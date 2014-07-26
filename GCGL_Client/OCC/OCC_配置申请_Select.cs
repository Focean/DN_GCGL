using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.OCC
{
    public partial class OCC_配置申请_Select : Form
    {
        public OCC_配置申请_Select()
        {
            InitializeComponent();
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
        }

        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_OCC_配置申请();
                model.ExAction = "Request";
                model.单位编码 = AppServer.LoginUnitCode;
                DataSet db = AppServer.wcfClient.OCC_配置申请_List(ref model);
                this.dgvList.DataSource = db.Tables[0];//调拨               
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

        public void Select_DB()
        {
            this.Text = "配置申报选择";
        }
      
        private void OCC_配置申请_Select_Load(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }             

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void btn下一步_Click(object sender, EventArgs e)
        {   
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;

            using (var form = new OCC_公车入库_Editor())
            {
                form.Editor_Add(row);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }         
        }

        private void OCC_配置申请_Select_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control)         //Ctrl+N
            {
                this.btn下一步_Click(this, EventArgs.Empty);
            }
        }
    }
}
