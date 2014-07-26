using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GCGL_Client.NET;
using TY.Helper;
using System.Data.SqlClient;

namespace GCGL_Client.Main
{
    public partial class Man_UserEnt_Editor : Form
    {
        public Man_UserEnt_Editor()
        {
            InitializeComponent();
            this.rb启用.Checked = true;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                //this.cbx被委托人.DataSource = AppServer.wcfClient.FZB_编码_List("用户信息").Tables[0];
                var model = new Ref_WS_GCGL.DataType_SYS_委托();
                model.ExAction = "用户信息";
                model.委托人 = AppServer.LoginUserCode;
                DataSet db = AppServer.wcfClient.SYS_委托_list(ref model);
                this.cbx被委托人.DataSource = db.Tables[0];

                this.cbx被委托人.DisplayMember = "用户名称";
                this.cbx被委托人.ValueMember = "用户编码";
                this.cbx被委托人.SelectedIndex = -1;
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
        private int FDataRow;
        public void Editor_Add()
        {
            this.Text = "设置委托人(添加)";
            this.Tag = "Add";
        }

        public void Editor_Mod(DataRow row)
        {
            this.Text = "设置委托人(修改)";
            this.Tag = "Mod";
            FDataRow = row["ID"].ToIntegerDef(0);
            string tt = row["被委托人"].ToString();
            this.cbx被委托人.Text = row["被委托人"].ToString();
            if (row["是否启用"].ToString() == "是") this.rb启用.Checked = true;
            else this.rb不启用.Checked = true;
        }
        private void btn确定_Click(object sender, EventArgs e)
        {
            if (this.cbx被委托人.Text.Trim() == "")
            {
                AppServer.ShowMsg("委托人为空不能提交！");
                this.cbx被委托人.Focus();
                return;
            }
            if (this.cbx被委托人.SelectedValue.ToString() == AppServer.LoginUserCode)
            {
                AppServer.ShowMsg("不能委托给自己,请重新选择!");
                this.cbx被委托人.Text = "";
                this.cbx被委托人.Focus();
                return;
            }

            #region 提交数据
            base.Cursor = Cursors.WaitCursor;
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_SYS_委托();
                
                model.ExAction = this.Tag.ToString();
                model.ID = FDataRow;
                model.被委托人 = this.cbx被委托人.SelectedValue.ToString();
                model.委托人 = AppServer.LoginUserCode;
                if (this.rb启用.Checked == true) model.是否启用 = "1";
                if (this.rb不启用.Checked == true) model.是否启用 = "0";
                AppServer.wcfClient.SYS_委托_Edit(ref model);
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                    return;
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
            #endregion
            //
            this.DialogResult = DialogResult.OK;
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Man_UserEnt_Editor_KeyDown(object sender, KeyEventArgs e)
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
                btn确定_Click(this, EventArgs.Empty);
            }
        }
    }
}
