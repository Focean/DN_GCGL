namespace GCGL_Client.NET
{
    partial class NET_公告通知_通知
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
            this.txt公文标题 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt接收单位 = new System.Windows.Forms.TextBox();
            this.btn接收单位 = new System.Windows.Forms.Button();
            this.dN_HtmlEditor1 = new DN_HtmlEditor.DN_HtmlEditor();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // txt公文标题
            // 
            this.txt公文标题.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt公文标题.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt公文标题.ForeColor = System.Drawing.Color.Blue;
            this.txt公文标题.Location = new System.Drawing.Point(16, 13);
            this.txt公文标题.Name = "txt公文标题";
            this.txt公文标题.Size = new System.Drawing.Size(643, 46);
            this.txt公文标题.TabIndex = 2;
            this.txt公文标题.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Location = new System.Drawing.Point(360, 437);
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
            this.btnCancel.Location = new System.Drawing.Point(214, 437);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 28);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "取消(ESC)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "接收单位：";
            // 
            // txt接收单位
            // 
            this.txt接收单位.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt接收单位.BackColor = System.Drawing.Color.White;
            this.txt接收单位.Location = new System.Drawing.Point(76, 398);
            this.txt接收单位.Name = "txt接收单位";
            this.txt接收单位.ReadOnly = true;
            this.txt接收单位.Size = new System.Drawing.Size(583, 21);
            this.txt接收单位.TabIndex = 19;
            // 
            // btn接收单位
            // 
            this.btn接收单位.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn接收单位.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn接收单位.Location = new System.Drawing.Point(637, 399);
            this.btn接收单位.Name = "btn接收单位";
            this.btn接收单位.Size = new System.Drawing.Size(21, 19);
            this.btn接收单位.TabIndex = 54;
            this.btn接收单位.Text = "…";
            this.btn接收单位.UseVisualStyleBackColor = true;
            this.btn接收单位.Click += new System.EventHandler(this.btn接收单位_Click);
            // 
            // dN_HtmlEditor1
            // 
            this.dN_HtmlEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dN_HtmlEditor1.BodyText = null;
            this.dN_HtmlEditor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dN_HtmlEditor1.HtmlText = "<HTML></HTML>\0";
            this.dN_HtmlEditor1.Location = new System.Drawing.Point(16, 68);
            this.dN_HtmlEditor1.Name = "dN_HtmlEditor1";
            this.dN_HtmlEditor1.Size = new System.Drawing.Size(643, 325);
            this.dN_HtmlEditor1.TabIndex = 55;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(16, 68);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(643, 325);
            this.webBrowser1.TabIndex = 56;
            // 
            // NET_公告通知_通知
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 476);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.dN_HtmlEditor1);
            this.Controls.Add(this.btn接收单位);
            this.Controls.Add(this.txt接收单位);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txt公文标题);
            this.MinimizeBox = false;
            this.Name = "NET_公告通知_通知";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt公文标题;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt接收单位;
        private System.Windows.Forms.Button btn接收单位;
        private DN_HtmlEditor.DN_HtmlEditor dN_HtmlEditor1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}