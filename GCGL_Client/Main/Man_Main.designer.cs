﻿namespace GCGL_Client
{
    partial class Man_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Man_Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslAppHost = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslWorkDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslLoginUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslAppArea = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslAppUnit = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dbTreeView = new DingnuoControlLibrary.DBTreeView();
            this.iglTree = new System.Windows.Forms.ImageList(this.components);
            this.pnlRight = new System.Windows.Forms.Panel();
            this.labelTree = new System.Windows.Forms.Label();
            this.toolStripRight = new System.Windows.Forms.ToolStrip();
            this.toolBtnShowFT = new System.Windows.Forms.ToolStripButton();
            this.splitter = new System.Windows.Forms.Splitter();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.plTop = new System.Windows.Forms.Panel();
            this.toolStripTitle = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelTitle = new System.Windows.Forms.ToolStripLabel();
            this.plToolStrip = new System.Windows.Forms.Panel();
            this.toolStripLeft = new System.Windows.Forms.ToolStrip();
            this.toolBtnHideFT = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.miChangYear = new System.Windows.Forms.ToolStripMenuItem();
            this.miModiPswd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.miView_FunctionTree = new System.Windows.Forms.ToolStripMenuItem();
            this.miView_StatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.miView_Guide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.miTool_Calc = new System.Windows.Forms.ToolStripMenuItem();
            this.miTool_Note = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn重新登录 = new System.Windows.Forms.Button();
            this.btn退出系统 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.toolStripRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.plTop.SuspendLayout();
            this.toolStripTitle.SuspendLayout();
            this.plToolStrip.SuspendLayout();
            this.toolStripLeft.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslAppHost,
            this.tsslWorkDate,
            this.tsslLoginUser,
            this.tsslAppArea,
            this.tsslAppUnit,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 621);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1025, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statMainInfo";
            // 
            // tsslAppHost
            // 
            this.tsslAppHost.AutoSize = false;
            this.tsslAppHost.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.tsslAppHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslAppHost.Name = "tsslAppHost";
            this.tsslAppHost.Size = new System.Drawing.Size(180, 17);
            this.tsslAppHost.Text = "应用服务器：202.102.238.46";
            // 
            // tsslWorkDate
            // 
            this.tsslWorkDate.AutoSize = false;
            this.tsslWorkDate.Name = "tsslWorkDate";
            this.tsslWorkDate.Size = new System.Drawing.Size(160, 17);
            this.tsslWorkDate.Text = "业务日期：2013-07-28";
            // 
            // tsslLoginUser
            // 
            this.tsslLoginUser.Name = "tsslLoginUser";
            this.tsslLoginUser.Size = new System.Drawing.Size(171, 17);
            this.tsslLoginUser.Text = "  操作员：(81999008)管理员  ";
            // 
            // tsslAppArea
            // 
            this.tsslAppArea.Name = "tsslAppArea";
            this.tsslAppArea.Size = new System.Drawing.Size(79, 17);
            this.tsslAppArea.Text = "区划：河南省";
            // 
            // tsslAppUnit
            // 
            this.tsslAppUnit.AutoSize = false;
            this.tsslAppUnit.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tsslAppUnit.Name = "tsslAppUnit";
            this.tsslAppUnit.Size = new System.Drawing.Size(420, 17);
            this.tsslAppUnit.Spring = true;
            this.tsslAppUnit.Text = "单位：郑州鼎诺电子科技有限公司";
            this.tsslAppUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 15);
            this.toolStripStatusLabel1.Text = "DnSoft 版权所有 ";
            // 
            // dbTreeView
            // 
            this.dbTreeView.AutoScroll = true;
            this.dbTreeView.CheckBoxs = false;
            this.dbTreeView.CheckMode = DingnuoControlLibrary.CheckMode.None;
            this.dbTreeView.DataSource = null;
            this.dbTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTreeView.HideSelection = false;
            this.dbTreeView.ImageIndex = 0;
            this.dbTreeView.ImageList = this.iglTree;
            this.dbTreeView.ItemHeight = 22;
            this.dbTreeView.Location = new System.Drawing.Point(0, 23);
            this.dbTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.dbTreeView.MultiSelect = true;
            this.dbTreeView.Name = "dbTreeView";
            this.dbTreeView.NodeID = "MenuCode";
            this.dbTreeView.NodePID = "MenuPCode";
            this.dbTreeView.NodeTitle = "MenuName";
            this.dbTreeView.SelectedImageIndex = 0;
            this.dbTreeView.SelectedNode = null;
            this.dbTreeView.Size = new System.Drawing.Size(233, 525);
            this.dbTreeView.TabIndex = 5;
            this.dbTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dbTreeView_NodeMouseDoubleClick);
            this.dbTreeView.TreeNodeCreated += new DingnuoControlLibrary.TreeNodeCreatedEventHandler(this.dbTreeView_TreeNodeCreated);
            // 
            // iglTree
            // 
            this.iglTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iglTree.ImageStream")));
            this.iglTree.TransparentColor = System.Drawing.Color.Fuchsia;
            this.iglTree.Images.SetKeyName(0, "arrowright_green16.bmp");
            this.iglTree.Images.SetKeyName(1, "folders16_h.bmp");
            this.iglTree.Images.SetKeyName(2, "views16.bmp");
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRight.Controls.Add(this.labelTree);
            this.pnlRight.Controls.Add(this.toolStripRight);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRight.Location = new System.Drawing.Point(240, 69);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(33, 552);
            this.pnlRight.TabIndex = 14;
            // 
            // labelTree
            // 
            this.labelTree.BackColor = System.Drawing.Color.Gainsboro;
            this.labelTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTree.Location = new System.Drawing.Point(0, 25);
            this.labelTree.Name = "labelTree";
            this.labelTree.Size = new System.Drawing.Size(29, 523);
            this.labelTree.TabIndex = 3;
            this.labelTree.Text = "功\r\n能\r\n树";
            this.labelTree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTree.Click += new System.EventHandler(this.labelTree_Click);
            // 
            // toolStripRight
            // 
            this.toolStripRight.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripRight.ImageScalingSize = new System.Drawing.Size(15, 15);
            this.toolStripRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnShowFT});
            this.toolStripRight.Location = new System.Drawing.Point(0, 0);
            this.toolStripRight.Name = "toolStripRight";
            this.toolStripRight.Size = new System.Drawing.Size(29, 25);
            this.toolStripRight.TabIndex = 1;
            // 
            // toolBtnShowFT
            // 
            this.toolBtnShowFT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnShowFT.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnShowFT.Image")));
            this.toolBtnShowFT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnShowFT.Name = "toolBtnShowFT";
            this.toolBtnShowFT.Size = new System.Drawing.Size(23, 22);
            this.toolBtnShowFT.Text = "展开 功能树";
            this.toolBtnShowFT.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitter.Location = new System.Drawing.Point(237, 69);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 552);
            this.splitter.TabIndex = 13;
            this.splitter.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLeft.Controls.Add(this.dbTreeView);
            this.pnlLeft.Controls.Add(this.plTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 69);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(237, 552);
            this.pnlLeft.TabIndex = 12;
            // 
            // plTop
            // 
            this.plTop.Controls.Add(this.toolStripTitle);
            this.plTop.Controls.Add(this.plToolStrip);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(233, 23);
            this.plTop.TabIndex = 11;
            // 
            // toolStripTitle
            // 
            this.toolStripTitle.Font = new System.Drawing.Font("宋体", 9F);
            this.toolStripTitle.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelTitle});
            this.toolStripTitle.Location = new System.Drawing.Point(0, 0);
            this.toolStripTitle.Name = "toolStripTitle";
            this.toolStripTitle.Size = new System.Drawing.Size(198, 25);
            this.toolStripTitle.TabIndex = 13;
            this.toolStripTitle.Text = "toolStrip";
            // 
            // toolStripLabelTitle
            // 
            this.toolStripLabelTitle.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabelTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.toolStripLabelTitle.Name = "toolStripLabelTitle";
            this.toolStripLabelTitle.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabelTitle.Text = "功能树";
            // 
            // plToolStrip
            // 
            this.plToolStrip.Controls.Add(this.toolStripLeft);
            this.plToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.plToolStrip.Location = new System.Drawing.Point(198, 0);
            this.plToolStrip.Name = "plToolStrip";
            this.plToolStrip.Size = new System.Drawing.Size(35, 23);
            this.plToolStrip.TabIndex = 12;
            // 
            // toolStripLeft
            // 
            this.toolStripLeft.ImageScalingSize = new System.Drawing.Size(15, 15);
            this.toolStripLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnHideFT});
            this.toolStripLeft.Location = new System.Drawing.Point(0, 0);
            this.toolStripLeft.Name = "toolStripLeft";
            this.toolStripLeft.Size = new System.Drawing.Size(35, 25);
            this.toolStripLeft.TabIndex = 0;
            // 
            // toolBtnHideFT
            // 
            this.toolBtnHideFT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnHideFT.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnHideFT.Image")));
            this.toolBtnHideFT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnHideFT.Name = "toolBtnHideFT";
            this.toolBtnHideFT.Size = new System.Drawing.Size(23, 22);
            this.toolBtnHideFT.Text = "折叠 功能树";
            this.toolBtnHideFT.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1025, 24);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miChangYear,
            this.miModiPswd,
            this.toolStripSeparator2,
            this.miLogin,
            this.miExit});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(58, 20);
            this.fileMenu.Text = "系统(&S)";
            // 
            // miChangYear
            // 
            this.miChangYear.Name = "miChangYear";
            this.miChangYear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.miChangYear.Size = new System.Drawing.Size(170, 22);
            this.miChangYear.Text = "切换年度";
            this.miChangYear.Visible = false;
            // 
            // miModiPswd
            // 
            this.miModiPswd.Name = "miModiPswd";
            this.miModiPswd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.miModiPswd.Size = new System.Drawing.Size(170, 22);
            this.miModiPswd.Text = "修改密码";
            this.miModiPswd.Click += new System.EventHandler(this.miModiPswd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // miLogin
            // 
            this.miLogin.Name = "miLogin";
            this.miLogin.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.miLogin.Size = new System.Drawing.Size(170, 22);
            this.miLogin.Text = "重新登录";
            this.miLogin.Click += new System.EventHandler(this.miLogin_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.miExit.Size = new System.Drawing.Size(170, 22);
            this.miExit.Text = "退出系统";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miView_FunctionTree,
            this.miView_StatusBar,
            this.miView_Guide});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(59, 20);
            this.viewMenu.Text = "视图(&V)";
            // 
            // miView_FunctionTree
            // 
            this.miView_FunctionTree.Checked = true;
            this.miView_FunctionTree.CheckOnClick = true;
            this.miView_FunctionTree.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miView_FunctionTree.Name = "miView_FunctionTree";
            this.miView_FunctionTree.Size = new System.Drawing.Size(128, 22);
            this.miView_FunctionTree.Text = "功能树(&N)";
            this.miView_FunctionTree.Click += new System.EventHandler(this.miView_FunctionTree_Click);
            // 
            // miView_StatusBar
            // 
            this.miView_StatusBar.Checked = true;
            this.miView_StatusBar.CheckOnClick = true;
            this.miView_StatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miView_StatusBar.Name = "miView_StatusBar";
            this.miView_StatusBar.Size = new System.Drawing.Size(128, 22);
            this.miView_StatusBar.Text = "状态栏(&S)";
            this.miView_StatusBar.Click += new System.EventHandler(this.miView_StatusBar_Click);
            // 
            // miView_Guide
            // 
            this.miView_Guide.Checked = true;
            this.miView_Guide.CheckOnClick = true;
            this.miView_Guide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miView_Guide.Name = "miView_Guide";
            this.miView_Guide.Size = new System.Drawing.Size(128, 22);
            this.miView_Guide.Text = "导航栏(&G)";
            this.miView_Guide.Click += new System.EventHandler(this.miView_Guide_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTool_Calc,
            this.miTool_Note});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(58, 20);
            this.toolsMenu.Text = "工具(&T)";
            // 
            // miTool_Calc
            // 
            this.miTool_Calc.Image = ((System.Drawing.Image)(resources.GetObject("miTool_Calc.Image")));
            this.miTool_Calc.Name = "miTool_Calc";
            this.miTool_Calc.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.J)));
            this.miTool_Calc.Size = new System.Drawing.Size(206, 22);
            this.miTool_Calc.Text = "计算器(&C)";
            this.miTool_Calc.Click += new System.EventHandler(this.miTool_Calc_Click);
            // 
            // miTool_Note
            // 
            this.miTool_Note.Image = ((System.Drawing.Image)(resources.GetObject("miTool_Note.Image")));
            this.miTool_Note.Name = "miTool_Note";
            this.miTool_Note.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.miTool_Note.Size = new System.Drawing.Size(206, 22);
            this.miTool_Note.Text = "记事本(&N)";
            this.miTool_Note.Click += new System.EventHandler(this.miTool_Note_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrangeIconsToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(63, 20);
            this.windowsMenu.Text = "窗口(&W)";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.arrangeIconsToolStripMenuItem.Text = "排列图标(&A)";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.arrangeIconsToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.cascadeToolStripMenuItem.Text = "层叠(&C)";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tileHorizontalToolStripMenuItem.Text = "水平平铺(&H)";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tileVerticalToolStripMenuItem.Text = "垂直平铺(&V)";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.closeAllToolStripMenuItem.Text = "全部关闭(&L)";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(60, 20);
            this.helpMenu.Text = "帮助(&H)";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.contentsToolStripMenuItem.Text = "目录(&C)";
            this.contentsToolStripMenuItem.Visible = false;
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.indexToolStripMenuItem.Text = "索引(&I)";
            this.indexToolStripMenuItem.Visible = false;
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.searchToolStripMenuItem.Text = "搜索(&S)";
            this.searchToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(160, 6);
            this.toolStripSeparator4.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutToolStripMenuItem.Text = "关于(&A) ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn重新登录);
            this.panel1.Controls.Add(this.btn退出系统);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 45);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 45);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn重新登录
            // 
            this.btn重新登录.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn重新登录.BackgroundImage")));
            this.btn重新登录.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn重新登录.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn重新登录.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn重新登录.ForeColor = System.Drawing.Color.White;
            this.btn重新登录.Location = new System.Drawing.Point(875, 0);
            this.btn重新登录.Name = "btn重新登录";
            this.btn重新登录.Size = new System.Drawing.Size(75, 45);
            this.btn重新登录.TabIndex = 1;
            this.btn重新登录.Text = "重新登录";
            this.btn重新登录.UseVisualStyleBackColor = true;
            this.btn重新登录.Click += new System.EventHandler(this.btn重新登录_Click);
            // 
            // btn退出系统
            // 
            this.btn退出系统.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn退出系统.BackgroundImage")));
            this.btn退出系统.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn退出系统.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn退出系统.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn退出系统.ForeColor = System.Drawing.Color.White;
            this.btn退出系统.Location = new System.Drawing.Point(950, 0);
            this.btn退出系统.Name = "btn退出系统";
            this.btn退出系统.Size = new System.Drawing.Size(75, 45);
            this.btn退出系统.TabIndex = 0;
            this.btn退出系统.Text = "退出系统";
            this.btn退出系统.UseVisualStyleBackColor = true;
            this.btn退出系统.Click += new System.EventHandler(this.btn退出系统_Click);
            // 
            // Man_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 643);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Man_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主窗口";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TfmMan_Main_FormClosing);
            this.Load += new System.EventHandler(this.fmMan_Main_Load);
            this.Shown += new System.EventHandler(this.TfmMan_Main_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.toolStripRight.ResumeLayout(false);
            this.toolStripRight.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            this.toolStripTitle.ResumeLayout(false);
            this.toolStripTitle.PerformLayout();
            this.plToolStrip.ResumeLayout(false);
            this.plToolStrip.PerformLayout();
            this.toolStripLeft.ResumeLayout(false);
            this.toolStripLeft.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslWorkDate;
        private System.Windows.Forms.ToolStripStatusLabel tsslLoginUser;
        private DingnuoControlLibrary.DBTreeView dbTreeView;
        private System.Windows.Forms.ToolStripStatusLabel tsslAppUnit;
        private System.Windows.Forms.ImageList iglTree;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label labelTree;
        private System.Windows.Forms.ToolStrip toolStripRight;
        private System.Windows.Forms.ToolStripButton toolBtnShowFT;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.ToolStrip toolStripTitle;
        private System.Windows.Forms.ToolStripLabel toolStripLabelTitle;
        private System.Windows.Forms.Panel plToolStrip;
        private System.Windows.Forms.ToolStrip toolStripLeft;
        private System.Windows.Forms.ToolStripButton toolBtnHideFT;
        internal System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem miLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem miView_FunctionTree;
        private System.Windows.Forms.ToolStripMenuItem miView_StatusBar;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem miTool_Calc;
        private System.Windows.Forms.ToolStripMenuItem miTool_Note;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miChangYear;
        private System.Windows.Forms.ToolStripMenuItem miModiPswd;
        private System.Windows.Forms.ToolStripStatusLabel tsslAppHost;
        private System.Windows.Forms.ToolStripMenuItem miView_Guide;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn重新登录;
        private System.Windows.Forms.Button btn退出系统;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel tsslAppArea;
    }
}

