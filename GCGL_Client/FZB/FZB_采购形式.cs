using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GLG.Common;
using TY.Helper;
namespace GCGL_Client.FZB
{
    public partial class FZB_采购形式 : Form
    {
        public FZB_采购形式()
        {
            InitializeComponent();
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            DataBinding_GridView(0);
        }
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                this.dgvList.DataSource = AppServer.wcfClient.FZB_编码_List("采购形式").Tables[0];
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
        private void Btn增加_Click(object sender, EventArgs e)
        {
            using (var form = new FZB_采购形式_Editor())
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

        private void Btn删除_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            //
            string iRowID = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index]["采购形式编码"].ToString();
            if (iRowID == null) return;
            //
            if (!AppServer.DialogMsg("确认要删除当前采购形式吗？", "删除确认")) return;

            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_FZB_编码();
                model.ExAction = "Del";
                model.采购形式编码 = iRowID;
                AppServer.wcfClient.FZB_采购形式_Edit(ref model);
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

        private void Btn修改_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new FZB_采购形式_Editor())
            {
                form.Editor_Mod(row);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                }
            }
        }

        private void Btn刷新_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void Btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
