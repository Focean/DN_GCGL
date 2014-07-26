namespace GCGL_Client.NET
{
    partial class NET_业务论坛
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btn版块管理 = new System.Windows.Forms.Button();
            this.btn浏览 = new System.Windows.Forms.Button();
            this.btn新建 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.版块名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.贴子编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.贴子标题 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发贴人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发贴时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.回贴数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.最后回贴时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.cbx版块名称 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTool.Controls.Add(this.btn版块管理);
            this.pnlTool.Controls.Add(this.btn浏览);
            this.pnlTool.Controls.Add(this.btn新建);
            this.pnlTool.Controls.Add(this.btn关闭);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(880, 30);
            this.pnlTool.TabIndex = 126;
            // 
            // btn版块管理
            // 
            this.btn版块管理.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn版块管理.Location = new System.Drawing.Point(150, 0);
            this.btn版块管理.Name = "btn版块管理";
            this.btn版块管理.Size = new System.Drawing.Size(101, 28);
            this.btn版块管理.TabIndex = 8;
            this.btn版块管理.Text = "版块管理(&G)";
            this.btn版块管理.UseVisualStyleBackColor = true;
            this.btn版块管理.Visible = false;
            this.btn版块管理.Click += new System.EventHandler(this.btn版块管理_Click);
            // 
            // btn浏览
            // 
            this.btn浏览.BackColor = System.Drawing.SystemColors.Control;
            this.btn浏览.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn浏览.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn浏览.Location = new System.Drawing.Point(75, 0);
            this.btn浏览.Name = "btn浏览";
            this.btn浏览.Size = new System.Drawing.Size(75, 28);
            this.btn浏览.TabIndex = 7;
            this.btn浏览.Text = "浏览(&B)";
            this.btn浏览.UseVisualStyleBackColor = false;
            this.btn浏览.Click += new System.EventHandler(this.btn回贴_Click);
            // 
            // btn新建
            // 
            this.btn新建.BackColor = System.Drawing.SystemColors.Control;
            this.btn新建.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn新建.ForeColor = System.Drawing.Color.Blue;
            this.btn新建.Location = new System.Drawing.Point(0, 0);
            this.btn新建.Name = "btn新建";
            this.btn新建.Size = new System.Drawing.Size(75, 28);
            this.btn新建.TabIndex = 1;
            this.btn新建.Text = "发新贴(&N)";
            this.btn新建.UseVisualStyleBackColor = false;
            this.btn新建.Click += new System.EventHandler(this.btn新建_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.BackColor = System.Drawing.SystemColors.Control;
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(803, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 6;
            this.btn关闭.Text = "关闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = false;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuery.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnQuery.Location = new System.Drawing.Point(805, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
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
            this.版块名称,
            this.贴子编码,
            this.贴子标题,
            this.发贴人,
            this.发贴时间,
            this.回贴数,
            this.最后回贴时间});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 98);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvList.RowHeadersWidth = 30;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(880, 478);
            this.dgvList.TabIndex = 125;
            this.dgvList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvList_MouseDoubleClick);
            // 
            // 版块名称
            // 
            this.版块名称.DataPropertyName = "版块名称";
            this.版块名称.HeaderText = "版块";
            this.版块名称.Name = "版块名称";
            this.版块名称.ReadOnly = true;
            this.版块名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.版块名称.Width = 120;
            // 
            // 贴子编码
            // 
            this.贴子编码.DataPropertyName = "贴子编码";
            this.贴子编码.HeaderText = "贴子编码";
            this.贴子编码.Name = "贴子编码";
            this.贴子编码.ReadOnly = true;
            this.贴子编码.Visible = false;
            // 
            // 贴子标题
            // 
            this.贴子标题.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.贴子标题.DataPropertyName = "贴子标题";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.贴子标题.DefaultCellStyle = dataGridViewCellStyle2;
            this.贴子标题.HeaderText = "标题";
            this.贴子标题.MinimumWidth = 100;
            this.贴子标题.Name = "贴子标题";
            this.贴子标题.ReadOnly = true;
            this.贴子标题.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 发贴人
            // 
            this.发贴人.DataPropertyName = "创建人";
            this.发贴人.HeaderText = "发贴人";
            this.发贴人.Name = "发贴人";
            this.发贴人.ReadOnly = true;
            this.发贴人.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.发贴人.Width = 80;
            // 
            // 发贴时间
            // 
            this.发贴时间.DataPropertyName = "创建时间";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.发贴时间.DefaultCellStyle = dataGridViewCellStyle3;
            this.发贴时间.HeaderText = "发贴时间";
            this.发贴时间.Name = "发贴时间";
            this.发贴时间.ReadOnly = true;
            this.发贴时间.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.发贴时间.Width = 110;
            // 
            // 回贴数
            // 
            this.回贴数.DataPropertyName = "回贴数";
            this.回贴数.HeaderText = "回贴数";
            this.回贴数.Name = "回贴数";
            this.回贴数.ReadOnly = true;
            this.回贴数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.回贴数.Width = 70;
            // 
            // 最后回贴时间
            // 
            this.最后回贴时间.DataPropertyName = "最后回贴时间";
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.最后回贴时间.DefaultCellStyle = dataGridViewCellStyle4;
            this.最后回贴时间.HeaderText = "最后回贴时间";
            this.最后回贴时间.Name = "最后回贴时间";
            this.最后回贴时间.ReadOnly = true;
            this.最后回贴时间.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.最后回贴时间.Width = 110;
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlQuery.Controls.Add(this.cbx版块名称);
            this.pnlQuery.Controls.Add(this.label1);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 68);
            this.pnlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(880, 30);
            this.pnlQuery.TabIndex = 128;
            // 
            // cbx版块名称
            // 
            this.cbx版块名称.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx版块名称.FormattingEnabled = true;
            this.cbx版块名称.Items.AddRange(new object[] {
            "全部",
            "购车指南",
            "养车之家",
            "娱乐频道"});
            this.cbx版块名称.Location = new System.Drawing.Point(43, 5);
            this.cbx版块名称.Name = "cbx版块名称";
            this.cbx版块名称.Size = new System.Drawing.Size(172, 20);
            this.cbx版块名称.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "版块：";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(880, 38);
            this.lblTitle.TabIndex = 127;
            this.lblTitle.Text = "论坛列表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NET_业务论坛
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 576);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlTool);
            this.Name = "NET_业务论坛";
            this.Text = "NET_业务论坛";
            this.Load += new System.EventHandler(this.NET_业务论坛_Load);
            this.pnlTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Button btn新建;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn浏览;
        private System.Windows.Forms.ComboBox cbx版块名称;
        private System.Windows.Forms.Button btn版块管理;
        private System.Windows.Forms.DataGridViewTextBoxColumn 版块名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 贴子编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 贴子标题;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发贴人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发贴时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 回贴数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 最后回贴时间;
    }
}