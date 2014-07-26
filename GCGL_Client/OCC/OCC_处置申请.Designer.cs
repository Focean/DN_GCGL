namespace GCGL_Client.OCC
{
    partial class OCC_处置申请
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btn查看 = new System.Windows.Forms.Button();
            this.btn删除 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.btn新建 = new System.Windows.Forms.Button();
            this.btn导出 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.btn选择单位 = new System.Windows.Forms.Button();
            this.chk包含下级 = new System.Windows.Forms.CheckBox();
            this.txt选择单位 = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp结束时间 = new System.Windows.Forms.DateTimePicker();
            this.dtp开始时间 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.申请编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总评估价值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请原因 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exWaitState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTool.SuspendLayout();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTool.Controls.Add(this.btn查看);
            this.pnlTool.Controls.Add(this.btn删除);
            this.pnlTool.Controls.Add(this.btn修改);
            this.pnlTool.Controls.Add(this.btn新建);
            this.pnlTool.Controls.Add(this.btn导出);
            this.pnlTool.Controls.Add(this.btn关闭);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(1267, 30);
            this.pnlTool.TabIndex = 118;
            // 
            // btn查看
            // 
            this.btn查看.BackColor = System.Drawing.SystemColors.Control;
            this.btn查看.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn查看.Location = new System.Drawing.Point(225, 0);
            this.btn查看.Name = "btn查看";
            this.btn查看.Size = new System.Drawing.Size(75, 28);
            this.btn查看.TabIndex = 4;
            this.btn查看.Text = "查看(&K)";
            this.btn查看.UseVisualStyleBackColor = false;
            this.btn查看.Click += new System.EventHandler(this.btn查看_Click);
            // 
            // btn删除
            // 
            this.btn删除.BackColor = System.Drawing.SystemColors.Control;
            this.btn删除.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn删除.Location = new System.Drawing.Point(150, 0);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(75, 28);
            this.btn删除.TabIndex = 3;
            this.btn删除.Text = "删除(&D)";
            this.btn删除.UseVisualStyleBackColor = false;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // btn修改
            // 
            this.btn修改.BackColor = System.Drawing.SystemColors.Control;
            this.btn修改.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn修改.Location = new System.Drawing.Point(75, 0);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(75, 28);
            this.btn修改.TabIndex = 2;
            this.btn修改.Text = "修改(&M)";
            this.btn修改.UseVisualStyleBackColor = false;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // btn新建
            // 
            this.btn新建.BackColor = System.Drawing.SystemColors.Control;
            this.btn新建.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn新建.Location = new System.Drawing.Point(0, 0);
            this.btn新建.Name = "btn新建";
            this.btn新建.Size = new System.Drawing.Size(75, 28);
            this.btn新建.TabIndex = 1;
            this.btn新建.Text = "新建(&N)";
            this.btn新建.UseVisualStyleBackColor = false;
            this.btn新建.Click += new System.EventHandler(this.btn新建_Click);
            // 
            // btn导出
            // 
            this.btn导出.BackColor = System.Drawing.SystemColors.Control;
            this.btn导出.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn导出.Location = new System.Drawing.Point(1115, 0);
            this.btn导出.Name = "btn导出";
            this.btn导出.Size = new System.Drawing.Size(75, 28);
            this.btn导出.TabIndex = 5;
            this.btn导出.Text = "导出(&P)";
            this.btn导出.UseVisualStyleBackColor = false;
            this.btn导出.Click += new System.EventHandler(this.btn导出_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.BackColor = System.Drawing.SystemColors.Control;
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(1190, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 6;
            this.btn关闭.Text = "关闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = false;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1267, 45);
            this.lblTitle.TabIndex = 119;
            this.lblTitle.Text = "公车处置申请查询列表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlQuery.Controls.Add(this.btn选择单位);
            this.pnlQuery.Controls.Add(this.chk包含下级);
            this.pnlQuery.Controls.Add(this.txt选择单位);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.dtp结束时间);
            this.pnlQuery.Controls.Add(this.dtp开始时间);
            this.pnlQuery.Controls.Add(this.label2);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 75);
            this.pnlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(1267, 30);
            this.pnlQuery.TabIndex = 120;
            // 
            // btn选择单位
            // 
            this.btn选择单位.Location = new System.Drawing.Point(263, 6);
            this.btn选择单位.Name = "btn选择单位";
            this.btn选择单位.Size = new System.Drawing.Size(22, 19);
            this.btn选择单位.TabIndex = 8;
            this.btn选择单位.Text = "…";
            this.btn选择单位.UseVisualStyleBackColor = true;
            this.btn选择单位.Click += new System.EventHandler(this.btn选择单位_Click);
            // 
            // chk包含下级
            // 
            this.chk包含下级.AutoSize = true;
            this.chk包含下级.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk包含下级.Location = new System.Drawing.Point(290, 8);
            this.chk包含下级.Name = "chk包含下级";
            this.chk包含下级.Size = new System.Drawing.Size(72, 16);
            this.chk包含下级.TabIndex = 9;
            this.chk包含下级.Text = "包含下级";
            this.chk包含下级.UseVisualStyleBackColor = true;
            // 
            // txt选择单位
            // 
            this.txt选择单位.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt选择单位.ForeColor = System.Drawing.Color.Blue;
            this.txt选择单位.Location = new System.Drawing.Point(66, 5);
            this.txt选择单位.Margin = new System.Windows.Forms.Padding(2);
            this.txt选择单位.Name = "txt选择单位";
            this.txt选择单位.ReadOnly = true;
            this.txt选择单位.Size = new System.Drawing.Size(220, 21);
            this.txt选择单位.TabIndex = 7;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuery.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnQuery.Location = new System.Drawing.Point(1192, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 142;
            this.label4.Text = "查询单位：";
            // 
            // dtp结束时间
            // 
            this.dtp结束时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp结束时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp结束时间.Location = new System.Drawing.Point(584, 5);
            this.dtp结束时间.Name = "dtp结束时间";
            this.dtp结束时间.Size = new System.Drawing.Size(121, 21);
            this.dtp结束时间.TabIndex = 11;
            // 
            // dtp开始时间
            // 
            this.dtp开始时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp开始时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp开始时间.Location = new System.Drawing.Point(440, 5);
            this.dtp开始时间.Name = "dtp开始时间";
            this.dtp开始时间.Size = new System.Drawing.Size(122, 21);
            this.dtp开始时间.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "申请日期从                      至";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvList.ColumnHeadersHeight = 28;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.申请编号,
            this.单位名称,
            this.总评估价值,
            this.申请数量,
            this.申请原因,
            this.申请备注,
            this.exWaitState,
            this.申请人,
            this.创建时间});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle31;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 105);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1267, 543);
            this.dgvList.TabIndex = 13;
            // 
            // 申请编号
            // 
            this.申请编号.DataPropertyName = "申请编号";
            this.申请编号.HeaderText = "申请编号";
            this.申请编号.Name = "申请编号";
            this.申请编号.ReadOnly = true;
            this.申请编号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.申请编号.Width = 150;
            // 
            // 单位名称
            // 
            this.单位名称.DataPropertyName = "单位名称";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.单位名称.DefaultCellStyle = dataGridViewCellStyle26;
            this.单位名称.HeaderText = "申请单位";
            this.单位名称.Name = "单位名称";
            this.单位名称.ReadOnly = true;
            this.单位名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.单位名称.Width = 200;
            // 
            // 总评估价值
            // 
            this.总评估价值.DataPropertyName = "总评估价值";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.Format = "N2";
            dataGridViewCellStyle27.NullValue = "0";
            this.总评估价值.DefaultCellStyle = dataGridViewCellStyle27;
            this.总评估价值.HeaderText = "总评估价值(元)";
            this.总评估价值.MinimumWidth = 100;
            this.总评估价值.Name = "总评估价值";
            this.总评估价值.ReadOnly = true;
            this.总评估价值.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 申请数量
            // 
            this.申请数量.DataPropertyName = "申请数量";
            this.申请数量.HeaderText = "申请数量(台)";
            this.申请数量.Name = "申请数量";
            this.申请数量.ReadOnly = true;
            this.申请数量.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.申请数量.Width = 90;
            // 
            // 申请原因
            // 
            this.申请原因.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.申请原因.DataPropertyName = "申请原因";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.申请原因.DefaultCellStyle = dataGridViewCellStyle28;
            this.申请原因.FillWeight = 60F;
            this.申请原因.HeaderText = "申请原因";
            this.申请原因.MinimumWidth = 150;
            this.申请原因.Name = "申请原因";
            this.申请原因.ReadOnly = true;
            this.申请原因.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 申请备注
            // 
            this.申请备注.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.申请备注.DataPropertyName = "申请备注";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.申请备注.DefaultCellStyle = dataGridViewCellStyle29;
            this.申请备注.FillWeight = 40F;
            this.申请备注.HeaderText = "备注";
            this.申请备注.MinimumWidth = 100;
            this.申请备注.Name = "申请备注";
            this.申请备注.ReadOnly = true;
            this.申请备注.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // exWaitState
            // 
            this.exWaitState.DataPropertyName = "exWaitState";
            this.exWaitState.HeaderText = "审批状态";
            this.exWaitState.Name = "exWaitState";
            this.exWaitState.ReadOnly = true;
            this.exWaitState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.exWaitState.Width = 200;
            // 
            // 申请人
            // 
            this.申请人.DataPropertyName = "申请人";
            this.申请人.HeaderText = "申请人";
            this.申请人.Name = "申请人";
            this.申请人.ReadOnly = true;
            this.申请人.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.申请人.Width = 80;
            // 
            // 创建时间
            // 
            this.创建时间.DataPropertyName = "创建时间";
            dataGridViewCellStyle30.Format = "d";
            dataGridViewCellStyle30.NullValue = null;
            this.创建时间.DefaultCellStyle = dataGridViewCellStyle30;
            this.创建时间.HeaderText = "申请时间";
            this.创建时间.Name = "创建时间";
            this.创建时间.ReadOnly = true;
            this.创建时间.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.创建时间.Width = 110;
            // 
            // OCC_处置申请
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 648);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlTool);
            this.Name = "OCC_处置申请";
            this.Load += new System.EventHandler(this.OCC_处置申请_Load);
            this.pnlTool.ResumeLayout(false);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Button btn查看;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Button btn新建;
        private System.Windows.Forms.Button btn导出;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtp结束时间;
        private System.Windows.Forms.DateTimePicker dtp开始时间;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btn选择单位;
        private System.Windows.Forms.CheckBox chk包含下级;
        private System.Windows.Forms.TextBox txt选择单位;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总评估价值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请原因;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn exWaitState;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建时间;
    }
}