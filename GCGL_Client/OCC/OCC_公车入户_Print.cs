using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.OCC
{
    public partial class OCC_公车入户_Print : Form
    {
        public OCC_公车入户_Print()
        {
            InitializeComponent();
            //获取打印机列表
            try
            {
                this.cbxSelectPrinter.Items.Clear();
                foreach (string iprt in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                    this.cbxSelectPrinter.Items.Add(iprt);
                this.cbxSelectPrinter.Text = (new System.Drawing.Printing.PrintDocument()).PrinterSettings.PrinterName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取打印机配置时出现异常错误！\n 错误信息：" + ex.Message);
                return;
            }  
        }
        private string RKCode;//入库单编码
        public void Editor_Print(string ACardCode)
        {
            this.Text = "车辆入户凭证(打印)";
            //
            if (DateTime.Today.Year - 2010 >= 0 && DateTime.Today.Year - 2010 < this.cbx备案字.Items.Count)
            {
                this.cbx备案字.SelectedIndex = DateTime.Today.Year - 2010;
            }
            //
            try
            {
                if (!AppServer.WcfService_Open()) return;

                var model = new Ref_WS_GCGL.DataType_NET_审批();
                model.ExAction = "GetCode";
                model.exCode = ACardCode;
                DataTable table = AppServer.wcfClient.NET_审批_List(ref model).Tables[0];
                if (table.Rows.Count == 0) return;
                    RKCode = table.Rows[0]["CardCode"].ToString();//入库单编码


                var mdl = new Ref_WS_GCGL.DataType_OCC_公车入库();
                mdl.入库单编码 = RKCode;
                DataSet db0 = AppServer.wcfClient.OCC_公车入库_List(ref mdl);
                DataTable table0 = db0.Tables[0];
                TY.Helper.FormHelper.DataBinding_DataSourceToUI(db0.Tables[0], this);
                this.lbl购车单位.Text = table0.Rows[0]["单位名称"].ToString();
                this.lbl代码证号.Text=table0.Rows[0]["组织代码证号"].ToString();
                this.lbl日期.Text = string.Format("{0:yyyy年MM月dd日}", DateTime.Today);
                this.lbl车辆类型.Text=table0.Rows[0]["车辆类型名称"].ToString();
                this.lbl购买价格.Text = string.Format("{0:0.00}", Convert.ToDecimal(table0.Rows[0]["价值"].ToString()));
                this.lbl购买日期.Text = string.Format("{0:yyyy年MM月dd日}", Convert.ToDateTime(table0.Rows[0]["取得日期"].ToString()));
                this.lbl购买发票号.Text=table0.Rows[0]["会计凭证号"].ToString();
                this.lbl座位数.Text=table0.Rows[0]["座位数"].ToString();
                
                this.txt备案号.Text=table0.Rows[0]["备案号"].ToString();
                this.cbx备案字.Text=table0.Rows[0]["备案字"].ToString();
                //
                if (table0.Rows[0]["备案号"].ToString().Trim() != "" && table0.Rows[0]["备案字"].ToString().Trim() != "")
                {
                    this.cbx备案字.Enabled = false;
                    this.txt备案号.ReadOnly = true;
                    this.btnAdd.Enabled = false;
                }
                else
                {
                    AppServer.ShowMsg("请先添加备案字号后再打印！","提示");
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
        }

        private void btn打印_Click(object sender, EventArgs e)
        {
            this.PrintForm();
            //
            this.DialogResult = DialogResult.OK;
        }
        public void PrintForm()
        {  
            //
            using (var prtForm = new OCC_公车入户_Prt())
            {
                prtForm.lbl购车单位.Text = this.lbl购车单位.Text;
                prtForm.lbl代码证号.Text = this.lbl代码证号.Text;
                prtForm.lbl日期.Text = this.lbl日期.Text;
                prtForm.lbl车辆类型.Text = this.lbl车辆类型.Text;
                prtForm.lbl厂牌型号.Text = this.lbl厂牌型号.Text;
                prtForm.lbl车架号码.Text = this.lbl车架号.Text;
                prtForm.lbl发动机号码.Text = this.lbl发动机号.Text;
                prtForm.lbl备注.Text = this.lbl备注.Text;
                prtForm.lbl购买发票号.Text = this.lbl购买发票号.Text;
                prtForm.lbl购买价格.Text = this.lbl购买价格.Text;
                prtForm.lbl购买日期.Text = this.lbl购买日期.Text;
                prtForm.lbl排气量.Text = this.lbl排气量.Text;
                prtForm.lbl颜色.Text = this.lbl颜色.Text;
                prtForm.lbl座位数.Text = this.lbl座位数.Text;
                prtForm.lbl备案号.Text = this.txt备案号.Text;
                prtForm.lbl备案字.Text = this.cbx备案字.Text;
                prtForm.Print();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.cbx备案字.Text.Trim() == "")
            {
                AppServer.ShowMsg("备案字不能为空！", "提示");
                this.cbx备案字.Focus();
                return;
            }
            if (this.txt备案号.Text.Trim() == "")
            {
                AppServer.ShowMsg("备案号不能为空！", "提示");
                this.txt备案号.Focus();
                return;
            }
            if (Convert.ToInt32(this.txt备案号.Text.Trim()) < 0 || Convert.ToInt32(this.txt备案号.Text.Trim()) > 999999)
            {
                AppServer.ShowMsg("备案号在0-999999之间！", "提示");
                this.txt备案号.Focus();
                return;
            }
            if (!AppServer.DialogMsg("确定要添加备案字号？", "提示")) return;
            try
            {
                if (!AppServer.WcfService_Open()) return;

                var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                model.ExAction = "Mod_BA";
                model.备案号 = Convert.ToInt32(this.txt备案号.Text.Trim());
                model.备案字 = this.cbx备案字.Text.Trim();
                model.LoginUserCode = AppServer.LoginUserCode;
                model.入库单编码 = RKCode;
                AppServer.wcfClient.OCC_公车入库_Edit(ref model);
                //
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                else
                {
                    AppServer.ShowMsg("添加成功！", "提示");
                    this.txt备案号.ReadOnly = true;
                    this.cbx备案字.Enabled = false;
                    this.btnAdd.Enabled = false;
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
           
        }
    }
}
