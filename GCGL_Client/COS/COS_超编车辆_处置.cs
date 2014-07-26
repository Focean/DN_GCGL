using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.COS
{
    public partial class COS_超编车辆_处置 : Form
    {
        public COS_超编车辆_处置()
        {
            InitializeComponent();
        }
        private string cbbm;
        private string zcbh;
        public void Add(DataRow row)
        {
            this.Text = "超编车辆(处置形式)";
            cbbm = row["超编编码"].ToString();
            zcbh = row["资产编号"].ToString();
            this.cbx超编状态.Text = row["超编状态"].ToString();
            this.txt备注.Text = row["备注"].ToString();
        }
        private void btn确定_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                model.ExAction = "Mod_CZ";
                model.超编编码 = cbbm;
                model.超编状态 = this.cbx超编状态.Text;
                model.资产编号 = zcbh;
                model.备注 = this.txt备注.Text;
                AppServer.wcfClient.COS_车辆超编_Edit(ref model);
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
