﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Common;
using TY.Helper;
using System.Globalization;
using GCGL_Client.Main;

namespace GCGL_Client.OCC
{
    public partial class OCC_配置申请 : Form
    {
        public OCC_配置申请()
        {
            InitializeComponent();
            //
            AppServer.SetGridViewStyle(this.dgvList);
            //
            this.dtp结束时间.Value = DateTime.Now;
            this.dtp开始时间.Value = DateTime.Now.AddMonths(-1);
            //
            if (AppServer.UserQxMenuList.Rows.Contains("031102"))
            {
                this.btn撤销.Visible = true;
                this.btn删除.Visible = true;
                this.btn新增.Visible = true;
                this.btn修改.Visible = true;
                this.btn打印备案.Visible = true;
            }
            this.DataBinding_GridView(0);
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
            }
        }

        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_配置申请();
                model.ExAction = "List";
                model.开始时间 = this.dtp开始时间.Value;
                model.结束时间 = this.dtp结束时间.Value;
                if (AppServer.LoginUnitType == 1 || AppServer.LoginUnitType == 8)
                {
                    model.单位编码 = AppServer.LoginUnitCode;
                }
                else if (this.txt单位编码.Tag != null)
                {
                    model.单位编码 = this.txt单位编码.Tag.ToString();
                    model.包含下级 = this.chk包含下级.Checked;
                }
                DataSet db = AppServer.wcfClient.OCC_配置申请_List(ref model);
                DataTable table = db.Tables[0];
                this.dgvList.DataSource = table;
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
        private void UpdateGridView()
        {
            this.DataBinding_GridView(0);
        }

        #region 功能按钮
        private void btn新增_Click(object sender, EventArgs e)
        {
            using (var form = new OCC_配置申请_Editor())
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
            if (row["exWaitState2"].ToString() == "等待提交" || row["exWaitState2"].ToString() == "等待重新提交")
            {
                using (var form = new OCC_配置申请_Editor())
                {
                    form.Editor_Mod(row["申请编号"].ToString());
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        //更新数据
                        this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                    }
                }
            }
            else
            {
                AppServer.ShowMsg_Warn("该申请已经提交，无法修改！", "警告");
                return;
            }
        }

        private void btn删除_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (row["exWaitState2"].ToString() != "等待提交" && row["exWaitState2"].ToString() != "等待重新提交")
            {
                AppServer.ShowMsg_Warn("该申请已经提交，无法删除！", "警告");
                return;
            }
            if (AppServer.DialogMsg("是否确认删除？", " "))
            {
                var dtm = new Ref_WS_GCGL.DataType_OCC_配置申请();
                dtm.ExAction = "Del";
                dtm.申请编号 = row["申请编号"].ToString();
                if (!AppServer.WcfService_Open()) return;
                AppServer.wcfClient.OCC_配置申请_Edit(ref dtm);
                if (dtm.ExResult == 0)
                {
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index - 1);
                }
                else
                    AppServer.ShowMsg_Error(dtm.ErrorMsg, "错误");
            }
            else return;
        }
        //

        private void btn撤销_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (row["exWaitState2"].ToString() != "等待提交" && row["exWaitState2"].ToString() != "等待主管单位审核")
            {
                AppServer.ShowMsg_Warn("该申请已经开始审核，无法撤销！", "警告");
                return;
            }
            if (AppServer.DialogMsg("是否确认撤销？", " "))
            {
                var dtm = new Ref_WS_GCGL.DataType_OCC_配置申请();
                dtm.ExAction = "GoBack";
                dtm.申请编号 = row["申请编号"].ToString();
                if (!AppServer.WcfService_Open()) return;
                AppServer.wcfClient.OCC_配置申请_Edit(ref dtm);
                if (dtm.ExResult == 0)
                {
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                }
                else
                    AppServer.ShowMsg_Error(dtm.ErrorMsg, "错误");
            }
            else return;
        }

        private void btn查看_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new OCC_配置申请_Editor())
            {
                form.Editor_See(row["申请编号"].ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                }
            }
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
        }

        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.dgvList, this.lblTitle.Text);
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        //
        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (row["exWaitState2"].ToString() == "等待提交" || row["exWaitState2"].ToString() == "等待重新提交")
            {
                this.btn修改.PerformClick();
            }
            else
            {
                this.btn查看.PerformClick();
            }
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

        private void btn打印备案_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new OCC_配置申请_Editor())
            {
                form.Editor_Print(row["申请编号"].ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void btn刷新_Click(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
        }
    }
}
