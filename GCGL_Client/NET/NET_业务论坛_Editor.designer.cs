namespace GCGL_Client.NET
{
    partial class NET_业务论坛_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NET_业务论坛_Editor));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn取消 = new System.Windows.Forms.Button();
            this.btn提交 = new System.Windows.Forms.Button();
            this.btn清空 = new System.Windows.Forms.Button();
            this.btn发帖 = new System.Windows.Forms.Button();
            this.pnl菜单栏 = new System.Windows.Forms.Panel();
            this.dN_HtmlEditor1 = new DN_HtmlEditor.DN_HtmlEditor();
            this.pnl菜单栏.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Top;
            this.webBrowser1.Location = new System.Drawing.Point(0, 1);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1090, 473);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.MenuText;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1090, 1);
            this.label3.TabIndex = 52;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InfoText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1090, 1);
            this.label1.TabIndex = 50;
            this.label1.Visible = false;
            // 
            // btn取消
            // 
            this.btn取消.BackColor = System.Drawing.Color.LightPink;
            this.btn取消.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn取消.ForeColor = System.Drawing.Color.Blue;
            this.btn取消.Location = new System.Drawing.Point(910, 0);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(90, 30);
            this.btn取消.TabIndex = 54;
            this.btn取消.Text = "返回(ESC)";
            this.btn取消.UseVisualStyleBackColor = false;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // btn提交
            // 
            this.btn提交.BackColor = System.Drawing.Color.LightPink;
            this.btn提交.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn提交.Location = new System.Drawing.Point(90, 0);
            this.btn提交.Name = "btn提交";
            this.btn提交.Size = new System.Drawing.Size(90, 30);
            this.btn提交.TabIndex = 56;
            this.btn提交.Text = "发表(&P)";
            this.btn提交.UseVisualStyleBackColor = false;
            this.btn提交.Click += new System.EventHandler(this.btn提交_Click);
            // 
            // btn清空
            // 
            this.btn清空.BackColor = System.Drawing.Color.LightPink;
            this.btn清空.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn清空.Location = new System.Drawing.Point(1000, 0);
            this.btn清空.Name = "btn清空";
            this.btn清空.Size = new System.Drawing.Size(90, 30);
            this.btn清空.TabIndex = 60;
            this.btn清空.Text = "清空(&D)";
            this.btn清空.UseVisualStyleBackColor = false;
            this.btn清空.Click += new System.EventHandler(this.btn清空_Click);
            // 
            // btn发帖
            // 
            this.btn发帖.BackColor = System.Drawing.Color.LightPink;
            this.btn发帖.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn发帖.ForeColor = System.Drawing.Color.Blue;
            this.btn发帖.Location = new System.Drawing.Point(0, 0);
            this.btn发帖.Name = "btn发帖";
            this.btn发帖.Size = new System.Drawing.Size(90, 30);
            this.btn发帖.TabIndex = 59;
            this.btn发帖.Text = "回贴(&A)";
            this.btn发帖.UseVisualStyleBackColor = false;
            this.btn发帖.Click += new System.EventHandler(this.btn回贴_Click);
            // 
            // pnl菜单栏
            // 
            this.pnl菜单栏.Controls.Add(this.btn取消);
            this.pnl菜单栏.Controls.Add(this.btn清空);
            this.pnl菜单栏.Controls.Add(this.btn提交);
            this.pnl菜单栏.Controls.Add(this.btn发帖);
            this.pnl菜单栏.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl菜单栏.Location = new System.Drawing.Point(0, 475);
            this.pnl菜单栏.Name = "pnl菜单栏";
            this.pnl菜单栏.Size = new System.Drawing.Size(1090, 30);
            this.pnl菜单栏.TabIndex = 62;
            // 
            // dN_HtmlEditor1
            // 
            this.dN_HtmlEditor1.BodyText = null;
            this.dN_HtmlEditor1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dN_HtmlEditor1.HtmlText = resources.GetString("dN_HtmlEditor1.HtmlText");
            this.dN_HtmlEditor1.Location = new System.Drawing.Point(0, 506);
            this.dN_HtmlEditor1.Name = "dN_HtmlEditor1";
            this.dN_HtmlEditor1.Size = new System.Drawing.Size(1090, 157);
            this.dN_HtmlEditor1.TabIndex = 64;
            // 
            // NET_业务论坛_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1090, 663);
            this.Controls.Add(this.dN_HtmlEditor1);
            this.Controls.Add(this.pnl菜单栏);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NET_业务论坛_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NET_业务论坛_Editor_Load);
            this.pnl菜单栏.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Button btn提交;
        private System.Windows.Forms.Button btn清空;
        private System.Windows.Forms.Button btn发帖;
        private System.Windows.Forms.Panel pnl菜单栏;
        private DN_HtmlEditor.DN_HtmlEditor dN_HtmlEditor1;
    }
}