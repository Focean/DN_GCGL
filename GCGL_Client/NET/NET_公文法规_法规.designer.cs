﻿namespace GCGL_Client.NET
{
    partial class NET_公文法规_法规
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
            this.txt公文内容 = new System.Windows.Forms.TextBox();
            this.txt公文标题 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn附件查看 = new System.Windows.Forms.Button();
            this.txt附件信息 = new System.Windows.Forms.TextBox();
            this.btn附件管理 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt公文内容
            // 
            this.txt公文内容.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt公文内容.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt公文内容.ForeColor = System.Drawing.Color.Blue;
            this.txt公文内容.Location = new System.Drawing.Point(7, 62);
            this.txt公文内容.Multiline = true;
            this.txt公文内容.Name = "txt公文内容";
            this.txt公文内容.Size = new System.Drawing.Size(703, 383);
            this.txt公文内容.TabIndex = 3;
            // 
            // txt公文标题
            // 
            this.txt公文标题.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt公文标题.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt公文标题.ForeColor = System.Drawing.Color.Blue;
            this.txt公文标题.Location = new System.Drawing.Point(6, 8);
            this.txt公文标题.Name = "txt公文标题";
            this.txt公文标题.Size = new System.Drawing.Size(705, 46);
            this.txt公文标题.TabIndex = 2;
            this.txt公文标题.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Location = new System.Drawing.Point(358, 512);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 28);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "确定(Ctrl+D)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(212, 512);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 28);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消(ESC)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn附件查看
            // 
            this.btn附件查看.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn附件查看.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn附件查看.Location = new System.Drawing.Point(628, 464);
            this.btn附件查看.Name = "btn附件查看";
            this.btn附件查看.Size = new System.Drawing.Size(76, 23);
            this.btn附件查看.TabIndex = 240;
            this.btn附件查看.Text = "附件查看(&W)";
            this.btn附件查看.UseVisualStyleBackColor = true;
            this.btn附件查看.Click += new System.EventHandler(this.btn附件查看_Click);
            // 
            // txt附件信息
            // 
            this.txt附件信息.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt附件信息.BackColor = System.Drawing.Color.White;
            this.txt附件信息.ForeColor = System.Drawing.Color.Blue;
            this.txt附件信息.Location = new System.Drawing.Point(40, 464);
            this.txt附件信息.Name = "txt附件信息";
            this.txt附件信息.ReadOnly = true;
            this.txt附件信息.Size = new System.Drawing.Size(506, 21);
            this.txt附件信息.TabIndex = 239;
            // 
            // btn附件管理
            // 
            this.btn附件管理.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn附件管理.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn附件管理.Location = new System.Drawing.Point(552, 464);
            this.btn附件管理.Name = "btn附件管理";
            this.btn附件管理.Size = new System.Drawing.Size(69, 23);
            this.btn附件管理.TabIndex = 238;
            this.btn附件管理.Text = "附件管理(&F)";
            this.btn附件管理.UseVisualStyleBackColor = true;
            this.btn附件管理.Click += new System.EventHandler(this.btn附件管理_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 237;
            this.label1.Text = "附件：";
            // 
            // NET_公文法规_法规
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 551);
            this.Controls.Add(this.btn附件查看);
            this.Controls.Add(this.txt附件信息);
            this.Controls.Add(this.btn附件管理);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txt公文内容);
            this.Controls.Add(this.txt公文标题);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NET_公文法规_法规";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt公文内容;
        private System.Windows.Forms.TextBox txt公文标题;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btn附件查看;
        private System.Windows.Forms.TextBox txt附件信息;
        private System.Windows.Forms.Button btn附件管理;
        private System.Windows.Forms.Label label1;
    }
}