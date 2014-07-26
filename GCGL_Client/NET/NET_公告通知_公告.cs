using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using GLG.Common;

namespace GCGL_Client.NET
{
    public partial class NET_公告通知_公告 : Form
    {
        public NET_公告通知_公告()
        {
            InitializeComponent();
        }

        public void Editor_Add()
        {
            this.Text = "发布新的公告";
            this.Tag = "Add";
            //
            this.txt公文标题.Text = "公告标题";
        }

        public void Editor_Mod(string GW)
        {
            this.Text = "修改公告";
            this.Tag = "Mod";
            //
            this.btnOk.Tag = GW;
            this.DataBinding_GridView(GW);
        }

        public void Editor_See(string GW )
        {
            this.Text = "查看公告";
            this.Tag = "See";
            //       
            this.txt公文标题.ReadOnly = true;
            this.txt公文内容.ReadOnly = true;
            this.btnOk.Tag = GW;
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
                if (!AppServer.WcfService_Open()) return;
                //
                DataSet ds = AppServer.wcfClient.NET_公文_List(ref model);               
                if (ds.Tables[0].Rows.Count > 0)
                    TY.Helper.FormHelper.DataBinding_DataSourceToUI(ds.Tables[0], this);                
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
            PostData();
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
                model.公文类型 = "公告";
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

    }
}
