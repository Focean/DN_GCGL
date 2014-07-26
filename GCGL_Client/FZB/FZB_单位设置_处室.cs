using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.FZB;
namespace GCGL_Client
{
    public partial class FZB_单位_处室_Editor : Form
    {
        public delegate void UpdateGridView(string AUnitCode);

        public UpdateGridView OnUpdateGrid { get; set; }

        public FZB_单位_处室_Editor()
        {
            InitializeComponent();
            try
            {
                if (!AppServer.WcfService_Open()) return;

                if (AppServer.LoginUnitIsYSDW()||AppServer.LoginUnitIsZGDW())
                {
                    this.cbx处室类型.DataSource = AppServer.wcfClient.FZB_编码_List("普通处室", AppServer.LoginAreaCode).Tables[0];
                    this.cbx处室类型.DisplayMember = "名称";
                    this.cbx处室类型.ValueMember = "编码";
                }
                else if (AppServer.LoginUnitIsCZT())
                {
                    this.cbx处室类型.DataSource = AppServer.wcfClient.FZB_编码_List("财政处室", AppServer.LoginAreaCode).Tables[0];
                    this.cbx处室类型.DisplayMember = "名称";
                    this.cbx处室类型.ValueMember = "编码";
                }
                //
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
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 25, this.btnOK, true);

        }
        public void GetCode()
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var dtm = new Ref_WS_GCGL.DataType_CMN_单位_处室();
                dtm.ExAction = "GetNewCode";
                dtm.单位编码 = this.txt单位编码.Tag.ToString();
                AppServer.wcfClient.CMN_单位_处室_List(ref dtm);
                this.txt处室编码.Text = dtm.处室编码;     
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

        private string FDataRow = null;
        //增加状态
        public void Editor_Add(string AUnitCode,string NUnitCode)
        {
            this.Text = "新建处室";
            this.Tag = "Add";
            //
            if (AppServer.LoginUnitType < 4)
            {
                this.txt单位编码.Text = NUnitCode;
                this.txt单位编码.Tag = AUnitCode;
            }
            //
            this.GetCode();
         }

        //修改状态
        public void Editor_Mod(DataRow row)
        {
            this.Text = "修改处室";
            this.Tag = "Mod";
            //
            FDataRow = row["处室编码"].ToString();
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
            this.txt单位编码.Tag=row["单位编码"].ToString();
            this.txt单位编码.Text=row["单位名称"].ToString();
            if (row["有效"].ToString() == "有效")
                this.chk有效.Checked = true;
            else
                this.chk有效.Checked = false;
            this.txt处室编码.ReadOnly = true;
        }

        private bool PostData()
        {
            if (this.txt处室编码.Text.Trim() == "")
            {
                AppServer.ShowMsg_Warn("处室编码不能为空　　", "数据验证");
                this.txt处室编码.Focus();
                return false;
            }
            if (this.txt处室名称.Text.Trim() == "")
            {
                AppServer.ShowMsg_Warn("处室名称不能为空　　", "数据验证");
                this.txt处室名称.Focus();
                return false;
            }
            //
            this.DialogResult = DialogResult.None;
            try
            {
                if (!AppServer.WcfService_Open()) return false;
                var dtm = new Ref_WS_GCGL.DataType_CMN_单位_处室();
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, dtm);
                dtm.ExAction = this.Tag.ToString();
                dtm.单位编码 = this.txt单位编码.Tag.ToString();
                dtm.LoginUserCode = AppServer.LoginUserCode; 
                AppServer.wcfClient.CMN_单位_处室_Edit(ref dtm);
                //
                if (dtm.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(dtm.ErrorMsg);
                    switch (dtm.ExResult)
                    {
                        case 1: this.txt处室编码.Focus(); break;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return false;
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }
            //
            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.PostData()) return;
            if (this.OnUpdateGrid != null) this.OnUpdateGrid(this.txt单位编码.Tag.ToString());
            //提交成功了
            this.DialogResult = DialogResult.OK;
        }

        private void Man_单位_处室_Editor_Load(object sender, EventArgs e)
        {
            
        }

        private void btn提交并继续_Click(object sender, EventArgs e)
        {
            if (!this.PostData()) return;
            //
            this.txt处室名称.Text = "";
            if (this.OnUpdateGrid != null) this.OnUpdateGrid(this.txt单位编码.Tag.ToString());
            this.Editor_Add(this.txt单位编码.Tag.ToString(), this.txt单位编码.Text); 
        }

        private void txt处室编码_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void FZB_单位_处室_Editor_KeyDown(object sender, KeyEventArgs e)
        {
            //单键 
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btnCancel_Click(this, EventArgs.Empty);
                    break;
            }

            // 组合键
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)         //Ctrl+s
            {
                btnOK_Click(this, EventArgs.Empty);
            }
        }       
    }
}
