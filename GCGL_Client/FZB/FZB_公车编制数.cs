using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GLG.Common;

namespace GCGL_Client.FZB
{
    public partial class FZB_公车编制数 : Form
    {
        public FZB_公车编制数()
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
                //
                var model = new Ref_WS_GCGL.DataType_CMN_单位_编制();
                model.ExAction = "Card";
                DataSet db = AppServer.wcfClient.CMN_单位_编制_List(ref model);
                DataTable table = db.Tables[0];
                if (table.Rows.Count == 0) return;
                this.dgvList.DataSource = table;
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
                AppServer.wcfClient.CMN_单位_编制_Edit(ref model);

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

        private void btn新增_Click(object sender, EventArgs e)
        {
            using (var form = new FZB_公车编制数_Editor())
            {
                form.Editor_Add();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    this.DataBinding_GridView(this.dgvList.Rows.Count);
                }
            }
        }

        private void btn删除_Click(object sender, EventArgs e)
        {
            if (AppServer.DialogMsg("确定要删除该信息吗？"))
            {
                int row = Convert.ToInt32(((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index]["ID"].ToString());
                Dep_Stop(row);
            }
            this.DataBinding_GridView(this.dgvList.CurrentRow.Index - 1);
        }

        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.dgvList, this.lbl公车编制数配置列表.Text);
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn查看_Click(object sender, EventArgs e)
        {

        }

        private void btn修改_Click(object sender, EventArgs e)
        {

        }

        private void btn审批_Click(object sender, EventArgs e)
        {
            if (AppServer.DialogMsg("确定要审批该信息吗？"))
            {
                int row = Convert.ToInt32(((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index]["ID"].ToString());
                string Urow = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index]["单位编码"].ToString();
                base.Cursor = Cursors.WaitCursor;
                try
                {
                    if (!AppServer.WcfService_Open()) return;
                    var model = new Ref_WS_GCGL.DataType_CMN_单位_编制();
                    model.ExAction = "Check";
                    model.ID = row;
                    model.单位编码 = Urow;
                    model.审核人编码 = AppServer.LoginUserCode;
                    AppServer.wcfClient.CMN_单位_编制_Edit(ref model);
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
            this.DataBinding_GridView(this.dgvList.CurrentRow.Index - 1);
        }
    }
}
