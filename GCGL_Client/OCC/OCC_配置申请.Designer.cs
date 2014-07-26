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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn刷新 = new System.Windows.Forms.Button();
            this.btn打印备案 = new System.Windows.Forms.Button();
            this.btn审批意见 = new System.Windows.Forms.Button();
            this.btn查看 = new System.Windows.Forms.Button();
            this.btn撤销 = new System.Windows.Forms.Button();
            this.btn导出 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.btn删除 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.申请编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.审批流程编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exWaitState2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请总数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请总金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请原因 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.btn预算单位 = new System.Windows.Forms.Button();
            this.txt单位编码 = new System.Windows.Forms.TextBox();
            this.chk包含下级 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtp结束时间 = new System.Windows.Forms.DateTimePicker();
            this.dtp开始时间 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn刷新);
            this.panel1.Controls.Add(this.btn打印备案);
            this.panel1.Controls.Add(this.btn审批意见);
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
            this.panel1.Size = new System.Drawing.Size(896, 30);
            this.panel1.TabIndex = 3;
            // 
            // btn刷新
            // 
            this.btn刷新.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn刷新.Location = new System.Drawing.Point(606, 0);
            this.btn刷新.Name = "btn刷新";
            this.btn刷新.Size = new System.Drawing.Size(75, 28);
            this.btn刷新.TabIndex = 7;
            this.btn刷新.Text = "刷新(&F)";
            this.btn刷新.UseVisualStyleBackColor = true;
            this.btn刷新.Click += new System.EventHandler(this.btn刷新_Click);
            // 
            // btn打印备案
            // 
            this.btn打印备案.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn打印备案.Location = new System.Drawing.Point(483, 0);
            this.btn打印备案.Name = "btn打印备案";
            this.btn打印备案.Size = new System.Drawing.Size(123, 28);
            this.btn打印备案.TabIndex = 6;
            this.btn打印备案.Text = "打印备案申请表(&P)";
            this.btn打印备案.UseVisualStyleBackColor = true;
            this.btn打印备案.Click += new System.EventHandler(this.btn打印备案_Click);
            // 
            // btn审批意见
            // 
            this.btn审批意见.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn审批意见.Location = new System.Drawing.Point(375, 0);
            this.btn审批意见.Name = "btn审批意见";
            this.btn审批意见.Size = new System.Drawing.Size(108, 28);
            this.btn审批意见.TabIndex = 5;
            this.btn审批意见.Text = "查看审核意见(&S)";
            this.btn审批意见.UseVisualStyleBackColor = true;
            this.btn审批意见.Click += new System.EventHandler(this.btn审批意见_Click);
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
            // btn撤销
            // 
            this.btn撤销.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn撤销.Location = new System.Drawing.Point(225, 0);
            this.btn撤销.Name = "btn撤销";
            this.btn撤销.Size = new System.Drawing.Size(75, 28);
            this.btn撤销.TabIndex = 3;
            this.btn撤销.Text = "撤销(&G)";
            this.btn撤销.UseVisualStyleBackColor = true;
            this.btn撤销.Visible = false;
            this.btn撤销.Click += new System.EventHandler(this.btn撤销_Click);
            // 
            // btn导出
            // 
            this.btn导出.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn导出.Location = new System.Drawing.Point(744, 0);
            this.btn导出.Name = "btn导出";
            this.btn导出.Size = new System.Drawing.Size(75, 28);
            this.btn导出.TabIndex = 8;
            this.btn导出.Text = "导出（&E)";
            this.btn导出.UseVisualStyleBackColor = true;
            this.btn导出.Click += new System.EventHandler(this.btn导出_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(819, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 9;
            this.btn关闭.Text = "关 闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = true;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // btn删除
            // 
            this.btn删除.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn删除.Location = new System.Drawing.Point(150, 0);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(75, 28);
            this.btn删除.TabIndex = 2;
            this.btn删除.Text = "删除（&D)";
            this.btn删除.UseVisualStyleBackColor = true;
            this.btn删除.Visible = false;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // btn修改
            // 
            this.btn修改.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn修改.Location = new System.Drawing.Point(75, 0);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(75, 28);
            this.btn修改.TabIndex = 1;
            this.btn修改.Text = "修改（&M)";
            this.btn修改.UseVisualStyleBackColor = true;
            this.btn修改.Visible = false;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // btn新增
            // 
            this.btn新增.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn新增.ForeColor = System.Drawing.Color.Blue;
            this.btn新增.Location = new System.Drawing.Point(0, 0);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(75, 28);
            this.btn新增.TabIndex = 0;
            this.btn新增.Text = "申报（&N)";
            this.btn新增.UseVisualStyleBackColor = true;
            this.btn新增.Visible = false;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(896, 45);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "车辆配置申报查询列表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.申请编号,
            this.审批流程编码,
            this.单位编码,
            this.exWaitState2,
            this.申请总数,
            this.申请总金额,
            this.申请原因,
            this.单位名称,
            this.申请备注,
            this.创建人,
            this.创建时间});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 105);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvList.RowHeadersWidth = 28;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(896, 412);
            this.dgvList.TabIndex = 14;
            this.dgvList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvList_MouseDoubleClick);
            // 
            // 申请编号
            // 
            this.申请编号.DataPropertyName = "申请编号";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.申请编号.DefaultCellStyle = dataGridViewCellStyle2;
            this.申请编号.HeaderText = "申请编号";
            this.申请编号.MinimumWidth = 20;
            this.申请编号.Name = "申请编号";
            this.申请编号.ReadOnly = true;
            this.申请编号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.申请编号.Visible = false;
            this.申请编号.Width = 120;
            // 
            // 审批流程编码
            // 
            this.审批流程编码.DataPropertyName = "审批流程编码";
            this.审批流程编码.HeaderText = "审批流程编码";
            this.审批流程编码.Name = "审批流程编码";
            this.审批流程编码.ReadOnly = true;
            this.审批流程编码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.审批流程编码.Visible = false;
            // 
            // 单位编码
            // 
            this.单位编码.DataPropertyName = "单位编码";
            this.单位编码.HeaderText = "单位编码";
            this.单位编码.Name = "单位编码";
            this.单位编码.ReadOnly = true;
            this.单位编码.Visible = false;
            // 
            // exWaitState2
            // 
            this.exWaitState2.DataPropertyName = "exWaitState2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.exWaitState2.DefaultCellStyle = dataGridViewCellStyle3;
            this.exWaitState2.HeaderText = "审核状态";
            this.exWaitState2.Name = "exWaitState2";
            this.exWaitState2.ReadOnly = true;
            this.exWaitState2.Width = 220;
            // 
            // 申请总数
            // 
            this.申请总数.DataPropertyName = "申请总数";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.申请总数.DefaultCellStyle = dataGridViewCellStyle4;
            this.申请总数.HeaderText = "申请总数(台)";
            this.申请总数.Name = "申请总数";
            this.申请总数.ReadOnly = true;
            this.申请总数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.申请总数.Width = 90;
            // 
            // 申请总金额
            // 
            this.申请总金额.DataPropertyName = "申请总金额";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.申请总金额.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.申请原因.DefaultCellStyle = dataGridViewCellStyle6;
            this.申请原因.FillWeight = 60F;
            this.申请原因.HeaderText = "申请原因";
            this.申请原因.MinimumWidth = 150;
            this.申请原因.Name = "申请原因";
            this.申请原因.ReadOnly = true;
            this.申请原因.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 单位名称
            // 
            this.单位名称.DataPropertyName = "单位名称";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.NullValue = null;
            this.单位名称.DefaultCellStyle = dataGridViewCellStyle7;
            this.单位名称.HeaderText = "提交单位";
            this.单位名称.MinimumWidth = 80;
            this.单位名称.Name = "单位名称";
            this.单位名称.ReadOnly = true;
            this.单位名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.单位名称.Visible = false;
            this.单位名称.Width = 200;
            // 
            // 申请备注
            // 
            this.申请备注.DataPropertyName = "申请备注";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.申请备注.DefaultCellStyle = dataGridViewCellStyle8;
            this.申请备注.FillWeight = 40F;
            this.申请备注.HeaderText = "备注";
            this.申请备注.MinimumWidth = 100;
            this.申请备注.Name = "申请备注";
            this.申请备注.ReadOnly = true;
            this.申请备注.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.申请备注.Visible = false;
            this.申请备注.Width = 150;
            // 
            // 创建人
            // 
            this.创建人.DataPropertyName = "创建人";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.创建人.DefaultCellStyle = dataGridViewCellStyle9;
            this.创建人.HeaderText = "申请人";
            this.创建人.Name = "创建人";
            this.创建人.ReadOnly = true;
            this.创建人.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.创建人.Width = 80;
            // 
            // 创建时间
            // 
            this.创建时间.DataPropertyName = "创建时间";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            this.创建时间.DefaultCellStyle = dataGridViewCellStyle10;
            this.创建时间.HeaderText = "申请日期";
            this.创建时间.Name = "创建时间";
            this.创建时间.ReadOnly = true;
            this.创建时间.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.创建时间.Width = 110;
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlQuery.Controls.Add(this.btn预算单位);
            this.pnlQuery.Controls.Add(this.txt单位编码);
            this.pnlQuery.Controls.Add(this.chk包含下级);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Controls.Add(this.dtp结束时间);
            this.pnlQuery.Controls.Add(this.dtp开始时间);
            this.pnlQuery.Controls.Add(this.label3);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 75);
            this.pnlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(896, 30);
            this.pnlQuery.TabIndex = 119;
            // 
            // btn预算单位
            // 
            this.btn预算单位.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn预算单位.Location = new System.Drawing.Point(271, 6);
            this.btn预算单位.Name = "btn预算单位";
            this.btn预算单位.Size = new System.Drawing.Size(21, 19);
            this.btn预算单位.TabIndex = 11;
            this.btn预算单位.Text = "…";
            this.btn预算单位.UseVisualStyleBackColor = true;
            this.btn预算单位.Click += new System.EventHandler(this.btn预算单位_Click);
            // 
            // txt单位编码
            // 
            this.txt单位编码.Location = new System.Drawing.Point(63, 4);
            this.txt单位编码.Name = "txt单位编码";
            this.txt单位编码.ReadOnly = true;
            this.txt单位编码.Size = new System.Drawing.Size(231, 21);
            this.txt单位编码.TabIndex = 146;
            // 
            // chk包含下级
            // 
            this.chk包含下级.AutoSize = true;
            this.chk包含下级.ForeColor = System.Drawing.Color.Yellow;
            this.chk包含下级.Location = new System.Drawing.Point(297, 8);
            this.chk包含下级.Name = "chk包含下级";
            this.chk包含下级.Size = new System.Drawing.Size(72, 16);
            this.chk包含下级.TabIndex = 12;
            this.chk包含下级.Text = "包含下级";
            this.chk包含下级.UseVisualStyleBackColor = true;
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
            this.btnQuery.Location = new System.Drawing.Point(821, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 10;
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
            this.dtp结束时间.TabIndex = 14;
            // 
            // dtp开始时间
            // 
            this.dtp开始时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp开始时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp开始时间.Location = new System.Drawing.Point(448, 5);
            this.dtp开始时间.Name = "dtp开始时间";
            this.dtp开始时间.Size = new System.Drawing.Size(122, 21);
            this.dtp开始时间.TabIndex = 13;
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
            // OCC_配置申请
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 517);
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
        private System.Windows.Forms.CheckBox chk包含下级;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn撤销;
        private System.Windows.Forms.Button btn审批意见;
        private System.Windows.Forms.Button btn预算单位;
        private System.Windows.Forms.TextBox txt单位编码;
        private System.Windows.Forms.Button btn打印备案;
        private System.Windows.Forms.Button btn刷新;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 审批流程编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn exWaitState2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请总数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请总金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请原因;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建时间;
    }
}