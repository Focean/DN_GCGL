using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.NET
{
    public partial class NET_公文法规_公文 : Form
    {
        public NET_公文法规_公文()
        {
            InitializeComponent();
        }
       
        public void Editor_Add()
        {
            this.Text = "发布新的公文";
            this.Tag = "Add";
            //    
            this.dN_HtmlEditor1.Visible = true;
            this.webBrowser1.Visible = false;
        }

        public void Editor_Mod(string GW)
        {
            this.Text = "修改公文";
            this.Tag = "Mod";
            //
            this.btnOk.Tag = GW;
            DataBinding_GridView(GW);
        }

        public void Editor_See(string GW)
        {
            this.Text = "查看公文";
            this.Tag = "See";       
            this.btnOk.Enabled = false;
            this.txt公文标题.ReadOnly = true;
            this.dN_HtmlEditor1.Visible = false;
            this.webBrowser1.Visible = true;
            DataBinding_GridView(GW);
            this.btn附件管理.Enabled = false;
            this.btnCancel.Text = "返回(ESC)";
        }

        private void DataBinding_GridView(String GWBM)
        {
            try
            {
                var model = new Ref_WS_GCGL.DataType_NET_公文();
                model.ExAction = "See";
                model.公文编码 = GWBM;
                //
                var model2 = new Ref_WS_GCGL.DataType_NET_附件管理();
                model2.ExAction = "List";
                if (!AppServer.WcfService_Open()) return;
                //
                DataSet ds = AppServer.wcfClient.NET_公文_List(ref model);
                if (ds.Tables[0].Rows.Count == 0) return;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    TY.Helper.FormHelper.DataBinding_DataSourceToUI(ds.Tables[0], this);
                    using (WebBrowser webBrowser1 = new WebBrowser())
                    {
                        this.webBrowser1.DocumentText = ds.Tables[0].Rows[0]["公文内容"].ToString(); ;
                        this.webBrowser1.Document.Write(this.webBrowser1.DocumentText);
                        this.webBrowser1.Document.Write(ds.Tables[0].Rows[0]["公文内容"].ToString());
                    }
                }
                this.txt附件信息.Tag = ds.Tables[0].Rows[0]["附件编码"].ToString();
                this.txt附件信息.Text = ds.Tables[0].Rows[0]["附件摘要"].ToString();
              
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

        public void PostData()
        {
            if (this.txt公文标题.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("公文标题不能为空！");
                this.txt公文标题.Focus();
                return;
            }
            if (this.dN_HtmlEditor1.BodyText == null)
            {
                AppServer.ShowMsg("公文内容不能为空！");
                this.dN_HtmlEditor1.Focus();
                return;
            }
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_NET_公文();
                model.ExAction = this.Tag.ToString();              
                if (this.Tag.ToString() == "Mod")
                model.公文编码 = this.btnOk.Tag.ToString();
                model.公文标题 = this.txt公文标题.Text.ToString();
                model.公文内容 = this.dN_HtmlEditor1.HtmlText.ToString();
                model.创建人编码 = AppServer.LoginUserCode;
                model.单位编码 = AppServer.LoginUnitCode;
                model.接收单位编码 = "All";
                model.公文类型 = "公文";
                if (this.txt附件信息.Tag == null)
                    model.附件编码 = "";
                else
                    model.附件编码 = this.txt附件信息.Tag.ToString();
                AppServer.wcfClient.NET_公文_Edit(ref model);
                if (model.ExResult != 0)AppServer.ShowMsg_Error(model.ErrorMsg);
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
            this.DialogResult = DialogResult.OK;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {            
            PostData();
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
