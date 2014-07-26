using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using System.Globalization;
using GCGL_Client.Main;
namespace GCGL_Client.OCC
{
    public partial class OCC_配置申请_Editor : Form
    {

        private int 公务CarNum;  //编制数    
        private int 执法CarNum;
        private int 特种CaNum;
        public OCC_配置申请_Editor()
        {
            InitializeComponent();
            //
            AppServer.SetGridViewStyle(this.dgvList);
            //获取打印机列表
            try
            {
                this.cbxSelectPrinter.Items.Clear();
                foreach (string iprt in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                    this.cbxSelectPrinter.Items.Add(iprt);
                this.cbxSelectPrinter.Text = (new System.Drawing.Printing.PrintDocument()).PrinterSettings.PrinterName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取打印机配置时出现异常错误！\n 错误信息：" + ex.Message);
                return;
            }  
        }

        public void Editor_Add()
        {
            this.Text = "车辆配置申报(新增)";
            this.Tag = "Add";
            //
            this.lbl单位名称.Text = AppServer.LoginUnitName;
            //
            if (AppServer.LoginUnitIsYSDW())
            {
                Get_Freeze(AppServer.LoginUnitCode);
           //
                GetNum(AppServer.LoginUnitCode);
            }
            //如果登陆单位是非预算单位，车辆编制数和实有数、冻结数均为空！
            else
            {
                this.lbl公务用车编制数.Text = "";
                this.lbl其中执法执勤用车编制数.Text = "";
                this.lbl公务用车实有数.Text = "";
                this.lbl其中执法执勤用车实有数.Text = "";
                this.lbl公务冻结数.Text = "";
            }
            //
            this.DataBinding_GridView("");
        }

        public void Editor_Mod(string ACardCode)
        {
            this.Text = "车辆配置申报(修改)";
            this.Tag = "Mod";
            //
            this.DataBinding_GridView(ACardCode);
            //预算单位
            if (AppServer.LoginUnitIsYSDW())
            {
                Get_Freeze(AppServer.LoginUnitCode);
                //
                GetNum(AppServer.LoginUnitCode);
            }
            else
            {
                Get_Freeze(this.dgvList.Rows[0].Cells["预算单位编码"].Value.ToString());
                GetNum(this.dgvList.Rows[0].Cells["预算单位编码"].Value.ToString());
            } 
           
        }

        public void Editor_See(string ACardCode, bool AEmebMode = false)
        {
            this.Text = "车辆配置申报(查看）";
            this.Tag = "See";
            // 
            this.DataBinding_GridView(ACardCode);

            //预算单位
            if (AppServer.LoginUnitType == 1)
            {
                Get_Freeze(AppServer.LoginUnitCode);
                GetNum(AppServer.LoginUnitCode);
            }
            else
            {
                Get_Freeze(this.dgvList.Rows[0].Cells["预算单位编码"].Value.ToString());
                GetNum(this.dgvList.Rows[0].Cells["预算单位编码"].Value.ToString());
            }
            //
           
            this.btn删除.Enabled = false;
            this.btn新增.Enabled = false;
            this.txt申请原因.BackColor = SystemColors.Control;
            this.txt申请原因.Enabled = false;
            this.txt申请备注.BackColor = SystemColors.Control;
            this.txt申请备注.Enabled = false; 
            this.btn保存.Enabled = false;
            this.btn提交.Enabled = false;
            this.btn取消.Text = "返回(&X)";

            //嵌入式状态不显示工具栏
            this.pnlTool.Visible = !AEmebMode;
        }
        private string Fstrc=null;//申请编号
        public void Editor_Print(string ACardCode)
        {
            this.Text = "车辆备案申请打印";
            this.Tag = "Prt";
            Fstrc = ACardCode;
            // 
            this.DataBinding_GridView(ACardCode);

            //预算单位
            if (AppServer.LoginUnitType == 1)
            {
                Get_Freeze(AppServer.LoginUnitCode);
                GetNum(AppServer.LoginUnitCode);
            }
            else
            {
                Get_Freeze(this.dgvList.Rows[0].Cells["预算单位编码"].Value.ToString());
                GetNum(this.dgvList.Rows[0].Cells["预算单位编码"].Value.ToString());
            }
            //
            this.txt申请原因.BackColor = SystemColors.Control;
            this.txt申请原因.Enabled = false;
            this.txt申请备注.BackColor = SystemColors.Control;
            this.txt申请备注.Enabled = false; 
            this.btn删除.Visible = false;
            this.btn新增.Visible = false;
            this.btn保存.Enabled = false;
            this.btn提交.Enabled = false;
            this.btn取消.Text = "返回(ESC)";
            this.btn附件查看.Visible = false;

            //
            this.lbl打印机.Visible = true;
            this.cbxSelectPrinter.Visible = true;

            this.btn打印.Visible = true;
            this.btn取消.Text = "返回(&X)";
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
                    this.lbl特种专业用车冻结数.Text=tbl.Rows[0][2].ToString();
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

        private void DataBinding_GridView(string ACardCode)
        {
            this.btn保存.Tag = ACardCode;
            //
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_配置申请();
                model.ExAction = "Card";
                model.申请编号 = ACardCode;
                DataSet db = AppServer.wcfClient.OCC_配置申请_List(ref model);
                //
                if (db.Tables[0].Rows.Count > 0)//查询出来的第一个数据表
                {
                    TY.Helper.FormHelper.DataBinding_DataSourceToUI(db.Tables[0], this);//调用函数赋值
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

        #region 功能按钮

        private void btn新增_Click(object sender, EventArgs e)
        {           
            int C_公务CarNum = 公务CarNum;
            int C_执法CarNum;
            if (特种CaNum < 0)
                C_执法CarNum = 执法CarNum;
            else
                C_执法CarNum = 执法CarNum + 特种CaNum;
            if (this.dgvList.Rows.Count != 0)
            {               
                for (int i = 0; i < dgvList.Rows.Count; i++)
                {
                    if (dgvList.Rows[i].Cells["车辆类型编码"].Value.ToString() == "0301")
                        C_执法CarNum -= this.dgvList.Rows[i].Cells["数量"].Value.ToIntegerDef();
                   else
                        if(dgvList.Rows[i].Cells["车辆类型编码"].Value.ToString() != "0302")
                            C_公务CarNum -= this.dgvList.Rows[i].Cells["数量"].Value.ToIntegerDef();
                }
            }
            if (this.dgvList.Rows.Count >= 3)
            {
                AppServer.ShowMsg("根据有关规定，一次配置申请最多只能申请3条！", "提示");
                return;
            }
            C_执法CarNum -= lbl执法冻结数.Text.ToIntegerDef();
            C_公务CarNum -= lbl公务冻结数.Text.ToIntegerDef();           
            using (var form = new OCC_配置申请_Editor_MX())
            {
                DataRow newrow = ((DataTable)this.dgvList.DataSource).NewRow();
                form.Editor_Add(newrow, C_执法CarNum, C_公务CarNum);
                if (form.ShowDialog() == DialogResult.OK)
                {                  
                    ((DataTable)this.dgvList.DataSource).Rows.Add(newrow);
                    for (int i = 0; i < dgvList.Rows.Count; i++)                    
                    this.dgvList.Rows[i].Cells[1].Value = Convert.ToString(i + 1);                      
                    this.dgvList.GoToRowByIndex(-1);
                }
            }
        }
        
        private void btn修改_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            //
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            DataRow newrow = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            int C_公务CarNum = 公务CarNum;
            int C_执法CarNum;
            if (特种CaNum < 0)
                C_执法CarNum = 执法CarNum;
            else
                C_执法CarNum = 执法CarNum + 特种CaNum;
            for (int i = 0; i < dgvList.Rows.Count; i++)
            {
                if (dgvList.Rows[i].Cells["车辆类型编码"].Value.ToString() == "0301")
                    C_执法CarNum -= this.dgvList.Rows[i].Cells["数量"].Value.ToIntegerDef();
                else
                    if (dgvList.Rows[i].Cells["车辆类型编码"].Value.ToString() != "0302")
                        C_公务CarNum -= this.dgvList.Rows[i].Cells["数量"].Value.ToIntegerDef();
            }
            if (row["车辆类型编码"].ToString() == "0301")
                C_执法CarNum += row["数量"].ToIntegerDef();
            else
                if (row["车辆类型编码"].ToString() != "0302")
                    C_公务CarNum += row["数量"].ToIntegerDef();
            //
            C_执法CarNum -= lbl执法冻结数.Text.ToIntegerDef();
            C_公务CarNum -= lbl公务冻结数.Text.ToIntegerDef();   
            using (var form = new OCC_配置申请_Editor_MX())
            {
                form.Editor_Mod(row, C_执法CarNum, C_公务CarNum,this.btn提交.Visible);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    ((DataTable)this.dgvList.DataSource).AcceptChanges();
                    this.dgvList.GoToRowByIndex(this.dgvList.CurrentRow.Index);
                }
            }
        }
        
        private void btn删除_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            if (!AppServer.DialogMsg("是否确认要删除吗？")) return;
            //
            foreach(DataGridViewRow row in this.dgvList.SelectedRows)
            {
                this.dgvList.Rows.Remove(row);//一行从 Rows 集合中删除
            }
            for (int i = 0; i < dgvList.Rows.Count; i++)//重新生成申请序号
            {
                dgvList.Rows[i].Cells[1].Value = Convert.ToString(i + 1);
            }
            ((DataTable)this.dgvList.DataSource).AcceptChanges();//删除后要随时更新数据，否则出现错误（不能通过已删除的行访问该行的信息）
        }

        private void PostData(Boolean ASubmit)
        {
            if (this.dgvList.Rows.Count == 0)
            {
                AppServer.ShowMsg("当前没有申请任何车辆，无法提交！", "提示");                
                return;
            }
            if (this.txt申请原因.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("申请原因不能为空！", "提示");
                this.txt申请原因.Focus();
                return;
            }
             
            if (this.dgvList.Rows.Count == 0) return;
            //
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_配置申请();
                model.ExAction = this.Tag.ToString();
                model.LoginUserCode = AppServer.LoginUserCode;
                model.单位编码 = AppServer.LoginUnitCode;
                model.申请编号 = this.btn保存.Tag.ToString();
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.MxDataStr = ((DataTable)this.dgvList.DataSource).ToXml("ar");                  
                //开始保存
                AppServer.ShowWaitForm();
                AppServer.DataImport("正在保存数据，请稍等...", 20, 100, true);
                AppServer.wcfClient.OCC_配置申请_Edit(ref model);
                //
                if (model.ExResult != 0)
                {
                    AppServer.HideWaitForm();
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                //此时记住已保存成功了，如果是新增状态可变为修改状态了，防止提交不成功后重复新增数据
                if (this.Tag.ToString() == "Add")
                {
                    this.Tag = "Mod";
                    this.btn保存.Tag = model.申请编号;
                }
                //
                if (ASubmit)
                {
                    model.ExAction = "Submit";
                    model.申请编号 = this.btn保存.Tag.ToString();
                    AppServer.wcfClient.OCC_配置申请_Edit(ref model);
                    if (model.ExResult != 0)
                    {
                        AppServer.HideWaitForm();
                        AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                        return;
                    }
                }
                AppServer.DataImport("数据保存已成功完成！", 100, 100, false);
                AppServer.HideWaitForm();
                //
       
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
     
        private void btn保存_Click(object sender, EventArgs e)
        {
            this.PostData(false);
        }

        private void btn保存并提交_Click(object sender, EventArgs e)
        {
            if ((this.lbl公务用车编制数.Text == "0" || this.lbl公务用车编制数.Text == "") && (this.lbl其中执法执勤用车编制数.Text == "0" || this.lbl其中执法执勤用车编制数.Text == "") && (this.lbl特种专业技术用车编制数.Text == "0" || this.lbl特种专业技术用车编制数.Text == ""))
            {
                AppServer.ShowMsg("现行编制数为0，请先申请单位公务用车编制数，再进行配置申请！", "提示");
                this.txt申请原因.Focus();
                return;
            }
            this.PostData(true);
        }

        #endregion

        private void lbl公务用车实有数_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (var form = new OCC_公车库存_List())
            {
                
                if (AppServer.LoginUnitType == 1)
                    form.Property_List(AppServer.LoginUnitCode, "01");
                else
                   form.Property_List(this.dgvList.Rows[0].Cells["预算单位编码"].Value.ToString(), "01");

                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void lbl其中执法执勤用车实有数_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (var form = new OCC_公车库存_List())
            {
                
                if (AppServer.LoginUnitType == 1)
                    form.Property_List(AppServer.LoginUnitCode, "0301");
                else
                   form.Property_List(this.dgvList.Rows[0].Cells["预算单位编码"].Value.ToString(), "0301");

                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void lbl特种专业技术用车实有数_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (var form = new OCC_公车库存_List())
            {

                if (AppServer.LoginUnitType == 1)
                    form.Property_List(AppServer.LoginUnitCode, "0302");
                else
                    form.Property_List(this.dgvList.Rows[0].Cells["预算单位编码"].Value.ToString(), "0302");

                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void OCC_配置申请_Editor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)         //Ctrl+S
            {
                this.btn保存_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.J && e.Modifiers == Keys.Control)         //Ctrl+J
            {
                this.btn保存并提交_Click(this, EventArgs.Empty);
            }
        }

        private void btn附件查看_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            //
            if (this.dgvList.CurrentRow.Cells["依据文件编码"].Value.ToString() == "") return;
            //
            using (var form = new NET.NET_附件管理())
            {
                form.Editor_See(this.dgvList.CurrentRow.Cells["依据文件编码"].Value.ToString());
                form.ShowDialog();
            }
        }

        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            //
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            DataRow newrow = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            int C_公务CarNum = 公务CarNum;
            int C_执法CarNum;
            if (特种CaNum < 0)
                C_执法CarNum = 执法CarNum;
            else
                C_执法CarNum = 执法CarNum + 特种CaNum;
            for (int i = 0; i < dgvList.Rows.Count; i++)
            {
                if (dgvList.Rows[i].Cells["车辆类型编码"].Value.ToString() == "0301")
                    C_执法CarNum -= this.dgvList.Rows[i].Cells["数量"].Value.ToIntegerDef();
                else
                    if (dgvList.Rows[i].Cells["车辆类型编码"].Value.ToString() != "0302")
                        C_公务CarNum -= this.dgvList.Rows[i].Cells["数量"].Value.ToIntegerDef();
            }
            if (row["车辆类型编码"].ToString() == "0301")
                C_执法CarNum += row["数量"].ToIntegerDef();
            else
                if (row["车辆类型编码"].ToString() != "0302")
                    C_公务CarNum += row["数量"].ToIntegerDef();
            //
            C_执法CarNum -= lbl执法冻结数.Text.ToIntegerDef();
            C_公务CarNum -= lbl公务冻结数.Text.ToIntegerDef();
            using (var form = new OCC_配置申请_Editor_MX())
            {

                form.Editor_Mod(row, C_执法CarNum, C_公务CarNum, this.btn提交.Enabled);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    ((DataTable)this.dgvList.DataSource).AcceptChanges();
                    this.dgvList.GoToRowByIndex(this.dgvList.CurrentRow.Index);
                }
            }
        }

        private void btn打印_Click(object sender, EventArgs e)
        {
            this.PrintForm();
            //
            this.DialogResult = DialogResult.OK;
        }
        public void PrintForm()
        {
            DataTable table0 = null;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var mdl = new Ref_WS_GCGL.DataType_OCC_配置申请();
                mdl.ExAction = "Card";
                mdl.申请编号 = Fstrc;
                DataSet db = AppServer.wcfClient.OCC_配置申请_List(ref mdl);
                table0 = db.Tables[0];
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
            using (var prtForm = new OCC_配置申请_Prt())
            {
                prtForm.lbl申购单位.Text = this.lbl单位名称.Text;
                prtForm.lbl组织代码证号.Text = table0.Rows[0]["组织代码证号"].ToString();
                prtForm.lbl日期.Text = string.Format("{0:yyyy年MM月dd日}", Convert.ToDateTime(table0.Rows[0]["创建时间"].ToString()));
                prtForm.lbl单位性质.Text = table0.Rows[0]["单位性质名称"].ToString();
                prtForm.lbl级别.Text = table0.Rows[0]["级别"].ToString();
                prtForm.lbl一般公务用车编制数.Text = this.lbl公务用车编制数.Text.Trim();
                prtForm.lbl执法执勤用车编制数.Text = this.lbl其中执法执勤用车编制数.Text.Trim();
                prtForm.lbl一般公务用车实有数.Text = this.lbl公务用车实有数.Text.Trim();
                prtForm.lbl执法执勤用车实有数.Text = this.lbl其中执法执勤用车实有数.Text.Trim();
                prtForm.lbl经办人.Text = AppServer.LoginUnitName;
                prtForm.lbl联系电话.Text = "";//现在先手填
                prtForm.lbl备注.Text = this.txt申请备注.Text.Trim();

                prtForm.lbl车辆品牌1.Text = this.dgvList.Rows[0].Cells["车辆品牌"].Value.ToString();
                prtForm.lbl型号1.Text = this.dgvList.Rows[0].Cells["型号"].Value.ToString();
                prtForm.lbl车辆类型1.Text = this.dgvList.Rows[0].Cells["车辆类型名称"].Value.ToString();
                prtForm.lbl排气量1.Text = this.dgvList.Rows[0].Cells["排气量"].Value.ToString();
                prtForm.lbl座位数1.Text = this.dgvList.Rows[0].Cells["座位数"].Value.ToString();
                prtForm.lbl资金来源1.Text = "";//现在先手填
                prtForm.lbl价格1.Text = string.Format("{0:0.00}", Convert.ToDecimal(this.dgvList.Rows[0].Cells["价格"].Value.ToString()));
                prtForm.lbl数量1.Text = this.dgvList.Rows[0].Cells["数量"].Value.ToString();

                prtForm.lbl车辆品牌2.Text = "";
                prtForm.lbl型号2.Text = "";
                prtForm.lbl车辆类型2.Text = "";
                prtForm.lbl排气量2.Text = "";
                prtForm.lbl座位数2.Text = "";
                prtForm.lbl资金来源2.Text = "";
                prtForm.lbl价格2.Text = "";
                prtForm.lbl数量2.Text = "";

                prtForm.lbl车辆品牌3.Text = "";
                prtForm.lbl型号3.Text = "";
                prtForm.lbl车辆类型3.Text = "";
                prtForm.lbl排气量3.Text = "";
                prtForm.lbl座位数3.Text = "";
                prtForm.lbl资金来源3.Text = "";
                prtForm.lbl价格3.Text = "";
                prtForm.lbl数量3.Text = "";


                if (this.dgvList.Rows.Count > 1)
                {
                    prtForm.lbl车辆品牌2.Text = this.dgvList.Rows[1].Cells["车辆品牌"].Value.ToString();
                    prtForm.lbl型号2.Text = this.dgvList.Rows[1].Cells["型号"].Value.ToString();
                    prtForm.lbl车辆类型2.Text = this.dgvList.Rows[1].Cells["车辆类型名称"].Value.ToString();
                    prtForm.lbl排气量2.Text = this.dgvList.Rows[1].Cells["排气量"].Value.ToString();
                    prtForm.lbl座位数2.Text = this.dgvList.Rows[1].Cells["座位数"].Value.ToString();
                    prtForm.lbl资金来源2.Text = "";//现在先手填
                    prtForm.lbl价格2.Text = string.Format("{0:0.00}", Convert.ToDecimal(this.dgvList.Rows[1].Cells["价格"].Value.ToString()));
                    prtForm.lbl数量2.Text = this.dgvList.Rows[1].Cells["数量"].Value.ToString();
                    if (this.dgvList.Rows.Count == 3)
                    {
                        prtForm.lbl车辆品牌3.Text = this.dgvList.Rows[2].Cells["车辆品牌"].Value.ToString();
                        prtForm.lbl型号3.Text = this.dgvList.Rows[2].Cells["型号"].Value.ToString();
                        prtForm.lbl车辆类型3.Text = this.dgvList.Rows[2].Cells["车辆类型名称"].Value.ToString();
                        prtForm.lbl排气量3.Text = this.dgvList.Rows[2].Cells["排气量"].Value.ToString();
                        prtForm.lbl座位数3.Text = this.dgvList.Rows[2].Cells["座位数"].Value.ToString();
                        prtForm.lbl资金来源3.Text = "";//现在先手填
                        prtForm.lbl价格3.Text = string.Format("{0:0.00}", Convert.ToDecimal(this.dgvList.Rows[2].Cells["价格"].Value.ToString()));
                        prtForm.lbl数量3.Text = this.dgvList.Rows[2].Cells["数量"].Value.ToString();
                    }
                }
                
                prtForm.Print();
            }
        }
    }
}
