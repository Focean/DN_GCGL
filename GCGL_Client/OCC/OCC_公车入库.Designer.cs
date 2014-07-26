namespace GCGL_Client.OCC
{
    partial class OCC_公车入库
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn选择单位 = new System.Windows.Forms.Button();
            this.chk包含下级 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt选择单位 = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtp结束时间 = new System.Windows.Forms.DateTimePicker();
            this.dtp开始时间 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn查看 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.btn调拨 = new System.Windows.Forms.Button();
            this.btn打印 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btn导出 = new System.Windows.Forms.Button();
            this.btn购置 = new System.Windows.Forms.Button();
            this.入库单编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.配置申请编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂牌型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入库类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车牌号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发动机号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车架号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.账面净值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.附件摘要 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn选择单位
            // 
            this.btn选择单位.Location = new System.Drawing.Point(283, 6);
            this.btn选择单位.Name = "btn选择单位";
            this.btn选择单位.Size = new System.Drawing.Size(21, 19);
            this.btn选择单位.TabIndex = 144;
            this.btn选择单位.Text = "…";
            this.btn选择单位.UseVisualStyleBackColor = true;
            this.btn选择单位.Click += new System.EventHandler(this.btn选择单位_Click);
            // 
            // chk包含下级
            // 
            this.chk包含下级.AutoSize = true;
            this.chk包含下级.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk包含下级.Location = new System.Drawing.Point(314, 8);
            this.chk包含下级.Name = "chk包含下级";
            this.chk包含下级.Size = new System.Drawing.Size(72, 16);
            this.chk包含下级.TabIndex = 145;
            this.chk包含下级.Text = "包含下级";
            this.chk包含下级.UseVisualStyleBackColor = true;
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
            // txt选择单位
            // 
            this.txt选择单位.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt选择单位.ForeColor = System.Drawing.Color.Blue;
            this.txt选择单位.Location = new System.Drawing.Point(67, 5);
            this.txt选择单位.Margin = new System.Windows.Forms.Padding(2);
            this.txt选择单位.Name = "txt选择单位";
            this.txt选择单位.ReadOnly = true;
            this.txt选择单位.Size = new System.Drawing.Size(238, 21);
            this.txt选择单位.TabIndex = 143;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuery.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnQuery.Location = new System.Drawing.Point(802, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtp结束时间
            // 
            this.dtp结束时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp结束时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp结束时间.Location = new System.Drawing.Point(603, 5);
            this.dtp结束时间.Name = "dtp结束时间";
            this.dtp结束时间.Size = new System.Drawing.Size(121, 21);
            this.dtp结束时间.TabIndex = 12;
            // 
            // dtp开始时间
            // 
            this.dtp开始时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp开始时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp开始时间.Location = new System.Drawing.Point(459, 5);
            this.dtp开始时间.Name = "dtp开始时间";
            this.dtp开始时间.Size = new System.Drawing.Size(122, 21);
            this.dtp开始时间.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "入库日期从                      至";
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
            this.pnlQuery.Size = new System.Drawing.Size(877, 30);
            this.pnlQuery.TabIndex = 124;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(877, 45);
            this.lblTitle.TabIndex = 123;
            this.lblTitle.Text = "入库登记查询申请列表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn查看
            // 
            this.btn查看.BackColor = System.Drawing.SystemColors.Control;
            this.btn查看.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn查看.Location = new System.Drawing.Point(251, 0);
            this.btn查看.Name = "btn查看";
            this.btn查看.Size = new System.Drawing.Size(75, 28);
            this.btn查看.TabIndex = 4;
            this.btn查看.Text = "查看(&K)";
            this.btn查看.UseVisualStyleBackColor = false;
            this.btn查看.Click += new System.EventHandler(this.btn查看_Click);
            // 
            // btn修改
            // 
            this.btn修改.BackColor = System.Drawing.SystemColors.Control;
            this.btn修改.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn修改.Location = new System.Drawing.Point(176, 0);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(75, 28);
            this.btn修改.TabIndex = 2;
            this.btn修改.Text = "修改(&M)";
            this.btn修改.UseVisualStyleBackColor = false;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // btn调拨
            // 
            this.btn调拨.BackColor = System.Drawing.SystemColors.Control;
            this.btn调拨.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn调拨.Location = new System.Drawing.Point(88, 0);
            this.btn调拨.Name = "btn调拨";
            this.btn调拨.Size = new System.Drawing.Size(88, 28);
            this.btn调拨.TabIndex = 1;
            this.btn调拨.Text = "调拨入库(&B)";
            this.btn调拨.UseVisualStyleBackColor = false;
            this.btn调拨.Click += new System.EventHandler(this.btn调拨_Click);
            // 
            // btn打印
            // 
            this.btn打印.BackColor = System.Drawing.SystemColors.Control;
            this.btn打印.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn打印.Location = new System.Drawing.Point(725, 0);
            this.btn打印.Name = "btn打印";
            this.btn打印.Size = new System.Drawing.Size(75, 28);
            this.btn打印.TabIndex = 5;
            this.btn打印.Text = "打印(&P)";
            this.btn打印.UseVisualStyleBackColor = false;
            this.btn打印.Click += new System.EventHandler(this.btn打印_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.BackColor = System.Drawing.SystemColors.Control;
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(800, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 6;
            this.btn关闭.Text = "关闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = false;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
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
            this.配置申请编号,
            this.单位名称,
            this.资产编号,
            this.资产名称,
            this.规格型号,
            this.厂牌型号,
            this.入库类型,
            this.车牌号,
            this.发动机号,
            this.车架号,
            this.价值,
            this.账面净值,
            this.附件摘要,
            this.备注});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 105);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(877, 411);
            this.dgvList.TabIndex = 121;
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTool.Controls.Add(this.btn导出);
            this.pnlTool.Controls.Add(this.btn查看);
            this.pnlTool.Controls.Add(this.btn修改);
            this.pnlTool.Controls.Add(this.btn调拨);
            this.pnlTool.Controls.Add(this.btn打印);
            this.pnlTool.Controls.Add(this.btn关闭);
            this.pnlTool.Controls.Add(this.btn购置);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(877, 30);
            this.pnlTool.TabIndex = 122;
            // 
            // btn导出
            // 
            this.btn导出.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn导出.Location = new System.Drawing.Point(650, 0);
            this.btn导出.Name = "btn导出";
            this.btn导出.Size = new System.Drawing.Size(75, 28);
            this.btn导出.TabIndex = 503;
            this.btn导出.Text = "导出（&E)";
            this.btn导出.UseVisualStyleBackColor = true;
            // 
            // btn购置
            // 
            this.btn购置.BackColor = System.Drawing.SystemColors.Control;
            this.btn购置.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn购置.Location = new System.Drawing.Point(0, 0);
            this.btn购置.Name = "btn购置";
            this.btn购置.Size = new System.Drawing.Size(88, 28);
            this.btn购置.TabIndex = 504;
            this.btn购置.Text = "购置入库(&A)";
            this.btn购置.UseVisualStyleBackColor = false;
            this.btn购置.Click += new System.EventHandler(this.btn购置_Click);
            // 
            // 入库单编码
            // 
            this.入库单编码.DataPropertyName = "入库单编码";
            this.入库单编码.HeaderText = "入库单编码";
            this.入库单编码.Name = "入库单编码";
            this.入库单编码.ReadOnly = true;
            this.入库单编码.Visible = false;
            // 
            // 配置申请编号
            // 
            this.配置申请编号.DataPropertyName = "配置申请编号";
            this.配置申请编号.HeaderText = "配置申请编号";
            this.配置申请编号.Name = "配置申请编号";
            this.配置申请编号.ReadOnly = true;
            this.配置申请编号.Visible = false;
            // 
            // 单位名称
            // 
            this.单位名称.DataPropertyName = "单位名称";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.单位名称.DefaultCellStyle = dataGridViewCellStyle2;
            this.单位名称.HeaderText = "单位名称";
            this.单位名称.Name = "单位名称";
            this.单位名称.ReadOnly = true;
            this.单位名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.单位名称.Width = 150;
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
            // 厂牌型号
            // 
            this.厂牌型号.DataPropertyName = "厂牌型号";
            this.厂牌型号.HeaderText = "厂牌型号";
            this.厂牌型号.Name = "厂牌型号";
            this.厂牌型号.ReadOnly = true;
            this.厂牌型号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.厂牌型号.Width = 150;
            // 
            // 入库类型
            // 
            this.入库类型.DataPropertyName = "入库类型";
            this.入库类型.HeaderText = "入库类型";
            this.入库类型.Name = "入库类型";
            this.入库类型.ReadOnly = true;
            this.入库类型.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.车架号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.车架号.DataPropertyName = "车架号";
            this.车架号.HeaderText = "车架号";
            this.车架号.MinimumWidth = 50;
            this.车架号.Name = "车架号";
            this.车架号.ReadOnly = true;
            this.车架号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 价值
            // 
            this.价值.DataPropertyName = "价值";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.价值.DefaultCellStyle = dataGridViewCellStyle4;
            this.价值.HeaderText = "价值(万元)";
            this.价值.Name = "价值";
            this.价值.ReadOnly = true;
            this.价值.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.价值.Width = 120;
            // 
            // 账面净值
            // 
            this.账面净值.DataPropertyName = "账面净值";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.账面净值.DefaultCellStyle = dataGridViewCellStyle5;
            this.账面净值.HeaderText = "账面净值(万元)";
            this.账面净值.Name = "账面净值";
            this.账面净值.ReadOnly = true;
            this.账面净值.Width = 120;
            // 
            // 附件摘要
            // 
            this.附件摘要.DataPropertyName = "附件摘要";
            this.附件摘要.HeaderText = "文件依据";
            this.附件摘要.Name = "附件摘要";
            this.附件摘要.ReadOnly = true;
            this.附件摘要.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.附件摘要.Width = 120;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "备注";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            // 
            // OCC_公车入库
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 516);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlTool);
            this.Name = "OCC_公车入库";
            this.Text = "入库登记";
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn选择单位;
        private System.Windows.Forms.CheckBox chk包含下级;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt选择单位;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtp结束时间;
        private System.Windows.Forms.DateTimePicker dtp开始时间;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn查看;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Button btn调拨;
        private System.Windows.Forms.Button btn打印;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Button btn导出;
        private System.Windows.Forms.Button btn购置;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入库单编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 配置申请编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂牌型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入库类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车牌号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发动机号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车架号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 账面净值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 附件摘要;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;

    }
}