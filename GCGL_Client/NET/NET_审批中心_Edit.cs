using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using GCGL_Client.OCC;
using GCGL_Client.FZB;

namespace GCGL_Client.NET
{
    public partial class NET_审批中心_Edit : Form
    {
        public NET_审批中心_Edit()
        {
            InitializeComponent();
            //
            //if (AppServer.LoginUserType == 3)//办事员
            //{
            //    //this.lbl并.Visible = true;
            //    //this.cbx转给.Visible = true;
            //    try
            //    {
            //        if (!AppServer.WcfService_Open()) return;
            //        var dtm = new Ref_WS_GCGL.DataType_User();
            //        dtm.ExAction = "LType";
            //        this.cbx转给.DataSource = AppServer.wcfClient.Sys_User_List(dtm).Tables[0];
            //        this.cbx转给.DisplayMember = "UserName";
            //        this.cbx转给.ValueMember = "UserCode";
            //    }
            //    catch (Exception ex)
            //    {
            //        AppServer.ShowMsg_ExceptError(ex.Message);
            //        return;
            //    }
            //    finally
            //    {
            //        AppServer.WcfService_Close();
            //        base.Cursor = Cursors.Arrow;
            //    }
            //}
            //
            //if (AppServer.LoginUnitType==3 && AppServer.LoginUserType == 3)//经办人
            //{
            //    if (!AppServer.WcfService_Open()) return;
            //    this.cbx转给.DataSource = AppServer.wcfClient.FZB_编码_List("处置形式").Tables[0];
            //    this.cbx转给.DisplayMember = "处置形式名称";
            //    this.cbx转给.ValueMember = "处置形式编码";  
            //}
            //
            if (AppServer.LoginUnitType == 2)//主管单位
            {
                this.cbx返回到.Items.Clear();
                this.cbx返回到.Items.Add("返回给申请单位");
            }
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgv审批);
            
        }
        private string LxName { get; set; }
        private string ExCode { get; set; }

        public void Editor_Mod(string LX, string BM, string DW, string LC)
        {
            this.LxName = LX;
            this.ExCode = BM;
            this.btn提交.Enabled = true;
            DataBinding_GridView(0);
            
        }
        public void Editor_See(string LX, string BM, string DW, string LC)
        {
            this.LxName = LX;
            this.ExCode = BM;
            this.pnl审批.Visible = false;
            this.btn提交.Enabled = false;
            DataBinding_GridView(0);
            
        }

        private Form _ChildForm;
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_NET_审批();
                model.ExAction = "GetCode";
                model.exCode = this.ExCode;
                DataTable table = AppServer.wcfClient.NET_审批_List(ref model).Tables[0];
                if (table.Rows.Count == 0) return;
                string sCardCode = table.Rows[0]["CardCode"].ToString();//申请编号
                //
                var ml = new Ref_WS_GCGL.DataType_NET_审批();
                ml.ExAction = "GetFlow";
                ml.exCode = ExCode;
                ml.LoginUserCode = AppServer.LoginUserCode;
                //
                DataSet dbo = AppServer.wcfClient.NET_审批_List(ref ml);
                this.dgv审批.DataSource = dbo.Tables[0];
                //
                switch (table.Rows[0]["CardType"].ToString())
                {
                    case "PZ":
                        _ChildForm = new OCC_配置申请_Editor();
                        (_ChildForm as OCC_配置申请_Editor).Editor_See(sCardCode, true);
                        _ChildForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        _ChildForm.TopLevel = false;
                        _ChildForm.Parent = this.pnlF;
                        this.Width = _ChildForm.Width + 5;
                        _ChildForm.Visible = true;
                        _ChildForm.Dock = DockStyle.Top;
                        break;
                    case "CZ":
                        _ChildForm = new OCC_处置申请_Editor();
                        (_ChildForm as OCC_处置申请_Editor).Editor_See(sCardCode, true);
                       
                        _ChildForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        _ChildForm.TopLevel = false;
                        _ChildForm.Parent = this.pnlF;
                        this.Width = _ChildForm.Width + 5;
                        _ChildForm.Visible = true;
                        _ChildForm.Dock = DockStyle.Top;
                        if (AppServer.LoginUserType == 3)
                        {
                            (_ChildForm as OCC_处置申请_Editor).CZSP = this.btn提交.Enabled;
                            this.lbl提示.Visible = true;
                        }
                        break;
                    case "RK":
                        _ChildForm = new OCC_公车入库_Editor();
                        (_ChildForm as OCC_公车入库_Editor).Editor_See(sCardCode,"入户",true);
                        _ChildForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        _ChildForm.TopLevel = false;
                        _ChildForm.Parent = this.pnlF;
                        this.Width = _ChildForm.Width + 5;
                        _ChildForm.Visible = true;
                        _ChildForm.Dock = DockStyle.Top;
                        if (AppServer.LoginUserType == 3)
                        {
                            this.cbx返回到.Items.Clear();
                            this.cbx返回到.Items.Add("返回给申请单位");
                        }
                        break;
                    case "CK":
                        switch (table.Rows[0]["处置形式编码"].ToString())
                        {
                            case "01":
                                _ChildForm = new OCC_公车出库_报废();
                                (_ChildForm as OCC_公车出库_报废).Editor_See(sCardCode, true);                 
                                break;
                            case "02":
                                _ChildForm = new OCC_公车出库_报废();
                                (_ChildForm as OCC_公车出库_报废).Editor_See(sCardCode, true);
                                break;
                            case "03":
                                _ChildForm = new OCC_公车出库_调拨();
                                (_ChildForm as OCC_公车出库_调拨).Editor_See(sCardCode, true);
                                break;
                            case "04":
                                _ChildForm = new OCC_公车出库_出售();
                                (_ChildForm as OCC_公车出库_出售).Editor_See(sCardCode, true);                      
                                break;
                        }
                        _ChildForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        _ChildForm.TopLevel = false;
                        _ChildForm.Parent = this.pnlF;
                        this.Width = 750;
                        _ChildForm.Visible = true;
                        _ChildForm.Dock = DockStyle.Top;
                        if (AppServer.LoginUserType == 3)
                        {
                            this.cbx返回到.Items.Clear();
                            this.cbx返回到.Items.Add("返回给申请单位");
                        }
                        break;
                    case "BZ":
                        _ChildForm = new FZB_公车编制数_Editor();
                        (_ChildForm as FZB_公车编制数_Editor).Editor_See(sCardCode, true);
                        _ChildForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        _ChildForm.TopLevel = false;
                        _ChildForm.Parent = this.pnlF;
                        this.Width = 750;
                        _ChildForm.Visible = true;
                        _ChildForm.Dock = DockStyle.Top;
                        if (AppServer.LoginUserType == 3)
                        {
                            this.cbx返回到.Items.Clear();
                            this.cbx返回到.Items.Add("返回给申请单位");
                        }
                        break;
                    case "GX":
                        _ChildForm = new OCC_更新计划_Editor();
                        (_ChildForm as OCC_更新计划_Editor).Editor_View(sCardCode, true);
                        _ChildForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                        _ChildForm.TopLevel = false;
                        _ChildForm.Parent = this.pnlF;
                        this.Width = 750;
                        _ChildForm.Visible = true;
                        _ChildForm.Dock = DockStyle.Top;
                         if (AppServer.LoginUserType == 3)
                         {
                             this.cbx返回到.Items.Clear();
                             this.cbx返回到.Items.Add("返回给申请单位");
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

        private void NET_审批中心_Edit_Load(object sender, EventArgs e)
        {
            
        }

        private void btn提交_Click(object sender, EventArgs e)
        {
            if (this.rbn不同意.Checked == false && this.rbn同意.Checked == false)
            {
                AppServer.ShowMsg("请选择审核意见！","提示");
                return;
            }
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
                    model.exnext = this.cbx返回到.Text.ToString();
                }
                else
                {
                    model.exOpinionFlag = 1;
                    //model.exNextUserCode = this.cbx转给.SelectedValue.ToStringDef();
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

        private void rbn同意_CheckedChanged(object sender, EventArgs e)
        {
            this.cbx转给.Enabled = this.rbn同意.Checked;
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
    }
}
