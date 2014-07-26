using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DingnuoControlLibrary;
using TY.Helper;

namespace GCGL_Client.Main
{
    public partial class Man_UserMngr : Form
    {
        public Man_UserMngr()
        {
            InitializeComponent();
            //设置表格样式
            AppServer.SetGridViewStyle(this.dbGridView);
        }

        private void Man_UserMngr_Load(object sender, EventArgs e)
        {
            this.DataBinding_dbTreeView();
            //
            this.ChangeUnitParam("InitData", "");
        }

        private string FCurrUnitCode;
        private void ChangeUnitParam(string AUnitCode, string AUnitName)
        {
            if ((AUnitCode == "InitData") && (this.dbTreeView.SelectedNode != null))
            {
                AUnitCode = ((DBTreeNode)this.dbTreeView.SelectedNode).ID;
                AUnitName = this.dbTreeView.SelectedNode.Text;
                if (this.dbTreeView.SelectedNode.Parent != null)
                    AUnitName = this.dbTreeView.SelectedNode.Parent.Text + AUnitName;
            }

            FCurrUnitCode = AUnitCode;
            this.lblTitle.Text = string.Format("{0}_用户列表", AUnitName);
            //
            this.DataBinding_dbGridView(0);
        }

        //获取_树形显示
        private void DataBinding_dbTreeView()
        {
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_CMN_单位();
                model.ExAction = "UserMngrUnit";
                model.单位编码 = AppServer.LoginUnitCode;
                model.区划编码 = AppServer.LoginAreaCode;
                model.LoginUserCode = AppServer.LoginUserCode;

                this.dbTreeView.NodeID = "单位编码";
                this.dbTreeView.NodePID = "上级编码";
                this.dbTreeView.NodeTitle = "单位名称";
                this.dbTreeView.DataSource = AppServer.wcfClient.CMN_单位_List(ref model).Tables[0];
                this.dbTreeView.BuildTrees();
                this.dbTreeView.ExpandAll();
                if (this.dbTreeView.Nodes.Count > 0)
                    this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_Error(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }
        }

        public void DataBinding_dbGridView(int ACurrRowIndex)
        {
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var dtm = new Ref_WS_GCGL.DataType_User();
                dtm.ExAction = "List";
                dtm.UnitCode = FCurrUnitCode;
                this.dbGridView.DataSource = AppServer.wcfClient.Sys_User_List(dtm).Tables[0];
                this.dbGridView.GoToRowByIndex(ACurrRowIndex);
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

        private void dbTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.ChangeUnitParam(((DBTreeNode)e.Node).ID, e.Node.Text);
        }

        private void dbTreeView_TreeNodeCreated(object sender, TreeNodeCreatedEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void btnUser_Add_Click(object sender, EventArgs e)
        {
            using (var form = new Man_UserMngr_Editor())
            {
                form.Visible = false;
                form.Editor_Add(this.FCurrUnitCode);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_dbGridView(-1);
                }
            }
        }

        private void btnUser_Mod_Click(object sender, EventArgs e)
        {
            if ((dbGridView.Rows.Count == 0) || (dbGridView.SelectedRows.Count == 0)) return;
            string sUserCode = this.dbGridView.CurrentRow.Cells["UserCode"].Value.ToString().Trim();
            DataRow row = (this.dbGridView.DataSource as DataTable).Rows[this.dbGridView.CurrentRow.Index];

            using (var form = new Man_UserMngr_Editor())
            {
                form.Visible = false;
                form.Editor_Mod(sUserCode, row);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_dbGridView(this.dbGridView.CurrentRow.Index);
                }
            }
        }

        private void btnUser_Del_Click(object sender, EventArgs e)
        {
            if ((dbGridView.Rows.Count == 0) || (dbGridView.SelectedRows.Count == 0)) return;
            if (!AppServer.DialogMsg("确认要删除当前用户吗？", "删除确认")) return;

            string sUserCode = this.dbGridView.CurrentRow.Cells["UserCode"].Value.ToString().Trim();
            //开始删除
            base.Cursor = Cursors.WaitCursor;
            try
            {
                var dmt = new Ref_WS_GCGL.DataType_User();
                dmt.UserCode = sUserCode;
                dmt.ExAction = "Del";

                if (!AppServer.WcfService_Open()) return;
                //
                AppServer.wcfClient.Sys_User_Edit(ref dmt);

                if (dmt.ExResult != 0)
                {
                    AppServer.ShowMsg_Error(dmt.ErrorMsg);
                    return;
                }
                this.DataBinding_dbGridView(this.dbGridView.CurrentRow.Index - 1);
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_SubmitError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }
        }

        private void btnUser_Rgt_Click(object sender, EventArgs e)
        {
            if ((dbGridView.Rows.Count == 0) || (dbGridView.SelectedRows.Count == 0)) return;
            string sUserCode = this.dbGridView.CurrentRow.Cells["UserCode"].Value.ToString().Trim();
            string sUserName = this.dbGridView.CurrentRow.Cells["UserName"].Value.ToString().Trim();
            string sRoleList = this.dbGridView.CurrentRow.Cells["RoleList"].Value.ToString().Trim();

            using (var form = new Man_UserRole())
            {
                form.Visible = false;
                form.Editor_Mod(sUserCode, sUserName, sRoleList);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_dbGridView(this.dbGridView.CurrentRow.Index);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
