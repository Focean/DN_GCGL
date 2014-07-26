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

namespace GCGL_Client.Common
{
    public partial class Cmn_TreeBox : Form
    {
        public Cmn_TreeBox()
        {
            InitializeComponent();
           
            this.OnlySelectMx = true;
        }

        public Boolean BuildTree(string ATreeName, object ADataSource, string ANodeID, string ANodePID, string ANodeTitle)
        {
            this.Text = ATreeName;

            this.dbTreeView.NodeID = ANodeID;
            this.dbTreeView.NodePID = ANodePID;
            this.dbTreeView.NodeTitle = ANodeTitle;
            this.dbTreeView.DataSource = ADataSource;
            this.dbTreeView.BuildTrees();
            //
            return this.dbTreeView.Nodes.Count > 0;
        }

        public Boolean OnlySelectMx { get; set; }

        private string _SelectNodeID;
        public string SelectNodeID
        {
            get { return _SelectNodeID; }
            set
            {
                _SelectNodeID = value;
                DBTreeNode fNode = this.dbTreeView.FindTreeNode(_SelectNodeID);
                if (fNode != null)
                {
                    _SelectNodeTitle = fNode.Text;
                    //fNode.se
                }
                else
                {
                    _SelectNodeTitle = "";
                }
            }
        }

        public string _SelectNodeTitle;
        public string SelectNodeTitle { get { return _SelectNodeTitle; } }

        public string FindNodeTitle(string ANodeID)
        {
            DBTreeNode fNode = this.dbTreeView.FindTreeNode(ANodeID);
            if (fNode != null)
            {
                return fNode.Text;
                //fNode.se
            }
            else
            {
                return "";
            }
        }

        public void SetShowParam(Control AControl, int AShowWidth)
        {
            //恢复成默认值吧，以后每次调用再自己设置
            this.OnlySelectMx = true;
            //
            this.Left = AControl.PointToScreen(new Point(0, 0)).X;
            this.Top = AControl.PointToScreen(new Point(0, 0)).Y + AControl.Height;
            if (AShowWidth == 0)
                this.Width = AControl.Width;
            else
                this.Width = AShowWidth;
        }

        private void dbTreeView_TreeNodeCreated(object sender, TreeNodeCreatedEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        public void GetFirstChildNode()
        {
            _SelectNodeID = "";
            _SelectNodeTitle = "";

            if (this.dbTreeView.Nodes.Count == 0) return;
            TreeNode fNode = this.dbTreeView.Nodes[0];
            if (fNode == null) return;
            while (fNode.Nodes.Count > 0)
            {
                if (fNode.Nodes.Count > 0)
                {
                    fNode = fNode.Nodes[0];

                }
                else
                {
                    break;
                }
            }
            //
            if (fNode == null) return;
            _SelectNodeID = ((DBTreeNode)fNode).ID;
            _SelectNodeTitle = fNode.Text;
        }

        public void ExpandAll()
        {
            this.dbTreeView.ExpandAll();
        }

        private void dbTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
          //  if (this.OnlySelectMx && (e.Node.Nodes.Count > 0)) return;
            //
            _SelectNodeID = ((DBTreeNode)e.Node).ID;
            _SelectNodeTitle = e.Node.Text;
            //
            this.DialogResult = DialogResult.OK;

        }
        DataRow dr;
        public void DB_View(string Code)
        {
            DataRow row = null;
            try
            {
                var dtm = new Ref_WS_GCGL.DataType_CMN_单位();
                dtm.单位编码 = Code;
                dtm.ExAction = "GetSubList";
                if (!AppServer.WcfService_Open()) return;
                DataTable table = AppServer.wcfClient.CMN_单位_List(ref dtm).Tables[0];
                if (table.Rows.Count == 0) return;
                row = table.Rows[0];
                dr = table.Rows[0];
                TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
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
        private void dbTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(this.Text=="单位信息")
               this.DB_View(this.dbTreeView.SelectedNode.ID);//获取单位的信息
            if (dbTreeView.SelectedNode.Nodes.Count > 0) return;//若有子节点则不再加载
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
                if (!string.IsNullOrEmpty(((DBTreeNode)e.Node).ID))
                {
                    DBTreeNode node = this.dbTreeView.FindTreeNode(((DBTreeNode)e.Node).ID);
                    if (node != null) this.dbTreeView.SelectedNode = node;
                }
                e.Node.Expand();
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
    }
}
