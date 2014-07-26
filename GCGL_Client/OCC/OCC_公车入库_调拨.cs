using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GLG.Common;
using TY.Helper;
namespace GCGL_Client.OCC
{
    public partial class OCC_公车入库_调拨 : Form
    {
        public OCC_公车入库_调拨()
        {
            InitializeComponent();
        }

        #region 数据绑定自定义方法
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车出库();
                model.ExAction = "Search1";
                model.接收单位编码 = AppServer.LoginUnitCode;
                DataSet db = AppServer.wcfClient.OCC_公车出库_List(ref model);
                DataTable table = db.Tables[0];

                this.dgvList.DataSource = table;
                string gridstr = "{ro=1,rno=1}"
                   + "[出库单编码,wh=120,al=mc,sm=1]"
                   + "[资产编号,wh=90,al=mc,sm=1,vi=0]"
                   + "[处置形式名称,tc=处置形式,wh=90,al=mc,sm=1]"
                   + "[资产名称,wh=150,al=mc]"
                   + "[价值,tc=价值(万元),wh=120,fmt=N2,al=mr]"
                   + "[账面净值,tc=账面净值(万元),wh=120,fmt=N2,al=mr]"
                   + "[车辆类型名称,tc=车辆类型,wh=150,al=mc]"
                   + "[资产类别名称,tc=资产类别,wh=150,al=mc]"
                   + "[排气量,tc=排气量(L),wh=120,al=mc]"
                   + "[发动机号,wh=150,al=mc]"
                   + "[车架号,wh=120,al=mc]"
                   + "[规格型号,wh=100,al=mc]"
                   + "[厂牌型号,wh=100,al=mc]"
                   + "[保修截止日期,wh=100,al=mc]";
                //wh是宽度，al是对齐方式,sm是是否排序（1真)
                this.dgvList.GridStr(gridstr);
                this.dgvList.GoToRowByIndex(ACurrRowIndex);
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

        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.dgvList, this.LblTitle.Text);
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void OCC_公车入库_调拨_Load(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new OCC_公车入库_Editor())
            {
                form.Editor_Accept(row,row["出库单编码"].ToString(),2);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    DataBinding_GridView(0);
                }
            }


        }

        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            //
            using (var form = new OCC_公车入库_Editor())
            {
                //form.Editor_View(row);
            }
        }
    }
}
