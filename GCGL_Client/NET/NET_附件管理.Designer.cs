namespace GCGL_Client.NET
{
    partial class NET_附件管理
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSelDir = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.文件名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.路径 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.文件大小 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进度 = new GCGL_Client.NET.DataGridViewProgressColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridViewProgressColumn1 = new GCGL_Client.NET.DataGridViewProgressColumn();
            this.pnlDownPath = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlDownPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemoveFile);
            this.panel1.Controls.Add(this.btnChooseFile);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnSendFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 49);
            this.panel1.TabIndex = 14;
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(131, 10);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(90, 28);
            this.btnRemoveFile.TabIndex = 23;
            this.btnRemoveFile.Text = "移除文件";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(12, 10);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(113, 28);
            this.btnChooseFile.TabIndex = 21;
            this.btnChooseFile.Text = "选择要上传的文件";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnOK.Location = new System.Drawing.Point(472, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 28);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "确定(&P)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendFile.ForeColor = System.Drawing.Color.Blue;
            this.btnSendFile.Location = new System.Drawing.Point(375, 10);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(90, 28);
            this.btnSendFile.TabIndex = 15;
            this.btnSendFile.Text = "上传下载";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnSelDir
            // 
            this.btnSelDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelDir.Location = new System.Drawing.Point(472, 11);
            this.btnSelDir.Name = "btnSelDir";
            this.btnSelDir.Size = new System.Drawing.Size(90, 23);
            this.btnSelDir.TabIndex = 20;
            this.btnSelDir.Text = "选择目录";
            this.btnSelDir.UseVisualStyleBackColor = true;
            this.btnSelDir.Click += new System.EventHandler(this.btnSelDir_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavePath.ForeColor = System.Drawing.Color.Blue;
            this.txtSavePath.Location = new System.Drawing.Point(91, 12);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(374, 21);
            this.txtSavePath.TabIndex = 19;
            this.txtSavePath.Text = "D:\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "下载时保存到：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.文件名称,
            this.路径,
            this.文件大小,
            this.进度,
            this.状态,
            this.操作});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(575, 285);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "序号";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Visible = false;
            this.序号.Width = 40;
            // 
            // 文件名称
            // 
            this.文件名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.文件名称.DataPropertyName = "文件名称";
            this.文件名称.HeaderText = "文件名称";
            this.文件名称.MinimumWidth = 100;
            this.文件名称.Name = "文件名称";
            this.文件名称.ReadOnly = true;
            this.文件名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 路径
            // 
            this.路径.DataPropertyName = "路径";
            this.路径.HeaderText = "路径";
            this.路径.Name = "路径";
            this.路径.ReadOnly = true;
            this.路径.Visible = false;
            // 
            // 文件大小
            // 
            this.文件大小.DataPropertyName = "文件大小";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.文件大小.DefaultCellStyle = dataGridViewCellStyle1;
            this.文件大小.HeaderText = "大小";
            this.文件大小.Name = "文件大小";
            this.文件大小.ReadOnly = true;
            this.文件大小.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 进度
            // 
            this.进度.DataPropertyName = "进度";
            this.进度.HeaderText = "进度";
            this.进度.Name = "进度";
            this.进度.ReadOnly = true;
            // 
            // 状态
            // 
            this.状态.DataPropertyName = "状态";
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            this.状态.ReadOnly = true;
            this.状态.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.状态.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 操作
            // 
            this.操作.DataPropertyName = "操作";
            this.操作.HeaderText = "操作";
            this.操作.Name = "操作";
            this.操作.ReadOnly = true;
            this.操作.Text = "下载";
            this.操作.Visible = false;
            // 
            // dataGridViewProgressColumn1
            // 
            this.dataGridViewProgressColumn1.DataPropertyName = "进度";
            this.dataGridViewProgressColumn1.HeaderText = "进度";
            this.dataGridViewProgressColumn1.Name = "dataGridViewProgressColumn1";
            // 
            // pnlDownPath
            // 
            this.pnlDownPath.Controls.Add(this.txtSavePath);
            this.pnlDownPath.Controls.Add(this.label3);
            this.pnlDownPath.Controls.Add(this.btnSelDir);
            this.pnlDownPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDownPath.Location = new System.Drawing.Point(0, 49);
            this.pnlDownPath.Name = "pnlDownPath";
            this.pnlDownPath.Size = new System.Drawing.Size(575, 46);
            this.pnlDownPath.TabIndex = 16;
            // 
            // NET_附件管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 380);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlDownPath);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NET_附件管理";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "附件管理";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlDownPath.ResumeLayout(false);
            this.pnlDownPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnSelDir;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label label3;
        private DataGridViewProgressColumn dataGridViewProgressColumn1;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Panel pnlDownPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 文件名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 路径;
        private System.Windows.Forms.DataGridViewTextBoxColumn 文件大小;
        private DataGridViewProgressColumn 进度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private System.Windows.Forms.DataGridViewButtonColumn 操作;

    }
}