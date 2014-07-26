using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace GCGL_Client.Main
{
    public partial class Man_Entrust : Form
    {
        public Man_Entrust()
        {
            InitializeComponent();
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            AppServer.SetGridViewStyle(this.dgvList1);
            this.DataBinding_GridView(0);
            this.DataBanding_dgvlist(0);
            tabControl1_Selected(null, null);
        }
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_SYS_委托();
                model.ExAction = "List";
                model.委托人 = AppServer.LoginUserCode;
                DataSet db = AppServer.wcfClient.SYS_委托_list(ref model);
                DataTable table = db.Tables[0];

                this.dgvList.DataSource = table;
                //行定位
                this.dgvList.GoToRowByIndex(ACurrRowIndex);
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

        private void DataBanding_dgvlist(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_SYS_委托();
                model.ExAction = "被委托";
                model.被委托人 = AppServer.LoginUserCode;
                DataSet db = AppServer.wcfClient.SYS_委托_list(ref model);
                DataTable table = db.Tables[0];
                int i = table.Rows.Count;
                this.dgvList1.DataSource = table;
                //行定位
                this.dgvList1.GoToRowByIndex(ACurrRowIndex);
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
        //更改选项卡
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "委托信息")
            {
                this.LblTitle.Text = "委托列表";
                this.btn新增.Enabled = true;
                this.btn修改.Enabled = true;
                this.btn删除.Enabled = true;
            }
            if (tabControl1.SelectedTab.Name == "被委托信息")
            {
                this.LblTitle.Text = "被委托列表";
                this.btn删除.BackColor = SystemColors.Control;
                this.btn删除.Enabled = false;
                this.btn新增.BackColor = SystemColors.Control;
                this.btn新增.Enabled = false;
                this.btn修改.BackColor = SystemColors.Control;
                this.btn修改.Enabled = false;
            }
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            using (var form = new Man_UserEnt_Editor())
            {
                form.Editor_Add();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    this.dgvList.GoToRowByIndex(0);
                    this.DataBinding_GridView(0);
                }
            }
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new Man_UserEnt_Editor())
            {
                form.Editor_Mod(row);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                }
            }
        }

        private void btn删除_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            int RowId = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index]["ID"].ToIntegerDef(0);
            if ( RowId == 0 ) return;
            if (!AppServer.DialogMsg("确定要删除此委托人吗？", "确定删除")) return;
            //
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_SYS_委托();
                model.ExAction = "Del";
                model.ID = RowId;
                AppServer.wcfClient.SYS_委托_Edit(ref model);
                //
                if (model.ExResult != 0)
                {
                    AppServer.HideWaitForm();
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                //提交成功了
                if (this.dgvList.Rows.Count == 0) this.DataBinding_GridView(0);
                else this.DataBinding_GridView(this.dgvList.CurrentRow.Index); 
                //this.DataBinding_GridView(this.dgvList.CurrentRow.Index - 1);
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
        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
