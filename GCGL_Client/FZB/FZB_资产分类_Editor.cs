using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GCGL_Client.FZB
{
    public partial class FZB_资产分类_Editor : Form
    {
        public FZB_资产分类_Editor()
        {
            InitializeComponent();
            try
            {
                if (!AppServer.WcfService_Open()) return;
                DataTable dt = AppServer.wcfClient.FZB_编码_List("车辆类型", AppServer.LoginAreaCode).Tables[0];
                if (dt.Rows.Count > 0)
                {                    
                    this.cbx车辆类型名称.DataSource = dt;
                    this.cbx车辆类型名称.DisplayMember = "车辆类型名称";
                    this.cbx车辆类型名称.ValueMember = "车辆类型编码";
                }
                DataTable dt1 = AppServer.wcfClient.FZB_编码_List("资产分类1", AppServer.LoginAreaCode).Tables[0];
                if (dt1.Rows.Count > 0)
                {
                    clb固定资产类别.DataSource = dt1;
                    clb固定资产类别.ValueMember = "资产分类编码";
                    clb固定资产类别.DisplayMember = "资产分类名称";
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

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn提交_Click(object sender, EventArgs e)
        {
            if (this.cbx车辆类型名称.Text == "" || this.cbx车辆类型名称.SelectedIndex == -1)
            {
                AppServer.ShowMsg_Error("所选的车辆类型不能为空！");
                return;
            }
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_FZB_编码();
                model.ExAction = "Clr";
                model.车辆类型编码 = this.cbx车辆类型名称.SelectedValue.ToString();                                                       
                AppServer.wcfClient.FZB_固定资产_Edit(ref model);
                foreach (DataRowView dr in clb固定资产类别.CheckedItems)
                {
                    model.ExAction = "Mod";                    
                    model.资产分类编码 = dr["资产分类编码"].ToString();                    
                    AppServer.wcfClient.FZB_固定资产_Edit(ref model);
                } 
                //
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
                }
                else
                    AppServer.ShowMsg("已保存当前<"+this.cbx车辆类型名称.Text+">新的固定资产分类对应！");
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
            }
            finally
            {
                AppServer.WcfService_Close();              
            }
            this.chk清空.Checked = false;
        }

        private void FZB_资产分类_Editor_KeyDown(object sender, KeyEventArgs e)
        {
            //单键 
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    btn取消_Click(this, EventArgs.Empty);
                    break;
            }

            // 组合键
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)         //Ctrl+s
            {
                btn提交_Click(this, EventArgs.Empty);
            }
        }

        private void chk清空_CheckedChanged(object sender, EventArgs e)
        {
            if (chk清空.Checked)
            {
                this.lbx固定资产类别.Items.Clear();
                for (int j = 0; j < clb固定资产类别.Items.Count; j++)
                    this.clb固定资产类别.SetItemChecked(j, false);
            }
            else
                this.ShowSelection();
        }

        private void clb固定资产类别_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chk清空.Checked = false;
            lbx固定资产类别.Items.Clear();
            for (int j = 0; j < clb固定资产类别.Items.Count; j++)
            {
                if (clb固定资产类别.GetItemChecked(j))
                {
                    string s = clb固定资产类别.GetItemText(clb固定资产类别.Items[j]);
                    lbx固定资产类别.Items.Add(s);
                }
            }
        }

        public void ShowSelection()
        {
            this.chk清空.Checked = false;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                DataTable dt = AppServer.wcfClient.FZB_固定资产_List("对应资产类别", this.cbx车辆类型名称.SelectedValue.ToString()).Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < clb固定资产类别.Items.Count; j++)
                    {
                        string s = clb固定资产类别.GetItemText(clb固定资产类别.Items[j]);
                        if (dt.Rows[i]["资产分类名称"].ToString() == s)
                        {
                            clb固定资产类别.SetItemChecked(j, true);
                            lbx固定资产类别.Items.Add(s);
                        }
                    }
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

        private void cbx车辆类型名称_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.lb资产分类列表.Text = "当前 <" + cbx车辆类型名称.Text + "> 包含的固定资产类别列表：";
            //资产类别发生变化时选项也会变化，先清空选项
            this.chk清空.Checked = false;
            for (int j = 0; j < clb固定资产类别.Items.Count; j++)
                this.clb固定资产类别.SetItemChecked(j, false);
            lbx固定资产类别.Items.Clear();
            //资产类别发生变化时选项也会变化，再重新赋值
            this.ShowSelection();
        }
    }
}
