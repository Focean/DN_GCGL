namespace GCGL_Client.OCC
{
    partial class OCC_公车库存_Select
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iglTree = new System.Windows.Forms.ImageList(this.components);
            this.btn查询 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp开始时间 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp结束时间 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt车牌号 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv单位资产 = new System.Windows.Forms.DataGridView();
            this.btn确定 = new System.Windows.Forms.Button();
            this.btn取消 = new System.Windows.Forms.Button();
            this.资产编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编制情况 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车牌号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车架号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发动机号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.取得日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv单位资产)).BeginInit();
            this.SuspendLayout();
            // 
            // iglTree
            // 
            this.iglTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iglTree.ImageSize = new System.Drawing.Size(16, 16);
            this.iglTree.TransparentColor = System.Drawing.Color.Fuchsia;
            // 
            // btn查询
            // 
            this.btn查询.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn查询.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn查询.Location = new System.Drawing.Point(571, 0);
            this.btn查询.Name = "btn查询";
            this.btn查询.Size = new System.Drawing.Size(75, 28);
            this.btn查询.TabIndex = 258;
            this.btn查询.Text = "查询(&Q)";
            this.btn查询.UseVisualStyleBackColor = true;
            this.btn查询.Click += new System.EventHandler(this.btn查询_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 259;
            this.label1.Text = "取得日期:从";
            // 
            // dtp开始时间
            // 
            this.dtp开始时间.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtp开始时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp开始时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp开始时间.Location = new System.Drawing.Point(88, 5);
            this.dtp开始时间.Name = "dtp开始时间";
            this.dtp开始时间.Size = new System.Drawing.Size(122, 21);
            this.dtp开始时间.TabIndex = 260;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(217, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 261;
            this.label2.Text = "到";
            // 
            // dtp结束时间
            // 
            this.dtp结束时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp结束时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp结束时间.Location = new System.Drawing.Point(241, 5);
            this.dtp结束时间.Name = "dtp结束时间";
            this.dtp结束时间.Size = new System.Drawing.Size(121, 21);
            this.dtp结束时间.TabIndex = 262;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txt车牌号);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp结束时间);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtp开始时间);
            this.panel1.Controls.Add(this.btn查询);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 28);
            this.panel1.TabIndex = 264;
            // 
            // txt车牌号
            // 
            this.txt车牌号.Location = new System.Drawing.Point(433, 5);
            this.txt车牌号.Name = "txt车牌号";
            this.txt车牌号.Size = new System.Drawing.Size(81, 21);
            this.txt车牌号.TabIndex = 264;
            this.txt车牌号.Text = "豫";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(387, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 263;
            this.label3.Text = "车牌号：";
            // 
            // dgv单位资产
            // 
            this.dgv单位资产.AllowUserToAddRows = false;
            this.dgv单位资产.AllowUserToDeleteRows = false;
            this.dgv单位资产.AllowUserToResizeRows = false;
            this.dgv单位资产.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv单位资产.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv单位资产.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv单位资产.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv单位资产.ColumnHeadersHeight = 28;
            this.dgv单位资产.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv单位资产.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.资产编号,
            this.编制情况,
            this.资产名称,
            this.车牌号,
            this.车架号,
            this.发动机号,
            this.取得日期});
            this.dgv单位资产.EnableHeadersVisualStyles = false;
            this.dgv单位资产.Location = new System.Drawing.Point(0, 31);
            this.dgv单位资产.Name = "dgv单位资产";
            this.dgv单位资产.ReadOnly = true;
            this.dgv单位资产.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv单位资产.RowHeadersWidth = 20;
            this.dgv单位资产.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv单位资产.RowTemplate.Height = 23;
            this.dgv单位资产.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv单位资产.Size = new System.Drawing.Size(646, 341);
            this.dgv单位资产.TabIndex = 265;
            this.dgv单位资产.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv单位资产_MouseDoubleClick);
            // 
            // btn确定
            // 
            this.btn确定.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn确定.Location = new System.Drawing.Point(344, 385);
            this.btn确定.Name = "btn确定";
            this.btn确定.Size = new System.Drawing.Size(110, 28);
            this.btn确定.TabIndex = 275;
            this.btn确定.Text = "确定(Ctrl+D)";
            this.btn确定.UseVisualStyleBackColor = true;
            this.btn确定.Click += new System.EventHandler(this.btn确定_Click);
            // 
            // btn取消
            // 
            this.btn取消.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn取消.Location = new System.Drawing.Point(192, 385);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(110, 28);
            this.btn取消.TabIndex = 274;
            this.btn取消.Text = "取消(&ESC)";
            this.btn取消.UseVisualStyleBackColor = true;
            // 
            // 资产编号
            // 
            this.资产编号.DataPropertyName = "资产编号";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.资产编号.DefaultCellStyle = dataGridViewCellStyle2;
            this.资产编号.HeaderText = "资产编号";
            this.资产编号.Name = "资产编号";
            this.资产编号.ReadOnly = true;
            this.资产编号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.资产编号.Visible = false;
            // 
            // 编制情况
            // 
            this.编制情况.DataPropertyName = "编制情况";
            this.编制情况.HeaderText = "编制情况";
            this.编制情况.Name = "编制情况";
            this.编制情况.ReadOnly = true;
            // 
            // 资产名称
            // 
            this.资产名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.资产名称.DataPropertyName = "资产名称";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.资产名称.DefaultCellStyle = dataGridViewCellStyle3;
            this.资产名称.HeaderText = "资产名称";
            this.资产名称.MinimumWidth = 150;
            this.资产名称.Name = "资产名称";
            this.资产名称.ReadOnly = true;
            this.资产名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 车牌号
            // 
            this.车牌号.DataPropertyName = "车牌号";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.车牌号.DefaultCellStyle = dataGridViewCellStyle4;
            this.车牌号.HeaderText = "车牌号";
            this.车牌号.Name = "车牌号";
            this.车牌号.ReadOnly = true;
            this.车牌号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.车牌号.Width = 120;
            // 
            // 车架号
            // 
            this.车架号.DataPropertyName = "车架号";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.车架号.DefaultCellStyle = dataGridViewCellStyle5;
            this.车架号.HeaderText = "车架号";
            this.车架号.Name = "车架号";
            this.车架号.ReadOnly = true;
            this.车架号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.车架号.Width = 150;
            // 
            // 发动机号
            // 
            this.发动机号.DataPropertyName = "发动机号";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.发动机号.DefaultCellStyle = dataGridViewCellStyle6;
            this.发动机号.HeaderText = "发动机号";
            this.发动机号.Name = "发动机号";
            this.发动机号.ReadOnly = true;
            this.发动机号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 取得日期
            // 
            this.取得日期.DataPropertyName = "取得日期";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.取得日期.DefaultCellStyle = dataGridViewCellStyle7;
            this.取得日期.HeaderText = "取得日期";
            this.取得日期.Name = "取得日期";
            this.取得日期.ReadOnly = true;
            this.取得日期.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OCC_公车库存_Select
            // 
            this.AcceptButton = this.btn查询;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 425);
            this.Controls.Add(this.btn确定);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.dgv单位资产);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(569, 381);
            this.Name = "OCC_公车库存_Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "单位资产信息选择";
            this.Load += new System.EventHandler(this.OCC_资产信息_Select_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OCC_公车库存_Select_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv单位资产)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList iglTree;
        private System.Windows.Forms.Button btn查询;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp开始时间;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp结束时间;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv单位资产;
        private System.Windows.Forms.Button btn确定;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.TextBox txt车牌号;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编制情况;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车牌号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车架号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发动机号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 取得日期;
    }
}