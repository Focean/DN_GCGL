namespace GCGL_Client
{
    partial class Man_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Man_Login));
            this.lblUserCode = new System.Windows.Forms.Label();
            this.lblUserPswd = new System.Windows.Forms.Label();
            this.txtLoginPswd = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblUserCode
            // 
            this.lblUserCode.AutoSize = true;
            this.lblUserCode.BackColor = System.Drawing.SystemColors.Control;
            this.lblUserCode.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserCode.Location = new System.Drawing.Point(321, 245);
            this.lblUserCode.Name = "lblUserCode";
            this.lblUserCode.Size = new System.Drawing.Size(72, 13);
            this.lblUserCode.TabIndex = 0;
            this.lblUserCode.Text = "用户账号：";
            // 
            // lblUserPswd
            // 
            this.lblUserPswd.AutoSize = true;
            this.lblUserPswd.BackColor = System.Drawing.SystemColors.Control;
            this.lblUserPswd.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserPswd.Location = new System.Drawing.Point(321, 284);
            this.lblUserPswd.Name = "lblUserPswd";
            this.lblUserPswd.Size = new System.Drawing.Size(72, 13);
            this.lblUserPswd.TabIndex = 1;
            this.lblUserPswd.Text = "用户密码：";
            // 
            // txtLoginPswd
            // 
            this.txtLoginPswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPswd.ForeColor = System.Drawing.Color.Blue;
            this.txtLoginPswd.Location = new System.Drawing.Point(388, 280);
            this.txtLoginPswd.Name = "txtLoginPswd";
            this.txtLoginPswd.PasswordChar = '*';
            this.txtLoginPswd.Size = new System.Drawing.Size(132, 21);
            this.txtLoginPswd.TabIndex = 1;
            this.txtLoginPswd.UseSystemPasswordChar = true;
            this.txtLoginPswd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginPswd_KeyPress);
            // 
            // txtLoginName
            // 
            this.txtLoginName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginName.ForeColor = System.Drawing.Color.Blue;
            this.txtLoginName.Location = new System.Drawing.Point(388, 241);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(132, 21);
            this.txtLoginName.TabIndex = 0;
            this.txtLoginName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginName_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnLogin.Location = new System.Drawing.Point(331, 360);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(188, 28);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登    录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(620, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.BackColor = System.Drawing.SystemColors.Control;
            this.chkRemember.Location = new System.Drawing.Point(388, 316);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(138, 16);
            this.chkRemember.TabIndex = 2;
            this.chkRemember.Text = "记住我的登录密码(&J)";
            this.chkRemember.UseVisualStyleBackColor = false;
            // 
            // Man_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(644, 423);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.txtLoginPswd);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblUserPswd);
            this.Controls.Add(this.lblUserCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Man_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.TfmMan_Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Man_Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Man_Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Man_Login_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserCode;
        private System.Windows.Forms.Label lblUserPswd;
        private System.Windows.Forms.TextBox txtLoginPswd;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkRemember;
    }
}