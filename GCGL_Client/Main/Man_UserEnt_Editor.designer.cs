namespace GCGL_Client.Main
{
    partial class Man_UserEnt_Editor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb启用 = new System.Windows.Forms.RadioButton();
            this.rb不启用 = new System.Windows.Forms.RadioButton();
            this.cbx被委托人 = new System.Windows.Forms.ComboBox();
            this.btn确定 = new System.Windows.Forms.Button();
            this.btn取消 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "被委托人：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "是否启用：";
            // 
            // rb启用
            // 
            this.rb启用.AutoSize = true;
            this.rb启用.Location = new System.Drawing.Point(115, 65);
            this.rb启用.Name = "rb启用";
            this.rb启用.Size = new System.Drawing.Size(47, 16);
            this.rb启用.TabIndex = 3;
            this.rb启用.TabStop = true;
            this.rb启用.Text = "启用";
            this.rb启用.UseVisualStyleBackColor = true;
             // 
            // rb不启用
            // 
            this.rb不启用.AutoSize = true;
            this.rb不启用.Location = new System.Drawing.Point(183, 65);
            this.rb不启用.Name = "rb不启用";
            this.rb不启用.Size = new System.Drawing.Size(59, 16);
            this.rb不启用.TabIndex = 4;
            this.rb不启用.TabStop = true;
            this.rb不启用.Text = "不启用";
            this.rb不启用.UseVisualStyleBackColor = true;
              // 
            // cbx被委托人
            // 
            this.cbx被委托人.FormattingEnabled = true;
            this.cbx被委托人.Location = new System.Drawing.Point(115, 28);
            this.cbx被委托人.Name = "cbx被委托人";
            this.cbx被委托人.Size = new System.Drawing.Size(121, 20);
            this.cbx被委托人.TabIndex = 5;
            // 
            // btn确定
            // 
            this.btn确定.Location = new System.Drawing.Point(156, 106);
            this.btn确定.Name = "btn确定";
            this.btn确定.Size = new System.Drawing.Size(93, 28);
            this.btn确定.TabIndex = 501;
            this.btn确定.Text = "确定(Ctrl+S)";
            this.btn确定.UseVisualStyleBackColor = true;
            this.btn确定.Click += new System.EventHandler(this.btn确定_Click);
            // 
            // btn取消
            // 
            this.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn取消.Location = new System.Drawing.Point(40, 106);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(93, 28);
            this.btn取消.TabIndex = 502;
            this.btn取消.Text = "取消(Esc)";
            this.btn取消.UseVisualStyleBackColor = true;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // Man_UserEnt_Editor
            // 
            this.AcceptButton = this.btn取消;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 156);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.btn确定);
            this.Controls.Add(this.cbx被委托人);
            this.Controls.Add(this.rb不启用);
            this.Controls.Add(this.rb启用);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Man_UserEnt_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "委托";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Man_UserEnt_Editor_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb启用;
        private System.Windows.Forms.RadioButton rb不启用;
        private System.Windows.Forms.ComboBox cbx被委托人;
        private System.Windows.Forms.Button btn确定;
        private System.Windows.Forms.Button btn取消;
    }
}