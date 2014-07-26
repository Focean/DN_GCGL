namespace GCGL_Client.FZB
{
    partial class FZB_配置标准_Editor
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
            this.chk是否生效 = new System.Windows.Forms.CheckBox();
            this.nud价格 = new System.Windows.Forms.NumericUpDown();
            this.nud排量 = new System.Windows.Forms.NumericUpDown();
            this.btn取消 = new System.Windows.Forms.Button();
            this.btn提交 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt依据文件 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chk是否新能源汽车 = new System.Windows.Forms.CheckBox();
            this.btn资产类别 = new System.Windows.Forms.Button();
            this.txt资产类别 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn附件查看 = new System.Windows.Forms.Button();
            this.btn附件管理 = new System.Windows.Forms.Button();
            this.cbx车辆类型编码 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud价格)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud排量)).BeginInit();
            this.SuspendLayout();
            // 
            // chk是否生效
            // 
            this.chk是否生效.AutoSize = true;
            this.chk是否生效.Checked = true;
            this.chk是否生效.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk是否生效.ForeColor = System.Drawing.Color.Blue;
            this.chk是否生效.Location = new System.Drawing.Point(355, 236);
            this.chk是否生效.Name = "chk是否生效";
            this.chk是否生效.Size = new System.Drawing.Size(72, 16);
            this.chk是否生效.TabIndex = 9;
            this.chk是否生效.Text = "是否生效";
            this.chk是否生效.UseVisualStyleBackColor = true;
            // 
            // nud价格
            // 
            this.nud价格.DecimalPlaces = 2;
            this.nud价格.ForeColor = System.Drawing.Color.Blue;
            this.nud价格.Location = new System.Drawing.Point(320, 102);
            this.nud价格.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nud价格.Name = "nud价格";
            this.nud价格.Size = new System.Drawing.Size(100, 21);
            this.nud价格.TabIndex = 4;
            this.nud价格.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nud排量
            // 
            this.nud排量.DecimalPlaces = 1;
            this.nud排量.ForeColor = System.Drawing.Color.Blue;
            this.nud排量.Location = new System.Drawing.Point(102, 102);
            this.nud排量.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud排量.Name = "nud排量";
            this.nud排量.Size = new System.Drawing.Size(100, 21);
            this.nud排量.TabIndex = 3;
            this.nud排量.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn取消
            // 
            this.btn取消.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn取消.Location = new System.Drawing.Point(131, 229);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(89, 28);
            this.btn取消.TabIndex = 11;
            this.btn取消.Text = "取消(Esc)";
            this.btn取消.UseVisualStyleBackColor = true;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // btn提交
            // 
            this.btn提交.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn提交.Location = new System.Drawing.Point(259, 229);
            this.btn提交.Name = "btn提交";
            this.btn提交.Size = new System.Drawing.Size(89, 28);
            this.btn提交.TabIndex = 10;
            this.btn提交.Text = "提交(Ctrl+S)";
            this.btn提交.UseVisualStyleBackColor = true;
            this.btn提交.Click += new System.EventHandler(this.btn提交_Click);
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(16, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(461, 2);
            this.label11.TabIndex = 39;
            this.label11.Text = "label11";
            // 
            // txt依据文件
            // 
            this.txt依据文件.Location = new System.Drawing.Point(102, 143);
            this.txt依据文件.Name = "txt依据文件";
            this.txt依据文件.ReadOnly = true;
            this.txt依据文件.Size = new System.Drawing.Size(350, 21);
            this.txt依据文件.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 36;
            this.label8.Text = "依据文件：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "价格：                  万元";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "排量：                  升";
            // 
            // chk是否新能源汽车
            // 
            this.chk是否新能源汽车.AutoSize = true;
            this.chk是否新能源汽车.ForeColor = System.Drawing.Color.Red;
            this.chk是否新能源汽车.Location = new System.Drawing.Point(102, 177);
            this.chk是否新能源汽车.Name = "chk是否新能源汽车";
            this.chk是否新能源汽车.Size = new System.Drawing.Size(108, 16);
            this.chk是否新能源汽车.TabIndex = 6;
            this.chk是否新能源汽车.Text = "是否新能源汽车";
            this.chk是否新能源汽车.UseVisualStyleBackColor = true;
            // 
            // btn资产类别
            // 
            this.btn资产类别.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn资产类别.Location = new System.Drawing.Point(427, 26);
            this.btn资产类别.Name = "btn资产类别";
            this.btn资产类别.Size = new System.Drawing.Size(24, 19);
            this.btn资产类别.TabIndex = 1;
            this.btn资产类别.Text = "…";
            this.btn资产类别.UseVisualStyleBackColor = true;
            this.btn资产类别.Click += new System.EventHandler(this.btn资产类别_Click);
            // 
            // txt资产类别
            // 
            this.txt资产类别.BackColor = System.Drawing.Color.White;
            this.txt资产类别.Location = new System.Drawing.Point(102, 25);
            this.txt资产类别.Name = "txt资产类别";
            this.txt资产类别.ReadOnly = true;
            this.txt资产类别.Size = new System.Drawing.Size(350, 21);
            this.txt资产类别.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 54;
            this.label7.Text = "车辆类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 53;
            this.label4.Text = "资产类别：";
            // 
            // btn附件查看
            // 
            this.btn附件查看.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn附件查看.Location = new System.Drawing.Point(371, 170);
            this.btn附件查看.Name = "btn附件查看";
            this.btn附件查看.Size = new System.Drawing.Size(80, 23);
            this.btn附件查看.TabIndex = 8;
            this.btn附件查看.Text = "附件查看(&W)";
            this.btn附件查看.UseVisualStyleBackColor = true;
            this.btn附件查看.Click += new System.EventHandler(this.btn附件查看_Click);
            // 
            // btn附件管理
            // 
            this.btn附件管理.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn附件管理.Location = new System.Drawing.Point(285, 170);
            this.btn附件管理.Name = "btn附件管理";
            this.btn附件管理.Size = new System.Drawing.Size(80, 23);
            this.btn附件管理.TabIndex = 7;
            this.btn附件管理.Text = "附件管理(&F)";
            this.btn附件管理.UseVisualStyleBackColor = true;
            this.btn附件管理.Click += new System.EventHandler(this.btn附件管理_Click);
            // 
            // cbx车辆类型编码
            // 
            this.cbx车辆类型编码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx车辆类型编码.FormattingEnabled = true;
            this.cbx车辆类型编码.Location = new System.Drawing.Point(101, 64);
            this.cbx车辆类型编码.Name = "cbx车辆类型编码";
            this.cbx车辆类型编码.Size = new System.Drawing.Size(350, 20);
            this.cbx车辆类型编码.TabIndex = 2;
            // 
            // FZB_配置标准_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 279);
            this.Controls.Add(this.cbx车辆类型编码);
            this.Controls.Add(this.btn附件查看);
            this.Controls.Add(this.btn附件管理);
            this.Controls.Add(this.btn资产类别);
            this.Controls.Add(this.txt资产类别);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk是否新能源汽车);
            this.Controls.Add(this.chk是否生效);
            this.Controls.Add(this.nud价格);
            this.Controls.Add(this.nud排量);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.btn提交);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt依据文件);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 306);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(512, 306);
            this.Name = "FZB_配置标准_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FZB_配置标准_Editor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FZB_配置标准_Editor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nud价格)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud排量)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk是否生效;
        private System.Windows.Forms.NumericUpDown nud价格;
        private System.Windows.Forms.NumericUpDown nud排量;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Button btn提交;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt依据文件;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk是否新能源汽车;
        private System.Windows.Forms.Button btn资产类别;
        private System.Windows.Forms.TextBox txt资产类别;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn附件查看;
        private System.Windows.Forms.Button btn附件管理;
        private System.Windows.Forms.ComboBox cbx车辆类型编码;




    }
}