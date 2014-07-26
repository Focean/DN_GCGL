namespace GCGL_Client.NET
{
    partial class NET_审批中心
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NET_审批中心));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn审批 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn入户凭证 = new System.Windows.Forms.Button();
            this.btn查看 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.cbx审批类型 = new System.Windows.Forms.ComboBox();
            this.chk仅未审批 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtp结束时间 = new System.Windows.Forms.DateTimePicker();
            this.dtp开始时间 = new System.Windows.Forms.DateTimePicker();
            this.chk申请日期 = new System.Windows.Forms.CheckBox();
            this.pnlleft = new System.Windows.Forms.Panel();
            this.dbTreeView = new DingnuoControlLibrary.DBTreeView();
            this.iglTree = new System.Windows.Forms.ImageList(this.components);
            this.pnl搜搜 = new System.Windows.Forms.Panel();
            this.txt关键字 = new System.Windows.Forms.TextBox();
            this.btn检索 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStripTitle = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelTitle = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.labelTree = new System.Windows.Forms.Label();
            this.toolStripRight = new System.Windows.Forms.ToolStrip();
            this.toolBtnShowFT = new System.Windows.Forms.ToolStripButton();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.exCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exWaitState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exFinished = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.单位编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlQuery.SuspendLayout();
            this.pnlleft.SuspendLayout();
            this.pnl搜搜.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStripTitle.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.toolStripRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1193, 40);
            this.lblTitle.TabIndex = 500;
            this.lblTitle.Text = "网上审核处理中心";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn审批
            // 
            this.btn审批.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn审批.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn审批.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn审批.Location = new System.Drawing.Point(0, 0);
            this.btn审批.Name = "btn审批";
            this.btn审批.Size = new System.Drawing.Size(110, 28);
            this.btn审批.TabIndex = 1;
            this.btn审批.Text = "审核(Ctrl+P)";
            this.btn审批.UseVisualStyleBackColor = true;
            this.btn审批.Click += new System.EventHandler(this.btn审批_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn入户凭证);
            this.panel1.Controls.Add(this.btn查看);
            this.panel1.Controls.Add(this.btn关闭);
            this.panel1.Controls.Add(this.btn审批);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 28);
            this.panel1.TabIndex = 502;
            // 
            // btn入户凭证
            // 
            this.btn入户凭证.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn入户凭证.Location = new System.Drawing.Point(185, 0);
            this.btn入户凭证.Name = "btn入户凭证";
            this.btn入户凭证.Size = new System.Drawing.Size(107, 28);
            this.btn入户凭证.TabIndex = 21;
            this.btn入户凭证.Text = "打印入户凭证(&R)";
            this.btn入户凭证.UseVisualStyleBackColor = true;
            this.btn入户凭证.Visible = false;
            this.btn入户凭证.Click += new System.EventHandler(this.btn入户凭证_Click);
            // 
            // btn查看
            // 
            this.btn查看.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn查看.Location = new System.Drawing.Point(110, 0);
            this.btn查看.Name = "btn查看";
            this.btn查看.Size = new System.Drawing.Size(75, 28);
            this.btn查看.TabIndex = 2;
            this.btn查看.Text = "查看(&K)";
            this.btn查看.UseVisualStyleBackColor = true;
            this.btn查看.Click += new System.EventHandler(this.btn查看_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(1118, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 5;
            this.btn关闭.Text = "关 闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = true;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlQuery.Controls.Add(this.cbx审批类型);
            this.pnlQuery.Controls.Add(this.chk仅未审批);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Controls.Add(this.dtp结束时间);
            this.pnlQuery.Controls.Add(this.dtp开始时间);
            this.pnlQuery.Controls.Add(this.chk申请日期);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 68);
            this.pnlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(1193, 30);
            this.pnlQuery.TabIndex = 503;
            // 
            // cbx审批类型
            // 
            this.cbx审批类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx审批类型.FormattingEnabled = true;
            this.cbx审批类型.Items.AddRange(new object[] {
            "所有",
            "年度更新计划",
            "配置申请审核",
            "处置申请审核",
            "入库登记审核",
            "出库登记审核",
            "车辆编制审核"});
            this.cbx审批类型.Location = new System.Drawing.Point(68, 5);
            this.cbx审批类型.Name = "cbx审批类型";
            this.cbx审批类型.Size = new System.Drawing.Size(201, 20);
            this.cbx审批类型.TabIndex = 139;
            this.cbx审批类型.SelectedIndexChanged += new System.EventHandler(this.cbx审批类型_SelectedIndexChanged);
            // 
            // chk仅未审批
            // 
            this.chk仅未审批.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk仅未审批.AutoSize = true;
            this.chk仅未审批.Checked = true;
            this.chk仅未审批.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk仅未审批.ForeColor = System.Drawing.Color.Yellow;
            this.chk仅未审批.Location = new System.Drawing.Point(1033, 8);
            this.chk仅未审批.Name = "chk仅未审批";
            this.chk仅未审批.Size = new System.Drawing.Size(60, 16);
            this.chk仅未审批.TabIndex = 7;
            this.chk仅未审批.Text = "未审批";
            this.chk仅未审批.UseVisualStyleBackColor = true;
            this.chk仅未审批.CheckedChanged += new System.EventHandler(this.chk仅未审批_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 138;
            this.label4.Text = "审核类型：";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuery.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnQuery.Location = new System.Drawing.Point(1118, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtp结束时间
            // 
            this.dtp结束时间.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtp结束时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp结束时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp结束时间.Location = new System.Drawing.Point(677, 5);
            this.dtp结束时间.Name = "dtp结束时间";
            this.dtp结束时间.Size = new System.Drawing.Size(121, 21);
            this.dtp结束时间.TabIndex = 4;
            // 
            // dtp开始时间
            // 
            this.dtp开始时间.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtp开始时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp开始时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp开始时间.Location = new System.Drawing.Point(533, 5);
            this.dtp开始时间.Name = "dtp开始时间";
            this.dtp开始时间.Size = new System.Drawing.Size(122, 21);
            this.dtp开始时间.TabIndex = 3;
            // 
            // chk申请日期
            // 
            this.chk申请日期.AutoSize = true;
            this.chk申请日期.Location = new System.Drawing.Point(450, 8);
            this.chk申请日期.Name = "chk申请日期";
            this.chk申请日期.Size = new System.Drawing.Size(228, 16);
            this.chk申请日期.TabIndex = 8;
            this.chk申请日期.Text = "申请日期从                      至";
            this.chk申请日期.UseVisualStyleBackColor = true;
            this.chk申请日期.CheckedChanged += new System.EventHandler(this.chk申请日期_CheckedChanged);
            // 
            // pnlleft
            // 
            this.pnlleft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlleft.Controls.Add(this.dbTreeView);
            this.pnlleft.Controls.Add(this.pnl搜搜);
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 98);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(288, 500);
            this.pnlleft.TabIndex = 504;
            // 
            // dbTreeView
            // 
            this.dbTreeView.CheckBoxs = false;
            this.dbTreeView.CheckMode = DingnuoControlLibrary.CheckMode.None;
            this.dbTreeView.DataSource = null;
            this.dbTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTreeView.HideSelection = false;
            this.dbTreeView.ImageIndex = 0;
            this.dbTreeView.ImageList = this.iglTree;
            this.dbTreeView.ItemHeight = 18;
            this.dbTreeView.Location = new System.Drawing.Point(0, 75);
            this.dbTreeView.MultiSelect = false;
            this.dbTreeView.Name = "dbTreeView";
            this.dbTreeView.NodeID = "编码";
            this.dbTreeView.NodePID = "上级编码";
            this.dbTreeView.NodeTitle = "全名";
            this.dbTreeView.SelectedImageIndex = 0;
            this.dbTreeView.SelectedNode = null;
            this.dbTreeView.Size = new System.Drawing.Size(284, 421);
            this.dbTreeView.TabIndex = 129;
            this.dbTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dbTreeView_AfterSelect);
            this.dbTreeView.TreeNodeCreated += new DingnuoControlLibrary.TreeNodeCreatedEventHandler(this.dbTreeView_TreeNodeCreated);
            // 
            // iglTree
            // 
            this.iglTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iglTree.ImageStream")));
            this.iglTree.TransparentColor = System.Drawing.Color.Fuchsia;
            this.iglTree.Images.SetKeyName(0, "arrowright_green16.bmp");
            this.iglTree.Images.SetKeyName(1, "stop_blue16.bmp");
            this.iglTree.Images.SetKeyName(2, "AddToFavorites.bmp");
            // 
            // pnl搜搜
            // 
            this.pnl搜搜.BackColor = System.Drawing.SystemColors.Control;
            this.pnl搜搜.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl搜搜.Controls.Add(this.txt关键字);
            this.pnl搜搜.Controls.Add(this.btn检索);
            this.pnl搜搜.Controls.Add(this.panel2);
            this.pnl搜搜.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl搜搜.Location = new System.Drawing.Point(0, 0);
            this.pnl搜搜.Name = "pnl搜搜";
            this.pnl搜搜.Size = new System.Drawing.Size(284, 75);
            this.pnl搜搜.TabIndex = 128;
            // 
            // txt关键字
            // 
            this.txt关键字.Location = new System.Drawing.Point(12, 39);
            this.txt关键字.Name = "txt关键字";
            this.txt关键字.Size = new System.Drawing.Size(178, 21);
            this.txt关键字.TabIndex = 24;
            // 
            // btn检索
            // 
            this.btn检索.Location = new System.Drawing.Point(200, 37);
            this.btn检索.Name = "btn检索";
            this.btn检索.Size = new System.Drawing.Size(75, 23);
            this.btn检索.TabIndex = 23;
            this.btn检索.Text = "检索(&F)";
            this.btn检索.UseVisualStyleBackColor = true;
            this.btn检索.Click += new System.EventHandler(this.btn检索_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStripTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 23);
            this.panel2.TabIndex = 26;
            // 
            // toolStripTitle
            // 
            this.toolStripTitle.Font = new System.Drawing.Font("宋体", 9F);
            this.toolStripTitle.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelTitle,
            this.toolStripButton1});
            this.toolStripTitle.Location = new System.Drawing.Point(0, 0);
            this.toolStripTitle.Name = "toolStripTitle";
            this.toolStripTitle.Size = new System.Drawing.Size(280, 25);
            this.toolStripTitle.TabIndex = 14;
            this.toolStripTitle.Text = "toolStrip";
            // 
            // toolStripLabelTitle
            // 
            this.toolStripLabelTitle.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabelTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.toolStripLabelTitle.Name = "toolStripLabelTitle";
            this.toolStripLabelTitle.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabelTitle.Text = "单位检索";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "隐藏";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(288, 98);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 500);
            this.splitter1.TabIndex = 505;
            this.splitter1.TabStop = false;
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRight.Controls.Add(this.labelTree);
            this.pnlRight.Controls.Add(this.toolStripRight);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRight.Location = new System.Drawing.Point(294, 98);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(33, 500);
            this.pnlRight.TabIndex = 506;
            this.pnlRight.Visible = false;
            // 
            // labelTree
            // 
            this.labelTree.BackColor = System.Drawing.Color.Gainsboro;
            this.labelTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTree.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.labelTree.Location = new System.Drawing.Point(0, 25);
            this.labelTree.Name = "labelTree";
            this.labelTree.Size = new System.Drawing.Size(29, 471);
            this.labelTree.TabIndex = 3;
            this.labelTree.Text = "单位列表";
            this.labelTree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.toolBtnShowFT.Click += new System.EventHandler(this.toolBtnShowFT_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeight = 28;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exCode,
            this.wfName,
            this.exWaitState,
            this.单位名称,
            this.exTitle,
            this.创建人,
            this.CreateTime,
            this.exFinished,
            this.单位编码});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(327, 98);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvList.RowHeadersWidth = 20;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(866, 500);
            this.dgvList.StandardTab = true;
            this.dgvList.TabIndex = 499;
            this.dgvList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvList_MouseDoubleClick);
            // 
            // exCode
            // 
            this.exCode.DataPropertyName = "exCode";
            this.exCode.HeaderText = "exCode";
            this.exCode.Name = "exCode";
            this.exCode.ReadOnly = true;
            this.exCode.Visible = false;
            // 
            // wfName
            // 
            this.wfName.DataPropertyName = "wfName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.wfName.DefaultCellStyle = dataGridViewCellStyle3;
            this.wfName.HeaderText = "类型";
            this.wfName.Name = "wfName";
            this.wfName.ReadOnly = true;
            // 
            // exWaitState
            // 
            this.exWaitState.DataPropertyName = "exWaitState";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.exWaitState.DefaultCellStyle = dataGridViewCellStyle4;
            this.exWaitState.HeaderText = "审核状态";
            this.exWaitState.Name = "exWaitState";
            this.exWaitState.ReadOnly = true;
            this.exWaitState.Width = 300;
            // 
            // 单位名称
            // 
            this.单位名称.DataPropertyName = "单位名称";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.单位名称.DefaultCellStyle = dataGridViewCellStyle5;
            this.单位名称.HeaderText = "申请单位";
            this.单位名称.Name = "单位名称";
            this.单位名称.ReadOnly = true;
            this.单位名称.Width = 200;
            // 
            // exTitle
            // 
            this.exTitle.DataPropertyName = "exTitle";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.exTitle.DefaultCellStyle = dataGridViewCellStyle6;
            this.exTitle.HeaderText = "申请原因/备注";
            this.exTitle.MinimumWidth = 120;
            this.exTitle.Name = "exTitle";
            this.exTitle.ReadOnly = true;
            this.exTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.exTitle.Width = 300;
            // 
            // 创建人
            // 
            this.创建人.DataPropertyName = "创建人";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.创建人.DefaultCellStyle = dataGridViewCellStyle7;
            this.创建人.HeaderText = "申请人";
            this.创建人.Name = "创建人";
            this.创建人.ReadOnly = true;
            this.创建人.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.创建人.Width = 140;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "d";
            this.CreateTime.DefaultCellStyle = dataGridViewCellStyle8;
            this.CreateTime.HeaderText = "申请时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Width = 110;
            // 
            // exFinished
            // 
            this.exFinished.DataPropertyName = "exFinished";
            this.exFinished.FalseValue = "0";
            this.exFinished.HeaderText = "已完成";
            this.exFinished.Name = "exFinished";
            this.exFinished.ReadOnly = true;
            this.exFinished.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.exFinished.TrueValue = "1";
            this.exFinished.Visible = false;
            // 
            // 单位编码
            // 
            this.单位编码.DataPropertyName = "CreateUnitCode";
            this.单位编码.HeaderText = "单位编码";
            this.单位编码.Name = "单位编码";
            this.单位编码.ReadOnly = true;
            this.单位编码.Visible = false;
            // 
            // NET_审批中心
            // 
            this.AcceptButton = this.btn检索;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 598);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlleft);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "NET_审批中心";
            this.Text = "NET_网上审批";
            this.Load += new System.EventHandler(this.NET_审批中心_Load);
            this.panel1.ResumeLayout(false);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            this.pnlleft.ResumeLayout(false);
            this.pnl搜搜.ResumeLayout(false);
            this.pnl搜搜.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStripTitle.ResumeLayout(false);
            this.toolStripTitle.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.toolStripRight.ResumeLayout(false);
            this.toolStripRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn审批;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.CheckBox chk仅未审批;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtp结束时间;
        private System.Windows.Forms.DateTimePicker dtp开始时间;
        private System.Windows.Forms.CheckBox chk申请日期;
        private System.Windows.Forms.Button btn查看;
        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnl搜搜;
        private System.Windows.Forms.TextBox txt关键字;
        private System.Windows.Forms.Button btn检索;
        private DingnuoControlLibrary.DBTreeView dbTreeView;
        private System.Windows.Forms.ImageList iglTree;
        private System.Windows.Forms.ComboBox cbx审批类型;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStripTitle;
        private System.Windows.Forms.ToolStripLabel toolStripLabelTitle;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label labelTree;
        private System.Windows.Forms.ToolStrip toolStripRight;
        private System.Windows.Forms.ToolStripButton toolBtnShowFT;
        private System.Windows.Forms.Button btn入户凭证;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn exCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn wfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn exWaitState;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn exTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建人;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位编码;

    }
}