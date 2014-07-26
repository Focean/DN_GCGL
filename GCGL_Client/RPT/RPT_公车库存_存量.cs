using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using TY.Common;
using GCGL_Client.Main;
using GCGL_Client.OCC;

namespace GCGL_Client.RPT
{
    public partial class RPT_公车库存_存量 : Form
    {
        public RPT_公车库存_存量()
        {
            InitializeComponent();
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            
        }
        private void RPT_公车库存_存量_Load(object sender, EventArgs e)
        {
           string str = "{ro=1,rno=1}"
                + "[单位名称,tc=车辆所属单位,wh=150,al=ml]"
                + "[资产编号,wh=90,al=mc,vi=0]"
                + "[资产名称,wh=100,al=mc,sm=1]"
                + "[车辆类型名称,tc=车辆类型,wh=120,al=mc,sm=1]"
                + "[资产类别名称,tc=资产类别,wh=120,al=mc,sm=1]"
                + "[取得日期,wh=100,al=mc,fmt=d]"
                + "[保修截止日期,wh=100,al=mc,fmt=d]"
                + "[价值,tc=价值(万元),wh=100,al=mr,fmt=n4]"
                + "[账面净值,tc=账面净值(万元),wh=100,al=mr,fmt=n4]"
                + "[排气量,wh=100,al=mr,sm=1]"
                + "[厂牌型号,wh=100,al=mc]"
                + "[颜色,wh=100,al=mc]"
                + "[车牌号,wh=100,al=mc]"
                + "[规格型号,wh=100,al=mc]"
                + "[发动机号,wh=100,al=mc]"
                + "[车架号,wh=100,al=mc]"
                + "[车辆产地,wh=150,al=mc]"  
                + "[采购形式名称,tc=采购形式,wh=150,al=mc,sm=1]"
                + "[备注,wh=200,al=ml]"
                + "[资产状态名称,tc=资产状态,wh=100,al=mc,sm=1]";

            //wh是宽度，al是对齐方式,sm是否排序（1真)     
            this.dgvList.GridStr(str);
           // this.btnQuery.PerformClick();
        }
        private RPT_条件组合 FQueryForm;
        private RPT_显示信息 FshowForm;
        private string Showstr = null;
        private string[] arrstr = null;
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (FQueryForm == null) FQueryForm = new RPT_条件组合();

            FQueryForm.select_tag("Query");
            if (FQueryForm.ShowDialog() == DialogResult.OK)
            {
               
                this.dgvList.DataSource = FQueryForm.table;
                string gridstr = null;

                gridstr = "{ro=1,rno=1}"
                +"[单位名称,tc=车辆所属单位,wh=150,al=ml]"
                 + "[资产编号,wh=90,al=mc,vi=0]"
                + "[资产名称,wh=100,al=mc,sm=1]"
                + "[车辆类型名称,tc=车辆类型,wh=120,al=mc,sm=1]"
                + "[资产类别名称,tc=资产类别,wh=120,al=mc,sm=1]"
                + "[取得日期,wh=100,al=mc,fmt=d]"
                + "[保修截止日期,wh=100,al=mc,fmt=d]"
                + "[价值,tc=价值(万元),wh=100,al=mr,fmt=n4]"
                + "[账面净值,tc=账面净值(万元),wh=100,al=mr,fmt=n4]"
                + "[排气量,wh=100,al=mr,sm=1]"
                + "[厂牌型号,wh=100,al=mc]"
                + "[颜色,wh=100,al=mc]"
                + "[车牌号,wh=100,al=mc]"
                + "[规格型号,wh=100,al=mc]"
                + "[发动机号,wh=100,al=mc]"
                + "[车架号,wh=100,al=mc]"
                + "[车辆产地,wh=150,al=mc]"
                + "[采购形式名称,tc=采购形式,wh=150,al=mc,sm=1]"
                + "[备注,wh=200,al=ml]"
                + "[资产状态名称,tc=资产状态,wh=100,al=mc,sm=1]";

                //wh是宽度，al是对齐方式,sm是否排序（1真)
                this.dgvList.GridStr(gridstr);
                this.dgvList.GoToRowByIndex(0);
            }
        }
        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            //if (this.dgvList.Rows.Count == 0) return;
            //DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            //if (row == null) return;
            ////
            //using (var form = new OCC_公车入库_Editor())
            //{
            //    form.Editor_See(row["入库单编码"].ToString());
            //    form.ShowDialog();
            //}
        }
        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.dgvList, this.lblTitle.Text);
        }
        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void btn设置显示_Click(object sender, EventArgs e)
        {        
          
            if (FshowForm == null) FshowForm = new RPT_显示信息();   
            if (FshowForm.ShowDialog() == DialogResult.OK)
            {
                Showstr = FshowForm.FShowstr;
                arrstr = Showstr.Split(new char[] { ',' });
                for (int i = 0; i < this.dgvList.ColumnCount; i++)
                {
                    this.dgvList.Columns[i].Visible = false;
                    for (int j = 0; j < arrstr.Length; j++)
                    {
                        if (this.dgvList.Columns[i].HeaderText == arrstr[j])
                        {
                            this.dgvList.Columns[i].Visible = true;
                        }
                    }
                }
            }  
        }
    }
}
