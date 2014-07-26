using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using GCGL_Client.NET;

namespace GCGL_Client.OCC
{
    public partial class OCC_处置申请_Editor : Form
    {
        public OCC_处置申请_Editor()
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
            if (AppServer.LoginUnitType == 1)
                this.dgvList.Columns[5].Visible= false;
        }

        private void DataBinding_GridView(string ACardCode)
        {
            this.btn保存.Tag = ACardCode;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_OCC_处置申请();
                model.ExAction = "Card";
                model.申请编号 = ACardCode;
                DataSet db = AppServer.wcfClient.OCC_处置申请_List(ref model);
                if (db.Tables[0].Rows.Count > 0)//查询出来的第一个数据表
                {
                    TY.Helper.FormHelper.DataBinding_DataSourceToUI(db.Tables[0], this);
                }
                this.dgvList.DataSource = db.Tables[1];//第二个数据表(处置申请明细表)
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

        #region 增、改、查、打印

        public void Editor_Add()
        {
            this.Text = "车辆处置申报(新增)";
            this.Tag = "Add";
            DataBinding_GridView("");
        }

        public void Editor_Mod(string ACardCode)
        {
            this.Text = "车辆处置申报(修改)";
            this.Tag = "Mod";
            DataBinding_GridView(ACardCode);
        }

        public void Editor_See(string ACardCode, bool AEmebMode = false)
        {
            this.Text = "车辆处置申报(查看）";
            this.Tag = "Che";
            DataBinding_GridView(ACardCode);
            //
            this.txt申请原因.BackColor = SystemColors.Control;
            this.txt申请备注.Enabled = false;
            this.txt申请备注.BackColor = SystemColors.Control;
            this.txt申请原因.Enabled = false;
            this.btnAdd.Enabled = false;
            this.btnDel.Enabled = false;
            this.btn保存.Enabled = false;
            this.btn提交.Enabled = false;
            this.btnCancel.Text = "返回(ESC)";
            //嵌入式状态不显示工具栏
            this.pnlTool.Visible = !AEmebMode;
        }
       
        public void Editor_Print(string ACardCode)
        {
            this.Text = "车辆备案申请打印";
            this.Tag = "Prt";
            // 
            this.DataBinding_GridView(ACardCode);

            this.btnAdd.Visible = false;
            this.btnDel.Visible = false;
            this.btn保存.Visible = false;
            this.btn提交.Visible = false;
            this.btn附件查看.Visible = false;

            //
            this.lbl打印机.Visible = true;
            this.cbxSelectPrinter.Visible = true;

            this.btn打印.Visible = true;
            this.btnCancel.Text = "返回(&X)";
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
           using (var form = new OCC_处置申请_Editor_MX())
             {
                DataRow newrow = ((DataTable)this.dgvList.DataSource).NewRow();                   
                string[] str = new String[10];
                if (this.dgvList.Rows.Count>0)                
                for (int i = 0; i < dgvList.Rows.Count; i++)
                  {                       
                    str[i] = this.dgvList.Rows[i].Cells["资产编号"].Value.ToString();
                  }
               form.Editor_Add(newrow,str);
               if (form.ShowDialog() == DialogResult.OK)
                {
                  ((DataTable)this.dgvList.DataSource).Rows.Add(newrow);
                  for (int i = 0; i < dgvList.Rows.Count; i++)
                    {
                     dgvList.Rows[i].Cells[1].Value = Convert.ToString(i + 1);//序号
                    }
                 this.dgvList.GoToRowByIndex(-1);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            if (!AppServer.DialogMsg("是否确认要删除吗？")) return;
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

        private void PostData(Boolean ASubmit)
        {
            #region  控件验证
            if (this.txt申请原因.Text == "")
            {
                AppServer.ShowMsg("申请原因不能为空！", "提示");
                this.txt申请原因.Focus();
                return;
            }
            #endregion

            #region 提交数据
            if (this.dgvList.Rows.Count == 0) return;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_OCC_处置申请();
                model.ExAction = this.Tag.ToString();
                model.LoginUserCode = AppServer.LoginUserCode;
                model.单位编码 = AppServer.LoginUnitCode;
                model.申请编号 = this.btn保存.Tag.ToString();
                model.申请数量 = this.dgvList.Rows.Count;          
                TY.Helper.FormHelper.DataBinding_DataSourceToModel(this, model);
                model.MxDataStr = ((DataTable)this.dgvList.DataSource).ToXml("ar");

                //开始保存
               
                AppServer.wcfClient.OCC_处置申请_Edit(ref model);
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
                    AppServer.wcfClient.OCC_处置申请_Edit(ref model);
                    if (model.ExResult != 0)
                    {
                        AppServer.HideWaitForm();
                        AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                        return;
                    }
                }
            #endregion
                
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

        private void btn提交_Click(object sender, EventArgs e)
        {
            this.PostData(true);
        }

        private void btn附件查看_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            //
            string wCode = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index]["依据文件编码"].ToString();
            if (wCode == null) return;
            using (var form = new NET_附件管理())
            {
                form.Editor_See(wCode);
                form.ShowDialog();
            }
        }

        private void btn提交_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)         //Ctrl+S
            {
                this.btn保存_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.J && e.Modifiers == Keys.Control)         //Ctrl+j
            {
                this.btn提交_Click(this, EventArgs.Empty);
            }
        }
        public Boolean CZSP;//是否处置审批
        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            
            if (AppServer.LoginUserType == 3)
            {
                if (CZSP == false) return;
                using (var form = new OCC_处置申请_XG())
                {
                    form.Editor_XG(row);                
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        DataBinding_GridView(row["申请编号"].ToString());
                    }
                }
            }
            else
            {
                using (var form = new OCC_处置申请_Editor_MX())
                {
                    form.Editor_Mod(row, this.btn保存.Enabled);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        //更新数据
                        ((DataTable)this.dgvList.DataSource).AcceptChanges();
                        this.dgvList.GoToRowByIndex(this.dgvList.CurrentRow.Index);
                    }
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
            if (this.dgvList.Rows.Count == 0) return;
            //
            OCC_处置申请_Print prtForm = null;
            int iRowCount = 0;
            foreach (DataRow row in ((DataTable)this.dgvList.DataSource).Rows)
            {
                if (iRowCount % 5 == 0)
                {
                    if (prtForm != null)
                    {
                        prtForm.Print(this.cbxSelectPrinter.Text);
                        prtForm = null;
                    }
                    prtForm = new OCC_处置申请_Print();
                }
                //
                if (prtForm != null)
                {
                    prtForm.lbl申报单位.Text = AppServer.LoginUnitName;
                    prtForm.lbl申报日期.Text = string.Format("{0:yyyy年MM月dd日}", DateTime.Today);

                    prtForm.AddRow(row);
                }
                //
                iRowCount++;
            }
            //打印最后一页或不足满页的余行
            if (prtForm != null)
            {
                prtForm.Print(this.cbxSelectPrinter.Text);
                prtForm = null;
            }
        }
       
    }
}
