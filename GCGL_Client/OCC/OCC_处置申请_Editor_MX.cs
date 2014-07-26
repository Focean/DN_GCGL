using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.FZB;
using GCGL_Client.NET;

namespace GCGL_Client.OCC
{
    public partial class OCC_处置申请_Editor_MX : Form
    {
        public OCC_处置申请_Editor_MX()
        {
            InitializeComponent();
            if (!AppServer.WcfService_Open()) return;
            this.cbx处置形式名称.DataSource = AppServer.wcfClient.FZB_编码_List("处置形式").Tables[0];
            this.cbx处置形式名称.DisplayMember = "处置形式名称";
            this.cbx处置形式名称.ValueMember = "处置形式编码";   
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 12, this.btnOk, true);
        }

        #region 增、改
        private DataRow FDataRow;
        private string ZCBH;
        private string[] ZCstr =new string[10];
        public void Editor_Add(DataRow row,string[] str)
        {
            this.Text = "处置申请明细(添加)";
            this.Tag = "Add";
            FDataRow = row;
            Array.Copy(str, ZCstr, str.Length);
        }

        public void Editor_Mod(DataRow row)
        {
            this.Text = "处置申请明细(修改)";
            this.Tag = "Mod";
            FDataRow = row;
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
            this.cbx处置形式名称.Text = row["处置形式名称"].ToString();
        }
        #endregion 
      
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txt资产名称.Text == "")
            {
                AppServer.ShowMsg("资产名称不能为空！", "提示");
                this.txt资产名称.Focus();
                return;
            }
            if (this.nud评估价值.Value == 0)
            {
                AppServer.ShowMsg("评估价值不能为0！", "提示");
                this.nud评估价值.Focus();
                return;
            }     
            //开始赋值给Datarow   
            if (FDataRow == null) return;
            TY.Helper.FormHelper.DataBinding_FormToDataRow(this, FDataRow);
            FDataRow["资产编号"] = ZCBH;
            FDataRow["取得日期"] = this.dtp取得日期.Value;
            FDataRow["账面净值"] = this.nud账面净值.Value;
            FDataRow["评估价值"] = this.nud评估价值.Value;
            FDataRow["处置形式名称"] = this.cbx处置形式名称.Text;
            FDataRow["处置形式编码"] = this.cbx处置形式名称.SelectedValue;
            if(this.txt附件信息.Tag!=null)FDataRow["依据文件编码"] = this.txt附件信息.Tag.ToString();
            this.DialogResult = DialogResult.OK;   
        }

        private void btn资产编号_Click(object sender, EventArgs e)
        {
            using (var form = new OCC_公车库存_Select())
            {
                form.Select_查询单位资产(ZCstr);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ZCBH = form.SelectPropertyCode;
                    this.txt资产名称.Text = form.SelectPropertyName;
                    this.txt资产名称.Tag = form.SelectPropertyCode;
                    try
                    {
                        if (!AppServer.WcfService_Open()) return;
                        var model = new Ref_WS_GCGL.DataType_OCC_公车库存();
                        model.资产编号 = form.SelectPropertyCode.ToString();
                        DataSet db = AppServer.wcfClient.OCC_公车库存_List(ref model);
                        DataTable table = db.Tables[0];
                        this.txt资产名称.Text = table.Rows[0]["资产名称"].ToString();
                        this.txt规格型号.Text = table.Rows[0]["规格型号"].ToString();
                        this.txt车牌号.Text = table.Rows[0]["车牌号"].ToString();
                        this.nud价值.Value = Convert.ToDecimal(table.Rows[0]["价值"].ToString())*10000;
                        this.dtp取得日期.Value = Convert.ToDateTime(table.Rows[0]["取得日期"].ToString());
                        this.nud账面净值.Value = Convert.ToDecimal(table.Rows[0]["账面净值"].ToString())*10000;
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
    }
}
