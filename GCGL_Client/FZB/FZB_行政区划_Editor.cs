using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.FZB
{
    public partial class FZB_行政区划_Editor : Form
    {

        public FZB_行政区划_Editor()
        {
            InitializeComponent();
        }

        private DataRow FDataRow;
        public void Editor_Add(DataRow row, DataRow dr)
        {
            this.Text = "行政区划(新增)";
            this.Tag = "Add";            
            txt上级编码.Text = row["编码"].ToString();
            txt上级编码.ReadOnly = true;
            txt区划编码.Text = row["编码"].ToString();
            txt区划编码.Focus();
            //       
            FDataRow = dr;
        }
        public void Editor_Mod(DataRow row, DataRow dr)
        {
            this.Text = "行政区划(修改)";
            this.Tag = "Mod";
            txt区划编码.Enabled = false;
            txt上级编码.ReadOnly = true;
            txt区划编码.Text = row["编码"].ToString();
            txt区划名称.Text = row["名称"].ToString();
            txt上级编码.Text = row["上级编码"].ToString();
            nud区划级次.Value = Convert.ToDecimal(row["区划级次"]);
            chk是否本级.Checked = Convert.ToBoolean(row["是否本级"]);
            chk是否行政省管县.Checked = Convert.ToBoolean(row["是否行政省管县"]);
            chk是否财政省管县.Checked = Convert.ToBoolean(row["是否财政省管县"]);
            chk是否有效.Checked = Convert.ToBoolean(row["是否有效"]);                     
            //  
            FDataRow = dr;
        }

        private void Btn确定_Click(object sender, EventArgs e)
        {
            if (txt区划编码.Text.Trim() == "")
            {
                AppServer.ShowMsg("区划编码不能为空！　");
                txt区划编码.Focus();
                return;
            }



            if (txt区划名称.Text.Trim() == "")
            {
                AppServer.ShowMsg("名称不能为空！　");
                txt区划名称.Focus();
                return;
            }

            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_行政区划();
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.ExAction =this.Tag.ToString();
                if (model.ExAction == "Mod")
                {
                    model.区划编码 = this.txt区划编码.Text.ToString();
                }
                AppServer.wcfClient.CMN_行政区划_Edit(ref model);               
                if (model.ExResult!=0)
                {
                    AppServer.ShowMsg_Error(model.ErrorMsg);
                    return;
                }
                FDataRow["编码"] = this.txt区划编码.Text.ToString();
                FDataRow["名称"] = this.txt区划名称.Text.ToString();
                FDataRow["上级编码"] = this.txt上级编码.Text.ToString();
                FDataRow["全名"] = "(" + this.txt区划编码.Text.ToString() + ")" + this.txt区划名称.Text.ToString();
                FDataRow["区划级次"] = this.nud区划级次.Value;
                FDataRow["是否本级"] = this.chk是否本级.Checked;
                FDataRow["是否行政省管县"] = this.chk是否行政省管县.Checked;
                FDataRow["是否财政省管县"] = this.chk是否财政省管县.Checked;
                FDataRow["是否有效"] = this.chk是否有效.Checked;
                DialogResult = DialogResult.OK;
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

        private void Txt数字_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }

        private void Btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FZB_行政区划_Editor_KeyDown(object sender, KeyEventArgs e)
        {
            // 组合键
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)         //Ctrl+s
            {
                Btn确定_Click(this, EventArgs.Empty);
            }
        }

        private void txt区划编码_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9')|| e.KeyChar == 8)//退格键是8
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
