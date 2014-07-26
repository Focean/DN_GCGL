using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.Main;
using TY.Common;
namespace GCGL_Client.RPT
{
    public partial class RPT_公车库存_总账 : Form
    {
        public RPT_公车库存_总账()
        {
            InitializeComponent();

            //
            this.tyGridView.BuildGrid(AppServer.GetTableDef(this.GetType().Name));
            if (AppServer.LoginUnitIsGWC())
            {
                this.btn预算单位.Visible = false;
                this.txt单位编码.Tag = "410001_GWC";
                this.txt单位编码.Text = "省公物仓";
            }
            if (AppServer.LoginUnitIsYSDW())
            {
                this.btn预算单位.Visible = false;
                this.txt单位编码.Tag = AppServer.LoginUnitCode;
                this.txt单位编码.Text = AppServer.LoginUnitName;
            }
        }
        private void DataBing_DataGrid()
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车库存();
                model.ExAction = "Ledger";
                model.开始时间 = this.dtp开始时间.Value;
                model.结束时间 = this.dtp结束时间.Value;
                if (AppServer.LoginUnitType == 1 || AppServer.LoginUnitType == 8)
                {
                    model.单位编码 = AppServer.LoginUnitCode;
                }
                else if (this.txt单位编码.Tag != null)
                {
                    model.单位编码 = this.txt单位编码.Tag.ToString();
                }
                DataSet db = AppServer.wcfClient.OCC_公车库存_List(ref model);
                DataTable table = db.Tables[1];
                if (table.Rows.Count == 0) return;
                this.tyGridView.DataSource = table;
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
            DataBing_DataGrid();
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx单位编码_SelectedValueChanged(object sender, EventArgs e)
        {
            DataBing_DataGrid();
        }

        private void btn预算单位_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(2);
            AppServer.Frm单位信息.SetShowParam(this.txt单位编码, 0);
            AppServer.Frm单位信息.ShowDialog();
            if (AppServer.Frm单位信息.DialogResult == DialogResult.OK)
            {
                this.txt单位编码.Tag = AppServer.Frm单位信息.SelectNodeID;
                this.txt单位编码.Text = AppServer.Frm单位信息.SelectNodeTitle;
            }
            AppServer.Frm单位信息.Hide();
        }

        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.tyGridView, this.lblTitle.Text);
        }
    }
}
