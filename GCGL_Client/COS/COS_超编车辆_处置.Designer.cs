namespace GCGL_Client.COS
{
    partial class COS_超编车辆_处置
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
            this.btn确定 = new System.Windows.Forms.Button();
            this.btn取消 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx超编状态 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt备注 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn确定
            // 
            this.btn确定.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn确定.Location = new System.Drawing.Point(242, 169);
            this.btn确定.Name = "btn确定";
            this.btn确定.Size = new System.Drawing.Size(110, 28);
            this.btn确定.TabIndex = 277;
            this.btn确定.Text = "提交(Ctrl+J)";
            this.btn确定.UseVisualStyleBackColor = true;
            this.btn确定.Click += new System.EventHandler(this.btn确定_Click);
            // 
            // btn取消
            // 
            this.btn取消.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn取消.Location = new System.Drawing.Point(90, 169);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(110, 28);
            this.btn取消.TabIndex = 276;
            this.btn取消.Text = "取消(&ESC)";
            this.btn取消.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 278;
            this.label1.Text = "处置情况：";
            // 
            // cbx超编状态
            // 
            this.cbx超编状态.FormattingEnabled = true;
            this.cbx超编状态.Items.AddRange(new object[] {
            "已出售"});
            this.cbx超编状态.Location = new System.Drawing.Point(76, 26);
            this.cbx超编状态.Name = "cbx超编状态";
            this.cbx超编状态.Size = new System.Drawing.Size(311, 20);
            this.cbx超编状态.TabIndex = 279;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 280;
            this.label2.Text = "备注：";
            // 
            // txt备注
            // 
            this.txt备注.Location = new System.Drawing.Point(76, 70);
            this.txt备注.Multiline = true;
            this.txt备注.Name = "txt备注";
            this.txt备注.Size = new System.Drawing.Size(311, 68);
            this.txt备注.TabIndex = 281;
            // 
            // COS_超编车辆_处置
            // 
            this.AcceptButton = this.btn取消;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 209);
            this.Controls.Add(this.txt备注);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx超编状态);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn确定);
            this.Controls.Add(this.btn取消);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "COS_超编车辆_处置";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "COS_超编车辆_处置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn确定;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx超编状态;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt备注;
    }
}