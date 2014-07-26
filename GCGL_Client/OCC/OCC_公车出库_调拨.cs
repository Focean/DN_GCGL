using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Common;
using TY.Helper;
using GCGL_Client.NET;

namespace GCGL_Client.OCC
{
    public partial class OCC_公车出库_调拨 : Form
    {
        public OCC_公车出库_调拨()
        {
            InitializeComponent();
            txt经办人.Text = AppServer.LoginUserName;
            if (AppServer.LoginUnitType == 1)
            {
                txt接收单位编码.Text = "河南省公物仓";
                txt接收单位编码.Tag = "410001_GWC";
                btn选择单位.Visible = false;
            }
            if (AppServer.LoginUnitType == 8)
            {
                label4.Text = "    资产编号：";
            }
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
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                if (AppServer.LoginUnitIsGWC())
                {
                    var dtm = new Ref_WS_GCGL.DataType_OCC_公车库存();
                    dtm.ExAction = "zSearch";
                    dtm.资产编号 = txt处置申请编号.Text.Trim();
                    DataSet ds = AppServer.wcfClient.OCC_公车库存_List(ref dtm);
                    this.dgvList.DataSource = ds.Tables[1];
                    string gridstr = "{ro=1,rno=1}"
                           + "[资产编号,wh=20,al=ml,vi=0]"
                           + "[资产名称,wh=150,al=ml]"
                           + "[规格型号,wh=150,al=mc]"
                           + "[价值,tc=账面原值(元),fmt=N2,wh=120,al=mr]"
                           + "[账面净值,tc=账面净值(元),fmt=N2,wh=120,al=mr]"
                           + "[排气量,tc=排气量(L),fmt=N1,wh=120,al=mc]";

                    //wh是宽度，al是对齐方式,sm是是否排序（1真)
                    this.dgvList.GridStr(gridstr);
                    this.dgvList.GoToRowByIndex(ACurrRowIndex);
                }
                else
                {
                    var model = new Ref_WS_GCGL.DataType_OCC_处置申请();
                    model.ExAction = "Card";
                    model.申请编号 = this.txt处置申请编号.Text.Trim();
                    model.申请序号 = Onum;
                    DataSet db = AppServer.wcfClient.OCC_处置申请_List(ref model);
                    this.dgvList.DataSource = db.Tables[2];
                    string gridstr = "{ro=1,rno=1}"
                            + "[资产编号,wh=20,al=ml,vi=0]"
                            + "[资产名称,wh=150,al=ml]"
                            + "[规格型号,wh=150,al=mc]"
                            + "[价值,tc=账面原值(元),fmt=N2,wh=120,al=mr]"
                            + "[账面净值,tc=账面净值(元),fmt=N2,wh=120,al=mr]"
                            + "[评估价值,tc=评估价值(元),fmt=N2,wh=120,al=mr]";

                    //wh是宽度，al是对齐方式,sm是是否排序（1真)
                    this.dgvList.GridStr(gridstr);
                    this.dgvList.GoToRowByIndex(ACurrRowIndex);
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
        #region 增、修改、查看、打印
        int Onum;
        public void Editor_Add()
        {
            this.Text = "调拨出库登记(新增)";
            this.Tag = "Add_DB";
            //
            this.btn提交.Tag = "";
        }

        public void Editor_Mod(string BH)
        {
            this.Text = "调拨出库登记(修改)";
            this.Tag = "Mod";
            //
            if (!AppServer.WcfService_Open()) return;
            var model = new Ref_WS_GCGL.DataType_OCC_公车出库();
            model.出库单编码 = BH;
            DataSet db = AppServer.wcfClient.OCC_公车出库_List(ref model);
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(db.Tables[0], this);
            Onum=db.Tables[0].Rows[0]["处置申请序号"].ToIntegerDef();
            this.txt接收单位编码.Text = db.Tables[0].Rows[0]["单位名称"].ToString();
            this.txt接收单位编码.Tag = db.Tables[0].Rows[0]["接收单位编码"].ToString();
            this.txt附件信息.Tag = db.Tables[0].Rows[0]["附件编码"].ToString();
            this.txt附件信息.Text = db.Tables[0].Rows[0]["附件摘要"].ToString();
            DataBinding_GridView(0);
            this.btn提交.Tag = BH;
        }
        public void Editor_See(string BM, bool AEmebMode = false)
        {
            this.Text = "调拨出库登记(查看)";
            this.Tag = "Chk";
            //
            if (!AppServer.WcfService_Open()) return;
            var model = new Ref_WS_GCGL.DataType_OCC_公车出库();
            model.出库单编码 = BM;
            DataSet db = AppServer.wcfClient.OCC_公车出库_List(ref model);
            if (db.Tables[0].Rows.Count ==0) return;
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(db.Tables[0], this);
            Onum = db.Tables[0].Rows[0]["处置申请序号"].ToIntegerDef();
           // this.txt经办人.Text = db.Tables[0].Rows[0]["经办人"].ToString();
            this.txt接收单位编码.Text = db.Tables[0].Rows[0]["单位名称"].ToString();
            this.txt接收单位编码.Tag = db.Tables[0].Rows[0]["接收单位编码"].ToString();
            this.txt附件信息.Tag = db.Tables[0].Rows[0]["附件编码"].ToString();
            this.txt附件信息.Text = db.Tables[0].Rows[0]["附件摘要"].ToString();
            this.txt经办人.Text = db.Tables[0].Rows[0]["创建人"].ToString();
            DataBinding_GridView(0);
            //
            this.txt备注.ReadOnly = true;
            this.txt经办人.ReadOnly = true;
            this.dtp调拨日期.Enabled = false;
            this.btn配置审批.Visible = false;
            this.btn选择单位.Visible = false;
            this.btn提交.Visible = false;
            this.btn附件管理.Visible = false;

            //嵌入式状态不显示工具栏
            this.pnlTool.Visible = !AEmebMode;
        }
        public void Editor_Print(string BM)
        {
            this.Text = "处置备案表打印";
            //
            if (!AppServer.WcfService_Open()) return;
            var model = new Ref_WS_GCGL.DataType_OCC_公车出库();
            model.出库单编码 = BM;
            DataSet db = AppServer.wcfClient.OCC_公车出库_List(ref model);
            if (db.Tables[0].Rows.Count == 0) return;
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(db.Tables[0], this);
            Onum = db.Tables[0].Rows[0]["处置申请序号"].ToIntegerDef();
            // this.txt经办人.Text = db.Tables[0].Rows[0]["经办人"].ToString();
            this.txt接收单位编码.Text = db.Tables[0].Rows[0]["单位名称"].ToString();
            this.txt接收单位编码.Tag = db.Tables[0].Rows[0]["接收单位编码"].ToString();
            this.txt附件信息.Tag = db.Tables[0].Rows[0]["附件编码"].ToString();
            this.txt附件信息.Text = db.Tables[0].Rows[0]["附件摘要"].ToString();
            this.txt经办人.Text = db.Tables[0].Rows[0]["创建人"].ToString();
            DataBinding_GridView(0);

            //
            this.txt备注.ReadOnly = true;
            this.txt经办人.ReadOnly = true;
            this.dtp调拨日期.Enabled = false;
            this.btn配置审批.Visible = false;
            this.btn选择单位.Visible = false;
            this.btn附件管理.Enabled = false;
            this.btn提交.Visible = false;
            this.btn打印.Visible = true;
            this.lbl打印机.Visible = true;
            this.cbxSelectPrinter.Visible = true;
        }
        #endregion 
        private void btn配置审批_Click(object sender, EventArgs e)
        {
            if (this.txt接收单位编码.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("接收单位不能为空！", "提示");
                this.txt接收单位编码.Focus();
                return;
            }
            if (AppServer.LoginUnitIsGWC())
            {
                 string[] ZCstr =new string[10];
                using (var form = new OCC_公车库存_Select())
                {   
                   form.Select_查询单位资产(ZCstr);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        txt处置申请编号.Text = form.SelectPropertyCode;
                        DataBinding_GridView(0);
                    }
                }
            }
            else
            {  
                using (var form = new OCC_处置申请_Select())
                {
                    form.Select_DB(this.txt接收单位编码.Tag.ToString());
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        txt处置申请编号.Text = form.RequestCode.ToString();
                        Onum = form.RequestIndex;
                        DataBinding_GridView(0);
                    }
                }
            }
        }

        private void btn附件管理_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt附件信息.Tag == null) this.txt附件信息.Tag = "";
                form.Editor_Mod(this.txt附件信息.Tag.ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.txt附件信息.Tag = form.FileCode;
                    this.txt附件信息.Text = form.FileInfo;
                }
            }
        }

        private void btn附件查看_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt附件信息.Tag == null) this.txt附件信息.Tag = "";
                form.Editor_See(this.txt附件信息.Tag.ToString());
                form.ShowDialog();
            }
        }

        private void btn提交_Click(object sender, EventArgs e)
        {
            #region 控件验证
            if (this.txt接收单位编码.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("接收单位不能为空！", "提示");
                this.txt接收单位编码.Focus();
                return;
            }
            if (this.txt处置申请编号.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("处置申请不能为空！", "提示");
                this.txt处置申请编号.Focus();
                return;
            }
            if (this.txt经办人.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("经办人不能为空！", "提示");
                this.txt经办人.Focus();
                return;
            }
            #endregion
            #region 提交

            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_OCC_公车出库();
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.ExAction = this.Tag.ToString();
                model.接收单位编码 = this.txt接收单位编码.Tag.ToString();
                model.单位编码 = AppServer.LoginUnitCode;
                model.资产编号 = dgvList.Rows[0].Cells[0].Value.ToString();
                model.LoginUserCode = AppServer.LoginUserCode;
                model.处置形式编码 = "03";
                model.出库单编码 = this.btn提交.Tag.ToString();
                model.处置申请序号 = Onum;              
                if (AppServer.LoginUnitIsGWC())
                {
                    model.处置申请编号 = null;
                    model.处置申请序号 = 0;
                }
                if (this.txt附件信息.Tag != null) model.附件编码 = this.txt附件信息.Tag.ToString();
                AppServer.wcfClient.OCC_公车出库_Edit(ref model);
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
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
            #endregion
            this.DialogResult = DialogResult.OK;
        }

        private void btn选择单位_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(22);
            AppServer.Frm单位信息.SetShowParam(this.txt接收单位编码, 0);
            AppServer.Frm单位信息.ShowDialog();
            if (AppServer.Frm单位信息.DialogResult == DialogResult.OK)
            {
                this.txt接收单位编码.Tag = AppServer.Frm单位信息.SelectNodeID;
                this.txt接收单位编码.Text = AppServer.Frm单位信息.SelectNodeTitle;
            }
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OCC_公车出库_调拨_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.J && e.Modifiers == Keys.Control)         //Ctrl+J
            {
                this.btn提交_Click(this, EventArgs.Empty);
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
            if (this.dgvList.Rows.Count == 0) return;
            using (var pForm = new OCC_处置备案_Print())
            {
                pForm.lbl申报单位.Text = AppServer.LoginUnitName;
                pForm.lbl原因.Text = this.txt备注.Text;
                pForm.lbl资产价值.Text = string.Format("{0:0.00}",Convert.ToDecimal(this.dgvList.Rows[0].Cells["价值"].Value.ToString()));
                //
                pForm.Print(this.cbxSelectPrinter.Text);
            }
        }
    }
}
