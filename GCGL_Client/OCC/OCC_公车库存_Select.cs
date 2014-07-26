using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DingnuoControlLibrary;
namespace GCGL_Client.OCC
{
    public partial class OCC_公车库存_Select : Form
    {
        public OCC_公车库存_Select()
        {           
            InitializeComponent();
            this.dtp开始时间.Value = this.dtp结束时间.Value.AddMonths(-1);    
        }
        private void OCC_资产信息_Select_Load(object sender, EventArgs e)
        {
        }
        private string[] ZCstr = new string[10];
        public void Select_查询单位资产(string[] ss)
        {
            Array.Copy(ss, ZCstr, ss.Length);
            this.Text = "单位资产选择";
            //
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_OCC_公车库存();
                model.ExAction = "Check";
                model.单位编码 = AppServer.LoginUnitCode;
                model.开始时间 = this.dtp开始时间.Value;
                model.结束时间 = this.dtp结束时间.Value;
                model.车牌号 = this.txt车牌号.Text;
                DataSet db = AppServer.wcfClient.OCC_公车库存_List(ref model);
                DataTable table = db.Tables[1];
                for (int i = 0; i < this.ZCstr.Length; i++)
                {
                    if (this.ZCstr[i] == null) break;
                    for (int j = 0; j < table.Rows.Count; j++)
                        if (table.Rows[j]["资产编号"].ToString() == this.ZCstr[i].ToString())
                            table.Rows.Remove(table.Rows[j]);
                }
                if (table.Rows.Count <= 0)
                {
                    dgv单位资产.DataSource = table;
                    return;
                }
                dgv单位资产.DataSource = table;    
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

        // property资产的意思
        public string SelectPropertyCode { get; set; }
        public string SelectPropertyName { get; set; }     
        private void dbTreeView_TreeNodeCreated(object sender, TreeNodeCreatedEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void btn查询_Click(object sender, EventArgs e)
        {
            Select_查询单位资产(ZCstr);
        }

        private void dgv单位资产_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.btn确定.PerformClick();
        }

        private void btn确定_Click(object sender, EventArgs e)
        {
            if (this.dgv单位资产.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgv单位资产.DataSource).Rows[this.dgv单位资产.CurrentRow.Index];
            DataRow newrow = ((DataTable)this.dgv单位资产.DataSource).Rows[this.dgv单位资产.CurrentRow.Index];
            if (row == null) return;
            else
            {
                SelectPropertyCode = row["资产编号"].ToString();
                SelectPropertyName = row["资产名称"].ToString();
            }
            this.DialogResult = DialogResult.OK;
        } 
    }
}
