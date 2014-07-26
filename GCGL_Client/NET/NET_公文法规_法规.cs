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
    public partial class NET_公文法规_法规 : Form
    {
        public NET_公文法规_法规()
        {
            InitializeComponent();
        }

        public void Editor_Add()
        {
            this.Text = "发布新的法规";
            this.Tag = "Add";
            //        
        }

        public void Editor_Mod(string GW)
        {
            this.Text = "修改法规";
            this.Tag = "Mod";
            this.txt公文标题.ReadOnly = true;
            //
            DataBinding_GridView(GW);
            this.btnOk.Tag = GW;
        }

        public void Editor_See(string GW)
        {
            this.Text = "查看法规";
            this.Tag = "See";
            this.txt公文标题.ReadOnly = true;
            this.txt公文内容.ReadOnly = true;
            this.btn附件管理.Enabled = false;
            this.btnOk.Enabled = false;
            DataBinding_GridView(GW);
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
                TY.Helper.FormHelper.DataBinding_DataSourceToUI(ds.Tables[0], this);
                this.txt附件信息.Tag = ds.Tables[0].Rows[0]["附件编码"].ToString();
                //
                model2.附件编码 = ds.Tables[0].Rows[0]["附件编码"].ToString();
                DataSet ds2 = AppServer.wcfClient.NET_附件管理_List(ref model2);
                if (ds2.Tables[0].Rows.Count == 0) return;
                string FileNames = "";
                for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                    FileNames += ds2.Tables[0].Rows[i]["文件名称"].ToString();
                this.txt附件信息.Text = string.Format("共{0}个文件:{1}", ds2.Tables[0].Rows.Count, FileNames);
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
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_NET_公文();
                model.ExAction = this.Tag.ToString();
                if (this.Tag.ToString() == "Mod")
                model.公文编码 = this.btnOk.Tag.ToString();
                model.公文标题 = this.txt公文标题.Text.ToString();
                model.公文内容 = this.txt公文内容.Text.ToString();
                model.创建人编码 = AppServer.LoginUserCode;
                model.单位编码 = AppServer.LoginUnitCode;
                model.公文类型 = "法规";
                model.接收单位编码="All";
                model.附件编码 = this.txt附件信息.Tag.ToString();
                AppServer.wcfClient.NET_公文_Edit(ref model);
                if (model.ExResult != 0)
                    AppServer.ShowMsg_Error(model.ErrorMsg);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PostData();
        }
    }
}
