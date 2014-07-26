using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Common;
using TY.Helper;
using GCGL_Client.NET;
namespace GCGL_Client.FZB
{
    public partial class FZB_配置标准 : Form
    {
        public FZB_配置标准()
        {
            InitializeComponent();
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            //
            if (AppServer.UserQxMenuList.Rows.Contains("010402"))
            {
                this.btn删除.Visible = true;
                this.btn修改.Visible = true;
                this.btn新增.Visible = true;
            }
        }

        private void FZB_配置标准_Load(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
        }
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_CMN_车辆配置标准();
                DataSet db = AppServer.wcfClient.CMN_车辆配置标准_List(ref model);
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
        private void btn新增_Click(object sender, EventArgs e)
        {
            using (var form = new FZB_配置标准_Editor())
            {
                form.Editor_Add();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
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
            using (var form = new FZB_配置标准_Editor())
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
            //
            int iRowID = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index]["ID"].ToIntegerDef(0);
            if (iRowID == 0) return;
            //
            if (!AppServer.DialogMsg("确认要删除当前车辆配置标准吗？", "删除确认")) return;
            //
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_CMN_车辆配置标准();
                model.ExAction = "删除";
                //  model.LoginUserCode = AppServer.LoginUserCode;
                model.ID = iRowID;
                AppServer.wcfClient.CMN_车辆配置标准_Edit(ref model);
                //
                if (model.ExResult != 0)
                {
                    AppServer.HideWaitForm();
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                //提交成功了
                this.DataBinding_GridView(this.dgvList.CurrentRow.Index - 1);
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
        private void btn查看_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new FZB_配置标准_Editor())
            {
                form.Editor_View(row);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    //this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                }
            }
        }
        

        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.dgvList, this.LblTitle.Text);
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn附件查看_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            //
            string wCode = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index]["依据文件编码"].ToString();
            if (wCode == null) return;
            using (var form = new NET_附件管理())
            {
                form.Editor_See(wCode);
                form.ShowDialog();
            }
        }

        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (AppServer.UserQxMenuList.Rows.Contains("010402"))
                this.btn修改.PerformClick();
            else
                this.btn查看.PerformClick();
        }
    }
}
