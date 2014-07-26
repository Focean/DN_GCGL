using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using DingnuoControlLibrary;

namespace GCGL_Client.Main
{
    public partial class Man_单位_Select : Form
    {
        public Man_单位_Select()
        {
            InitializeComponent();
          
        }
        private void Man_单位_Select_Load(object sender, EventArgs e)
        {
            Select_查询单位();
        }
        public void Select_查询单位()
        {
            this.Text = "查询单位选择";
            this.Tag = "查询单位";
            ////
            this.dbTreeView.NodeID = "单位编码";
            this.dbTreeView.NodePID = "上级编码";
            this.dbTreeView.NodeTitle = "单位名称";
            this.dbTreeView.DataSource = AppServer.UdataTable;
            this.dbTreeView.BuildTrees();
            if (this.dbTreeView.Nodes.Count > 0)
            {
                this.dbTreeView.Nodes[0].Expand();
                this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
            }    
            //this.dbTreeView = AppServer.dbTreeView;
        }

        public string SelectUnitCode { get; set; }
        public string SelectUnitName { get; set; }

        private void btn选择_Click(object sender, EventArgs e)
        {
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (this.dbTreeView.SelectedNode == null) return;
                //
                this.SelectUnitCode = this.dbTreeView.SelectedNode.ID;
                this.SelectUnitName = this.dbTreeView.SelectedNode.Text;
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return;
            }
            finally
            {
                base.Cursor = Cursors.Arrow;
            }
            //
            this.DialogResult = DialogResult.OK;
        }

        private void dbTreeView_DoubleClick(object sender, EventArgs e)
        {
            this.btn选择.PerformClick();
        }

        private void dbTreeView_TreeNodeCreated(object sender, TreeNodeCreatedEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void dbTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.btn选择.PerformClick();
        }

        private void dbTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.btn选择.PerformClick();
        }

       
    }
}
