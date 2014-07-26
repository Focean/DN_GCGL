using GCGL_Client.Main;
using GCGL_Client.NET;
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
    public partial class OCC_批量申请_Editor : Form
    {
        public OCC_批量申请_Editor()
        {
            InitializeComponent();
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                DataTable dt1 = AppServer.wcfClient.FZB_编码_List("车辆品牌", AppServer.LoginAreaCode).Tables[0];
                this.cbx车辆品牌.DataSource = dt1;
                this.cbx车辆品牌.DisplayMember = "名称";
                this.cbx车辆品牌.ValueMember = "编码";
                this.cbx车辆品牌.SelectedValue = -1;
                //
                DataTable dt2 = AppServer.wcfClient.FZB_编码_List("排气量", AppServer.LoginAreaCode).Tables[0];
                this.cbx排气量.DataSource = dt2;
                this.cbx排气量.DisplayMember = "名称";
                this.cbx排气量.ValueMember = "编码";
                this.cbx排气量.SelectedValue = -1;
                //
                DataTable dt3 = AppServer.wcfClient.FZB_编码_List("座位数", AppServer.LoginAreaCode).Tables[0];
                this.cbx座位数.DataSource = dt3;
                this.cbx座位数.DisplayMember = "名称";
                this.cbx座位数.ValueMember = "编码";
                this.cbx座位数.SelectedValue = -1;
                //
                DataTable dt4 = AppServer.wcfClient.FZB_编码_List("车辆类型", AppServer.LoginAreaCode).Tables[0];
                this.cbx车辆类型名称.DataSource = dt4;
                this.cbx车辆类型名称.DisplayMember = "车辆类型名称";
                this.cbx车辆类型名称.ValueMember = "车辆类型编码";
                this.cbx车辆类型名称.SelectedValue = -1;          
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

        public void Editor_Add()
        {
            this.Text = "批量配置申请车辆分发（添加）";
            this.Tag = "Add";
            this.DataBinding_GridView("");
        }

        public void Editor_Distribute(DataRow row)
        {
            this.Text = "批量配置申请车辆二次分发";
            this.Tag = "Distribute";
            this.DataBinding_GridView(row["配置编号"].ToString());
            this.btn添加.TabIndex = 0;

            #region   数据显示的形式
            this.btn资产类别.Visible = false;
            this.btn附件管理.Enabled = false;
            this.txt配置原因.BackColor = SystemColors.Control;
            this.txt配置原因.Enabled = false;
            this.txt备注.BackColor = SystemColors.Control;
            this.txt备注.Enabled = false;
            this.txt经费来源.BackColor = SystemColors.Control;
            this.txt经费来源.Enabled = false;
            this.txt资产类别名称.BackColor = SystemColors.Control;
            this.cbx排气量.BackColor = SystemColors.Control;
            this.cbx排气量.Enabled = false;
            this.cbx经费来源性质.BackColor = SystemColors.Control;
            this.cbx经费来源性质.Enabled = false;
            this.cbx座位数.BackColor = SystemColors.Control;
            this.cbx座位数.Enabled = false;
            this.txt型号.Enabled = false;
            this.cbx车辆品牌.BackColor = SystemColors.Control;
            this.cbx车辆品牌.Enabled = false;
            this.nud价格.BackColor = SystemColors.Control;
            this.nud价格.Enabled = false;
            this.cbx车辆类型名称.BackColor = SystemColors.Control;
            this.cbx车辆类型名称.Enabled = false;
            #endregion
        }

        public void Editor_Mod(string ACardCode)
        {
            this.Text = "批量配置申请车辆分发（修改）";
            this.Tag = "Mod";
            //
            this.DataBinding_GridView(ACardCode);
        }

        public void Editor_See(string ACardCode)
        {
            this.Text = "批量配置申请车辆分发（查看）";
            this.Tag = "See";
            this.DataBinding_GridView(ACardCode);

            #region   数据显示的形式
            this.btn删除.Enabled = false;
            this.btn添加.Enabled = false;
            this.btn资产类别.Visible =false;
            this.btn附件管理.Enabled = false;
            this.txt配置原因.BackColor = SystemColors.Control;
            this.txt配置原因.Enabled = false;
            this.txt备注.BackColor = SystemColors.Control;
            this.txt备注.Enabled = false;
            this.txt经费来源.BackColor = SystemColors.Control;
            this.txt经费来源.Enabled = false;
            this.txt资产类别名称.BackColor = SystemColors.Control;
            this.cbx排气量.BackColor = SystemColors.Control;
            this.cbx排气量.Enabled = false;
            this.cbx经费来源性质.BackColor = SystemColors.Control;
            this.cbx经费来源性质.Enabled = false;
            this.cbx座位数.BackColor = SystemColors.Control;
            this.cbx座位数.Enabled = false;
            this.txt型号.Enabled = false;
            this.cbx车辆品牌.BackColor = SystemColors.Control;
            this.cbx车辆品牌.Enabled = false;
            this.nud价格.BackColor = SystemColors.Control;
            this.nud价格.Enabled = false;
            this.cbx车辆类型名称.BackColor = SystemColors.Control;
            this.cbx车辆类型名称.Enabled = false;
            this.btn确定.Enabled = false;
            this.btn取消.Text = "返回(&X)";
            #endregion
        }

        private void DataBinding_GridView(string ACardCode)
        {
            this.btn确定.Tag = ACardCode;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_批量申请();
                model.ExAction = "Card";
                model.配置编号 = ACardCode;
                DataSet db = AppServer.wcfClient.OCC_批量申请_List(ref model);
                //
                if (db.Tables[0].Rows.Count > 0)//查询出来的第一个数据表
                {
                    TY.Helper.FormHelper.DataBinding_DataSourceToUI(db.Tables[0], this);//调用函数赋值
                    this.txt资产类别名称.Tag = db.Tables[0].Rows[0]["资产类别编码"].ToString();
                    this.cbx排气量.Text = db.Tables[0].Rows[0]["排气量"].ToString();
                    this.cbx车辆类型名称.Tag = db.Tables[0].Rows[0]["车辆类型编码"].ToString();
                    this.cbx车辆类型名称.Text = db.Tables[0].Rows[0]["车辆类型名称"].ToString();
                    this.txt附件信息.Tag = db.Tables[0].Rows[0]["依据文件编码"].ToString();
                    this.txt附件信息.Text = db.Tables[0].Rows[0]["附件摘要"].ToString();
                }
                //
                this.dgvList.DataSource = db.Tables[1];//第二个数据表(申请明细表)
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

        private void btn资产类别_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(5);
            AppServer.Frm资产类别.SetShowParam(this.txt资产类别名称, 0);
            AppServer.Frm资产类别.ShowDialog();
            if (AppServer.Frm资产类别.DialogResult == DialogResult.OK)
            {
                this.txt资产类别名称.Tag = AppServer.Frm资产类别.SelectNodeID;
                this.txt资产类别名称.Text = AppServer.Frm资产类别.SelectNodeTitle;
            }
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn确定_Click(object sender, EventArgs e)
        {
            #region 控件验证
            if (this.txt资产类别名称.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("资产类别不能为空！", "提示");
                this.txt资产类别名称.Focus();
                return;
            }
            if (this.cbx车辆品牌.Text.Trim() == "" || this.cbx排气量.Text.Trim() == "" || this.cbx座位数.Text.Trim() == "" || this.txt型号.Text.Trim() == "")
            {
                AppServer.ShowMsg("请将车辆信息填写完整！", "提示");
                return;
            }
            if (this.nud价格.Value == 0)
            {
                AppServer.ShowMsg("价格不能为0！", "提示");
                this.nud价格.Focus();
                return;
            }
            //
            if (this.cbx车辆类型名称.SelectedValue.ToString() == "")
            {
                AppServer.ShowMsg("车辆类型不能为空！", "提示");
                this.cbx车辆类型名称.Focus();
                return;
            }

            if (this.cbx经费来源性质.Text == "" || this.txt经费来源.Text.Trim() == "")
            {
                AppServer.ShowMsg("请完善经费来源信息！", "提示");
                this.txt经费来源.Focus();
                return;
            }
            #endregion
            try
            {
                if (!AppServer.WcfService_Open()) return;
                    var model = new Ref_WS_GCGL.DataType_OCC_批量申请();
                    if (this.Tag.ToString() != "Add") model.配置编号 =this.btn确定.Tag.ToString();
                    model.ExAction = this.Tag.ToString();
                    model.资产类别编码 = this.txt资产类别名称.Tag.ToString();
                    model.备注 = this.txt备注.Text;
                    model.车辆类型编码 = this.cbx车辆类型名称.SelectedValue.ToString();
                    model.经费来源 = this.txt经费来源.Text;
                    model.经费来源性质 = this.cbx经费来源性质.Text;
                    model.车辆品牌 = this.cbx车辆品牌.Text;
                    model.型号 = this.txt型号.Text;
                    model.座位数 = this.cbx座位数.Text;
                    model.排气量 = this.cbx排气量.Text;
                    model.价格 = this.nud价格.Value;
                    model.配置原因 = this.txt配置原因.Text;
                    model.申请单位 = AppServer.LoginUnitCode;
                    if (this.txt附件信息.Tag != null) model.依据文件编码 = this.txt附件信息.Tag.ToString();
                    
                    //判断是否已接受
                    for (int i= 0; i < ((DataTable)this.dgvList.DataSource).Rows.Count;i++ )
                    {
                        if (((DataTable)this.dgvList.DataSource).Rows[i]["接收状态"].ToString() == "已接收"
                            || ((DataTable)this.dgvList.DataSource).Rows[i]["接收状态"].ToString() == "拒收")
                        {
                            ((DataTable)this.dgvList.DataSource).Rows.RemoveAt(i);
                        }
                    }
                    model.MxDataStr = ((DataTable)this.dgvList.DataSource).ToXml("ar");            
                    AppServer.wcfClient.OCC_批量申请_Edit(ref model);
                    if (model.ExResult != 0)
                    {
                        AppServer.HideWaitForm();
                        AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    }
                    //此时记住已保存成功了，如果是新增状态可变为修改状态了，防止提交不成功后重复新增数据
                    if (this.Tag.ToString() == "Add")
                    {
                        this.Tag = "Mod";
                        this.btn确定.Tag = model.配置编号;
                    }
            }
            catch (Exception ex)
            {
                AppServer.HideWaitForm();
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

        private void btn添加_Click(object sender, EventArgs e)
        {
            using (var form = new OCC_批量申请_Editor_FP())
            {
                DataRow newrow = ((DataTable)this.dgvList.DataSource).NewRow();
               
                form.Editor_Add(newrow);
                bool ASubmit = true;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //判断是否已接受
                    for (int j = 0; j < ((DataTable)this.dgvList.DataSource).Rows.Count; j++)
                    {
                        if (((DataTable)this.dgvList.DataSource).Rows[j]["接收状态"].ToString() == "已接收"
                            && ((DataTable)this.dgvList.DataSource).Rows[j]["单位名称"].ToString() ==
                            newrow["单位名称"].ToString())
                        {
                            AppServer.ShowMsg_Warn("该单位已经接收，不能再次分发", "警告");
                            ASubmit = false;
                            return;
                        }
                    }
                    if (ASubmit)
                    {
                        ((DataTable)this.dgvList.DataSource).Rows.Add(newrow);
                        for (int i = 0; i < dgvList.Rows.Count; i++)
                            this.dgvList.Rows[i].Cells[1].Value = Convert.ToString(i + 1);
                        this.dgvList.GoToRowByIndex(-1);
                    }
                }
            }
        }

        private void btn删除_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            if (!AppServer.DialogMsg("是否确认要删除吗？")) return;
            //
            foreach (DataGridViewRow row in this.dgvList.SelectedRows)
            {
                this.dgvList.Rows.Remove(row);//一行从 Rows 集合中删除
            }
            for (int i = 0; i < dgvList.Rows.Count; i++)//重新生成申请序号
            {
                dgvList.Rows[i].Cells[1].Value = Convert.ToString(i + 1);
            }
            ((DataTable)this.dgvList.DataSource).AcceptChanges();//删除后要随时更新数据，否则出现错误（不能通过已删除的行访问该行的信息）
        }

    }
}
