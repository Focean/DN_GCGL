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
            if (AppServer.LoginUnitType == 0)
            {
                this.btn重置密码.Visible = true;
            }
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

            if (AUnitCode == "410001_CZT") this.btn分管.Visible = true;  //若是资产处则有单位分管功能,否则没有
            else this.btn分管.Visible = false;

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
                if (AppServer.LoginUnitIsQH()&&!AppServer.LoginUserIsQH())
                {
                    var model = new Ref_WS_GCGL.DataType_CMN_行政区划();
                    model.ExAction = "List";
                    model.区划编码 = AppServer.LoginAreaCode;
                    this.dbTreeView.NodeID = "编码";
                    this.dbTreeView.NodePID = "上级编码";
                    this.dbTreeView.NodeTitle = "全名";
                    this.dbTreeView.DataSource = AppServer.wcfClient.CMN_行政区划_List(ref model).Tables[0];
                    this.dbTreeView.BuildTrees();
                    this.dbTreeView.ExpandAll();
                    if (this.dbTreeView.Nodes.Count > 0)
                        this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
                }
                else
                {
                    var model = new Ref_WS_GCGL.DataType_CMN_单位();
                    model.ExAction = "UnitMngrTree";
                    model.LoginUserCode = AppServer.LoginUserCode;
                    model.区划编码 = AppServer.LoginAreaCode;
                    model.单位编码 = AppServer.LoginUnitCode;
                    model.单位类型编码 = AppServer.LoginUnitType;
                    this.dbTreeView.NodeID = "单位编码";
                    this.dbTreeView.NodePID = "上级编码";
                    this.dbTreeView.NodeTitle = "单位全名";
                    this.dbTreeView.DataSource = AppServer.wcfClient.CMN_单位_List(ref model).Tables[0];
                    this.dbTreeView.BuildTrees();
                    this.dbTreeView.ExpandAll();
                    if (this.dbTreeView.Nodes.Count > 0)
                        this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
                }
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
                if (AppServer.LoginUserIsXT())
                    dtm.UnitCode = FCurrUnitCode + "_";
                else
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

            string sUserCode = this.dbGridView.CurrentRow.Cells["UserCode"].Value.ToString().Trim();
            if (AppServer.LoginUserCode == sUserCode)
            {
                AppServer.ShowMsg_Warn("您不能删除自己！", "警告");
                return;
            }

            if (!AppServer.DialogMsg("确认要删除当前用户吗？", "删除确认")) return;
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
            if (AppServer.LoginUserCode == sUserCode)
            {
                AppServer.ShowMsg_Warn("您不能修改自己的权限！", "警告");
                return;
            }
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
        //加载子节点
        private void dbTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //if (AppServer.LoginUnitType == 0) return;//区划管理只能添加主管和财政厅、公物仓、纪委的管理员，不能添加预算单位管理员
            if (dbTreeView.SelectedNode.Nodes.Count > 0) return;//若有子节点则不再加载

            //
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var ml = new Ref_WS_GCGL.DataType_CMN_单位();
                ml.ExAction = "GetSubUnit";
                ml.单位编码 = this.dbTreeView.SelectedNode.ID;
                DataTable dt = AppServer.wcfClient.CMN_单位_List(ref ml).Tables[0];
                if (dt.Rows.Count == 0) return;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DBTreeNode newnode = new DBTreeNode();
                    newnode.Text = dt.Rows[i]["单位全名"].ToStringDef();
                    newnode.ID = dt.Rows[i]["单位编码"].ToStringDef();
                    this.dbTreeView.SelectedNode.Nodes.Add(newnode);
                }
                this.dbTreeView.ExpandAll();
                if (!string.IsNullOrEmpty(((DBTreeNode)e.Node).ID))
                {
                    DBTreeNode node = this.dbTreeView.FindTreeNode(((DBTreeNode)e.Node).ID);
                    if (node != null) this.dbTreeView.SelectedNode = node;
                }
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

        private void btn分管_Click(object sender, EventArgs e)
        {
            if ((dbGridView.Rows.Count == 0) || (dbGridView.SelectedRows.Count == 0)) return;
            string sUserCode = this.dbGridView.CurrentRow.Cells["UserCode"].Value.ToString().Trim();
            string sUserName = this.dbGridView.CurrentRow.Cells["UserName"].Value.ToString().Trim();
            int sRoleList =Convert.ToInt32(this.dbGridView.CurrentRow.Cells["UserType"].Value.ToString().Trim());
            if (sRoleList != 3)
            {
                AppServer.ShowMsg("该用户不用添加分管单位", "提示");
                return;
            }
            using (var form = new Man_UserDep_Editor())
            {
                form.Editor_Mod(sUserCode);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_dbGridView(this.dbGridView.CurrentRow.Index);
                }
            }
        }

        private void btn重置密码_Click(object sender, EventArgs e)
        {
            if ((dbGridView.Rows.Count == 0) || (dbGridView.SelectedRows.Count == 0)) return;

            string sUserCode = this.dbGridView.CurrentRow.Cells["UserCode"].Value.ToString().Trim();
            if (!AppServer.DialogMsg("确认要重置当前用户(" + sUserCode + ")的密码吗？", "重置确认")) return;
            DataRow row = (this.dbGridView.DataSource as DataTable).Rows[this.dbGridView.CurrentRow.Index];

            //开始删除
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var dmt = new Ref_WS_GCGL.DataType_User();
                dmt.UserCode = sUserCode;
                dmt.ExAction = "RePwd";             
                //
                AppServer.wcfClient.Sys_User_Edit(ref dmt);
                
                if (dmt.ExResult != 0)
                {
                    AppServer.ShowMsg_Error(dmt.ErrorMsg);
                    return;
                }
                if (dmt.UserPswd != null)
                {
                    AppServer.ShowMsg("重置的密码为："+dmt.UserPswd,"提示");
                }
                this.DataBinding_dbGridView(this.dbGridView.CurrentRow.Index);
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

    }
}
