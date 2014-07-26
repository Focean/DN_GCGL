using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using TY.Common;
using System.Globalization;

namespace GCGL_Client.FZB
{
    public partial class FZB_基础数据 : Form
    {
        public FZB_基础数据()
        {
            InitializeComponent();
            //
            this.dtp开始时间.Value = DateTime.Today.AddDays(2 - DateTime.Today.DayOfYear);
            this.dtp结束时间.Value = DateTime.Today;       
            //
            //设置表格样式
            AppServer.SetGridViewStyle(this.dgvList);
            if (AppServer.LoginUnitIsYSDW())
            {
                this.txt单位编码.Text = AppServer.LoginUnitName;
                this.txt单位编码.ReadOnly = true;
            }
            DataBinding_GridView(0);
            //
            this.btn第一页.Enabled = AppServer.Sys_Param.PageRows > 0;
            this.btn上一页.Enabled = AppServer.Sys_Param.PageRows > 0;
            this.btn下一页.Enabled = AppServer.Sys_Param.PageRows > 0;
            this.btn末一页.Enabled = AppServer.Sys_Param.PageRows > 0;
            this.nudPageIndex.Enabled = AppServer.Sys_Param.PageRows > 0;
            
        }

        private void DataBinding_GridView(int ACurrRowIndex)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                model.ExAction = "List_D";
                model.开始时间 = this.dtp开始时间.Value;
                model.结束时间 = this.dtp结束时间.Value;
                model.LoginUserCode = AppServer.LoginUserCode;
                model.PageRows = AppServer.Sys_Param.PageRows;
                model.PageIndex = this.nudPageIndex.Value.ToIntegerDef(1);
                model.单位名称=this.txt单位编码.Text.Trim();
                DataSet db = AppServer.wcfClient.OCC_公车入库_List(ref model);
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
        }

        private void btn导入_Click(object sender, EventArgs e)
        {
            using (var form = new FZB_基础数据_Editor())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据     
                    this.DataBinding_GridView(0);
                }
            }
        }
        private void btn删除_Click(object sender, EventArgs e)
        {   
            if (this.dgvList.Rows.Count == 0) return;
            if (AppServer.DialogMsg("是否确认删除？", " "))
            {
                foreach (DataGridViewRow dr in this.dgvList.SelectedRows)
                {
                    if (dr.Cells["exWaitState2"].Value.ToString() == "等待提交" || dr.Cells["exWaitState2"].Value.ToString() == "等待重新提交")
                    {
                        var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                        model.ExAction = "Del";
                        model.入库单编码 = dr.Cells["入库单编码"].Value.ToString();
                        model.LoginUserCode = AppServer.LoginUserCode;
                        if (!AppServer.WcfService_Open()) return;
                        AppServer.wcfClient.OCC_公车入库_Edit(ref model);
                        if (model.ExResult != 0)
                        {
                            AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                            return;
                        }
                        this.dgvList.Rows.Remove(dr);
                    }
                    else
                    {
                        AppServer.ShowMsg_Warn("该申请已被审核，无法删除！", "警告");
                        return;
                    }
                }
            }
          this.DataBinding_GridView(0); 
        }

        private void btnQuery_Click(object sender, EventArgs e)
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

        private void nudPageIndex_ValueChanged(object sender, EventArgs e)
        {
            this.DataBinding_GridView(0);
        }

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
