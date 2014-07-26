namespace GCGL_Client.RPT
{
    partial class RPT_查询方案_重命名
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
            this.txt方案名称 = new System.Windows.Forms.TextBox();
            this.btn确定 = new System.Windows.Forms.Button();
            this.btn取消 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt方案名称
            // 
            this.txt方案名称.Location = new System.Drawing.Point(12, 12);
            this.txt方案名称.Name = "txt方案名称";
            this.txt方案名称.Size = new System.Drawing.Size(162, 21);
            this.txt方案名称.TabIndex = 0;
            // 
            // btn确定
            // 
            this.btn确定.Location = new System.Drawing.Point(96, 63);
            this.btn确定.Name = "btn确定";
            this.btn确定.Size = new System.Drawing.Size(65, 23);
            this.btn确定.TabIndex = 1;
            this.btn确定.Text = "确定";
            this.btn确定.UseVisualStyleBackColor = true;
            this.btn确定.Click += new System.EventHandler(this.btn确定_Click);
            // 
            // btn取消
            // 
            this.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn取消.Location = new System.Drawing.Point(15, 63);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(65, 23);
            this.btn取消.TabIndex = 8;
            this.btn取消.Text = "取消";
            this.btn取消.UseVisualStyleBackColor = true;
            // 
            // RPT_查询方案_重命名
            // 
            this.AcceptButton = this.btn取消;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 98);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.btn确定);
            this.Controls.Add(this.txt方案名称);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RPT_查询方案_重命名";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "重命名";
            this.Load += new System.EventHandler(this.RPT_查询方案_重命名_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt方案名称;
        private System.Windows.Forms.Button btn确定;
        private System.Windows.Forms.Button btn取消;
    }
}