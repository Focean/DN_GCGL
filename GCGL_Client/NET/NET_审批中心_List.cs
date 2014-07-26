using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace GCGL_Client.NET
{
    public partial class NET_审批中心_List : Form
    {
        public NET_审批中心_List()
        {
            InitializeComponent();
            //
            AppServer.SetGridViewStyle(this.dgvList);
        }
        private string Slx;
        private string Szt;
        private string Sdw;
        public void Editor(string LX,string ZT,string DW)
        {
            Slx = LX;
            Szt = ZT;
            Sdw = DW;
//            年度更新计划
//配置申请审核
//处置申请审核
//入库登记审核
//出库登记审核
//车辆编制审核
            string allstr = "{ro=1,rno=1}"
                  + "[tc=选择,wh=60,type=checkbox,ro=0]"
                  + "[单位名称,tc=申请单位,wh=150,al=ml]"
                  + "[审批流程编码,wh=150,al=mc,sm=1,vi=0]"
                  + "[exWaitState,wh=120,al=ml,vi=0]"
                  + "[wfName,wh=120,al=ml,vi=0]"
                  + "[exCode,wh=120,al=ml,vi=0]";

            if (LX == "入库登记审核")
            {
                string str = "[资产编号,wh=150,al=mc,sm=1,vi=0]"
                  + "[车牌号,tc=车牌号,wh=80,al=ml]"
                  + "[资产类别名称,tc=资产类别,wh=120,al=ml]"
                  + "[车辆类型名称,tc=车辆类型,wh=120,al=ml]"
                  + "[资产名称,wh=120,al=ml]"
                  + "[车辆颜色,wh=80,al=ml]"
                  + "[厂牌型号,wh=80,al=ml]"
                  + "[发动机号,wh=80,al=ml]"
                  + "[车架号,wh=100,al=ml]"
                  + "[厂牌型号,wh=100,al=ml]"
                  + "[排气量,wh=60,al=mr]"
                  + "[座位数,wh=60,al=mr]"
                  + "[价值,tc=价值(元),wh=100,al=mr,fmt=n2]"
                  + "[购车发票号,wh=120,al=ml]";
                //wh是宽度，al是对齐方式,sm是否排序（1真)     
                this.dgvList.GridStr(allstr+str);
            }
            else if (LX == "车辆编制审核")
            {
                string str = "[一般公务用车编制数,tc=申请一般公务用车编制数,wh=150,al=mc]"
                + "[一般执法执勤用车编制数,tc=申请一般执法执勤用车编制数,wh=150,al=mc]"
                + "[特种专业技术用车编制数,tc=申请特种专业技术用车编制数,wh=150,al=mc]"
                + "[现有公务用车编制数,tc=现有一般公务用车编制数,wh=150,al=mc]"
                + "[现有执法执勤编制数,tc=现有一般执法执勤用车编制数,wh=150,al=mc]"
                + "[现有特种专业编制数,tc=申请特种专业技术用车编制数,wh=150,al=mc]";
                //wh是宽度，al是对齐方式,sm是否排序（1真)     
                this.dgvList.GridStr(allstr + str);
            }

            DataBinding_GridView(0);
        }
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_NET_审批();
                model.ExAction = "Review";
                model.审批类型 = Slx;
                model.exWaitState = Szt;
                model.单位编码 = Sdw;
                DataTable table = AppServer.wcfClient.NET_审批_List(ref model).Tables[0];
                this.dgvList.DataSource = table;
                //
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

        private void btn审批_Click(object sender, EventArgs e)
        {
            using (var form = new NET_审批中心_Edit())
            {
                form.Editor_Mod(this.dgvList.CurrentRow.Cells["wfName"].Value.ToString(),
                     this.dgvList.CurrentRow.Cells["exCode"].Value.ToString(),
                     this.dgvList.CurrentRow.Cells["单位名称"].Value.ToString(),
                     this.dgvList.CurrentRow.Cells["exWaitState"].Value.ToString());

                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_GridView(0);
                }
            }
        }

        private void btn批量审批_Click(object sender, EventArgs e)
        {        
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                foreach (DataGridViewRow dr in this.dgvList.Rows)
                {
                    if (dr.Cells["选择"].Value != null)
                    {
                        if (dr.Cells["选择"].Value.ToString() == "True")
                        {
                            var model = new Ref_WS_GCGL.DataType_NET_审批();
                            model.LoginUserCode = AppServer.LoginUserCode;
                            model.exCode = dr.Cells["exCode"].Value.ToString();
                            model.exOpinionFlag = 1;
                            model.exOpinion = "无";
                            AppServer.wcfClient.NET_审批_Edit(ref model);
                            if (model.ExResult != 0)
                            {
                                AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                                return;
                            }
                        }
                    }
                }
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
            DataBinding_GridView(0);

        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void NET_审批中心_List_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.btn审批.PerformClick();
        }

        private void dgvList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(this.dgvList.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), this.dgvList.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 6, e.RowBounds.Location.Y + 4); 
        }

        private void btn批量不通过_Click(object sender, EventArgs e)
        {
            string str = string.Empty;
            foreach (DataGridViewRow dr in this.dgvList.Rows)
            {
                if (dr.Cells["选择"].Value != null)
                {
                    if (dr.Cells["选择"].Value.ToString() == "True")
                    {
                        str += dr.Cells["exCode"].Value.ToString()+",";
                    }
                }
            }
            using (var form = new NET_审批中心_List_不通过())
            {
                form.exCode=str;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_GridView(0);
                }
            }
        }

        private void dgvList_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.dgvList.CurrentRow.Cells["选择"].Value.ToBooleanDef() == true)
                this.dgvList.CurrentRow.Cells["选择"].Value = false;
            else
                this.dgvList.CurrentRow.Cells["选择"].Value = true;
        }
    }
}
