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
        }
        private string FDataRow = null;
        public void Editor_Add()
        {
            this.Text = "资产类别设置(新增)";
            this.Tag = "Add";
            //   
        }

        public void Editor_Mod(DataRow row)
        {
            this.Text = "资产类别设置(修改)";
            this.Tag = "Mod";
            //
            FDataRow = row["资产类别编码"].ToString();
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
            this.txt资产类别编码.ReadOnly = true;
        }

        public void Editor_View(DataRow row)
        {
            this.Text = "资产类别设置(查看)";
            this.Tag = "View";
            //
            FDataRow = row["资产类别编码"].ToString();
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
            this.btn提交.Enabled = false;
            this.btn取消.Text = "返回(&X)";
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
            //    model.资产类别编码 = FUnitCode;
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
