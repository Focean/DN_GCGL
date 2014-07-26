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
    public partial class OCC_批量申请_Editor_FP : Form
    {
        public OCC_批量申请_Editor_FP()
        {
            InitializeComponent();
        }

        private DataRow FDataRow;
        public void Editor_Add(DataRow row)
        {
            this.Text = "车辆分发明细(添加)";
            this.Tag = "Add";
            //
            FDataRow = row;
        }

        private void btn确定_Click(object sender, EventArgs e)
        {
            #region 控件验证
            if (this.txt预算单位名称.Text.Trim().ToString() == "")
            {
                AppServer.ShowMsg("预算单位名称不能为空！", "提示");
                this.txt预算单位名称.Focus();
                return;
            }
            if (this.nud分配数量.Value <= 0)
            {
                AppServer.ShowMsg("分配数量不能为0！", "提示");
                this.nud分配数量.Focus();
                return;
            }
            #endregion

            //开始赋值给Datarow   
            if (FDataRow == null) return;
            TY.Helper.FormHelper.DataBinding_FormToDataRow(this, FDataRow);
            FDataRow["单位编码"] = this.txt预算单位名称.Tag.ToString();
            FDataRow["单位名称"] = this.txt预算单位名称.Text;
            FDataRow["分配数量"] = this.nud分配数量.Value;
            FDataRow["接收数量"] = this.nud分配数量.Value;
            this.DialogResult = DialogResult.OK;         
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //快捷键设置
        private void OCC_批量申请_Editor_FP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)         //Ctrl+S
            {
                this.btn确定_Click(this, EventArgs.Empty);
            }
        }

        private void btn添加单位_Click(object sender, EventArgs e)
        {
            using (var form = new GCGL_Client.Main.Man_单位_Select())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (!AppServer.WcfService_Open()) return;
                        this.txt预算单位名称.Text = form.SelectUnitName;
                        this.txt预算单位名称.Tag = form.SelectUnitCode;
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
                }
            }
        }
    }
}
