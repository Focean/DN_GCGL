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
using GCGL_Client.NET;

namespace GCGL_Client.OCC
{
    public partial class OCC_公车出库_报废 : Form
    {
        public OCC_公车出库_报废()
        {
            InitializeComponent();
            txt经办人.Text = AppServer.LoginUserName;
            if (AppServer.LoginUnitType == 8)
            {
                label4.Text = "    资产编号：";
                label5.Enabled = false;
            }
        }

        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                if (AppServer.LoginUnitType == 8)
                {
                    var dtm = new Ref_WS_GCGL.DataType_OCC_公车库存();
                    dtm.资产编号 = txt处置申请编号.Text.Trim();
                    DataSet ds = AppServer.wcfClient.OCC_公车库存_List(ref dtm);
                    this.dgvList.DataSource = ds.Tables[0];
                }
                else
                {
                    var model = new Ref_WS_GCGL.DataType_OCC_处置申请();
                    model.ExAction = "Card";
                    model.申请编号 = this.txt处置申请编号.Text.Trim();
                    model.申请序号 = Onum;

                    DataSet db = AppServer.wcfClient.OCC_处置申请_List(ref model);
                    this.dgvList.DataSource = db.Tables[3];
                    string gridstr = "{ro=1,rno=1}"
                        + "[资产编号,wh=20,al=ml,vi=0]"
                        + "[资产名称,wh=150,al=ml]"
                        + "[规格型号,wh=150,al=mc]"
                        + "[价值,tc=账面原值(元),wh=120,al=mr]"
                        + "[账面净值,tc=账面净值(元),fmt=N2,wh=120,al=mr]"
                        + "[评估价值,tc=评估价值(元),fmt=N2,wh=120,al=mr]";

                    //wh是宽度，al是对齐方式,sm是是否排序（1真),fmt是数字格式
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

        #region 增、修、查看
        int Onum;
        public void Editor_Add()
        {
            this.Text = "报废出库登记(新增)";
            this.Tag = "Add_BF";
            this.btn提交.Tag = "";
            //           
        }
        public void Editor_Mod(string BM)
        {
            this.Text = "报废出库登记(修改)";
            this.Tag = "Mod";
            this.btn提交.Tag = BM;
            //            
            if (!AppServer.WcfService_Open()) return;
            var model = new Ref_WS_GCGL.DataType_OCC_公车出库();
            model.出库单编码 = BM;
            DataSet db = AppServer.wcfClient.OCC_公车出库_List(ref model);
            if (db.Tables[0].Rows.Count < 1) return;
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(db.Tables[0], this);
            Onum =db.Tables[0].Rows[0]["处置申请序号"].ToIntegerDef();
            this.txt附件信息.Tag = db.Tables[0].Rows[0]["附件编码"].ToString();
            this.txt附件信息.Text = db.Tables[0].Rows[0]["附件摘要"].ToString();
            DataBinding_GridView(0);
        }
        public void Editor_See(string BM)
        {
            this.Text = "报废出库登记(查看)";
            this.Tag = "Chk";
            //
            if (!AppServer.WcfService_Open()) return;
            var model = new Ref_WS_GCGL.DataType_OCC_公车出库();
            model.出库单编码 = BM; 
            DataSet db = AppServer.wcfClient.OCC_公车出库_List(ref model);
            if (db.Tables[0].Rows.Count < 1) return;
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(db.Tables[0], this);
            Onum = db.Tables[0].Rows[0]["处置申请序号"].ToIntegerDef();
            this.txt附件信息.Tag = db.Tables[0].Rows[0]["附件编码"].ToString();
            this.txt附件信息.Text = db.Tables[0].Rows[0]["附件摘要"].ToString();
            DataBinding_GridView(0);
         
            //
            this.btn提交.Enabled = false;
            this.btn附件管理.Enabled = false;
        }
        private void btn处置申请_Click(object sender, EventArgs e)
        {
            if (AppServer.LoginUnitType == 8)
            {
                string[] ZCstr = new string[10];
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
                    form.Select_BF("");
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        txt处置申请编号.Text = form.RequestCode;
                        Onum = form.RequestIndex;
                        DataBinding_GridView(0);
                    }
                }
            }
        }
        #endregion
        #region 功能按钮

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
            if (this.txt处置申请编号.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("处置申请不能为空！", "提示");
                this.txt处置申请编号.Focus();
                return;
            }
            if (this.txt本单位批准人 .Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("本单位批准人不能为空！", "提示");
                this.txt本单位批准人.Focus();
                return;
            }
            if (this.txt经办人.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("经办人不能为空！", "提示");
                this.txt经办人.Focus();
                return;
            }
            if (this.txt收购单位.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("收购单位不能为空！", "提示");
                this.txt收购单位.Focus();
                return;
            }
            if (this.nud处置收入.Value==0)
            {
                AppServer.ShowMsg("处置收入不能为0！", "提示");
                this.nud处置收入.Focus();
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
                model.单位编码 = AppServer.LoginUnitCode;
                model.资产编号 = dgvList.Rows[0].Cells[0].Value.ToString();
                model.LoginUserCode = AppServer.LoginUserCode;
                model.备注 = this.txt备注.Text.ToString();
                model.出库单编码 = this.btn提交.Tag.ToString();
                model.处置申请序号 = AppServer.SQXH;
                model.收购单位 = this.txt收购单位.Text.ToString();
                model.调拨日期 = this.dtp调拨日期.Value;
                model.处置收入 = this.nud处置收入.Value;
                model.处置形式编码 = "02";
                model.本单位批准人 = this.txt本单位批准人.Text.ToString();
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
        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void OCC_公车出库_报废_Load(object sender, EventArgs e)
        {

        }


    }
}
