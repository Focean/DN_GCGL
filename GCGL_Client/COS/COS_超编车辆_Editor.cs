using GCGL_Client.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.COS
{
    public partial class COS_超编车辆_Editor : Form
    {
        public COS_超编车辆_Editor()
        {
            InitializeComponent();
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 30, this.btn提交, true);
            //
            try
            {
                if (!AppServer.WcfService_Open()) return;
                this.cbx采购形式编码.DataSource = AppServer.wcfClient.FZB_编码_List("采购形式1", AppServer.LoginAreaCode).Tables[0];
                this.cbx采购形式编码.DisplayMember = "名称";
                this.cbx采购形式编码.ValueMember = "编码";
                //
                this.cbx排气量.DataSource = AppServer.wcfClient.FZB_编码_List("排气量", AppServer.LoginAreaCode).Tables[0];
                this.cbx排气量.DisplayMember = "名称";
                this.cbx排气量.ValueMember = "名称";
                //
                this.cbx车辆类型编码.DataSource = AppServer.wcfClient.FZB_编码_List("车辆类型", AppServer.LoginAreaCode).Tables[0];
                this.cbx车辆类型编码.DisplayMember = "车辆类型名称";
                this.cbx车辆类型编码.ValueMember = "车辆类型编码";

                DataTable dt3 = null;
                dt3 = AppServer.wcfClient.FZB_编码_List("座位数", AppServer.LoginAreaCode).Tables[0];
                if (dt3.Rows.Count > 0)
                {
                    for (int i = 0; i < dt3.Rows.Count; i++)
                    {
                        this.cbx座位数.Items.Add(dt3.Rows[i][2].ToString());
                    }
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
        }

        //
        private string Code = null;
        private string Rcode = null;
        public void Editor_Mod(DataRow row)
        {
            this.Text = "超编车辆信息(修改)";
            this.Tag = "Mod";
            Code = row["资产编号"].ToString();
            Rcode = row["超编编码"].ToString();
            
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
            this.txt资产类别编码.Tag = row["资产类别编码"].ToString();
            this.txt资产类别编码.Text = row["资产类别名称"].ToString();

            this.txt票据附件.Text = row["购车票据"].ToString();
            this.txt票据附件.Tag = row["购车票据附件"].ToString();

            this.txt备案信息附件.Text = row["备案信息"].ToString();
            this.txt备案信息附件.Tag = row["备案信息附件"].ToString();

            this.txt行驶证附件.Text = row["行驶证"].ToString();
            this.txt行驶证附件.Tag = row["行驶证附件"].ToString();
        }

        private void btn提交_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;

                var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);

                model.ExAction = this.Tag.ToString();
                model.LoginUserCode = AppServer.LoginUserCode;
                model.单位编码 = AppServer.LoginUnitCode;
                model.资产编号 = Code;
                model.超编编码 = Rcode;
                model.编制情况 = "超编";
                model.资产类别编码 = this.txt资产类别编码.Tag.ToString();
                if (this.txt票据附件.Tag != null) model.购车票据附件 = this.txt票据附件.Tag.ToString();
                if (this.txt行驶证附件.Tag != null) model.行驶证附件 = this.txt行驶证附件.Tag.ToString();
                if (this.txt备案信息附件.Tag != null) model.备案信息附件 = this.txt备案信息附件.Tag.ToString();

                AppServer.wcfClient.COS_车辆超编_Edit(ref model);
                //
                if (model.ExResult != 0)
                {
                    if (model.ExResult == 3)
                    {
                        AppServer.ShowMsg(model.ErrorMsg, "提示");
                        return;
                    }
                    AppServer.HideWaitForm();
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }                
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
            //
            this.DialogResult = DialogResult.OK;
        }

        private void btn资产类别_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(5);
            AppServer.Frm资产类别.SetShowParam(this.txt资产类别编码, 0);
            AppServer.Frm资产类别.ShowDialog();
            if (AppServer.Frm资产类别.DialogResult == DialogResult.OK)
            {
                this.txt资产类别编码.Tag = AppServer.Frm资产类别.SelectNodeID;
                this.txt资产类别编码.Text = AppServer.Frm资产类别.SelectNodeTitle;
            }
        }

        private void txt车架号_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == 8)//退格键是8
                e.Handled = false;
            else e.Handled = true;
        }

        private void txt发动机号_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == 8)//退格键是8
                e.Handled = false;
            else e.Handled = true;
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn附件管理_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt票据附件.Tag == null) this.txt票据附件.Tag = "";
                form.Editor_Mod(this.txt票据附件.Tag.ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.txt票据附件.Tag = form.FileCode;
                    this.txt票据附件.Text = form.FileInfo;
                }
            }
        }

        private void btn备案信息附件_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt备案信息附件.Tag == null) this.txt备案信息附件.Tag = "";
                form.Editor_Mod(this.txt备案信息附件.Tag.ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.txt备案信息附件.Tag = form.FileCode;
                    this.txt备案信息附件.Text = form.FileInfo;
                }
            }
        }

        private void btn行驶证附件_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt行驶证附件.Tag == null) this.txt行驶证附件.Tag = "";
                form.Editor_Mod(this.txt行驶证附件.Tag.ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.txt行驶证附件.Tag = form.FileCode;
                    this.txt行驶证附件.Text = form.FileInfo;
                }
            }
        }

        private void btn行驶证查看_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt行驶证附件.Tag == null) this.txt行驶证附件.Tag = "";
                form.Editor_See(this.txt行驶证附件.Tag.ToString());
                form.ShowDialog();
            }
        }

        private void btn备案信息查看_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt备案信息附件.Tag == null) this.txt备案信息附件.Tag = "";
                form.Editor_See(this.txt备案信息附件.Tag.ToString());
                form.ShowDialog();
            }   
        }

        private void btn附件查看_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt票据附件.Tag == null) this.txt票据附件.Tag = "";
                form.Editor_See(this.txt票据附件.Tag.ToString());
                form.ShowDialog();
            }
        }
    }
}
