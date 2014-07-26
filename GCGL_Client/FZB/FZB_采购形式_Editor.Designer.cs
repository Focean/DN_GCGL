namespace GCGL_Client.FZB
{
    partial class FZB_采购形式_Editor
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
            this.txt采购形式名称 = new System.Windows.Forms.TextBox();
            this.txt采购形式编码 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn取消
            // 
            this.btn取消.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn取消.Location = new System.Drawing.Point(87, 149);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(92, 28);
            this.btn取消.TabIndex = 3;
            this.btn取消.Text = "取消(ESC)";
            this.btn取消.UseVisualStyleBackColor = true;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // btn提交
            // 
            this.btn提交.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn提交.Location = new System.Drawing.Point(228, 151);
            this.btn提交.Name = "btn提交";
            this.btn提交.Size = new System.Drawing.Size(92, 28);
            this.btn提交.TabIndex = 4;
            this.btn提交.Text = "提交(Ctrl+S)";
            this.btn提交.UseVisualStyleBackColor = true;
            this.btn提交.Click += new System.EventHandler(this.btn提交_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(16, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(377, 2);
            this.label11.TabIndex = 41;
            this.label11.Text = "label11";
            // 
            // txt采购形式名称
            // 
            this.txt采购形式名称.Location = new System.Drawing.Point(115, 76);
            this.txt采购形式名称.Name = "txt采购形式名称";
            this.txt采购形式名称.Size = new System.Drawing.Size(263, 21);
            this.txt采购形式名称.TabIndex = 2;
            // 
            // txt采购形式编码
            // 
            this.txt采购形式编码.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt采购形式编码.Location = new System.Drawing.Point(115, 22);
            this.txt采购形式编码.Name = "txt采购形式编码";
            this.txt采购形式编码.Size = new System.Drawing.Size(263, 21);
            this.txt采购形式编码.TabIndex = 1;
            this.txt采购形式编码.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt采购形式编码_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "采购形式名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "采购形式编码：";
            // 
            // FZB_采购形式_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 194);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.btn提交);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt采购形式名称);
            this.Controls.Add(this.txt采购形式编码);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(416, 221);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(416, 221);
            this.Name = "FZB_采购形式_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FZB_采购形式_Editor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FZB_采购形式_Editor_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Button btn提交;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt采购形式名称;
        private System.Windows.Forms.TextBox txt采购形式编码;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}