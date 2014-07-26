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
namespace GCGL_Client.FZB
{
    public partial class FZB_机构信息 : Form
    {
        public FZB_机构信息()
        {
            InitializeComponent();
            this.LblTitle.Text = AppServer.LoginAreaName+"组织机构信息列表";
        }

        private void BZ_组织机构_Load(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }
        #region 数据绑定自定义方法
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_CMN_单位();
                model.ExAction = "GetOrg";
                if (this.txt行政区划.Tag == null || this.txt行政区划.Tag.ToString() == "")
                {
                    model.单位编码 = null;
                }
                else
                {
                    model.区划编码 = this.txt行政区划.Tag.ToString();
                    model.包含下级 = this.chk包含下级.Checked;
                }
                DataSet db = AppServer.wcfClient.CMN_单位_List(ref model);
                DataTable table = db.Tables[0];

                this.dgvList.DataSource = table;
                string gridstr = "{ro=1,rno=1}"
                   + "[单位名称,wh=200,al=ml,sm=1]"
                   + "[单位类型名称,tc=单位类型,wh=120,al=mc,sm=1]"
                   + "[处室名称,wh=150,al=mc]"
                   + "[处室类型名称,tc=处室类型,wh=120,al=mc]"
                   + "[区划名称,wh=150,al=mc,sm=1]"
                   + "[联系人,wh=100,al=mc]"
                   + "[电话,wh=100,al=mc]"
                   + "[传真,wh=100,al=mc]"
                   + "[单位地址,wh=220,al=ml]"
                   + "[邮编,wh=150,al=mc]";
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
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void btn选择单位_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(1);
            AppServer.Frm行政区划.SetShowParam(this.txt行政区划, 0);
            AppServer.Frm行政区划.ShowDialog();
            if (AppServer.Frm行政区划.DialogResult == DialogResult.OK)
            {
                this.txt行政区划.Tag = AppServer.Frm行政区划.SelectNodeID;
                this.txt行政区划.Text = AppServer.Frm行政区划.SelectNodeTitle;
            }
        }

        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.dgvList, this.LblTitle.Text);
        }
        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
