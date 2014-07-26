using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.Main;
namespace GCGL_Client.RPT
{
    public partial class RPT_条件组合 : Form
    {
        public RPT_条件组合()
        {
            InitializeComponent();    
            //
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_单位();
                model.ExAction = "GetSubList";
                if (AppServer.LoginUnitType < 3 || AppServer.LoginUnitType == 8)
                    model.单位编码 = AppServer.LoginUnitCode;
                DataTable dt = null;
                DataSet ds = AppServer.wcfClient.CMN_单位_List(ref model);
                dt = ds.Tables[0];
                this.cbx单位编码.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.cbx单位编码.AutoCompleteSource = AutoCompleteSource.ListItems;
                this.cbx单位编码.DataSource = dt;
                this.cbx单位编码.DisplayMember = "单位名称";
                this.cbx单位编码.ValueMember = "单位编码";
                this.cbx单位编码.SelectedIndex = -1;
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
        public DataTable table;
        public int f = 0;
        public void select_tag(string str)
        {
            this.Tag = str;
            if (str == "Maccount")
            {
                this.chk已报废.Enabled = false;
                this.chk已出售.Enabled = false;
                this.chk在编制.Enabled = false;
            }
        }
        private void btn确定_Click(object sender, EventArgs e)
        {
            if (this.chk在编制.Checked == true && this.chk已报废.Checked == false && this.chk已出售.Checked == false) f = 1;
            else  f = 0;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车库存();
                model.ExAction = this.Tag.ToString();
                if (AppServer.LoginUnitType == 1 || AppServer.LoginUnitType == 8)
                {
                    model.单位编码 = AppServer.LoginUnitCode;
                }
                else
                if (this.cbx单位编码.SelectedValue!=null)
                {
                    model.单位编码 = this.cbx单位编码.SelectedValue.ToString();
                    model.包含下级 = this.chk包含下级.Checked;
                }
                if (this.txt车辆类型编码.Tag!=null)
                {
                    model.车辆类型编码 = this.txt车辆类型编码.Tag.ToString();
                }
                if (this.txt资产类别编码.Tag!=null)
                {
                    model.资产类别编码 = this.txt资产类别编码.Tag.ToString();
                }
                model.开始时间 = this.dtp开始时间.Value;
                model.结束时间 = this.dtp结束时间.Value;
                model.保修截止日期k = this.dtp保修截止日期k.Value;
                model.保修截止日期j = this.dtp保修截止日期j.Value;
                model.账面净值1 = this.nud账面净值1.Value;
                model.账面净值2 = this.nud账面净值2.Value;
                model.价值1 = this.nud价值1.Value;
                model.价值2 = this.nud价值2.Value;
                model.车牌号 = this.txt车牌号.Text.Trim();
                model.发动机号 = this.txt发动机号.Text.Trim();
                model.资产名称 = this.txt资产名称.Text.Trim();
                model.在编制 = this.chk在编制.Checked;
                model.已报废 = this.chk已报废.Checked;
                model.已出售 = this.chk已出售.Checked;
                DataSet db = AppServer.wcfClient.OCC_公车库存_List(ref model);
                table = db.Tables[1];
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

            this.DialogResult = DialogResult.OK;
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

        private void btn重置_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = string.Empty;
                    tb.Tag = string.Empty;
                    this.cbx单位编码.SelectedIndex = -1;
                }
            }
            nud价值1.Value = 0;
            nud价值2.Value = 9999999;
            nud账面净值1.Value = 0;
            nud账面净值2.Value = 9999999;
        }
    }
}
