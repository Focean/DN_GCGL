using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using System.Globalization;
using GCGL_Client.Main;
using GLG.Printer;
namespace GCGL_Client.OCC
{
    public partial class OCC_公车入库 : Form
    {
        public OCC_公车入库()
        {
            InitializeComponent();
            //
            if (AppServer.LoginUnitType < 3 || AppServer.LoginUnitType == 8)
            {
                this.txt选择单位.Text = AppServer.LoginUnitName;
                this.txt选择单位.Tag = AppServer.LoginUnitCode;
            }
            else
            {
                this.txt选择单位.Text = "所有单位";
                this.txt选择单位.Tag = "410000_";
            }
            this.dtp开始时间.Value = DateTime.Today.AddDays(1 - DateTime.Today.DayOfYear);
            this.dtp结束时间.Value = DateTime.Today;         

            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            DataBinding_GridView(0);
        }

        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                model.ExAction = "List";
                model.开始时间 = this.dtp开始时间.Value;
                model.结束时间 = this.dtp结束时间.Value;
                if (this.txt选择单位.Tag == null || this.txt选择单位.Tag.ToString() == "")
                    model.单位编码 =  AppServer.LoginUnitCode;
                else
                {
                    model.单位编码 = this.txt选择单位.Tag.ToString();
                    model.包含下级 = this.chk包含下级.Checked;
                }
                DataSet db = AppServer.wcfClient.OCC_公车入库_List(ref model);

                this.dgvList.DataSource = db.Tables[0];
                
                this.dgvList.GoToRowByIndex(ACurrRowIndex);
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }
        }

        private void btn购置_Click(object sender, EventArgs e)
        {
          if (AppServer.LoginUnitType == 8)
            {
                using (var form = new OCC_公车入库_Editor())
                {
                    form.Editor_Add();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        //更新数据     
                        this.DataBinding_GridView(0);
                    }
                }
            }  
         else
            using (var form = new OCC_配置申请_Select())
            {
                form.Select_DB();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据     
                    this.DataBinding_GridView(0);
                }
            }
        }

        private void btn调拨_Click(object sender, EventArgs e)
        {
            using (var form = new OCC_公车入库_调拨())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据     
                    this.DataBinding_GridView(this.dgvList.Rows.Count);
                }
            }
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (row["审批流程编码"].ToString() == "")
            {
                if (row["入库类型"].ToString() == "新购")
                    using (var form = new OCC_公车入库_Editor())
                    {
                        form.Editor_Mod(row["资产编号"].ToString(),row["入库单编码"].ToString());
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            //更新数据
                            this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                        }
                    }
                if (row["入库类型"].ToString() == "调拨")
                    using (var form = new OCC_公车入库_Editor())
                    {
                        form.Editor_Accept(row, row["入库单编码"].ToString(),1);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            //更新数据
                            this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                        }
                    }
            }
            else
            {
                AppServer.ShowMsg_Warn("该申请已被审核，无法修改！", "警告");
                return;
            }
        }

        private void btn删除_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (row["审批流程编码"].ToString() == "")
            {
                if (AppServer.DialogMsg("是否确认删除？", " "))
                {
                    var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                    model.ExAction = "Del";
                    model.入库单编码 = row["入库单编码"].ToString();
                    if (!AppServer.WcfService_Open()) return;
                    AppServer.wcfClient.OCC_公车入库_Edit(ref model);
                    if (model.ExResult == 0)
                    {
                        this.DataBinding_GridView(this.dgvList.CurrentRow.Index - 1);
                    }
                    else
                        AppServer.ShowMsg_Error(model.ErrorMsg, "错误");
                }
            }
            else
            {
                AppServer.ShowMsg_Warn("该申请已被审核，无法修改！", "警告");
                return;
            }
        }

        private void btn查看_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new OCC_公车入库_Editor())
            {
                form.Editor_See(row["入库单编码"].ToString());
                form.ShowDialog();
            }
        }

        private void btn选择单位_Click(object sender, EventArgs e)
        {
            using (var form = new Man_单位_Select())
            {
                form.Select_查询单位();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.txt选择单位.Text = form.SelectUnitName;
                    this.txt选择单位.Tag = form.SelectUnitCode;
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void btn打印_Click(object sender, EventArgs e)
        {
            //GLG_DGVPrinter printer = new GLG_DGVPrinter();
            //printer.Title = this.lblTitle.Text;
            ////  printer.SubTitle_L = " \n征收机关：" + AppServer.SysParam_征收机关名称;
            //printer.ShowTotalPageNumber = true;
            //printer.SetPrintPaper("A3", true);
            //printer.PrintPreviewNoDisplay(this.dgvList);
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
