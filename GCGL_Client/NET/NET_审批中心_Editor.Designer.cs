namespace GCGL_Client.NET
{
    partial class OCC_网上审批_Editor
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
            this.txtexOpinion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn提交 = new System.Windows.Forms.Button();
            this.btn取消 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbn同意 = new System.Windows.Forms.RadioButton();
            this.rbn不同意 = new System.Windows.Forms.RadioButton();
            this.cbx返回到 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt单位名称 = new System.Windows.Forms.TextBox();
            this.txt审批流程 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn查阅申请 = new System.Windows.Forms.Button();
            this.btn查阅流程 = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtexOpinion
            // 
            this.txtexOpinion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtexOpinion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtexOpinion.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtexOpinion.ForeColor = System.Drawing.Color.Blue;
            this.txtexOpinion.Location = new System.Drawing.Point(22, 126);
            this.txtexOpinion.Multiline = true;
            this.txtexOpinion.Name = "txtexOpinion";
            this.txtexOpinion.Size = new System.Drawing.Size(502, 163);
            this.txtexOpinion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "审批意见：";
            // 
            // btn提交
            // 
            this.btn提交.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn提交.Location = new System.Drawing.Point(294, 345);
            this.btn提交.Name = "btn提交";
            this.btn提交.Size = new System.Drawing.Size(95, 28);
            this.btn提交.TabIndex = 3;
            this.btn提交.Text = "提交(Ctrl+T)";
            this.btn提交.UseVisualStyleBackColor = true;
            this.btn提交.Click += new System.EventHandler(this.btn提交_Click);
            // 
            // btn取消
            // 
            this.btn取消.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn取消.Location = new System.Drawing.Point(156, 345);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(95, 28);
            this.btn取消.TabIndex = 4;
            this.btn取消.Text = "取消(ESC)";
            this.btn取消.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "审批决定：";
            // 
            // rbn同意
            // 
            this.rbn同意.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbn同意.AutoSize = true;
            this.rbn同意.Checked = true;
            this.rbn同意.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbn同意.ForeColor = System.Drawing.Color.Green;
            this.rbn同意.Location = new System.Drawing.Point(87, 298);
            this.rbn同意.Name = "rbn同意";
            this.rbn同意.Size = new System.Drawing.Size(69, 24);
            this.rbn同意.TabIndex = 7;
            this.rbn同意.TabStop = true;
            this.rbn同意.Text = "同意";
            this.rbn同意.UseVisualStyleBackColor = true;
            // 
            // rbn不同意
            // 
            this.rbn不同意.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbn不同意.AutoSize = true;
            this.rbn不同意.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbn不同意.ForeColor = System.Drawing.Color.Red;
            this.rbn不同意.Location = new System.Drawing.Point(168, 298);
            this.rbn不同意.Name = "rbn不同意";
            this.rbn不同意.Size = new System.Drawing.Size(127, 24);
            this.rbn不同意.TabIndex = 8;
            this.rbn不同意.Text = "不同意，并";
            this.rbn不同意.UseVisualStyleBackColor = true;
            this.rbn不同意.CheckedChanged += new System.EventHandler(this.rbn不同意_CheckedChanged);
            // 
            // cbx返回到
            // 
            this.cbx返回到.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx返回到.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx返回到.Enabled = false;
            this.cbx返回到.ForeColor = System.Drawing.Color.Red;
            this.cbx返回到.FormattingEnabled = true;
            this.cbx返回到.Items.AddRange(new object[] {
            "返回到上一步",
            "返回给申请单位"});
            this.cbx返回到.Location = new System.Drawing.Point(291, 300);
            this.cbx返回到.Name = "cbx返回到";
            this.cbx返回到.Size = new System.Drawing.Size(233, 20);
            this.cbx返回到.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "申请单位：";
            // 
            // txt单位名称
            // 
            this.txt单位名称.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt单位名称.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt单位名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt单位名称.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt单位名称.ForeColor = System.Drawing.Color.Black;
            this.txt单位名称.Location = new System.Drawing.Point(82, 13);
            this.txt单位名称.Name = "txt单位名称";
            this.txt单位名称.ReadOnly = true;
            this.txt单位名称.Size = new System.Drawing.Size(442, 24);
            this.txt单位名称.TabIndex = 529;
            // 
            // txt审批流程
            // 
            this.txt审批流程.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt审批流程.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt审批流程.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt审批流程.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt审批流程.ForeColor = System.Drawing.Color.Black;
            this.txt审批流程.Location = new System.Drawing.Point(82, 40);
            this.txt审批流程.Name = "txt审批流程";
            this.txt审批流程.ReadOnly = true;
            this.txt审批流程.Size = new System.Drawing.Size(442, 24);
            this.txt审批流程.TabIndex = 531;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 530;
            this.label4.Text = "审批流程：";
            // 
            // btn查阅申请
            // 
            this.btn查阅申请.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn查阅申请.Location = new System.Drawing.Point(302, 69);
            this.btn查阅申请.Name = "btn查阅申请";
            this.btn查阅申请.Size = new System.Drawing.Size(108, 28);
            this.btn查阅申请.TabIndex = 532;
            this.btn查阅申请.Text = "查阅原申请单(&S)";
            this.btn查阅申请.UseVisualStyleBackColor = true;
            this.btn查阅申请.Click += new System.EventHandler(this.btn查阅申请_Click);
            // 
            // btn查阅流程
            // 
            this.btn查阅流程.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn查阅流程.Location = new System.Drawing.Point(416, 69);
            this.btn查阅流程.Name = "btn查阅流程";
            this.btn查阅流程.Size = new System.Drawing.Size(108, 28);
            this.btn查阅流程.TabIndex = 533;
            this.btn查阅流程.Text = "查阅审批流程(&F)";
            this.btn查阅流程.UseVisualStyleBackColor = true;
            this.btn查阅流程.Click += new System.EventHandler(this.btn查阅流程_Click);
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label36.Location = new System.Drawing.Point(6, 335);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(531, 2);
            this.label36.TabIndex = 534;
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OCC_网上审批_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn取消;
            this.ClientSize = new System.Drawing.Size(544, 384);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.btn查阅流程);
            this.Controls.Add(this.btn查阅申请);
            this.Controls.Add(this.txt审批流程);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt单位名称);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx返回到);
            this.Controls.Add(this.rbn不同意);
            this.Controls.Add(this.rbn同意);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.btn提交);
            this.Controls.Add(this.txtexOpinion);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "OCC_网上审批_Editor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "审批";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtexOpinion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn提交;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbn同意;
        private System.Windows.Forms.RadioButton rbn不同意;
        private System.Windows.Forms.ComboBox cbx返回到;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt单位名称;
        private System.Windows.Forms.TextBox txt审批流程;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn查阅申请;
        private System.Windows.Forms.Button btn查阅流程;
        private System.Windows.Forms.Label label36;
    }
}