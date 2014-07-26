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
            Select_查询单位();
        }

        public void Select_查询单位()
        {
            this.Text = "查询单位选择";
            this.Tag = "查询单位";
            //
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_CMN_单位();
                model.ExAction = "GetSubList";
                if (AppServer.LoginUnitType == 1 || AppServer.LoginUnitType == 2)
                {
                    model.单位编码 = AppServer.LoginUnitCode;
                }
                DataTable table = AppServer.wcfClient.CMN_单位_List(ref model).Tables[0];
                //
                this.dbTreeView.NodeID = "单位编码";
                this.dbTreeView.NodePID = "上级编码";
                this.dbTreeView.NodeTitle = "单位名称";
                this.dbTreeView.DataSource = AppServer.wcfClient.CMN_单位_List(ref model).Tables[0];
                this.dbTreeView.BuildTrees();
                if (this.dbTreeView.Nodes.Count > 0)
                {
                    this.dbTreeView.Nodes[0].Expand();
                    this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
                }
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
