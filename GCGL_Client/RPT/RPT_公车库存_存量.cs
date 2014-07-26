using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using GLG.Common;
using GCGL_Client.Main;

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
            this.btnQuery.PerformClick();
        }
        private RPT_条件组合 FQueryForm;

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (FQueryForm == null) FQueryForm = new RPT_条件组合();

            FQueryForm.select_tag("Query");
            if (FQueryForm.ShowDialog() == DialogResult.OK)
            {
                int a = FQueryForm.f;
                this.dgvList.DataSource = FQueryForm.table;
               
                string str1 = null;
                string str2 = null;
                string gridstr = null;
                if (FQueryForm.f == 0)
                {
                    str1 = "[收购单位,wh=150,al=ml]";
                }
                str2="{ro=1,rno=1}"
                +"[单位名称,tc=车辆所属单位,wh=150,al=ml]"
                + "[资产编号,wh=90,al=mc,vi=0]"
                + "[资产名称,wh=100,al=mc]"
                + "[价值,tc=价值(万元),wh=100,al=mr,fmt=n2]"
                + "[账面净值,tc=账面净值(万元),wh=100,al=mr,fmt=n2]"
                + "[排气量,wh=100,al=mr]"
                + "[厂牌型号,wh=100,al=mc]"
                + "[颜色,wh=100,al=mc]"
                + "[车牌号,wh=100,al=mc]"
                + "[规格型号,wh=100,al=mc]"
                + "[发动机号,wh=100,al=mc]"
                + "[车架号,wh=100,al=mc]"
                + "[车辆类型名称,tc=车辆类型,wh=120,al=mc]"
                + "[资产类别名称,wh=资产类别,wh=120,al=mc]"
                + "[车辆产地,wh=150,al=mc]"
                + "[取得日期,wh=100,al=mc,fmt=d]"
                + "[保修截止日期,wh=100,al=mc,fmt=d]"
                + "[采购形式名称,tc=采购形式,wh=150,al=mc]"
                + "[备注,wh=200,al=mc]"
                + "[资产状态名称,tc=资产状态,wh=100,al=mc,sm=1]";

                //wh是宽度，al是对齐方式,sm是否排序（1真)
                gridstr = str2 + str1;
                this.dgvList.GridStr(gridstr);
                this.dgvList.GoToRowByIndex(0);
            }
        }  
        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.dgvList, this.lblTitle.Text);
        }
        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
