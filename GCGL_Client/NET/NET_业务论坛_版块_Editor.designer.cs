namespace GCGL_Client.NET
{
    partial class NET_业务论坛_版块_Editor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelT = new System.Windows.Forms.Panel();
            this.Btn刷新 = new System.Windows.Forms.Button();
            this.btn删除 = new System.Windows.Forms.Button();
            this.btn增加 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.Lbl标题 = new System.Windows.Forms.Label();
            this.panelMT = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.版块编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.版块名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn取消 = new System.Windows.Forms.Button();
            this.btn提交 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp创建时间 = new System.Windows.Forms.DateTimePicker();
            this.txt版块简介 = new System.Windows.Forms.TextBox();
            this.txt版块名称 = new System.Windows.Forms.TextBox();
            this.txt版主人编码 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelT.SuspendLayout();
            this.panelMT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelT
            // 
            this.panelT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelT.Controls.Add(this.Btn刷新);
            this.panelT.Controls.Add(this.btn删除);
            this.panelT.Controls.Add(this.btn增加);
            this.panelT.Controls.Add(this.btn关闭);
            this.panelT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelT.Location = new System.Drawing.Point(0, 0);
            this.panelT.Name = "panelT";
            this.panelT.Size = new System.Drawing.Size(950, 25);
            this.panelT.TabIndex = 92;
            // 
            // Btn刷新
            // 
            this.Btn刷新.BackColor = System.Drawing.SystemColors.Control;
            this.Btn刷新.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn刷新.Location = new System.Drawing.Point(130, 0);
            this.Btn刷新.Name = "Btn刷新";
            this.Btn刷新.Size = new System.Drawing.Size(65, 25);
            this.Btn刷新.TabIndex = 4;
            this.Btn刷新.Text = "刷新(&R)";
            this.Btn刷新.UseVisualStyleBackColor = false;
            this.Btn刷新.Click += new System.EventHandler(this.Btn刷新_Click);
            // 
            // btn删除
            // 
            this.btn删除.BackColor = System.Drawing.SystemColors.Control;
            this.btn删除.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn删除.Location = new System.Drawing.Point(65, 0);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(65, 25);
            this.btn删除.TabIndex = 16;
            this.btn删除.Text = "删除(&D)";
            this.btn删除.UseVisualStyleBackColor = false;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // btn增加
            // 
            this.btn增加.BackColor = System.Drawing.SystemColors.Control;
            this.btn增加.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn增加.Location = new System.Drawing.Point(0, 0);
            this.btn增加.Name = "btn增加";
            this.btn增加.Size = new System.Drawing.Size(65, 25);
            this.btn增加.TabIndex = 14;
            this.btn增加.Text = "增加(&A)";
            this.btn增加.UseVisualStyleBackColor = false;
            this.btn增加.Click += new System.EventHandler(this.btn增加_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn关闭.BackColor = System.Drawing.SystemColors.Control;
            this.btn关闭.Location = new System.Drawing.Point(885, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(65, 25);
            this.btn关闭.TabIndex = 0;
            this.btn关闭.Text = "关闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = false;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // Lbl标题
            // 
            this.Lbl标题.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl标题.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl标题.Location = new System.Drawing.Point(0, 0);
            this.Lbl标题.Name = "Lbl标题";
            this.Lbl标题.Size = new System.Drawing.Size(950, 32);
            this.Lbl标题.TabIndex = 3;
            this.Lbl标题.Text = "业务论坛版块列表";
            this.Lbl标题.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMT
            // 
            this.panelMT.Controls.Add(this.Lbl标题);
            this.panelMT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMT.Location = new System.Drawing.Point(0, 25);
            this.panelMT.Name = "panelMT";
            this.panelMT.Size = new System.Drawing.Size(950, 32);
            this.panelMT.TabIndex = 93;
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
            this.版块编码,
            this.版块名称,
            this.创建时间});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 57);
            this.dgvList.MinimumSize = new System.Drawing.Size(328, 475);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(373, 507);
            this.dgvList.TabIndex = 94;
            this.dgvList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvList_MouseClick);
            // 
            // 版块编码
            // 
            this.版块编码.DataPropertyName = "版块编码";
            this.版块编码.HeaderText = "版块编码";
            this.版块编码.MinimumWidth = 50;
            this.版块编码.Name = "版块编码";
            this.版块编码.ReadOnly = true;
            // 
            // 版块名称
            // 
            this.版块名称.DataPropertyName = "版块名称";
            this.版块名称.HeaderText = "版块名称";
            this.版块名称.MinimumWidth = 100;
            this.版块名称.Name = "版块名称";
            this.版块名称.ReadOnly = true;
            // 
            // 创建时间
            // 
            this.创建时间.DataPropertyName = "创建时间";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.创建时间.DefaultCellStyle = dataGridViewCellStyle2;
            this.创建时间.HeaderText = "创建时间";
            this.创建时间.MinimumWidth = 80;
            this.创建时间.Name = "创建时间";
            this.创建时间.ReadOnly = true;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(373, 57);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 507);
            this.splitter1.TabIndex = 95;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn取消);
            this.panel1.Controls.Add(this.btn提交);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtp创建时间);
            this.panel1.Controls.Add(this.txt版块简介);
            this.panel1.Controls.Add(this.txt版块名称);
            this.panel1.Controls.Add(this.txt版主人编码);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(378, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 507);
            this.panel1.TabIndex = 96;
            // 
            // btn取消
            // 
            this.btn取消.Location = new System.Drawing.Point(197, 435);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(75, 23);
            this.btn取消.TabIndex = 9;
            this.btn取消.Text = "取消(&ESC)";
            this.btn取消.UseVisualStyleBackColor = true;
            this.btn取消.Visible = false;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // btn提交
            // 
            this.btn提交.Location = new System.Drawing.Point(373, 435);
            this.btn提交.Name = "btn提交";
            this.btn提交.Size = new System.Drawing.Size(75, 23);
            this.btn提交.TabIndex = 8;
            this.btn提交.Text = "提交(&S)";
            this.btn提交.UseVisualStyleBackColor = true;
            this.btn提交.Visible = false;
            this.btn提交.Click += new System.EventHandler(this.btn提交_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "创建时间：";
            // 
            // dtp创建时间
            // 
            this.dtp创建时间.Location = new System.Drawing.Point(379, 88);
            this.dtp创建时间.Name = "dtp创建时间";
            this.dtp创建时间.Size = new System.Drawing.Size(168, 21);
            this.dtp创建时间.TabIndex = 6;
            // 
            // txt版块简介
            // 
            this.txt版块简介.Location = new System.Drawing.Point(98, 136);
            this.txt版块简介.Multiline = true;
            this.txt版块简介.Name = "txt版块简介";
            this.txt版块简介.Size = new System.Drawing.Size(449, 283);
            this.txt版块简介.TabIndex = 5;
            // 
            // txt版块名称
            // 
            this.txt版块名称.BackColor = System.Drawing.SystemColors.Info;
            this.txt版块名称.Location = new System.Drawing.Point(98, 41);
            this.txt版块名称.Name = "txt版块名称";
            this.txt版块名称.Size = new System.Drawing.Size(449, 21);
            this.txt版块名称.TabIndex = 4;
            // 
            // txt版主人编码
            // 
            this.txt版主人编码.Location = new System.Drawing.Point(98, 90);
            this.txt版主人编码.Name = "txt版主人编码";
            this.txt版主人编码.Size = new System.Drawing.Size(197, 21);
            this.txt版主人编码.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "版主人编码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "版块简介：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "版块名称：";
            // 
            // NET_业务论坛_版块_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.panelMT);
            this.Controls.Add(this.panelT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NET_业务论坛_版块_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelT.ResumeLayout(false);
            this.panelMT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelT;
        private System.Windows.Forms.Button Btn刷新;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.Button btn增加;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.Label Lbl标题;
        private System.Windows.Forms.Panel panelMT;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn 版块编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 版块名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建时间;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Button btn提交;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp创建时间;
        private System.Windows.Forms.TextBox txt版块简介;
        private System.Windows.Forms.TextBox txt版块名称;
        private System.Windows.Forms.TextBox txt版主人编码;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}