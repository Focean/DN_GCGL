using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.NET
{
    public partial class NET_审批中心_List_不通过 : Form
    {
        public NET_审批中心_List_不通过()
        {
            InitializeComponent();
        }
        private string _exCode;
        public string exCode
        {
            get { return _exCode; }
            set { _exCode = value; }
        }
        private string[] arrstr = null;
        private void btn确定_Click(object sender, EventArgs e)
        {
            if (this.txtexOpinion.Text == "")
            {
                AppServer.ShowMsg("请填写审核意见！", "提示");
                this.txtexOpinion.Focus();
                return;
            }
            if (this.rbn不同意.Checked == false )
            {
                AppServer.ShowMsg("请选择审核意见！", "提示");
                return;
            }
            arrstr = exCode.Split(new char[] { ',' });
            try
            {
                if (!AppServer.WcfService_Open()) return;
                for (int i = 0; i < this.arrstr.Length; i++)
                {
                    if (arrstr[i] != null && arrstr[i].ToString() != "")
                    {
                        var model = new Ref_WS_GCGL.DataType_NET_审批();
                        model.LoginUserCode = AppServer.LoginUserCode;
                        model.exCode = arrstr[i];
                        model.exOpinion = txtexOpinion.Text;
                        model.exOpinionFlag = 0;
                        model.exnext = this.cbx返回到.Text.ToString();
                        AppServer.wcfClient.NET_审批_Edit(ref model);
                        if (model.ExResult != 0)
                        {
                            AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                            return;
                        }
                    }
                }

                this.DialogResult = DialogResult.OK;
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
    }
}
