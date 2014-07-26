using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Common;

namespace GCGL_Client.FZB
{
    public partial class FZB_公车编制数 : Form
    {
        private Boolean Btnshow;
        public FZB_公车编制数()
        {
            InitializeComponent();
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            AppServer.SetGridViewStyle(this.dgvLBZ);
            //
            if (!AppServer.LoginUnitIsYSDW())
            {
                this.dgvList.Columns[3].Visible=true;
                Btnshow = true;
            }
            if (AppServer.UserQxMenuList.Rows.Contains("031002"))
            {
                this.btn新增.Visible = true;
                this.btn修改.Visible = true;
                this.btn删除.Visible = true;
            }
            if (AppServer.UserQxMenuList.Rows.Contains("031003"))
            {
                this.btn编制导入.Visible = true;
                this.btn编制调减.Visible = true;
            }
            DataBinding_GridView(0);
            dataGrid_BZS();
        }
        
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_CMN_单位_编制();
                model.ExAction = "Card";
                if (AppServer.LoginUnitIsCZT())
                {
                    model.单位编码 = null;
                }
                model.单位编码 = AppServer.LoginUnitCode;
                DataSet db = AppServer.wcfClient.CMN_单位_编制_List(ref model);
                DataTable table = db.Tables[0];
                if (table.Rows.Count == 0) return;
                this.dgvList.DataSource = table;
                //
              
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
            }
        }

        private void dataGrid_BZS()
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_单位_编制();
                model.ExAction = "Gbz";
                if (AppServer.LoginUnitIsYSDW())
                    model.单位编码 = AppServer.LoginUnitCode;
                else
                {
                    if(this.dgvList.Rows.Count>0)
                        model.单位编码 = this.dgvList.Rows[this.dgvList.CurrentRow.Index].Cells["单位编码"].Value.ToString();
                }
                DataTable dt = AppServer.wcfClient.CMN_单位_编制_List(ref model).Tables[0];
                if (dt.Rows.Count == 0) return;
                this.dgvLBZ.DataSource = dt;
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
            }
        }
    
        public void Dep_Stop(int ID)
        { 
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_单位_编制();
                model.ExAction = "Del";
                model.ID = ID;
                model.LoginUserCode = AppServer.LoginUserCode;
                AppServer.wcfClient.CMN_单位_编制_Edit(ref model);
                if (model.ExResult == 0)
                {
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index - 1);
                }
                else
                    AppServer.ShowMsg_Error(model.ErrorMsg, "错误");
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

        private void UpdateGridView(int AIndex)
        {
            this.DataBinding_GridView(AIndex);
            dataGrid_BZS();
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            using (var form = new FZB_公车编制数_Editor())
            {

                form.Editor_Add(Btnshow);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    this.DataBinding_GridView(this.dgvList.Rows.Count);
                    dataGrid_BZS();
                }
            }
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            if (row["exWaitState"].ToString() == "等待提交" || row["exWaitState"].ToString() == "等待重新提交")
            {
                using (var form = new FZB_公车编制数_Editor())
                {
                    form.Editor_Mod(row);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        //更新数据
                        this.DataBinding_GridView(this.dgvList.Rows.Count);
                        dataGrid_BZS();
                    }
                }
            }
            else
            {
                AppServer.ShowMsg_Warn("该申请已经提交，无法修改！", "警告");
                return;
            }
        }

        private void btn查看_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new FZB_公车编制数_Editor())
            {
                form.Editor_See(row["ID"].ToString(),false);
                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void btn删除_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (AppServer.DialogMsg("确定要删除该信息吗？"))
            {
                int rowID = Convert.ToInt32(row["ID"].ToString());
                Dep_Stop(rowID);
            }
            DataBinding_GridView(0);
            dataGrid_BZS();
        }

        private void btn刷新_Click(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
            dataGrid_BZS();
        }

        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.dgvList, this.lbl公车编制数配置列表.Text);
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn编制导入_Click(object sender, EventArgs e)
        {
            using (var form = new FZB_公车编制数_导入())
            {
                form.OnUpdateGrid = this.UpdateGridView;
                if (form.ShowDialog() == DialogResult.OK)
                {
                }
            }

        }

        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (row["exWaitState"].ToString() == "等待提交" || row["exWaitState"].ToString() == "等待重新提交")
            {
                this.btn修改.PerformClick();
            }
            else
            {
                this.btn查看.PerformClick();
            }
        }

        private void btn编制调减_Click(object sender, EventArgs e)
        {
            using (var form = new FZB_公车编制数_Editor())
            {
                form.Editor_Add(true);
                form.Text = "编制调减";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    this.DataBinding_GridView(this.dgvList.Rows.Count);
                    dataGrid_BZS();
                }
            }
        }

        private void dgvList_MouseClick(object sender, MouseEventArgs e)
        {
            dataGrid_BZS();
        }

        private void btn审批意见_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new GCGL_Client.NET.NET_审批中心_Flow())
            {
                form.Editor_See(row["审批流程编码"].ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

    }
}
