using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.Main;
using GLG.Common;
using TY.Helper;
using GCGL_Client.NET;
namespace GCGL_Client.OCC
{
    public partial class OCC_公车出库 : Form
    {
        public OCC_公车出库()
        {
            InitializeComponent();
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

           if (AppServer.LoginUnitType >= 2&&AppServer.LoginUnitType<8)
           {
               this.btn报废.Enabled = false;
               this.btn出售出库.Enabled = false;
               this.btn删除.Enabled = false;
               this.btn调拨.Enabled = false;
               this.btn修改.Enabled = false;
           }
        }

        private void OCC_公车出库_Load(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
        }

        #region 数据绑定自定义方法
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车出库();
                model.ExAction = "List";
                model.开始时间 = this.dtp开始时间.Value;
                model.结束时间 = this.dtp结束时间.Value;
                if (this.txt选择单位.Tag == null || this.txt选择单位.Tag.ToString() == "")
                    model.单位编码 = AppServer.LoginUnitCode;
                else
                {
                    model.单位编码 = this.txt选择单位.Tag.ToString();
                    model.包含下级 = this.chk包含下级.Checked;
                }
                DataSet db = AppServer.wcfClient.OCC_公车出库_List(ref model);
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
        #endregion
 
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

        private void btn报废_Click(object sender, EventArgs e)
        {
            using (var form = new OCC_公车出库_报废())
            {
                form.Editor_Add();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据     
                    this.DataBinding_GridView(this.dgvList.Rows.Count);

                }
            }
        }

        private void btn调拨_Click(object sender, EventArgs e)
        {
            using (var form = new OCC_公车出库_调拨())
            {
                form.Editor_Add();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据     
                    this.DataBinding_GridView(this.dgvList.Rows.Count);

                }
            }
        }
        private void btn出售出库_Click(object sender, EventArgs e)
        {
            using (var form = new OCC_公车出库_出售())
            {
                form.Editor_Add();
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
                if (row["处置形式编码"].ToString() == "01")
                using (var form = new OCC_公车出库_调拨())
                {
                    form.Editor_Mod(row["出库单编码"].ToString());
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        //更新数据
                        this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                    }
                }
                if (row["处置形式编码"].ToString() == "02")
                    using (var form = new OCC_公车出库_报废())
                    {
                        form.Editor_Mod(row["出库单编码"].ToString());
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            //更新数据
                            this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                        }
                    }
                if (row["处置形式编码"].ToString() == "03")
                    using (var form = new OCC_公车出库_出售())
                    {
                        form.Editor_Mod(row["出库单编码"].ToString());
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

                    var dtm = new Ref_WS_GCGL.DataType_OCC_公车出库();
                    dtm.ExAction = "Del";
                    dtm.出库单编码 = row["出库单编码"].ToString();
                    if (!AppServer.WcfService_Open()) return;
                    AppServer.wcfClient.OCC_公车出库_Edit(ref dtm);
                    if (dtm.ExResult == 0)
                    {
                        this.DataBinding_GridView(this.dgvList.CurrentRow.Index - 1);
                    }
                    else
                        AppServer.ShowMsg_Error(dtm.ErrorMsg, "错误");
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
         
            if (row["处置形式编码"].ToString() == "01")
                using (var form = new OCC_公车出库_调拨())
                {
                    form.Editor_See(row["出库单编码"].ToString());
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        //更新数据
                        this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                    }
                }
             if (row["处置形式编码"].ToString() == "02")
                    using (var form = new OCC_公车出库_报废())
                    {
                        form.Editor_See(row["出库单编码"].ToString());
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            //更新数据
                            this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                        }
                    }
            if (row["处置形式编码"].ToString() == "03")
                 using (var form = new OCC_公车出库_出售())
                 {
                     form.Editor_See(row["出库单编码"].ToString());
                     if (form.ShowDialog() == DialogResult.OK)
                     {
                         //更新数据
                         this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                     }
                 }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

       

        private void btn附件查看_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            //
            string wCode = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index]["附件编码"].ToString();
            if (wCode == null) return;
            using (var form = new NET_附件管理())
            {
                form.Editor_See(wCode);
                form.ShowDialog();
            }
        }

        private void btn导出_Click(object sender, EventArgs e)
        {

        }

        private void btn打印_Click(object sender, EventArgs e)
        {

        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
