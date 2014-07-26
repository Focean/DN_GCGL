namespace GCGL_Client.RPT
{
    partial class RPT_公车库存_变化
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
            this.components = new System.ComponentModel.Container();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.cbx选择单位 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt查询年度 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn导出 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.tyGridView = new TY.Grids.TyGridView(this.components);
            this.pnlQuery.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlQuery.Controls.Add(this.cbx选择单位);
            this.pnlQuery.Controls.Add(this.label11);
            this.pnlQuery.Controls.Add(this.txt查询年度);
            this.pnlQuery.Controls.Add(this.label1);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 68);
            this.pnlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(1036, 30);
            this.pnlQuery.TabIndex = 132;
            // 
            // cbx选择单位
            // 
            this.cbx选择单位.FormattingEnabled = true;
            this.cbx选择单位.Location = new System.Drawing.Point(66, 5);
            this.cbx选择单位.MaxDropDownItems = 9;
            this.cbx选择单位.Name = "cbx选择单位";
            this.cbx选择单位.Size = new System.Drawing.Size(265, 20);
            this.cbx选择单位.TabIndex = 144;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(476, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 143;
            this.label11.Text = "年";
            // 
            // txt查询年度
            // 
            this.txt查询年度.Location = new System.Drawing.Point(401, 5);
            this.txt查询年度.Name = "txt查询年度";
            this.txt查询年度.Size = new System.Drawing.Size(72, 21);
            this.txt查询年度.TabIndex = 142;
            this.txt查询年度.Text = "2013";
            this.txt查询年度.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt查询年度_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 141;
            this.label1.Text = "查询年度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 138;
            this.label4.Text = "查询单位：";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuery.Location = new System.Drawing.Point(961, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1036, 40);
            this.lblTitle.TabIndex = 131;
            this.lblTitle.Text = "公务用车年度变化列表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn导出);
            this.panel1.Controls.Add(this.btn关闭);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 28);
            this.panel1.TabIndex = 133;
            // 
            // btn导出
            // 
            this.btn导出.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn导出.Location = new System.Drawing.Point(886, 0);
            this.btn导出.Name = "btn导出";
            this.btn导出.Size = new System.Drawing.Size(75, 28);
            this.btn导出.TabIndex = 5;
            this.btn导出.Text = "导出（&E)";
            this.btn导出.UseVisualStyleBackColor = true;
            // 
            // btn关闭
            // 
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(961, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 3;
            this.btn关闭.Text = "关 闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = true;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // tyGridView
            // 
            this.tyGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tyGridView.ColumnDeep = 1;
            this.tyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tyGridView.Location = new System.Drawing.Point(0, 98);
            this.tyGridView.Name = "tyGridView";
            this.tyGridView.RowTemplate.Height = 23;
            this.tyGridView.Size = new System.Drawing.Size(1036, 497);
            this.tyGridView.TabIndex = 135;
            // 
            // RPT_公车库存_变化
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1036, 595);
            this.Controls.Add(this.tyGridView);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "RPT_公车库存_变化";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "公车库存_变化";
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tyGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn导出;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.TextBox txt查询年度;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private TY.Grids.TyGridView tyGridView;
        private System.Windows.Forms.ComboBox cbx选择单位;
    }
}