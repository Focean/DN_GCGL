using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;

namespace GCGL_Client
{
    public partial class Man_Login : Form
    {
        public Man_Login()
        {
            InitializeComponent();
        }

        private void TfmMan_Login_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " Ver" + Application.ProductVersion;
            //this.Text = Application.ProductName + "--用户登录";

            #region 绘制Form中控件的透明背景
            int iOldX, iOldY;
            iOldX = this.lblUserCode.Location.X;
            iOldY = this.lblUserCode.Location.Y;
            this.Controls.Remove(this.lblUserCode);
            this.lblUserCode.Parent = this;
            this.lblUserCode.BackColor = System.Drawing.Color.Transparent;
            this.lblUserCode.Location = new System.Drawing.Point(iOldX, iOldY);

            iOldX = this.lblUserPswd.Location.X;
            iOldY = this.lblUserPswd.Location.Y;
            this.Controls.Remove(this.lblUserPswd);
            this.lblUserPswd.Parent = this;
            this.lblUserPswd.BackColor = System.Drawing.Color.Transparent;
            this.lblUserPswd.Location = new System.Drawing.Point(iOldX, iOldY);

            iOldX = this.chkRemember.Location.X;
            iOldY = this.chkRemember.Location.Y;
            this.Controls.Remove(this.chkRemember);
            this.chkRemember.Parent = this;
            this.chkRemember.BackColor = System.Drawing.Color.Transparent;
            this.chkRemember.Location = new System.Drawing.Point(iOldX, iOldY);
            #endregion            
            //
            string userName = string.Empty;
            string password = string.Empty;
            //Access configuration parameters defined in the Project > Properties > Settings
            if (Properties.Settings.Default.LoginRemb == true)
            {
                this.txtLoginName.Text = Properties.Settings.Default.LoginName;
                this.txtLoginPswd.Text = Cmn_DataProtection.UnprotectData(Properties.Settings.Default.LoginPswd);
                this.chkRemember.Checked = true;
                this.btnLogin.Focus();
            }
            else
            {
                this.txtLoginName.Focus();
            }
        }

        private void txtLoginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13)) this.txtLoginPswd.Focus();
        }

        private void txtLoginPswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) this.btnLogin.PerformClick();
        }

        #region 处理窗体拖动事件

        private Point FMousePoint;    //鼠标移动位置变量
        private bool FMoveState;     //标签是否为左键

        private void Man_Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FMousePoint = new Point(-e.X, -e.Y);
                FMoveState = true;
            }
        }

        private void Man_Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (FMoveState)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(FMousePoint.X, FMousePoint.Y);
                this.Location = mouseSet;
            }
        }

        private void Man_Login_MouseUp(object sender, MouseEventArgs e)
        {
            if (FMoveState) FMoveState = false;
        }

        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;

            if (this.txtLoginName.Text.Trim().Length == 0) 
            {
                AppServer.ShowMsg("请输入要登录的用户账号！");
                this.txtLoginName.Focus();
                this.DialogResult = DialogResult.None;
                return;
            }
            //开始验证登录
            base.Cursor = Cursors.WaitCursor;
            try
            {
                //1.打开连接
                if (!AppServer.WcfService_Open()) return;
                //2.读取登录参数
                var model = new Ref_WS_GCGL.DataType_User();
                model.LoginName = this.txtLoginName.Text;
                model.LoginPswd = this.txtLoginPswd.Text;
                //model.LoginDate = this.dtpLoginDate.Value;
                model.LoginAddr = TY.Common.NetWork.GetLocalIP();
                //3.开始登录
                DataSet ds = AppServer.wcfClient.SYS_Login(ref model);
                //4.检查登录返回值
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_Error(model.ErrorMsg, "登录失败了！");
                    switch (model.ExResult)
                    {
                        case 1: this.txtLoginName.Focus(); break;
                        case 2: this.txtLoginPswd.Focus(); break;
                        //case 3: this.dtpLoginDate.Focus(); break;
                    }                    
                    return;
                }
                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    AppServer.ShowMsg_Error("登录时服务端返回空的登录数据，请与系统管理员联系解决！", "登录失败了！");
                    return;
                }
                //5.读取登录返回数据
                AppServer.LoginUserCode = ds.Tables[0].Rows[0]["UserCode"].ToString();
                AppServer.LoginUserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                AppServer.LoginUserType = ds.Tables[0].Rows[0]["UserType"].ToIntegerDef();
                AppServer.LoginUnitCode = ds.Tables[0].Rows[0]["UnitCode"].ToString();
                AppServer.LoginUnitName = ds.Tables[0].Rows[0]["UnitName"].ToString();
                AppServer.LoginUnitType = ds.Tables[0].Rows[0]["UnitType"].ToIntegerDef();
                AppServer.LoginUnitJC = ds.Tables[0].Rows[0]["UnitJC"].ToIntegerDef(0);
                AppServer.LoginDeptCode = ds.Tables[0].Rows[0]["DeptCode"].ToString();
                AppServer.LoginDeptName = ds.Tables[0].Rows[0]["DeptName"].ToString();
                AppServer.LoginAreaCode = ds.Tables[0].Rows[0]["AreaCode"].ToString();
                AppServer.LoginAreaName = ds.Tables[0].Rows[0]["AreaName"].ToString();

                AppServer.LoginGovCars = ds.Tables[0].Rows[0]["GovCars"].ToIntegerDef();
                AppServer.LoginLawCars = ds.Tables[0].Rows[0]["LawCars"].ToIntegerDef();
                AppServer.LoginSkillCars = ds.Tables[0].Rows[0]["SkillCars"].ToIntegerDef();
                
                AppServer.LoginWorkDate = DateTime.Today;
                //6.获取用户菜单列表
                model.UserCode = AppServer.LoginUserCode;
                AppServer.UserQxMenuList = AppServer.wcfClient.SYS_Login_Menu(ref model).Tables[0];
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_Error(model.ErrorMsg, "登录失败了！");
                    return;
                }
                AppServer.UserQxMenuList.PrimaryKey = new DataColumn[1] { AppServer.UserQxMenuList.Columns["MenuCode"] };
                //7.获取系统参数
                AppServer.wcfClient.SYS_Param_Get(ref AppServer.Sys_Param);
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_Error("系统登录时出现异常，请确认您的网络连接是否有问题！\n错误信息：" + ex.Message, "登录失败了！");
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;            
            }

            //登录成功了
            if (this.chkRemember.Checked)
            {
                Properties.Settings.Default.LoginName = this.txtLoginName.Text;
                Properties.Settings.Default.LoginPswd = Cmn_DataProtection.ProtectData(txtLoginPswd.Text, "GLG_JXC_Password");
                Properties.Settings.Default.LoginRemb = this.chkRemember.Checked;
            }
            else
            {
                Properties.Settings.Default.LoginName = string.Empty;
                Properties.Settings.Default.LoginPswd = string.Empty;
                Properties.Settings.Default.LoginRemb = this.chkRemember.Checked;
            }
            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
        }

    }
}
