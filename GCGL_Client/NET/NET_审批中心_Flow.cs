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
    public partial class NET_审批中心_Flow : Form
    {
        public NET_审批中心_Flow()
        {
            InitializeComponent();
            //
            AppServer.SetGridViewStyle(this.dgvList);
        }

        public void Editor_See(string sExCode)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;

                var model = new Ref_WS_GCGL.DataType_NET_审批();
                model.ExAction = "GetFlow";
                model.exCode = sExCode;
                model.LoginUserCode = AppServer.LoginUserCode;
                //
                DataSet db = AppServer.wcfClient.NET_审批_List(ref model);
                this.dgvList.DataSource = db.Tables[0];
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

    }
}
