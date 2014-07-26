namespace GCGL_Client.NET
{
    partial class NET_公文法规
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btn查看 = new System.Windows.Forms.Button();
            this.btn删除 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.btn发布法规 = new System.Windows.Forms.Button();
            this.btn发布公文 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtp结束时间 = new System.Windows.Forms.DateTimePicker();
            this.dtp开始时间 = new System.Windows.Forms.DateTimePicker();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt关键字 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.标题 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.查阅次数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发布人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发布时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTool.SuspendLayout();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(859, 45);
            this.lblTitle.TabIndex = 127;
            this.lblTitle.Text = "公文法规列表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTool.Controls.Add(this.btn查看);
            this.pnlTool.Controls.Add(this.btn删除);
            this.pnlTool.Controls.Add(this.btn修改);
            this.pnlTool.Controls.Add(this.btn发布法规);
            this.pnlTool.Controls.Add(this.btn发布公文);
            this.pnlTool.Controls.Add(this.btn关闭);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(859, 30);
            this.pnlTool.TabIndex = 126;
            // 
            // btn查看
            // 
            this.btn查看.BackColor = System.Drawing.SystemColors.Control;
            this.btn查看.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn查看.Location = new System.Drawing.Point(326, 0);
            this.btn查看.Name = "btn查看";
            this.btn查看.Size = new System.Drawing.Size(75, 28);
            this.btn查看.TabIndex = 4;
            this.btn查看.Text = "查看(&K)";
            this.btn查看.UseVisualStyleBackColor = false;
            this.btn查看.Click += new System.EventHandler(this.btn查看_Click);
            // 
            // btn删除
            // 
            this.btn删除.BackColor = System.Drawing.SystemColors.Control;
            this.btn删除.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn删除.Location = new System.Drawing.Point(251, 0);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(75, 28);
            this.btn删除.TabIndex = 10;
            this.btn删除.Text = "删除(&D)";
            this.btn删除.UseVisualStyleBackColor = false;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // btn修改
            // 
            this.btn修改.BackColor = System.Drawing.SystemColors.Control;
            this.btn修改.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn修改.Location = new System.Drawing.Point(176, 0);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(75, 28);
            this.btn修改.TabIndex = 9;
            this.btn修改.Text = "修改(&M)";
            this.btn修改.UseVisualStyleBackColor = false;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // btn发布法规
            // 
            this.btn发布法规.BackColor = System.Drawing.SystemColors.Control;
            this.btn发布法规.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn发布法规.ForeColor = System.Drawing.Color.Red;
            this.btn发布法规.Location = new System.Drawing.Point(88, 0);
            this.btn发布法规.Name = "btn发布法规";
            this.btn发布法规.Size = new System.Drawing.Size(88, 28);
            this.btn发布法规.TabIndex = 8;
            this.btn发布法规.Text = "发布法规(&T)";
            this.btn发布法规.UseVisualStyleBackColor = false;
            this.btn发布法规.Click += new System.EventHandler(this.btn发布法规_Click);
            // 
            // btn发布公文
            // 
            this.btn发布公文.BackColor = System.Drawing.SystemColors.Control;
            this.btn发布公文.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn发布公文.ForeColor = System.Drawing.Color.Blue;
            this.btn发布公文.Location = new System.Drawing.Point(0, 0);
            this.btn发布公文.Name = "btn发布公文";
            this.btn发布公文.Size = new System.Drawing.Size(88, 28);
            this.btn发布公文.TabIndex = 11;
            this.btn发布公文.Text = "发布公文(&G)";
            this.btn发布公文.UseVisualStyleBackColor = false;
            this.btn发布公文.Click += new System.EventHandler(this.btn发布公文_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.BackColor = System.Drawing.SystemColors.Control;
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(782, 0);
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
            this.btnQuery.Location = new System.Drawing.Point(784, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtp结束时间
            // 
            this.dtp结束时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp结束时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp结束时间.Location = new System.Drawing.Point(237, 5);
            this.dtp结束时间.Name = "dtp结束时间";
            this.dtp结束时间.Size = new System.Drawing.Size(121, 21);
            this.dtp结束时间.TabIndex = 11;
            // 
            // dtp开始时间
            // 
            this.dtp开始时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp开始时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp开始时间.Location = new System.Drawing.Point(93, 5);
            this.dtp开始时间.Name = "dtp开始时间";
            this.dtp开始时间.Size = new System.Drawing.Size(122, 21);
            this.dtp开始时间.TabIndex = 10;
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlQuery.Controls.Add(this.label3);
            this.pnlQuery.Controls.Add(this.txt关键字);
            this.pnlQuery.Controls.Add(this.label1);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Controls.Add(this.dtp结束时间);
            this.pnlQuery.Controls.Add(this.dtp开始时间);
            this.pnlQuery.Controls.Add(this.label2);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 75);
            this.pnlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(859, 30);
            this.pnlQuery.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "至";
            // 
            // txt关键字
            // 
            this.txt关键字.Location = new System.Drawing.Point(456, 5);
            this.txt关键字.Name = "txt关键字";
            this.txt关键字.Size = new System.Drawing.Size(247, 21);
            this.txt关键字.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "检索关键字：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "发布日期从：";
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
            this.标题,
            this.查阅次数,
            this.发布人,
            this.发布时间});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 105);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowHeadersWidth = 30;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(859, 491);
            this.dgvList.TabIndex = 125;
            // 
            // 标题
            // 
            this.标题.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.标题.DataPropertyName = "公文标题";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.标题.DefaultCellStyle = dataGridViewCellStyle2;
            this.标题.HeaderText = "标题";
            this.标题.MinimumWidth = 100;
            this.标题.Name = "标题";
            this.标题.ReadOnly = true;
            this.标题.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 查阅次数
            // 
            this.查阅次数.DataPropertyName = "查看次数";
            this.查阅次数.HeaderText = "查阅次数";
            this.查阅次数.Name = "查阅次数";
            this.查阅次数.ReadOnly = true;
            this.查阅次数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 发布人
            // 
            this.发布人.DataPropertyName = "创建人";
            this.发布人.HeaderText = "发布人";
            this.发布人.Name = "发布人";
            this.发布人.ReadOnly = true;
            this.发布人.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.发布人.Width = 80;
            // 
            // 发布时间
            // 
            this.发布时间.DataPropertyName = "创建时间";
            this.发布时间.HeaderText = "发布时间";
            this.发布时间.Name = "发布时间";
            this.发布时间.ReadOnly = true;
            this.发布时间.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.发布时间.Width = 110;
            // 
            // NET_公文法规
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 596);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlTool);
            this.Name = "NET_公文法规";
            this.Text = "NET_公文法规";
            this.Load += new System.EventHandler(this.NET_公文法规_Load);
            this.pnlTool.ResumeLayout(false);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtp结束时间;
        private System.Windows.Forms.DateTimePicker dtp开始时间;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TextBox txt关键字;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 标题;
        private System.Windows.Forms.DataGridViewTextBoxColumn 查阅次数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发布人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发布时间;
        private System.Windows.Forms.Button btn查看;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Button btn发布法规;
        private System.Windows.Forms.Button btn发布公文;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}