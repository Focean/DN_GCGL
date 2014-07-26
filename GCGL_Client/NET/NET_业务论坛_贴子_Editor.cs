using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
namespace GCGL_Client.NET
{
    public partial class NET_业务论坛_贴子_Editor : Form
    {
        public NET_业务论坛_贴子_Editor()
        {
            InitializeComponent();
            this.txt创建人编码.Text = AppServer.LoginUserName;
            this.txt创建人编码.Tag = AppServer.LoginUserCode;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                DataTable dt = AppServer.wcfClient.FZB_编码_List("版块名称", AppServer.LoginAreaCode).Tables[0];
                dt.Rows.RemoveAt(0);
                this.cbx版块名称.DataSource = dt;
                this.cbx版块名称.DisplayMember = "版块名称";
                this.cbx版块名称.ValueMember = "版块编码";
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

        }
        public void Editor_Add()
        {
            this.Text = "发帖";
            this.Tag = "Add";               
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.txt贴子标题.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("帖子标题不能为空！");
                this.txt贴子标题.Focus();
                return;
            }
            if (this.dN_HtmlEditor1.BodyText == null)
            {
                AppServer.ShowMsg("帖子内容不能为空！");
                this.dN_HtmlEditor1.Focus();
                return;
            }
            
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_NET_论坛();
                model.ExAction = this.Tag.ToString();
                model.版块编码 = this.cbx版块名称.SelectedValue.ToString();
                model.版主人编码 = this.txt创建人编码.Tag.ToString();
                model.贴子标题 = this.txt贴子标题.Text.ToString();
                model.贴子内容 = GetHtmlImageUrlList(this.dN_HtmlEditor1.HtmlText);
                model.LoginUserCode = AppServer.LoginUserCode;
                AppServer.wcfClient.NET_论坛_Edit(ref model);
                //
                if (model.ExResult != 0)
                {
                    AppServer.HideWaitForm();
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                //
                this.DialogResult = DialogResult.OK;
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
        }
        public static string GetHtmlImageUrlList(string sHtmlText)
        {
            // 定义正则表达式用来匹配 img 标签 
            Regex regImg = new Regex(@"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>", RegexOptions.IgnoreCase);
            // 搜索匹配的字符串 
            MatchCollection matches = regImg.Matches(sHtmlText);
            string NewHtmlText = null;
            // 取得匹配项列表 
            foreach (Match match in matches)
            {
                string dr1 = match.Groups["imgUrl"].Value;
                string fileFormat = dr1.Substring(dr1.LastIndexOf("."));
                string ip = AppServer.wcfClient.Endpoint.Address.Uri.Host.ToString();
                byte[] document = setFileToBytes(dr1);
                MemoryStream ms = new MemoryStream(document);
                //返回一个存储目标路径string dr2                    
                string dr2 = AppServer.wcfClient.NET_论坛_图片_Edit(ms, fileFormat, ip);
                dr2 += fileFormat;
                NewHtmlText = sHtmlText.Replace(dr1, dr2);
            }
            if (NewHtmlText == null) return sHtmlText;
            else return NewHtmlText;
        }

        public static byte[] setFileToBytes(string fileName)
        {
            byte[] content;
            FileInfo finfo = new FileInfo(fileName);   //绝对路径
            if (finfo.Exists)
            {
                //读取文件内容，写入byte数组
                content = new byte[finfo.Length];
                FileStream stream = finfo.OpenRead();
                stream.Read(content, 0, content.Length);
                stream.Close();
            }
            else
            {
                return null;
            }
            return content;
        }  
    }
}
