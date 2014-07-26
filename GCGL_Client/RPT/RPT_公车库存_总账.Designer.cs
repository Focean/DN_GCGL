namespace GCGL_Client.RPT
{
    partial class RPT_公车库存_总账
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
            this.dtp结束时间 = new System.Windows.Forms.DateTimePicker();
            this.dtp开始时间 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn导出 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.tyGridView = new TY.Grids.TyGridView(this.components);
            this.cbx单位编码 = new System.Windows.Forms.ComboBox();
            this.pnlQuery.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlQuery.Controls.Add(this.cbx单位编码);
            this.pnlQuery.Controls.Add(this.dtp结束时间);
            this.pnlQuery.Controls.Add(this.dtp开始时间);
            this.pnlQuery.Controls.Add(this.label2);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 68);
            this.pnlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(1017, 30);
            this.pnlQuery.TabIndex = 132;
            // 
            // dtp结束时间
            // 
            this.dtp结束时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp结束时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp结束时间.Location = new System.Drawing.Point(571, 5);
            this.dtp结束时间.Name = "dtp结束时间";
            this.dtp结束时间.Size = new System.Drawing.Size(121, 21);
            this.dtp结束时间.TabIndex = 143;
            // 
            // dtp开始时间
            // 
            this.dtp开始时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp开始时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp开始时间.Location = new System.Drawing.Point(382, 5);
            this.dtp开始时间.Name = "dtp开始时间";
            this.dtp开始时间.Size = new System.Drawing.Size(122, 21);
            this.dtp开始时间.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 12);
            this.label2.TabIndex = 141;
            this.label2.Text = "开始日期                        结束日期";
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
            this.btnQuery.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnQuery.Location = new System.Drawing.Point(942, 0);
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
            this.lblTitle.Size = new System.Drawing.Size(1017, 40);
            this.lblTitle.TabIndex = 131;
            this.lblTitle.Text = "公务用车总账列表";
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
            this.panel1.Size = new System.Drawing.Size(1017, 28);
            this.panel1.TabIndex = 133;
            // 
            // btn导出
            // 
            this.btn导出.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn导出.Location = new System.Drawing.Point(867, 0);
            this.btn导出.Name = "btn导出";
            this.btn导出.Size = new System.Drawing.Size(75, 28);
            this.btn导出.TabIndex = 5;
            this.btn导出.Text = "导出（&E)";
            this.btn导出.UseVisualStyleBackColor = true;
            // 
            // btn关闭
            // 
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(942, 0);
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
            this.tyGridView.Size = new System.Drawing.Size(1017, 333);
            this.tyGridView.TabIndex = 10;
            // 
            // cbx单位编码
            // 
            this.cbx单位编码.FormattingEnabled = true;
            this.cbx单位编码.Location = new System.Drawing.Point(69, 5);
            this.cbx单位编码.Name = "cbx单位编码";
            this.cbx单位编码.Size = new System.Drawing.Size(256, 20);
            this.cbx单位编码.TabIndex = 144;
            // 
            // RPT_公车库存_总账
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 431);
            this.Controls.Add(this.tyGridView);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "RPT_公车库存_总账";
            this.Text = "OCC_公车库存_总账";
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
        private System.Windows.Forms.DateTimePicker dtp结束时间;
        private System.Windows.Forms.DateTimePicker dtp开始时间;
        private System.Windows.Forms.Label label2;
        private TY.Grids.TyGridView tyGridView;
        private System.Windows.Forms.ComboBox cbx单位编码;
    }
}