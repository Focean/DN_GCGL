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
                //
                if (!AppServer.WcfService_Open()) return;
                this.cbx车辆类型编码.DataSource = AppServer.wcfClient.FZB_编码_List("车辆类型", AppServer.LoginAreaCode).Tables[0];
                this.cbx车辆类型编码.DisplayMember = "车辆类型名称";
                this.cbx车辆类型编码.ValueMember = "车辆类型编码";
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
            if (AppServer.LoginUnitIsGWC())
            {
                this.btn预算单位.Visible = false;
                this.txt单位编码.Tag = "410001_GWC";
                this.txt单位编码.Text = "省公物仓";
            }
            if (AppServer.LoginUnitIsYSDW())
            {
                this.btn预算单位.Visible = false;
                this.txt单位编码.Tag = AppServer.LoginUnitCode;
                this.txt单位编码.Text = AppServer.LoginUnitName;
            }
        }
        public DataTable table;
       
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
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车库存();
                model.ExAction = this.Tag.ToString();
                if (AppServer.LoginUnitIsYSDW() || AppServer.LoginUnitIsGWC())
                {
                    model.单位编码 = AppServer.LoginUnitCode;
                }
                else if (AppServer.LoginUnitIsZGDW())
                {
                    model.单位编码 = AppServer.LoginUnitCode;
                    model.包含下级 = this.chk包含下级.Checked;
                }
                if (this.txt单位编码.Tag != null)
                {
                    model.单位编码 = this.txt单位编码.Tag.ToString();
                    model.包含下级 = this.chk包含下级.Checked;
                }
                if (this.txt资产类别编码.Tag!=null)
                {
                    model.资产类别编码 = this.txt资产类别编码.Tag.ToString();
                }
                if (this.chk车辆类型.Checked)
                {
                    if (this.cbx车辆类型编码.SelectedValue != null)
                    {
                        model.车辆类型编码 = this.cbx车辆类型编码.SelectedValue.ToString();
                    }
                }
                if (this.chk取得.Checked == true)
                {
                    model.开始时间 = this.dtp取得日期k.Value;
                    model.结束时间 = this.dtp取得日期j.Value;
                }
                if (this.chk截止.Checked == true)
                {
                    model.保修截止日期k = this.dtp保修截止日期k.Value;
                    model.保修截止日期j = this.dtp保修截止日期j.Value;
                }
                if (this.chk价值.Checked == true)
                {
                    model.价值1 = this.nud价值1.Value;
                    model.价值2 = this.nud价值2.Value;
                }
                if (this.chk账面净值.Checked == true)
                {
                    model.账面净值1 = this.nud账面净值1.Value;
                    model.账面净值2 = this.nud账面净值2.Value;
                }
                model.车牌号 = this.txt车牌号.Text.Trim();
                model.发动机号 = this.txt发动机号.Text.Trim();
                model.资产名称 = this.txt资产名称.Text.Trim();
                model.在编制 = this.chk在编制.Checked;
                model.已报废 = this.chk已报废.Checked;
                model.已出售 = this.chk已出售.Checked;
                model.审核中 = this.chk审核中.Checked;
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

        private void btn重置_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = string.Empty;
                    tb.Tag = string.Empty;
                    this.txt单位编码.Tag = AppServer.LoginUnitCode;
                    this.txt单位编码.Text = AppServer.LoginUnitName;
                }
            }
           
            nud价值1.Value = 0;
            nud价值2.Value = 9999999;
            nud账面净值1.Value = 0;
            nud账面净值2.Value = 9999999;
            this.chk已报废.Checked = false;
            this.chk已出售.Checked = false;
            this.chk在编制.Checked = true;
            this.chk取得.Checked = true;
            this.chk截止.Checked = true;
            this.chk价值.Checked = true;
            this.chk账面净值.Checked = true;
        }

        private void chk取得_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk取得.Checked == true)
            {
                this.dtp取得日期k.Enabled = true;
                this.dtp取得日期j.Enabled = true;
            }
            else
            {
                this.dtp取得日期k.Enabled = false;
                this.dtp取得日期j.Enabled = false;
            }
        }

        private void chk截止_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk取得.Checked == true)
            {
                this.dtp保修截止日期k.Enabled = true;
                this.dtp保修截止日期j.Enabled = true;
            }
            else
            {
                this.dtp保修截止日期k.Enabled = false;
                this.dtp保修截止日期j.Enabled = false;
            }
        }

        private void chk价值_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk价值.Checked == true)
            {
                this.nud价值1.Enabled = true;
                this.nud价值2.Enabled = true;
            }
            else
            {
                this.nud价值1.Enabled = false;
                this.nud价值2.Enabled = false;
            }
        }
        private void chk车辆类型_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk车辆类型.Checked)
                this.cbx车辆类型编码.Enabled = true;
            else
                this.cbx车辆类型编码.Enabled = false;
        }
        private void chk账面净值_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk账面净值.Checked == true)
            {
                this.nud账面净值1.Enabled = true;
                this.nud账面净值2.Enabled = true;
            }
            else
            {
                this.nud账面净值1.Enabled = false;
                this.nud账面净值2.Enabled = false;
            }
        }
        //快捷键设置
        private void RPT_条件组合_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && e.Modifiers == Keys.Control)         //Ctrl+D
            {
                this.btn确定_Click(this, EventArgs.Empty);
            }
        }

        private void btn预算单位_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(2);
            AppServer.Frm单位信息.SetShowParam(this.txt单位编码, 0);
            AppServer.Frm单位信息.ShowDialog();
            if (AppServer.Frm单位信息.DialogResult == DialogResult.OK)
            {
                this.txt单位编码.Tag = AppServer.Frm单位信息.SelectNodeID;
                this.txt单位编码.Text = AppServer.Frm单位信息.SelectNodeTitle;
            }
            AppServer.Frm单位信息.Hide();
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

       
    }
}
