namespace GCGL_Client.OCC
{
    partial class OCC_公车出库
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn选择单位 = new System.Windows.Forms.Button();
            this.chk包含下级 = new System.Windows.Forms.CheckBox();
            this.txt选择单位 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtp结束时间 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.dtp开始时间 = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btn报废 = new System.Windows.Forms.Button();
            this.btn调拨 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.btn打印 = new System.Windows.Forms.Button();
            this.btn导出 = new System.Windows.Forms.Button();
            this.btn出售出库 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn附件查看 = new System.Windows.Forms.Button();
            this.btn查看 = new System.Windows.Forms.Button();
            this.btn删除 = new System.Windows.Forms.Button();
            this.出库单编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处置申请编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出库单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处置形式编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处置形式名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.接收单位编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.接收人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处置收入 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.收购单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.附件编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.附件摘要 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.调拨日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn选择单位
            // 
            this.btn选择单位.Location = new System.Drawing.Point(262, 6);
            this.btn选择单位.Name = "btn选择单位";
            this.btn选择单位.Size = new System.Drawing.Size(22, 19);
            this.btn选择单位.TabIndex = 11;
            this.btn选择单位.Text = "…";
            this.btn选择单位.UseVisualStyleBackColor = true;
            this.btn选择单位.Click += new System.EventHandler(this.btn选择单位_Click);
            // 
            // chk包含下级
            // 
            this.chk包含下级.AutoSize = true;
            this.chk包含下级.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk包含下级.Location = new System.Drawing.Point(293, 8);
            this.chk包含下级.Name = "chk包含下级";
            this.chk包含下级.Size = new System.Drawing.Size(72, 16);
            this.chk包含下级.TabIndex = 12;
            this.chk包含下级.Text = "包含下级";
            this.chk包含下级.UseVisualStyleBackColor = true;
            // 
            // txt选择单位
            // 
            this.txt选择单位.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt选择单位.ForeColor = System.Drawing.Color.Blue;
            this.txt选择单位.Location = new System.Drawing.Point(65, 5);
            this.txt选择单位.Margin = new System.Windows.Forms.Padding(2);
            this.txt选择单位.Name = "txt选择单位";
            this.txt选择单位.ReadOnly = true;
            this.txt选择单位.Size = new System.Drawing.Size(220, 21);
            this.txt选择单位.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 138;
            this.label4.Text = "查询单位：";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuery.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnQuery.Location = new System.Drawing.Point(899, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 9;
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
            this.dtp结束时间.Location = new System.Drawing.Point(593, 5);
            this.dtp结束时间.Name = "dtp结束时间";
            this.dtp结束时间.Size = new System.Drawing.Size(121, 21);
            this.dtp结束时间.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "出库日期从                      至";
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlQuery.Controls.Add(this.btn选择单位);
            this.pnlQuery.Controls.Add(this.chk包含下级);
            this.pnlQuery.Controls.Add(this.txt选择单位);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Controls.Add(this.dtp结束时间);
            this.pnlQuery.Controls.Add(this.dtp开始时间);
            this.pnlQuery.Controls.Add(this.label3);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 75);
            this.pnlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(974, 30);
            this.pnlQuery.TabIndex = 123;
            // 
            // dtp开始时间
            // 
            this.dtp开始时间.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtp开始时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp开始时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp开始时间.Location = new System.Drawing.Point(449, 5);
            this.dtp开始时间.Name = "dtp开始时间";
            this.dtp开始时间.Size = new System.Drawing.Size(122, 21);
            this.dtp开始时间.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(974, 45);
            this.lblTitle.TabIndex = 122;
            this.lblTitle.Text = "公车出库信息查询列表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeight = 30;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.出库单编码,
            this.处置申请编号,
            this.出库单位,
            this.资产名称,
            this.处置形式编码,
            this.处置形式名称,
            this.接收单位编码,
            this.单位名称,
            this.接收人,
            this.处置收入,
            this.收购单位,
            this.备注,
            this.附件编码,
            this.附件摘要,
            this.调拨日期});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 105);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(974, 508);
            this.dgvList.TabIndex = 6;
            // 
            // btn报废
            // 
            this.btn报废.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn报废.Location = new System.Drawing.Point(0, 0);
            this.btn报废.Name = "btn报废";
            this.btn报废.Size = new System.Drawing.Size(88, 28);
            this.btn报废.TabIndex = 0;
            this.btn报废.Text = "报废出库(&A)";
            this.btn报废.UseVisualStyleBackColor = true;
            this.btn报废.Click += new System.EventHandler(this.btn报废_Click);
            // 
            // btn调拨
            // 
            this.btn调拨.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn调拨.Location = new System.Drawing.Point(88, 0);
            this.btn调拨.Name = "btn调拨";
            this.btn调拨.Size = new System.Drawing.Size(88, 28);
            this.btn调拨.TabIndex = 2;
            this.btn调拨.Text = "调拨出库(&B)";
            this.btn调拨.UseVisualStyleBackColor = true;
            this.btn调拨.Click += new System.EventHandler(this.btn调拨_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(897, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 15;
            this.btn关闭.Text = "关 闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = true;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // btn打印
            // 
            this.btn打印.BackColor = System.Drawing.SystemColors.Control;
            this.btn打印.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn打印.Location = new System.Drawing.Point(822, 0);
            this.btn打印.Name = "btn打印";
            this.btn打印.Size = new System.Drawing.Size(75, 28);
            this.btn打印.TabIndex = 8;
            this.btn打印.Text = "打印(&P)";
            this.btn打印.UseVisualStyleBackColor = false;
            this.btn打印.Click += new System.EventHandler(this.btn打印_Click);
            // 
            // btn导出
            // 
            this.btn导出.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn导出.Location = new System.Drawing.Point(747, 0);
            this.btn导出.Name = "btn导出";
            this.btn导出.Size = new System.Drawing.Size(75, 28);
            this.btn导出.TabIndex = 7;
            this.btn导出.Text = "导出（&E)";
            this.btn导出.UseVisualStyleBackColor = true;
            this.btn导出.Click += new System.EventHandler(this.btn导出_Click);
            // 
            // btn出售出库
            // 
            this.btn出售出库.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn出售出库.Location = new System.Drawing.Point(176, 0);
            this.btn出售出库.Name = "btn出售出库";
            this.btn出售出库.Size = new System.Drawing.Size(88, 28);
            this.btn出售出库.TabIndex = 3;
            this.btn出售出库.Text = "出售出库(&C)";
            this.btn出售出库.UseVisualStyleBackColor = true;
            this.btn出售出库.Click += new System.EventHandler(this.btn出售出库_Click);
            // 
            // btn修改
            // 
            this.btn修改.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn修改.Location = new System.Drawing.Point(264, 0);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(75, 28);
            this.btn修改.TabIndex = 3;
            this.btn修改.Text = "修改（&M)";
            this.btn修改.UseVisualStyleBackColor = true;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn附件查看);
            this.panel1.Controls.Add(this.btn查看);
            this.panel1.Controls.Add(this.btn删除);
            this.panel1.Controls.Add(this.btn修改);
            this.panel1.Controls.Add(this.btn出售出库);
            this.panel1.Controls.Add(this.btn导出);
            this.panel1.Controls.Add(this.btn打印);
            this.panel1.Controls.Add(this.btn关闭);
            this.panel1.Controls.Add(this.btn调拨);
            this.panel1.Controls.Add(this.btn报废);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 30);
            this.panel1.TabIndex = 120;
            // 
            // btn附件查看
            // 
            this.btn附件查看.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn附件查看.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn附件查看.Location = new System.Drawing.Point(489, 0);
            this.btn附件查看.Name = "btn附件查看";
            this.btn附件查看.Size = new System.Drawing.Size(80, 28);
            this.btn附件查看.TabIndex = 6;
            this.btn附件查看.Text = "附件查看(&W)";
            this.btn附件查看.UseVisualStyleBackColor = true;
            this.btn附件查看.Click += new System.EventHandler(this.btn附件查看_Click);
            // 
            // btn查看
            // 
            this.btn查看.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn查看.Location = new System.Drawing.Point(414, 0);
            this.btn查看.Name = "btn查看";
            this.btn查看.Size = new System.Drawing.Size(75, 28);
            this.btn查看.TabIndex = 5;
            this.btn查看.Text = "查看（&K)";
            this.btn查看.UseVisualStyleBackColor = true;
            this.btn查看.Click += new System.EventHandler(this.btn查看_Click);
            // 
            // btn删除
            // 
            this.btn删除.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn删除.Location = new System.Drawing.Point(339, 0);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(75, 28);
            this.btn删除.TabIndex = 4;
            this.btn删除.Text = "删除（&D)";
            this.btn删除.UseVisualStyleBackColor = true;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // 出库单编码
            // 
            this.出库单编码.DataPropertyName = "出库单编码";
            this.出库单编码.HeaderText = "出库单编码";
            this.出库单编码.Name = "出库单编码";
            this.出库单编码.ReadOnly = true;
            this.出库单编码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.出库单编码.Width = 180;
            // 
            // 处置申请编号
            // 
            this.处置申请编号.DataPropertyName = "处置申请编号";
            this.处置申请编号.HeaderText = "处置申请编号";
            this.处置申请编号.Name = "处置申请编号";
            this.处置申请编号.ReadOnly = true;
            this.处置申请编号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.处置申请编号.Visible = false;
            this.处置申请编号.Width = 180;
            // 
            // 出库单位
            // 
            this.出库单位.DataPropertyName = "单位名称";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.出库单位.DefaultCellStyle = dataGridViewCellStyle2;
            this.出库单位.HeaderText = "出库单位";
            this.出库单位.Name = "出库单位";
            this.出库单位.ReadOnly = true;
            this.出库单位.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.出库单位.Width = 150;
            // 
            // 资产名称
            // 
            this.资产名称.DataPropertyName = "资产名称";
            this.资产名称.HeaderText = "资产名称";
            this.资产名称.Name = "资产名称";
            this.资产名称.ReadOnly = true;
            this.资产名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.资产名称.Width = 200;
            // 
            // 处置形式编码
            // 
            this.处置形式编码.DataPropertyName = "处置形式编码";
            this.处置形式编码.HeaderText = "处置形式编码";
            this.处置形式编码.Name = "处置形式编码";
            this.处置形式编码.ReadOnly = true;
            this.处置形式编码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.处置形式编码.Visible = false;
            this.处置形式编码.Width = 160;
            // 
            // 处置形式名称
            // 
            this.处置形式名称.DataPropertyName = "处置形式名称";
            this.处置形式名称.HeaderText = "处置形式";
            this.处置形式名称.Name = "处置形式名称";
            this.处置形式名称.ReadOnly = true;
            this.处置形式名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.处置形式名称.Width = 120;
            // 
            // 接收单位编码
            // 
            this.接收单位编码.DataPropertyName = "接收单位编码";
            this.接收单位编码.HeaderText = "接收单位编码";
            this.接收单位编码.Name = "接收单位编码";
            this.接收单位编码.ReadOnly = true;
            this.接收单位编码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.接收单位编码.Visible = false;
            this.接收单位编码.Width = 170;
            // 
            // 单位名称
            // 
            this.单位名称.DataPropertyName = "接收单位名称";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.单位名称.DefaultCellStyle = dataGridViewCellStyle3;
            this.单位名称.HeaderText = "接收单位名称";
            this.单位名称.Name = "单位名称";
            this.单位名称.ReadOnly = true;
            this.单位名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.单位名称.Width = 150;
            // 
            // 接收人
            // 
            this.接收人.DataPropertyName = "接收人";
            this.接收人.HeaderText = "接收人";
            this.接收人.Name = "接收人";
            this.接收人.ReadOnly = true;
            this.接收人.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.接收人.Width = 150;
            // 
            // 处置收入
            // 
            this.处置收入.DataPropertyName = "处置收入";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.处置收入.DefaultCellStyle = dataGridViewCellStyle4;
            this.处置收入.HeaderText = "处置收入(元)";
            this.处置收入.Name = "处置收入";
            this.处置收入.ReadOnly = true;
            this.处置收入.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 收购单位
            // 
            this.收购单位.DataPropertyName = "收购单位";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.收购单位.DefaultCellStyle = dataGridViewCellStyle5;
            this.收购单位.HeaderText = "收购单位";
            this.收购单位.Name = "收购单位";
            this.收购单位.ReadOnly = true;
            this.收购单位.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.收购单位.Width = 150;
            // 
            // 备注
            // 
            this.备注.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.备注.DataPropertyName = "备注";
            this.备注.HeaderText = "备注";
            this.备注.MinimumWidth = 100;
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 附件编码
            // 
            this.附件编码.DataPropertyName = "附件编码";
            this.附件编码.HeaderText = "文件依据";
            this.附件编码.Name = "附件编码";
            this.附件编码.ReadOnly = true;
            this.附件编码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.附件编码.Visible = false;
            this.附件编码.Width = 120;
            // 
            // 附件摘要
            // 
            this.附件摘要.DataPropertyName = "附件摘要";
            this.附件摘要.HeaderText = "文件依据";
            this.附件摘要.Name = "附件摘要";
            this.附件摘要.ReadOnly = true;
            this.附件摘要.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.附件摘要.Width = 150;
            // 
            // 调拨日期
            // 
            this.调拨日期.DataPropertyName = "调拨日期";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.调拨日期.DefaultCellStyle = dataGridViewCellStyle6;
            this.调拨日期.HeaderText = "调拨日期";
            this.调拨日期.Name = "调拨日期";
            this.调拨日期.ReadOnly = true;
            this.调拨日期.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OCC_公车出库
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 613);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "OCC_公车出库";
            this.Load += new System.EventHandler(this.OCC_公车出库_Load);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn选择单位;
        private System.Windows.Forms.CheckBox chk包含下级;
        private System.Windows.Forms.TextBox txt选择单位;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtp结束时间;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.DateTimePicker dtp开始时间;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btn报废;
        private System.Windows.Forms.Button btn调拨;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.Button btn打印;
        private System.Windows.Forms.Button btn导出;
        private System.Windows.Forms.Button btn出售出库;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn附件查看;
        private System.Windows.Forms.Button btn查看;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出库单编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处置申请编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出库单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处置形式编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处置形式名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 接收单位编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 接收人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处置收入;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收购单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn 附件编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 附件摘要;
        private System.Windows.Forms.DataGridViewTextBoxColumn 调拨日期;
    }
}