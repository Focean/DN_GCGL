namespace GCGL_Client.FZB
{
    partial class FZB_单位设置
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FZB_单位设置));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTitle = new System.Windows.Forms.Label();
            this.btn修改 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btn删除 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.dbTreeView = new DingnuoControlLibrary.DBTreeView();
            this.iglTree = new System.Windows.Forms.ImageList(this.components);
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.处室编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处室名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处室类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处室类型名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.有效 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl传真 = new System.Windows.Forms.Label();
            this.lbl电话 = new System.Windows.Forms.Label();
            this.lbl联系人 = new System.Windows.Forms.Label();
            this.lbl邮编 = new System.Windows.Forms.Label();
            this.lbl单位性质名称 = new System.Windows.Forms.Label();
            this.lbl组织代码证号 = new System.Windows.Forms.Label();
            this.lbl单位类型名称 = new System.Windows.Forms.Label();
            this.lbl单位地址 = new System.Windows.Forms.Label();
            this.lbl单位名称 = new System.Windows.Forms.Label();
            this.lbl预算编码 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn删除处室 = new System.Windows.Forms.Button();
            this.btn修改处室 = new System.Windows.Forms.Button();
            this.btn添加处室 = new System.Windows.Forms.Button();
            this.pnlTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblTitle.Location = new System.Drawing.Point(0, 28);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(1062, 40);
            this.LblTitle.TabIndex = 122;
            this.LblTitle.Text = "预算单位信息管理";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn修改
            // 
            this.btn修改.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn修改.Location = new System.Drawing.Point(95, 0);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(95, 28);
            this.btn修改.TabIndex = 2;
            this.btn修改.Text = "修改单位(&M)";
            this.btn修改.UseVisualStyleBackColor = true;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // btn新增
            // 
            this.btn新增.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn新增.Location = new System.Drawing.Point(0, 0);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(95, 28);
            this.btn新增.TabIndex = 1;
            this.btn新增.Text = "新增单位(&A)";
            this.btn新增.UseVisualStyleBackColor = true;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTool.Controls.Add(this.btn删除);
            this.pnlTool.Controls.Add(this.btn修改);
            this.pnlTool.Controls.Add(this.btn新增);
            this.pnlTool.Controls.Add(this.btn关闭);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(1062, 28);
            this.pnlTool.TabIndex = 124;
            // 
            // btn删除
            // 
            this.btn删除.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn删除.Location = new System.Drawing.Point(190, 0);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(95, 28);
            this.btn删除.TabIndex = 8;
            this.btn删除.Text = "删除单位(&D)";
            this.btn删除.UseVisualStyleBackColor = true;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(987, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 7;
            this.btn关闭.Text = "关闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = true;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // dbTreeView
            // 
            this.dbTreeView.CheckBoxs = false;
            this.dbTreeView.CheckMode = DingnuoControlLibrary.CheckMode.None;
            this.dbTreeView.DataSource = null;
            this.dbTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.dbTreeView.HideSelection = false;
            this.dbTreeView.ImageIndex = 0;
            this.dbTreeView.ImageList = this.iglTree;
            this.dbTreeView.ItemHeight = 18;
            this.dbTreeView.Location = new System.Drawing.Point(0, 68);
            this.dbTreeView.MultiSelect = false;
            this.dbTreeView.Name = "dbTreeView";
            this.dbTreeView.NodeID = "编码";
            this.dbTreeView.NodePID = "上级编码";
            this.dbTreeView.NodeTitle = "全名";
            this.dbTreeView.SelectedImageIndex = 0;
            this.dbTreeView.SelectedNode = null;
            this.dbTreeView.Size = new System.Drawing.Size(310, 555);
            this.dbTreeView.TabIndex = 126;
            this.dbTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dbTreeView_NodeMouseClick);
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
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeight = 28;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.处室编码,
            this.单位编码,
            this.单位名称,
            this.处室名称,
            this.处室类型,
            this.处室类型名称,
            this.有效,
            this.创建时间});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 28);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(746, 370);
            this.dgvList.TabIndex = 127;
            // 
            // 处室编码
            // 
            this.处室编码.DataPropertyName = "处室编码";
            this.处室编码.HeaderText = "处室编码";
            this.处室编码.Name = "处室编码";
            this.处室编码.ReadOnly = true;
            this.处室编码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 单位编码
            // 
            this.单位编码.DataPropertyName = "单位编码";
            this.单位编码.HeaderText = "单位编码";
            this.单位编码.Name = "单位编码";
            this.单位编码.ReadOnly = true;
            this.单位编码.Visible = false;
            // 
            // 单位名称
            // 
            this.单位名称.DataPropertyName = "单位名称";
            this.单位名称.HeaderText = "单位名称";
            this.单位名称.Name = "单位名称";
            this.单位名称.ReadOnly = true;
            this.单位名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.单位名称.Visible = false;
            // 
            // 处室名称
            // 
            this.处室名称.DataPropertyName = "处室名称";
            this.处室名称.HeaderText = "处室名称";
            this.处室名称.Name = "处室名称";
            this.处室名称.ReadOnly = true;
            this.处室名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 处室类型
            // 
            this.处室类型.DataPropertyName = "处室类型";
            this.处室类型.HeaderText = "处室类型";
            this.处室类型.Name = "处室类型";
            this.处室类型.ReadOnly = true;
            this.处室类型.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.处室类型.Visible = false;
            this.处室类型.Width = 150;
            // 
            // 处室类型名称
            // 
            this.处室类型名称.DataPropertyName = "处室类型名称";
            this.处室类型名称.HeaderText = "处室类型";
            this.处室类型名称.Name = "处室类型名称";
            this.处室类型名称.ReadOnly = true;
            // 
            // 有效
            // 
            this.有效.DataPropertyName = "有效";
            this.有效.HeaderText = "有效";
            this.有效.Name = "有效";
            this.有效.ReadOnly = true;
            this.有效.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 创建时间
            // 
            this.创建时间.DataPropertyName = "创建时间";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.创建时间.DefaultCellStyle = dataGridViewCellStyle2;
            this.创建时间.HeaderText = "创建时间";
            this.创建时间.Name = "创建时间";
            this.创建时间.ReadOnly = true;
            this.创建时间.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(310, 68);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 555);
            this.splitter1.TabIndex = 128;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl传真);
            this.panel2.Controls.Add(this.lbl电话);
            this.panel2.Controls.Add(this.lbl联系人);
            this.panel2.Controls.Add(this.lbl邮编);
            this.panel2.Controls.Add(this.lbl单位性质名称);
            this.panel2.Controls.Add(this.lbl组织代码证号);
            this.panel2.Controls.Add(this.lbl单位类型名称);
            this.panel2.Controls.Add(this.lbl单位地址);
            this.panel2.Controls.Add(this.lbl单位名称);
            this.panel2.Controls.Add(this.lbl预算编码);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(316, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 157);
            this.panel2.TabIndex = 129;
            // 
            // lbl传真
            // 
            this.lbl传真.AutoSize = true;
            this.lbl传真.ForeColor = System.Drawing.Color.Blue;
            this.lbl传真.Location = new System.Drawing.Point(457, 117);
            this.lbl传真.Name = "lbl传真";
            this.lbl传真.Size = new System.Drawing.Size(29, 12);
            this.lbl传真.TabIndex = 20;
            this.lbl传真.Text = "传真";
            // 
            // lbl电话
            // 
            this.lbl电话.AutoSize = true;
            this.lbl电话.ForeColor = System.Drawing.Color.Blue;
            this.lbl电话.Location = new System.Drawing.Point(262, 117);
            this.lbl电话.Name = "lbl电话";
            this.lbl电话.Size = new System.Drawing.Size(53, 12);
            this.lbl电话.TabIndex = 19;
            this.lbl电话.Text = "联系电话";
            // 
            // lbl联系人
            // 
            this.lbl联系人.AutoSize = true;
            this.lbl联系人.ForeColor = System.Drawing.Color.Blue;
            this.lbl联系人.Location = new System.Drawing.Point(85, 117);
            this.lbl联系人.Name = "lbl联系人";
            this.lbl联系人.Size = new System.Drawing.Size(41, 12);
            this.lbl联系人.TabIndex = 18;
            this.lbl联系人.Text = "联系人";
            // 
            // lbl邮编
            // 
            this.lbl邮编.AutoSize = true;
            this.lbl邮编.ForeColor = System.Drawing.Color.Blue;
            this.lbl邮编.Location = new System.Drawing.Point(654, 85);
            this.lbl邮编.Name = "lbl邮编";
            this.lbl邮编.Size = new System.Drawing.Size(29, 12);
            this.lbl邮编.TabIndex = 17;
            this.lbl邮编.Text = "邮编";
            // 
            // lbl单位性质名称
            // 
            this.lbl单位性质名称.AutoSize = true;
            this.lbl单位性质名称.ForeColor = System.Drawing.Color.Blue;
            this.lbl单位性质名称.Location = new System.Drawing.Point(654, 21);
            this.lbl单位性质名称.Name = "lbl单位性质名称";
            this.lbl单位性质名称.Size = new System.Drawing.Size(53, 12);
            this.lbl单位性质名称.TabIndex = 16;
            this.lbl单位性质名称.Text = "单位性质";
            // 
            // lbl组织代码证号
            // 
            this.lbl组织代码证号.AutoSize = true;
            this.lbl组织代码证号.ForeColor = System.Drawing.Color.Blue;
            this.lbl组织代码证号.Location = new System.Drawing.Point(457, 21);
            this.lbl组织代码证号.Name = "lbl组织代码证号";
            this.lbl组织代码证号.Size = new System.Drawing.Size(77, 12);
            this.lbl组织代码证号.TabIndex = 15;
            this.lbl组织代码证号.Text = "组织代码证号";
            // 
            // lbl单位类型名称
            // 
            this.lbl单位类型名称.AutoSize = true;
            this.lbl单位类型名称.ForeColor = System.Drawing.Color.Blue;
            this.lbl单位类型名称.Location = new System.Drawing.Point(262, 21);
            this.lbl单位类型名称.Name = "lbl单位类型名称";
            this.lbl单位类型名称.Size = new System.Drawing.Size(53, 12);
            this.lbl单位类型名称.TabIndex = 14;
            this.lbl单位类型名称.Text = "单位类型";
            // 
            // lbl单位地址
            // 
            this.lbl单位地址.AutoSize = true;
            this.lbl单位地址.ForeColor = System.Drawing.Color.Blue;
            this.lbl单位地址.Location = new System.Drawing.Point(85, 85);
            this.lbl单位地址.Name = "lbl单位地址";
            this.lbl单位地址.Size = new System.Drawing.Size(53, 12);
            this.lbl单位地址.TabIndex = 13;
            this.lbl单位地址.Text = "单位地址";
            // 
            // lbl单位名称
            // 
            this.lbl单位名称.AutoSize = true;
            this.lbl单位名称.ForeColor = System.Drawing.Color.Blue;
            this.lbl单位名称.Location = new System.Drawing.Point(85, 53);
            this.lbl单位名称.Name = "lbl单位名称";
            this.lbl单位名称.Size = new System.Drawing.Size(53, 12);
            this.lbl单位名称.TabIndex = 12;
            this.lbl单位名称.Text = "单位名称";
            // 
            // lbl预算编码
            // 
            this.lbl预算编码.AutoSize = true;
            this.lbl预算编码.ForeColor = System.Drawing.Color.Blue;
            this.lbl预算编码.Location = new System.Drawing.Point(85, 21);
            this.lbl预算编码.Name = "lbl预算编码";
            this.lbl预算编码.Size = new System.Drawing.Size(53, 12);
            this.lbl预算编码.TabIndex = 11;
            this.lbl预算编码.Text = "预算编码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "传    真：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "预算编码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "单位名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "单位性质：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "联系电话：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "单位地址：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(592, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "邮    编：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "联 系 人：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "单位类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "组织代码证号：";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvList);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(316, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 398);
            this.panel3.TabIndex = 130;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.btn删除处室);
            this.panel4.Controls.Add(this.btn修改处室);
            this.panel4.Controls.Add(this.btn添加处室);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(746, 28);
            this.panel4.TabIndex = 128;
            // 
            // btn删除处室
            // 
            this.btn删除处室.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn删除处室.Enabled = false;
            this.btn删除处室.Location = new System.Drawing.Point(150, 0);
            this.btn删除处室.Name = "btn删除处室";
            this.btn删除处室.Size = new System.Drawing.Size(75, 28);
            this.btn删除处室.TabIndex = 13;
            this.btn删除处室.Text = "删除处室";
            this.btn删除处室.UseVisualStyleBackColor = true;
            this.btn删除处室.Click += new System.EventHandler(this.btn删除处室_Click);
            // 
            // btn修改处室
            // 
            this.btn修改处室.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn修改处室.Enabled = false;
            this.btn修改处室.Location = new System.Drawing.Point(75, 0);
            this.btn修改处室.Name = "btn修改处室";
            this.btn修改处室.Size = new System.Drawing.Size(75, 28);
            this.btn修改处室.TabIndex = 14;
            this.btn修改处室.Text = "修改处室";
            this.btn修改处室.UseVisualStyleBackColor = true;
            this.btn修改处室.Click += new System.EventHandler(this.btn修改处室_Click);
            // 
            // btn添加处室
            // 
            this.btn添加处室.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn添加处室.Enabled = false;
            this.btn添加处室.Location = new System.Drawing.Point(0, 0);
            this.btn添加处室.Name = "btn添加处室";
            this.btn添加处室.Size = new System.Drawing.Size(75, 28);
            this.btn添加处室.TabIndex = 12;
            this.btn添加处室.Text = "添加处室";
            this.btn添加处室.UseVisualStyleBackColor = true;
            this.btn添加处室.Click += new System.EventHandler(this.btn添加处室_Click);
            // 
            // FZB_单位设置
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 623);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dbTreeView);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.pnlTool);
            this.Name = "FZB_单位设置";
            this.Text = "FZB_单位设置";
            this.Load += new System.EventHandler(this.FZB_单位设置_Load);
            this.pnlTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.Button btn关闭;
        private DingnuoControlLibrary.DBTreeView dbTreeView;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ImageList iglTree;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处室编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处室名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处室类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处室类型名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 有效;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建时间;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn删除处室;
        private System.Windows.Forms.Button btn修改处室;
        private System.Windows.Forms.Button btn添加处室;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl单位名称;
        private System.Windows.Forms.Label lbl预算编码;
        private System.Windows.Forms.Label lbl单位地址;
        private System.Windows.Forms.Label lbl传真;
        private System.Windows.Forms.Label lbl电话;
        private System.Windows.Forms.Label lbl联系人;
        private System.Windows.Forms.Label lbl邮编;
        private System.Windows.Forms.Label lbl单位性质名称;
        private System.Windows.Forms.Label lbl组织代码证号;
        private System.Windows.Forms.Label lbl单位类型名称;
    }
}