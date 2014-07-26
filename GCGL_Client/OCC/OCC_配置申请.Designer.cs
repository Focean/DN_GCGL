namespace GCGL_Client.OCC
{
    partial class OCC_配置申请
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn导出 = new System.Windows.Forms.Button();
            this.btn查看 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.btn删除 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.申请编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.预算单位名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请总数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请总金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请原因 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exWaitState2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.btn选择单位 = new System.Windows.Forms.Button();
            this.chk包含下级 = new System.Windows.Forms.CheckBox();
            this.txt选择单位 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtp结束时间 = new System.Windows.Forms.DateTimePicker();
            this.dtp开始时间 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn撤销 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn查看);
            this.panel1.Controls.Add(this.btn撤销);
            this.panel1.Controls.Add(this.btn导出);
            this.panel1.Controls.Add(this.btn关闭);
            this.panel1.Controls.Add(this.btn删除);
            this.panel1.Controls.Add(this.btn修改);
            this.panel1.Controls.Add(this.btn新增);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 30);
            this.panel1.TabIndex = 3;
            // 
            // btn导出
            // 
            this.btn导出.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn导出.Location = new System.Drawing.Point(723, 0);
            this.btn导出.Name = "btn导出";
            this.btn导出.Size = new System.Drawing.Size(75, 28);
            this.btn导出.TabIndex = 5;
            this.btn导出.Text = "导出（&E)";
            this.btn导出.UseVisualStyleBackColor = true;
            this.btn导出.Click += new System.EventHandler(this.btn导出_Click);
            // 
            // btn查看
            // 
            this.btn查看.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn查看.Location = new System.Drawing.Point(300, 0);
            this.btn查看.Name = "btn查看";
            this.btn查看.Size = new System.Drawing.Size(75, 28);
            this.btn查看.TabIndex = 4;
            this.btn查看.Text = "查看（&K)";
            this.btn查看.UseVisualStyleBackColor = true;
            this.btn查看.Click += new System.EventHandler(this.btn查看_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(798, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 3;
            this.btn关闭.Text = "关 闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = true;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // btn删除
            // 
            this.btn删除.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn删除.Enabled = false;
            this.btn删除.Location = new System.Drawing.Point(150, 0);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(75, 28);
            this.btn删除.TabIndex = 2;
            this.btn删除.Text = "删除（&D)";
            this.btn删除.UseVisualStyleBackColor = true;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // btn修改
            // 
            this.btn修改.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn修改.Enabled = false;
            this.btn修改.Location = new System.Drawing.Point(75, 0);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(75, 28);
            this.btn修改.TabIndex = 1;
            this.btn修改.Text = "修改（&M)";
            this.btn修改.UseVisualStyleBackColor = true;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // btn新增
            // 
            this.btn新增.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn新增.Enabled = false;
            this.btn新增.Location = new System.Drawing.Point(0, 0);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(75, 28);
            this.btn新增.TabIndex = 0;
            this.btn新增.Text = "新建（&N)";
            this.btn新增.UseVisualStyleBackColor = true;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(875, 45);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "公车配置申请查询列表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvList.ColumnHeadersHeight = 28;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.申请编号,
            this.预算单位名称,
            this.申请总数,
            this.申请总金额,
            this.申请原因,
            this.申请备注,
            this.exWaitState2,
            this.单位名称,
            this.创建人,
            this.创建时间});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 105);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvList.RowHeadersWidth = 28;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(875, 287);
            this.dgvList.TabIndex = 14;
            // 
            // 申请编号
            // 
            this.申请编号.DataPropertyName = "申请编号";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.申请编号.DefaultCellStyle = dataGridViewCellStyle14;
            this.申请编号.HeaderText = "申请编号";
            this.申请编号.MinimumWidth = 20;
            this.申请编号.Name = "申请编号";
            this.申请编号.ReadOnly = true;
            this.申请编号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.申请编号.Width = 120;
            // 
            // 预算单位名称
            // 
            this.预算单位名称.DataPropertyName = "预算单位名称";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.预算单位名称.DefaultCellStyle = dataGridViewCellStyle15;
            this.预算单位名称.HeaderText = "预算单位";
            this.预算单位名称.Name = "预算单位名称";
            this.预算单位名称.ReadOnly = true;
            this.预算单位名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.预算单位名称.Width = 150;
            // 
            // 申请总数
            // 
            this.申请总数.DataPropertyName = "申请总数";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.申请总数.DefaultCellStyle = dataGridViewCellStyle16;
            this.申请总数.HeaderText = "申请总数(台)";
            this.申请总数.Name = "申请总数";
            this.申请总数.ReadOnly = true;
            this.申请总数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.申请总数.Width = 90;
            // 
            // 申请总金额
            // 
            this.申请总金额.DataPropertyName = "申请总金额";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            this.申请总金额.DefaultCellStyle = dataGridViewCellStyle17;
            this.申请总金额.HeaderText = "申请总金额(万元)";
            this.申请总金额.Name = "申请总金额";
            this.申请总金额.ReadOnly = true;
            this.申请总金额.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.申请总金额.Width = 120;
            // 
            // 申请原因
            // 
            this.申请原因.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.申请原因.DataPropertyName = "申请原因";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.申请原因.DefaultCellStyle = dataGridViewCellStyle18;
            this.申请原因.FillWeight = 60F;
            this.申请原因.HeaderText = "申请原因";
            this.申请原因.MinimumWidth = 150;
            this.申请原因.Name = "申请原因";
            this.申请原因.ReadOnly = true;
            this.申请原因.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 申请备注
            // 
            this.申请备注.DataPropertyName = "申请备注";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.申请备注.DefaultCellStyle = dataGridViewCellStyle19;
            this.申请备注.FillWeight = 40F;
            this.申请备注.HeaderText = "备注";
            this.申请备注.MinimumWidth = 100;
            this.申请备注.Name = "申请备注";
            this.申请备注.ReadOnly = true;
            this.申请备注.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.申请备注.Width = 150;
            // 
            // exWaitState2
            // 
            this.exWaitState2.DataPropertyName = "exWaitState2";
            this.exWaitState2.HeaderText = "审批状态";
            this.exWaitState2.Name = "exWaitState2";
            this.exWaitState2.ReadOnly = true;
            this.exWaitState2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.exWaitState2.Width = 150;
            // 
            // 单位名称
            // 
            this.单位名称.DataPropertyName = "单位名称";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.NullValue = null;
            this.单位名称.DefaultCellStyle = dataGridViewCellStyle20;
            this.单位名称.HeaderText = "提交单位";
            this.单位名称.MinimumWidth = 80;
            this.单位名称.Name = "单位名称";
            this.单位名称.ReadOnly = true;
            this.单位名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.单位名称.Width = 200;
            // 
            // 创建人
            // 
            this.创建人.DataPropertyName = "创建人";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.创建人.DefaultCellStyle = dataGridViewCellStyle21;
            this.创建人.HeaderText = "申请人";
            this.创建人.Name = "创建人";
            this.创建人.ReadOnly = true;
            this.创建人.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.创建人.Width = 80;
            // 
            // 创建时间
            // 
            this.创建时间.DataPropertyName = "创建时间";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Format = "d";
            dataGridViewCellStyle22.NullValue = null;
            this.创建时间.DefaultCellStyle = dataGridViewCellStyle22;
            this.创建时间.HeaderText = "申请日期";
            this.创建时间.Name = "创建时间";
            this.创建时间.ReadOnly = true;
            this.创建时间.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.创建时间.Width = 110;
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
            this.pnlQuery.Size = new System.Drawing.Size(875, 30);
            this.pnlQuery.TabIndex = 119;
            // 
            // btn选择单位
            // 
            this.btn选择单位.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn选择单位.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn选择单位.Location = new System.Drawing.Point(267, 5);
            this.btn选择单位.Name = "btn选择单位";
            this.btn选择单位.Size = new System.Drawing.Size(22, 21);
            this.btn选择单位.TabIndex = 140;
            this.btn选择单位.Text = "…";
            this.btn选择单位.UseVisualStyleBackColor = false;
            this.btn选择单位.Click += new System.EventHandler(this.btn选择单位_Click);
            // 
            // chk包含下级
            // 
            this.chk包含下级.AutoSize = true;
            this.chk包含下级.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk包含下级.Location = new System.Drawing.Point(297, 8);
            this.chk包含下级.Name = "chk包含下级";
            this.chk包含下级.Size = new System.Drawing.Size(72, 16);
            this.chk包含下级.TabIndex = 141;
            this.chk包含下级.Text = "包含下级";
            this.chk包含下级.UseVisualStyleBackColor = true;
            // 
            // txt选择单位
            // 
            this.txt选择单位.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt选择单位.ForeColor = System.Drawing.Color.Blue;
            this.txt选择单位.Location = new System.Drawing.Point(69, 5);
            this.txt选择单位.Margin = new System.Windows.Forms.Padding(2);
            this.txt选择单位.Name = "txt选择单位";
            this.txt选择单位.ReadOnly = true;
            this.txt选择单位.Size = new System.Drawing.Size(220, 21);
            this.txt选择单位.TabIndex = 139;
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
            this.btnQuery.Location = new System.Drawing.Point(800, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtp结束时间
            // 
            this.dtp结束时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp结束时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp结束时间.Location = new System.Drawing.Point(592, 5);
            this.dtp结束时间.Name = "dtp结束时间";
            this.dtp结束时间.Size = new System.Drawing.Size(121, 21);
            this.dtp结束时间.TabIndex = 4;
            // 
            // dtp开始时间
            // 
            this.dtp开始时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp开始时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp开始时间.Location = new System.Drawing.Point(448, 5);
            this.dtp开始时间.Name = "dtp开始时间";
            this.dtp开始时间.Size = new System.Drawing.Size(122, 21);
            this.dtp开始时间.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "申请日期从                      至";
            // 
            // btn撤销
            // 
            this.btn撤销.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn撤销.Location = new System.Drawing.Point(225, 0);
            this.btn撤销.Name = "btn撤销";
            this.btn撤销.Size = new System.Drawing.Size(75, 28);
            this.btn撤销.TabIndex = 6;
            this.btn撤销.Text = "撤销(&G)";
            this.btn撤销.UseVisualStyleBackColor = true;
            this.btn撤销.Click += new System.EventHandler(this.btn撤销_Click);
            // 
            // OCC_配置申请
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 392);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "OCC_配置申请";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
  
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Button btn导出;
        private System.Windows.Forms.Button btn查看;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtp结束时间;
        private System.Windows.Forms.DateTimePicker dtp开始时间;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn选择单位;
        private System.Windows.Forms.CheckBox chk包含下级;
        private System.Windows.Forms.TextBox txt选择单位;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 预算单位名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请总数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请总金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请原因;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn exWaitState2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建时间;
        private System.Windows.Forms.Button btn撤销;
    }
}