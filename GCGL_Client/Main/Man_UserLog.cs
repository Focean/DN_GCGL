using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace GCGL_Client.Main
{
    public partial class Man_UserLog : Form
    {
        public Man_UserLog()
        {
            InitializeComponent();
            //
            this.dtp开始时间.Value = DateTime.Today.AddDays(1 - DateTime.Today.DayOfYear);
            this.dtp结束时间.Value = DateTime.Today;

            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            DataBinding_GridView(0);
        }
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_User_log();
                model.开始时间 = this.dtp开始时间.Value;
                model.结束时间 = this.dtp结束时间.Value;

                DataSet db = AppServer.wcfClient.SYS_User_log_list(ref model);
                this.dgvList.DataSource = db.Tables[0];
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
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }
    }
}
