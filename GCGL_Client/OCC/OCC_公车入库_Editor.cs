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
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 30, this.btn保存, true);

            try
            {
                if (!AppServer.WcfService_Open()) return;
                this.cbx采购形式编码.DataSource = AppServer.wcfClient.FZB_编码_List("采购形式1", AppServer.LoginAreaCode).Tables[0];
                this.cbx采购形式编码.DisplayMember = "名称";
                this.cbx采购形式编码.ValueMember = "编码";
                //
                this.cbx排气量.DataSource = AppServer.wcfClient.FZB_编码_List("排气量", AppServer.LoginAreaCode).Tables[0];
                this.cbx排气量.DisplayMember = "名称";
                this.cbx排气量.ValueMember = "名称";
                //
                this.cbx车辆类型编码.DataSource = AppServer.wcfClient.FZB_编码_List("车辆类型", AppServer.LoginAreaCode).Tables[0];
                this.cbx车辆类型编码.DisplayMember = "车辆类型名称";
                this.cbx车辆类型编码.ValueMember = "车辆类型编码";

                DataTable dt3 = null;
                dt3 = AppServer.wcfClient.FZB_编码_List("座位数", AppServer.LoginAreaCode).Tables[0];
                if (dt3.Rows.Count > 0)
                {
                    for (int i = 0; i < dt3.Rows.Count; i++)
                    {
                        this.cbx座位数.Items.Add(dt3.Rows[i][2].ToString());
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

            //
            if (AppServer.LoginUnitIsYSDW())
            {
                this.btn资产类别.Enabled = false;
                this.cbx车辆类型编码.Enabled = false;
            }
            if (AppServer.LoginUnitIsGWC())
            {
                this.txt配置申请编号.Enabled = false;
            }
        }
        private decimal JG = 0;//价格
        int N = 0;//在界面一建立的时候价值、账面净值等控件由于值改变而执行，会出现错误，所以加了一个标志，如果为N==1，则不执行
        private int XH;//接收配置申请序号
        private string BM = null;//接收资产编号
        private string Code = null;//出库单编码接收变量
        private string oType = null;//修改的类型，分配置、入库，如果为入库则显示车牌号的输入区域

        #region 增、改、查看、接收
       
        public void Editor_Add(DataRow row)
        {
            this.Text = "车辆入库(新增)";
            this.Tag = "Add_GZ";
            //
            this.cbx折旧状态.SelectedIndex = 0;
            this.cbx价值类型.SelectedIndex = 0;
            this.btn保存.Tag = "";

            this.getDW();
            this.getDep();
            //
            this.pnl信息.Height = 640;
            this.pnl入户.Height=0;
            this.pnl入户.Visible = false;
            this.Height=633;
            //
            if (AppServer.LoginUnitIsYSDW() || AppServer.LoginUnitIsGWC())
            {
                this.cbx单位编码.Text = AppServer.LoginUnitName;
                this.cbx单位编码.SelectedValue = AppServer.LoginUnitCode;
            }
            if ((row != null) && (!AppServer.LoginUnitIsGWC()))
            {
                this.txt配置申请编号.Text = row["申请编号"].ToString();
                XH = Convert.ToInt32(row["申请序号"].ToString());
                this.txt资产类别编码.Text = row["资产类别名称"].ToString();
                this.txt资产类别编码.Tag = row["资产类别编码"].ToString();
                this.cbx车辆类型编码.SelectedValue = row["车辆类型编码"].ToString();
                this.cbx车辆类型编码.Text = row["车辆类型名称"].ToString();
                this.cbx排气量.Text = row["排气量"].ToString();
                this.txt厂牌型号.Text = row["车辆品牌"].ToString();
                this.txt规格型号.Text = row["型号"].ToString();
                this.nud价值.Value = Convert.ToDecimal(row["价格"].ToString()) * 10000;
                this.cbx座位数.Text = row["座位数"].ToString();
                if(row["申请编号"].ToString()=="")
                this.cbx编制情况.Text=row["编制情况"].ToString();
                //
                JG = Convert.ToDecimal(row["价格"].ToString()) * 10000;
                this.txt规格型号.ReadOnly = true;
                this.txt厂牌型号.ReadOnly = true;
                this.cbx座位数.Enabled = false;
                this.cbx排气量.Enabled = false;
            }
        }
        public void Editor_Mod(String Code, string RKCode,string ModType)
        {
            this.Text = "车辆入库(修改)";
            this.Tag = "Mod_GZ";
            oType = ModType;

            this.getDW();
            this.getDep();


            if (ModType == "入户" )
            {
                #region   数据显示的形式

                this.txt资产名称.BackColor = SystemColors.Control;
                this.txt资产类别编码.BackColor = SystemColors.Control;
                this.txt规格型号.BackColor = SystemColors.Control;
                this.txt规格型号.ReadOnly = true;
                this.txt厂牌型号.BackColor = SystemColors.Control;
                this.txt厂牌型号.ReadOnly = true;
                this.txt车辆产地.BackColor = SystemColors.Control;
                this.txt车辆产地.ReadOnly = true;
                this.txt颜色.BackColor = SystemColors.Control;
                this.txt颜色.ReadOnly = true;
                this.txt车架号.BackColor = SystemColors.Control;
                this.txt车架号.ReadOnly = true;
                this.txt发动机号.BackColor = SystemColors.Control;
                this.txt发动机号.ReadOnly = true;
                this.txt会计凭证号.BackColor = SystemColors.Control;
                this.txt会计凭证号.ReadOnly = true;
                this.txt票据附件.BackColor = SystemColors.Control;
                this.txt行驶证附件.BackColor = SystemColors.Control;
                this.txt备案信息附件.BackColor = SystemColors.Control;

                this.cbx计量单位.BackColor = SystemColors.Control;
                this.cbx计量单位.Enabled = false;
                this.cbx采购形式编码.Enabled = false;
                this.cbx取得方式.Enabled = false;
                this.cbx排气量.Enabled = false;
                this.cbx座位数.Enabled = false;
                this.cbx价值类型.Enabled = false;
                this.cbx使用部门.Enabled = false;
                this.cbx单位编码.Enabled = false;
                this.cbx折旧状态.Enabled = false;
                this.cbx编制情况.Enabled = false;

                this.nud使用年限.BackColor = SystemColors.Control;
                this.nud使用年限.Enabled = false;
                this.nud价值.BackColor = SystemColors.Control;
                this.nud价值.Enabled = false;
                this.nud累计折旧.BackColor = SystemColors.Control;
                this.nud累计折旧.Enabled = false;
                this.nud账面净值.BackColor = SystemColors.Control;
                this.nud账面净值.Enabled = false;

                this.dtp保修截止日期.Enabled = false;
                this.dtp取得日期.Enabled = true;
                this.dtp使用日期.Enabled = false;

                this.btn资产类别.Visible = false;
                this.btn备案信息附件.Visible = false;
                this.btn附件管理.Visible = false;
                #endregion
              
                this.pnl信息.Height = 650;
                this.pnl入户.Height = 100;
                this.pnl入户.Visible = true;
                this.Height = 746;
            }
            else if (ModType == "购置")
            {
                this.pnl信息.Height = 640;
                this.pnl入户.Height = 0;
                this.pnl入户.Visible = false; 
                this.Height = 694;
            }
            else if (ModType == "导入")
            {
                this.pnl信息.Height = 650;
                this.pnl入户.Height = 100;
                this.pnl入户.Visible = true;
                this.pnl入户.BackColor = SystemColors.Control;
                this.Height = 746;
            }
            //
            N = 1;
            BM = Code;
            this.btn保存.Tag = RKCode;
           
            this.Lbl配置审批编号.Enabled = false;
            this.txt配置申请编号.Enabled = false;
            
           
            DataBinding_GridView(RKCode);
            N = 0;

            if (this.txt配置申请编号.Text.Trim() != "")
            {
                this.cbx编制情况.Enabled = false;
                this.btn资产类别.Enabled = false;
                this.cbx车辆类型编码.Enabled = false;
                this.txt厂牌型号.ReadOnly = true;
                this.txt规格型号.ReadOnly = true;
                this.cbx座位数.Enabled = false;
                this.cbx排气量.Enabled = false;
                this.nud价值.Enabled = false;
                this.nud账面净值.Enabled = false;
            }
            else
            {
                this.cbx编制情况.Enabled = true;
                this.btn资产类别.Enabled = true;
                this.cbx车辆类型编码.Enabled = true;
                this.txt厂牌型号.Enabled = true;
                this.txt规格型号.Enabled = true;
                this.cbx座位数.Enabled = true;
                this.cbx排气量.Enabled = true;
                this.nud价值.Enabled = true;
                this.nud账面净值.Enabled = true;
            }
            #region //如果是公物仓
            if (AppServer.LoginUnitIsGWC())
            {
                this.cbx编制情况.Enabled = false;
                this.cbx计量单位.Enabled = false;
                this.cbx单位编码.Enabled = false;
                this.cbx价值类型.Enabled = false;
                this.cbx使用部门.Enabled = false;             
                this.txt会计凭证号.ReadOnly = true;
                this.cbx取得方式.Enabled = false;
                this.cbx采购形式编码.Enabled = false;
                this.btn资产类别.Enabled = false;
                this.cbx车辆类型编码.Enabled = false;
                this.cbx计量单位.Enabled = false;
                this.cbx价值类型.Enabled = false;
                this.cbx折旧状态.Enabled = false;
                this.dtp保修截止日期.Enabled = false;
                this.dtp取得日期.Enabled = false;
                this.dtp使用日期.Enabled = false;

                this.txt车牌号.ReadOnly = true;
                this.btn附件管理.Enabled = false;
                this.btn备案信息附件.Enabled = false;
                
                this.btn行驶证附件.Enabled = false;
            }
            #endregion

        }

        public void Editor_See(String Code,string ModType,bool AEmebMode = false)
        {
            this.Text = "车辆入库(查看)";
            this.Tag = "See";
            //
            oType = ModType;
           if (ModType == "入户")
            {
                this.pnl信息.Height = 640;
                this.pnl入户.Height = 100;
                this.pnl入户.Visible = true;
                this.Height = 746;
            }
           else if (ModType == "购置")
           {
               this.pnl信息.Height = 640;
               this.pnl入户.Height = 0;
               this.pnl入户.Visible = false;
               this.Height = 694;
           }
           else if (ModType == "导入")
           {
               this.pnl信息.Height = 650;
               this.pnl入户.Height = 100;
               this.pnl入户.Visible = true;
               this.pnl入户.BackColor = SystemColors.Control;
               this.Height = 746;
           }
            N = 1;//不触发ValueChanged
            this.DataBinding_GridView(Code);
           
            this.btn保存.Enabled = false;

            this.btn附件管理.Enabled = false;
            this.btn备案信息附件.Enabled = false;
           
            this.btn行驶证附件.Enabled = false;
            //
            #region   数据显示的形式
            this.txt资产名称.BackColor = SystemColors.Control;
            this.txt资产类别编码.BackColor = SystemColors.Control;
            this.btn资产类别.Visible = false;
            this.cbx车辆类型编码.BackColor = SystemColors.Control;
            this.cbx车辆类型编码.Enabled = false;
            this.cbx编制情况.BackColor = SystemColors.Control;
            this.cbx编制情况.Enabled = false;
            this.cbx计量单位.BackColor = SystemColors.Control;
            this.cbx计量单位.Enabled = false;
            this.txt规格型号.BackColor = SystemColors.Control;
            this.txt规格型号.Enabled = false;
            this.txt厂牌型号.BackColor = SystemColors.Control;
            this.txt厂牌型号.Enabled = false;
            this.cbx采购形式编码.Enabled = false;
            this.cbx取得方式.Enabled = false;
            this.dtp取得日期.Enabled = false;
            this.txt车辆产地.BackColor = SystemColors.Control;
            this.txt车辆产地.Enabled = false;
            this.nud使用年限.BackColor = SystemColors.Control;
            this.nud使用年限.Enabled = false;
            this.dtp保修截止日期.Enabled = false;
            this.txt颜色.BackColor = SystemColors.Control;
            this.txt颜色.Enabled = false;
            this.dtp使用日期.Enabled = false;
            this.cbx排气量.BackColor = SystemColors.Control;
            this.cbx排气量.Enabled = false;
            this.txt车架号.BackColor = SystemColors.Control;
            this.txt车架号.Enabled = false;
            this.txt发动机号.BackColor = SystemColors.Control;
            this.txt发动机号.Enabled = false;
            this.cbx座位数.BackColor = SystemColors.Control;
            this.cbx座位数.Enabled = false;
            this.cbx价值类型.Enabled = false;
            this.nud价值.BackColor = SystemColors.Control;
            this.nud价值.Enabled = false;
            this.txt会计凭证号.BackColor = SystemColors.Control;
            this.txt会计凭证号.Enabled = false;
            this.cbx折旧状态.Enabled = false;
            this.nud累计折旧.BackColor = SystemColors.Control;
            this.nud累计折旧.Enabled = false;
            this.nud账面净值.BackColor = SystemColors.Control;
            this.nud账面净值.Enabled = false;
            this.cbx使用部门.Enabled = false;
            this.cbx单位编码.BackColor = SystemColors.Control;
            this.cbx单位编码.Enabled = false;
            this.txt票据附件.BackColor = SystemColors.Control;
            this.txt行驶证附件.BackColor = SystemColors.Control;
            this.txt备案信息附件.BackColor = SystemColors.Control;
            this.txt车牌号.BackColor = SystemColors.Control;
            this.txt车牌号.Enabled = false;
            this.pnl入户.BackColor = SystemColors.Control;
            this.txt备注.Enabled = false;
            this.txt备注.BackColor = SystemColors.Control; 

            this.btn提交.Enabled = false;
            this.btn取消.Text = "返回";
            #endregion


            N = 0;
            //嵌入式状态不显示工具栏
            if (AEmebMode == true)
            {
                this.pnlTool.Visible = !AEmebMode;
                this.Height = 694;
                lbl线.Visible = !AEmebMode;
            }
        }

        public void Editor_Accept(DataRow row, string CKCode, int operation)
        {
            //operation 为1表示调拨入库修改  2表示增加调拨入库
            this.Text = "车辆入库(接收)";
            if (operation == 2) this.Tag = "Add_DB";
            else this.Tag = "Mod_DB";
            //         
            BM = row["资产编号"].ToString();
            this.btn保存.Tag = "";
            this.txt配置申请编号.Enabled = false;

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
            this.txt备注.Text=row["备注"].ToString();
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

            #region  如果是公物仓
            if (AppServer.LoginUnitIsGWC())
            {
                this.btn保存.Tag = CKCode;
                this.cbx计量单位.Enabled = false;
                this.cbx单位编码.Enabled = false;
                this.cbx价值类型.Enabled = false;
                this.cbx使用部门.Enabled = false;
                this.txt会计凭证号.ReadOnly = true;
                this.cbx取得方式.Enabled = false;
                this.cbx采购形式编码.Enabled = false;
                this.btn资产类别.Enabled = false;
                this.cbx车辆类型编码.Enabled = false;
                this.cbx计量单位.Enabled = false;
                this.cbx价值类型.Enabled = false;
                this.cbx折旧状态.Enabled = false;
                this.dtp保修截止日期.Enabled = false;
                this.dtp取得日期.Enabled = false;
                this.dtp使用日期.Enabled = false;
                this.nud账面净值.Enabled = false;
                this.cbx排气量.Enabled = false;
                this.cbx座位数.Enabled = false;
                this.txt车牌号.ReadOnly = true;
                this.btn附件管理.Enabled = false;
                this.btn备案信息附件.Enabled = false;
               
                this.btn行驶证附件.Enabled = false;
            }
            #endregion

            this.txt车牌号.BackColor = Color.Yellow;
            this.cbx取得方式.Text = "调拨";
            this.cbx取得方式.BackColor = Color.Yellow;
            this.txt资产类别编码.Text = dr["资产类别名称"].ToString();
            this.txt资产类别编码.Tag = dr["资产类别编码"].ToString();
            this.cbx车辆类型编码.Text = dr["车辆类型名称"].ToString();
            this.cbx车辆类型编码.SelectedValue = dr["车辆类型编码"].ToString();
            this.nud价值.Value = Convert.ToDecimal(dr["价值"].ToString()) * 10000;
            this.nud账面净值.Value = Convert.ToDecimal(dr["账面净值"].ToString()) * 10000;
            this.cbx排气量.Text = dr["排气量"].ToString();
            this.cbx座位数.Text=dr["座位数"].ToString();
            this.cbx单位编码.Text = AppServer.LoginUnitName;
            this.cbx单位编码.SelectedValue = AppServer.LoginUnitCode;
            this.txt票据附件.Text=dr["购车票据"].ToString();
            this.txt票据附件.Tag = dr["购车票据附件"].ToString();
            this.getDep();
          
        }
        #endregion

        #region 根据入库编码获取车辆信息
        private void DataBinding_GridView(String Code)
        {
            this.btn保存.Tag = Code;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                model.入库单编码 = Code;
                DataSet db = AppServer.wcfClient.OCC_公车入库_List(ref model);
                DataTable table = db.Tables[0];
                TY.Helper.FormHelper.DataBinding_DataSourceToUI(db.Tables[0], this);
                this.cbx单位编码.Text = table.Rows[0]["单位名称"].ToString();
                this.cbx单位编码.SelectedValue = table.Rows[0]["单位编码"].ToString();

                this.cbx使用部门.Text = table.Rows[0]["处室名称"].ToString();
                this.cbx使用部门.SelectedValue = table.Rows[0]["处室编码"].ToString();

                this.nud价值.Value = Convert.ToDecimal(table.Rows[0]["价值"].ToString()) * 10000;
                this.nud账面净值.Value = Convert.ToDecimal(table.Rows[0]["账面净值"].ToString()) * 10000;
                this.nud累计折旧.Value = Convert.ToDecimal(table.Rows[0]["累计折旧"].ToString());

                this.txt资产类别编码.Text = table.Rows[0]["资产类别名称"].ToString();
                this.txt资产类别编码.Tag = table.Rows[0]["资产类别编码"].ToString();

                this.cbx车辆类型编码.Text = table.Rows[0]["车辆类型名称"].ToString();
                this.cbx车辆类型编码.SelectedValue = table.Rows[0]["车辆类型编码"].ToString();

                this.txt票据附件.Text = table.Rows[0]["购车票据"].ToString();
                this.txt票据附件.Tag = db.Tables[0].Rows[0]["购车票据附件"].ToString();

                this.txt备案信息附件.Text = table.Rows[0]["备案信息"].ToString();
                this.txt备案信息附件.Tag = db.Tables[0].Rows[0]["备案信息附件"].ToString();

                this.txt行驶证附件.Text = table.Rows[0]["行驶证"].ToString();
                this.txt行驶证附件.Tag = db.Tables[0].Rows[0]["行驶证附件"].ToString();
                





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
        //获取单位
        #region 获取单位信息
        private void getDW()
        {
          
            if (AppServer.LoginUnitIsCZT()) return;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_单位();
                model.ExAction = "GetSubList";
                model.单位编码 = AppServer.LoginUnitCode;
                DataTable dt = null;
                DataSet ds = AppServer.wcfClient.CMN_单位_List(ref model);
                dt = ds.Tables[0];
                this.cbx单位编码.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.cbx单位编码.AutoCompleteSource = AutoCompleteSource.ListItems;
                this.cbx单位编码.DataSource = dt;
                this.cbx单位编码.DisplayMember = "单位名称";
                this.cbx单位编码.ValueMember = "单位编码";
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
        //获取处室
        public void getDep()
        {
            if (this.cbx单位编码.SelectedValue == null) return;
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_单位_处室();
                model.ExAction = "QList";
                model.单位编码 = this.cbx单位编码.SelectedValue.ToString();
                DataTable table = AppServer.wcfClient.CMN_单位_处室_List(ref model).Tables[0];
                this.cbx使用部门.DataSource = table;
                this.cbx使用部门.DisplayMember = "处室名称";
                this.cbx使用部门.ValueMember = "处室编码";
                this.cbx使用部门.SelectedIndex = -1;
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

        private void btn附件查看_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt票据附件.Tag == null) this.txt票据附件.Tag = "";
                form.Editor_See(this.txt票据附件.Tag.ToString());
                form.ShowDialog();
            }
        }
      
        private void nud价值_ValueChanged(object sender, EventArgs e)
        {
            if (N==1) return;
            if (JG != 0)
            {
                if (this.nud价值.Value > JG)
                    this.nud价值.Value = JG;
            }
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
                if (this.txt票据附件.Tag == null) this.txt票据附件.Tag = "";
                form.Editor_Mod(this.txt票据附件.Tag.ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.txt票据附件.Tag = form.FileCode;
                    this.txt票据附件.Text = form.FileInfo;
                }
            }
        }

        private void cbx折旧状态_TextChanged(object sender, EventArgs e)
        {
            if (this.cbx折旧状态.Text == "不提折旧")
            {
                this.nud累计折旧.Value = 0;
                this.nud累计折旧.Enabled = false;
            }
            else this.nud累计折旧.Enabled = true;
        }

        private void cbx单位编码_SelectedValueChanged(object sender, EventArgs e)
        {
            this.getDep();
        }

        private void PostData(Boolean ASubmit)
        {
            #region 控件验证
            if (this.cbx编制情况.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("编制情况不能为空！", "提示");
                this.cbx编制情况.Focus();
                return;
            }
            if (this.txt资产名称.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("资产名称不能为空！", "提示");
                this.txt资产名称.Focus();
                return;
            }
            if (this.txt资产类别编码.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("资产类别不能为空！", "提示");
                this.txt资产类别编码.Focus();
                return;
            }
            if (this.cbx车辆类型编码.SelectedIndex <0)
            {
                AppServer.ShowMsg("车辆类型不能为空！", "提示");
                this.cbx车辆类型编码.Focus();
                return;
            }
            if (this.txt颜色.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("颜色不能为空！", "提示");
                this.txt颜色.Focus();
                return;
            }
            if (this.txt车架号.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("车架号不能为空！", "提示");
                this.txt车架号.Focus();
                return;
            }
            else 
            {
                if (this.txt车架号.Text.Trim().ToString().Length > 20)
                {
                    AppServer.ShowMsg("车架号不超过20位，请重新确认后输入！", "提示");
                    this.txt车架号.Focus();
                    return;
                }
            }
            if (this.txt发动机号.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("发动机号不能为空！", "提示");
                this.txt发动机号.Focus();
                return;
            }
            else
            {
                if (this.txt发动机号.Text.Trim().ToString().Length >25)
                {
                    AppServer.ShowMsg("发动机号不超过25位，请重新确认后输入！", "提示");
                    this.txt发动机号.Focus();
                    return;
                }
            }
            if (this.nud价值.Value == 0)
            {
                AppServer.ShowMsg("价值不能为0！", "提示");
                this.nud价值.Focus();
                return;
            }
            if (this.cbx座位数.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("座位数不能为空！", "提示");
                this.cbx座位数.Focus();
                return;
            }
            if (this.nud账面净值.Value == 0)
            {
                AppServer.ShowMsg("账面净值不能为0！", "提示");
                this.nud账面净值.Focus();
                return;
            }
            if (this.cbx单位编码.SelectedValue == null)
            {
                AppServer.ShowMsg("使用单位不能为空！", "提示");
                this.cbx单位编码.Focus();
                return;
            }
            if (this.txt会计凭证号.Text.Trim() == "")
            {
                AppServer.ShowMsg("购车发票号不能为空！","提示");
                this.txt会计凭证号.Focus();
                return;
            }
            if (this.txt票据附件.Text.Trim() == "")
            {
                AppServer.ShowMsg("购车票据附件不能为空！","提示");
                this.txt票据附件.Focus();
                return;
            }

            if (oType == "入户" || oType == "导入")
            {
                if (this.txt车牌号.Text.Trim().ToString() == "")
                {
                    AppServer.ShowMsg("车牌号不能为空！", "提示");
                    this.txt车牌号.Focus();
                    return;
                }
                else
                {
                    if (this.txt车牌号.Text.Trim().ToString().Substring(0, 1) != "豫")
                    {
                        AppServer.ShowMsg("车牌号开头为“豫”！", "提示");
                        this.txt车牌号.Focus();
                        return;
                    }
                    if (this.txt车牌号.Text.Trim().ToString().Length != 7)
                    {
                        AppServer.ShowMsg("车牌号不正确，请检查后再进行输入", "提示");
                        this.txt车牌号.Focus();
                        return;
                    }

                }
                if (this.txt行驶证附件.Text.Trim().ToString() == "")
                {
                    AppServer.ShowMsg("行驶证附件不能为空！", "提示");
                    this.txt行驶证附件.Focus();
                    return;
                }
            }
            if (oType != "导入")
            {
                if (this.txt备案信息附件.Text.Trim() == "")
                {
                    AppServer.ShowMsg("备案信息附件不能为空！", "提示");
                    this.txt备案信息附件.Focus();
                    return;
                }
            }
            #endregion

            #region 提交数据
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_OCC_公车入库();

                model.LoginUserCode = AppServer.LoginUserCode;
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.ExAction = this.Tag.ToString();
                model.出库单编码 = Code;
                model.配置申请编号 = this.txt配置申请编号.Text.ToString();
                model.申请序号 = XH;
                model.编制情况 = this.cbx编制情况.Text;
                model.入库单编码 = this.btn保存.Tag.ToString();
                model.资产类别编码 = this.txt资产类别编码.Tag.ToString();
                if (this.cbx车辆类型编码.SelectedValue != null)
                    model.车辆类型编码 = this.cbx车辆类型编码.SelectedValue.ToString();

                model.计量单位 = this.cbx计量单位.Text;
                if (this.cbx采购形式编码.SelectedValue != null)
                    model.采购形式编码 = this.cbx采购形式编码.SelectedValue.ToString();
                model.取得方式 = this.cbx取得方式.Text.ToString();
                model.取得日期 = this.dtp取得日期.Value;
                model.使用年限 = Convert.ToInt32(this.nud使用年限.Value);
                model.保修截止日期 = this.dtp保修截止日期.Value;
                model.使用日期 = this.dtp使用日期.Value;
                model.排气量 = cbx排气量.Text.Trim();
                model.座位数 = this.cbx座位数.Text.Trim();
                model.价值类型 = this.cbx价值类型.Text.ToString();
                model.价值 = this.nud价值.Value;
                model.账面净值 = this.nud账面净值.Value;
                model.折旧状态 = this.cbx折旧状态.Text.ToString();
                model.累计折旧 = this.nud累计折旧.Value;
                if (this.cbx单位编码.SelectedValue != null)
                    model.单位编码 = this.cbx单位编码.SelectedValue.ToString();
                if (!(cbx使用部门.SelectedValue == null))
                {
                    model.处室编码 = cbx使用部门.SelectedValue.ToString();
                }
                else
                {
                    model.处室编码 = null;
                }
                model.备注 = this.txt备注.Text;
                if (this.txt票据附件.Tag != null) model.购车票据附件 = this.txt票据附件.Tag.ToString();
                if (this.txt备案信息附件.Tag != null) model.备案信息附件 = this.txt备案信息附件.Tag.ToString();
            // 入户
                model.车牌号 = this.txt车牌号.Text;
                if (this.txt行驶证附件.Tag != null) model.行驶证附件 = this.txt行驶证附件.Tag.ToString();
                if (BM != null) model.资产编号 = BM;

                //开始保存
                AppServer.ShowWaitForm();
                AppServer.DataImport("正在保存数据，请稍等...", 20, 100, true);
                AppServer.wcfClient.OCC_公车入库_Edit(ref model);
                //
                if (model.ExResult != 0)
                {
                    AppServer.HideWaitForm();
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                //此时记住已保存成功了，如果是新增状态可变为修改状态了，防止提交不成功后重复新增数据
               
                if (this.Tag.ToString() == "Add_GZ" )
                {
                    this.Tag = "Mod_GZ";
                    this.btn保存.Tag = model.入库单编码;
                }
                if (this.Tag.ToString() == "Add_DB")
                {
                    this.Tag = "Mod_DB";
                    this.btn保存.Tag = model.入库单编码;
                }
                //
                if (ASubmit)
                {
                    model.ExAction = "Submit";
                    model.入库单编码 = this.btn保存.Tag.ToString();
                    if (BM != null) model.资产编号 = BM;
                    if (this.cbx单位编码.SelectedValue != null)
                        model.单位编码 = this.cbx单位编码.SelectedValue.ToString();
                    AppServer.wcfClient.OCC_公车入库_Edit(ref model);
                    if (model.ExResult != 0)
                    {
                        AppServer.HideWaitForm();
                        AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                        return;
                    }
                }
                AppServer.DataImport("数据保存已成功完成！", 100, 100, false);
                AppServer.HideWaitForm();
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

        private void btn保存_Click(object sender, EventArgs e)
        {
            this.PostData(false);       
        }

        private void btn提交_Click(object sender, EventArgs e)
        {
            this.PostData(true);
        }

        private void OCC_公车入库_Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)         //Ctrl+S
            {
                this.btn保存_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.J && e.Modifiers == Keys.Control)         //Ctrl+J
            {
                this.btn提交_Click(this, EventArgs.Empty);
            }
        }

        private void btn资产类别_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(5);
            AppServer.Frm资产类别.SetShowParam(this.txt资产类别编码, 0);
            AppServer.Frm资产类别.ShowDialog();
            if (AppServer.Frm资产类别.DialogResult == DialogResult.OK)
            {
                this.txt资产类别编码.Tag = AppServer.Frm资产类别.SelectNodeID;
                this.txt资产类别编码.Text = AppServer.Frm资产类别.SelectNodeTitle;
            }
        }

        private void btn备案信息附件_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt备案信息附件.Tag == null) this.txt备案信息附件.Tag = "";
                form.Editor_Mod(this.txt备案信息附件.Tag.ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.txt备案信息附件.Tag = form.FileCode;
                    this.txt备案信息附件.Text = form.FileInfo;
                }
            }
        }

        private void btn备案信息查看_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt备案信息附件.Tag == null) this.txt备案信息附件.Tag = "";
                form.Editor_See(this.txt备案信息附件.Tag.ToString());
                form.ShowDialog();
            }   
        }

        private void btn行驶证附件_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt行驶证附件.Tag == null) this.txt行驶证附件.Tag = "";
                form.Editor_Mod(this.txt行驶证附件.Tag.ToString());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.txt行驶证附件.Tag = form.FileCode;
                    this.txt行驶证附件.Text = form.FileInfo;
                }
            }
        }

        private void btn行驶证查看_Click(object sender, EventArgs e)
        {
            using (var form = new NET_附件管理())
            {
                if (this.txt行驶证附件.Tag == null) this.txt行驶证附件.Tag = "";
                form.Editor_See(this.txt行驶证附件.Tag.ToString());
                form.ShowDialog();
            }
        }

        private void txt车架号_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == 8)//退格键是8
                e.Handled = false;
            else e.Handled = true;
        }

        private void txt发动机号_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == 8)//退格键是8
                e.Handled = false;
            else e.Handled = true;
        }

    }
}
