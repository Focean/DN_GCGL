namespace GCGL_Client.NET
{
    partial class NET_审批中心_List_不通过
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
            this.txtexOpinion = new System.Windows.Forms.TextBox();
            this.btn确定 = new System.Windows.Forms.Button();
            this.btn取消 = new System.Windows.Forms.Button();
            this.cbx返回到 = new System.Windows.Forms.ComboBox();
            this.rbn不同意 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtexOpinion
            // 
            this.txtexOpinion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtexOpinion.AutoCompleteCustomSource.AddRange(new string[] {
            "调度"});
            this.txtexOpinion.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtexOpinion.ForeColor = System.Drawing.Color.Blue;
            this.txtexOpinion.Location = new System.Drawing.Point(12, 12);
            this.txtexOpinion.Multiline = true;
            this.txtexOpinion.Name = "txtexOpinion";
            this.txtexOpinion.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtexOpinion.Size = new System.Drawing.Size(427, 115);
            this.txtexOpinion.TabIndex = 3;
            // 
            // btn确定
            // 
            this.btn确定.Location = new System.Drawing.Point(258, 187);
            this.btn确定.Name = "btn确定";
            this.btn确定.Size = new System.Drawing.Size(75, 28);
            this.btn确定.TabIndex = 4;
            this.btn确定.Text = "确定(&J)";
            this.btn确定.UseVisualStyleBackColor = true;
            this.btn确定.Click += new System.EventHandler(this.btn确定_Click);
            // 
            // btn取消
            // 
            this.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn取消.Location = new System.Drawing.Point(139, 186);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(75, 28);
            this.btn取消.TabIndex = 5;
            this.btn取消.Text = "取消(Esc)";
            this.btn取消.UseVisualStyleBackColor = true;
            // 
            // cbx返回到
            // 
            this.cbx返回到.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx返回到.ForeColor = System.Drawing.Color.Red;
            this.cbx返回到.FormattingEnabled = true;
            this.cbx返回到.Items.AddRange(new object[] {
            "返回到上一步",
            "返回给申请单位"});
            this.cbx返回到.Location = new System.Drawing.Point(130, 138);
            this.cbx返回到.Name = "cbx返回到";
            this.cbx返回到.Size = new System.Drawing.Size(309, 20);
            this.cbx返回到.TabIndex = 15;
            // 
            // rbn不同意
            // 
            this.rbn不同意.AutoSize = true;
            this.rbn不同意.Checked = true;
            this.rbn不同意.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbn不同意.ForeColor = System.Drawing.Color.Red;
            this.rbn不同意.Location = new System.Drawing.Point(7, 138);
            this.rbn不同意.Name = "rbn不同意";
            this.rbn不同意.Size = new System.Drawing.Size(122, 23);
            this.rbn不同意.TabIndex = 14;
            this.rbn不同意.TabStop = true;
            this.rbn不同意.Text = "不同意，并";
            this.rbn不同意.UseVisualStyleBackColor = true;
            // 
            // NET_审批中心_List_不通过
            // 
            this.AcceptButton = this.btn取消;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 236);
            this.Controls.Add(this.cbx返回到);
            this.Controls.Add(this.rbn不同意);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.btn确定);
            this.Controls.Add(this.txtexOpinion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 263);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 263);
            this.Name = "NET_审批中心_List_不通过";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "审核不通过";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtexOpinion;
        private System.Windows.Forms.Button btn确定;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.ComboBox cbx返回到;
        private System.Windows.Forms.RadioButton rbn不同意;
    }
}