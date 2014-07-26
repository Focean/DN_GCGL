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
namespace GCGL_Client.RPT
{
    public partial class RPT_公车库存_台账 : Form
    {
        public RPT_公车库存_台账()
        {
            InitializeComponent();
            //
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
        }
        string gridstr = "{ro=1,rno=1}"
                + "[单位名称,tc=使用单位,wh=150,al=ml]"
                + "[资产编号,wh=120,al=mc]"
                + "[资产名称,wh=150,al=mc]"
                + "[车辆类型名称,tc=车辆类型,wh=120,al=mc,sm=1]"
                + "[资产类别名称,tc=资产类型,wh=120,al=mc,sm=1]"
                + "[厂牌型号,wh=150,al=mc]"
                + "[规格型号,wh=150,al=mc]"
                + "[车架号,wh=120,al=mc]"
                + "[发动机号,wh=120,al=mc]"
                + "[车牌号,wh=120,al=mc]"
                + "[排气量,wh=100,al=mc]"
                + "[计量单位,wh=80,al=mc]"
                + "[车辆产地,wh=120,al=mc]"
                + "[价值类型,wh=80,al=mc]"
                + "[价值,tc=价值(元),wh=120,fmt=N2,,al=mr]"
                + "[账面净值,tc=账面净值(元),wh=120,fmt=N2,al=mr]"
                + "[采购形式名称,tc=采购形式,wh=120,al=mc]"
                + "[折旧状态,wh=120,al=mc]"
                + "[累计折旧,wh=120,al=mc]"
                + "[经费来源,wh=150,al=mc]"
                + "[取得方式,wh=120,al=mc]"
                + "[取得日期,wh=100,al=mc,fmt=d]"
                + "[使用年限,wh=80,al=mc,fmt=n0]"
                + "[使用日期,wh=100,al=mc,fmt=d]"
                + "[保修截止日期,wh=100,al=mc,fmt=d]"
                + "[会计凭证号,wh=120,al=mc]"
                + "[入库时间,wh=100,al=mc,fmt=d]"
                + "[资产状态名称,tc=资产状态,wh=120,al=mc,fmt=d]"
                + "[备注,wh=100,al=mc,fmt=d]"
                + "[财政资产编号,wh=150,al=mc]";
        //wh是宽度，al是对齐方式,sm是是否排序（1真)，fmt是格式
        private void RPT_公车库存_台账_Load(object sender, EventArgs e)
        {
            this.dgvList.GridStr(gridstr);
        }
        private RPT_条件组合 FQueryForm;

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (FQueryForm == null) FQueryForm = new RPT_条件组合();

            FQueryForm.select_tag("Maccount");
            
            if (FQueryForm.ShowDialog() == DialogResult.OK)
            {
                  this.dgvList.DataSource = FQueryForm.table;
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
