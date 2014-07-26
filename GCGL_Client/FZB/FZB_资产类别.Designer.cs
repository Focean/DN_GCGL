namespace GCGL_Client.FZB
{
    partial class FZB_资产类别
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMT = new System.Windows.Forms.Panel();
            this.Lbl标题 = new System.Windows.Forms.Label();
            this.Btn刷新 = new System.Windows.Forms.Button();
            this.Btn修改 = new System.Windows.Forms.Button();
            this.Btn删除 = new System.Windows.Forms.Button();
            this.Btn增加 = new System.Windows.Forms.Button();
            this.Btn关闭 = new System.Windows.Forms.Button();
            this.panelT = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.资产类别编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产类别名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMT.SuspendLayout();
            this.panelT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMT
            // 
            this.panelMT.Controls.Add(this.Lbl标题);
            this.panelMT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMT.Location = new System.Drawing.Point(0, 25);
            this.panelMT.Name = "panelMT";
            this.panelMT.Size = new System.Drawing.Size(865, 32);
            this.panelMT.TabIndex = 77;
            // 
            // Lbl标题
            // 
            this.Lbl标题.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl标题.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl标题.Location = new System.Drawing.Point(0, 0);
            this.Lbl标题.Name = "Lbl标题";
            this.Lbl标题.Size = new System.Drawing.Size(865, 32);
            this.Lbl标题.TabIndex = 3;
            this.Lbl标题.Text = "资产类别列表";
            this.Lbl标题.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn刷新
            // 
            this.Btn刷新.BackColor = System.Drawing.SystemColors.Control;
            this.Btn刷新.Location = new System.Drawing.Point(192, 0);
            this.Btn刷新.Name = "Btn刷新";
            this.Btn刷新.Size = new System.Drawing.Size(65, 25);
            this.Btn刷新.TabIndex = 4;
            this.Btn刷新.Text = "刷新(&R)";
            this.Btn刷新.UseVisualStyleBackColor = false;
            this.Btn刷新.Click += new System.EventHandler(this.Btn刷新_Click);
            // 
            // Btn修改
            // 
            this.Btn修改.BackColor = System.Drawing.SystemColors.Control;
            this.Btn修改.Location = new System.Drawing.Point(128, 0);
            this.Btn修改.Name = "Btn修改";
            this.Btn修改.Size = new System.Drawing.Size(65, 25);
            this.Btn修改.TabIndex = 15;
            this.Btn修改.Text = "修改(&U)";
            this.Btn修改.UseVisualStyleBackColor = false;
            this.Btn修改.Click += new System.EventHandler(this.Btn修改_Click);
            // 
            // Btn删除
            // 
            this.Btn删除.BackColor = System.Drawing.SystemColors.Control;
            this.Btn删除.Location = new System.Drawing.Point(64, 0);
            this.Btn删除.Name = "Btn删除";
            this.Btn删除.Size = new System.Drawing.Size(65, 25);
            this.Btn删除.TabIndex = 16;
            this.Btn删除.Text = "删除(&D)";
            this.Btn删除.UseVisualStyleBackColor = false;
            this.Btn删除.Click += new System.EventHandler(this.Btn删除_Click);
            // 
            // Btn增加
            // 
            this.Btn增加.BackColor = System.Drawing.SystemColors.Control;
            this.Btn增加.Location = new System.Drawing.Point(0, 0);
            this.Btn增加.Name = "Btn增加";
            this.Btn增加.Size = new System.Drawing.Size(65, 25);
            this.Btn增加.TabIndex = 14;
            this.Btn增加.Text = "增加(&A)";
            this.Btn增加.UseVisualStyleBackColor = false;
            this.Btn增加.Click += new System.EventHandler(this.Btn增加_Click);
            // 
            // Btn关闭
            // 
            this.Btn关闭.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn关闭.BackColor = System.Drawing.SystemColors.Control;
            this.Btn关闭.Location = new System.Drawing.Point(800, 0);
            this.Btn关闭.Name = "Btn关闭";
            this.Btn关闭.Size = new System.Drawing.Size(65, 25);
            this.Btn关闭.TabIndex = 0;
            this.Btn关闭.Text = "关闭(&X)";
            this.Btn关闭.UseVisualStyleBackColor = false;
            this.Btn关闭.Click += new System.EventHandler(this.Btn关闭_Click);
            // 
            // panelT
            // 
            this.panelT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelT.Controls.Add(this.Btn刷新);
            this.panelT.Controls.Add(this.Btn修改);
            this.panelT.Controls.Add(this.Btn删除);
            this.panelT.Controls.Add(this.Btn增加);
            this.panelT.Controls.Add(this.Btn关闭);
            this.panelT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelT.Location = new System.Drawing.Point(0, 0);
            this.panelT.Name = "panelT";
            this.panelT.Size = new System.Drawing.Size(865, 25);
            this.panelT.TabIndex = 76;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvList.ColumnHeadersHeight = 28;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.资产类别编码,
            this.资产类别名称});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 60);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
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
            this.dgvList.Size = new System.Drawing.Size(865, 513);
            this.dgvList.TabIndex = 78;
            // 
            // 资产类别编码
            // 
            this.资产类别编码.DataPropertyName = "资产类别编码";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.资产类别编码.DefaultCellStyle = dataGridViewCellStyle7;
            this.资产类别编码.HeaderText = "资产类别编码";
            this.资产类别编码.Name = "资产类别编码";
            this.资产类别编码.ReadOnly = true;
            this.资产类别编码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.资产类别编码.Width = 150;
            // 
            // 资产类别名称
            // 
            this.资产类别名称.DataPropertyName = "资产类别名称";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.资产类别名称.DefaultCellStyle = dataGridViewCellStyle8;
            this.资产类别名称.HeaderText = "资产类别名称";
            this.资产类别名称.Name = "资产类别名称";
            this.资产类别名称.ReadOnly = true;
            this.资产类别名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.资产类别名称.Width = 350;
            // 
            // FZB_资产类别
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 572);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.panelMT);
            this.Controls.Add(this.panelT);
            this.Name = "FZB_资产类别";
            this.Text = "资产分类设置";
            this.panelMT.ResumeLayout(false);
            this.panelT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMT;
        private System.Windows.Forms.Label Lbl标题;
        private System.Windows.Forms.Button Btn刷新;
        private System.Windows.Forms.Button Btn修改;
        private System.Windows.Forms.Button Btn删除;
        private System.Windows.Forms.Button Btn增加;
        private System.Windows.Forms.Button Btn关闭;
        private System.Windows.Forms.Panel panelT;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产类别编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产类别名称;
    }
}