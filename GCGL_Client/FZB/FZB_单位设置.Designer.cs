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
            this.pnl单位信息 = new System.Windows.Forms.Panel();
            this.lbl部门预算处室名称 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.pnl11 = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.处室编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处室名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处室类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处室类型名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.有效 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl处室 = new System.Windows.Forms.Panel();
            this.lbl处室列表 = new System.Windows.Forms.Label();
            this.btn添加处室 = new System.Windows.Forms.Button();
            this.btn修改处室 = new System.Windows.Forms.Button();
            this.btn删除处室 = new System.Windows.Forms.Button();
            this.btn检索 = new System.Windows.Forms.Button();
            this.txt关键字 = new System.Windows.Forms.TextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnl搜搜 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlright = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlTool.SuspendLayout();
            this.pnl单位信息.SuspendLayout();
            this.pnl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnl处室.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnl搜搜.SuspendLayout();
            this.pnlright.SuspendLayout();
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
            this.LblTitle.Text = "单位信息";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn修改
            // 
            this.btn修改.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn修改.Location = new System.Drawing.Point(95, 0);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(95, 28);
            this.btn修改.TabIndex = 2;
            this.btn修改.Text = "修改(&M)";
            this.btn修改.UseVisualStyleBackColor = true;
            this.btn修改.Visible = false;
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
            this.btn新增.Visible = false;
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
            this.btn删除.TabIndex = 3;
            this.btn删除.Text = "删除单位(&D)";
            this.btn删除.UseVisualStyleBackColor = true;
            this.btn删除.Visible = false;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(987, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 4;
            this.btn关闭.Text = "关闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = true;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
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
            this.dbTreeView.Location = new System.Drawing.Point(0, 61);
            this.dbTreeView.MultiSelect = false;
            this.dbTreeView.Name = "dbTreeView";
            this.dbTreeView.NodeID = "编码";
            this.dbTreeView.NodePID = "上级编码";
            this.dbTreeView.NodeTitle = "全名";
            this.dbTreeView.SelectedImageIndex = 0;
            this.dbTreeView.SelectedNode = null;
            this.dbTreeView.Size = new System.Drawing.Size(281, 494);
            this.dbTreeView.TabIndex = 126;
            this.dbTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dbTreeView_AfterSelect);
            this.dbTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dbTreeView_NodeMouseClick);
            this.dbTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dbTreeView_NodeMouseDoubleClick);
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
            // pnl单位信息
            // 
            this.pnl单位信息.BackColor = System.Drawing.SystemColors.Control;
            this.pnl单位信息.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl单位信息.Controls.Add(this.lbl部门预算处室名称);
            this.pnl单位信息.Controls.Add(this.label10);
            this.pnl单位信息.Controls.Add(this.lbl传真);
            this.pnl单位信息.Controls.Add(this.lbl电话);
            this.pnl单位信息.Controls.Add(this.lbl联系人);
            this.pnl单位信息.Controls.Add(this.lbl邮编);
            this.pnl单位信息.Controls.Add(this.lbl单位性质名称);
            this.pnl单位信息.Controls.Add(this.lbl组织代码证号);
            this.pnl单位信息.Controls.Add(this.lbl单位类型名称);
            this.pnl单位信息.Controls.Add(this.lbl单位地址);
            this.pnl单位信息.Controls.Add(this.lbl单位名称);
            this.pnl单位信息.Controls.Add(this.lbl预算编码);
            this.pnl单位信息.Controls.Add(this.label4);
            this.pnl单位信息.Controls.Add(this.label2);
            this.pnl单位信息.Controls.Add(this.label1);
            this.pnl单位信息.Controls.Add(this.label6);
            this.pnl单位信息.Controls.Add(this.label9);
            this.pnl单位信息.Controls.Add(this.label7);
            this.pnl单位信息.Controls.Add(this.label11);
            this.pnl单位信息.Controls.Add(this.label8);
            this.pnl单位信息.Controls.Add(this.label5);
            this.pnl单位信息.Controls.Add(this.label3);
            this.pnl单位信息.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl单位信息.Location = new System.Drawing.Point(0, 0);
            this.pnl单位信息.Name = "pnl单位信息";
            this.pnl单位信息.Size = new System.Drawing.Size(775, 157);
            this.pnl单位信息.TabIndex = 129;
            // 
            // lbl部门预算处室名称
            // 
            this.lbl部门预算处室名称.AutoSize = true;
            this.lbl部门预算处室名称.ForeColor = System.Drawing.Color.Blue;
            this.lbl部门预算处室名称.Location = new System.Drawing.Point(654, 53);
            this.lbl部门预算处室名称.Name = "lbl部门预算处室名称";
            this.lbl部门预算处室名称.Size = new System.Drawing.Size(53, 12);
            this.lbl部门预算处室名称.TabIndex = 22;
            this.lbl部门预算处室名称.Text = "财政归口";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(594, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "财政归口：";
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
            this.lbl电话.Text = "办公电话";
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
            this.lbl单位类型名称.TextChanged += new System.EventHandler(this.lbl单位类型名称_TextChanged);
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
            this.label9.Text = "办公电话：";
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
            this.label11.Location = new System.Drawing.Point(595, 85);
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
            // pnl11
            // 
            this.pnl11.Controls.Add(this.dgvList);
            this.pnl11.Controls.Add(this.pnl处室);
            this.pnl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl11.Location = new System.Drawing.Point(0, 157);
            this.pnl11.Name = "pnl11";
            this.pnl11.Size = new System.Drawing.Size(775, 398);
            this.pnl11.TabIndex = 130;
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
            this.dgvList.Size = new System.Drawing.Size(775, 370);
            this.dgvList.TabIndex = 127;
            // 
            // 处室编码
            // 
            this.处室编码.DataPropertyName = "处室编码";
            this.处室编码.HeaderText = "处室编码";
            this.处室编码.Name = "处室编码";
            this.处室编码.ReadOnly = true;
            this.处室编码.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.处室类型.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.处室类型名称.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // 有效
            // 
            this.有效.DataPropertyName = "有效";
            this.有效.HeaderText = "有效";
            this.有效.Name = "有效";
            this.有效.ReadOnly = true;
            this.有效.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // pnl处室
            // 
            this.pnl处室.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl处室.Controls.Add(this.lbl处室列表);
            this.pnl处室.Controls.Add(this.btn添加处室);
            this.pnl处室.Controls.Add(this.btn修改处室);
            this.pnl处室.Controls.Add(this.btn删除处室);
            this.pnl处室.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl处室.Location = new System.Drawing.Point(0, 0);
            this.pnl处室.Name = "pnl处室";
            this.pnl处室.Size = new System.Drawing.Size(775, 28);
            this.pnl处室.TabIndex = 128;
            // 
            // lbl处室列表
            // 
            this.lbl处室列表.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl处室列表.Location = new System.Drawing.Point(2, 0);
            this.lbl处室列表.Name = "lbl处室列表";
            this.lbl处室列表.Size = new System.Drawing.Size(523, 28);
            this.lbl处室列表.TabIndex = 8;
            this.lbl处室列表.Text = "处室列表";
            this.lbl处室列表.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn添加处室
            // 
            this.btn添加处室.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn添加处室.Enabled = false;
            this.btn添加处室.Location = new System.Drawing.Point(550, 0);
            this.btn添加处室.Name = "btn添加处室";
            this.btn添加处室.Size = new System.Drawing.Size(75, 28);
            this.btn添加处室.TabIndex = 7;
            this.btn添加处室.Text = "添加处室";
            this.btn添加处室.UseVisualStyleBackColor = true;
            this.btn添加处室.Click += new System.EventHandler(this.btn添加处室_Click);
            // 
            // btn修改处室
            // 
            this.btn修改处室.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn修改处室.Enabled = false;
            this.btn修改处室.Location = new System.Drawing.Point(625, 0);
            this.btn修改处室.Name = "btn修改处室";
            this.btn修改处室.Size = new System.Drawing.Size(75, 28);
            this.btn修改处室.TabIndex = 6;
            this.btn修改处室.Text = "修改处室";
            this.btn修改处室.UseVisualStyleBackColor = true;
            this.btn修改处室.Click += new System.EventHandler(this.btn修改处室_Click);
            // 
            // btn删除处室
            // 
            this.btn删除处室.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn删除处室.Enabled = false;
            this.btn删除处室.Location = new System.Drawing.Point(700, 0);
            this.btn删除处室.Name = "btn删除处室";
            this.btn删除处室.Size = new System.Drawing.Size(75, 28);
            this.btn删除处室.TabIndex = 5;
            this.btn删除处室.Text = "删除处室";
            this.btn删除处室.UseVisualStyleBackColor = true;
            this.btn删除处室.Click += new System.EventHandler(this.btn删除处室_Click);
            // 
            // btn检索
            // 
            this.btn检索.Location = new System.Drawing.Point(200, 26);
            this.btn检索.Name = "btn检索";
            this.btn检索.Size = new System.Drawing.Size(75, 23);
            this.btn检索.TabIndex = 23;
            this.btn检索.Text = "检索";
            this.btn检索.UseVisualStyleBackColor = true;
            this.btn检索.Click += new System.EventHandler(this.btn检索_Click);
            // 
            // txt关键字
            // 
            this.txt关键字.Location = new System.Drawing.Point(12, 28);
            this.txt关键字.Name = "txt关键字";
            this.txt关键字.Size = new System.Drawing.Size(178, 21);
            this.txt关键字.TabIndex = 24;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.dbTreeView);
            this.pnlLeft.Controls.Add(this.pnl搜搜);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 68);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(281, 555);
            this.pnlLeft.TabIndex = 131;
            // 
            // pnl搜搜
            // 
            this.pnl搜搜.BackColor = System.Drawing.SystemColors.Control;
            this.pnl搜搜.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl搜搜.Controls.Add(this.label12);
            this.pnl搜搜.Controls.Add(this.txt关键字);
            this.pnl搜搜.Controls.Add(this.btn检索);
            this.pnl搜搜.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl搜搜.Location = new System.Drawing.Point(0, 0);
            this.pnl搜搜.Name = "pnl搜搜";
            this.pnl搜搜.Size = new System.Drawing.Size(281, 61);
            this.pnl搜搜.TabIndex = 127;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(277, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "单位检索";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlright
            // 
            this.pnlright.BackColor = System.Drawing.Color.DarkRed;
            this.pnlright.Controls.Add(this.pnl11);
            this.pnlright.Controls.Add(this.pnl单位信息);
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlright.Location = new System.Drawing.Point(287, 68);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(775, 555);
            this.pnlright.TabIndex = 132;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(281, 68);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 555);
            this.splitter1.TabIndex = 133;
            this.splitter1.TabStop = false;
            // 
            // FZB_单位设置
            // 
            this.AcceptButton = this.btn检索;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 623);
            this.Controls.Add(this.pnlright);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.pnlTool);
            this.Name = "FZB_单位设置";
            this.Load += new System.EventHandler(this.FZB_单位设置_Load);
            this.pnlTool.ResumeLayout(false);
            this.pnl单位信息.ResumeLayout(false);
            this.pnl单位信息.PerformLayout();
            this.pnl11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnl处室.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnl搜搜.ResumeLayout(false);
            this.pnl搜搜.PerformLayout();
            this.pnlright.ResumeLayout(false);
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
        private System.Windows.Forms.ImageList iglTree;
        private System.Windows.Forms.Panel pnl单位信息;
        private System.Windows.Forms.Panel pnl11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnl处室;
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
        private System.Windows.Forms.Label lbl部门预算处室名称;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl处室列表;
        private System.Windows.Forms.TextBox txt关键字;
        private System.Windows.Forms.Button btn检索;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnl搜搜;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处室编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处室名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处室类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处室类型名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 有效;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建时间;
        private System.Windows.Forms.Panel pnlright;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label12;
    }
}