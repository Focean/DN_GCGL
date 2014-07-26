namespace GCGL_Client.COS
{
    partial class COS_使用情况_加油
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
            this.cbx车牌号 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl加油 = new System.Windows.Forms.Panel();
            this.nud加油行驶里程 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txt加油费用 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.nud油价 = new System.Windows.Forms.NumericUpDown();
            this.nud加油量 = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dtp加油日期 = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btn取消 = new System.Windows.Forms.Button();
            this.btn提交 = new System.Windows.Forms.Button();
            this.pnl加油.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud加油行驶里程)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud油价)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud加油量)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx车牌号
            // 
            this.cbx车牌号.FormattingEnabled = true;
            this.cbx车牌号.Location = new System.Drawing.Point(70, 12);
            this.cbx车牌号.Name = "cbx车牌号";
            this.cbx车牌号.Size = new System.Drawing.Size(121, 20);
            this.cbx车牌号.TabIndex = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 112;
            this.label2.Text = "车牌号：";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 48);
            this.label1.TabIndex = 114;
            this.label1.Text = "车辆加油登记单";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl加油
            // 
            this.pnl加油.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl加油.Controls.Add(this.nud加油行驶里程);
            this.pnl加油.Controls.Add(this.label13);
            this.pnl加油.Controls.Add(this.cbx车牌号);
            this.pnl加油.Controls.Add(this.txt加油费用);
            this.pnl加油.Controls.Add(this.label2);
            this.pnl加油.Controls.Add(this.label29);
            this.pnl加油.Controls.Add(this.nud油价);
            this.pnl加油.Controls.Add(this.nud加油量);
            this.pnl加油.Controls.Add(this.label27);
            this.pnl加油.Controls.Add(this.label26);
            this.pnl加油.Controls.Add(this.label6);
            this.pnl加油.Controls.Add(this.label23);
            this.pnl加油.Controls.Add(this.dtp加油日期);
            this.pnl加油.Controls.Add(this.label22);
            this.pnl加油.Controls.Add(this.label3);
            this.pnl加油.Controls.Add(this.label25);
            this.pnl加油.Location = new System.Drawing.Point(12, 51);
            this.pnl加油.Name = "pnl加油";
            this.pnl加油.Size = new System.Drawing.Size(428, 149);
            this.pnl加油.TabIndex = 115;
            // 
            // nud加油行驶里程
            // 
            this.nud加油行驶里程.ForeColor = System.Drawing.Color.Blue;
            this.nud加油行驶里程.Location = new System.Drawing.Point(309, 12);
            this.nud加油行驶里程.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud加油行驶里程.Name = "nud加油行驶里程";
            this.nud加油行驶里程.Size = new System.Drawing.Size(73, 21);
            this.nud加油行驶里程.TabIndex = 0;
            this.nud加油行驶里程.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(246, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "行驶里程：";
            // 
            // txt加油费用
            // 
            this.txt加油费用.Location = new System.Drawing.Point(309, 92);
            this.txt加油费用.Name = "txt加油费用";
            this.txt加油费用.ReadOnly = true;
            this.txt加油费用.Size = new System.Drawing.Size(73, 21);
            this.txt加油费用.TabIndex = 109;
            this.txt加油费用.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(258, 96);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 12);
            this.label29.TabIndex = 108;
            this.label29.Text = "总金额：";
            // 
            // nud油价
            // 
            this.nud油价.DecimalPlaces = 2;
            this.nud油价.ForeColor = System.Drawing.Color.Blue;
            this.nud油价.Location = new System.Drawing.Point(72, 92);
            this.nud油价.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nud油价.Name = "nud油价";
            this.nud油价.Size = new System.Drawing.Size(82, 21);
            this.nud油价.TabIndex = 92;
            this.nud油价.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nud加油量
            // 
            this.nud加油量.DecimalPlaces = 1;
            this.nud加油量.ForeColor = System.Drawing.Color.Blue;
            this.nud加油量.Location = new System.Drawing.Point(309, 53);
            this.nud加油量.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud加油量.Name = "nud加油量";
            this.nud加油量.Size = new System.Drawing.Size(73, 21);
            this.nud加油量.TabIndex = 91;
            this.nud加油量.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(33, 96);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 12);
            this.label27.TabIndex = 89;
            this.label27.Text = "单价：";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(385, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(11, 12);
            this.label26.TabIndex = 88;
            this.label26.Text = "L";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 87;
            this.label6.Text = "加油量：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(385, 96);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 12);
            this.label23.TabIndex = 108;
            this.label23.Text = "元";
            // 
            // dtp加油日期
            // 
            this.dtp加油日期.CustomFormat = "yyyy年MM月dd日";
            this.dtp加油日期.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp加油日期.Location = new System.Drawing.Point(70, 53);
            this.dtp加油日期.Name = "dtp加油日期";
            this.dtp加油日期.Size = new System.Drawing.Size(121, 21);
            this.dtp加油日期.TabIndex = 2;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(160, 96);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 107;
            this.label22.Text = "元/L";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 84;
            this.label3.Text = "加油日期：";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(385, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 110;
            this.label25.Text = "公里";
            // 
            // btn取消
            // 
            this.btn取消.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn取消.AutoSize = true;
            this.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn取消.Location = new System.Drawing.Point(109, 220);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(110, 28);
            this.btn取消.TabIndex = 117;
            this.btn取消.Text = "取消(&ESC)";
            this.btn取消.UseVisualStyleBackColor = true;
            // 
            // btn提交
            // 
            this.btn提交.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn提交.AutoSize = true;
            this.btn提交.Location = new System.Drawing.Point(248, 220);
            this.btn提交.Name = "btn提交";
            this.btn提交.Size = new System.Drawing.Size(110, 28);
            this.btn提交.TabIndex = 116;
            this.btn提交.Text = "提交(Ctrl+S)";
            this.btn提交.UseVisualStyleBackColor = true;
            this.btn提交.Click += new System.EventHandler(this.btn提交_Click);
            // 
            // COS_使用情况_加油
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 268);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.btn提交);
            this.Controls.Add(this.pnl加油);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "COS_使用情况_加油";
            this.Text = "COS_使用情况_加油";
            this.pnl加油.ResumeLayout(false);
            this.pnl加油.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud加油行驶里程)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud油价)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud加油量)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx车牌号;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl加油;
        private System.Windows.Forms.NumericUpDown nud加油行驶里程;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt加油费用;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown nud油价;
        private System.Windows.Forms.NumericUpDown nud加油量;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtp加油日期;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Button btn提交;
    }
}