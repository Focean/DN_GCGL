namespace GCGL_Client.NET
{
    partial class NET_审批中心_Flow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.exIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exOpinion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exOpinionFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exOpinionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.执行人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeight = 30;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exIndex,
            this.exOpinion,
            this.exOpinionFlag,
            this.exOpinionTime,
            this.执行人,
            this.CreateTime});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(797, 446);
            this.dgvList.TabIndex = 7;
            // 
            // exIndex
            // 
            this.exIndex.DataPropertyName = "exIndex";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.exIndex.DefaultCellStyle = dataGridViewCellStyle2;
            this.exIndex.HeaderText = "序号";
            this.exIndex.Name = "exIndex";
            this.exIndex.ReadOnly = true;
            this.exIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.exIndex.Width = 45;
            // 
            // exOpinion
            // 
            this.exOpinion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.exOpinion.DataPropertyName = "exOpinion";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exOpinion.DefaultCellStyle = dataGridViewCellStyle3;
            this.exOpinion.HeaderText = "意见";
            this.exOpinion.Name = "exOpinion";
            this.exOpinion.ReadOnly = true;
            this.exOpinion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // exOpinionFlag
            // 
            this.exOpinionFlag.DataPropertyName = "exOpinionFlag";
            this.exOpinionFlag.HeaderText = "审批决定";
            this.exOpinionFlag.Name = "exOpinionFlag";
            this.exOpinionFlag.ReadOnly = true;
            this.exOpinionFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // exOpinionTime
            // 
            this.exOpinionTime.DataPropertyName = "exOpinionTime";
            dataGridViewCellStyle4.Format = "g";
            this.exOpinionTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.exOpinionTime.HeaderText = "审批时间";
            this.exOpinionTime.Name = "exOpinionTime";
            this.exOpinionTime.ReadOnly = true;
            this.exOpinionTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.exOpinionTime.Width = 110;
            // 
            // 执行人
            // 
            this.执行人.DataPropertyName = "执行人";
            this.执行人.HeaderText = "审批人";
            this.执行人.Name = "执行人";
            this.执行人.ReadOnly = true;
            this.执行人.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.执行人.Width = 60;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            dataGridViewCellStyle5.Format = "g";
            this.CreateTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CreateTime.Width = 110;
            // 
            // NET_审批中心_Flow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 446);
            this.Controls.Add(this.dgvList);
            this.MinimizeBox = false;
            this.Name = "NET_审批中心_Flow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看审批流程";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn exIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn exOpinion;
        private System.Windows.Forms.DataGridViewTextBoxColumn exOpinionFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn exOpinionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn 执行人;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
    }
}