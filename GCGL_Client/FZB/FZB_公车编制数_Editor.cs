using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.NET;
using GCGL_Client.Main;

namespace GCGL_Client.FZB
{
    public partial class FZB_公车编制数_Editor : Form
    {
        public FZB_公车编制数_Editor()
        {

            InitializeComponent();
            //
            if (AppServer.LoginUnitIsYSDW())
            {
                this.txt单位编码.Text = AppServer.LoginUnitName;
                this.txt单位编码.Tag = AppServer.LoginUnitCode;
                GetV();
            }
        }
        public void Editor_Add(bool IView=false)
        {
            this.Text = "编制申报(新增)";
            this.Tag = "Add";
            this.btn选择单位.Visible = IView;
            // 
        }
        private int FID;
      
        public void Editor_Mod(DataRow  FDataRow)
        {
            this.Text = "编制申报(修改)";
            this.Tag = "Mod";
            //   
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(FDataRow, this);
            this.txt单位编码.Text = FDataRow["单位名称"].ToString();
            this.txt单位编码.Tag = FDataRow["单位编码"].ToString();
            this.btn保存.Tag = FDataRow["ID"].ToString();
            this.txt附件信息.Tag=FDataRow["附件编码"].ToString();
            this.txt附件信息.Text = FDataRow["附件摘要"].ToString();
            GetV();
        }
        public void Editor_See(string ACardCode=null, bool AEmebMode = false)
        {
            this.Text = "编制数(查看）";
            this.Tag = "See";
            //
            FID = Convert.ToInt32(ACardCode);
            //
            if (!AppServer.WcfService_Open()) return;
            var model = new Ref_WS_GCGL.DataType_CMN_单位_编制();
            model.ExAction = "GetV";
            model.ID = FID;
            DataSet ds = AppServer.wcfClient.CMN_单位_编制_List(ref model);
            DataTable dt = ds.Tables[0];
            this.txt单位编码.Text = dt.Rows[0]["单位名称"].ToString();
            this.txt单位编码.Tag = dt.Rows[0]["单位编码"].ToString();
            nud一般公务用车编制数.Value = Convert.ToInt32(dt.Rows[0]["一般公务用车编制数"].ToString());
            nud一般执法执勤用车编制数.Value = Convert.ToInt32(dt.Rows[0]["一般执法执勤用车编制数"].ToString());
            nud特种专业技术用车编制数.Value = Convert.ToInt32(dt.Rows[0]["特种专业技术用车编制数"].ToString());
            this.txt备注.Text = dt.Rows[0]["备注"].ToString();
            this.txt附件信息.Text = dt.Rows[0]["附件摘要"].ToString();
            this.txt附件信息.Tag=dt.Rows[0]["附件编码"].ToString();
            //
            GetV();
            //
            this.nud特种专业技术用车编制数.Enabled = false;
            this.nud一般公务用车编制数.Enabled = false;
            this.nud一般执法执勤用车编制数.Enabled = false;
            this.btn选择单位.Visible = false;
            this.txt备注.ReadOnly = true;
            this.txt备注.BackColor = SystemColors.Control;
            this.btn保存.Visible = false;
            this.btn附件管理.Visible = false;
            this.btn提交.Visible = false;
            this.btn取消.Text = "返回";
            //嵌入式状态不显示工具栏
            this.pnlTool.Visible = !AEmebMode;
        }
        private void PostData(Boolean ASubmit)
        {
            #region 控件验证
            if (this.txt单位编码.Tag == null || this.txt单位编码.Tag.ToString()=="")
            {
                AppServer.ShowMsg_Warn("单位名称不能为空","警告");
                this.txt单位编码.Focus();
                return;
            }
            if (ASubmit)
            {
                if (this.txt附件信息.Tag == null || this.txt附件信息.Tag.ToString()=="")
                {
                    AppServer.ShowMsg_Warn("编制依据文件不能为空", "警告");
                    this.txt附件信息.Focus();
                    return;
                }
            }
            #endregion

            #region 提交数据
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_单位_编制();
                model.ExAction = this.Tag.ToString();
                model.LoginUserCode = AppServer.LoginUserCode;
                if(this.btn保存.Tag!=null)
                    model.ID =Convert.ToInt32(this.btn保存.Tag.ToString());
                if (AppServer.LoginUnitIsYSDW())
                    model.单位编码 = AppServer.LoginUnitCode;
                else
                {
                    if (this.txt单位编码.Tag != null)
                        model.单位编码 = this.txt单位编码.Tag.ToString();
                }
                model.创建人编码 = AppServer.LoginUserCode;
                model.一般公务用车编制数 = Convert.ToInt32(this.nud一般公务用车编制数.Value);
                model.一般执法执勤用车编制数 = Convert.ToInt32(this.nud一般执法执勤用车编制数.Value);
                model.特种专业技术用车编制数 = Convert.ToInt32(this.nud特种专业技术用车编制数.Value);
                if (this.txt附件信息.Tag != null) model.附件编码 = this.txt附件信息.Tag.ToString();
                model.备注 = this.txt备注.Text;
                //开始保存
                //AppServer.ShowWaitForm();
                //AppServer.DataImport("正在保存数据，请稍等...", 20, 100, true);
                AppServer.wcfClient.CMN_单位_编制_Edit(ref model);
                //
                if (model.ExResult != 0)
                {
                    AppServer.HideWaitForm();
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                //此时记住已保存成功了，如果是新增状态可变为修改状态了，防止提交不成功后重复新增数据
                if (this.Tag.ToString() == "Add")
                {
                    this.Tag = "Mod";
                    this.btn保存.Tag = model.ID;
                }
                //
                if (ASubmit)
                {
                    model.ExAction = "Submit";
                    model.ID =Convert.ToInt32(this.btn保存.Tag.ToString());
                    AppServer.wcfClient.CMN_单位_编制_Edit(ref model);
                    if (model.ExResult != 0)
                    {
                        AppServer.HideWaitForm();
                        AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                        return;
                    }
                }
                //AppServer.DataImport("数据保存已成功完成！", 100, 100, false);
                //AppServer.HideWaitForm();
                //
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
            #endregion
        }

        public void GetV()
        {
            if (this.txt单位编码.Tag == null || this.txt单位编码.Tag.ToString() == "")
                return;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_CMN_单位();
                model.ExAction = "GetVehicle";
                if (this.txt单位编码.Tag != null)
                    model.单位编码 = this.txt单位编码.Tag.ToString();
                DataSet db = AppServer.wcfClient.CMN_单位_List(ref model);
                DataTable table = db.Tables[0];
                this.txt一般公务用车编制数.Text = table.Rows[0]["一般公务用车编制数"].ToString();
                this.txt一般执法执勤用车编制数.Text = table.Rows[0]["一般执法执勤用车编制数"].ToString();
                this.txt特种专业技术用车编制数.Text = table.Rows[0]["特种专业技术用车编制数"].ToString();
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

        private void btn保存_Click(object sender, EventArgs e)
        {
            this.PostData(false);
        }
        private void btn提交_Click(object sender, EventArgs e)
        {
            this.PostData(true);
        }

        private void btn附件管理_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt附件信息.Tag == null) this.txt附件信息.Tag = "";
                form.Editor_Mod(this.txt附件信息.Tag.ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.txt附件信息.Tag = form.FileCode;
                    this.txt附件信息.Text = form.FileInfo;
                }
            }
        }      

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FZB_公车编制数_Editor_KeyDown(object sender, KeyEventArgs e)
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
                btn提交_Click(this, EventArgs.Empty);
            }
        }
        
        private void btn选择单位_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(2);
            AppServer.Frm单位信息.SetShowParam(this.txt单位编码, 0);
            AppServer.Frm单位信息.ShowDialog();
            if (AppServer.Frm单位信息.DialogResult == DialogResult.OK)
            {
                this.txt单位编码.Tag = AppServer.Frm单位信息.SelectNodeID;
                this.txt单位编码.Text = AppServer.Frm单位信息.SelectNodeTitle;
            }
            GetV();
            AppServer.Frm单位信息.Hide();
        }

        private void btn附件查看_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt附件信息.Tag == null) this.txt附件信息.Tag = "";
                form.Editor_See(this.txt附件信息.Tag.ToString());
                form.ShowDialog();
            }
        }
    }
}
