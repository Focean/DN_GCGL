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
    public partial class FZB_车辆类型_Editor : Form
    {
        public FZB_车辆类型_Editor()
        {
            InitializeComponent();
            base.Cursor = Cursors.WaitCursor;
         
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
        }
        private void btn提交_Click(object sender, EventArgs e)
        {
            #region 提交数据
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_FZB_编码();

                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.ExAction = this.Tag.ToString();
                model.资产类别编码 = this.txt资产类别编码.Text;
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
    }
}
