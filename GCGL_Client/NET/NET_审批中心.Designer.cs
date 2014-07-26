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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn审批 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn导出 = new System.Windows.Forms.Button();
            this.btn打印 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.btn选择单位 = new System.Windows.Forms.Button();
            this.chk仅未审批 = new System.Windows.Forms.CheckBox();
            this.txt选择单位 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtp结束时间 = new System.Windows.Forms.DateTimePicker();
            this.dtp开始时间 = new System.Windows.Forms.DateTimePicker();
            this.chk申请日期 = new System.Windows.Forms.CheckBox();
            this.exCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exWaitState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exFinished = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvList.ColumnHeadersHeight = 28;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exCode,
            this.wfName,
            this.单位名称,
            this.exTitle,
            this.创建人,
            this.CreateTime,
            this.exWaitState,
            this.exFinished});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 98);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvList.RowHeadersWidth = 20;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(934, 500);
            this.dgvList.StandardTab = true;
            this.dgvList.TabIndex = 499;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(934, 40);
            this.label1.TabIndex = 500;
            this.label1.Text = "网上审批处理中心";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn审批
            // 
            this.btn审批.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn审批.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn审批.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn审批.Location = new System.Drawing.Point(0, 0);
            this.btn审批.Name = "btn审批";
            this.btn审批.Size = new System.Drawing.Size(110, 28);
            this.btn审批.TabIndex = 501;
            this.btn审批.Text = "审批(Ctrl+P)";
            this.btn审批.UseVisualStyleBackColor = true;
            this.btn审批.Click += new System.EventHandler(this.btn审批_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn导出);
            this.panel1.Controls.Add(this.btn打印);
            this.panel1.Controls.Add(this.btn关闭);
            this.panel1.Controls.Add(this.btn审批);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 28);
            this.panel1.TabIndex = 502;
            // 
            // btn导出
            // 
            this.btn导出.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn导出.Location = new System.Drawing.Point(709, 0);
            this.btn导出.Name = "btn导出";
            this.btn导出.Size = new System.Drawing.Size(75, 28);
            this.btn导出.TabIndex = 502;
            this.btn导出.Text = "导出（&E)";
            this.btn导出.UseVisualStyleBackColor = true;
            // 
            // btn打印
            // 
            this.btn打印.BackColor = System.Drawing.SystemColors.Control;
            this.btn打印.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn打印.Location = new System.Drawing.Point(784, 0);
            this.btn打印.Name = "btn打印";
            this.btn打印.Size = new System.Drawing.Size(75, 28);
            this.btn打印.TabIndex = 503;
            this.btn打印.Text = "打印(&P)";
            this.btn打印.UseVisualStyleBackColor = false;
            this.btn打印.Click += new System.EventHandler(this.btn打印_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(859, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 3;
            this.btn关闭.Text = "关 闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = true;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlQuery.Controls.Add(this.btn选择单位);
            this.pnlQuery.Controls.Add(this.chk仅未审批);
            this.pnlQuery.Controls.Add(this.txt选择单位);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Controls.Add(this.dtp结束时间);
            this.pnlQuery.Controls.Add(this.dtp开始时间);
            this.pnlQuery.Controls.Add(this.chk申请日期);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 68);
            this.pnlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(934, 30);
            this.pnlQuery.TabIndex = 503;
            // 
            // btn选择单位
            // 
            this.btn选择单位.Location = new System.Drawing.Point(262, 6);
            this.btn选择单位.Name = "btn选择单位";
            this.btn选择单位.Size = new System.Drawing.Size(22, 19);
            this.btn选择单位.TabIndex = 140;
            this.btn选择单位.Text = "…";
            this.btn选择单位.UseVisualStyleBackColor = true;
            // 
            // chk仅未审批
            // 
            this.chk仅未审批.AutoSize = true;
            this.chk仅未审批.Checked = true;
            this.chk仅未审批.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk仅未审批.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk仅未审批.Location = new System.Drawing.Point(300, 8);
            this.chk仅未审批.Name = "chk仅未审批";
            this.chk仅未审批.Size = new System.Drawing.Size(108, 16);
            this.chk仅未审批.TabIndex = 141;
            this.chk仅未审批.Text = "仅显示未完成的";
            this.chk仅未审批.UseVisualStyleBackColor = true;
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
            this.txt选择单位.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 138;
            this.label4.Text = "申请单位：";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuery.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnQuery.Location = new System.Drawing.Point(859, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 6;
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
            this.dtp结束时间.Location = new System.Drawing.Point(644, 5);
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
            this.dtp开始时间.Location = new System.Drawing.Point(500, 5);
            this.dtp开始时间.Name = "dtp开始时间";
            this.dtp开始时间.Size = new System.Drawing.Size(122, 21);
            this.dtp开始时间.TabIndex = 3;
            // 
            // chk申请日期
            // 
            this.chk申请日期.AutoSize = true;
            this.chk申请日期.Location = new System.Drawing.Point(417, 8);
            this.chk申请日期.Name = "chk申请日期";
            this.chk申请日期.Size = new System.Drawing.Size(228, 16);
            this.chk申请日期.TabIndex = 142;
            this.chk申请日期.Text = "申请日期从                      至";
            this.chk申请日期.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.wfName.DefaultCellStyle = dataGridViewCellStyle14;
            this.wfName.HeaderText = "类型";
            this.wfName.Name = "wfName";
            this.wfName.ReadOnly = true;
            this.wfName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 单位名称
            // 
            this.单位名称.DataPropertyName = "单位名称";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.单位名称.DefaultCellStyle = dataGridViewCellStyle15;
            this.单位名称.HeaderText = "单位名称";
            this.单位名称.Name = "单位名称";
            this.单位名称.ReadOnly = true;
            this.单位名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.单位名称.Width = 200;
            // 
            // exTitle
            // 
            this.exTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.exTitle.DataPropertyName = "exTitle";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.exTitle.DefaultCellStyle = dataGridViewCellStyle16;
            this.exTitle.HeaderText = "申请原因/备注";
            this.exTitle.MinimumWidth = 120;
            this.exTitle.Name = "exTitle";
            this.exTitle.ReadOnly = true;
            this.exTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 创建人
            // 
            this.创建人.DataPropertyName = "创建人";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.创建人.DefaultCellStyle = dataGridViewCellStyle17;
            this.创建人.HeaderText = "申请人";
            this.创建人.Name = "创建人";
            this.创建人.ReadOnly = true;
            this.创建人.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.创建人.Width = 80;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "d";
            this.CreateTime.DefaultCellStyle = dataGridViewCellStyle18;
            this.CreateTime.HeaderText = "申请时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CreateTime.Width = 110;
            // 
            // exWaitState
            // 
            this.exWaitState.DataPropertyName = "exWaitState";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.exWaitState.DefaultCellStyle = dataGridViewCellStyle19;
            this.exWaitState.HeaderText = "审批状态";
            this.exWaitState.Name = "exWaitState";
            this.exWaitState.ReadOnly = true;
            this.exWaitState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.exWaitState.Width = 150;
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
            // 
            // NET_审批中心
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 598);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "NET_审批中心";
            this.Text = "NET_网上审批";
            this.Load += new System.EventHandler(this.NET_审批中心_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn审批;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.Button btn选择单位;
        private System.Windows.Forms.CheckBox chk仅未审批;
        private System.Windows.Forms.TextBox txt选择单位;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtp结束时间;
        private System.Windows.Forms.DateTimePicker dtp开始时间;
        private System.Windows.Forms.Button btn导出;
        private System.Windows.Forms.Button btn打印;
        private System.Windows.Forms.CheckBox chk申请日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn exCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn wfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn exTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建人;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn exWaitState;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exFinished;

    }
}