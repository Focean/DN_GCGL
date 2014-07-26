using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace GCGL_Client.OCC
{
    public partial class OCC_批量申请_接收 : Form
    {
        private int 公务CarNum;  //编制数    
        private int 执法CarNum;
        private int 特种CaNum;
        private DataRow row_mod = null;
        public OCC_批量申请_接收()
        {
            InitializeComponent();
        }

        private void OCC_接收情况_Editor_Load(object sender, EventArgs e)
        {
            this.lbl单位名称.Text = AppServer.LoginUnitName;
            Get_Freeze(AppServer.LoginUnitCode);
            GetNum(AppServer.LoginUnitCode);
        }

        public void Editor_Add(DataRow row)
        {
            this.Text = "接收车辆";
            this.Tag = "Accept";
            row_mod = row;
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);    
        }

        public void Editor_See(DataRow row)
        {
            this.Text = "查看接收车辆";
            this.Tag = "See";
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);

            this.nud接收数量.BackColor = SystemColors.Control;
            this.nud接收数量.Enabled = false;
            this.txt接收原因.BackColor = SystemColors.Control;
            this.txt接收原因.Enabled = false;
            this.lbl修改.Visible = false;
            this.btn接收.Enabled = false;

        }
        //提取当前预算单位的公车编制与实有数
        public void GetNum(string code)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //计算单位的剩余编制数（目前先不把冻结数计算在内）
                var mdl = new Ref_WS_GCGL.DataType_CMN_单位_编制();
                mdl.ExAction = "All";
                mdl.单位编码 = code;
                DataSet db = AppServer.wcfClient.CMN_单位_编制_List(ref mdl);
                DataTable table = db.Tables[0];
                if (table.Rows.Count == 0) return;
                else
                {
                    this.lbl公务用车实有数.Text = table.Rows[0][0].ToString();
                    this.lbl其中执法执勤用车实有数.Text = table.Rows[0][1].ToString();
                    this.lbl特种专业技术用车实有数.Text = table.Rows[0][2].ToString();

                    this.lbl公务用车编制数.Text = table.Rows[0][3].ToString();
                    this.lbl其中执法执勤用车编制数.Text = table.Rows[0][4].ToString();
                    this.lbl特种专业技术用车编制数.Text = table.Rows[0][5].ToString();

                    公务CarNum = table.Rows[0][3].ToIntegerDef() - table.Rows[0][0].ToIntegerDef();
                    执法CarNum = table.Rows[0][4].ToIntegerDef() - table.Rows[0][1].ToIntegerDef();
                    特种CaNum = table.Rows[0][5].ToIntegerDef() - table.Rows[0][2].ToIntegerDef();
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
        }
        private void Get_Freeze(string Ucode)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //获取冻结数
                var mdel = new Ref_WS_GCGL.DataType_OCC_配置申请();
                mdel.ExAction = "Freeze";
                mdel.单位编码 = Ucode;
                DataSet dab = AppServer.wcfClient.OCC_配置申请_List(ref mdel);
                DataTable tbl = dab.Tables[0];
                if (tbl.Rows.Count == 0)
                {
                    this.lbl公务冻结数.Text = "0";
                    this.lbl执法冻结数.Text = "0";
                    this.lbl特种专业用车冻结数.Text = "0";
                }
                else
                {
                    this.lbl公务冻结数.Text = tbl.Rows[0][1].ToString();
                    this.lbl执法冻结数.Text = tbl.Rows[0][0].ToString();
                    this.lbl特种专业用车冻结数.Text = tbl.Rows[0][2].ToString();
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
        }

        private void btn接收_Click(object sender, EventArgs e)
        {
            this.PostData(true);              
        }

        private void btn拒收_Click(object sender, EventArgs e)
        {
            this.nud接收数量.Value = 0;
            this.PostData(false);
        }
        private void PostData(Boolean ASubmit)
        {
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_OCC_批量申请();
                model.ExAction = this.Tag.ToString();
                model.是否接收 = ASubmit;
                if (this.txt接收原因.Text.Trim() != "")
                {
                    model.接收原因 = this.txt接收原因.Text;
                }
                model.接收数量 = Convert.ToInt32(this.nud接收数量.Value);
                model.LoginUserCode = AppServer.LoginUserCode;
                model.单位编码 = AppServer.LoginUnitCode;

                model.配置编号 = row_mod["配置编号"].ToString();
                model.序号 = Convert.ToInt32(row_mod["序号"].ToString());

                AppServer.wcfClient.OCC_批量申请_Edit(ref model);
                //
                if (model.ExResult != 0)
                {
                    AppServer.HideWaitForm();
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
            this.DialogResult = DialogResult.OK;
        }
        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nud接收数量_ValueChanged(object sender, EventArgs e)
        {
            if (this.nud接收数量.Value > Convert.ToDecimal(this.txt分配数量.Text))
            {
                AppServer.ShowMsg_Warn("该接收数量不能大于分配数量！", "警告");
                this.nud接收数量.Value = Convert.ToDecimal(this.txt分配数量.Text);
                return;
            }
        }
    }
}
