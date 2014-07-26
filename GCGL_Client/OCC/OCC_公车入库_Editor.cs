using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.NET;

namespace GCGL_Client.OCC
{
    public partial class OCC_公车入库_Editor : Form
    {
        public OCC_公车入库_Editor()
        {
            InitializeComponent();
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 30, this.btn提交, true);
            this.txt单位编码.Text = AppServer.LoginUnitName;
            this.txt单位编码.Tag = AppServer.LoginUnitCode;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                this.cbx采购形式编码.DataSource = AppServer.wcfClient.FZB_编码_List("采购形式1").Tables[0];
                this.cbx采购形式编码.DisplayMember = "名称";
                this.cbx采购形式编码.ValueMember = "编码";
                //
                this.cbx排气量.DataSource = AppServer.wcfClient.FZB_编码_List("排气量").Tables[0];
                this.cbx排气量.DisplayMember = "名称";
                this.cbx排气量.ValueMember = "名称";
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
            getDep();
            if (AppServer.LoginUnitType == 1)
            {
                btn车辆类型.Enabled = false;
                btn资产类别.Enabled = false;
            }
            if (AppServer.LoginUnitType == 8)
            {
                this.txt配置申请编号.Enabled = false;
            }
        }

        #region 数据绑定自定义方法
        private void DataBinding_GridView(String Code)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                model.入库单编码 = Code;
                DataSet db = AppServer.wcfClient.OCC_公车入库_List(ref model);
                DataTable table = db.Tables[0];
                TY.Helper.FormHelper.DataBinding_DataSourceToUI(db.Tables[0], this);
                this.txt单位编码.Text = table.Rows[0]["单位名称"].ToString();
                this.txt单位编码.Tag = table.Rows[0]["单位编码"].ToString();
                this.nud价值.Value = Convert.ToDecimal(table.Rows[0]["价值"].ToString()) * 10000;
                this.nud账面净值.Value = Convert.ToDecimal(table.Rows[0]["账面净值"].ToString()) * 10000;
                this.nud累计折旧.Value = Convert.ToDecimal(table.Rows[0]["累计折旧"].ToString());
                this.txt车辆类型编码.Text = table.Rows[0]["车辆类型名称"].ToString();
                this.txt车辆类型编码.Tag = table.Rows[0]["车辆类型编码"].ToString();

                this.txt资产类别编码.Text = table.Rows[0]["资产类别名称"].ToString();
                this.txt资产类别编码.Tag = table.Rows[0]["资产类别编码"].ToString();
                this.txt附件信息.Text = table.Rows[0]["附件摘要"].ToString();
                this.txt附件信息.Tag = db.Tables[0].Rows[0]["附件编码"].ToString();
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
      
        //获取处室
        public void getDep()
        {
            if (this.txt单位编码.Tag == null) return;
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_单位_处室();
                model.ExAction = "List";
                model.单位编码 = this.txt单位编码.Tag.ToString();
                DataTable table = AppServer.wcfClient.CMN_单位_处室_List(ref model).Tables[0];
                this.cbx使用部门.DataSource = table;
                this.cbx使用部门.DisplayMember = "处室名称";
                this.cbx使用部门.ValueMember = "处室编码";
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

        #region 增、改、接收
        int N = 0;
        public string BM = null;
        public string Code = null;//出库单编码接收变量
        public void Editor_Add()
        {
            this.Text = "车辆入库(新增)";
            this.Tag = "Add_GZ";
            //
            this.cbx折旧状态.SelectedIndex = 0;
            this.cbx价值类型.SelectedIndex = 0;
            this.btn提交.Tag = "";
            this.btn购置审批.Visible = false;

            if (AppServer.LoginUnitType == 1 || AppServer.LoginUnitType == 8)
            {
                this.btn选择单位.Enabled = false;
                this.txt单位编码.Text = AppServer.LoginUnitName;
                this.txt单位编码.Tag = AppServer.LoginUnitCode;
            }
            if (AppServer.LoginUnitType != 8)
            {
                this.txt配置申请编号.Text = AppServer.RequestCode.ToString();
                this.txt车辆类型编码.Text = AppServer.VName.ToString();
                this.txt车辆类型编码.Tag = AppServer.VType.ToString();
                this.txt资产类别编码.Tag = AppServer.PType.ToString();
                this.txt资产类别编码.Text = AppServer.PName.ToString();
                this.cbx排气量.Text = AppServer.Emission;
                this.txt厂牌型号.Text = AppServer.CarBrand;
                this.txt规格型号.Text = AppServer.CarModel;
                this.nud价值.Value = Convert.ToDecimal(AppServer.CarPrice) * 10000;
            }
        }
        public void Editor_Mod(String Code,string RKCode)
        {
            this.Text = "车辆入库(修改)";
            this.Tag = "Mod_GZ";
            //
            N = 1;
            BM = Code;
            this.btn提交.Tag = RKCode;
            this.btn购置审批.Enabled = false;
            this.Lbl配置审批编号.Enabled = false;
            this.txt配置申请编号.Enabled = false;
            DataBinding_GridView(Code);
            N = 0;
        }
        public void Editor_See(String Code)
        {
            this.Text = "车辆入库(查看)";
            this.Tag = "See";
            //    
            N = 1;//不触发ValueChanged
            this.DataBinding_GridView(Code);

            this.btn购置审批.Enabled = false;
            this.btn提交.Enabled = false;
            this.btn附件管理.Enabled = false;
            N = 0;
        }
        public void Editor_Accept(DataRow row, string CKCode, int operation)
        {
            //operation 为1表示调拨入库修改  2表示增加调拨入库
            this.Text = "车辆入库(接收)";
            if (operation == 2) this.Tag = "Add_DB";
            else this.Tag = "Mod_DB";
            //         
             BM=row["资产编号"].ToString();
             this.btn提交.Tag = "";
             this.txt配置申请编号.Enabled  = false;
             this.btn购置审批.Enabled = false;
             Code = CKCode;
             DataRow dr;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_OCC_公车库存();
                model.资产编号 = BM;
                DataSet db = AppServer.wcfClient.OCC_公车库存_List(ref model);
                dr = db.Tables[0].Rows[0];
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
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(dr, this);
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.ReadOnly = true;
                }
            }
            foreach (Control d in this.Controls)
            {
                if (d is NumericUpDown)
                {
                    NumericUpDown nu = (NumericUpDown)d;
                    nu.ReadOnly = true;
                }
            }
            this.cbx采购形式编码.Enabled = false;
            this.btn车辆类型.Enabled = false;
            this.btn资产类别.Enabled = false;
            this.cbx计量单位.Enabled = false;
            this.cbx价值类型.Enabled = false;
            this.cbx折旧状态.Enabled = false;
            this.dtp保修截止日期.Enabled = false;
            this.dtp取得日期.Enabled = false;
            this.dtp使用日期.Enabled = false;
            this.txt车牌号.ReadOnly = false;
            this.txt车牌号.BackColor = Color.Yellow;
            this.txt取得方式.Text = "调拨";
            this.txt取得方式.BackColor = Color.Yellow;
            this.txt车辆类型编码.Text = dr["车辆类型名称"].ToString();
            this.txt车辆类型编码.Tag = dr["车辆类型编码"].ToString();
            this.txt资产类别编码.Text = dr["资产类别名称"].ToString();
            this.txt资产类别编码.Tag = dr["资产类别编码"].ToString();  
            this.cbx排气量.Text=dr["排气量"].ToString();
            this.txt单位编码.Text = AppServer.LoginUnitName;
            this.txt单位编码.Tag = AppServer.LoginUnitCode;
            getDep();
        }
        #endregion
        private void btn附件查看_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt附件信息.Tag == null) this.txt附件信息.Tag = "";
                form.Editor_See(this.txt附件信息.Tag.ToString());
                form.ShowDialog();
            }
        }
        private void btn车辆类型_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(5);
            AppServer.Frm车辆类型.SetShowParam(this.txt车辆类型编码, 0);
            AppServer.Frm车辆类型.ShowDialog();
            if (AppServer.Frm车辆类型.DialogResult == DialogResult.OK)
            {
                this.txt车辆类型编码.Tag = AppServer.Frm车辆类型.SelectNodeID;
                this.txt车辆类型编码.Text = AppServer.Frm车辆类型.SelectNodeTitle;
            }
        }

        private void btn资产类别_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(4);
            AppServer.Frm资产类别.SetShowParam(this.txt资产类别编码, 0);
            AppServer.Frm资产类别.ShowDialog();
            if (AppServer.Frm资产类别.DialogResult == DialogResult.OK)
            {
                this.txt资产类别编码.Tag = AppServer.Frm资产类别.SelectNodeID;
                this.txt资产类别编码.Text = AppServer.Frm资产类别.SelectNodeTitle;
            }
        }

        private void btn选择单位_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(2);
            AppServer.Frm单位信息.Left = txt单位编码.PointToScreen(new Point(0, 0)).X ;
            AppServer.Frm单位信息.Top = txt单位编码.PointToScreen(new Point(0, 0)).Y - AppServer.Frm单位信息.Height;
            AppServer.Frm单位信息.Width = txt单位编码.Width;
            
            AppServer.Frm单位信息.ShowDialog();
            if (AppServer.Frm单位信息.DialogResult == DialogResult.OK)
            {
                this.txt单位编码.Tag = AppServer.Frm单位信息.SelectNodeID;
                this.txt单位编码.Text = AppServer.Frm单位信息.SelectNodeTitle;
            }
            //
            this.getDep();
        }
       

        private void btn提交_Click(object sender, EventArgs e)
        {
            #region 验证
            if (this.txt资产名称.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("资产名称不能为空！", "提示");
                this.txt资产名称.Focus();
                return;
            }
             if (this.txt资产名称.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("资产名称不能为空！", "提示");
                this.txt资产名称.Focus();
                return;
            }
            if (this.txt车辆类型编码.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("车辆类型不能为空！", "提示");
                this.txt车辆类型编码.Focus();
                return;
            }
            if (this.txt资产类别编码.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("资产类别不能为空！", "提示");
                this.txt资产类别编码.Focus();
                return;
            }
            if (this.txt车架号.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("车架号不能为空！", "提示");
                this.txt车架号.Focus();
                return;
            }
            if (this.txt发动机号.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("发动机号不能为空！", "提示");
                this.txt发动机号.Focus();
                return;
            }
            if (this.txt车牌号.Text.Trim().ToString() == ""||this.txt车牌号.Text.Trim().Length<7)
            {
                AppServer.ShowMsg("车牌号输入不正确！", "提示");
                this.txt车牌号.Focus();
                return;
            }
            if (this.nud价值.Value == 0)
            {
                AppServer.ShowMsg("价值不能为0！", "提示");
                this.nud价值.Focus();
                return;
            }         
            if (this.nud账面净值.Value == 0)
            {
                AppServer.ShowMsg("账面净值不能为0！", "提示");
                this.nud账面净值.Focus();
                return;
            }
            if (this.txt单位编码.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("使用单位不能为空！", "提示");
                this.txt单位编码.Focus();
                return;
            }
          #endregion

            #region 提交数据
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.ExAction = this.Tag.ToString();
                model.LoginUserCode = AppServer.LoginUserCode;
                model.入库单编码 = this.btn提交.Tag.ToString();
                model.保修截止日期 = this.dtp保修截止日期.Value;
                model.取得日期 = this.dtp取得日期.Value;
                model.使用日期 = this.dtp使用日期.Value;
                model.单位编码 = this.txt单位编码.Tag.ToString();
                model.出库单编码 = Code;
                model.配置申请编号 = this.txt配置申请编号.Text.ToString();
                model.申请序号 = AppServer.SQXH;
                model.排气量 = cbx排气量.Text.Trim();
                model.使用年限 = Convert.ToInt32(this.nud使用年限.Value);
                if (!(cbx使用部门.SelectedValue == null))
                {
                    model.处室编码 = cbx使用部门.SelectedValue.ToString();
                }
                else
                {
                    model.处室编码 = null;
                }
                model.车辆类型编码 = this.txt车辆类型编码.Tag.ToString();
                model.资产类别编码 = this.txt资产类别编码.Tag.ToString();
                if (this.txt附件信息.Tag != null) model.附件编码 = this.txt附件信息.Tag.ToString();
                if(BM!=null) model.资产编号 = BM;
                AppServer.wcfClient.OCC_公车入库_Edit(ref model);
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

        private void btn购置审批_Click(object sender, EventArgs e)
        {
            using (var form = new OCC_配置申请_Select())
            {
                form.Select_DB();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.txt配置申请编号.Text = AppServer.RequestCode.ToString();
                    this.txt车辆类型编码.Text = AppServer.VName.ToString();
                    this.txt车辆类型编码.Tag = AppServer.VType.ToString();
                    this.txt资产类别编码.Tag = AppServer.PType.ToString();
                    this.txt资产类别编码.Text = AppServer.PName.ToString();
                    this.cbx排气量.Text = AppServer.Emission;               
                }
            }

        }
        private void nud价值_ValueChanged(object sender, EventArgs e)
        {
            if (N==1) return;
            this.nud账面净值.Value = this.nud价值.Value - this.nud累计折旧.Value;
        }

        private void nud累计折旧_ValueChanged(object sender, EventArgs e)
        {
            if (N==1) return;
            
            if (nud累计折旧.Value > nud价值.Value)
            {
                AppServer.ShowMsg("累计折旧不能为超过价值！", "提示");
                this.nud累计折旧.Focus();
                this.nud累计折旧.Value = 0;
                return;
            }
            this.nud账面净值.Value = this.nud价值.Value - this.nud累计折旧.Value;
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

      
        private void cbx折旧状态_TextChanged(object sender, EventArgs e)
        {
            if (this.cbx折旧状态.Text == "不提折旧") this.nud累计折旧.Enabled = false;
            else  this.nud累计折旧.Enabled = true;
        }  
    }
}
