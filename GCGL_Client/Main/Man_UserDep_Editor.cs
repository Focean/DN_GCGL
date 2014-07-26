using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.Main
{
    public partial class Man_UserDep_Editor : Form
    {
        public DataTable dtable;
        public Man_UserDep_Editor()
        {
            InitializeComponent();
            //
            if (!AppServer.WcfService_Open()) return;
            try
            {
                dtable = AppServer.wcfClient.FZB_编码_List("部门预算处室编码", AppServer.LoginAreaCode).Tables[0];
                clb分管单位.DataSource = dtable;
                this.clb分管单位.DisplayMember = "全名";
                this.clb分管单位.ValueMember = "处室编码";
              
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
        string AUser;
        public void Editor_Mod(string AUserCode)
        {
            AUser = AUserCode;
            this.Text = "设置分管单位";
            try
            {
                if (!AppServer.WcfService_Open()) return;

                var mdl = new  Ref_WS_GCGL.DataType_CMN_单位_处室();
                mdl.ExAction = "GetUdep";
                mdl.分管人 = AUserCode;
                DataTable dt = AppServer.wcfClient.CMN_单位_处室_List(ref mdl).Tables[0];
                for (int j = 0; j < this.clb分管单位.Items.Count; j++)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (this.clb分管单位.GetItemText(this.clb分管单位.Items[j]) == dt.Rows[i]["全名"].ToString())
                        {
                            this.clb分管单位.SetItemChecked(j, true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_SubmitError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var md = new Ref_WS_GCGL.DataType_CMN_单位_处室();
                md.ExAction = "COffice";
                md.分管人 = AUser;
                AppServer.wcfClient.CMN_单位_处室_Edit(ref md);
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_SubmitError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
            }
            try
            {
                if (!AppServer.WcfService_Open()) return;
                for (int x = 0; x < this.clb分管单位.Items.Count; x++)
                {
                    for (int i = 0; i < dtable.Rows.Count; i++)
                    {
                        if (this.clb分管单位.GetItemText(this.clb分管单位.Items[x]) == dtable.Rows[i]["全名"].ToString())
                        {
                            if (this.clb分管单位.GetItemChecked(x))
                            {
                                var model = new Ref_WS_GCGL.DataType_CMN_单位_处室();
                                model.ExAction = "MaOffice";
                                model.分管人 = AUser;
                                model.处室编码 = dtable.Rows[i]["处室编码"].ToString();
                                AppServer.wcfClient.CMN_单位_处室_Edit(ref model);
                                if (model.ExResult != 0)
                                {
                                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                                    return;
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_SubmitError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
            }
            //提交成功了
            this.DialogResult = DialogResult.OK;
        }
    }
}
