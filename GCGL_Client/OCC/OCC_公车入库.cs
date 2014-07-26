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
using TY.Common;

namespace GCGL_Client.OCC
{
    public partial class OCC_公车入库 : Form
    {
        public OCC_公车入库()
        {
            InitializeComponent();
           //
            this.dtp开始时间.Value = DateTime.Today.AddDays(1 - DateTime.Today.DayOfYear);
            this.dtp结束时间.Value = DateTime.Today;         

            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            DataBinding_GridView(0);
            //
            if (AppServer.UserQxMenuList.Rows.Contains("031202"))
            {
                this.btn购置.Visible = true;
                this.btn删除.Visible = true;
                this.btn修改.Visible = true;
                this.btn入户登记.Visible = true;
            }
            if (AppServer.UserQxMenuList.Rows.Contains("031203"))
            {
                this.btn调拨.Visible = true;
                this.btn删除.Visible = true;
                this.btn修改.Visible = true;
            }
            //
            this.btn第一页.Enabled = AppServer.Sys_Param.PageRows > 0;
            this.btn上一页.Enabled = AppServer.Sys_Param.PageRows > 0;
            this.btn下一页.Enabled = AppServer.Sys_Param.PageRows > 0;
            this.btn末一页.Enabled = AppServer.Sys_Param.PageRows > 0;
            this.nudPageIndex.Enabled = AppServer.Sys_Param.PageRows > 0;
            //
            if (AppServer.LoginUnitIsGWC())
            {
                this.btn预算单位.Visible = false;
                this.txt单位编码.Tag = "410001_GWC";
                this.txt单位编码.Text = "省公物仓";
                this.chk包含下级.Visible = false;
            }
            if (AppServer.LoginUnitIsYSDW())
            {
                this.btn预算单位.Visible = false;
                this.txt单位编码.Tag = AppServer.LoginUnitCode;
                this.txt单位编码.Text = AppServer.LoginUnitName;
                this.chk包含下级.Visible = false;
                this.dgvList.Columns["单位名称"].Visible = false;
            }
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
                model.未完成 = this.chk未完成.Checked;
                model.PageRows = AppServer.Sys_Param.PageRows;
                model.PageIndex = this.nudPageIndex.Value.ToIntegerDef(1);
                if (AppServer.LoginUnitIsYSDW() || AppServer.LoginUnitIsGWC())
                {
                    model.单位编码 = AppServer.LoginUnitCode;
                }
                else if (this.txt单位编码.Tag != null)
                {
                    model.单位编码 = this.txt单位编码.Tag.ToString();
                    model.包含下级 = this.chk包含下级.Checked;
                }
                DataSet db = AppServer.wcfClient.OCC_公车入库_List(ref model);
                
                if (AppServer.Sys_Param.PageRows > 0)
                {
                    this.lblDataInfo.Text = string.Format("共 {0} 条记录，每页 {1} 条，共 {2} 页", model.RowsCount, model.PageRows, model.PageCount);
                    this.nudPageIndex.Maximum = model.PageCount == 0 ? 1 : model.PageCount;
                }
                else
                {
                    this.lblDataInfo.Text = string.Format("共 {0} 条记录", model.RowsCount);
                }
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
          if (AppServer.LoginUnitIsGWC())
            {
                using (var form = new OCC_公车入库_Editor())
                {
                    form.Editor_Add(null);
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
        private void btn入户登记_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;

            if (row["exWaitState2"].ToString() == "等待入户登记")
            {
                if (row["入库类型"].ToString() == "新购")
                    using (var form = new OCC_公车入库_Editor())
                    {
                        form.Editor_Mod(row["资产编号"].ToString(), row["入库单编码"].ToString(),"入户");
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            //更新数据
                            this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                        }
                    }
                if (row["入库类型"].ToString() == "调拨")
                    using (var form = new OCC_公车入库_Editor())
                    {
                        form.Editor_Accept(row, row["入库单编码"].ToString(), 1);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            //更新数据
                            this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                        }
                    }
            }
            else
            {
                AppServer.ShowMsg_Warn("该申请不需要入户登记！", "警告");
                return;
            }
        }
        private void btn修改_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;

            if (row["exWaitState2"].ToString() == "等待提交" || row["exWaitState2"].ToString() == "等待重新提交" || row["exWaitState2"].ToString() == "等待入户登记")
            {
                if (row["入库类型"].ToString() == "新购")
                    using (var form = new OCC_公车入库_Editor())
                    {
                        if (row["exWaitState2"].ToString() == "等待入户登记" )
                        {
                            form.Editor_Mod(row["资产编号"].ToString(), row["入库单编码"].ToString(),"入户");
                        }
                        else if (row["配置申请编号"].ToString() == "")
                        {
                            form.Editor_Mod(row["资产编号"].ToString(), row["入库单编码"].ToString(), "导入");
                        }
                        else
                        {
                            form.Editor_Mod(row["资产编号"].ToString(), row["入库单编码"].ToString(), "购置");
                        }
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            //更新数据
                            this.DataBinding_GridView(0);
                        }
                    }
                if (row["入库类型"].ToString() == "调拨")
                    using (var form = new OCC_公车入库_Editor())
                    {
                        form.Editor_Accept(row, row["入库单编码"].ToString(),1);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            //更新数据
                            this.DataBinding_GridView(0);
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
            if (row["exWaitState2"].ToString() == "等待提交" || row["exWaitState2"].ToString() == "等待重新提交" )
            {
                if (AppServer.DialogMsg("是否确认删除？", " "))
                {
                    var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                    model.ExAction = "Del";
                    model.入库单编码 = row["入库单编码"].ToString();
                    model.LoginUserCode = AppServer.LoginUserCode;
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
                AppServer.ShowMsg_Warn("该申请已被审核，无法删除！", "警告");
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

                if (row["exWaitState2"].ToString() == "等待入户登记")
                {
                    form.Editor_See(row["入库单编码"].ToString(), "入户");
                }
                else if (row["配置申请编号"].ToString() == "")
                {
                    form.Editor_See(row["入库单编码"].ToString(), "导入");
                }
                else
                {
                    form.Editor_See(row["入库单编码"].ToString(), "购置");
                }
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                  //  this.DataBinding_GridView(0);
                }
            }

          

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }
        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            if (row["exWaitState2"].ToString() == "等待提交" || row["exWaitState2"].ToString() == "等待重新提交" || row["exWaitState2"].ToString() == "等待入户登记")
            {
                this.btn修改.PerformClick();
            }
            else
            {
                this.btn查看.PerformClick();
            }
        }

        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.dgvList, this.lblTitle.Text);
        }
        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn审批意见_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new GCGL_Client.NET.NET_审批中心_Flow())
            {
                form.Editor_See(row["审批流程编码"].ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void btn对比_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            new OCC_公车入库_对比(row["资产编号"].ToString()).ShowDialog();

        }

        private void btn预算单位_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(2);
            AppServer.Frm单位信息.SetShowParam(this.txt单位编码, 0);
            AppServer.Frm单位信息.ShowDialog();
            if (AppServer.Frm单位信息.DialogResult == DialogResult.OK)
            {
                this.txt单位编码.Tag = AppServer.Frm单位信息.SelectNodeID;
                this.txt单位编码.Text = AppServer.Frm单位信息.SelectNodeTitle;
            }
            AppServer.Frm单位信息.Hide();
        }

        private void chk未完成_CheckedChanged(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void btn第一页_Click(object sender, EventArgs e)
        {
            this.nudPageIndex.Value = 1;
        }

        private void btn上一页_Click(object sender, EventArgs e)
        {
            if (this.nudPageIndex.Value <= 1) return;
            this.nudPageIndex.Value = this.nudPageIndex.Value - 1;
        }

        private void btn下一页_Click(object sender, EventArgs e)
        {
            if (this.nudPageIndex.Value >= this.nudPageIndex.Maximum) return;
            this.nudPageIndex.Value = this.nudPageIndex.Value + 1;
        }

        private void btn末一页_Click(object sender, EventArgs e)
        {
            this.nudPageIndex.Value = this.nudPageIndex.Maximum;
        }

        private void nudPageIndex_ValueChanged(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
        }

    }
}
