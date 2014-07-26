using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.Common;
using System.Text.RegularExpressions;
namespace GCGL_Client.FZB
{
    public partial class FZB_单位设置_Editor : Form
    {
        public FZB_单位设置_Editor()
        {
            InitializeComponent();
            //
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                this.cbx单位性质编码.DataSource = AppServer.wcfClient.FZB_编码_List("单位性质").Tables[0];
                this.cbx单位性质编码.DisplayMember = "单位性质名称";
                this.cbx单位性质编码.ValueMember = "单位性质编码"; 
                //
                this.cbx单位类型编码.DataSource = AppServer.wcfClient.FZB_编码_List("单位类型").Tables[0];
                this.cbx单位类型编码.DisplayMember = "单位类型名称";
                this.cbx单位类型编码.ValueMember = "单位类型编码";
                //
                this.cbx部门预算处室编码.DataSource = AppServer.wcfClient.FZB_编码_List("部门预算处室编码").Tables[0];
                this.cbx部门预算处室编码.DisplayMember = "全名";
                this.cbx部门预算处室编码.ValueMember = "处室编码";
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
            //
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 18, this.btn提交, true);
        }

        public string UnitCode { get; set; }

        public void Editor_Add(string AUnitPCode)
        {
            this.Text = "单位(新增)";
            this.Tag = "Add";
            //
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_CMN_单位();
                model.单位编码 = AUnitPCode;
                DataTable table = AppServer.wcfClient.CMN_单位_List(ref model).Tables[0];
                txt区划编码.Text = table.Rows[0]["区划编码"].ToString();
                txt上级编码.Text = table.Rows[0]["单位名称"].ToString();
                txt上级编码.Tag  = table.Rows[0]["单位编码"].ToString();
                if (AppServer.LoginUnitType == 0)  //如果是区划管理员
                {
                    this.txt上级编码.Text = AppServer.LoginUnitName;
                    this.txt上级编码.Tag = AppServer.LoginUnitCode;
                }
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);            
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }
        }

        public void Editor_Mod(DataRow row)
        {
            this.Text = "单位(修改)";
            this.Tag = "Mod";
            //
            this.txt预算编码.Text=row["预算编码"].ToString();
            if (row == null) return;
            else
            {
                try
                {
                    var dtm = new Ref_WS_GCGL.DataType_CMN_单位();
                    dtm.ExAction = "GetSubList";
                    dtm.单位编码 = row["单位编码"].ToString();
                    if (!AppServer.WcfService_Open()) return;
                    //
                    DataTable table = AppServer.wcfClient.CMN_单位_List(ref dtm).Tables[0];
                    if (table.Rows.Count == 0) return;
                    row = table.Rows[0];
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
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
            txt上级编码.Tag=row["区划编码"].ToString();
            txt上级编码.Tag = row["上级编码"].ToString();
            txt上级编码.Text=row["上级单位名称"].ToString();
        }

        private void btn提交_Click(object sender, EventArgs e)
        {           
            //电话号码和手机验证
            string s_reg = @"((\d{11})|^((\d{7,8})|(\d{4}|\d{3})-(\d{7,8})|(\d{4}|\d{3})-(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1})|(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1}))$)";
            string y_reg = @"([1-9]\d{5}(?!d))";//邮编验证
            Regex reg_y = new Regex(y_reg);
            Regex reg = new Regex(s_reg);
            if (txt邮编.Text != "")
            {
                if (!reg_y.IsMatch(txt邮编.Text.Trim()))
                {
                    AppServer.ShowMsg("请检查输入的邮编是否正确！", "提示");
                    this.txt邮编.Focus();
                    return;
                }
            }
            if (this.txt预算编码.Text == "")
            {
                AppServer.ShowMsg("单位编码不能为空！", "提示");
                this.txt预算编码.Focus();
                return;
            }
            if (this.txt单位名称.Text == "")
            {
                AppServer.ShowMsg("单位名称不能为空！", "提示");
                this.txt单位名称.Focus();
                return;
            }
            if (this.txt组织代码证号.Text == "")
            {
                AppServer.ShowMsg("组织代码证号不能为空！", "提示");
                this.txt组织代码证号.Focus();
                return;
            }
            if (txt电话.Text.Trim() != "")
            {
                if (!reg.IsMatch(txt电话.Text.Trim()))
                {
                    AppServer.ShowMsg("请检查输入的联系电话是否正确！", "提示");
                    this.txt电话.Focus();
                    return;
                }
            }
            #region 提交数据

            this.UnitCode = string.Format("{0}_{1}", this.txt区划编码.Text, this.txt预算编码.Text);
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_单位();               
                model.ExAction = this.Tag.ToString();
                model.LoginUserCode = AppServer.LoginUserCode;
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);

                if (txt上级编码.Tag == null)
                {
                    model.上级编码 = null;
                }
                else
                {
                    model.上级编码 = txt上级编码.Tag.ToString();
                }
                model.单位编码 = this.UnitCode;
                AppServer.wcfClient.CMN_单位_Edit(ref model);
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
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
            #endregion
            //          
            this.Tag = "(" + this.txt区划编码.Text+"_"+this.txt预算编码.Text.ToString() + ")" + this.txt单位名称.Text.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
