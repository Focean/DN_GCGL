using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using TY.Common;
using GCGL_Client.Main;
namespace GCGL_Client.OCC
{
    public partial class OCC_更新计划 : Form
    {
        public OCC_更新计划()
        {
            InitializeComponent();

            if (AppServer.UserQxMenuList.Rows.Contains("021102"))
            {
                this.btn删除.Enabled = true;
                this.btn新增.Enabled = true;
                this.btn修改.Enabled = true;
            }
            //
            this.tyGridView.BuildGrid(AppServer.GetTableDef(this.GetType().Name));
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

        private void SP_年度计划_Load(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_更新计划();
                model.ExAction = "List";
                if (AppServer.LoginUnitType == 1 || AppServer.LoginUnitType == 8)
                {
                    model.单位编码 = AppServer.LoginUnitCode;
                }
                else if (this.txt单位编码.Tag != null)
                {
                    model.单位编码 = this.txt单位编码.Tag.ToString();
                    model.包含下级 = this.chk包含下级.Checked;
                }
                DataSet db = AppServer.wcfClient.OCC_更新计划_List(ref model);
                DataTable table = db.Tables[0];
                this.tyGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
            }
        }

        public void Dep_Stop(string iRow)
        {
            if (iRow == null) return;
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_OCC_更新计划();
                model.ExAction = "Del";
                model.申请编号 = iRow;
                AppServer.wcfClient.OCC_更新计划_Edit(ref model);
            }
            catch (Exception ex)
            {
                AppServer.HideWaitForm();
                AppServer.ShowMsg_ExceptError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }
        }

        #region 功能按钮

        private void btn新增_Click(object sender, EventArgs e)
        {
            using (var form = new OCC_更新计划_Editor())
            {
                form.Editor_Add();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    this.DataBinding_GridView(0);
                }
            }
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if (this.tyGridView.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.tyGridView.DataSource).Rows[this.tyGridView.CurrentRow.Index];
            if (row == null) return;
            //
            if (row["exWaitState1"].ToString() == "等待提交" || row["exWaitState1"].ToString() == "等待重新提交")
            {
                using (var form = new OCC_更新计划_Editor())
                {
                    form.Editor_Mod(row);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        //更新数据
                        this.DataBinding_GridView(this.tyGridView.CurrentRow.Index);
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
            if (this.tyGridView.Rows.Count == 0) return;
            DataRow row1 = ((DataTable)this.tyGridView.DataSource).Rows[this.tyGridView.CurrentRow.Index];
            if (row1 == null) return;
            if (row1["exWaitState1"].ToString() == "等待提交" || row1["exWaitState1"].ToString() == "等待重新提交")
            {
                if (AppServer.DialogMsg("确定要删除该信息吗？"))
                {
                    string row = row1["申请编号"].ToString(); ;
                    Dep_Stop(row);
                }
                this.DataBinding_GridView(0);
            }
            else
            {
                AppServer.ShowMsg_Warn("该申请已经提交，无法删除！", "警告");
                return;
            }

        }

        private void btn查看_Click(object sender, EventArgs e)
        {
            if (this.tyGridView.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.tyGridView.DataSource).Rows[this.tyGridView.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new OCC_更新计划_Editor())
            {
                form.Editor_View(row["申请编号"].ToString(),false);
                if (form.ShowDialog() == DialogResult.OK) { }
            }
        }

        private void btn刷新_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.tyGridView, this.lbl年度更新计划列表.Text);
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void tyGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.tyGridView.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.tyGridView.DataSource).Rows[this.tyGridView.CurrentRow.Index];
            if (row == null) return;
            if (row["exWaitState1"].ToString() == "等待提交" || row["exWaitState1"].ToString() == "等待重新提交")
            {
                this.btn修改.PerformClick();
            }
            else
            {
                this.btn查看.PerformClick();
            }
        }

        private void cbx选择单位_SelectedValueChanged(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
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

        private void btn审批意见_Click(object sender, EventArgs e)
        {
            if (this.tyGridView.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.tyGridView.DataSource).Rows[this.tyGridView.CurrentRow.Index];
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
       
    }
}
