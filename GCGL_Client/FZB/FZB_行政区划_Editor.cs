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
        #region PrivateProperty
        private string Option;
        private object Object;
        private string PCode;
        

        #endregion

        public FZB_行政区划_Editor()
        {
            InitializeComponent();
        }
         public FZB_行政区划_Editor(string option, string pCode, object objtmp = null)
        {
            InitializeComponent();
            Option = option;
            PCode = pCode;
            Object = objtmp;
        }


        private void BZ_行政区划_Edit_Load(object sender, EventArgs e)
        {
            switch (Option)
            {
                case "Add":
                    Text = "新增行政区划";
                    txt上级编码.Text = PCode;
                    txt上级编码.ReadOnly = true;
                    txt区划编码.Text = PCode;
                    txt区划编码.Focus();
                    break;
                case "Mod":
                    Text = "修改行政区划";
                    txt区划编码.Enabled = false;
                    txt上级编码.ReadOnly = true;
                    txt区划编码.Text = (Object as DataRow)["编码"].ToString();
                    txt区划名称.Text = (Object as DataRow)["名称"].ToString();
                    nud区划级次.Value = Convert.ToDecimal((Object as DataRow)["区划级次"]);
                    chk是否本级.Checked =Convert.ToBoolean((Object as DataRow)["是否本级"]);
                    chk是否行政省管县.Checked=Convert.ToBoolean((Object as DataRow)["是否行政省管县"]);
                    chk是否财政省管县.Checked = Convert.ToBoolean((Object as DataRow)["是否财政省管县"]);
                    chk是否有效.Checked = Convert.ToBoolean((Object as DataRow)["是否有效"]);
                    PCode = (Object as DataRow)["上级编码"].ToString();
                    txt上级编码.Text = (Object as DataRow)["上级编码"].ToString();
                    txt区划名称.Focus();
                    break;
            }
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
                model.ExAction =Option;
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
                if (Option == "Add")
                    AppServer.ShowMsg("增加成功！");
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
    }
}
