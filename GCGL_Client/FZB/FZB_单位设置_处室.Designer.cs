namespace GCGL_Client
{
    partial class FZB_单位_处室_Editor
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txt处室名称 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt单位编码 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk有效 = new System.Windows.Forms.CheckBox();
            this.cbx处室类型 = new System.Windows.Forms.ComboBox();
            this.txt处室编码 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn提交并继续 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(35, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 26);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消(Esc)";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(267, 184);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(97, 26);
            this.btnOK.TabIndex = 4;
            this.btnOK.Tag = "保存";
            this.btnOK.Text = "提交(Ctrl+S)";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txt处室名称
            // 
            this.txt处室名称.BackColor = System.Drawing.Color.White;
            this.txt处室名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt处室名称.ForeColor = System.Drawing.Color.Blue;
            this.txt处室名称.Location = new System.Drawing.Point(133, 90);
            this.txt处室名称.MaxLength = 50;
            this.txt处室名称.Name = "txt处室名称";
            this.txt处室名称.Size = new System.Drawing.Size(205, 21);
            this.txt处室名称.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 184;
            this.label1.Text = "处室名称：";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(9, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(370, 2);
            this.label9.TabIndex = 188;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 191;
            this.label2.Text = "处室类型：";
            // 
            // txt单位编码
            // 
            this.txt单位编码.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt单位编码.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt单位编码.ForeColor = System.Drawing.Color.Blue;
            this.txt单位编码.Location = new System.Drawing.Point(133, 22);
            this.txt单位编码.MaxLength = 50;
            this.txt单位编码.Name = "txt单位编码";
            this.txt单位编码.ReadOnly = true;
            this.txt单位编码.Size = new System.Drawing.Size(205, 21);
            this.txt单位编码.TabIndex = 192;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 193;
            this.label4.Text = "所属单位：";
            // 
            // chk有效
            // 
            this.chk有效.AutoSize = true;
            this.chk有效.Checked = true;
            this.chk有效.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk有效.ForeColor = System.Drawing.Color.Red;
            this.chk有效.Location = new System.Drawing.Point(133, 153);
            this.chk有效.Name = "chk有效";
            this.chk有效.Size = new System.Drawing.Size(48, 16);
            this.chk有效.TabIndex = 3;
            this.chk有效.Text = "有效";
            this.chk有效.UseVisualStyleBackColor = true;
            // 
            // cbx处室类型
            // 
            this.cbx处室类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx处室类型.FormattingEnabled = true;
            this.cbx处室类型.Location = new System.Drawing.Point(133, 124);
            this.cbx处室类型.Name = "cbx处室类型";
            this.cbx处室类型.Size = new System.Drawing.Size(205, 20);
            this.cbx处室类型.TabIndex = 2;
            // 
            // txt处室编码
            // 
            this.txt处室编码.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt处室编码.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt处室编码.ForeColor = System.Drawing.Color.Blue;
            this.txt处室编码.Location = new System.Drawing.Point(133, 57);
            this.txt处室编码.MaxLength = 50;
            this.txt处室编码.Name = "txt处室编码";
            this.txt处室编码.Size = new System.Drawing.Size(205, 21);
            this.txt处室编码.TabIndex = 0;
            this.txt处室编码.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt处室编码_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 196;
            this.label3.Text = "处室编码：";
            // 
            // btn提交并继续
            // 
            this.btn提交并继续.Location = new System.Drawing.Point(139, 184);
            this.btn提交并继续.Name = "btn提交并继续";
            this.btn提交并继续.Size = new System.Drawing.Size(121, 26);
            this.btn提交并继续.TabIndex = 6;
            this.btn提交并继续.Tag = "保存";
            this.btn提交并继续.Text = "提交并继续录入(&N)";
            this.btn提交并继续.UseVisualStyleBackColor = false;
            this.btn提交并继续.Click += new System.EventHandler(this.btn提交并继续_Click);
            // 
            // FZB_单位_处室_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 234);
            this.Controls.Add(this.btn提交并继续);
            this.Controls.Add(this.txt处室编码);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx处室类型);
            this.Controls.Add(this.chk有效);
            this.Controls.Add(this.txt单位编码);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txt处室名称);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(406, 261);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(406, 261);
            this.Name = "FZB_单位_处室_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "单位处室编辑";
            this.Load += new System.EventHandler(this.Man_单位_处室_Editor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FZB_单位_处室_Editor_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.TextBox txt处室名称;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt单位编码;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk有效;
        private System.Windows.Forms.ComboBox cbx处室类型;
        public System.Windows.Forms.TextBox txt处室编码;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btn提交并继续;
    }
}