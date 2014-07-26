using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Common;
using TY.Helper;
namespace GCGL_Client.NET
{
    public partial class NET_业务论坛_版块_Editor : Form
    {
        public NET_业务论坛_版块_Editor()
        {
            InitializeComponent();
            DataBinding_GridView(0);
        }

        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_NET_论坛();
                model.ExAction = "List";
               DataTable table = AppServer.wcfClient.NET_论坛_版块_List(ref model).Tables[0];
                //行定位
               table.Rows.RemoveAt(0);//除去版块名称为"全部"的               
                this.dgvList.DataSource = table;
                string gridstr = "{ro=1,rno=1}"
                   + "[版块编码,tc=版块编码,wh=150,al=mc,sm=0,vi=0]"
                   + "[版块名称,tc=版块名称,wh=120,al=mc,sm=0]"
                   + "[版主人编码,tc=版主人编码,wh=90,al=mc,sm=0,vi=0]"
                   + "[版块简介,tc=版块简介,wh=120,al=mc,sm=1,vi=0]"
                   + "[创建时间,tc=创建时间,wh=150,fmt=g,al=mc]";
                //wh是宽度，al是对齐方式,sm是否排序（1真)
                this.dgvList.GridStr(gridstr);
                this.dgvList.GoToRowByIndex(ACurrRowIndex);
                //
                this.txt版块简介.Clear();
                this.txt版块名称.Clear();
                this.txt版主人编码.Clear();
                this.btn取消.Visible = false;
                this.btn提交.Visible = false;
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
        private void btn增加_Click(object sender, EventArgs e)
        {
            this.btn提交.Visible = true;
            this.btn取消.Visible = true;
           //
            this.txt版块简介.Clear();
            this.txt版块名称.Clear();
            this.txt版主人编码.Clear();
        }


        private void btn删除_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            int index = this.dgvList.CurrentRow.Index;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (AppServer.DialogMsg("是否确认删除？", " "))
            {
                var dtm = new Ref_WS_GCGL.DataType_NET_论坛();
                dtm.ExAction = "Del";
                dtm.版块编码= row["版块编码"].ToString();
                if (!AppServer.WcfService_Open()) return;
                AppServer.wcfClient.NET_论坛_版块_Edit(ref dtm);
                if (dtm.ExResult == 0)
                {
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index - 1);
                }
                else
                    AppServer.ShowMsg_Error(dtm.ErrorMsg, "错误");
            }
            else
                return;
            if (index >= 1)
                DataBinding_GridView(index - 1);
            else
                DataBinding_GridView(-1);
        }

        private void dgvList_MouseClick(object sender, MouseEventArgs e)
        {
            this.btn取消.Visible = false;
            this.btn提交.Visible = false;
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            this.txt版块名称.Text = row["版块名称"].ToString();
            this.txt版主人编码.Text = row["版主人编码"].ToString();
            this.txt版块简介.Text = row["版块简介"].ToString();
            this.dtp创建时间.Value =row["创建时间"].ToDateTimeDef();
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.txt版块简介.Clear();
            this.txt版块名称.Clear();
            this.txt版主人编码.Clear();
        }

        private void btn提交_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_NET_论坛();
                model.ExAction = "Add";
                model.版块简介 = this.txt版块简介.Text.ToString();
                model.版块名称 = this.txt版块名称.Text.ToString();
                model.版主人编码 = this.txt版主人编码.Text.ToString();
                model.创建时间 = this.dtp创建时间.Value;
                AppServer.wcfClient.NET_论坛_版块_Edit(ref model);
                if (model.ExResult == 0)
                {
                    this.DataBinding_GridView(this.dgvList.Rows.Count);
                }
                else
                    AppServer.ShowMsg_Error(model.ErrorMsg, "错误");
                DataBinding_GridView(this.dgvList.Rows.Count); 
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

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn刷新_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

    }
}
