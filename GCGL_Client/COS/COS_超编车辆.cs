using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Common;
using TY.Helper;
using GCGL_Client.OCC;

namespace GCGL_Client.COS
{
    public partial class COS_超编车辆 : Form
    {
        public COS_超编车辆()
        {
            InitializeComponent();
            //
            this.btn第一页.Enabled = AppServer.Sys_Param.PageRows > 0;
            this.btn上一页.Enabled = AppServer.Sys_Param.PageRows > 0;
            this.btn下一页.Enabled = AppServer.Sys_Param.PageRows > 0;
            this.btn末一页.Enabled = AppServer.Sys_Param.PageRows > 0;
            this.nudPageIndex.Enabled = AppServer.Sys_Param.PageRows > 0;
            //
            this.dtp开始时间.Value = DateTime.Today.AddDays(1 - DateTime.Today.DayOfYear);
            this.dtp结束时间.Value = DateTime.Today;

            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            //
            if (AppServer.LoginUnitIsYSDW() || AppServer.LoginUnitIsGWC())
            {
                this.btn预算单位.Visible = false;
                this.txt单位编码.Text = AppServer.LoginUnitName;
                this.txt单位编码.Tag = AppServer.LoginUnitCode;
                this.chk包含下级.Visible = false;
                this.dgvList.Columns["单位名称"].Visible = false;
                this.btn导入.Visible = false;
                this.btn处置情况.Visible = false;
                this.btn修改.Visible = false;
            }
            if (AppServer.LoginUnitIsCZT())
            {
                this.btn新增.Visible = false;            
            }
            //
            DataBinding_GridView(0);
        }
        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                model.ExAction = "List";
                model.开始时间 = this.dtp开始时间.Value;
                model.结束时间 = this.dtp结束时间.Value;
                model.PageRows = AppServer.Sys_Param.PageRows;
                model.PageIndex = this.nudPageIndex.Value.ToIntegerDef(1);
                if (AppServer.LoginUnitIsYSDW() || AppServer.LoginUnitIsGWC())
                {
                    model.单位编码 = AppServer.LoginUnitCode;
                }
                else if(AppServer.LoginUnitIsCZT())
                {
                    if (this.txt单位编码.Tag != null)
                    {
                        model.单位编码 = this.txt单位编码.Tag.ToString();
                        model.包含下级 = this.chk包含下级.Checked;
                    }
                    else
                        model.单位编码 = AppServer.LoginUnitCode;
                }
                DataSet db = AppServer.wcfClient.COS_车辆超编_List(ref model);

                if (AppServer.Sys_Param.PageRows > 0)
                {
                    this.lblDataInfo.Text = string.Format("共 {0} 条记录，每页 {1} 条，共 {2} 页", model.RowsCount, model.PageRows, model.PageCount);
                    this.nudPageIndex.Maximum = model.PageCount == 0 ? 1 : model.PageCount;
                }
                else
                {
                    this.lblDataInfo.Text = string.Format("共 {0} 条记录", model.RowsCount);
                }
                this.dgvList.DataSource = db.Tables[0];
                this.dgvList.GoToRowByIndex(ACurrRowIndex);
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
            this.DialogResult = DialogResult.OK;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataBinding_GridView(0);
        }

        private void btn预算单位_Click(object sender, EventArgs e)
        {
            AppServer.ReadAppCommon(2);
            AppServer.Frm单位信息.SetShowParam(this.txt单位编码, 0);
            AppServer.Frm单位信息.ShowDialog();
            if (AppServer.Frm单位信息.DialogResult == DialogResult.OK)
            {
                this.txt单位编码.Tag = AppServer.Frm单位信息.SelectNodeID;
                this.txt单位编码.Text = AppServer.Frm单位信息.SelectNodeTitle;
            }
            AppServer.Frm单位信息.Hide();
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            using (var form = new OCC_公车库存_Select())
            {
                form.select_超编(AppServer.LoginUnitCode);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //ZCBH = form.SelectPropertyCode;
                    //this.txt资产名称.Text = form.SelectPropertyName;
                    //this.txt资产名称.Tag = form.SelectPropertyCode;
                    //ZCview(ZCBH);
                    this.DataBinding_GridView(0);
                }
            }
        }

        private void btn导入_Click(object sender, EventArgs e)
        {
            using (var form = new COS_超编车辆_导入())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据     
                    this.DataBinding_GridView(0);
                }
            }
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn导出_Click(object sender, EventArgs e)
        {
            DataToExcel.DataGridViewToExcelApp(this.dgvList, this.lblTitle.Text);
        }

        private void btn处置情况_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (row["超编状态"].ToString() != "" || row["超编状态"].ToString() != null)
            {
                using (var form = new COS_超编车辆_处置())
                {
                    form.Add(row);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        this.DataBinding_GridView(0);
                    }
                }
            }
        }
        #region 分页
        private void nudPageIndex_ValueChanged(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
        }

        private void btn第一页_Click(object sender, EventArgs e)
        {
            this.nudPageIndex.Value = 1;
        }

        private void btn上一页_Click(object sender, EventArgs e)
        {
            if (this.nudPageIndex.Value <= 1) return;
            this.nudPageIndex.Value = this.nudPageIndex.Value - 1;
        }

        private void btn下一页_Click(object sender, EventArgs e)
        {
            if (this.nudPageIndex.Value >= this.nudPageIndex.Maximum) return;
            this.nudPageIndex.Value = this.nudPageIndex.Value + 1;
        }

        private void btn末一页_Click(object sender, EventArgs e)
        {
            this.nudPageIndex.Value = this.nudPageIndex.Maximum;
        }
        #endregion 

        private void btn删除_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            if (AppServer.DialogMsg("是否确认删除？", " "))
            {
                var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                model.ExAction = "Del";
                model.超编编码 = row["超编编码"].ToString();
                model.资产编号 = row["资产编号"].ToString();
                model.LoginUserCode = AppServer.LoginUserCode;
                if (!AppServer.WcfService_Open()) return;
                AppServer.wcfClient.COS_车辆超编_Edit(ref model);
                if (model.ExResult == 0)
                {
                    this.DataBinding_GridView(0);
                }
                else
                    AppServer.ShowMsg_Error(model.ErrorMsg, "错误");
            }
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            using (var form = new COS_超编车辆_Editor())
            {
                form.Editor_Mod(row);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    this.DataBinding_GridView(this.dgvList.CurrentRow.Index);
                }
            }
        }

        private void dgvList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (AppServer.LoginUnitIsCZT()) this.btn修改.PerformClick();
        }
    }
}
