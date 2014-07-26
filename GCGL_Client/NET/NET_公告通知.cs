using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using System.Globalization;
using TY.Common;
namespace GCGL_Client.NET
{
    public partial class NET_公告通知 : Form
    {
        public NET_公告通知()
        {
            InitializeComponent();
            //
            this.dtp结束时间.Value = DateTime.Now;
            this.dtp开始时间.Value = DateTime.Now.AddMonths(-1);
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            //
            this.DataBinding_GridView(0);
        }

        private void DataBinding_GridView(int ARowIndex)
        {
            try
            {
               if (!AppServer.WcfService_Open()) return;
               var model = new Ref_WS_GCGL.DataType_NET_公文();
               model.ExAction = "List_TZ";
               model.单位编码 = AppServer.LoginUnitCode;
               model.开始时间 = this.dtp开始时间.Value;
               model.结束时间 = this.dtp结束时间.Value;
               model.仅显示我未接收 = this.chk仅显示我未接收.Checked;
               //
               DataSet ds = AppServer.wcfClient.NET_公文_List(ref model);             
               this.dgvList.DataSource = ds.Tables[0];
               this.dgvList.GoToRowByIndex(ARowIndex);
               
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

        private void Consult(string row)
        {
            try
            {
                var model = new Ref_WS_GCGL.DataType_NET_公文();
                model.ExAction = "Browse";
                model.公文编码 = row;
                if (!AppServer.WcfService_Open()) return;
                //
                AppServer.wcfClient.NET_公文_Edit(ref model);
                if (model.ExResult != 0) AppServer.ShowMsg_Error(model.ErrorMsg);
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

        private void btn公告_Click(object sender, EventArgs e)
        {
            using (var form = new NET_公告通知_公告())
            {
                form.Editor_Add();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_GridView(-1);
                    this.btnQuery.PerformClick();
                }
            }
        }

        private void btn通知_Click(object sender, EventArgs e)
        {
            if (AppServer.LoginUnitType == 1)
            {
                AppServer.ShowMsg("本单位没有发布通知的权限！");
                return;            
            }
            
            using (var form = new NET_公告通知_通知())
            {
                    form.Editor_Add();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_GridView(-1);
                    this.btnQuery.PerformClick();
                }
            }
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            //
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (row["公文类型"].ToString() == "公告")
            {
                using (var form = new NET_公告通知_公告())
                {
                    form.Editor_Mod(row["公文编码"].ToString());
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.DataBinding_GridView(-1);
                    }
                }
            }
            if (row["公文类型"].ToString() == "通知")
            {
                using (var form = new NET_公告通知_通知())
                {
                    form.Editor_Mod(row["公文编码"].ToString());
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.DataBinding_GridView(-1);
                    }
                }
            }
        }

        private void btn删除_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            if (!AppServer.DialogMsg("确认要删除当前选择项吗？", "删除确认")) return;
            //
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            try
            {
                var model = new Ref_WS_GCGL.DataType_NET_公文();
                model.ExAction = "Del";
                model.公文编码 = row["公文编码"].ToString();
                model.LoginUserCode = AppServer.LoginUserCode;
                if (!AppServer.WcfService_Open()) return;
                //
                AppServer.wcfClient.NET_公文_Edit(ref model);
                if (model.ExResult != 0) AppServer.ShowMsg_Error(model.ErrorMsg);
                if (this.dgvList.CurrentRow.Index >= 1)
                    DataBinding_GridView(this.dgvList.CurrentRow.Index - 1);
                else
                    DataBinding_GridView(-1);
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

        private void btn查看_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            //
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //查阅次数增1
            Consult(row["公文编码"].ToString());
            if (row["公文类型"].ToString() == "公告")
            {
                using (var form = new NET_公告通知_公告())
                {
                    form.Editor_See(row["公文编码"].ToString());
                    form.ShowDialog();
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index);           
                }
            }
            if (row["公文类型"].ToString() == "通知")
            {
                using (var form = new NET_公告通知_通知())
                {
                    form.Editor_See(row["公文编码"].ToString(),row["接收人编码"].ToString());
                    form.ShowDialog();
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
           this.DataBinding_GridView(0);
        }

        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.btn查看.PerformClick();
        }

        private void chk仅显示我未接收_CheckedChanged(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
        }
       
    }
}
