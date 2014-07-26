using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.NET;
using TY.Helper;
using System.Data.SqlClient;
namespace GCGL_Client.FZB
{
    public partial class FZB_配置标准_Editor : Form
    {
        public FZB_配置标准_Editor()
        {
            InitializeComponent();
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 9, this.btn提交, true);
            //
            try
            {
                if (!AppServer.WcfService_Open()) return;
                this.cbx车辆类型编码.DataSource = AppServer.wcfClient.FZB_编码_List("车辆类型", AppServer.LoginAreaCode).Tables[0];
                this.cbx车辆类型编码.DisplayMember = "车辆类型名称";
                this.cbx车辆类型编码.ValueMember = "车辆类型编码";
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

        private void FZB_配置标准_Editor_Load(object sender, EventArgs e)
        {

        }
        private int FDataRow;
        public void Editor_Add()
        {
            this.Text = "车辆配置标准(新增)";
            this.Tag = "新增";
            //
            FDataRow = 0;

        }

        public void Editor_Mod(DataRow row)
        {
            this.Text = "车辆配置标准(修改)";
            this.Tag = "修改";
            //
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
            FDataRow = row["ID"].ToIntegerDef(0);

            if (row["是否生效"].ToString() == "是")
            {
                chk是否生效.Checked = true;
            }
            else
            {
                chk是否生效.Checked = false;
            }
            if (row["是否新能源汽车"].ToString() == "是")
            {
              chk是否新能源汽车.Checked = true;
            }
            else
            {
                chk是否新能源汽车.Checked = false;
            }
            this.txt资产类别.Text = row["资产类别名称"].ToString();
            this.txt资产类别.Tag = row["资产类别编码"].ToString();
            this.cbx车辆类型编码.Text = row["车辆类型名称"].ToString();
            this.cbx车辆类型编码.SelectedValue = row["车辆类型编码"].ToString();
        }
        public void Editor_View(DataRow row)
        {
            this.Text = "配置标准设置(查看)";
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
            if (row["是否生效"].ToString() == "是")
            {
                chk是否生效.Checked = true;
            }
            else
            {
                chk是否生效.Checked = false;
            }

            if (row["是否新能源汽车"].ToString() == "是")
            {
                chk是否新能源汽车.Checked = true;
            }
            else
            {
                chk是否新能源汽车.Checked = false;
            }
            this.txt资产类别.Text = row["资产类别名称"].ToString();
            this.txt资产类别.Tag = row["资产类别编码"].ToString();
            this.cbx车辆类型编码.Text = row["车辆类型名称"].ToString();
            this.cbx车辆类型编码.SelectedValue = row["车辆类型编码"].ToString();
            //
            this.txt资产类别.BackColor = SystemColors.Control;
            this.btn资产类别.Visible = false;
            this.cbx车辆类型编码.Enabled = false;
            this.nud价格.Enabled = false;
            this.nud排量.Enabled = false;
            this.chk是否生效.Enabled = false;
            this.chk是否新能源汽车.Enabled = false;
            this.btn附件管理.Visible = false;
            btn提交.Visible = false;
            this.btn取消.Text = "返回(&X)";
        }
        private void btn提交_Click(object sender, EventArgs e)
        {
            if (txt资产类别.Text.Trim() == "")
            {
                AppServer.ShowMsg("资产类别不能为空！　");
                txt资产类别.Focus();
                return;
            }
            if (this.cbx车辆类型编码.Text=="")
            {
                AppServer.ShowMsg("车辆类型不能为空！　");
                this.cbx车辆类型编码.Focus();
                return;
            }
            #region 提交数据
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_车辆配置标准();

                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.ExAction = this.Tag.ToString();
                model.ID = FDataRow;
                model.车辆类型编码 = this.cbx车辆类型编码.SelectedValue.ToStringDef();
                model.资产类别编码 = this.txt资产类别.Tag.ToString();
                if (this.txt依据文件.Tag != null) model.依据文件编码 = this.txt依据文件.Tag.ToString();
                AppServer.wcfClient.CMN_车辆配置标准_Edit(ref model);
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

            this.DialogResult = DialogResult.OK;
        }

        private void btn附件管理_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt依据文件.Tag == null) this.txt依据文件.Tag = "";
                form.Editor_Mod(this.txt依据文件.Tag.ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.txt依据文件.Tag = form.FileCode;
                    this.txt依据文件.Text = form.FileInfo;
                }
            }
        }

        private void btn附件查看_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt依据文件.Tag == null) this.txt依据文件.Tag = "";
                form.Editor_See(this.txt依据文件.Tag.ToString());
                form.ShowDialog();
            }
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FZB_配置标准_Editor_KeyDown(object sender, KeyEventArgs e)
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

        private void btn资产类别_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(5);
            AppServer.Frm资产类别.SetShowParam(this.txt资产类别, 0);
            AppServer.Frm资产类别.ShowDialog();
            if (AppServer.Frm资产类别.DialogResult == DialogResult.OK)
            {
                this.txt资产类别.Tag = AppServer.Frm资产类别.SelectNodeID;
                this.txt资产类别.Text = AppServer.Frm资产类别.SelectNodeTitle;
            }
        }
    }
}
