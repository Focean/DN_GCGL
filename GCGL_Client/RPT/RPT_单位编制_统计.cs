using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.RPT
{
    public partial class RPT_单位编制_统计 : Form
    {
        public RPT_单位编制_统计()
        {
            InitializeComponent();
            //
            this.tyGridView.BuildGrid(AppServer.GetTableDef(this.GetType().Name));
            //
            AppServer.SetGridViewStyle(this.dgvList);
        }
        private DataTable table = null;
        private void DataBinding_GridView()
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_CMN_单位_编制();
                model.ExAction = "BZTJ";
                model.LoginUserCode = AppServer.LoginUserCode;
                if (this.txt单位编码.Tag != null)
                {
                    model.单位编码 = this.txt单位编码.Tag.ToString();
                }
                else
                {
                    model.单位编码 = null;
                }
                DataSet db = AppServer.wcfClient.CMN_单位_编制_List(ref model);
                table = db.Tables[0];
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

        private void RPT_单位编制_统计_Load(object sender, EventArgs e)
        {
            DataBinding_GridView();
            if(table.Rows.Count>0)
                this.tyGridView.DataSource = table;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_GridView();
            if (table.Rows.Count > 0)
                this.tyGridView.DataSource = table;
        }
        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txt单位编码_TextChanged(object sender, EventArgs e)
        {
            DataBinding_GridView();
            if (table.Rows.Count > 0)
                this.tyGridView.DataSource = table;
        }
       
        private void btn方案查询_Click(object sender, EventArgs e)
        {
            string[] arrstr = null;
            string arr = null;
            this.txt单位编码.Tag = null;
            DataTable newdt = new DataTable();         
            newdt = table.Clone(); // 克隆dt 的结构，包括所有 dt 架构和约束,并无数据；
            using (var form = new RPT_查询方案())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.tyGridView.DataSource = null;
                    arrstr = form.CheckList.Split(new char[] { ',' });                  
                    for (int i = 0; i< arrstr.Length-1; i++)//转为字符串
                    {
                        arr += "'" + arrstr[i] + "',";
                    }
                    if (table.Rows.Count > 0)
                    {
                        DataRow[] rows = table.Select("单位编码 in (" + arr.Substring(0, arr.Length - 1) + ")");
                        foreach (DataRow row in rows)  // 将查询的结果添加到dt中；
                        {
                            newdt.Rows.Add(row.ItemArray);
                        }
                        if (newdt.Rows.Count > 0)
                            this.tyGridView.DataSource = newdt;                            
                    }
                }
            }
        }


        private void tyGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.tyGridView.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.tyGridView.DataSource).Rows[this.tyGridView.CurrentRow.Index];
            if (row == null) return;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车库存();
                model.ExAction = "ZC_details";
                model.单位编码 = row["单位编码"].ToString();
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

        private void dgvList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(this.dgvList.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), this.dgvList.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 6, e.RowBounds.Location.Y + 4); 
        }

       
    }
}
