namespace GCGL_Client.OCC
{
    partial class OCC_处置申请_Select
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
            this.iglTree = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dtp结束时间 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp开始时间 = new System.Windows.Forms.DateTimePicker();
            this.btn查找 = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.申请编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车牌号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车架号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn确定 = new System.Windows.Forms.Button();
            this.btn取消 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iglTree
            // 
            this.iglTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iglTree.ImageSize = new System.Drawing.Size(16, 16);
            this.iglTree.TransparentColor = System.Drawing.Color.Fuchsia;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(217, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 261;
            this.label2.Text = "到";
            // 
            // dtp结束时间
            // 
            this.dtp结束时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp结束时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp结束时间.Location = new System.Drawing.Point(241, 8);
            this.dtp结束时间.Name = "dtp结束时间";
            this.dtp结束时间.Size = new System.Drawing.Size(121, 21);
            this.dtp结束时间.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 259;
            this.label1.Text = "申请时间:从";
            // 
            // dtp开始时间
            // 
            this.dtp开始时间.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtp开始时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp开始时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp开始时间.Location = new System.Drawing.Point(88, 7);
            this.dtp开始时间.Name = "dtp开始时间";
            this.dtp开始时间.Size = new System.Drawing.Size(122, 21);
            this.dtp开始时间.TabIndex = 1;
            this.dtp开始时间.Value = new System.DateTime(2013, 1, 24, 18, 2, 0, 0);
            // 
            // btn查找
            // 
            this.btn查找.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn查找.Location = new System.Drawing.Point(574, 0);
            this.btn查找.Name = "btn查找";
            this.btn查找.Size = new System.Drawing.Size(75, 34);
            this.btn查找.TabIndex = 0;
            this.btn查找.Text = "查询(&Q)";
            this.btn查找.UseVisualStyleBackColor = true;
            this.btn查找.Click += new System.EventHandler(this.btn查找_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.申请序号,
            this.资产编号,
            this.资产名称,
            this.车牌号,
            this.车架号});
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 35);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(649, 296);
            this.dgvList.TabIndex = 267;
            this.dgvList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvList_MouseDoubleClick);
            // 
            // 申请编号
            // 
            this.申请编号.DataPropertyName = "申请编号";
            this.申请编号.HeaderText = "申请编号";
            this.申请编号.Name = "申请编号";
            this.申请编号.ReadOnly = true;
            this.申请编号.Width = 120;
            // 
            // 申请序号
            // 
            this.申请序号.DataPropertyName = "申请序号";
            this.申请序号.HeaderText = "申请序号";
            this.申请序号.Name = "申请序号";
            this.申请序号.ReadOnly = true;
            this.申请序号.Visible = false;
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
            this.车牌号.HeaderText = "车牌号";
            this.车牌号.Name = "车牌号";
            this.车牌号.ReadOnly = true;
            this.车牌号.Width = 120;
            // 
            // 车架号
            // 
            this.车架号.DataPropertyName = "车架号";
            this.车架号.HeaderText = "车架号";
            this.车架号.Name = "车架号";
            this.车架号.ReadOnly = true;
            this.车架号.Width = 120;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp结束时间);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtp开始时间);
            this.panel1.Controls.Add(this.btn查找);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 34);
            this.panel1.TabIndex = 266;
            // 
            // btn确定
            // 
            this.btn确定.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn确定.Location = new System.Drawing.Point(343, 342);
            this.btn确定.Name = "btn确定";
            this.btn确定.Size = new System.Drawing.Size(110, 28);
            this.btn确定.TabIndex = 3;
            this.btn确定.Text = "确定(Ctrl+D)";
            this.btn确定.UseVisualStyleBackColor = true;
            this.btn确定.Click += new System.EventHandler(this.btn确定_Click);
            // 
            // btn取消
            // 
            this.btn取消.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn取消.Location = new System.Drawing.Point(196, 342);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(110, 28);
            this.btn取消.TabIndex = 4;
            this.btn取消.Text = "取消(&ESC)";
            this.btn取消.UseVisualStyleBackColor = true;
            // 
            // OCC_处置申请_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 381);
            this.Controls.Add(this.btn确定);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "OCC_处置申请_Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.OCC_处置申请_Select_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OCC_处置申请_Select_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList iglTree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp结束时间;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp开始时间;
        private System.Windows.Forms.Button btn查找;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn确定;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车牌号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车架号;
    }
}