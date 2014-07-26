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
using GLG.Common;
namespace GCGL_Client.FZB
{
    public partial class FZB_单位设置 : Form
    {
        public FZB_单位设置()
        {
            InitializeComponent();
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            //预算单位
            if (AppServer.LoginUnitType == 1) 
            {
                this.btn新增.Enabled = false;
                this.btn修改.Enabled = false;
                this.btn删除.Enabled = false;
                this.btn添加处室.Enabled = true;
                this.btn修改处室.Enabled = true;
                this.btn删除处室.Enabled = true;
                //
                this.DataBinding_GridView(AppServer.LoginUnitCode.ToString(), 0);
            }
        }

        private void FZB_单位设置_Load(object sender, EventArgs e)
        {
            this.DataBinding_dbTreeView();
            //
            if (this.dbTreeView.Nodes.Count > 0)
            {
                this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
                this.DB_View(this.dbTreeView.SelectedNode.ID);
            }
        }     

        private void DataBinding_dbTreeView(string ANodeID = "")
        {
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_CMN_单位();
                model.ExAction = "UnitMngrTree";
                model.LoginUserCode = AppServer.LoginUserCode;
                model.区划编码 = AppServer.LoginAreaCode;
                model.单位编码 = AppServer.LoginUnitCode;
                this.dbTreeView.NodeID = "单位编码";
                this.dbTreeView.NodePID = "上级编码";
                this.dbTreeView.NodeTitle = "单位全名";
                this.dbTreeView.DataSource = AppServer.wcfClient.CMN_单位_List(ref model).Tables[0];
                this.dbTreeView.BuildTrees();
                this.dbTreeView.ExpandAll();
                //
                if (!string.IsNullOrEmpty(ANodeID))
                {
                    DBTreeNode node = this.dbTreeView.FindTreeNode(ANodeID);
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

        public void DataBinding_GridView(string ss, int Acurrent)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_CMN_单位_处室();
                model.ExAction = "List";
                model.单位编码 = ss;
                DataTable table = AppServer.wcfClient.CMN_单位_处室_List(ref model).Tables[0];
                this.dgvList.DataSource = table;
                //行定位
                this.dgvList.GoToRowByIndex(Acurrent);
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
               if (table.Rows.Count == 0)
               {
                   AppServer.ShowMsg("该单位没有信息！", "提示");
                   return;
               }
               row = table.Rows[0];
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

       private void btn新增_Click(object sender, EventArgs e)
       {
            string APCode;
            if (dbTreeView.SelectedNode.Level != 0)
            {
                AppServer.ShowMsg_Error("不能在预算单位下再创建下级单位！");
                return;
            }
            if (dbTreeView.SelectedNode == null)
            {
                if (dbTreeView.Nodes.Count > 0)
                {
                    AppServer.ShowMsg_Error("请选择一个树结点再创建下级单位！");
                    return;
                }
                APCode = "";
            }
            else
            {
                APCode = dbTreeView.SelectedNode.ID;
            }
            //
            using (var form = new FZB_单位设置_Editor())
            {
                form.Editor_Add(APCode);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_dbTreeView(form.UnitCode);
                }
            }
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if (dbTreeView.SelectedNode == null) return;
            string sNodeID = dbTreeView.SelectedNode.ID;
            DataRow row = (dbTreeView.DataSource as DataTable).Locate("单位编码", sNodeID);
            if (row == null) return;
            //
            using (var form = new FZB_单位设置_Editor())
            {
                form.Editor_Mod(row);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    this.DataBinding_dbTreeView(sNodeID);
                }
            }
        }

        private void btn删除_Click(object sender, EventArgs e)
        {
            if (dbTreeView.SelectedNode == null) return;
            if (dbTreeView.SelectedNode.Nodes.Count > 0)
            {
                AppServer.ShowMsg_Warn("当前单位存在下级，请先删除下级！");
                return;
            }
            if (!AppServer.DialogMsg("删除将是不可恢复的操作，确定继续吗？　")) return;
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_单位();
                model.ExAction = "Del";

                model.单位编码 = dbTreeView.SelectedNode.ID;
                AppServer.wcfClient.CMN_单位_Edit(ref model);

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
            //
            this.DataBinding_dbTreeView();
        }
        private void dbTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (dbTreeView.SelectedNode != null)
            {
                DataBinding_GridView(((DBTreeNode)e.Node).ID,0);
                DB_View(((DBTreeNode)e.Node).ID);

            }
        }

        private void UpdateGridView(string AUnitCode)
        {
            this.DataBinding_GridView(AUnitCode, 0);
        }

        private void btn添加处室_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AppServer.LoginUnitCode))
            {
                AppServer.ShowMsg_Warn("您可能是系统管理员，不属于指定征收机关的用户无法新建单位处室！");
                return;
            }
            string APCode;
            string NTCode;
            if (dbTreeView.SelectedNode == null)
            {
                if (dbTreeView.Nodes.Count > 0)
                {
                    AppServer.ShowMsg_Error("请选择一个树结点再创建处室！");
                    return;
                }
                APCode = "";
            }
            else
            {
                APCode = this.dbTreeView.SelectedNode.ID;
                NTCode = this.dbTreeView.SelectedNode.Text;
                using (var form = new FZB_单位_处室_Editor())
                {
                    form.OnUpdateGrid = this.UpdateGridView;
                    form.Editor_Add(APCode, NTCode);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.DataBinding_GridView(APCode,0);
                    }
                }
               
            }
        }
        private void btn修改处室_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            using (var form = new FZB_单位_处室_Editor())
            {
                form.Editor_Mod(row);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DataBinding_GridView(row["单位编码"].ToString(),this.dgvList.CurrentRow.Index);
                }
            }
        }
        private void btn删除处室_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            //
            string iRowID = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index]["处室编码"].ToString();
            string Ucode = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index]["单位编码"].ToString();
            if (iRowID == null) return;
            //
            if (!AppServer.DialogMsg("确认要删除当前处室吗？", "删除确认")) return;

            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_单位_处室();
                model.ExAction = "Del";
                model.处室编码 = iRowID;
                model.单位编码 = Ucode;
                AppServer.wcfClient.CMN_单位_处室_Edit(ref model);
                //
                if (model.ExResult != 0)
                {
                    AppServer.HideWaitForm();
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                //提交成功了
                DataBinding_GridView(Ucode, this.dgvList.CurrentRow.Index-1);
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
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_dbTreeView();
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //private void btn选择区划_Click(object sender, EventArgs e)
        //{
        //    AppServer.ReadAppCommon(1);
        //    AppServer.Frm行政区划.SetShowParam(this.txt行政区划, 0);
        //    AppServer.Frm行政区划.ShowDialog();
        //    if (AppServer.Frm行政区划.DialogResult == DialogResult.OK)
        //    {
        //        this.txt行政区划.Tag = AppServer.Frm行政区划.SelectNodeID;
        //        this.txt行政区划.Text = AppServer.Frm行政区划.SelectNodeTitle;
        //    }
        //}

        private void dbTreeView_TreeNodeCreated(object sender, TreeNodeCreatedEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }
       
    }
}
