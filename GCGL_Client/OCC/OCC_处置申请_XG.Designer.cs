namespace GCGL_Client.OCC
{
    partial class OCC_处置申请_XG
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl申请处置形式 = new System.Windows.Forms.Label();
            this.cbx处置形式 = new System.Windows.Forms.ComboBox();
            this.btn取消 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "申报的处置形式：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "审核后的处置形式：";
            // 
            // lbl申请处置形式
            // 
            this.lbl申请处置形式.AutoSize = true;
            this.lbl申请处置形式.Location = new System.Drawing.Point(134, 21);
            this.lbl申请处置形式.Name = "lbl申请处置形式";
            this.lbl申请处置形式.Size = new System.Drawing.Size(41, 12);
            this.lbl申请处置形式.TabIndex = 2;
            this.lbl申请处置形式.Text = "label3";
            // 
            // cbx处置形式
            // 
            this.cbx处置形式.FormattingEnabled = true;
            this.cbx处置形式.Location = new System.Drawing.Point(123, 61);
            this.cbx处置形式.Name = "cbx处置形式";
            this.cbx处置形式.Size = new System.Drawing.Size(163, 20);
            this.cbx处置形式.TabIndex = 3;
            // 
            // btn取消
            // 
            this.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn取消.Location = new System.Drawing.Point(58, 111);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(101, 28);
            this.btn取消.TabIndex = 4;
            this.btn取消.Text = "取消";
            this.btn取消.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(180, 111);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(101, 28);
            this.btn.TabIndex = 5;
            this.btn.Text = "确定";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // OCC_处置申请_XG
            // 
            this.AcceptButton = this.btn取消;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 164);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.cbx处置形式);
            this.Controls.Add(this.lbl申请处置形式);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(347, 191);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(347, 191);
            this.Name = "OCC_处置申请_XG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OCC_处置申请_XG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl申请处置形式;
        private System.Windows.Forms.ComboBox cbx处置形式;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Button btn;
    }
}