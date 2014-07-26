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
using TY.Helper;

namespace GCGL_Client.RPT
{
    public partial class RPT_公车库存_变化 : Form
    {
        public RPT_公车库存_变化()
        {
            InitializeComponent();
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            //
            this.tyGridView.BuildGrid(AppServer.GetTableDef(this.GetType().Name));
            //
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
            if (AppServer.LoginUnitIsCZT()||AppServer.LoginUnitIsZGDW())
            {
                this.chk全部单位.Visible = true;
            }


        }
        private void DataBinding_GridView()
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车库存();
                model.ExAction = "Change";
                model.查询年度 = this.txt查询年度.Text.ToString();
                model.LoginUserCode = AppServer.LoginUserCode;
                if (this.txt单位编码.Tag != null)
                {
                    model.单位编码 = this.txt单位编码.Tag.ToString();
                }
                else
                {
                    model.单位编码 = null;
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
        #region 功能按钮
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (!this.chk全部单位.Checked)
            {
                if (this.txt单位编码.Text.Trim() == "")
                {
                    AppServer.ShowMsg("单位名称不能为空！", "提示");
                    return;
                }
            }
            DataBinding_GridView();
        }
        private void chk全部单位_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk全部单位.Checked)
            {
                this.txt单位编码.Text = "";
                this.txt单位编码.Tag = ""; 
            }
            DataBinding_GridView();
            
        }
        private void txt单位编码_TextChanged(object sender, EventArgs e)
        {
            this.btnQuery.PerformClick();
        }
        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.tyGridView, this.lblTitle.Text);
        }

        #endregion

        private void txt查询年度_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar==8)
                e.Handled = false;
            else e.Handled = true;
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
        private void tyGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             if (this.tyGridView.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.tyGridView.DataSource).Rows[this.tyGridView.CurrentRow.Index];
            if (row == null) return;
            string 资产类别 = null;
            string 年度=null;
            if (this.tyGridView.CurrentCell.ColumnIndex < 6 && this.tyGridView.CurrentCell.ColumnIndex >1)
             {
                 年度 = this.txt查询年度.Text.ToString();
                 if (this.tyGridView.CurrentCell.ColumnIndex == 4 || this.tyGridView.CurrentCell.ColumnIndex == 5)
                 {
                     资产类别 = "03";
                 }
             }
            else if (this.tyGridView.CurrentCell.ColumnIndex < 10 && this.tyGridView.CurrentCell.ColumnIndex > 5)
            {
                年度 =Convert.ToString(Convert.ToInt32(this.txt查询年度.Text.ToString())-1);
                if (this.tyGridView.CurrentCell.ColumnIndex == 8 || this.tyGridView.CurrentCell.ColumnIndex == 9)
                {
                    资产类别 = "03";
                }
            }
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车库存();
                model.ExAction = "C_details";
                model.单位编码 = row["单位编码"].ToString();
                model.查询年度 = 年度;
                model.资产类别编码 = 资产类别;
                DataSet db = AppServer.wcfClient.OCC_公车库存_List(ref model);
                this.dgvList.DataSource = db.Tables[1];
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
