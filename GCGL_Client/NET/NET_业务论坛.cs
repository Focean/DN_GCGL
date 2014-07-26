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
using GCGL_Client.Main;
namespace GCGL_Client.NET
{
    public partial class NET_业务论坛 : Form
    {
        public NET_业务论坛()
        {
            InitializeComponent();
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);          
            try
            {
                if (!AppServer.WcfService_Open()) return;
                this.cbx版块名称.DataSource = AppServer.wcfClient.FZB_编码_List("版块名称", AppServer.LoginAreaCode).Tables[0];
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
            //
            if (AppServer.UserQxMenuList.Rows.Contains("060402"))
            {
                this.btn版块管理.Visible = true;
            }
            
        }

        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_NET_论坛();
                model.ExAction = "List";
                model.版块编码 = this.cbx版块名称.SelectedValue.ToString();
                this.dgvList.DataSource = AppServer.wcfClient.NET_论坛_List(ref model).Tables[0];
              
                this.dgvList.GoToRowByIndex(ACurrRowIndex);
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

        private void NET_业务论坛_Load(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }
        
        private void btnQuery_Click(object sender, EventArgs e)
        {

            DataBinding_GridView(0);
        }

        private void btn新建_Click(object sender, EventArgs e)
        {           
            using (var form = new NET_业务论坛_贴子_Editor())
            {
                form.Editor_Add();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_GridView(0);
                }
            }
        }

        private void btn回贴_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            using (var form = new NET_业务论坛_Editor())
            {
                int index = this.dgvList.CurrentRow.Index;
                form.Editor_Add(row["版块编码"].ToString(), row["贴子编码"].ToString(), row["贴子标题"].ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                }
                this.btnQuery.PerformClick();
                this.dgvList.GoToRowByIndex(index);
            }
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.btn浏览.PerformClick();
        }

        private void btn版块管理_Click(object sender, EventArgs e)
        {
            //开始创建表单
            Form fMdiForm = null;
         
            fMdiForm = new NET_业务论坛_版块_Editor();
            fMdiForm.Show();
        }
    }
}
