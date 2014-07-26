using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DingnuoControlLibrary;
using GCGL_Client.Main;
using TY.Helper;
using GCGL_Client.OCC;
namespace GCGL_Client
{
    public partial class Man_Main : Form
    {
        //
        private MdiClient FMDI_Client;

        public Man_Main()
        {
            InitializeComponent();

            #region MDI窗口事件处理

            foreach (Control control in this.Controls)
            {
                if (control.GetType().ToString() == "System.Windows.Forms.MdiClient")
                {
                    FMDI_Client = (MdiClient)control;
                    break;
                }
            }
            //m_MdiClient.BackColor = System.Drawing.SystemColors.Control;
            //FMDI_Client.ControlAdded += new ControlEventHandler(m_MdiClient_ControlAdded);
            //FMDI_Client.ControlRemoved += new ControlEventHandler(m_MdiClient_ControlRemoved);

            #endregion

            //应用程序初始化
            AppServer.InitAppServer();

            //用户登录
            if (!AppServer.LoginSuccess)
                this.Login(true);
            else
                this.ReadFormParam();
         
        }

        private void fmMan_Main_Load(object sender, EventArgs e)
        {
            if (!AppServer.LoginSuccess) return;
            //
            this.toolBtnShowFT.PerformClick();
           
        }

        private void TfmMan_Main_Shown(object sender, EventArgs e)
        {
            if (!AppServer.LoginSuccess) this.Close();
        }

        private void TfmMan_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            if (!AppServer.LoginSuccess) return;
            //退出提示
            e.Cancel = !AppServer.DialogMsg("感谢您的使用，确认要退出系统吗？", "退出提示");
        }

        private void ReadFormParam()
        {
            base.Cursor = Cursors.WaitCursor;
            try
            {
                //更新界面属性
                this.Text = string.Format("{0} {1}", Application.ProductName, Man_About.AssemblyAppVer);
                this.toolStripLabelTitle.Text = string.Format("『{0}』的功能树", AppServer.LoginUserName);
                this.tsslAppHost.Text = string.Format("应用服务器：{0}", AppServer.wcfClient.Endpoint.Address.Uri.Host.ToString());
                this.tsslWorkDate.Text = string.Format("业务日期：{0:yyyy-MM-dd}", AppServer.LoginWorkDate);
                this.tsslLoginUser.Text = string.Format("  操作员：({0}){1}  ", AppServer.LoginUserCode, AppServer.LoginUserName);
                this.tsslAppArea.Text = string.Format("  区划：{0}", AppServer.LoginAreaName);
                this.tsslAppUnit.Text = string.Format("  单位名称：{0}", AppServer.LoginUnitName);
                //创建用户功能树
                if (AppServer.UserQxMenuList != null)
                {
                    //DataView dv = new DataView(AppServer.UserQxMenuList);
                    //dv.RowFilter = "MenuType=0 or MenuType=1";
                    DataTable dt = AppServer.UserQxMenuList.Clone();
                    foreach (DataRow row in AppServer.UserQxMenuList.Select("MenuType=0 or MenuType=1", "MenuPCode, MenuOrder, MenuCode"))
                    {
                        dt.Rows.Add(row.ItemArray);
                    }
                    this.dbTreeView.DataSource = dt;
                    this.dbTreeView.BuildTrees();
                    //
                    this.dbTreeView.ExpandAll();
                }
            }
            finally
            {
                base.Cursor = Cursors.Arrow;
            }
        }

        private Boolean Login(Boolean AFirst = false)
        {
            using (var fLogin = new Man_Login())
            {
                fLogin.Visible = false;
                //登录失败了，直接返回
                if (fLogin.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }
            }
            //登录成功了
            this.ReadFormParam();
            //重新登录后要把子窗口全部关闭
            if (!AFirst)
            {
                foreach (Form fMDI in this.MdiChildren)
                {
                    fMDI.Close();
                }
            }
            if (AppServer.UserQxMenuList.Rows.Contains("0600"))
            {
                AppServer.OpenUserMenu("0600", "代办事项", this);
            }
            //返回成功登录了
            return true;
        }

        public void UpdateForm(bool ABuildTree = true)
        {

        }

        #region MDIFormList控制

        Random random = new Random();
        private void m_MdiClient_ControlAdded(object sender, ControlEventArgs e)
        {
            //将控件添加到控件集合时
            Button btnMDI = new Button();
            btnMDI.Dock = DockStyle.Bottom;
            btnMDI.FlatStyle = FlatStyle.Popup;
            btnMDI.Text = e.Control.Text;

            e.Control.Tag = "Form" + random.Next().ToString();
            btnMDI.Name = "Button_" + e.Control.Tag;
            btnMDI.UseVisualStyleBackColor = true;
            //button.Click += new EventHandler(button_Click);

            //委托 匿名函数 目的是解决传参数
            btnMDI.Click += delegate(object o, EventArgs y)
            {
                foreach (Form childForm in MdiChildren)
                {
                    if (childForm.Tag == e.Control.Tag)
                    {
                        childForm.Focus();
                        break;
                    }
                }
            };
            pnlLeft.Controls.Add(btnMDI);
        }

        private void m_MdiClient_ControlRemoved(object sender, ControlEventArgs e)
        {
            //++++++++++++++++++ 将控件从控件集合移除时 ++++++++++++++++++
            //MessageBox.Show(e.Control.Name);
            foreach (Control control in pnlLeft.Controls)
            {
                if (control.Name == "Button_" + e.Control.Tag)
                {
                    pnlLeft.Controls.Remove(control);
                    control.Dispose();
                    break;
                }
            }
        }

        #endregion
        
        #region 菜单功能调用实现

        private void miModiPswd_Click(object sender, EventArgs e)
        {
            //修改密码
            using (Man_UserPswd form = new Man_UserPswd())
            {
                form.Visible = false;
                form.ShowDialog();
            }
        }

        private void miLogin_Click(object sender, EventArgs e)
        {
            //用户登录
            this.Login(false);
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            //退出系统
            this.Close();
        }

        private void miView_FunctionTree_Click(object sender, EventArgs e)
        {
            //菜单→窗口→功能树
            if (miView_FunctionTree.Checked)
                this.toolBtnShowFT.PerformClick();
            else
                this.toolBtnHideFT.PerformClick();
        }

        private void miView_StatusBar_Click(object sender, EventArgs e)
        {
            //菜单→视图→状态栏
            this.statusStrip1.Visible = this.miView_StatusBar.Checked;
        }

        private void miView_Guide_Click(object sender, EventArgs e)
        {
            //菜单→视图→导航栏
            //this.pnlGuide21.Visible = this.miView_Guide.Checked;
        }

        private void miTool_Calc_Click(object sender, EventArgs e)
        {
            //菜单→工具→计算器
            System.Diagnostics.Process[] p = System.Diagnostics.Process.GetProcessesByName("calc");
            if (p.Length <= 0)
                System.Diagnostics.Process.Start("calc.exe ");
            else Win32.SetForegroundWindow(p[0].MainWindowHandle);
        }

        private void miTool_Note_Click(object sender, EventArgs e)
        {
            //菜单→工具→记事本
            System.Diagnostics.Process[] p = System.Diagnostics.Process.GetProcessesByName("notepad");
            if (p.Length <= 0)
                System.Diagnostics.Process.Start("notepad.exe ");
            else Win32.SetForegroundWindow(p[0].MainWindowHandle);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //菜单→窗口→排列图标
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //菜单→窗口→层叠
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //菜单→窗口→水平平铺
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //菜单→窗口→垂直平铺
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //菜单→窗口→全部关闭
            foreach (Form fMdiForm in this.MdiChildren)
            {
                fMdiForm.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Man_About fAbout = new Man_About())
            {
                fAbout.ShowDialog();
            }
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            //折叠功能树
            this.pnlLeft.Visible = false;
            this.pnlRight.Visible = true;
            this.splitter.Enabled = false;
            this.splitter.Visible = false;
            this.miView_FunctionTree.Checked = false;
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            //展开功能树
            this.pnlRight.Visible = false;
            this.pnlLeft.Visible = true;
            this.splitter.Enabled = true;
            this.splitter.Visible = true;
            this.miView_FunctionTree.Checked = true;
        }

        private void labelTree_Click(object sender, EventArgs e)
        {
            this.toolBtnShowFT.PerformClick();
        }

        private void btn重新登录_Click(object sender, EventArgs e)
        {
            this.miLogin.PerformClick();
          
        }

        private void btn退出系统_Click(object sender, EventArgs e)
        {
            this.miExit.PerformClick();
        }

        #endregion

        #region 用户功能菜单树调用实现

        private void dbTreeView_TreeNodeCreated(object sender, TreeNodeCreatedEventArgs e)
        {
            int iMenuType = 0;
            string sMenuCode = e.Node.ID;
            DataRow[] dra = AppServer.UserQxMenuList.Select(string.Format("MenuCode='{0}'", sMenuCode));
            if (dra.Length > 0) iMenuType = dra[0]["MenuType"].ToIntegerDef();

            if (iMenuType == 0)
            {
                e.Node.ImageIndex = 1;
                e.Node.SelectedImageIndex = 0;
            }
            else
            {
                e.Node.ImageIndex = 2;
                e.Node.SelectedImageIndex = 0;
            }
        }

        private void dbTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (((DBTreeNode)e.Node).ID)
            {
                case "0903": {this.miLogin.PerformClick(); break; }
                case "0904": {this.miExit.PerformClick(); break; }
                default :
                    {
                        AppServer.OpenUserMenu(((DBTreeNode)e.Node).ID, ((DBTreeNode)e.Node).Text, this);
                        break;
                    }
            }
        }
        #endregion

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://10.8.4.140/dnsoft/gcgl/" + "\\操作手册.rar");
        }
    }
}
