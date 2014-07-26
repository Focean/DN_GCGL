namespace GCGL_Client.FZB
{
    partial class FZB_更新标准_Editor
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt依据文件 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn提交 = new System.Windows.Forms.Button();
            this.btn取消 = new System.Windows.Forms.Button();
            this.nud使用年限 = new System.Windows.Forms.NumericUpDown();
            this.nud行驶里程 = new System.Windows.Forms.NumericUpDown();
            this.chk是否生效 = new System.Windows.Forms.CheckBox();
            this.btn资产类别 = new System.Windows.Forms.Button();
            this.txt资产类别 = new System.Windows.Forms.TextBox();
            this.btn车辆类型 = new System.Windows.Forms.Button();
            this.txt车辆类型 = new System.Windows.Forms.TextBox();
            this.btn附件查看 = new System.Windows.Forms.Button();
            this.btn附件管理 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud使用年限)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud行驶里程)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "车辆类型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "使用年限：                  年";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "行驶里程：                  万公里";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "资产类别：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "依据文件：";
            // 
            // txt依据文件
            // 
            this.txt依据文件.BackColor = System.Drawing.SystemColors.Control;
            this.txt依据文件.Location = new System.Drawing.Point(106, 136);
            this.txt依据文件.Name = "txt依据文件";
            this.txt依据文件.ReadOnly = true;
            this.txt依据文件.Size = new System.Drawing.Size(350, 21);
            this.txt依据文件.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(14, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(475, 2);
            this.label11.TabIndex = 18;
            this.label11.Text = "label11";
            // 
            // btn提交
            // 
            this.btn提交.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn提交.Location = new System.Drawing.Point(262, 209);
            this.btn提交.Name = "btn提交";
            this.btn提交.Size = new System.Drawing.Size(80, 28);
            this.btn提交.TabIndex = 8;
            this.btn提交.Text = "提交";
            this.btn提交.UseVisualStyleBackColor = true;
            this.btn提交.Click += new System.EventHandler(this.btn提交_Click);
            // 
            // btn取消
            // 
            this.btn取消.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn取消.Location = new System.Drawing.Point(145, 209);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(80, 28);
            this.btn取消.TabIndex = 9;
            this.btn取消.Text = "取消";
            this.btn取消.UseVisualStyleBackColor = true;
            // 
            // nud使用年限
            // 
            this.nud使用年限.ForeColor = System.Drawing.Color.Blue;
            this.nud使用年限.Location = new System.Drawing.Point(106, 95);
            this.nud使用年限.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nud使用年限.Name = "nud使用年限";
            this.nud使用年限.Size = new System.Drawing.Size(100, 21);
            this.nud使用年限.TabIndex = 3;
            this.nud使用年限.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nud行驶里程
            // 
            this.nud行驶里程.ForeColor = System.Drawing.Color.Blue;
            this.nud行驶里程.Location = new System.Drawing.Point(319, 95);
            this.nud行驶里程.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud行驶里程.Name = "nud行驶里程";
            this.nud行驶里程.Size = new System.Drawing.Size(100, 21);
            this.nud行驶里程.TabIndex = 4;
            this.nud行驶里程.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chk是否生效
            // 
            this.chk是否生效.AutoSize = true;
            this.chk是否生效.Checked = true;
            this.chk是否生效.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk是否生效.ForeColor = System.Drawing.Color.Blue;
            this.chk是否生效.Location = new System.Drawing.Point(348, 216);
            this.chk是否生效.Name = "chk是否生效";
            this.chk是否生效.Size = new System.Drawing.Size(72, 16);
            this.chk是否生效.TabIndex = 7;
            this.chk是否生效.Text = "是否生效";
            this.chk是否生效.UseVisualStyleBackColor = true;
            // 
            // btn资产类别
            // 
            this.btn资产类别.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn资产类别.Location = new System.Drawing.Point(434, 59);
            this.btn资产类别.Name = "btn资产类别";
            this.btn资产类别.Size = new System.Drawing.Size(21, 19);
            this.btn资产类别.TabIndex = 2;
            this.btn资产类别.Text = "…";
            this.btn资产类别.UseVisualStyleBackColor = true;
            this.btn资产类别.Click += new System.EventHandler(this.btn资产类别_Click);
            // 
            // txt资产类别
            // 
            this.txt资产类别.BackColor = System.Drawing.Color.White;
            this.txt资产类别.Location = new System.Drawing.Point(106, 58);
            this.txt资产类别.Name = "txt资产类别";
            this.txt资产类别.ReadOnly = true;
            this.txt资产类别.Size = new System.Drawing.Size(350, 21);
            this.txt资产类别.TabIndex = 51;
            // 
            // btn车辆类型
            // 
            this.btn车辆类型.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn车辆类型.Location = new System.Drawing.Point(434, 20);
            this.btn车辆类型.Name = "btn车辆类型";
            this.btn车辆类型.Size = new System.Drawing.Size(21, 19);
            this.btn车辆类型.TabIndex = 1;
            this.btn车辆类型.Text = "…";
            this.btn车辆类型.UseVisualStyleBackColor = true;
            this.btn车辆类型.Click += new System.EventHandler(this.btn车辆类型_Click);
            // 
            // txt车辆类型
            // 
            this.txt车辆类型.BackColor = System.Drawing.Color.White;
            this.txt车辆类型.Location = new System.Drawing.Point(106, 19);
            this.txt车辆类型.Name = "txt车辆类型";
            this.txt车辆类型.ReadOnly = true;
            this.txt车辆类型.Size = new System.Drawing.Size(350, 21);
            this.txt车辆类型.TabIndex = 49;
            // 
            // btn附件查看
            // 
            this.btn附件查看.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn附件查看.Location = new System.Drawing.Point(375, 163);
            this.btn附件查看.Name = "btn附件查看";
            this.btn附件查看.Size = new System.Drawing.Size(80, 23);
            this.btn附件查看.TabIndex = 238;
            this.btn附件查看.Text = "附件查看(&W)";
            this.btn附件查看.UseVisualStyleBackColor = true;
            this.btn附件查看.Click += new System.EventHandler(this.btn附件查看_Click);
            // 
            // btn附件管理
            // 
            this.btn附件管理.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn附件管理.Location = new System.Drawing.Point(289, 163);
            this.btn附件管理.Name = "btn附件管理";
            this.btn附件管理.Size = new System.Drawing.Size(80, 23);
            this.btn附件管理.TabIndex = 237;
            this.btn附件管理.Text = "附件管理(&F)";
            this.btn附件管理.UseVisualStyleBackColor = true;
            this.btn附件管理.Click += new System.EventHandler(this.btn附件管理_Click);
            // 
            // FZB_更新标准_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 253);
            this.Controls.Add(this.btn附件查看);
            this.Controls.Add(this.btn附件管理);
            this.Controls.Add(this.btn资产类别);
            this.Controls.Add(this.txt资产类别);
            this.Controls.Add(this.btn车辆类型);
            this.Controls.Add(this.txt车辆类型);
            this.Controls.Add(this.chk是否生效);
            this.Controls.Add(this.nud行驶里程);
            this.Controls.Add(this.nud使用年限);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.btn提交);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt依据文件);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 292);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 292);
            this.Name = "FZB_更新标准_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.BZ_更新标准_Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud使用年限)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud行驶里程)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt依据文件;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn提交;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.NumericUpDown nud使用年限;
        private System.Windows.Forms.NumericUpDown nud行驶里程;
        private System.Windows.Forms.CheckBox chk是否生效;
        private System.Windows.Forms.Button btn资产类别;
        private System.Windows.Forms.TextBox txt资产类别;
        private System.Windows.Forms.Button btn车辆类型;
        private System.Windows.Forms.TextBox txt车辆类型;
        private System.Windows.Forms.Button btn附件查看;
        private System.Windows.Forms.Button btn附件管理;
    }
}