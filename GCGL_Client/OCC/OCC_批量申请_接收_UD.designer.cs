namespace GCGL_Client.OCC
{
    partial class OCC_批量申请_接收_UD
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
            this.btn取消 = new System.Windows.Forms.Button();
            this.btn确定 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.nud分配数量 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nud接收数量 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt接收原因 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud分配数量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud接收数量)).BeginInit();
            this.SuspendLayout();
            // 
            // btn取消
            // 
            this.btn取消.Location = new System.Drawing.Point(77, 193);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(100, 30);
            this.btn取消.TabIndex = 4;
            this.btn取消.Text = "取消（&ESC）";
            this.btn取消.UseVisualStyleBackColor = true;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // btn确定
            // 
            this.btn确定.Location = new System.Drawing.Point(212, 193);
            this.btn确定.Name = "btn确定";
            this.btn确定.Size = new System.Drawing.Size(100, 30);
            this.btn确定.TabIndex = 5;
            this.btn确定.Text = "确定（&Ctrl+S）";
            this.btn确定.UseVisualStyleBackColor = true;
            this.btn确定.Click += new System.EventHandler(this.btn确定_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(181, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 12);
            this.label17.TabIndex = 130;
            this.label17.Text = "台";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud分配数量
            // 
            this.nud分配数量.ForeColor = System.Drawing.Color.Blue;
            this.nud分配数量.Location = new System.Drawing.Point(76, 22);
            this.nud分配数量.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud分配数量.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud分配数量.Name = "nud分配数量";
            this.nud分配数量.ReadOnly = true;
            this.nud分配数量.Size = new System.Drawing.Size(99, 21);
            this.nud分配数量.TabIndex = 1;
            this.nud分配数量.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud分配数量.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "分配数量：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(181, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 12);
            this.label19.TabIndex = 139;
            this.label19.Text = "台";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud接收数量
            // 
            this.nud接收数量.ForeColor = System.Drawing.Color.Blue;
            this.nud接收数量.Location = new System.Drawing.Point(76, 58);
            this.nud接收数量.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud接收数量.Name = "nud接收数量";
            this.nud接收数量.Size = new System.Drawing.Size(99, 21);
            this.nud接收数量.TabIndex = 2;
            this.nud接收数量.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "接收数量：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "接收原因：";
            // 
            // txt接收原因
            // 
            this.txt接收原因.Location = new System.Drawing.Point(76, 95);
            this.txt接收原因.Multiline = true;
            this.txt接收原因.Name = "txt接收原因";
            this.txt接收原因.Size = new System.Drawing.Size(296, 72);
            this.txt接收原因.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(197, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 142;
            this.label2.Text = "（修改接收台数）";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(6, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 1);
            this.label3.TabIndex = 143;
            this.label3.Text = "label3";
            // 
            // OCC_接收情况_Editor_UD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 230);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt接收原因);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.nud接收数量);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.nud分配数量);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn确定);
            this.Controls.Add(this.btn取消);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OCC_接收情况_Editor_UD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.nud分配数量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud接收数量)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Button btn确定;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nud分配数量;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown nud接收数量;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt接收原因;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}