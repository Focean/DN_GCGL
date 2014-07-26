using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.Main;
namespace GCGL_Client.RPT
{
    public partial class RPT_公车库存_总账 : Form
    {
        public RPT_公车库存_总账()
        {
            InitializeComponent();
            //
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_单位();
                model.ExAction = "GetSubList";
                if (AppServer.LoginUnitType < 3 || AppServer.LoginUnitType == 8)
                    model.单位编码 = AppServer.LoginUnitCode;
                DataTable dt = null;
                DataSet ds = AppServer.wcfClient.CMN_单位_List(ref model);
                dt = ds.Tables[0];
                this.cbx单位编码.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.cbx单位编码.AutoCompleteSource = AutoCompleteSource.ListItems;
                this.cbx单位编码.DataSource = dt;
                this.cbx单位编码.DisplayMember = "单位名称";
                this.cbx单位编码.ValueMember = "单位编码";
                this.cbx单位编码.SelectedIndex = -1;
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
            this.tyGridView.BuildGrid(AppServer.GetTableDef(this.GetType().Name));
        }

        private void btnQuery_Click(object sender, EventArgs e)
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
                else if (this.cbx单位编码.SelectedValue != null)
                {
                    model.单位编码 = this.cbx单位编码.SelectedValue.ToString();
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

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
