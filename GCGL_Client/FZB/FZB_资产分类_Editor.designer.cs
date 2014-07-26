namespace GCGL_Client.FZB
{
    partial class FZB_资产分类_Editor
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
            this.cbx车辆类型名称 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clb固定资产类别 = new System.Windows.Forms.CheckedListBox();
            this.btn提交 = new System.Windows.Forms.Button();
            this.btn取消 = new System.Windows.Forms.Button();
            this.lb资产分类列表 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbx固定资产类别 = new System.Windows.Forms.ListBox();
            this.chk清空 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbx车辆类型名称
            // 
            this.cbx车辆类型名称.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx车辆类型名称.FormattingEnabled = true;
            this.cbx车辆类型名称.Location = new System.Drawing.Point(80, 16);
            this.cbx车辆类型名称.Name = "cbx车辆类型名称";
            this.cbx车辆类型名称.Size = new System.Drawing.Size(411, 20);
            this.cbx车辆类型名称.TabIndex = 0;
            this.cbx车辆类型名称.SelectionChangeCommitted += new System.EventHandler(this.cbx车辆类型名称_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "车辆类型：";
            // 
            // clb固定资产类别
            // 
            this.clb固定资产类别.CheckOnClick = true;
            this.clb固定资产类别.FormattingEnabled = true;
            this.clb固定资产类别.Location = new System.Drawing.Point(11, 75);
            this.clb固定资产类别.Name = "clb固定资产类别";
            this.clb固定资产类别.Size = new System.Drawing.Size(218, 340);
            this.clb固定资产类别.TabIndex = 1;
            this.clb固定资产类别.SelectedIndexChanged += new System.EventHandler(this.clb固定资产类别_SelectedIndexChanged);
            // 
            // btn提交
            // 
            this.btn提交.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn提交.Location = new System.Drawing.Point(381, 430);
            this.btn提交.Name = "btn提交";
            this.btn提交.Size = new System.Drawing.Size(89, 28);
            this.btn提交.TabIndex = 7;
            this.btn提交.Text = "保存(Ctrl+S)";
            this.btn提交.UseVisualStyleBackColor = true;
            this.btn提交.Click += new System.EventHandler(this.btn提交_Click);
            // 
            // btn取消
            // 
            this.btn取消.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn取消.Location = new System.Drawing.Point(282, 430);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(89, 28);
            this.btn取消.TabIndex = 6;
            this.btn取消.Text = "取消(Esc)";
            this.btn取消.UseVisualStyleBackColor = true;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // lb资产分类列表
            // 
            this.lb资产分类列表.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb资产分类列表.AutoSize = true;
            this.lb资产分类列表.ForeColor = System.Drawing.Color.Blue;
            this.lb资产分类列表.Location = new System.Drawing.Point(123, 51);
            this.lb资产分类列表.Name = "lb资产分类列表";
            this.lb资产分类列表.Size = new System.Drawing.Size(257, 12);
            this.lb资产分类列表.TabIndex = 8;
            this.lb资产分类列表.Text = "当前选择的车辆类型包含的固定资产分类列表：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(229, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "==>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbx固定资产类别
            // 
            this.lbx固定资产类别.FormattingEnabled = true;
            this.lbx固定资产类别.ItemHeight = 12;
            this.lbx固定资产类别.Location = new System.Drawing.Point(273, 75);
            this.lbx固定资产类别.Name = "lbx固定资产类别";
            this.lbx固定资产类别.Size = new System.Drawing.Size(218, 340);
            this.lbx固定资产类别.TabIndex = 11;
            // 
            // chk清空
            // 
            this.chk清空.AutoSize = true;
            this.chk清空.Location = new System.Drawing.Point(23, 425);
            this.chk清空.Name = "chk清空";
            this.chk清空.Size = new System.Drawing.Size(48, 16);
            this.chk清空.TabIndex = 12;
            this.chk清空.Text = "清空";
            this.chk清空.UseVisualStyleBackColor = true;
            this.chk清空.CheckedChanged += new System.EventHandler(this.chk清空_CheckedChanged);
            // 
            // FZB_资产分类_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(502, 463);
            this.Controls.Add(this.chk清空);
            this.Controls.Add(this.lbx固定资产类别);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb资产分类列表);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.btn提交);
            this.Controls.Add(this.clb固定资产类别);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx车辆类型名称);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FZB_资产分类_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FZB_资产分类_Editor_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx车辆类型名称;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clb固定资产类别;
        private System.Windows.Forms.Button btn提交;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Label lb资产分类列表;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbx固定资产类别;
        private System.Windows.Forms.CheckBox chk清空;
    }
}