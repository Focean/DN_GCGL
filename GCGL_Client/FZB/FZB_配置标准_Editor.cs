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
            txt车辆类型.Text = row["车辆类型名称"].ToString();
            txt车辆类型.Tag = row["车辆类型编码"].ToString();
            txt资产类别.Text = row["资产类别名称"].ToString();
            txt资产类别.Tag = row["资产类别编码"].ToString();
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
            txt车辆类型.Text = row["车辆类型名称"].ToString();
            txt车辆类型.Tag = row["车辆类型编码"].ToString();
            txt资产类别.Text = row["资产类别名称"].ToString();
            txt资产类别.Tag = row["资产类别编码"].ToString();
            btn提交.Enabled = false;
            this.btn取消.Text = "返回(&X)";
        }
        private void btn提交_Click(object sender, EventArgs e)
        {
            if (txt车辆类型.Text.Trim() == "")
            {
                AppServer.ShowMsg("车辆类型不能为空！　");
                txt车辆类型.Focus();
                return;
            }
            if (txt资产类别.Text.Trim() == "")
            {
                AppServer.ShowMsg("资产类别不能为空！　");
                txt资产类别.Focus();
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
                model.资产类别编码 = this.txt资产类别.Tag.ToString();
                model.车辆类型编码 = this.txt车辆类型.Tag.ToString();
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

        private void btn车辆类型_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(5);
            AppServer.Frm车辆类型.SetShowParam(this.txt车辆类型, 0);
            AppServer.Frm车辆类型.ShowDialog();
            if (AppServer.Frm车辆类型.DialogResult == DialogResult.OK)
            {
                this.txt车辆类型.Tag = AppServer.Frm车辆类型.SelectNodeID;
                this.txt车辆类型.Text = AppServer.Frm车辆类型.SelectNodeTitle;
            }
        }

        private void btn资产类别_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(4);
            AppServer.Frm资产类别.SetShowParam(this.txt资产类别, 0);
            AppServer.Frm资产类别.ShowDialog();
            if (AppServer.Frm资产类别.DialogResult == DialogResult.OK)
            {
                this.txt资产类别.Tag = AppServer.Frm资产类别.SelectNodeID;
                this.txt资产类别.Text = AppServer.Frm资产类别.SelectNodeTitle;
            }
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

    }
}
