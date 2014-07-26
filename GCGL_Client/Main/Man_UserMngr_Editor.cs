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
    public partial class Man_UserMngr_Editor : Form
    {
        public Man_UserMngr_Editor()
        {
            InitializeComponent();
            //
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 6, this.btnOK, true);
        }

        private void Man_UserMngr_Editor_Load(object sender, EventArgs e)
        {
        }

        private string _CurrUnitCode;
        private string CurrUnitCode
        {
            get { return _CurrUnitCode; }
            set 
            {
                _CurrUnitCode = value;
                //
                base.Cursor = Cursors.WaitCursor;
                try
                {
                    if (!AppServer.WcfService_Open()) return;
                    //
                    var dtm = new Ref_WS_GCGL.DataType_CMN_单位();
                    dtm.单位编码 = _CurrUnitCode;
                    DataTable table = AppServer.wcfClient.CMN_单位_List(ref dtm).Tables[0];
                    if (table.Rows.Count == 0) return;
                    this.txt所属单位.Text = string.Format("({0}){1}", table.Rows[0]["单位编码"].ToString(), table.Rows[0]["单位名称"].ToString());
                    //
                    var model_cs = new Ref_WS_GCGL.DataType_CMN_单位_处室();
                    model_cs.ExAction = "List";
                    model_cs.单位编码 = _CurrUnitCode;
                    this.cbx处室编码.DataSource = AppServer.wcfClient.CMN_单位_处室_List(ref model_cs).Tables[0];
                    this.cbx处室编码.DisplayMember = "处室名称";
                    this.cbx处室编码.ValueMember = "处室编码";
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

        //增加状态
        public void Editor_Add(string AUnitCode)
        {
            this.Text = "新建用户";
            this.Tag = "Add";
            this.txtUserCode.Focus();

            this.CurrUnitCode = AUnitCode;
        }

        //修改状态
        public void Editor_Mod(string AUserCode, DataRow row)
        {
            this.Text = "修改用户";
            this.Tag = "Mod";
            //
            this.CurrUnitCode = row["单位编码"].ToString();
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);

            this.txtUserCode.ReadOnly = true;
            this.txtUserName.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtUserCode.Text.Trim() == "")
            {
                AppServer.ShowMsg_Warn("用户账号不能为空　　", "数据验证");
                this.txtUserCode.Focus();
                return;
            }
            if (this.txtUserName.Text.Trim() == "")
            {
                AppServer.ShowMsg_Warn("用户名称不能为空　　", "数据验证");
                this.txtUserName.Focus();
                return;
            }
            //if (this.cbx处室编码.SelectedValue == null)
            //{
            //    AppServer.ShowMsg_Warn("用户所在处室不能为空　　", "数据验证");
            //    this.cbx处室编码.Focus();
            //    return;
            //}
            //
            this.DialogResult = DialogResult.None;
            try
            {
                var dtm = new Ref_WS_GCGL.DataType_User();
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, dtm);
                dtm.ExAction = this.Tag.ToString();
                dtm.UnitCode = _CurrUnitCode;
                if (this.cbx处室编码.SelectedValue != null) dtm.DeptCode = this.cbx处室编码.SelectedValue.ToString();
                
                if (!AppServer.WcfService_Open()) return;

                AppServer.wcfClient.Sys_User_Edit(ref dtm);

                if (dtm.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(dtm.ErrorMsg);
                    switch (dtm.ExResult)
                    {
                        case 1: this.txtUserCode.Focus(); break;
                    }
                    return;
                }
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
            //提交成功了
            this.DialogResult = DialogResult.OK;
        }

        private void txtUserCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == '@' || e.KeyChar == '#' || e.KeyChar == '_')
                e.Handled = false;
            else e.Handled = true;
        }

    }
}
