using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GLG.Common;
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

        #region 增、改、查

        public void Editor_Add()
        {
            this.Text = "公车处置申请";
            this.Tag = "Add";
            DataBinding_GridView("");
        }

        public void Editor_Mod(string ACardCode)
        {
            this.Text = "处置申请(修改)";
            this.Tag = "Mod";
            DataBinding_GridView(ACardCode);
        }

        public void Editor_See(string ACardCode)
        {
            this.Text = "处置申请(查看）";
            this.Tag = "Che";
            DataBinding_GridView(ACardCode);

            this.btnAdd.Enabled = false;
            this.btnDel.Enabled = false;
            this.btnMod.Enabled = false;
            this.btn保存.Enabled = false;
            this.btn提交.Enabled = false;
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
                    str[i] = this.dgvList.Rows[i].Cells[1].Value.ToString();
                  }
               form.Editor_Add(newrow,str);
               if (form.ShowDialog() == DialogResult.OK)
                {
                  ((DataTable)this.dgvList.DataSource).Rows.Add(newrow);
                  for (int i = 0; i < dgvList.Rows.Count; i++)
                    {
                     dgvList.Rows[i].Cells[0].Value = Convert.ToString(i + 1);
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

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (this.dgvList.Rows.Count == 0) return;
            DataRow row = ((DataTable)this.dgvList.DataSource).Rows[this.dgvList.CurrentRow.Index];
            if (row == null) return;
            using (var form = new OCC_处置申请_Editor_MX())
            {
                form.Editor_Mod(row);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //更新数据
                    ((DataTable)this.dgvList.DataSource).AcceptChanges();
                    this.dgvList.GoToRowByIndex(this.dgvList.CurrentRow.Index);
                }
            }
        }

        private void PostData(Boolean ASubmit)
        {                       
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
                AppServer.ShowWaitForm();
                AppServer.DataImport("正在保存数据，请稍等...", 20, 100, true);
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
    }
}
