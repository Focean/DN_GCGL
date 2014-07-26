using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
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
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                this.cbx单位性质编码.DataSource = AppServer.wcfClient.FZB_编码_List("单位性质",AppServer.LoginAreaCode).Tables[0];
                this.cbx单位性质编码.DisplayMember = "单位性质名称";
                this.cbx单位性质编码.ValueMember = "单位性质编码";
                //
                this.cbx单位类型编码.DataSource = AppServer.wcfClient.FZB_编码_List("单位类型", AppServer.LoginAreaCode).Tables[0];
                this.cbx单位类型编码.DisplayMember = "单位类型名称";
                this.cbx单位类型编码.ValueMember = "单位类型编码";
                //
                this.cbx部门预算处室编码.DataSource = AppServer.wcfClient.FZB_编码_List("部门预算处室编码", AppServer.LoginAreaCode).Tables[0];
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
            //
            if (AppServer.LoginUnitIsYSDW() || AppServer.LoginUnitIsGWC())
            {
                this.cbx单位类型编码.Enabled = false;
            }
        }

        public string UnitCode { get; set; }
        public string BCode { get; set; }
        private DataRow FDataRow;
        private DataTable table;
        public void Editor_Add(string AUnitPCode,DataRow dr)
        {
            this.Text = "单位(新增)";
            this.Tag = "Add";
            FDataRow = dr;
            if (AppServer.LoginUnitIsQH())
            {
                this.txt区划编码.Text = AppServer.LoginAreaName;
                this.txt区划编码.Tag = AppServer.LoginAreaCode;
                this.txt上级编码.Text = AppServer.LoginUnitName;
                this.txt上级编码.Tag = AppServer.LoginUnitCode;
                this.cbx单位类型编码.SelectedValue = 2;
                this.cbx单位类型编码.Enabled = false;
            }
            else if (AppServer.LoginUnitIsCZT())
            {
                this.txt区划编码.Text = AppServer.LoginAreaName;
                this.txt区划编码.Tag = AppServer.LoginAreaCode;
                this.cbx部门预算处室编码.SelectedValue = AUnitPCode;
                this.cbx部门预算处室编码.Enabled = false;
                this.txt上级编码.Text = AppServer.LoginUnitName ;
                this.txt上级编码.Tag = AppServer.LoginUnitCode;
                this.cbx单位类型编码.SelectedValue = 2;
                this.cbx单位类型编码.Enabled = false;
            }
            else if (AppServer.LoginUnitIsYSDW() || AppServer.LoginUnitIsZGDW())
            {
                this.label23.Visible = false;
                try
                {
                    if (!AppServer.WcfService_Open()) return;
                    //
                    var model = new Ref_WS_GCGL.DataType_CMN_单位();
                    model.单位编码 = AUnitPCode;
                    table = AppServer.wcfClient.CMN_单位_List(ref model).Tables[0];
                    this.txt区划编码.Text = "(" + table.Rows[0]["区划编码"].ToString() + ")" + table.Rows[0]["区划名称"].ToString();
                    this.txt区划编码.Tag = table.Rows[0]["区划编码"].ToString();

                    this.txt上级编码.Text = "(" + table.Rows[0]["预算编码"].ToString() + ")" + table.Rows[0]["单位名称"].ToString();
                    this.txt上级编码.Tag = table.Rows[0]["单位编码"].ToString();

                    this.cbx单位类型编码.SelectedValue = 1;
                    this.cbx单位类型编码.Enabled = false;
                   // this.cbx部门预算处室编码.Visible = false;
                    this.lbl财政归口处室.Visible = false;
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
                    FDataRow = table.Rows[0];
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

            TY.Helper.FormHelper.DataBinding_DataSourceToUI(FDataRow, this);
            if (AppServer.LoginUnitIsQH() || AppServer.LoginUnitIsCZT())
            {
                this.cbx部门预算处室编码.Enabled = true;
            }
            if (AppServer.LoginUnitIsYSDW())
            {
                this.txt单位名称.ReadOnly = true;
                this.txt单位名称.BackColor = SystemColors.Control;
            }
            this.txt区划编码.Text = FDataRow["区划编码"].ToString() + "(" + FDataRow["区划名称"].ToString() + ")";
            this.txt区划编码.Tag = FDataRow["区划编码"].ToString();


            this.txt上级编码.Tag = FDataRow["上级编码"].ToString();
            this.txt上级编码.Text = "(" + FDataRow["预算编码"].ToString() + ")" + FDataRow["上级单位名称"].ToString(); 

            this.cbx单位性质编码.Text = FDataRow["单位性质名称"].ToString();
            this.cbx单位性质编码.SelectedValue = FDataRow["单位性质编码"].ToString();

            this.cbx单位类型编码.Text = FDataRow["单位类型名称"].ToString();
            this.cbx单位类型编码.SelectedValue = FDataRow["单位类型编码"].ToString();
            this.cbx单位类型编码.Enabled = false;
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
            if (this.txt预算编码.Text.Trim() == "")
            {
                AppServer.ShowMsg("单位编码不能为空！", "提示");
                this.txt预算编码.Focus();
                return;
            }
           
            if (this.txt单位名称.Text.Trim() == "")
            {
                AppServer.ShowMsg("单位名称不能为空！", "提示");
                this.txt单位名称.Focus();
                return;
            }
            if (AppServer.LoginUnitIsYSDW())
            {
                if (this.txt组织代码证号.Text.Trim() == "")
                {
                    AppServer.ShowMsg("组织代码证号不能为空！", "提示");
                    this.txt组织代码证号.Focus();
                    return;
                }
                if (this.txt级别.Text.Trim() == "")
                {
                    AppServer.ShowMsg("单位级别不能为空！", "提示");
                    this.txt级别.Focus();
                    return;
                }
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
            if (txt传真.Text.Trim() != "")
            {
                if (!reg.IsMatch(txt传真.Text.Trim()))
                {
                    AppServer.ShowMsg("请检查输入的传真是否正确！", "提示");
                    this.txt传真.Focus();
                    return;
                }
            }
            #region 提交数据

            this.UnitCode = string.Format("{0}_{1}", this.txt区划编码.Tag, this.txt预算编码.Text);
            this.BCode = string.Format("{0}", this.cbx部门预算处室编码.SelectedValue.ToString());
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_单位();
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.ExAction = this.Tag.ToString();
                model.LoginUserCode = AppServer.LoginUserCode;
                model.区划编码 = this.txt区划编码.Tag.ToString();
                model.单位类型编码 = this.cbx单位类型编码.SelectedValue.ToIntegerDef();
               if(this.cbx部门预算处室编码.SelectedValue!=null) 
                   model.部门预算处室编码=this.cbx部门预算处室编码.SelectedValue.ToString();
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
                else
                {
                    this.Tag = "(" + this.txt区划编码.Tag.ToString() + "_" + this.txt预算编码.Text.ToString() + ")" + this.txt单位名称.Text.ToString();                   
                }
                //
                var mdl = new Ref_WS_GCGL.DataType_CMN_单位();
                mdl.ExAction = "UnitMngrTree";
                mdl.LoginUserCode = AppServer.LoginUserCode;
                mdl.区划编码 = AppServer.LoginAreaCode;
                mdl.单位编码 = AppServer.LoginUnitCode;
                mdl.单位类型编码 = AppServer.LoginUnitType;
                DataSet dset = AppServer.wcfClient.CMN_单位_List(ref mdl);
                AppServer.UdataTable = dset.Tables[0];
                //
                AppServer.ChangeTime = AppServer.wcfClient.CMN_单位_更新_List();
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
            this.DialogResult = DialogResult.OK;
            
        }

        private void txt预算编码_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void txt组织代码证号_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8 || e.KeyChar == '-' || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FZB_单位设置_Editor_KeyDown(object sender, KeyEventArgs e)
        {
            //单键 
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btn取消_Click(this, EventArgs.Empty);
                    break;
            }

            // 组合键
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)         //Ctrl+s
            {
               this.btn提交_Click(this, EventArgs.Empty);
            }
        }

        private void cbx单位类型编码_TextChanged(object sender, EventArgs e)
        {
            if (this.cbx单位类型编码.SelectedValue.ToIntegerDef() == 1)//预算单位
            {
                this.cbx部门预算处室编码.Visible = false;
                this.lbl财政归口处室.Visible = false;
                this.cbx单位性质编码.Visible = true;
                this.lbl单位性质.Visible = true;
            }
            else if(this.cbx单位类型编码.SelectedValue.ToIntegerDef() == 2)//主管单位
            {
                this.cbx部门预算处室编码.Visible = true;
                this.lbl财政归口处室.Visible = true;
                this.cbx单位性质编码.Visible=false;
                this.lbl单位性质.Visible=false;
            }
        }
    }
}
