using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DingnuoControlLibrary;

namespace GCGL_Client.FZB
{
    public partial class FZB_行政区划 : Form
    {


        public FZB_行政区划()
        {
            InitializeComponent();
        }
        private void BZ_行政区划_Load(object sender, EventArgs e)
        {
            this.dbGridView_DataBinding(0);
        }

        private void dbGridView_DataBinding(int ACurrentIndex)
          {
              try
              {
                  if (!AppServer.WcfService_Open()) return;
                  dtvTreeView.CheckBoxs = false;
                  dtvTreeView.MultiSelect = false;
                  var model = new Ref_WS_GCGL.DataType_CMN_行政区划();
                  model.ExAction = "List";
                  dtvTreeView.DataSource = AppServer.wcfClient.CMN_行政区划_List(ref model).Tables[0];
                  dtvTreeView.BuildTrees();
                  dtvTreeView.ExpandAll();
                  //选中首节点
                  if (dtvTreeView.Nodes.Count > 0)
                  {
                      dtvTreeView.Nodes[0].Expand();
                      dtvTreeView.SelectedNode = (DBTreeNode)dtvTreeView.Nodes[ACurrentIndex];
                  }
              }
              finally
              {
                  AppServer.WcfService_Close();
                  base.Cursor = Cursors.Arrow;
              }
          }
        private void Btn增加_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrEmpty(AppServer.LoginUnitCode))
            {
                AppServer.ShowMsg_Warn("您可能是系统管理员，不属于指定征收机关的用户无法新建行政区划！");
                return;
            }
            string APCode;
            if (dtvTreeView.SelectedNode == null)
            {
                if (dtvTreeView.Nodes.Count > 0)
                {
                    AppServer.ShowMsg_Error("请选择一个树结点再创建下级行政区划！");
                    return;
                }
                APCode = "";
            }
            else
                APCode = dtvTreeView.SelectedNode.ID;
            FZB_行政区划_Editor form = new FZB_行政区划_Editor("Add", APCode);
            form.Owner = this;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                this.dbGridView_DataBinding(this.dtvTreeView.SelectedNode.Index);
            }
        }

        private void Btn删除_Click(object sender, EventArgs e)
        {
            if (dtvTreeView.SelectedNode == null) return;
            if (dtvTreeView.SelectedNode.Nodes.Count > 0)
            {
                AppServer.ShowMsg_Warn("当前行政区划存在下级，请先删除下级！");
                return;
            }
            if (!AppServer.DialogMsg("删除将是不可恢复的操作，确定继续吗？　")) return;
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_行政区划();
                model.ExAction = "Del";
                model.区划编码 = dtvTreeView.SelectedNode.ID;
                AppServer.wcfClient.CMN_行政区划_Edit(ref model);

                if (model.ExResult!=0)
                {
                    AppServer.ShowMsg_Error(model.ErrorMsg);
                    return;
                }
                this.dbGridView_DataBinding(this.dtvTreeView.SelectedNode.Index-1);
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

        private void Btn修改_Click(object sender, EventArgs e)
        {
            if (dtvTreeView.SelectedNode == null) return;
            DataRow Dr = (dtvTreeView.DataSource as DataTable).NewRow();
            foreach (DataRow r in (dtvTreeView.DataSource as DataTable).Rows)
            {
                if (r["编码"].ToString() == dtvTreeView.SelectedNode.ID)
                {
                    Dr = r;
                    break;
                }
            }
            FZB_行政区划_Editor form = new FZB_行政区划_Editor("Mod", null, Dr);
            form.Owner = this;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                this.dbGridView_DataBinding(this.dtvTreeView.SelectedNode.Index);
            }
        }

        private void Btn刷新_Click(object sender, EventArgs e)
        {
            this.dbGridView_DataBinding(0);  
        }

        private void Btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtvTreeView_TreeNodeCreated(object sender, TreeNodeCreatedEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

      
    }
}
