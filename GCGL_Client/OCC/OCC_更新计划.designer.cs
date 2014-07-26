namespace GCGL_Client.OCC
{
    partial class OCC_更新计划
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
            this.lbl年度更新计划列表 = new System.Windows.Forms.Label();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btn查看 = new System.Windows.Forms.Button();
            this.btn删除 = new System.Windows.Forms.Button();
            this.btn导出 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.tyGridView = new TY.Grids.TyGridView(this.components);
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.btn选择单位 = new System.Windows.Forms.Button();
            this.chk包含下级 = new System.Windows.Forms.CheckBox();
            this.txt选择单位 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.pnlTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tyGridView)).BeginInit();
            this.pnlQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl年度更新计划列表
            // 
            this.lbl年度更新计划列表.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl年度更新计划列表.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl年度更新计划列表.Location = new System.Drawing.Point(0, 30);
            this.lbl年度更新计划列表.Name = "lbl年度更新计划列表";
            this.lbl年度更新计划列表.Size = new System.Drawing.Size(944, 42);
            this.lbl年度更新计划列表.TabIndex = 0;
            this.lbl年度更新计划列表.Text = "年度更新计划列表";
            this.lbl年度更新计划列表.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTool.Controls.Add(this.btn查看);
            this.pnlTool.Controls.Add(this.btn删除);
            this.pnlTool.Controls.Add(this.btn导出);
            this.pnlTool.Controls.Add(this.btn修改);
            this.pnlTool.Controls.Add(this.btn关闭);
            this.pnlTool.Controls.Add(this.btn新增);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(944, 30);
            this.pnlTool.TabIndex = 4;
            // 
            // btn查看
            // 
            this.btn查看.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn查看.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn查看.Location = new System.Drawing.Point(225, 0);
            this.btn查看.Name = "btn查看";
            this.btn查看.Size = new System.Drawing.Size(75, 28);
            this.btn查看.TabIndex = 12;
            this.btn查看.Text = "查看(&K)";
            this.btn查看.UseVisualStyleBackColor = true;
            this.btn查看.Click += new System.EventHandler(this.btn查看_Click);
            // 
            // btn删除
            // 
            this.btn删除.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn删除.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn删除.Enabled = false;
            this.btn删除.Location = new System.Drawing.Point(150, 0);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(75, 28);
            this.btn删除.TabIndex = 11;
            this.btn删除.Text = "删除(&D)";
            this.btn删除.UseVisualStyleBackColor = true;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // btn导出
            // 
            this.btn导出.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn导出.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn导出.Location = new System.Drawing.Point(792, 0);
            this.btn导出.Name = "btn导出";
            this.btn导出.Size = new System.Drawing.Size(75, 28);
            this.btn导出.TabIndex = 8;
            this.btn导出.Text = "导出(&E)";
            this.btn导出.UseVisualStyleBackColor = true;
            this.btn导出.Click += new System.EventHandler(this.btn导出_Click);
            // 
            // btn修改
            // 
            this.btn修改.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn修改.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn修改.Enabled = false;
            this.btn修改.Location = new System.Drawing.Point(75, 0);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(75, 28);
            this.btn修改.TabIndex = 10;
            this.btn修改.Text = "修改(&M)";
            this.btn修改.UseVisualStyleBackColor = true;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // btn关闭
            // 
            this.btn关闭.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn关闭.Location = new System.Drawing.Point(867, 0);
            this.btn关闭.Name = "btn关闭";
            this.btn关闭.Size = new System.Drawing.Size(75, 28);
            this.btn关闭.TabIndex = 7;
            this.btn关闭.Text = "关闭(&X)";
            this.btn关闭.UseVisualStyleBackColor = true;
            this.btn关闭.Click += new System.EventHandler(this.btn关闭_Click);
            // 
            // btn新增
            // 
            this.btn新增.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn新增.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn新增.Enabled = false;
            this.btn新增.Location = new System.Drawing.Point(0, 0);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(75, 28);
            this.btn新增.TabIndex = 9;
            this.btn新增.Text = "新增(&N)";
            this.btn新增.UseVisualStyleBackColor = true;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // tyGridView
            // 
            this.tyGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tyGridView.ColumnDeep = 1;
            this.tyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tyGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tyGridView.Location = new System.Drawing.Point(0, 102);
            this.tyGridView.Name = "tyGridView";
            this.tyGridView.RowTemplate.Height = 23;
            this.tyGridView.Size = new System.Drawing.Size(944, 486);
            this.tyGridView.TabIndex = 11;
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlQuery.Controls.Add(this.btn选择单位);
            this.pnlQuery.Controls.Add(this.chk包含下级);
            this.pnlQuery.Controls.Add(this.txt选择单位);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 72);
            this.pnlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(944, 30);
            this.pnlQuery.TabIndex = 120;
            // 
            // btn选择单位
            // 
            this.btn选择单位.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn选择单位.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn选择单位.Location = new System.Drawing.Point(267, 5);
            this.btn选择单位.Name = "btn选择单位";
            this.btn选择单位.Size = new System.Drawing.Size(22, 21);
            this.btn选择单位.TabIndex = 140;
            this.btn选择单位.Text = "…";
            this.btn选择单位.UseVisualStyleBackColor = false;
            this.btn选择单位.Click += new System.EventHandler(this.btn选择单位_Click);
            // 
            // chk包含下级
            // 
            this.chk包含下级.AutoSize = true;
            this.chk包含下级.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chk包含下级.Location = new System.Drawing.Point(297, 8);
            this.chk包含下级.Name = "chk包含下级";
            this.chk包含下级.Size = new System.Drawing.Size(72, 16);
            this.chk包含下级.TabIndex = 141;
            this.chk包含下级.Text = "包含下级";
            this.chk包含下级.UseVisualStyleBackColor = true;
            // 
            // txt选择单位
            // 
            this.txt选择单位.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt选择单位.ForeColor = System.Drawing.Color.Blue;
            this.txt选择单位.Location = new System.Drawing.Point(69, 5);
            this.txt选择单位.Margin = new System.Windows.Forms.Padding(2);
            this.txt选择单位.Name = "txt选择单位";
            this.txt选择单位.ReadOnly = true;
            this.txt选择单位.Size = new System.Drawing.Size(220, 21);
            this.txt选择单位.TabIndex = 139;
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
            this.btnQuery.Location = new System.Drawing.Point(869, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // OCC_更新计划
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 588);
            this.Controls.Add(this.tyGridView);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.lbl年度更新计划列表);
            this.Controls.Add(this.pnlTool);
            this.HelpButton = true;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "OCC_更新计划";
            this.Load += new System.EventHandler(this.SP_年度计划_Load);
            this.pnlTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tyGridView)).EndInit();
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Button btn导出;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.Label lbl年度更新计划列表;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Button btn查看;
        private TY.Grids.TyGridView tyGridView;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.Button btn选择单位;
        private System.Windows.Forms.CheckBox chk包含下级;
        private System.Windows.Forms.TextBox txt选择单位;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuery;
    }
}