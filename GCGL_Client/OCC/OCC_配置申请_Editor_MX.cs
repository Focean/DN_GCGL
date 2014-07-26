using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using System.IO;
using GCGL_Client.FZB;
using GCGL_Client.NET;

namespace GCGL_Client.OCC
{
    public partial class OCC_配置申请_Editor_MX : Form
    {
        DataTable dt1 = null;//车辆品牌
        DataTable dt2 = null;//排气量
        DataTable dt3 = null;//座位数
        DataTable dt4 = null;//资产类别
        DataTable dt5 = null;//存放当前的车辆配置标准
        bool Flat = true;//作为执行PZ_Control的标识
        public OCC_配置申请_Editor_MX()
        {
            InitializeComponent();
            try
            {
                if (!AppServer.WcfService_Open()) return;

                dt1 = AppServer.wcfClient.FZB_编码_List("车辆品牌", AppServer.LoginAreaCode).Tables[0];
                if (dt1.Rows.Count > 0)
                {
                    for(int i=0;i<dt1.Rows.Count;i++)
                    {
                        this.cbx车辆品牌.Items.Add(dt1.Rows[i][2].ToString());
                    }
                }
                //
                dt2 = AppServer.wcfClient.FZB_编码_List("排气量", AppServer.LoginAreaCode).Tables[0];
                if (dt2.Rows.Count > 0)
                {
                    this.cbx排气量.DataSource = dt2;
                    this.cbx排气量.DisplayMember = "名称";
                    this.cbx排气量.ValueMember = "编码";
                    dt排气量 = dt2.Copy();
                }
                dt3 = AppServer.wcfClient.FZB_编码_List("座位数", AppServer.LoginAreaCode).Tables[0];
                if (dt3.Rows.Count > 0)
                {
                    for (int i = 0; i < dt3.Rows.Count; i++)
                    {
                        this.cbx座位数.Items.Add(dt3.Rows[i][2].ToString());
                    }
                }
                //需要放在dt4之前获取，PZ_Control中需要
                dt5 = AppServer.wcfClient.FZB_编码_List("配置标准", AppServer.LoginAreaCode).Tables[0];
                //
                dt4 = AppServer.wcfClient.FZB_编码_List("车辆类型", AppServer.LoginAreaCode).Tables[0];
                if (dt4.Rows.Count > 0)
                {
                    this.Flat = false;
                    this.cbx车辆类型名称.DataSource = dt4;
                    this.cbx车辆类型名称.DisplayMember = "车辆类型名称";
                    this.cbx车辆类型名称.ValueMember = "车辆类型编码";                  
                    dt资产名称 = dt4.Copy();
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
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 10, this.btn确定, true);
        }
        //
        private DataRow FDataRow;
        private int Num1;
        private int Num2;
        private DataTable dt资产名称;
        private DataTable dt排气量;
        public void Editor_Add(DataRow row, int 执法CarNum,int 公务CarNum)
        {
            this.Text = "车辆配置明细(添加)";
            this.Tag = "Add";
            //
            if (AppServer.LoginUnitType == 1)//单位为预算单位
            {
                this.txt预算单位名称.Text = AppServer.LoginUnitName;
                this.txt预算单位名称.Tag = AppServer.LoginUnitCode;
                this.btn预算单位.Visible = false;
                this.txt预算单位名称.ReadOnly = true;
            }
            FDataRow = row;
            Num1 = 执法CarNum;
            Num2 = 公务CarNum;
        }

        public void Editor_Mod(DataRow row, int 执法CarNum, int 公务CarNum,bool Avisile)
        {
            this.Text = "车辆配置明细(修改)";
            this.Tag = "Mod";
            this.Flat = false;
            FDataRow = row;
            Num1 = 执法CarNum;
            Num2 = 公务CarNum;
            if (AppServer.LoginUnitType == 1)
            {
                btn预算单位.Visible = false;
            }        
            txt预算单位名称.Tag = row["预算单位编码"].ToString();             
            txt资产类别名称.Tag = row["资产类别编码"].ToString();                
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
            this.cbx车辆类型名称.SelectedValue = row["车辆类型编码"].ToString();   
            cbx车辆品牌.Text = row["车辆品牌"].ToString();          
            cbx排气量.Text = row["排气量"].ToString();
            this.cbx座位数.Text = row["座位数"].ToString();
            this.btn附件管理.Visible = Avisile;
            this.btn确定.Enabled = Avisile;
            this.btn预算单位.Visible = Avisile;
            this.btn资产类别.Visible = Avisile;
            this.cbx车辆类型名称.Enabled = Avisile;
            this.cbx车辆品牌.Enabled = Avisile;
            this.cbx经费来源性质.Enabled = Avisile;
            this.cbx排气量.Enabled = Avisile;
            this.cbx座位数.Enabled = Avisile;
            this.txt备注.Enabled = Avisile;
            this.txt经费来源.Enabled = Avisile;
            this.txt型号.Enabled = Avisile;
            this.nud价格.Enabled = Avisile;
            this.nud数量.Enabled = Avisile;
        }
        
        private void btn确定_Click(object sender, EventArgs e)
        {
            #region 控件验证
            if (this.txt预算单位名称.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("预算单位名称不能为空！", "提示");
                this.txt预算单位名称.Focus();
                return;
            }
            if (this.txt资产类别名称.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("资产类别不能为空！", "提示");
                this.txt资产类别名称.Focus();
                return;
            }
            //if (AppServer.LoginUnitType == 1)
            //{
            //    int Num3 = 0;
            //    if (this.txt资产类别名称.Tag.ToString() == "0301")
            //      Num3 = Num1 - this.nud数量.Value.ToIntegerDef();
            //    else
            //        if (this.txt资产类别名称.Tag.ToString() != "0302")
            //            Num3 = Num2 - this.nud数量.Value.ToIntegerDef();
            //    if (Num3 < 0)
            //    {
            //        AppServer.ShowMsg(this.txt资产类别名称.Text+"数量不能超编！", "提示");
            //        this.nud数量.Focus();
            //        return;
            //    }
            //}
            if (this.cbx车辆品牌.Text == "" || this.cbx排气量.Text == "" || this.cbx座位数.Text == ""||this.txt型号.Text.Trim()=="")
            {
                AppServer.ShowMsg("请将车辆信息填写完整！", "提示");   
                return;
            }
            if (this.nud价格.Value == 0)
            {
                AppServer.ShowMsg("价格不能为0！", "提示");
                this.nud价格.Focus();
                return;
            }
            //
            if (this.cbx车辆类型名称.SelectedValue.ToString() == "")
            {
                AppServer.ShowMsg("车辆类型不能为空！", "提示");
                this.cbx车辆类型名称.Focus();
                return;
            }
          
            if (this.cbx经费来源性质.Text==""||this.txt经费来源.Text.Trim() == "")
            {
                AppServer.ShowMsg("请完善经费来源信息！", "提示");
                this.txt经费来源.Focus();
                return;
            }
            #endregion

            //开始赋值给Datarow   
            if (FDataRow == null) return;
            TY.Helper.FormHelper.DataBinding_FormToDataRow(this, FDataRow);
            FDataRow["预算单位编码"] = txt预算单位名称.Tag.ToString();
            FDataRow["车辆类型编码"] = this.cbx车辆类型名称.SelectedValue.ToString();
            FDataRow["车辆类型名称"] = this.cbx车辆类型名称.Text.ToString();
            FDataRow["资产类别编码"] = txt资产类别名称.Tag.ToString();
            FDataRow["车辆品牌"] = this.cbx车辆品牌.Text;
            FDataRow["排气量"] = this.cbx排气量.Text;
            FDataRow["座位数"] = this.cbx座位数.Text;
            FDataRow["经费来源性质"] = this.cbx经费来源性质.Text;
            if (this.txt附件信息.Tag != null) FDataRow["依据文件编码"] = this.txt附件信息.Tag.ToString();
            if (this.txt附件信息.Tag != null) FDataRow["附件摘要"] = this.txt附件信息.Text;
            this.DialogResult = DialogResult.OK;         
        }

        #region 控件数据选择
        private void btn预算单位_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(2);
            AppServer.Frm单位信息.SetShowParam(this.txt预算单位名称,0);           
            AppServer.Frm单位信息.ShowDialog();
            if (AppServer.Frm单位信息.DialogResult == DialogResult.OK)
            {
                this.txt预算单位名称.Tag = AppServer.Frm单位信息.SelectNodeID;
                this.txt预算单位名称.Text = AppServer.Frm单位信息.SelectNodeTitle;
            }

        }
        #endregion

        private void txt车辆类型名称_TextChanged(object sender, EventArgs e)
        {
            this.PZ_Control();           
        }

        private void cbx资产类别名称_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PZ_Control();
            this.Flat = true;
        }

        //配置时控制方法的定义
        private void PZ_Control()
        {
            object[] objs=null;
            if (!this.Flat) return;
            DataColumn[] cols = new DataColumn[] { dt5.Columns["车辆类型编码"], dt5.Columns["资产类别编码"] };
            dt5.PrimaryKey = cols;
            if (this.txt资产类别名称.Tag != null && this.cbx车辆类型名称.SelectedValue != null)
                objs = new Object[] { this.txt资产类别名称.Tag.ToString(), this.cbx车辆类型名称.SelectedValue.ToString() };
            else
                return;
            DataRow dr = dt5.Rows.Find(objs);
            if (dr != null)
            {
                //根据配置标准中的内容控制---排气量
                DataTable dtUse = dt排气量.Copy();
                for (int i = 0; i < dtUse.Rows.Count; i++)
                {
                    double k = Convert.ToDouble(dr["排量"].ToString());
                    if (Convert.ToDouble(dtUse.Rows[i]["名称"].ToString().Substring(0, 3)) > Convert.ToDouble(dr["排量"].ToString()) )
                    {
                        dtUse.Rows.RemoveAt(i);
                        i = 0;
                    }
                }
                this.cbx排气量.DataSource = dtUse;

                //根据配置标准中的内容控制---价格
                this.nud价格.Maximum = Convert.ToDecimal(dr["价格"].ToString());
            }
            else
            {
               // AppServer.ShowMsg("配置标准中不存在当前的<" + this.txt资产类别名称.Text + ">与<" + this.cbx车辆类型名称.Text.ToString() + ">的配置标准，所以价格和排量将不限制！");
                this.cbx排气量.DataSource = dt2;
                this.nud价格.Maximum = 9999;
            }
        
        }
        
        //快捷键设置
        private void OCC_配置申请_Editor_MX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && e.Modifiers == Keys.Control)         //Ctrl+D
            {
                this.btn确定_Click(this, EventArgs.Empty);
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

        private void btn资产类别_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(5);
            AppServer.Frm资产类别.SetShowParam(this.txt资产类别名称, 0);
            AppServer.Frm资产类别.ShowDialog();
            if (AppServer.Frm资产类别.DialogResult == DialogResult.OK)
            {
                this.txt资产类别名称.Tag = AppServer.Frm资产类别.SelectNodeID;
                this.txt资产类别名称.Text = AppServer.Frm资产类别.SelectNodeTitle;
            }
        }   
    }
}
