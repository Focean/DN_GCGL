namespace GCGL_Client.FZB
{
    partial class FZB_配置标准
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btn附件查看 = new System.Windows.Forms.Button();
            this.btn查看 = new System.Windows.Forms.Button();
            this.btn删除 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车辆类型名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产类别名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.排量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否新能源汽车 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.依据文件编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否生效 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTop.Controls.Add(this.btn附件查看);
            this.pnlTop.Controls.Add(this.btn查看);
            this.pnlTop.Controls.Add(this.btn删除);
            this.pnlTop.Controls.Add(this.btn关闭);
            this.pnlTop.Controls.Add(this.btn修改);
            this.pnlTop.Controls.Add(this.btn新增);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(907, 28);
            this.pnlTop.TabIndex = 10;
            // 
            // btn附件查看
            // 
            this.btn附件查看.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn附件查看.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn附件查看.Location = new System.Drawing.Point(300, 0);
            this.btn附件查看.Name = "btn附件查看";
            this.btn附件查看.Size = new System.Drawing.Size(80, 28);
            this.btn附件查看.TabIndex = 5;
            this.btn附件查看.Text = "附件查看(&W)";
            this.btn附件查看.UseVisualStyleBackColor = true;
            this.btn附件查看.Click += new System.EventHandler(this.btn附件查看_Click);
            // 
            // btn查看
            // 
            this.btn查看.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn查看.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn查看.Location = new System.Drawing.Point(225, 0);
            this.btn查看.Name = "btn查看";
            this.btn查看.Size = new System.Drawing.Size(75, 28);
            this.btn查看.TabIndex = 4;
            this.btn查看.Text = "查看(&K)";
            this.btn查看.UseVisualStyleBackColor = true;
            this.btn查看.Click += new System.EventHandler(this.btn查看_Click);
            // 
            // btn删除
            // 
            this.btn删除.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn删除.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn删除.Location = new System.Drawing.Point(150, 0);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(75, 28);
            this.btn删除.TabIndex = 3;
            this.btn删除.Text = "删除(&D)";
            this.btn删除.UseVisualStyleBackColor = true;
            this.btn删除.Visible = false;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(832, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 7;
            this.btn关闭.Text = "关闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = true;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // btn修改
            // 
            this.btn修改.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn修改.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn修改.Location = new System.Drawing.Point(75, 0);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(75, 28);
            this.btn修改.TabIndex = 2;
            this.btn修改.Text = "修改(&M)";
            this.btn修改.UseVisualStyleBackColor = true;
            this.btn修改.Visible = false;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // btn新增
            // 
            this.btn新增.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn新增.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn新增.Location = new System.Drawing.Point(0, 0);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(75, 28);
            this.btn新增.TabIndex = 1;
            this.btn新增.Text = "新增(&A)";
            this.btn新增.UseVisualStyleBackColor = true;
            this.btn新增.Visible = false;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblTitle.Location = new System.Drawing.Point(0, 28);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(907, 40);
            this.LblTitle.TabIndex = 11;
            this.LblTitle.Text = "车辆配置标准列表";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ID,
            this.车辆类型名称,
            this.资产类别名称,
            this.排量,
            this.价格,
            this.是否新能源汽车,
            this.依据文件编码,
            this.创建时间,
            this.是否生效});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 68);
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
            this.dgvList.Size = new System.Drawing.Size(907, 571);
            this.dgvList.TabIndex = 12;
            this.dgvList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvList_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "编码";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // 车辆类型名称
            // 
            this.车辆类型名称.DataPropertyName = "车辆类型名称";
            this.车辆类型名称.HeaderText = "车辆类型";
            this.车辆类型名称.MinimumWidth = 120;
            this.车辆类型名称.Name = "车辆类型名称";
            this.车辆类型名称.ReadOnly = true;
            this.车辆类型名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.车辆类型名称.Width = 150;
            // 
            // 资产类别名称
            // 
            this.资产类别名称.DataPropertyName = "资产类别名称";
            this.资产类别名称.HeaderText = "资产类别";
            this.资产类别名称.Name = "资产类别名称";
            this.资产类别名称.ReadOnly = true;
            this.资产类别名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.资产类别名称.Width = 150;
            // 
            // 排量
            // 
            this.排量.DataPropertyName = "排量";
            this.排量.HeaderText = "排量(升)";
            this.排量.Name = "排量";
            this.排量.ReadOnly = true;
            this.排量.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.排量.Width = 80;
            // 
            // 价格
            // 
            this.价格.DataPropertyName = "价格";
            this.价格.HeaderText = "价格(万元)";
            this.价格.Name = "价格";
            this.价格.ReadOnly = true;
            this.价格.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 是否新能源汽车
            // 
            this.是否新能源汽车.DataPropertyName = "是否新能源汽车";
            this.是否新能源汽车.HeaderText = "是否新能源汽车";
            this.是否新能源汽车.Name = "是否新能源汽车";
            this.是否新能源汽车.ReadOnly = true;
            this.是否新能源汽车.Width = 120;
            // 
            // 依据文件编码
            // 
            this.依据文件编码.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.依据文件编码.DataPropertyName = "依据文件编码";
            this.依据文件编码.HeaderText = "依据文件";
            this.依据文件编码.MinimumWidth = 150;
            this.依据文件编码.Name = "依据文件编码";
            this.依据文件编码.ReadOnly = true;
            this.依据文件编码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 创建时间
            // 
            this.创建时间.DataPropertyName = "创建时间";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.创建时间.DefaultCellStyle = dataGridViewCellStyle2;
            this.创建时间.HeaderText = "创建时间";
            this.创建时间.MinimumWidth = 100;
            this.创建时间.Name = "创建时间";
            this.创建时间.ReadOnly = true;
            this.创建时间.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.创建时间.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.创建时间.Width = 120;
            // 
            // 是否生效
            // 
            this.是否生效.DataPropertyName = "是否生效";
            this.是否生效.HeaderText = "是否生效";
            this.是否生效.Name = "是否生效";
            this.是否生效.ReadOnly = true;
            this.是否生效.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.是否生效.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FZB_配置标准
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 642);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.pnlTop);
            this.Name = "FZB_配置标准";
            this.Load += new System.EventHandler(this.FZB_配置标准_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button btn查看;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车辆类型名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产类别名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 排量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否新能源汽车;
        private System.Windows.Forms.DataGridViewTextBoxColumn 依据文件编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否生效;
        private System.Windows.Forms.Button btn附件查看;

    }
}