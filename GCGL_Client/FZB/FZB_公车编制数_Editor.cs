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
    public partial class FZB_公车编制数_Editor : Form
    {
        public FZB_公车编制数_Editor()
        {
            InitializeComponent();
        }
        public void Init()
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_CMN_单位_编制();
                model.ExAction = "List";
                model.单位编码 = txt单位编码.Tag.ToString();
                model.开始日期 = dtp开始日期.Value;
                DataSet db = AppServer.wcfClient.CMN_单位_编制_List(ref model);
                DataTable table = db.Tables[0];
                if (table.Rows.Count == 0) return;
                txt一般公务用车编制数.Text = table.Rows[0]["一般公务用车编制数"].ToString();
                txt一般执法执勤用车编制数.Text = table.Rows[0]["一般执法执勤用车编制数"].ToString();
                txt特种专业技术用车编制数.Text = table.Rows[0]["特种专业技术用车编制数"].ToString();
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
            }
        }
        public void Editor_Add()
        {
            this.Text = "公车编制数(新增)";
            this.Tag = "Add";
            //   
        }

        private void txt申请单位_MouseClick(object sender, MouseEventArgs e)
        {
            this.btn选择单位.Visible = true;
        }

        private void btn选择单位_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(2);
            AppServer.Frm单位信息.Left = txt单位编码.PointToScreen(new Point(0, 0)).X;
            AppServer.Frm单位信息.Top = txt单位编码.PointToScreen(new Point(0, 0)).Y+txt单位编码.Height;
            AppServer.Frm单位信息.Width = txt单位编码.Width;

            AppServer.Frm单位信息.ShowDialog();
            if (AppServer.Frm单位信息.DialogResult == DialogResult.OK)
            {
                this.txt单位编码.Tag = AppServer.Frm单位信息.SelectNodeID;
                this.txt单位编码.Text = AppServer.Frm单位信息.SelectNodeTitle;
            }
            Init();
        }

        private void btn提交_Click(object sender, EventArgs e)
        {
            #region 提交数据
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_CMN_单位_编制();
                model.ExAction ="Add";
                model.单位编码 = this.txt单位编码.Tag.ToString();
                model.创建人编码 = AppServer.LoginUserCode;
                model.开始日期 = this.dtp开始日期.Value;
                model.一般公务用车编制数 =Convert.ToInt32(this.nud一般公务用车编制数.Value);
                model.一般执法执勤用车编制数 = Convert.ToInt32(this.nud一般执法执勤用车编制数.Value);
                model.特种专业技术用车编制数 = Convert.ToInt32(this.nud特种专业技术用车编制数.Value);
                AppServer.wcfClient.CMN_单位_编制_Edit(ref model);
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                this.DialogResult = DialogResult.OK;
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
        }
    }
}
