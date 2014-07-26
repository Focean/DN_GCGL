namespace GCGL_Client.FZB
{
    partial class FZB_公车编制数
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btn查看 = new System.Windows.Forms.Button();
            this.btn删除 = new System.Windows.Forms.Button();
            this.btn导出 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.lbl公车编制数配置列表 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开始日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.一般公务用车编制数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.一般执法执勤用车编制数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.特种专业技术用车编制数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否审核 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.审核人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.审核时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn审批 = new System.Windows.Forms.Button();
            this.pnlTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTool.Controls.Add(this.btn审批);
            this.pnlTool.Controls.Add(this.btn查看);
            this.pnlTool.Controls.Add(this.btn删除);
            this.pnlTool.Controls.Add(this.btn导出);
            this.pnlTool.Controls.Add(this.btn修改);
            this.pnlTool.Controls.Add(this.btn关闭);
            this.pnlTool.Controls.Add(this.btn新增);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(849, 30);
            this.pnlTool.TabIndex = 5;
            // 
            // btn查看
            // 
            this.btn查看.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn查看.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn查看.Location = new System.Drawing.Point(225, 0);
            this.btn查看.Name = "btn查看";
            this.btn查看.Size = new System.Drawing.Size(75, 28);
            this.btn查看.TabIndex = 12;
            this.btn查看.Text = "查看(&K)";
            this.btn查看.UseVisualStyleBackColor = true;
            this.btn查看.Visible = false;
            this.btn查看.Click += new System.EventHandler(this.btn查看_Click);
            // 
            // btn删除
            // 
            this.btn删除.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn删除.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn删除.Location = new System.Drawing.Point(150, 0);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(75, 28);
            this.btn删除.TabIndex = 11;
            this.btn删除.Text = "删除(&D)";
            this.btn删除.UseVisualStyleBackColor = true;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // btn导出
            // 
            this.btn导出.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn导出.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn导出.Location = new System.Drawing.Point(697, 0);
            this.btn导出.Name = "btn导出";
            this.btn导出.Size = new System.Drawing.Size(75, 28);
            this.btn导出.TabIndex = 8;
            this.btn导出.Text = "导出(&E)";
            this.btn导出.UseVisualStyleBackColor = true;
            this.btn导出.Click += new System.EventHandler(this.btn导出_Click);
            // 
            // btn修改
            // 
            this.btn修改.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn修改.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn修改.Location = new System.Drawing.Point(75, 0);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(75, 28);
            this.btn修改.TabIndex = 10;
            this.btn修改.Text = "修改(&M)";
            this.btn修改.UseVisualStyleBackColor = true;
            this.btn修改.Visible = false;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(772, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 7;
            this.btn关闭.Text = "关闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = true;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // btn新增
            // 
            this.btn新增.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn新增.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn新增.Location = new System.Drawing.Point(0, 0);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(75, 28);
            this.btn新增.TabIndex = 9;
            this.btn新增.Text = "新增(&N)";
            this.btn新增.UseVisualStyleBackColor = true;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // lbl公车编制数配置列表
            // 
            this.lbl公车编制数配置列表.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl公车编制数配置列表.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl公车编制数配置列表.Location = new System.Drawing.Point(0, 30);
            this.lbl公车编制数配置列表.Name = "lbl公车编制数配置列表";
            this.lbl公车编制数配置列表.Size = new System.Drawing.Size(849, 45);
            this.lbl公车编制数配置列表.TabIndex = 12;
            this.lbl公车编制数配置列表.Text = "公车编制数配置列表";
            this.lbl公车编制数配置列表.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvList.ColumnHeadersHeight = 28;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.单位编码,
            this.单位名称,
            this.开始日期,
            this.一般公务用车编制数,
            this.一般执法执勤用车编制数,
            this.特种专业技术用车编制数,
            this.是否审核,
            this.审核人,
            this.审核时间});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 75);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(849, 453);
            this.dgvList.TabIndex = 122;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Visible = false;
            this.ID.Width = 80;
            // 
            // 单位编码
            // 
            this.单位编码.DataPropertyName = "单位编码";
            this.单位编码.HeaderText = "单位编码";
            this.单位编码.Name = "单位编码";
            this.单位编码.ReadOnly = true;
            this.单位编码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.单位编码.Visible = false;
            this.单位编码.Width = 150;
            // 
            // 单位名称
            // 
            this.单位名称.DataPropertyName = "单位名称";
            this.单位名称.HeaderText = "单位名称";
            this.单位名称.Name = "单位名称";
            this.单位名称.ReadOnly = true;
            this.单位名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.单位名称.Width = 150;
            // 
            // 开始日期
            // 
            this.开始日期.DataPropertyName = "开始日期";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            this.开始日期.DefaultCellStyle = dataGridViewCellStyle12;
            this.开始日期.HeaderText = "开始日期";
            this.开始日期.Name = "开始日期";
            this.开始日期.ReadOnly = true;
            this.开始日期.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 一般公务用车编制数
            // 
            this.一般公务用车编制数.DataPropertyName = "一般公务用车编制数";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.一般公务用车编制数.DefaultCellStyle = dataGridViewCellStyle13;
            this.一般公务用车编制数.HeaderText = "一般公务用车编制数";
            this.一般公务用车编制数.Name = "一般公务用车编制数";
            this.一般公务用车编制数.ReadOnly = true;
            this.一般公务用车编制数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.一般公务用车编制数.Width = 150;
            // 
            // 一般执法执勤用车编制数
            // 
            this.一般执法执勤用车编制数.DataPropertyName = "一般执法执勤用车编制数";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.一般执法执勤用车编制数.DefaultCellStyle = dataGridViewCellStyle14;
            this.一般执法执勤用车编制数.HeaderText = "一般执法执勤用车编制数";
            this.一般执法执勤用车编制数.Name = "一般执法执勤用车编制数";
            this.一般执法执勤用车编制数.ReadOnly = true;
            this.一般执法执勤用车编制数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.一般执法执勤用车编制数.Width = 150;
            // 
            // 特种专业技术用车编制数
            // 
            this.特种专业技术用车编制数.DataPropertyName = "特种专业技术用车编制数";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.特种专业技术用车编制数.DefaultCellStyle = dataGridViewCellStyle15;
            this.特种专业技术用车编制数.HeaderText = "特种专业技术用车编制数";
            this.特种专业技术用车编制数.Name = "特种专业技术用车编制数";
            this.特种专业技术用车编制数.ReadOnly = true;
            this.特种专业技术用车编制数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.特种专业技术用车编制数.Width = 150;
            // 
            // 是否审核
            // 
            this.是否审核.DataPropertyName = "是否审核";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.是否审核.DefaultCellStyle = dataGridViewCellStyle16;
            this.是否审核.HeaderText = "是否审核";
            this.是否审核.Name = "是否审核";
            this.是否审核.ReadOnly = true;
            this.是否审核.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 审核人
            // 
            this.审核人.DataPropertyName = "审核人";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.审核人.DefaultCellStyle = dataGridViewCellStyle17;
            this.审核人.HeaderText = "审核人";
            this.审核人.Name = "审核人";
            this.审核人.ReadOnly = true;
            this.审核人.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 审核时间
            // 
            this.审核时间.DataPropertyName = "审核时间";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "d";
            dataGridViewCellStyle18.NullValue = null;
            this.审核时间.DefaultCellStyle = dataGridViewCellStyle18;
            this.审核时间.HeaderText = "审核时间";
            this.审核时间.Name = "审核时间";
            this.审核时间.ReadOnly = true;
            this.审核时间.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btn审批
            // 
            this.btn审批.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn审批.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn审批.Location = new System.Drawing.Point(300, 0);
            this.btn审批.Name = "btn审批";
            this.btn审批.Size = new System.Drawing.Size(75, 28);
            this.btn审批.TabIndex = 13;
            this.btn审批.Text = "审批(&P)";
            this.btn审批.UseVisualStyleBackColor = true;
            this.btn审批.Click += new System.EventHandler(this.btn审批_Click);
            // 
            // FZB_公车编制数
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 528);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.lbl公车编制数配置列表);
            this.Controls.Add(this.pnlTool);
            this.Name = "FZB_公车编制数";
            this.Text = "FZB_公车编制数";
            this.pnlTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Button btn查看;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.Button btn导出;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Label lbl公车编制数配置列表;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开始日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 一般公务用车编制数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 一般执法执勤用车编制数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 特种专业技术用车编制数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否审核;
        private System.Windows.Forms.DataGridViewTextBoxColumn 审核人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 审核时间;
        private System.Windows.Forms.Button btn审批;
    }
}