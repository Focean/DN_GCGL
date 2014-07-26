using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.Main;
using TY.Helper;
using TY.Common;//EXCEL导出
using DingnuoControlLibrary;//DBTREEVIEW

namespace GCGL_Client.NET
{
    public partial class NET_审批中心 : Form
    {
        public NET_审批中心()
        {
            InitializeComponent();
            //
            AppServer.SetGridViewStyle(this.dgvList);
            //
            if (AppServer.UserQxMenuList.Rows.Contains("060102"))
            {
                this.btn入户凭证.Visible = true;
            }
           
            //
            this.cbx审批类型.SelectedIndex = 0;
        }

        private void NET_审批中心_Load(object sender, EventArgs e)
        {
            this.DataBinding_dbTreeView();
            //
            if (this.dbTreeView.Nodes.Count > 0)
                this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
            this.DataBinding_GridView(0);
        }

        private void DataBinding_GridView(int ARowIndex, string UnitCode = "")
        {
            if (this.chk仅未审批.Checked == true)
            {
                string str = "{ro=1,rno=1,wh=15}"
                + "[wfName,tc=类型,wh=100,al=mc,sm=1]"
                + "[exWaitState,tc=审核状态,wh=250,al=ml,sm=1]"
                + "[单位编码,wh=100,al=mc,sm=1,vi=0]"
                + "[待审数量,wh=100,al=mc,fmt=N0]"
                + "[单位名称,tc=申请单位,wh=200,al=ml]";
                //wh是宽度，al是对齐方式,sm是否排序（1真)     
                this.dgvList.GridStr(str);
            }
            else
            {
                string str = "{ro=1,rno=1}"
                + "[wfName,tc=类型,wh=150,al=mc,sm=1]"
                + "[exWaitState,tc=审核状态,wh=250,al=ml,sm=1]"
                + "[单位编码,wh=100,al=mc,sm=1,vi=0]"
                + "[exTitle,tc=申请原因/备注,wh=250,al=ml]"
                + "[单位名称,tc=申请单位,wh=150,al=ml]"
                + "[创建人,tc=申请人,wh=200,al=ml]"
                + "[CreateTime,tc=申请时间,wh=150,al=ml,fmt=d]";
                //wh是宽度，al是对齐方式,sm是否排序（1真)     
                this.dgvList.GridStr(str);
            }
            //
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_NET_审批();
                model.ExAction = "List";
                model.LoginUserCode = AppServer.LoginUserCode;
                model.单位编码 = UnitCode;
                model.审批类型 = this.cbx审批类型.Text.Trim();
               
                if (this.chk申请日期.Checked)
                {
                    model.开始时间 = this.dtp开始时间.Value;
                    model.结束时间 = this.dtp结束时间.Value;
                }
                model.仅未审批 = this.chk仅未审批.Checked;
                this.btn审批.Enabled = this.chk仅未审批.Checked;
                //
                DataSet db = AppServer.wcfClient.NET_审批_List(ref model);
               
                this.dgvList.DataSource = db.Tables[0];
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
            this.dbTreeView.NodePID = "上级编码";
            this.dbTreeView.NodeTitle = "单位全名";
            if (AppServer.UdataTable.Rows.Count > 0)
                this.dbTreeView.DataSource = AppServer.UdataTable;
            this.dbTreeView.BuildTrees();
            //
            if (!string.IsNullOrEmpty(ANodeID))
            {
                DBTreeNode node = this.dbTreeView.FindTreeNode(ANodeID);
                if (node != null) this.dbTreeView.SelectedNode = node;
            }

        }

        private void DataSearch()
        {
            DataTable newdt = new DataTable();
            newdt = AppServer.UdataTable.Clone(); // 克隆dt 的结构，包括所有 dt 架构和约束,并无数据；
            DataRow[] rows = AppServer.UdataTable.Select("单位全名 like '" + '%' + this.txt关键字.Text.Trim() + '%' + "'"); // 从dt 中查询符合条件的记录； 
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
            if (this.dbTreeView.Nodes.Count > 0)
            {
                this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
            }
        }

        private void btn审批_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;

            //if (this.dgvList.CurrentRow.Cells["wfName"].Value.ToString() == "入库登记审核")
            //{
                using (var form = new NET_审批中心_List())
                {
                    form.Editor(this.dgvList.CurrentRow.Cells["wfName"].Value.ToString(), this.dgvList.CurrentRow.Cells["exWaitState"].Value.ToString(), this.dgvList.CurrentRow.Cells["CreateUnitCode"].Value.ToString());
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.DataBinding_GridView(0);
                    }
                }
            //}
            //else
            //{
            //    using (var form = new NET_审批中心_Edit())
            //    {
            //        form.Editor_Mod(this.dgvList.CurrentRow.Cells["wfName"].Value.ToString(),
            //             this.dgvList.CurrentRow.Cells["exCode"].Value.ToString(),
            //             this.dgvList.CurrentRow.Cells["单位名称"].Value.ToString(),
            //             this.dgvList.CurrentRow.Cells["exWaitState"].Value.ToString());

            //        if (form.ShowDialog() == DialogResult.OK)
            //        {
            //            this.DataBinding_GridView(0);
            //        }
            //    }
            //}
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn打印_Click(object sender, EventArgs e)
        {
            //AppServer.ShowMsg(this.dgvList.CurrentRow.Cells["exFinished"].Value.ToIntegerDef().ToString());
        }

        private void btn查看_Click(object sender, EventArgs e)
        {
            if (this.dgvList.RowCount == 0) return;
            using (var form = new NET_审批中心_Edit())
            {
                form.Editor_See(this.dgvList.CurrentRow.Cells["wfName"].Value.ToString(),
                     this.dgvList.CurrentRow.Cells["exCode"].Value.ToString(),
                     this.dgvList.CurrentRow.Cells["单位名称"].Value.ToString(),
                     this.dgvList.CurrentRow.Cells["exWaitState"].Value.ToString());

                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.dgvList, this.lblTitle.Text);
        }

        private void dbTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.DataBinding_GridView(0, this.dbTreeView.SelectedNode.ID);
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



        private void btn检索_Click(object sender, EventArgs e)
        {
            if (this.txt关键字.Text == "")
            {
                this.DataBinding_dbTreeView();
                //
                if (this.dbTreeView.Nodes.Count > 0)
                {
                    this.dbTreeView.SelectedNode = (DBTreeNode)this.dbTreeView.Nodes[0];
                }
                return;
            }
            DataSearch();
        }

        private void dbTreeView_TreeNodeCreated(object sender, TreeNodeCreatedEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void chk仅未审批_CheckedChanged(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
        }

        private void cbx审批类型_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
        }

        private void chk申请日期_CheckedChanged(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
        }

       
        private void toolStripButton1_Click(object sender, EventArgs e)//折叠
        {
            //折叠功能树
            this.pnlleft.Visible = false;
            this.pnlRight.Visible = true;
            this.splitter1.Enabled = false;
            this.splitter1.Visible = false;
        }

        private void toolBtnShowFT_Click(object sender, EventArgs e)
        {
            //展开功能树
            this.pnlRight.Visible = false;
            this.pnlleft.Visible = true;
            this.splitter1.Enabled = true;
            this.splitter1.Visible = true;
        }

        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.chk仅未审批.Checked)
                this.btn审批.PerformClick();
            else this.btn查看.PerformClick();
        }
        private void btn入户凭证_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            if (row["wfName"].ToString() == "入库登记审核" )
            {
                using (var form = new GCGL_Client.OCC.OCC_公车入户_Print())
                {
                    form.Editor_Print(row["exCode"].ToString());
                    if (form.ShowDialog() == DialogResult.OK)
                    { }
                }  
            }
            else
            {
                AppServer.ShowMsg("请选择要打印的入库登记审核","提示");
            }
        }

        private void cbx资产类别_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
        }

    }
}
