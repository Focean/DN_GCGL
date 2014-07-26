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
    public partial class NET_业务论坛_Editor : Form
    {
        public NET_业务论坛_Editor()
        {
            InitializeComponent();
        }

        private void NET_业务论坛_Editor_Load(object sender, EventArgs e)
        {
            this.reget();
        }

        public void Editor_Add(string Luntan, string tiezi, string T_tiezi)
        {
            this.Text = "标题：" + T_tiezi;
            this.Tag = "Add";
            this.btn发帖.Tag = tiezi;
            this.btn提交.Tag = Luntan;         
            //  
            this.btn发帖.Visible = true;
            this.btn取消.Visible = true;          
            this.btn提交.Visible = false;
            this.btn清空.Visible = false;
            this.htmlEditor1.Visible = false;
            this.pnl菜单栏.Dock = DockStyle.Bottom;
            this.webBrowser1.Dock = DockStyle.Fill;   
        }

        public void Editor_See(string Luntan,string tiezi)
        {
            this.Text = "";
            this.Tag = "See";
            this.btn发帖.Enabled = false;
            this.btn发帖.Tag = tiezi;
            this.btn提交.Tag = Luntan;
            //            
        }
 
        //获取帖子列表       
        private string TotalList;
        public void GetTalkList()
        {
            using (WebBrowser webBrowser1 = new WebBrowser())
            {
                this.webBrowser1.Refresh();
                string TalkList = "<table style=\"border: #F00 1px solid\" width=\"100%\"  border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"table-layout:fixed;\" rules=\"rows;\">";
                this.webBrowser1.Document.Write("");
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_NET_论坛();
                model.ExAction = "Card";
                model.版块编码 = this.btn提交.Tag.ToString();
                model.贴子编码 = this.btn发帖.Tag.ToString();
                DataSet ds = AppServer.wcfClient.NET_论坛_List(ref model);
                DataTable dt = ds.Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TalkList += "<tr bgcolor=\"#DDEEFF\" ><td height=\"27px\">" + "【" + dt.Rows[i]["贴子层次"].ToString() + "&nbsp&nbsp楼】&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp" + dt.Rows[i]["创建人"].ToString()
                                + "</td><td align=\"right\">"
                                + dt.Rows[i]["创建时间"].ToString() + "&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</td></tr><tr><td colspan=\"2\"><table width=\"100%\" cellpadding=\"15px\"><tr><td bgcolor=\"AliceBlue\" width=\"1166px\" >"
                                + dt.Rows[i]["贴子内容"].ToString() + "</td></tr></table></td></tr>";
                }
                TotalList = "<html><body>" + TalkList + "</table></body></html>";
                //this.webBrowser1.DocumentText = "<html><body>" + TalkList + "</table></body></html>";
                this.webBrowser1.Document.Write("<html><body>" + TalkList + "</table></body></html>");
            }
        }

        private void reget()
        {
            this.GetTalkList();
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.Refresh();
            this.webBrowser1.Document.Window.ScrollTo(10000, 10000);
        }

        private void btn回贴_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Dock = DockStyle.Top;
            this.pnl菜单栏.Dock = DockStyle.None;
            this.htmlEditor1.Visible = true;
            this.btn提交.Visible = true;
            this.btn清空.Visible = true;
            this.htmlEditor1.Focus();
            this.btn发帖.Enabled = false;
        }

        private void btn清空_Click(object sender, EventArgs e)
        {
            this.htmlEditor1.BodyInnerText = "";
            this.htmlEditor1.Focus();
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn提交_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.htmlEditor1.BodyInnerText == null)
                {
                    AppServer.ShowMsg("帖子内容不能为空！");
                    return;
                }
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_NET_论坛();
                model.ExAction = this.Tag.ToString();
                model.版块编码 = this.btn提交.Tag.ToString();
                model.贴子编码 = this.btn发帖.Tag.ToString();
                model.贴子内容 = GetHtmlImageUrlList(this.htmlEditor1.BodyInnerText);
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
                this.reget();
                this.btn清空.PerformClick();
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
