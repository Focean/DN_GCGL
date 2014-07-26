namespace GCGL_Client.RPT
{
    partial class RPT_公车库存_变化
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.chk全部单位 = new System.Windows.Forms.CheckBox();
            this.btn预算单位 = new System.Windows.Forms.Button();
            this.txt单位编码 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt查询年度 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn导出 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.tyGridView = new TY.Grids.TyGridView(this.components);
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.入库单编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车辆类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂牌型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.座位数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车牌号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发动机号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车架号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.排气量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.账面净值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlQuery.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Controls.Add(this.chk全部单位);
            this.pnlQuery.Controls.Add(this.btn预算单位);
            this.pnlQuery.Controls.Add(this.txt单位编码);
            this.pnlQuery.Controls.Add(this.label11);
            this.pnlQuery.Controls.Add(this.txt查询年度);
            this.pnlQuery.Controls.Add(this.label1);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 68);
            this.pnlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(742, 30);
            this.pnlQuery.TabIndex = 132;
            // 
            // chk全部单位
            // 
            this.chk全部单位.AutoSize = true;
            this.chk全部单位.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.chk全部单位.Checked = true;
            this.chk全部单位.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk全部单位.ForeColor = System.Drawing.Color.Fuchsia;
            this.chk全部单位.Location = new System.Drawing.Point(281, 7);
            this.chk全部单位.Name = "chk全部单位";
            this.chk全部单位.Size = new System.Drawing.Size(72, 16);
            this.chk全部单位.TabIndex = 147;
            this.chk全部单位.Text = "全部单位";
            this.chk全部单位.UseVisualStyleBackColor = false;
            this.chk全部单位.Visible = false;
            this.chk全部单位.CheckedChanged += new System.EventHandler(this.chk全部单位_CheckedChanged);
            // 
            // btn预算单位
            // 
            this.btn预算单位.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn预算单位.Location = new System.Drawing.Point(252, 4);
            this.btn预算单位.Name = "btn预算单位";
            this.btn预算单位.Size = new System.Drawing.Size(21, 19);
            this.btn预算单位.TabIndex = 145;
            this.btn预算单位.Text = "…";
            this.btn预算单位.UseVisualStyleBackColor = true;
            this.btn预算单位.Click += new System.EventHandler(this.btn预算单位_Click);
            // 
            // txt单位编码
            // 
            this.txt单位编码.Location = new System.Drawing.Point(66, 3);
            this.txt单位编码.Name = "txt单位编码";
            this.txt单位编码.ReadOnly = true;
            this.txt单位编码.Size = new System.Drawing.Size(208, 21);
            this.txt单位编码.TabIndex = 146;
            this.txt单位编码.TextChanged += new System.EventHandler(this.txt单位编码_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(496, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 143;
            this.label11.Text = "年";
            // 
            // txt查询年度
            // 
            this.txt查询年度.Location = new System.Drawing.Point(421, 5);
            this.txt查询年度.Name = "txt查询年度";
            this.txt查询年度.Size = new System.Drawing.Size(72, 21);
            this.txt查询年度.TabIndex = 142;
            this.txt查询年度.Text = "2013";
            this.txt查询年度.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt查询年度_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 141;
            this.label1.Text = "查询年度：";
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
            this.btnQuery.Location = new System.Drawing.Point(667, 0);
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
            this.lblTitle.Size = new System.Drawing.Size(742, 40);
            this.lblTitle.TabIndex = 131;
            this.lblTitle.Text = "车辆年度变化列表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn导出);
            this.panel1.Controls.Add(this.btn关闭);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 28);
            this.panel1.TabIndex = 133;
            // 
            // btn导出
            // 
            this.btn导出.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn导出.Location = new System.Drawing.Point(592, 0);
            this.btn导出.Name = "btn导出";
            this.btn导出.Size = new System.Drawing.Size(75, 28);
            this.btn导出.TabIndex = 5;
            this.btn导出.Text = "导出（&E)";
            this.btn导出.UseVisualStyleBackColor = true;
            this.btn导出.Click += new System.EventHandler(this.btn导出_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(667, 0);
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
            this.tyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tyGridView.Location = new System.Drawing.Point(0, 98);
            this.tyGridView.Name = "tyGridView";
            this.tyGridView.RowTemplate.Height = 23;
            this.tyGridView.Size = new System.Drawing.Size(742, 78);
            this.tyGridView.TabIndex = 135;
            this.tyGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tyGridView_CellMouseClick);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvList.ColumnHeadersHeight = 28;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.入库单编码,
            this.资产编号,
            this.资产名称,
            this.规格型号,
            this.车辆类型,
            this.资产类别,
            this.厂牌型号,
            this.座位数,
            this.车牌号,
            this.发动机号,
            this.车架号,
            this.排气量,
            this.价值,
            this.账面净值});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 176);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(742, 345);
            this.dgvList.TabIndex = 136;
            // 
            // 入库单编码
            // 
            this.入库单编码.DataPropertyName = "入库单编码";
            this.入库单编码.HeaderText = "入库单编码";
            this.入库单编码.Name = "入库单编码";
            this.入库单编码.ReadOnly = true;
            this.入库单编码.Visible = false;
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
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0";
            this.规格型号.DefaultCellStyle = dataGridViewCellStyle10;
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
            // 
            // 资产类别
            // 
            this.资产类别.DataPropertyName = "资产类别名称";
            this.资产类别.HeaderText = "资产类别";
            this.资产类别.Name = "资产类别";
            this.资产类别.ReadOnly = true;
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
            // 座位数
            // 
            this.座位数.DataPropertyName = "座位数";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.座位数.DefaultCellStyle = dataGridViewCellStyle11;
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
            // 排气量
            // 
            this.排气量.DataPropertyName = "排气量";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.排气量.DefaultCellStyle = dataGridViewCellStyle12;
            this.排气量.HeaderText = "排气量";
            this.排气量.Name = "排气量";
            this.排气量.ReadOnly = true;
            // 
            // 价值
            // 
            this.价值.DataPropertyName = "价值";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N4";
            dataGridViewCellStyle13.NullValue = "0";
            this.价值.DefaultCellStyle = dataGridViewCellStyle13;
            this.价值.HeaderText = "价值(万元)";
            this.价值.Name = "价值";
            this.价值.ReadOnly = true;
            this.价值.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.价值.Width = 120;
            // 
            // 账面净值
            // 
            this.账面净值.DataPropertyName = "账面净值";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N4";
            dataGridViewCellStyle14.NullValue = "0";
            this.账面净值.DefaultCellStyle = dataGridViewCellStyle14;
            this.账面净值.HeaderText = "账面净值(万元)";
            this.账面净值.Name = "账面净值";
            this.账面净值.ReadOnly = true;
            this.账面净值.Width = 120;
            // 
            // RPT_公车库存_变化
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(742, 521);
            this.Controls.Add(this.tyGridView);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvList);
            this.Name = "RPT_公车库存_变化";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn导出;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.TextBox txt查询年度;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private TY.Grids.TyGridView tyGridView;
        private System.Windows.Forms.Button btn预算单位;
        private System.Windows.Forms.TextBox txt单位编码;
        private System.Windows.Forms.CheckBox chk全部单位;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入库单编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车辆类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂牌型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 座位数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车牌号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发动机号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车架号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 排气量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价值;
        private System.Windows.Forms.DataGridViewTextBoxColumn 账面净值;
    }
}