namespace GCGL_Client.FZB
{
    partial class FZB_基础数据
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btn删除 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.btn导入 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.txt单位编码 = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp结束时间 = new System.Windows.Forms.DateTimePicker();
            this.dtp开始时间 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pnl分页信息 = new System.Windows.Forms.Panel();
            this.nudPageIndex = new System.Windows.Forms.NumericUpDown();
            this.lblDataInfo = new System.Windows.Forms.Label();
            this.btn末一页 = new System.Windows.Forms.Button();
            this.btn下一页 = new System.Windows.Forms.Button();
            this.btn上一页 = new System.Windows.Forms.Button();
            this.btn第一页 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.入库单编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.财政资产编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车辆类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂牌型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.取得方式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.取得日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车辆颜色 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.座位数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车牌号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发动机号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车架号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车辆产地 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.排气量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.账面净值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入库类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exWaitState2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTool.SuspendLayout();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnl分页信息.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTool.Controls.Add(this.btn删除);
            this.pnlTool.Controls.Add(this.btn关闭);
            this.pnlTool.Controls.Add(this.btn导入);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(1072, 30);
            this.pnlTool.TabIndex = 123;
            // 
            // btn删除
            // 
            this.btn删除.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn删除.Location = new System.Drawing.Point(88, 0);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(75, 28);
            this.btn删除.TabIndex = 4;
            this.btn删除.Text = "删除(&D)";
            this.btn删除.UseVisualStyleBackColor = true;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.BackColor = System.Drawing.SystemColors.Control;
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(995, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 19;
            this.btn关闭.Text = "关闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = false;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // btn导入
            // 
            this.btn导入.BackColor = System.Drawing.SystemColors.Control;
            this.btn导入.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn导入.Location = new System.Drawing.Point(0, 0);
            this.btn导入.Name = "btn导入";
            this.btn导入.Size = new System.Drawing.Size(88, 28);
            this.btn导入.TabIndex = 0;
            this.btn导入.Text = "导入(&A)";
            this.btn导入.UseVisualStyleBackColor = false;
            this.btn导入.Click += new System.EventHandler(this.btn导入_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1072, 45);
            this.lblTitle.TabIndex = 124;
            this.lblTitle.Text = "数据导入列表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlQuery.Controls.Add(this.txt单位编码);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.dtp结束时间);
            this.pnlQuery.Controls.Add(this.dtp开始时间);
            this.pnlQuery.Controls.Add(this.label2);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 75);
            this.pnlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(1072, 30);
            this.pnlQuery.TabIndex = 125;
            // 
            // txt单位编码
            // 
            this.txt单位编码.Location = new System.Drawing.Point(67, 5);
            this.txt单位编码.Name = "txt单位编码";
            this.txt单位编码.Size = new System.Drawing.Size(231, 21);
            this.txt单位编码.TabIndex = 146;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuery.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnQuery.Location = new System.Drawing.Point(997, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 142;
            this.label4.Text = "查询单位：";
            // 
            // dtp结束时间
            // 
            this.dtp结束时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp结束时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp结束时间.Location = new System.Drawing.Point(550, 5);
            this.dtp结束时间.Name = "dtp结束时间";
            this.dtp结束时间.Size = new System.Drawing.Size(121, 21);
            this.dtp结束时间.TabIndex = 14;
            // 
            // dtp开始时间
            // 
            this.dtp开始时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp开始时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp开始时间.Location = new System.Drawing.Point(406, 5);
            this.dtp开始时间.Name = "dtp开始时间";
            this.dtp开始时间.Size = new System.Drawing.Size(122, 21);
            this.dtp开始时间.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "导入日期从                      至";
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
            this.入库单编码,
            this.单位名称,
            this.资产编号,
            this.财政资产编号,
            this.资产名称,
            this.规格型号,
            this.车辆类型,
            this.资产类别,
            this.厂牌型号,
            this.取得方式,
            this.取得日期,
            this.车辆颜色,
            this.座位数,
            this.车牌号,
            this.发动机号,
            this.车架号,
            this.车辆产地,
            this.排气量,
            this.价值,
            this.账面净值,
            this.入库类型,
            this.备注,
            this.exWaitState2});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 105);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1072, 462);
            this.dgvList.TabIndex = 248;
            // 
            // pnl分页信息
            // 
            this.pnl分页信息.Controls.Add(this.nudPageIndex);
            this.pnl分页信息.Controls.Add(this.lblDataInfo);
            this.pnl分页信息.Controls.Add(this.btn末一页);
            this.pnl分页信息.Controls.Add(this.btn下一页);
            this.pnl分页信息.Controls.Add(this.btn上一页);
            this.pnl分页信息.Controls.Add(this.btn第一页);
            this.pnl分页信息.Controls.Add(this.label1);
            this.pnl分页信息.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl分页信息.Location = new System.Drawing.Point(0, 567);
            this.pnl分页信息.Name = "pnl分页信息";
            this.pnl分页信息.Size = new System.Drawing.Size(1072, 32);
            this.pnl分页信息.TabIndex = 249;
            // 
            // nudPageIndex
            // 
            this.nudPageIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPageIndex.Location = new System.Drawing.Point(846, 5);
            this.nudPageIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPageIndex.Name = "nudPageIndex";
            this.nudPageIndex.Size = new System.Drawing.Size(51, 21);
            this.nudPageIndex.TabIndex = 20;
            this.nudPageIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPageIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPageIndex.ValueChanged += new System.EventHandler(this.nudPageIndex_ValueChanged);
            // 
            // lblDataInfo
            // 
            this.lblDataInfo.AutoSize = true;
            this.lblDataInfo.Location = new System.Drawing.Point(9, 10);
            this.lblDataInfo.Name = "lblDataInfo";
            this.lblDataInfo.Size = new System.Drawing.Size(191, 12);
            this.lblDataInfo.TabIndex = 19;
            this.lblDataInfo.Text = "共 0 条记录，每页 0 条，共 0 页";
            // 
            // btn末一页
            // 
            this.btn末一页.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn末一页.Location = new System.Drawing.Point(990, 4);
            this.btn末一页.Name = "btn末一页";
            this.btn末一页.Size = new System.Drawing.Size(75, 23);
            this.btn末一页.TabIndex = 17;
            this.btn末一页.Text = "尾页";
            this.btn末一页.UseVisualStyleBackColor = false;
            this.btn末一页.Click += new System.EventHandler(this.btn末一页_Click);
            // 
            // btn下一页
            // 
            this.btn下一页.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn下一页.Location = new System.Drawing.Point(915, 4);
            this.btn下一页.Name = "btn下一页";
            this.btn下一页.Size = new System.Drawing.Size(75, 23);
            this.btn下一页.TabIndex = 16;
            this.btn下一页.Text = "下一页";
            this.btn下一页.UseVisualStyleBackColor = false;
            this.btn下一页.Click += new System.EventHandler(this.btn下一页_Click);
            // 
            // btn上一页
            // 
            this.btn上一页.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn上一页.Location = new System.Drawing.Point(747, 4);
            this.btn上一页.Name = "btn上一页";
            this.btn上一页.Size = new System.Drawing.Size(75, 23);
            this.btn上一页.TabIndex = 15;
            this.btn上一页.Text = "上一页";
            this.btn上一页.UseVisualStyleBackColor = false;
            this.btn上一页.Click += new System.EventHandler(this.btn上一页_Click);
            // 
            // btn第一页
            // 
            this.btn第一页.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn第一页.Location = new System.Drawing.Point(666, 4);
            this.btn第一页.Name = "btn第一页";
            this.btn第一页.Size = new System.Drawing.Size(75, 23);
            this.btn第一页.TabIndex = 14;
            this.btn第一页.Text = "首页";
            this.btn第一页.UseVisualStyleBackColor = false;
            this.btn第一页.Click += new System.EventHandler(this.btn第一页_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(828, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "第          页";
            // 
            // 入库单编码
            // 
            this.入库单编码.DataPropertyName = "入库单编码";
            this.入库单编码.HeaderText = "入库单编码";
            this.入库单编码.Name = "入库单编码";
            this.入库单编码.ReadOnly = true;
            this.入库单编码.Visible = false;
            // 
            // 单位名称
            // 
            this.单位名称.DataPropertyName = "单位名称";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.单位名称.DefaultCellStyle = dataGridViewCellStyle2;
            this.单位名称.HeaderText = "单位名称";
            this.单位名称.Name = "单位名称";
            this.单位名称.ReadOnly = true;
            this.单位名称.Width = 180;
            // 
            // 资产编号
            // 
            this.资产编号.DataPropertyName = "资产编号";
            this.资产编号.HeaderText = "资产编号";
            this.资产编号.Name = "资产编号";
            this.资产编号.ReadOnly = true;
            this.资产编号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.资产编号.Visible = false;
            // 
            // 财政资产编号
            // 
            this.财政资产编号.DataPropertyName = "财政资产编号";
            this.财政资产编号.HeaderText = "财政资产编号";
            this.财政资产编号.Name = "财政资产编号";
            this.财政资产编号.ReadOnly = true;
            this.财政资产编号.Width = 150;
            // 
            // 资产名称
            // 
            this.资产名称.DataPropertyName = "资产名称";
            this.资产名称.HeaderText = "资产名称";
            this.资产名称.Name = "资产名称";
            this.资产名称.ReadOnly = true;
            this.资产名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 规格型号
            // 
            this.规格型号.DataPropertyName = "规格型号";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.规格型号.DefaultCellStyle = dataGridViewCellStyle3;
            this.规格型号.HeaderText = "规格型号";
            this.规格型号.MinimumWidth = 100;
            this.规格型号.Name = "规格型号";
            this.规格型号.ReadOnly = true;
            this.规格型号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.规格型号.Width = 150;
            // 
            // 车辆类型
            // 
            this.车辆类型.DataPropertyName = "车辆类型名称";
            this.车辆类型.HeaderText = "车辆类型";
            this.车辆类型.Name = "车辆类型";
            this.车辆类型.ReadOnly = true;
            this.车辆类型.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.车辆类型.Visible = false;
            // 
            // 资产类别
            // 
            this.资产类别.DataPropertyName = "资产类别名称";
            this.资产类别.HeaderText = "资产类别";
            this.资产类别.Name = "资产类别";
            this.资产类别.ReadOnly = true;
            this.资产类别.Visible = false;
            this.资产类别.Width = 150;
            // 
            // 厂牌型号
            // 
            this.厂牌型号.DataPropertyName = "厂牌型号";
            this.厂牌型号.HeaderText = "厂牌型号";
            this.厂牌型号.Name = "厂牌型号";
            this.厂牌型号.ReadOnly = true;
            this.厂牌型号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.厂牌型号.Width = 150;
            // 
            // 取得方式
            // 
            this.取得方式.DataPropertyName = "取得方式";
            this.取得方式.HeaderText = "取得方式";
            this.取得方式.Name = "取得方式";
            this.取得方式.ReadOnly = true;
            this.取得方式.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 取得日期
            // 
            this.取得日期.DataPropertyName = "取得日期";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.取得日期.DefaultCellStyle = dataGridViewCellStyle4;
            this.取得日期.HeaderText = "取得日期";
            this.取得日期.Name = "取得日期";
            this.取得日期.ReadOnly = true;
            this.取得日期.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 车辆颜色
            // 
            this.车辆颜色.DataPropertyName = "颜色";
            this.车辆颜色.HeaderText = "车辆颜色";
            this.车辆颜色.Name = "车辆颜色";
            this.车辆颜色.ReadOnly = true;
            // 
            // 座位数
            // 
            this.座位数.DataPropertyName = "座位数";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.座位数.DefaultCellStyle = dataGridViewCellStyle5;
            this.座位数.HeaderText = "座位数";
            this.座位数.Name = "座位数";
            this.座位数.ReadOnly = true;
            // 
            // 车牌号
            // 
            this.车牌号.DataPropertyName = "车牌号";
            this.车牌号.HeaderText = "车牌号";
            this.车牌号.Name = "车牌号";
            this.车牌号.ReadOnly = true;
            this.车牌号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 发动机号
            // 
            this.发动机号.DataPropertyName = "发动机号";
            this.发动机号.HeaderText = "发动机号";
            this.发动机号.Name = "发动机号";
            this.发动机号.ReadOnly = true;
            this.发动机号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.发动机号.Width = 150;
            // 
            // 车架号
            // 
            this.车架号.DataPropertyName = "车架号";
            this.车架号.HeaderText = "车架号";
            this.车架号.MinimumWidth = 50;
            this.车架号.Name = "车架号";
            this.车架号.ReadOnly = true;
            this.车架号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 车辆产地
            // 
            this.车辆产地.DataPropertyName = "车辆产地";
            this.车辆产地.HeaderText = "车辆产地";
            this.车辆产地.Name = "车辆产地";
            this.车辆产地.ReadOnly = true;
            this.车辆产地.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 排气量
            // 
            this.排气量.DataPropertyName = "排气量";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.排气量.DefaultCellStyle = dataGridViewCellStyle6;
            this.排气量.HeaderText = "排气量";
            this.排气量.Name = "排气量";
            this.排气量.ReadOnly = true;
            this.排气量.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 价值
            // 
            this.价值.DataPropertyName = "价值";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N4";
            dataGridViewCellStyle7.NullValue = "0";
            this.价值.DefaultCellStyle = dataGridViewCellStyle7;
            this.价值.HeaderText = "价值(万元)";
            this.价值.Name = "价值";
            this.价值.ReadOnly = true;
            this.价值.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.价值.Width = 120;
            // 
            // 账面净值
            // 
            this.账面净值.DataPropertyName = "账面净值";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N4";
            dataGridViewCellStyle8.NullValue = "0";
            this.账面净值.DefaultCellStyle = dataGridViewCellStyle8;
            this.账面净值.HeaderText = "账面净值(万元)";
            this.账面净值.Name = "账面净值";
            this.账面净值.ReadOnly = true;
            this.账面净值.Width = 120;
            // 
            // 入库类型
            // 
            this.入库类型.DataPropertyName = "入库类型";
            this.入库类型.HeaderText = "入库类型";
            this.入库类型.Name = "入库类型";
            this.入库类型.ReadOnly = true;
            this.入库类型.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.入库类型.Visible = false;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "备注";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Visible = false;
            // 
            // exWaitState2
            // 
            this.exWaitState2.DataPropertyName = "exWaitState2";
            this.exWaitState2.HeaderText = "Column1";
            this.exWaitState2.Name = "exWaitState2";
            this.exWaitState2.ReadOnly = true;
            this.exWaitState2.Visible = false;
            // 
            // FZB_基础数据
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 599);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnl分页信息);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlTool);
            this.Name = "FZB_基础数据";
            this.Text = "FZB_基础数据";
            this.pnlTool.ResumeLayout(false);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnl分页信息.ResumeLayout(false);
            this.pnl分页信息.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.Button btn导入;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.TextBox txt单位编码;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp结束时间;
        private System.Windows.Forms.DateTimePicker dtp开始时间;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel pnl分页信息;
        private System.Windows.Forms.NumericUpDown nudPageIndex;
        private System.Windows.Forms.Label lblDataInfo;
        public System.Windows.Forms.Button btn末一页;
        public System.Windows.Forms.Button btn下一页;
        public System.Windows.Forms.Button btn上一页;
        public System.Windows.Forms.Button btn第一页;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入库单编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 财政资产编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车辆类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂牌型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 取得方式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 取得日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车辆颜色;
        private System.Windows.Forms.DataGridViewTextBoxColumn 座位数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车牌号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发动机号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车架号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车辆产地;
        private System.Windows.Forms.DataGridViewTextBoxColumn 排气量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 账面净值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入库类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn exWaitState2;
    }
}