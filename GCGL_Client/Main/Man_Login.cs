using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TY.Helper;
using DingnuoControlLibrary;
using GCGL_Client.Common;

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

            if (this.Login(this.txtLoginName.Text, this.txtLoginPswd.Text))
            {
                //登录成功了
                if (this.chkRemember.Checked)
                {
                    Properties.Settings.Default.LoginName = this.txtLoginName.Text;
                    Properties.Settings.Default.LoginPswd = Cmn_DataProtection.ProtectData(txtLoginPswd.Text, "GCGL_Password");
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

        public bool Login(string LoginName, string LoginPswd)
        {
            //开始验证登录
            base.Cursor = Cursors.WaitCursor;
            try
            {
                //1.打开连接
                if (!AppServer.WcfService_Open()) return false;
                //2.读取登录参数
                var model = new Ref_WS_GCGL.DataType_User();
                model.LoginName = LoginName;
                model.LoginPswd = LoginPswd;
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
                    }
                    return false;
                }
                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    AppServer.ShowMsg_Error("登录时服务端返回空的登录数据，请与系统管理员联系解决！", "登录失败了！");
                    return false;
                }
                //5.读取登录返回数据
                AppServer.LoginUserCode = ds.Tables[0].Rows[0]["UserCode"].ToString();//用户账号
                AppServer.LoginUserName = ds.Tables[0].Rows[0]["UserName"].ToString();//用户名称
                
                AppServer.LoginUserType = ds.Tables[0].Rows[0]["UserType"].ToIntegerDef();//用户类型
                AppServer.LoginUnitCode = ds.Tables[0].Rows[0]["UnitCode"].ToString();//单位编码
                AppServer.LoginUnitName = ds.Tables[0].Rows[0]["UnitName"].ToString();//单位名称
                AppServer.LoginUnitType = ds.Tables[0].Rows[0]["UnitType"].ToIntegerDef();//单位类型
                AppServer.LoginUnitJC = ds.Tables[0].Rows[0]["UnitJC"].ToIntegerDef(0);//单位级次
                AppServer.LoginDeptCode = ds.Tables[0].Rows[0]["DeptCode"].ToString();//处室编码
                AppServer.LoginDeptName = ds.Tables[0].Rows[0]["DeptName"].ToString();//处室名称
                AppServer.LoginAreaCode = ds.Tables[0].Rows[0]["AreaCode"].ToString();//区划编码
                AppServer.LoginAreaName = ds.Tables[0].Rows[0]["AreaName"].ToString();//区划名称

                AppServer.LoginGovCars = ds.Tables[0].Rows[0]["GovCars"].ToIntegerDef();//公务用车编制数
                AppServer.LoginLawCars = ds.Tables[0].Rows[0]["LawCars"].ToIntegerDef();//一般执法执勤用车编制数
                AppServer.LoginSkillCars = ds.Tables[0].Rows[0]["SkillCars"].ToIntegerDef();//特种专业用车编制数
                
                AppServer.LoginDataType=ds.Tables[0].Rows[0]["DataType"].ToString();//用户数据类型
                AppServer.LoginWorkDate = DateTime.Today;//登录时间
                //6.获取用户菜单列表
                model.UserCode = AppServer.LoginUserCode;
                DataSet dbb = AppServer.wcfClient.SYS_Login_Menu(ref model);
                if (model.ExResult != 0)
                {
                    AppServer.ShowMsg_Error(model.ErrorMsg, "登录失败了！");
                    return false;
                }
                if (dbb.Tables.Count == 0)
                {
                    AppServer.ShowMsg_Error("登录时没有发现用户权限，请与您的上级管理员联系！", "登录失败了！");
                    return false;
                }
                AppServer.UserQxMenuList = dbb.Tables[0];
                AppServer.UserQxMenuList.PrimaryKey = new DataColumn[1] { AppServer.UserQxMenuList.Columns["MenuCode"] };
                //7.获取系统参数
                AppServer.wcfClient.SYS_Param_Get(ref AppServer.Sys_Param);

                var mdl = new Ref_WS_GCGL.DataType_CMN_单位();
                mdl.LoginUserCode = AppServer.LoginUserCode;
                if (AppServer.LoginUnitIsCZT())
                {
                    mdl.ExAction = "GetGUnit";
                }
                else
                {
                    mdl.ExAction = "UnitMngrTree";
                    mdl.区划编码 = AppServer.LoginAreaCode;
                    mdl.单位编码 = AppServer.LoginUnitCode;
                    mdl.单位类型编码 = AppServer.LoginUnitType;
                }
                DataSet dset = AppServer.wcfClient.CMN_单位_List(ref mdl);
                AppServer.UdataTable = dset.Tables[0];
               
                //
                AppServer.ChangeTime = AppServer.wcfClient.CMN_单位_更新_List();
                AppServer.EndChange = AppServer.ChangeTime;
                //
                AppServer.Frm单位信息 = new Cmn_TreeBox();
                AppServer.Frm单位信息.BuildTree("单位信息", AppServer.UdataTable, "单位编码", "上级编码", "单位名称");
                //
                AppServer.LoginSuccess = true;
                return true;
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_Error("系统登录时出现异常，请确认您的网络连接是否有问题！\n错误信息：" + ex.Message, "登录失败了！");
                return false;
            }
            finally
            {
                AppServer.WcfService_Close();
                base.Cursor = Cursors.Arrow;            
            }
           
        }

    }
}
