﻿namespace GCGL_Client.FZB
{
    partial class BZ_处置形式_Editor
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
            this.btn取消 = new System.Windows.Forms.Button();
            this.btn提交 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt处置形式名称 = new System.Windows.Forms.TextBox();
            this.txt处置形式编码 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn取消
            // 
            this.btn取消.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn取消.Location = new System.Drawing.Point(104, 138);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(80, 28);
            this.btn取消.TabIndex = 47;
            this.btn取消.Text = "取消";
            this.btn取消.UseVisualStyleBackColor = true;
            // 
            // btn提交
            // 
            this.btn提交.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn提交.Location = new System.Drawing.Point(221, 138);
            this.btn提交.Name = "btn提交";
            this.btn提交.Size = new System.Drawing.Size(80, 28);
            this.btn提交.TabIndex = 46;
            this.btn提交.Text = "提交";
            this.btn提交.UseVisualStyleBackColor = true;
            this.btn提交.Click += new System.EventHandler(this.btn提交_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(12, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(377, 2);
            this.label11.TabIndex = 48;
            this.label11.Text = "label11";
            // 
            // txt处置形式名称
            // 
            this.txt处置形式名称.Location = new System.Drawing.Point(104, 70);
            this.txt处置形式名称.Name = "txt处置形式名称";
            this.txt处置形式名称.Size = new System.Drawing.Size(263, 21);
            this.txt处置形式名称.TabIndex = 45;
            // 
            // txt处置形式编码
            // 
            this.txt处置形式编码.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt处置形式编码.Location = new System.Drawing.Point(104, 16);
            this.txt处置形式编码.Name = "txt处置形式编码";
            this.txt处置形式编码.Size = new System.Drawing.Size(263, 21);
            this.txt处置形式编码.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 43;
            this.label2.Text = "处置形式名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "处置形式编码：";
            // 
            // BZ_处置形式_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 182);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.btn提交);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt处置形式名称);
            this.Controls.Add(this.txt处置形式编码);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(416, 221);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(416, 221);
            this.Name = "BZ_处置形式_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BZ_处置形式_Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Button btn提交;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt处置形式名称;
        private System.Windows.Forms.TextBox txt处置形式编码;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}