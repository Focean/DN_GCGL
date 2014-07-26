using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.Main;
using TY.Helper;

namespace GCGL_Client.NET
{
    public partial class NET_审批中心 : Form
    {
        public NET_审批中心()
        {
            InitializeComponent();
            //
            AppServer.SetGridViewStyle(this.dgvList);
            //
            if (AppServer.LoginUnitType <= 2)
            {
                this.txt选择单位.Text = AppServer.LoginUnitName;
                this.txt选择单位.Tag = AppServer.LoginUnitCode;
            }
            else
            {
                this.txt选择单位.Text = "所有单位";
                this.txt选择单位.Tag = "";
            }
        }

        private void NET_审批中心_Load(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);            
        }

        private void DataBinding_GridView(int ARowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;

                var model = new Ref_WS_GCGL.DataType_NET_审批();
                model.ExAction = "List";
                model.LoginUserCode = AppServer.LoginUserCode;
                model.单位编码 = this.txt选择单位.Tag.ToString();                
                if (this.chk申请日期.Checked)
                {
                    model.开始时间 = this.dtp开始时间.Value;
                    model.结束时间 = this.dtp结束时间.Value;
                }
                model.仅未审批 = this.chk仅未审批.Checked;
                this.btn审批.Enabled = this.chk仅未审批.Checked;
                //
                DataSet db = AppServer.wcfClient.NET_审批_List(ref model);
                this.dgvList.DataSource = db.Tables[0];
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

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView dgv = (DataGridView)sender;
            //if (dgv.Columns[e.ColumnIndex].Name == "待办处理事项_配置申请数量")
            //{
            //    OCC_配置申请 fMdiForm1 = new OCC_配置申请();
            //    fMdiForm1.MdiParent = this.MdiParent;
            //    fMdiForm1.Show();
            //}
            //else if (dgv.Columns[e.ColumnIndex].Name == "待办处理事项_处置申请数量")
            //{
            //    OCC_处置申请 fMdiForm2 = new OCC_处置申请();
            //    fMdiForm2.MdiParent = this.MdiParent;
            //    fMdiForm2.Show();
            //}
        }

        private void btn审批_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            //
            //if (this.dgvList.CurrentRow.Cells["exFinished"].Value.ToBooleanDef())
            //{
            //    AppServer.ShowMsg_Warn("当前申请已完成审批，不需要再处理了！");
            //    return;
            //}
            //
            using (var form = new OCC_网上审批_Editor())
            {
                form.Editor_Mod(this.dgvList.CurrentRow.Cells["wfName"].Value.ToString(),
                     this.dgvList.CurrentRow.Cells["exCode"].Value.ToString(),
                     this.dgvList.CurrentRow.Cells["单位名称"].Value.ToString(),
                     this.dgvList.CurrentRow.Cells["exWaitState"].Value.ToString());

                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DataBinding_GridView(0);
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn打印_Click(object sender, EventArgs e)
        {
            //AppServer.ShowMsg(this.dgvList.CurrentRow.Cells["exFinished"].Value.ToIntegerDef().ToString());
        }

       }
}
