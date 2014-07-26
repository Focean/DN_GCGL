using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.FZB
{
    public partial class FZB_资产类别_Editor : Form
    {
        public FZB_资产类别_Editor()
        {
            InitializeComponent();         
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 9, this.btn提交, true);
        }

        private void BZ_资产类别_Editor_Load(object sender, EventArgs e)
        {

        }

        private string FDataRow=null;
        public void Editor_Add(string str)
        {
            this.Text = "资产类别设置(新增)";
            this.Tag = "Add";
            //   
            FDataRow = str;
            txt上级编码.Text = FDataRow;   
        }

        public void Editor_Mod(DataRow row)
        {
            this.Text = "资产类别设置(修改)";
            this.Tag = "Mod";
            //
            FDataRow = row["编码"].ToString();
            this.txt上级编码.ReadOnly = true;
            this.txt资产类别编码.ReadOnly = true;
            this.txt上级编码.Text = row["上级编码"].ToString();
            this.txt资产类别编码.Text = row["编码"].ToString();
            this.txt资产类别名称.Text = row["名称"].ToString();
            this.chk顶级节点.Enabled = false;
            if (this.txt上级编码.Text != "")
                this.chk顶级节点.Checked = false;
            else
                this.chk顶级节点.Checked = true;
        }
        private void btn提交_Click(object sender, EventArgs e)
        {
            if(this.txt资产类别编码.Text.Trim()==""||this.txt资产类别名称.Text.Trim()=="")
            {
                AppServer.ShowMsg("请完善资产类别信息后再提交！");
                return;
            }
            #region 提交数据
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_FZB_编码();
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.ExAction = this.Tag.ToString();
                model.资产类别编码 = this.txt资产类别编码.Text;
                if (this.chk顶级节点.Checked) model.上级编码 = null;
                model.上级编码 = this.txt上级编码.Text;
                model.资产类别名称 = this.txt资产类别名称.Text;
                model.可选择项 = chk可选项.Checked;
                AppServer.wcfClient.FZB_资产类别_Edit(ref model);
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
            //
            this.DialogResult = DialogResult.OK;
        }


        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FZB_车辆类型_Editor_KeyDown(object sender, KeyEventArgs e)
        {

            //单键 
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btn取消_Click(this, EventArgs.Empty);
                    break;
            }

            // 组合键
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)         //Ctrl+s
            {
                btn提交_Click(this, EventArgs.Empty);
            }
        }

        private void chk顶级节点_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk顶级节点.Checked)
            {
                this.txt上级编码.Text = "";
            }
            else
            {
                this.txt上级编码.Text = FDataRow;
            }
        }

        private void txt资产类别编码_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
