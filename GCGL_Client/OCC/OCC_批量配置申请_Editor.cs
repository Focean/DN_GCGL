using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.Main;
using GLG.Common;
using TY.Helper;
namespace GCGL_Client.OCC
{
    public partial class OCC_批量配置申请_Editor : Form
    {
        public OCC_批量配置申请_Editor()
        {
            InitializeComponent();
            //
            try
            {
                if (!AppServer.WcfService_Open()) return;
                DataTable dt1 = null;
                DataTable dt2 = null;
                DataTable dt3 = null;
                dt1 = AppServer.wcfClient.FZB_编码_List("车辆品牌").Tables[0];
                if (dt1.Rows.Count > 0)
                {
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        this.cbx车辆品牌.Items.Add(dt1.Rows[i][2].ToString());
                    }
                }
                //
                dt2 = AppServer.wcfClient.FZB_编码_List("排气量").Tables[0];
                if (dt2.Rows.Count > 0)
                {
                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        this.cbx排气量.Items.Add(dt2.Rows[i][2].ToString());
                    }
                }
                //
                dt3 = AppServer.wcfClient.FZB_编码_List("座位数").Tables[0];
                if (dt3.Rows.Count > 0)
                {
                    for (int i = 0; i < dt3.Rows.Count; i++)
                    {
                        this.cbx座位数.Items.Add(dt3.Rows[i][2].ToString());
                    }
                }
                var mod = new Ref_WS_GCGL.DataType_CMN_单位_处室();
                mod.ExAction = "GetOffice";
                cbx归口资金处室.DataSource = AppServer.wcfClient.CMN_单位_处室_List(ref mod).Tables[0];
                cbx归口资金处室.ValueMember = "处室编码";
                cbx归口资金处室.DisplayMember = "处室名称";
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
            //
            TY.Helper.FormHelper.ReturnNextByTabIndex(0, 10, this.btn确定, true);
            this.tyGridView.BuildGrid(AppServer.GetTableDef(this.GetType().Name));
        }

        DataTable dt = new DataTable();
        private void OCC_批量配置申请_Editor_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("预算单位编码");
            dt.Columns.Add("申请序号");
            dt.Columns.Add("资产类别编码");
            dt.Columns.Add("车辆类型编码");
            dt.Columns.Add("车辆品牌");
            dt.Columns.Add("型号");
            dt.Columns.Add("排气量");
            dt.Columns.Add("座位数");
            dt.Columns.Add("价格");
            dt.Columns.Add("数量");
            dt.Columns.Add("经费来源");
            dt.Columns.Add("归口资金处室编码");
            dt.Columns.Add("备注");
        }
        public void Editor_Add()
        {
            this.Text = "批量配置申请(新增)";
            this.Tag = "Add";
        }

        public void Editor_Mod(DataRow row)
        {
            this.Text = "车辆配置申请(修改)";
            this.Tag = "Mod";
            TY.Helper.FormHelper.DataBinding_DataSourceToUI(row, this);
        }

        public void Editor_See(string ACardCode)
        {
            this.Text = "车辆配置申请(查看）";
            this.Tag = "See";
            //
            this.btn确定.Enabled = false;
            this.btn取消.Text = "返回(&X)";
        }

        DataTable dtable = null;
        DataRow dr = null; 
        void GetFormation(string Code)//获取编制数
        {
           
                try
                {
                    if (!AppServer.WcfService_Open()) return;
                    var model = new Ref_WS_GCGL.DataType_CMN_单位_编制();
                    model.ExAction = "All";
                    model.单位编码 = Code;
                    DataSet db = AppServer.wcfClient.CMN_单位_编制_List(ref model);
                    DataTable table = db.Tables[0];
                    if (this.tyGridView.Rows.Count == 0)
                    {
                        dtable = table;
                        this.tyGridView.DataSource = dtable;
                    }
                    else
                    {
                        for (int j = 0; j < dtable.Rows.Count; j++)
                        {
                            if (Code == dtable.Rows[j]["单位编码"].ToString())
                            {
                                AppServer.ShowMsg("所选单位已经存在，请勿重复添加！");
                                return;
                            }
                        }
                        dr = dtable.NewRow();
                        dr = table.Rows[0];
                        dtable.Rows.Add(dr.ItemArray);
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
                }
        }
        private void btn添加单位_Click(object sender, EventArgs e)
        {
            using (var form = new Man_单位_Select())
            {  
                if (form.ShowDialog() == DialogResult.OK)
                {
                    GetFormation(form.SelectUnitCode);
                    this.tyGridView.GoToRowByIndex(-1);
                }
            }
           
        }

        private void btn确定_Click(object sender, EventArgs e)
        {
            if (this.txt车辆类型名称.Text == "")
            {
                AppServer.ShowMsg("车辆类型不能为空！", "提示");
                this.txt车辆类型名称.Focus();
                return;
            }
            if (this.txt资产类别名称.Text == "")
            {
                AppServer.ShowMsg("资产类别不能为空！", "提示");
                this.txt资产类别名称.Focus();
                return;
            }
            if (this.tyGridView.Rows.Count == 0) return;
            //   
            for (int i = 0; i < this.tyGridView.Rows.Count; i++)
            {
                if (txt车辆类型名称.Tag.ToString().Substring(0, 2) != "03" && this.nud数量.Value > this.tyGridView.Rows[i].Cells["一般公务用车编制数"].Value.ToIntegerDef())
                {
                    AppServer.ShowMsg(this.tyGridView.Rows[i].Cells["单位名称"].Value.ToString() + "编制数超编，无法申请！");
                    return;
                }
                else if (txt车辆类型名称.Tag.ToStringDef() == "0301" && this.nud数量.Value > this.tyGridView.Rows[i].Cells["一般执法执勤用车编制数"].Value.ToIntegerDef())
                {
                    AppServer.ShowMsg(this.tyGridView.Rows[i].Cells["单位名称"].Value.ToString() + "编制数超编，无法申请！");
                    return;
                }

                try
                {
                    if (!AppServer.WcfService_Open()) return;
                    //
                    dt.Rows.Add();
                    dt.Rows[0]["预算单位编码"] = this.tyGridView.Rows[i].Cells[0].Value.ToString();
                    dt.Rows[0]["申请序号"] = i + 1;
                    dt.Rows[0]["资产类别编码"] = txt资产类别名称.Tag.ToString();
                    dt.Rows[0]["车辆类型编码"] = txt车辆类型名称.Tag.ToString();
                    dt.Rows[0]["车辆品牌"] = this.cbx车辆品牌.Text;
                    dt.Rows[0]["型号"] = this.txt型号.Text.Trim();
                    dt.Rows[0]["排气量"] = this.cbx排气量.Text;
                    dt.Rows[0]["座位数"] = this.cbx座位数.Text;
                    dt.Rows[0]["价格"] = this.nud价格.Value;
                    dt.Rows[0]["数量"] = this.nud数量.Value;
                    dt.Rows[0]["经费来源"] = this.txt经费来源.Text.Trim();
                    dt.Rows[0]["归口资金处室编码"] = this.cbx归口资金处室.SelectedValue.ToString();
                    dt.Rows[0]["备注"] = this.txt备注.Text.Trim();
                    var model = new Ref_WS_GCGL.DataType_OCC_配置申请();
                    model.ExAction = "Add";
                    model.LoginUserCode = AppServer.LoginUserCode;
                    model.单位编码 = AppServer.LoginUnitCode;
                    model.MxDataStr = dt.ToXml("ar");
                    AppServer.wcfClient.OCC_配置申请_Edit(ref model);
                    if (model.ExResult != 0)
                    {
                        AppServer.HideWaitForm();
                        AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                        return;
                    }
                    this.DialogResult = DialogResult.OK;
                }

                catch (Exception ex)
                {
                    AppServer.HideWaitForm();
                    AppServer.ShowMsg_ExceptError(ex.Message);
                }
                finally
                {
                    AppServer.WcfService_Close();
                    base.Cursor = Cursors.Arrow;
                }
            }
        }

        private void btn车辆类型_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(5);
            AppServer.Frm车辆类型.SetShowParam(this.txt车辆类型名称, 0);
            AppServer.Frm车辆类型.ShowDialog();
            if (AppServer.Frm车辆类型.DialogResult == DialogResult.OK)
            {
                this.txt车辆类型名称.Tag = AppServer.Frm车辆类型.SelectNodeID;
                this.txt车辆类型名称.Text = AppServer.Frm车辆类型.SelectNodeTitle;
            }
        }

        private void btn资产类别_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(4);
            AppServer.Frm资产类别.SetShowParam(this.txt资产类别名称, 0);
            AppServer.Frm资产类别.ShowDialog();
            if (AppServer.Frm资产类别.DialogResult == DialogResult.OK)
            {
                this.txt资产类别名称.Tag = AppServer.Frm资产类别.SelectNodeID;
                this.txt资产类别名称.Text = AppServer.Frm资产类别.SelectNodeTitle;
            }
        }

    }
}
