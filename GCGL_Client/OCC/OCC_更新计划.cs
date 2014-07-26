using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using GLG.Common;
using GCGL_Client.Main;
namespace GCGL_Client.OCC
{
    public partial class OCC_更新计划 : Form
    {
        public OCC_更新计划()
        {
            InitializeComponent();

            if (AppServer.LoginUnitType == 1)
            {
                this.btn删除.Enabled = true;
                this.btn新增.Enabled = true;
                this.btn修改.Enabled = true;
            }
            //
            if (AppServer.LoginUnitType < 3||AppServer.LoginUnitType==8)
            {
                this.txt选择单位.Text = AppServer.LoginUnitName;
                this.txt选择单位.Tag = AppServer.LoginUnitCode;
            }
            else
            {
                this.txt选择单位.Text = "所有单位";
                this.txt选择单位.Tag = "410000_";
            }
            this.tyGridView.BuildGrid(AppServer.GetTableDef(this.GetType().Name));
        }

        private void SP_年度计划_Load(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_更新计划();
                model.ExAction="List";
                if (this.txt选择单位.Tag == null || this.txt选择单位.Tag.ToString() == "")
                {
                    model.单位编码 = AppServer.LoginUnitCode;
                }
                else
                {
                    model.单位编码 = this.txt选择单位.Tag.ToString();
                    model.包含下级 = this.chk包含下级.Checked;
                }
                DataSet db = AppServer.wcfClient.OCC_更新计划_List(ref model);
                DataTable table = db.Tables[0];
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
            }
        }

        public void Dep_Stop(string iRow)
        {
            if (iRow == null) return;
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_OCC_更新计划();
                model.ExAction = "Del";
                model.申请编号 = iRow;
                AppServer.wcfClient.OCC_更新计划_Edit(ref model);

            }
            catch (Exception ex)
            {
                AppServer.HideWaitForm();
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

        private void btn新增_Click(object sender, EventArgs e)
        {
            using (var form = new OCC_更新计划_Editor())
            {
                form.Editor_Add();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    this.DataBinding_GridView(0);
                }
            }
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if (this.tyGridView.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.tyGridView.DataSource).Rows[this.tyGridView.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new OCC_更新计划_Editor())
            {
                form.Editor_Mod(row);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    this.DataBinding_GridView(this.tyGridView.CurrentRow.Index);

                }
            }
        }

        private void btn删除_Click(object sender, EventArgs e)
        {
            if (AppServer.DialogMsg("确定要删除该信息吗？"))
            {
                string row = ((DataTable)this.tyGridView.DataSource).Rows[this.tyGridView.CurrentRow.Index]["申请编号"].ToString(); ;
                 Dep_Stop(row);           
            }
            this.DataBinding_GridView(0);

        }

        private void btn查看_Click(object sender, EventArgs e)
        {
            if (this.tyGridView.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.tyGridView.DataSource).Rows[this.tyGridView.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new OCC_更新计划_Editor())
            {
                form.Editor_View(row);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    this.DataBinding_GridView(this.tyGridView.CurrentRow.Index);

                }
            }
        }

        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.tyGridView, this.lbl年度更新计划列表.Text);

        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btn刷新_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }
        #endregion
        private void btn选择单位_Click(object sender, EventArgs e)
        {
            using (var form = new Man_单位_Select())
            {
                form.Select_查询单位();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.txt选择单位.Text = form.SelectUnitName;
                    this.txt选择单位.Tag = form.SelectUnitCode;
                }
            }
        }

        
       
    }
}
