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
    public partial class NET_公告通知_通知 : Form
    {
        public NET_公告通知_通知()
        {
            InitializeComponent();
        }      
        public void Editor_Add()
        {
            this.Text = "发布新的通知";
            this.Tag = "Add";
            //
            this.txt公文标题.Text = "通知标题";
            this.dN_HtmlEditor1.Visible = true;
            this.webBrowser1.Visible = false;
        }

        public void Editor_Mod(string GW)
        {
            this.Text = "修改通知";
            this.Tag = "Mod";
            //
            this.btnOk.Tag = GW;
            this.txt公文标题.ReadOnly = true;
            this.DataBinding_GridView(GW);
        }

        public void Editor_See(String GW,string JSBM)
        {
            this.Text = "查看通知";
            this.txt公文标题.ReadOnly = true;
            this.dN_HtmlEditor1.Visible = false;
            this.webBrowser1.Visible = true;
            this.btn接收单位.Enabled = false;
            if(JSBM=="") 
            {
                this.btnOk.Text = "签收(Ctrl+D)";
                this.Tag = "Accept";
                this.btnOk.Tag = GW;
            }
            else
            {
                this.btnOk.Text = "已签收";
                this.btnOk.Enabled = false;
            }     
            DataBinding_GridView(GW);
        }

        private void DataBinding_GridView(String GWBM)
        {
            try
            {
                var model = new Ref_WS_GCGL.DataType_NET_公文();
                model.ExAction ="See";
                model.公文编码 = GWBM;
                if (!AppServer.WcfService_Open()) return;
                //
                DataSet ds = AppServer.wcfClient.NET_公文_List(ref model);
                if (ds.Tables[0].Rows.Count > 0)                                  
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
                this.txt接收单位.Text = AppServer.LoginUnitName;
                this.txt接收单位.Tag = AppServer.LoginUnitCode;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.txt公文标题.Text.Trim() == "")
            {
                AppServer.ShowMsg("公文标题不能为空！");
                return;
            }
            //if (this.dN_HtmlEditor1.BodyText.Trim() == "")
            //{
            //    AppServer.ShowMsg("公文内容不能为空！");
            //    return;
            //}
            if (string.IsNullOrEmpty(this.txt接收单位.Text.ToString()))
            {
                AppServer.ShowMsg("接收单位不能为空！");
                return;
            }
            if (this.Tag.ToString()== "Accept")
            {
               try
                {
                  if (!AppServer.WcfService_Open()) return;
                  var model = new Ref_WS_GCGL.DataType_NET_公文();
                  model.ExAction = this.Tag.ToString();
                  model.公文编码 = this.btnOk.Tag.ToString();
                  model.接收人编码 = AppServer.LoginUserCode;
                  model.接收单位编码 = AppServer.LoginUnitCode;
                  AppServer.wcfClient.NET_公文_Edit(ref model);
                  if (model.ExResult != 0)
                    {
                      AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                      return;
                     }
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
            }
            else 
                this.PostData();
        }

        public void PostData()
        {
            #region 提交数据
            base.Cursor = Cursors.WaitCursor;
            try
            {
               
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_NET_公文();
                model.ExAction = this.Tag.ToString();
                if (this.Tag.ToString() == "Mod")
                model.公文编码 = this.btnOk.Tag.ToString();
                model.创建人编码 = AppServer.LoginUserCode;
                model.公文标题 = this.txt公文标题.Text.ToString();
                model.公文内容 = this.dN_HtmlEditor1.HtmlText.ToString(); 
                model.公文类型 = "通知";
                model.单位编码 = AppServer.LoginUnitCode;
                string[] arrID = this.txt接收单位.Tag.ToString().Split(new char[]{ ';'});
                model.接收单位编码 = arrID[0];
                AppServer.wcfClient.NET_公文_Edit(ref model);
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                string GWBM=model.公文编码;//获取返回来的公文编码
               for(int i=1;i<arrID.Length-1;i++)
                {
                    model.ExAction = this.Tag.ToString();
                    model.公文编码 = GWBM;
                    model.接收单位编码 = arrID[i];
                    AppServer.wcfClient.NET_公文_Edit(ref model);
                    if (model.ExResult != 0)
                    {
                        AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                        return;
                    }
                }
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

        private void btn接收单位_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(2);
            AppServer.Frm单位信息.SetShowParam(this.txt接收单位, 0);
            AppServer.Frm单位信息.ShowDialog();
            if (AppServer.Frm单位信息.DialogResult == DialogResult.OK)
            {
                this.txt接收单位.Tag = AppServer.Frm单位信息.SelectNodeID;
                this.txt接收单位.Text = AppServer.Frm单位信息.SelectNodeTitle;
            }
            AppServer.Frm单位信息.Hide();          
        }
    }
}
