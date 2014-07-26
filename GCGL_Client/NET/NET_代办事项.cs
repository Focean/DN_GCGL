using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace GCGL_Client.NET
{
    public partial class NET_代办事项 : Form
    {
        public NET_代办事项()
        {
            InitializeComponent();
            //
            this.DataBinding_GET();
            if (AppServer.LoginUnitIsZGDW())
            {
                this.label4.Enabled = false;
                this.label5.Enabled = false;
                this.label6.Enabled = false;
                this.label7.Enabled = false;
                this.lbl编制.Enabled = false;
                this.lbl出库.Enabled = false;
                this.lbl更新.Enabled = false;
                this.lbl入库.Enabled = false;
            }
        }

        private void SetWaitLable(Label lab, int iCount)
        {
            if (iCount == 0)
            {
                lab.Text = "无";
                lab.ForeColor = Color.Black;
                lab.Cursor = Cursors.Arrow;
                //lab.Font.Underline = false;
            }
            else
            {
                lab.Text = string.Format("共{0}条", iCount);
                lab.ForeColor = Color.Blue;
                lab.Cursor = Cursors.Hand;
            }
        }

        private void DataBinding_GET()
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;
                var model = new Ref_WS_GCGL.DataType_NET_审批();
                model.ExAction = "NCount";
                model.LoginUserCode = AppServer.LoginUserCode;
                if(AppServer.LoginUnitIsYSDW()||AppServer.LoginUnitIsZGDW())
                     model.单位编码 = AppServer.LoginUnitCode;
                //
                DataSet db = AppServer.wcfClient.NET_审批_List(ref model);
                DataTable DT = db.Tables[0];
                
                this.SetWaitLable(this.lbl编制, DT.Rows[0]["编制审批数量"].ToIntegerDef());
                this.SetWaitLable(this.lbl更新, DT.Rows[0]["更新审批数量"].ToIntegerDef());
                this.SetWaitLable(this.lbl出库, DT.Rows[0]["出库审批数量"].ToIntegerDef());
                this.SetWaitLable(this.lbl入库, DT.Rows[0]["入库审批数量"].ToIntegerDef());
                this.SetWaitLable(this.lbl配置, DT.Rows[0]["配置审批数量"].ToIntegerDef());
                this.SetWaitLable(this.lbl处置, DT.Rows[0]["处置审批数量"].ToIntegerDef());
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

        private void btn关闭_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl配置_MouseClick(object sender, MouseEventArgs e)
        {
            if (AppServer.LoginUnitIsZGDW() || AppServer.LoginUnitIsCZT())
            {
                AppServer.OpenUserMenu("0601", "审批中心", Man_Main.ActiveForm);
            }
            else if (AppServer.LoginUnitIsYSDW())
            {
                AppServer.OpenUserMenu("0311", "配置申报", Man_Main.ActiveForm);
            }
        }

        private void lbl出库_MouseClick(object sender, MouseEventArgs e)
        {
            if (AppServer.LoginUnitIsZGDW() || AppServer.LoginUnitIsCZT())
            {
                AppServer.OpenUserMenu("0601", "审批中心", Man_Main.ActiveForm);
            }
            else if (AppServer.LoginUnitIsYSDW())
            {
                AppServer.OpenUserMenu("0512", "出库登记", Man_Main.ActiveForm);
            }
        }

        private void lbl更新_MouseClick(object sender, MouseEventArgs e)
        {
            //if  (AppServer.LoginUnitIsZGDW() || AppServer.LoginUnitIsCZT())
            //{
            //    AppServer.OpenUserMenu("0601", "审批中心", Man_Main.ActiveForm);
            //}
            //else if  (AppServer.LoginUnitIsYSDW())
            //{
            //    AppServer.OpenUserMenu("0211", "年度更新计划", Man_Main.ActiveForm);
            //}
        }

        private void lbl处置_MouseClick(object sender, MouseEventArgs e)
        {
            if (AppServer.LoginUnitIsZGDW() || AppServer.LoginUnitIsCZT())
            {
                AppServer.OpenUserMenu("0601", "审批中心", Man_Main.ActiveForm);
            }
            else if (AppServer.LoginUnitIsYSDW())
            {
                AppServer.OpenUserMenu("0511", "处置申报", Man_Main.ActiveForm);
            }  
        }

        private void lbl编制_MouseClick(object sender, MouseEventArgs e)
        {
            if (AppServer.LoginUnitIsZGDW() || AppServer.LoginUnitIsCZT())
            {
                AppServer.OpenUserMenu("0601", "审批中心", Man_Main.ActiveForm);
            }
            else if (AppServer.LoginUnitIsYSDW())
            {
                AppServer.OpenUserMenu("0310", "编制申报", Man_Main.ActiveForm);
            }
        }

        private void lbl入库_MouseClick(object sender, MouseEventArgs e)
        {
            if (AppServer.LoginUnitIsZGDW() || AppServer.LoginUnitIsCZT())
            {
                AppServer.OpenUserMenu("0601", "审批中心", Man_Main.ActiveForm);
            }
            else if (AppServer.LoginUnitIsYSDW())
            {
                AppServer.OpenUserMenu("0312", "入库登记", Man_Main.ActiveForm);
            }
        }

        private void btn刷新_Click(object sender, EventArgs e)
        {
            DataBinding_GET();
        }
      
    }
}
