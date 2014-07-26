namespace GCGL_Client.NET
{
    partial class NET_业务论坛_贴子_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NET_业务论坛_贴子_Editor));
            this.label1 = new System.Windows.Forms.Label();
            this.txt创建人编码 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt贴子标题 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dN_HtmlEditor1 = new WindowsFormsControlLibrary1.DN_HtmlEditor();
            this.cbx版块名称 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "发贴人：";
            // 
            // txt创建人编码
            // 
            this.txt创建人编码.BackColor = System.Drawing.Color.White;
            this.txt创建人编码.Location = new System.Drawing.Point(64, 56);
            this.txt创建人编码.Name = "txt创建人编码";
            this.txt创建人编码.ReadOnly = true;
            this.txt创建人编码.Size = new System.Drawing.Size(671, 21);
            this.txt创建人编码.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "贴子标题：";
            // 
            // txt贴子标题
            // 
            this.txt贴子标题.Location = new System.Drawing.Point(65, 96);
            this.txt贴子标题.Name = "txt贴子标题";
            this.txt贴子标题.Size = new System.Drawing.Size(670, 21);
            this.txt贴子标题.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "贴子内容：";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.Location = new System.Drawing.Point(406, 474);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(97, 28);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "发表(Ctrl+D)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(260, 474);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消(ESC)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = " 版块名称：";
            // 
            // dN_HtmlEditor1
            // 
            this.dN_HtmlEditor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dN_HtmlEditor1.Location = new System.Drawing.Point(65, 138);
            this.dN_HtmlEditor1.Name = "dN_HtmlEditor1";
            this.dN_HtmlEditor1.Size = new System.Drawing.Size(670, 313);
            this.dN_HtmlEditor1.TabIndex = 17;
            this.dN_HtmlEditor1.WB_HtmlText = resources.GetString("dN_HtmlEditor1.WB_HtmlText");
            // 
            // cbx版块名称
            // 
            this.cbx版块名称.BackColor = System.Drawing.SystemColors.Info;
            this.cbx版块名称.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx版块名称.FormattingEnabled = true;
            this.cbx版块名称.Location = new System.Drawing.Point(65, 17);
            this.cbx版块名称.Name = "cbx版块名称";
            this.cbx版块名称.Size = new System.Drawing.Size(670, 20);
            this.cbx版块名称.TabIndex = 18;
            // 
            // NET_业务论坛_贴子_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 519);
            this.Controls.Add(this.cbx版块名称);
            this.Controls.Add(this.dN_HtmlEditor1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt贴子标题);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt创建人编码);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NET_业务论坛_贴子_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt创建人编码;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt贴子标题;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.DN_HtmlEditor dN_HtmlEditor1;
        private System.Windows.Forms.ComboBox cbx版块名称;
    }
}