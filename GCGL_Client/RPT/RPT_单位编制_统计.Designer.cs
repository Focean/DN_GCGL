namespace GCGL_Client.RPT
{
    partial class RPT_单位编制_统计
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.btn预算单位 = new System.Windows.Forms.Button();
            this.txt单位编码 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn方案查询 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.tyGridView = new TY.Grids.TyGridView(this.components);
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.编制情况 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车牌号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车辆类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车辆颜色 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂牌型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发动机号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车架号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.排气量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.座位数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.购车发票号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlQuery.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlQuery.Controls.Add(this.btn预算单位);
            this.pnlQuery.Controls.Add(this.txt单位编码);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 68);
            this.pnlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(842, 30);
            this.pnlQuery.TabIndex = 136;
            // 
            // btn预算单位
            // 
            this.btn预算单位.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn预算单位.Location = new System.Drawing.Point(293, 6);
            this.btn预算单位.Name = "btn预算单位";
            this.btn预算单位.Size = new System.Drawing.Size(21, 19);
            this.btn预算单位.TabIndex = 147;
            this.btn预算单位.Text = "…";
            this.btn预算单位.UseVisualStyleBackColor = true;
            this.btn预算单位.Click += new System.EventHandler(this.btn预算单位_Click);
            // 
            // txt单位编码
            // 
            this.txt单位编码.Location = new System.Drawing.Point(65, 4);
            this.txt单位编码.Name = "txt单位编码";
            this.txt单位编码.ReadOnly = true;
            this.txt单位编码.Size = new System.Drawing.Size(249, 21);
            this.txt单位编码.TabIndex = 148;
            this.txt单位编码.TextChanged += new System.EventHandler(this.txt单位编码_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 8);
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
            this.btnQuery.Location = new System.Drawing.Point(767, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(842, 40);
            this.lblTitle.TabIndex = 135;
            this.lblTitle.Text = "单位车辆情况统计";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn方案查询);
            this.panel1.Controls.Add(this.btn关闭);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 28);
            this.panel1.TabIndex = 137;
            // 
            // btn方案查询
            // 
            this.btn方案查询.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn方案查询.ForeColor = System.Drawing.Color.Blue;
            this.btn方案查询.Location = new System.Drawing.Point(0, 0);
            this.btn方案查询.Name = "btn方案查询";
            this.btn方案查询.Size = new System.Drawing.Size(87, 28);
            this.btn方案查询.TabIndex = 7;
            this.btn方案查询.Text = "按方案查询";
            this.btn方案查询.UseVisualStyleBackColor = true;
            this.btn方案查询.Click += new System.EventHandler(this.btn方案查询_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(767, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 3;
            this.btn关闭.Text = "关 闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = true;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // tyGridView
            // 
            this.tyGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tyGridView.ColumnDeep = 1;
            this.tyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tyGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tyGridView.Location = new System.Drawing.Point(0, 98);
            this.tyGridView.Name = "tyGridView";
            this.tyGridView.RowTemplate.Height = 23;
            this.tyGridView.Size = new System.Drawing.Size(842, 342);
            this.tyGridView.TabIndex = 138;
            this.tyGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tyGridView_MouseClick);
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
            this.编制情况,
            this.单位名称,
            this.资产编号,
            this.单位编码,
            this.车牌号,
            this.资产类别,
            this.车辆类型,
            this.资产名称,
            this.车辆颜色,
            this.厂牌型号,
            this.发动机号,
            this.车架号,
            this.排气量,
            this.座位数,
            this.价值,
            this.购车发票号});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 440);
            this.dgvList.Name = "dgvList";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvList.RowHeadersWidth = 20;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(842, 152);
            this.dgvList.StandardTab = true;
            this.dgvList.TabIndex = 501;
            this.dgvList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvList_RowPostPaint);
            // 
            // 编制情况
            // 
            this.编制情况.DataPropertyName = "编制情况";
            this.编制情况.HeaderText = "编制情况";
            this.编制情况.Name = "编制情况";
            // 
            // 单位名称
            // 
            this.单位名称.DataPropertyName = "单位名称";
            this.单位名称.HeaderText = "单位名称";
            this.单位名称.Name = "单位名称";
            this.单位名称.ReadOnly = true;
            this.单位名称.Width = 250;
            // 
            // 资产编号
            // 
            this.资产编号.DataPropertyName = "资产编号";
            this.资产编号.HeaderText = "资产编号";
            this.资产编号.Name = "资产编号";
            this.资产编号.Visible = false;
            // 
            // 单位编码
            // 
            this.单位编码.DataPropertyName = "单位编码";
            this.单位编码.HeaderText = "单位编码";
            this.单位编码.Name = "单位编码";
            this.单位编码.Visible = false;
            // 
            // 车牌号
            // 
            this.车牌号.DataPropertyName = "车牌号";
            this.车牌号.HeaderText = "车牌号";
            this.车牌号.Name = "车牌号";
            this.车牌号.ReadOnly = true;
            this.车牌号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.车牌号.Width = 80;
            // 
            // 资产类别
            // 
            this.资产类别.DataPropertyName = "资产类别名称";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.资产类别.DefaultCellStyle = dataGridViewCellStyle3;
            this.资产类别.HeaderText = "资产类别";
            this.资产类别.Name = "资产类别";
            this.资产类别.ReadOnly = true;
            this.资产类别.Width = 120;
            // 
            // 车辆类型
            // 
            this.车辆类型.DataPropertyName = "车辆类型名称";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.车辆类型.DefaultCellStyle = dataGridViewCellStyle4;
            this.车辆类型.HeaderText = "车辆类型";
            this.车辆类型.Name = "车辆类型";
            this.车辆类型.ReadOnly = true;
            // 
            // 资产名称
            // 
            this.资产名称.DataPropertyName = "资产名称";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.资产名称.DefaultCellStyle = dataGridViewCellStyle5;
            this.资产名称.HeaderText = "资产名称";
            this.资产名称.Name = "资产名称";
            this.资产名称.ReadOnly = true;
            this.资产名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.资产名称.Width = 120;
            // 
            // 车辆颜色
            // 
            this.车辆颜色.DataPropertyName = "车辆颜色";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.车辆颜色.DefaultCellStyle = dataGridViewCellStyle6;
            this.车辆颜色.HeaderText = "车辆颜色";
            this.车辆颜色.Name = "车辆颜色";
            this.车辆颜色.ReadOnly = true;
            this.车辆颜色.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.车辆颜色.Width = 80;
            // 
            // 厂牌型号
            // 
            this.厂牌型号.DataPropertyName = "厂牌型号";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.厂牌型号.DefaultCellStyle = dataGridViewCellStyle7;
            this.厂牌型号.HeaderText = "厂牌型号";
            this.厂牌型号.Name = "厂牌型号";
            this.厂牌型号.ReadOnly = true;
            this.厂牌型号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 发动机号
            // 
            this.发动机号.DataPropertyName = "发动机号";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.发动机号.DefaultCellStyle = dataGridViewCellStyle8;
            this.发动机号.HeaderText = "发动机号";
            this.发动机号.Name = "发动机号";
            this.发动机号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.发动机号.Width = 80;
            // 
            // 车架号
            // 
            this.车架号.DataPropertyName = "车架号";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.车架号.DefaultCellStyle = dataGridViewCellStyle9;
            this.车架号.HeaderText = "车架号";
            this.车架号.Name = "车架号";
            this.车架号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.车架号.Width = 80;
            // 
            // 排气量
            // 
            this.排气量.DataPropertyName = "排气量";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.排气量.DefaultCellStyle = dataGridViewCellStyle10;
            this.排气量.HeaderText = "排气量";
            this.排气量.Name = "排气量";
            this.排气量.Width = 60;
            // 
            // 座位数
            // 
            this.座位数.DataPropertyName = "座位数";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.座位数.DefaultCellStyle = dataGridViewCellStyle11;
            this.座位数.HeaderText = "座位数";
            this.座位数.Name = "座位数";
            this.座位数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.座位数.Width = 60;
            // 
            // 价值
            // 
            this.价值.DataPropertyName = "价值";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.价值.DefaultCellStyle = dataGridViewCellStyle12;
            this.价值.HeaderText = "价值(元)";
            this.价值.Name = "价值";
            this.价值.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 购车发票号
            // 
            this.购车发票号.DataPropertyName = "购车发票号";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.购车发票号.DefaultCellStyle = dataGridViewCellStyle13;
            this.购车发票号.HeaderText = "购车发票号";
            this.购车发票号.Name = "购车发票号";
            this.购车发票号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.购车发票号.Width = 120;
            // 
            // RPT_单位编制_统计
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 592);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.tyGridView);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "RPT_单位编制_统计";
            this.Text = "RPT_单位编制_统计";
            this.Load += new System.EventHandler(this.RPT_单位编制_统计_Load);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.Button btn预算单位;
        private System.Windows.Forms.TextBox txt单位编码;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn关闭;
        private TY.Grids.TyGridView tyGridView;
        private System.Windows.Forms.Button btn方案查询;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编制情况;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车牌号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车辆类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车辆颜色;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂牌型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发动机号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车架号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 排气量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 座位数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 购车发票号;
    }
}