using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DingnuoControlLibrary;

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
            if (this.OnlySelectMx && (e.Node.Nodes.Count > 0)) return;
            //
            _SelectNodeID = ((DBTreeNode)e.Node).ID;
            _SelectNodeTitle = e.Node.Text;
            //
            this.DialogResult = DialogResult.OK;

        }
    }
}
