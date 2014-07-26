using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.OCC
{
    public partial class OCC_公车入库_对比 : Form
    {
        public OCC_公车入库_对比(string Code)
        {
            InitializeComponent();
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车库存();
                model.ExAction = "Contrast";
                model.资产编号 = Code;
                DataSet db = AppServer.wcfClient.OCC_公车库存_List(ref model);
                DataTable dt1 = db.Tables[1];
                DataTable dt2 = db.Tables[2];
                DataTable dt3 = db.Tables[3];
                int dt1_rowcount = dt1.Rows.Count;
                int dt2_colcount = dt2.Columns.Count;
                int dt3_colcount = dt3.Columns.Count;
                if (dt2.Rows.Count > 0)
                {
                    int j = 0;
                    for (int i = 0; i < dt1_rowcount; i++)
                    {
                        if (j < dt2_colcount)
                        {
                            dt1.Rows[i][1] = dt2.Rows[0][j];
                        }
                        j++;
                    }
                }
                if (dt3.Rows.Count > 0)
                {
                    int k = 0;
                    for (int s = 0; s < dt1_rowcount; s++)
                    {
                        if (k < dt3_colcount)
                        {
                            dt1.Rows[s][2] = dt3.Rows[0][k];
                        }
                        k++;
                    }

                }
                this.dgvList.DataSource = dt1;
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

        private void OCC_公车入库_对比_Load(object sender, EventArgs e)
        {
            for (int d = 0; d < this.dgvList.Rows.Count; d++)
            {
                if (this.dgvList.Rows[d].Cells[1].Value.ToString() != this.dgvList.Rows[d].Cells[2].Value.ToString() && this.dgvList.Rows[d].Cells[2].Value.ToString() != "")
                {
                   this.dgvList.Rows[d].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
