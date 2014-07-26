using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using GCGL_Client.Main;
using TY.Common;
namespace GCGL_Client.RPT
{
    public partial class RPT_公车库存_状况 : Form
    {
        public RPT_公车库存_状况()
        {
            InitializeComponent();        
        }
        string gridstr = "{ro=1,rno=1}"
                        + "[资产编号,wh=120,al=mc]"
                        + "[资产名称,wh=150,al=mc]"
                        + "[厂牌型号,wh=150,al=mc]"
                        + "[规格型号,wh=150,al=mc]"
                        + "[车架号,wh=120,al=mc]"
                        + "[发动机号,wh=120,al=mc]"
                        + "[车牌号,wh=120,al=mc]"
                        + "[排气量,wh=100,al=mc]"
                        + "[计量单位,wh=80,al=mc]"
                        + "[车辆类型名称,tc=车辆类型,wh=120,al=mc]"
                        + "[资产类别名称,tc=资产类型,wh=120,al=mc,sm=1]"
                        + "[采购形式名称,tc=采购形式,wh=120,al=mc]"
                        + "[价值类型,wh=80,al=mc]"
                        + "[价值,tc=价值(万元),wh=120,fmt=N4,,al=mr]"
                        + "[账面净值,tc=账面净值(万元),wh=120,fmt=N4,al=mr]"
                        + "[折旧状态,wh=120,al=mc]"
                        + "[累计折旧,wh=120,al=mc]"
                        + "[取得方式,wh=120,al=mc]"
                        + "[取得日期,wh=100,al=mc,fmt=d]"
                        + "[使用年限,wh=80,al=mc,fmt=n0]"
                        + "[使用日期,wh=100,al=mc,fmt=d]"
                        + "[保修截止日期,wh=100,al=mc,fmt=d]"
                        + "[会计凭证号,wh=120,al=mc]"
                        + "[单位名称,tc=使用单位,wh=150,al=mc,fmt=d]"
                        + "[入库时间,wh=100,al=mc,fmt=d]"
                        + "[修改时间,wh=100,al=mc,fmt=d]"
                        + "[资产状态名称,tc=资产状态,wh=100,al=mc]"
                        + "[财政资产编号,wh=150,al=mc]";
                       //wh是宽度，al是对齐方式,sm是是否排序（1真)，fmt是格式
        private void RPT_公车库存_状况_Load(object sender, EventArgs e)
        {
            this.dgvList.GridStr(gridstr);
        }

        #region 数据绑定自定义方法
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车库存();
                model.ExAction = "Details";               
                model.车牌号 = this.txt车牌号.Text.ToString();
                if (AppServer.LoginUnitIsYSDW()||AppServer.LoginUnitIsZGDW()||AppServer.LoginUnitIsGWC())
                {
                    model.单位编码 = AppServer.LoginUnitCode;
                }
                DataSet db = AppServer.wcfClient.OCC_公车库存_List(ref model);
                DataTable table = db.Tables[1];
                this.dgvList.DataSource = db.Tables[1];
                this.dgvList.DataSource = table;

                this.dgvList.GridStr(gridstr);
                this.dgvList.GoToRowByIndex(ACurrRowIndex);
                this.txt车牌号.Focus();
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
        #endregion

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }   

        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.dgvList, this.lblTitle.Text);
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt车牌号_TextChanged(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }     
    }
}
