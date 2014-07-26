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
    public partial class OCC_处置申请_XG : Form
    {
        public OCC_处置申请_XG()
        {
            InitializeComponent();
            if (!AppServer.WcfService_Open()) return;
            this.cbx处置形式.DataSource = AppServer.wcfClient.FZB_编码_List("处置形式", AppServer.LoginAreaCode).Tables[0];
            this.cbx处置形式.DisplayMember = "处置形式名称";
            this.cbx处置形式.ValueMember = "处置形式编码";  
        }
        private string Qcode;
        private string xH = null;
        public void Editor_XG(DataRow row)
        {
            
            this.Text = "处置形式(审核)";
            this.Tag = "CZXS";

            this.lbl申请处置形式.Text = row["申请处置形式名称"].ToString();
            Qcode = row["申请编号"].ToString();
            xH=row["申请序号"].ToString();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_OCC_处置申请();
                model.ExAction = this.Tag.ToString();
                model.LoginUserCode = AppServer.LoginUserCode;
                model.申请编号 = Qcode;
                model.申请序号 =Convert.ToInt32(xH);
                model.处置形式编码 = this.cbx处置形式.SelectedValue.ToString();
                AppServer.wcfClient.OCC_处置申请_Edit(ref model);
                //
                if (model.ExResult != 0)
                {
                    AppServer.HideWaitForm();
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                AppServer.HideWaitForm();
                AppServer.ShowMsg_ExceptError(ex.Message);
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }
           
        }
    }
}
