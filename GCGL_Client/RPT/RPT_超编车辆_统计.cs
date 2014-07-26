using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace GCGL_Client.RPT
{
    public partial class RPT_超编车辆_统计 : Form
    {
        public RPT_超编车辆_统计()
        {
            InitializeComponent();
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
        }

        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                model.ExAction = "List_tj";
                if (AppServer.LoginUnitIsCZT())
                {
                    if (this.txt单位编码.Tag != null)
                    {
                        model.单位编码 = this.txt单位编码.Tag.ToString();
                        model.包含下级 = this.chk包含下级.Checked;
                    }
                    else
                        model.单位编码 = null;
                }
                DataSet db = AppServer.wcfClient.COS_车辆超编_List(ref model);

                this.dgvList.DataSource = db.Tables[0];
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
            //
            this.DialogResult = DialogResult.OK;
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void RPT_超编车辆_统计_Load(object sender, EventArgs e)
        {
            string str = "{ro=1,rno=1}"
               + "[单位名称,tc=车辆所属单位,wh=150,al=ml]"
               + "[编制情况,wh=100,al=ml]"
               + "[资产状态名称,tc=资产状态,wh=100,al=mc,sm=1]"
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
               + "[备注,wh=200,al=ml]";

            //wh是宽度，al是对齐方式,sm是否排序（1真)     
            this.dgvList.GridStr(str);
            DataBinding_GridView(0);
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
    }
}
