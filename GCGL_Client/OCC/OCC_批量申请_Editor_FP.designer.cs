namespace GCGL_Client.OCC
{
    partial class OCC_批量申请_Editor_FP
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
            this.txt预算单位名称 = new System.Windows.Forms.TextBox();
            this.lb预算单位 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nud分配数量 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btn取消 = new System.Windows.Forms.Button();
            this.btn确定 = new System.Windows.Forms.Button();
            this.btn添加单位 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud分配数量)).BeginInit();
            this.SuspendLayout();
            // 
            // txt预算单位名称
            // 
            this.txt预算单位名称.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt预算单位名称.ForeColor = System.Drawing.Color.Blue;
            this.txt预算单位名称.Location = new System.Drawing.Point(77, 16);
            this.txt预算单位名称.Name = "txt预算单位名称";
            this.txt预算单位名称.ReadOnly = true;
            this.txt预算单位名称.Size = new System.Drawing.Size(252, 21);
            this.txt预算单位名称.TabIndex = 52;
            // 
            // lb预算单位
            // 
            this.lb预算单位.AutoSize = true;
            this.lb预算单位.Location = new System.Drawing.Point(18, 20);
            this.lb预算单位.Name = "lb预算单位";
            this.lb预算单位.Size = new System.Drawing.Size(65, 12);
            this.lb预算单位.TabIndex = 54;
            this.lb预算单位.Text = "单位名称：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(198, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 12);
            this.label17.TabIndex = 57;
            this.label17.Text = "台";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud分配数量
            // 
            this.nud分配数量.ForeColor = System.Drawing.Color.Blue;
            this.nud分配数量.Location = new System.Drawing.Point(78, 79);
            this.nud分配数量.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud分配数量.Name = "nud分配数量";
            this.nud分配数量.Size = new System.Drawing.Size(112, 21);
            this.nud分配数量.TabIndex = 2;
            this.nud分配数量.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 56;
            this.label10.Text = "分配数量：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn取消
            // 
            this.btn取消.Location = new System.Drawing.Point(61, 126);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(100, 28);
            this.btn取消.TabIndex = 4;
            this.btn取消.Text = "取消（&ESC）";
            this.btn取消.UseVisualStyleBackColor = true;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // btn确定
            // 
            this.btn确定.Location = new System.Drawing.Point(183, 126);
            this.btn确定.Name = "btn确定";
            this.btn确定.Size = new System.Drawing.Size(100, 28);
            this.btn确定.TabIndex = 3;
            this.btn确定.Text = "确定（&Ctrl+S）";
            this.btn确定.UseVisualStyleBackColor = true;
            this.btn确定.Click += new System.EventHandler(this.btn确定_Click);
            // 
            // btn添加单位
            // 
            this.btn添加单位.Location = new System.Drawing.Point(254, 41);
            this.btn添加单位.Name = "btn添加单位";
            this.btn添加单位.Size = new System.Drawing.Size(75, 27);
            this.btn添加单位.TabIndex = 1;
            this.btn添加单位.Text = "添加单位";
            this.btn添加单位.UseVisualStyleBackColor = true;
            this.btn添加单位.Click += new System.EventHandler(this.btn添加单位_Click);
            // 
            // OCC_批量申请_Editor_FP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 167);
            this.Controls.Add(this.btn添加单位);
            this.Controls.Add(this.btn确定);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.nud分配数量);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt预算单位名称);
            this.Controls.Add(this.lb预算单位);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OCC_批量申请_Editor_FP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OCC_批量申请_Editor_FP";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OCC_批量申请_Editor_FP_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nud分配数量)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt预算单位名称;
        private System.Windows.Forms.Label lb预算单位;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nud分配数量;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Button btn确定;
        private System.Windows.Forms.Button btn添加单位;
    }
}