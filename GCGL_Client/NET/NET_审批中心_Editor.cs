using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.OCC;

namespace GCGL_Client.NET
{
    public partial class OCC_网上审批_Editor : Form
    {
        public OCC_网上审批_Editor()
        {
            InitializeComponent();
        }

        private string LxName { get; set; }
        private string ExCode { get; set; }

        public void Editor_Mod(string LX, string BM, string DW, string LC)
        {
            this.LxName = LX;
            this.ExCode = BM;
            this.txt单位名称.Text = DW;
            this.txt审批流程.Text = LX + "--" + LC;
        }

        private void btn提交_Click(object sender, EventArgs e)
        {
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_NET_审批();
                model.LoginUserCode = AppServer.LoginUserCode;
                model.exCode = this.ExCode;
                model.exOpinion = txtexOpinion.Text;
                if (this.rbn同意.Checked == false)
                {
                    model.exOpinionFlag = 0;
                }
                else
                {
                    model.exOpinionFlag = 1;
                }
                AppServer.wcfClient.NET_审批_Edit(ref model);
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                //
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
        }

        private void rbn不同意_CheckedChanged(object sender, EventArgs e)
        {
            this.cbx返回到.Enabled = this.rbn不同意.Checked;
            //
            if (this.cbx返回到.Enabled)
                this.cbx返回到.SelectedIndex = 0;
            else 
                this.cbx返回到.SelectedIndex = -1;
        }

        private void btn查阅申请_Click(object sender, EventArgs e)
        {
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_NET_审批();
                model.ExAction = "GetCode";
                model.exCode = this.ExCode;
                DataTable table = AppServer.wcfClient.NET_审批_List(ref model).Tables[0];
                if (table.Rows.Count == 0) return;
                string sCardCode = table.Rows[0]["CardCode"].ToString();
                //AppServer.ShowMsg(sCardCode);
                //
                switch (table.Rows[0]["CardType"].ToString())
                {
                    case "PZ":
                        using (var form = new OCC_配置申请_Editor())
                        {
                            form.Editor_See(sCardCode);
                            form.ShowDialog();
                        }
                        break;
                    case "CZ":
                        using (var form = new OCC_处置申请_Editor())
                        {
                            form.Editor_See(sCardCode);
                            form.ShowDialog();
                        }
                        break;
                    case "RK":
                        using (var form = new OCC_公车入库_Editor())
                        {
                            form.Editor_See(sCardCode);
                            form.ShowDialog();
                        }
                        break;
                    case "CK":
                        switch (table.Rows[0]["处置形式编码"].ToString())
                        {
                            case "01":
                                using (var form = new OCC_公车出库_调拨())
                                {
                                    form.Editor_See(sCardCode);
                                    form.ShowDialog();
                                }
                                break;
                            case "02":
                                using (var form = new OCC_公车出库_报废())
                                {
                                    form.Editor_See(sCardCode);
                                    form.ShowDialog();
                                }
                                break;
                            case "03":
                                using (var form = new OCC_公车出库_出售())
                                {
                                    form.Editor_See(sCardCode);
                                    form.ShowDialog();
                                }
                                break;
                        }
                        break;
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

        private void btn查阅流程_Click(object sender, EventArgs e)
        {
            using (var form = new NET_审批中心_Flow())
            {
                form.Editor_See(this.ExCode);
                form.ShowDialog();
            }

        }
    }
}
