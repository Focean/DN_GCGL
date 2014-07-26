using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.OCC
{
    public partial class OCC_批量申请_接收_UD : Form
    {
        public OCC_批量申请_接收_UD()
        {
            InitializeComponent();
        }
        private DataRow RowT = null;
        public void Editor_Mod(DataRow row)
        {
            this.Text = "接收数量(修改)";
            this.Tag = "Mod";
            RowT = row;
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
        }

        private void btn确定_Click(object sender, EventArgs e)
        {
            if (this.nud分配数量.Value < this.nud接收数量.Value)
            {
                AppServer.ShowMsg("接收数量不能大于分配数量","提示");
                this.nud接收数量.Focus();
                return;
            }
            #region 提交数据
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_OCC_批量申请();

                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.ExAction = this.Tag.ToString();
                model.配置编号 = RowT["配置编号"].ToString();
                model.接收原因 = this.txt接收原因.Text;
                model.LoginUserCode = AppServer.LoginUserCode;
                model.单位编码 = AppServer.LoginUnitCode;
                AppServer.wcfClient.OCC_批量申请_Edit(ref model);
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }

            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;
            }
            #endregion
            this.DialogResult = DialogResult.OK;
        }
           

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
