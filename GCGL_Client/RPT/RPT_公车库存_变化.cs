using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.Main;
using GLG.Common;
using TY.Helper;
namespace GCGL_Client.RPT
{
    public partial class RPT_公车库存_变化 : Form
    {
        public RPT_公车库存_变化()
        {
            InitializeComponent();
            //
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_单位();
                model.ExAction = "GetSubList";  
                if(AppServer.LoginUnitType<3||AppServer.LoginUnitType==8)
                model.单位编码 = AppServer.LoginUnitCode;
                DataTable dt =null;
                DataSet ds= AppServer.wcfClient.CMN_单位_List(ref model);
                dt= ds.Tables[0];
                this.cbx选择单位.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.cbx选择单位.AutoCompleteSource = AutoCompleteSource.ListItems;
                this.cbx选择单位.DataSource = dt;
                this.cbx选择单位.DisplayMember = "单位名称";
                this.cbx选择单位.ValueMember = "单位编码";
                this.cbx选择单位.SelectedIndex = -1;
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
                model.ExAction = "Change";
                model.查询年度 = this.txt查询年度.Text.ToString();
                if (this.cbx选择单位.SelectedValue != null)
                {
                    model.单位编码 = this.cbx选择单位.SelectedValue.ToString();
                }
                DataSet db = AppServer.wcfClient.OCC_公车库存_List(ref model);
                DataTable table = db.Tables[1];
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

        private void txt查询年度_KeyPress(object sender, KeyPressEventArgs e)
        {    
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else e.Handled = true; 
        }
    }
}
