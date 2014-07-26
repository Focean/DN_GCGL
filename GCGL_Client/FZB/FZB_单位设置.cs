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
using TY.Common;

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
            if (AppServer.UserQxMenuList.Rows.Contains("010302"))
            {
                this.btn新增.Visible = true;
                this.btn删除.Visible = true;
            }
            if (AppServer.UserQxMenuList.Rows.Contains("010303"))
            {
                this.btn修改.Visible = true;
            }
            if (AppServer.LoginUnitIsYSDW()) 
            {
               
                this.btn添加处室.Enabled = true;
                this.btn修改处室.Enabled = true;
                this.btn删除处室.Enabled = true;
                //
            }
            if (AppServer.LoginUnitIsYSDW())
            {
                this.dbTreeView.Visible = false;
                this.splitter1.Visible = false;
                this.pnlLeft.Visible = false;
            }
            this.DataBinding_GridView(AppServer.LoginUnitCode.ToString(), 0);
        }

        private void FZB_单位设置_Load(object sender, EventArgs e)
        {
            if (AppServer.LoginUnitIsZGDW() || AppServer.LoginUnitIsYSDW()||AppServer.LoginUnitIsQH())
                DataBinding_dbTreeView();
            else if ( AppServer.LoginUnitIsCZT())//若是区划和资产处则显示对口单位
                DataBinding_dbTreeViewXZ();

            if (this.dbTreeView.Nodes.Count > 0)
            {
                this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
                this.DB_View(this.dbTreeView.SelectedNode.ID);
            }
        }
        DataTable Ydt = null;

        private void UpdateTable()
        {
            var mdl = new Ref_WS_GCGL.DataType_CMN_单位();
            mdl.LoginUserCode = AppServer.LoginUserCode;
            if (AppServer.LoginUnitIsCZT())
            {
                mdl.ExAction = "GetGUnit";
            }
            else
            {
                mdl.ExAction = "UnitMngrTree";
                mdl.区划编码 = AppServer.LoginAreaCode;
                mdl.单位编码 = AppServer.LoginUnitCode;
                mdl.单位类型编码 = AppServer.LoginUnitType;
            }
            DataSet dset = AppServer.wcfClient.CMN_单位_List(ref mdl);
            AppServer.UdataTable = dset.Tables[0];
        }

        private void DataBinding_dbTreeViewXZ(string CNodeID = "")
        {
            this.dbTreeView.NodeID = "处室编码";
            this.dbTreeView.NodePID = "单位编码";
            this.dbTreeView.NodeTitle = "处室名称";
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var mdl = new Ref_WS_GCGL.DataType_CMN_单位_处室();
                mdl.LoginUserCode = AppServer.LoginUserCode;
                mdl.ExAction = "Yunit";
                Ydt = AppServer.wcfClient.CMN_单位_处室_List(ref mdl).Tables[0];
                if (Ydt.Rows.Count > 0)
                    this.dbTreeView.DataSource = Ydt;
                this.dbTreeView.BuildTrees();
                //
                if (!string.IsNullOrEmpty(CNodeID))
                {
                    DBTreeNode node = this.dbTreeView.FindTreeNode(CNodeID);
                    if (node != null) this.dbTreeView.SelectedNode = node;
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
        private void DataBinding_dbTreeView(string ANodeID = "")
        {
            this.dbTreeView.NodeID = "单位编码";
            this.dbTreeView.NodePID  = "上级编码";
            this.dbTreeView.NodeTitle = "单位全名";
            if(AppServer.UdataTable.Rows.Count>0)
                this.dbTreeView.DataSource = AppServer.UdataTable;
            this.dbTreeView.BuildTrees();
            //
            if (!string.IsNullOrEmpty(ANodeID))
            {
                DBTreeNode node = this.dbTreeView.FindTreeNode(ANodeID);
                if (node != null) this.dbTreeView.SelectedNode = node;
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
                DataTable dt = new DataTable();
                dt = table.Clone();
                foreach (DataColumn col in dt.Columns)
                {
                    if (col.ColumnName == "有效")
                    {
                        //修改列类型
                        col.DataType = typeof(String);
                    }
                }
                foreach (DataRow row in table.Rows)
                {
                    DataRow rowNew = dt.NewRow();
                    rowNew["处室编码"] = row["处室编码"];
                    rowNew["单位编码"] = row["单位编码"];
                    rowNew["单位名称"] = row["单位名称"];
                    rowNew["处室类型"] = row["处室类型"];
                    rowNew["处室名称"] = row["处室名称"];
                    rowNew["处室类型名称"] = row["处室类型名称"];
                    rowNew["创建时间"] = row["创建时间"];
                    rowNew["有效"] = row["有效"];
                    //修改记录值                  
                    dt.Rows.Add(rowNew);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["有效"].ToString() == "True")
                        dt.Rows[i]["有效"] = "有效";
                    else
                        dt.Rows[i]["有效"] = "无效";
                }
                this.dgvList.DataSource = dt;
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
       DataRow dr;//修改单位的时候存储重新获取的单位信息
       public void DB_View(string Code)
       {
           DataRow row = null;
           if (Code == null) return;
           try
           {
               var dtm = new Ref_WS_GCGL.DataType_CMN_单位();
               dtm.单位编码 = Code;
               dtm.ExAction = "GetUnitx";
               if (!AppServer.WcfService_Open()) return;
               DataTable table = AppServer.wcfClient.CMN_单位_List(ref dtm).Tables[0];
               if (table.Rows.Count == 0)
               {
                   row = null;
                   dr = null;
                   return;
               }
               row = table.Rows[0];
               dr = table.Rows[0];
               TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
               this.lbl部门预算处室名称.Text = row["部门预算处室名称"].ToString();
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
               if (AppServer.LoginUnitIsQH()||AppServer.LoginUnitIsCZT())
               {                  
                   if (this.dbTreeView.SelectedNode == null)
                   {
                       if (this.dbTreeView.Nodes.Count > 0)
                       {
                           AppServer.ShowMsg_Error("请选择一个树结点再创建下级单位！");
                           return;
                       }
                       APCode = "";
                   }
                   else
                   {
                       if (this.dbTreeView.SelectedNode.Level == 0)
                           APCode = this.dbTreeView.SelectedNode.ID;
                       else
                       {
                           if (this.dbTreeView.SelectedNode.Nodes.Count <= 0)
                           {
                               AppServer.ShowMsg_Error("请用主管单位用户创建预算单位！");
                               return;
                           }
                           else
                               APCode = this.dbTreeView.SelectedNode.ID;
                       }
                   }
                 
               }
               else
               {
                   //if (this.dbTreeView.SelectedNode.Nodes.Count <= 0)
                   //{
                   //    AppServer.ShowMsg_Error("不能在预算单位下再创建下级单位！");
                   //    return;
                   //}
                   if (this.dbTreeView.SelectedNode == null)
                   {
                       if (this.dbTreeView.Nodes.Count > 0)
                       {
                           AppServer.ShowMsg_Error("请选择一个树结点再创建下级单位！");
                           return;
                       }
                       APCode = "";
                   }
                   else
                   {
                       APCode = this.dbTreeView.SelectedNode.ID;
                   }
               }
            //
            DataRow newrow = ((DataTable)this.dbTreeView.DataSource).NewRow();
            using (var form = new FZB_单位设置_Editor())
            {
                form.Editor_Add(APCode, newrow);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (!AppServer.LoginUserIsQH())
                    {
                        ((DataTable)dbTreeView.DataSource).Rows.Add(newrow);
                        string[] ss = form.Tag.ToString().Split(new char[] { '(', '_', ')' });
                        DBTreeNode d1 = new DBTreeNode();
                        d1.Text = "(" + ss[2] + ")" + ss[3];
                        d1.ID = ss[1] + "_" + ss[2];
                        this.dbTreeView.SelectedNode.Nodes.Add(d1);
                        d1.ImageIndex = 1;
                        this.dbTreeView.SelectedNode = d1;
                    }
                    else
                    {
                        Event_检索(this.txt关键字.Text);
                    }
                }
            }
        }
       string T_YSBM;
       string T_BMYS;
        private void btn修改_Click(object sender, EventArgs e)
        {

            if (AppServer.LoginUnitIsYSDW())
            {
                if (dr == null) return;
               
                using (var form = new FZB_单位设置_Editor())
                {
                    form.Editor_Mod(dr);
                    if (form.ShowDialog() == DialogResult.OK)
                    {

                        {
                            this.DB_View(AppServer.LoginUnitCode);
                        }
                    }
                }
            }
            else
            {
                if (dbTreeView.SelectedNode == null) return;
                string sNodeID = dbTreeView.SelectedNode.ID;
                if (dr == null) return;
                T_YSBM = null;
                T_YSBM = dr["预算编码"].ToString();
                T_BMYS=dr["部门预算处室编码"].ToString();
                //        
                using (var form = new FZB_单位设置_Editor())
                {
                    form.Editor_Mod(dr);
                   
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        
                        string[] ss = form.Tag.ToString().Split(new char[] { '(', '_', ')' });
                        DBTreeNode d1 = new DBTreeNode();
                        d1.Text = "(" + ss[2] + ")" + ss[3];
                        d1.ID = ss[1] + "_" + ss[2];
                        this.dbTreeView.SelectedNode.Text = d1.Text;
                        this.dbTreeView.SelectedNode.ID = d1.ID;
                        this.DB_View(this.dbTreeView.SelectedNode.ID);
                        if (T_BMYS != form.BCode)
                            Event_检索(T_YSBM);
                    }
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
                if (model.ExResult != 0)
                    AppServer.ShowMsg_Error(model.ErrorMsg);
                else
                {
                    //dbTreeView.Nodes.Remove(dbTreeView.SelectedNode);

                    var model1 = new Ref_WS_GCGL.DataType_CMN_单位();
                    model1.LoginUserCode = AppServer.LoginUserCode;
                    if (AppServer.LoginUnitIsCZT())
                    {
                        model1.ExAction = "GetGUnit";
                    }
                    else
                    {
                        model1.ExAction = "UnitMngrTree";
                        model1.区划编码 = AppServer.LoginAreaCode;
                        model1.单位编码 = AppServer.LoginUnitCode;
                        model1.单位类型编码 = AppServer.LoginUnitType;
                    }
                    DataSet ds = AppServer.wcfClient.CMN_单位_List(ref model1);
                    AppServer.UdataTable = ds.Tables[0];
                }
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
            Event_检索(this.txt关键字.Text);
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
                       this.DataBinding_GridView(APCode, 0);
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

        private void dbTreeView_TreeNodeCreated(object sender, TreeNodeCreatedEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void dbTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.DB_View(this.dbTreeView.SelectedNode.ID);//获取单位的信息
            this.DataBinding_GridView(this.dbTreeView.SelectedNode.ID, 0);//获取单位处室的信息
        }

        private void dbTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.DB_View(this.dbTreeView.SelectedNode.ID);           
        }

        private void btn检索_Click(object sender, EventArgs e)
        {
            Event_检索(this.txt关键字.Text);
        }

        private void Event_检索(string 关键字)
        {
            
            DataTable newdt = new DataTable();
            DataRow[] rows = null;
            newdt = AppServer.UdataTable.Clone(); // 克隆dt 的结构，包括所有 dt 架构和约束,并无数据；
            if (AppServer.LoginUnitIsCZT())
            {
                if (关键字 == "")
                {
                    this.DataBinding_dbTreeViewXZ();
                    //
                    if (this.dbTreeView.Nodes.Count > 0)
                    {
                        this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
                        this.DB_View(this.dbTreeView.SelectedNode.ID);
                    }
                    return;
                }
                rows = AppServer.UdataTable.Select("单位类型编码=2 and 单位全名 like '" + '%' + 关键字.Trim() + '%' + "'"); // 从dt 中查询符合条件的记录； 
                foreach (DataRow row in rows)  // 将查询的结果添加到dt中；
                {
                    newdt.Rows.Add(row.ItemArray);
                }
                if (newdt.Rows.Count > 0)
                {
                    this.dbTreeView.ClearTrees();
                    DataBinding_dbTreeViewXZ();
                    for (int i = 0; i < newdt.Rows.Count; i++)
                    {
                        DBTreeNode newnode = new DBTreeNode();
                        newnode.Text = newdt.Rows[i]["单位全名"].ToStringDef();
                        newnode.ID = newdt.Rows[i]["单位编码"].ToStringDef();
                        for (int j = 0; j < this.dbTreeView.Nodes.Count; j++)
                        {
                            if (newdt.Rows[i]["部门预算处室编码"].ToStringDef() == Ydt.Rows[j]["处室编码"].ToStringDef() || (newdt.Rows[i]["部门预算处室编码"] is DBNull && Ydt.Rows[j]["处室编码"].ToStringDef() == "999"))
                            {
                                this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[j];
                                this.dbTreeView.SelectedNode.Nodes.Add(newnode);
                            }
                        }
                    }
                }
                else
                {
                    this.dbTreeView.ClearTrees();
                    AppServer.ShowMsg("查询结果为空，请确认输入内容！", "提示");
                    return;
                }
            }
            else
            {
                if (关键字 == "")
                {
                    this.DataBinding_dbTreeView();
                    //
                    if (this.dbTreeView.Nodes.Count > 0)
                    {
                        this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
                        this.DB_View(this.dbTreeView.SelectedNode.ID);
                    }
                    return;
                }
                newdt = AppServer.UdataTable.Clone(); // 克隆dt 的结构，包括所有 dt 架构和约束,并无数据；
                rows = AppServer.UdataTable.Select("单位全名 like '" + '%' + 关键字.Trim() + '%' + "'"); // 从dt 中查询符合条件的记录； 
                foreach (DataRow row in rows)  // 将查询的结果添加到dt中；
                {
                    newdt.Rows.Add(row.ItemArray);
                }
                this.dbTreeView.NodeID = "单位编码";
                this.dbTreeView.NodePID = "上级编码";
                this.dbTreeView.NodeTitle = "单位全名";
                if (newdt.Rows.Count > 0)
                    this.dbTreeView.DataSource = newdt;
                else
                {
                    this.dbTreeView.ClearTrees();
                    AppServer.ShowMsg("查询结果为空，请确认输入内容！", "提示");
                    return;
                }
                this.dbTreeView.BuildTrees();
            }
            this.dbTreeView.ExpandAll();
            if (this.dbTreeView.Nodes.Count > 0)
            {
                this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
                this.DB_View(this.dbTreeView.SelectedNode.ID);
            }
        }

        private void lbl单位类型名称_TextChanged(object sender, EventArgs e)
        {
            if (this.lbl单位类型名称.Text == "预算单位")
            {
                this.lbl部门预算处室名称.Visible = false;
                this.label10.Visible = false;
                this.lbl单位性质名称.Visible = true;
                this.label6.Visible = true;
            }
            else if (this.lbl单位类型名称.Text == "主管单位")
            {
                this.lbl部门预算处室名称.Visible = true;
                this.label10.Visible = true;
                this.lbl单位性质名称.Visible = false;
                this.label6.Visible = false;
            }
        }

        private void dbTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (dbTreeView.SelectedNode.Nodes.Count > 0) return;//若有子节点则不再加载
            if (AppServer.LoginUnitIsCZT() || AppServer.LoginUnitIsQH())
            {
                DataTable newdt = new DataTable();
                DataRow[] rows = null;
                newdt = AppServer.UdataTable.Clone(); // 克隆dt 的结构，包括所有 dt 架构和约束,并无数据；
                if (this.dbTreeView.SelectedNode.ID == "999")
                    rows = AppServer.UdataTable.Select("部门预算处室编码 is null and 单位类型编码 in (2,8)");
                else
                    rows = AppServer.UdataTable.Select("部门预算处室编码 = '" + this.dbTreeView.SelectedNode.ID + "'" + "and 单位类型编码 in (2,8)"); // 从dt 中查询符合条件的记录； 
                foreach (DataRow row in rows)  // 将查询的结果添加到dt中；
                {
                    newdt.Rows.Add(row.ItemArray);
                }
                if (newdt.Rows.Count == 0) return;
                for (int i = 0; i < newdt.Rows.Count; i++)
                {
                    DBTreeNode newnode = new DBTreeNode();
                    newnode.Text = newdt.Rows[i]["单位全名"].ToStringDef();
                    newnode.ID = newdt.Rows[i]["单位编码"].ToStringDef();
                    this.dbTreeView.SelectedNode.Nodes.Add(newnode);
                }
                if (!string.IsNullOrEmpty(((DBTreeNode)e.Node).ID))
                {
                    DBTreeNode node = this.dbTreeView.FindTreeNode(((DBTreeNode)e.Node).ID);
                    if (node != null) this.dbTreeView.SelectedNode = node;
                }
                e.Node.Expand();
            }
            else
            {
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
}
