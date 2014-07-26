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
using System.Data.SqlClient;

namespace GCGL_Client.OCC
{
    public partial class OCC_配置申请_Editor_MX : Form
    {
        public OCC_配置申请_Editor_MX()
        {
            InitializeComponent();
            try
            {
                if (!AppServer.WcfService_Open()) return;
                DataTable dt1 = null;
                DataTable dt2 = null;
                DataTable dt3 = null;
                dt1 = AppServer.wcfClient.FZB_编码_List("车辆品牌").Tables[0];
                if (dt1.Rows.Count > 0)
                {
                    for(int i=0;i<dt1.Rows.Count;i++)
                    {
                        this.cbx车辆品牌.Items.Add(dt1.Rows[i][2].ToString());
                    }
                } 
                //
                dt2 = AppServer.wcfClient.FZB_编码_List("排气量").Tables[0];
                if (dt2.Rows.Count > 0)
                {
                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        this.cbx排气量.Items.Add(dt2.Rows[i][2].ToString());
                    }
                } 
                //
                dt3 = AppServer.wcfClient.FZB_编码_List("座位数").Tables[0];
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
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 10, this.btn确定, true);
        }
        //
        private DataRow FDataRow;
        private int Num1;
        private int Num2;
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

        public void Editor_Mod(DataRow row, int 执法CarNum, int 公务CarNum)
        {
            this.Text = "车辆配置明细(修改)";
            this.Tag = "Mod";
            FDataRow = row;
            Num1 = 执法CarNum;
            Num2 = 公务CarNum;
            if (AppServer.LoginUnitType == 1)
            {
                btn预算单位.Visible = false;
            }        
            txt预算单位名称.Tag = row["预算单位编码"].ToString();             
            txt车辆类型名称.Tag = row["车辆类型编码"].ToString();
            txt资产类别名称.Tag = row["资产类别编码"].ToString();         
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
            cbx车辆品牌.Text = row["车辆品牌"].ToString();          
            cbx排气量.Text = row["排气量"].ToString();
            this.cbx座位数.Text = row["座位数"].ToString();
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
            if (AppServer.LoginUnitType == 1)
            {
                int Num3 = 0;
                if (this.txt车辆类型名称.Tag.ToString() == "0301")
                  Num3 = Num1 - this.nud数量.Value.ToIntegerDef();
                else
                    if (this.txt车辆类型名称.Tag.ToString() != "0302")
                        Num3 = Num2 - this.nud数量.Value.ToIntegerDef();
                if (Num3 < 0)
                {
                    AppServer.ShowMsg(this.txt车辆类型名称.Text+"数量不能超编！", "提示");
                    this.nud数量.Focus();
                    return;
                }
            }
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
            if (this.txt资产类别名称.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("资产类别不能为空！", "提示");
                this.txt资产类别名称.Focus();
                return;
            }
            if (this.txt车辆类型名称.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("车辆类型不能为空！", "提示");
                this.txt车辆类型名称.Focus();
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
            FDataRow["资产类别编码"] = txt资产类别名称.Tag.ToString();
            FDataRow["车辆类型编码"] = txt车辆类型名称.Tag.ToString();
            FDataRow["车辆品牌"] = this.cbx车辆品牌.Text;
            FDataRow["排气量"] = this.cbx排气量.Text;
            FDataRow["座位数"] = this.cbx座位数.Text;
            FDataRow["经费来源性质"] = this.cbx经费来源性质.Text;
            this.DialogResult = DialogResult.OK;         
        }

        #region 控件数据选择
      
        private void btn资产类别_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(4);
            AppServer.Frm资产类别.SetShowParam(this.txt资产类别名称, 0);
            AppServer.Frm资产类别.ShowDialog();
            if (AppServer.Frm资产类别.DialogResult == DialogResult.OK)
            {
                this.txt资产类别名称.Tag = AppServer.Frm资产类别.SelectNodeID;
                this.txt资产类别名称.Text = AppServer.Frm资产类别.SelectNodeTitle;
            }
        }      
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
        private void btn车辆类型_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(5);
            AppServer.Frm车辆类型.SetShowParam(this.txt车辆类型名称, 0);
            AppServer.Frm车辆类型.ShowDialog();
            if (AppServer.Frm车辆类型.DialogResult == DialogResult.OK)
            {
                this.txt车辆类型名称.Tag = AppServer.Frm车辆类型.SelectNodeID;
                this.txt车辆类型名称.Text = AppServer.Frm车辆类型.SelectNodeTitle;
            }
        }
        #endregion

       
    }
}
