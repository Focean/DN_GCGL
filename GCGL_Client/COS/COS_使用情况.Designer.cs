namespace GCGL_Client.COS
{
    partial class COS_使用情况
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl使用情况列表 = new System.Windows.Forms.Label();
            this.pnlTool = new System.Windows.Forms.Panel();
            this.btn删除 = new System.Windows.Forms.Button();
            this.btn导出 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.btn关闭 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.rb加油记录 = new System.Windows.Forms.RadioButton();
            this.rb保养记录 = new System.Windows.Forms.RadioButton();
            this.rb维修记录 = new System.Windows.Forms.RadioButton();
            this.rb出车记录 = new System.Windows.Forms.RadioButton();
            this.dtp结束时间 = new System.Windows.Forms.DateTimePicker();
            this.dtp开始时间 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx车牌号 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.pnlTool.SuspendLayout();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl使用情况列表
            // 
            this.lbl使用情况列表.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl使用情况列表.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl使用情况列表.Location = new System.Drawing.Point(0, 30);
            this.lbl使用情况列表.Name = "lbl使用情况列表";
            this.lbl使用情况列表.Size = new System.Drawing.Size(1131, 42);
            this.lbl使用情况列表.TabIndex = 121;
            this.lbl使用情况列表.Text = "使用情况列表";
            this.lbl使用情况列表.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlTool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTool.Controls.Add(this.btn删除);
            this.pnlTool.Controls.Add(this.btn导出);
            this.pnlTool.Controls.Add(this.btn修改);
            this.pnlTool.Controls.Add(this.btn关闭);
            this.pnlTool.Controls.Add(this.btn新增);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Size = new System.Drawing.Size(1131, 30);
            this.pnlTool.TabIndex = 122;
            // 
            // btn删除
            // 
            this.btn删除.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn删除.Dock = System.Windows.Forms.DockStyle.Left;
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
            this.btn导出.Location = new System.Drawing.Point(979, 0);
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
            this.btn关闭.Location = new System.Drawing.Point(1054, 0);
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
            this.btn新增.Location = new System.Drawing.Point(0, 0);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(75, 28);
            this.btn新增.TabIndex = 9;
            this.btn新增.Text = "新增(&N)";
            this.btn新增.UseVisualStyleBackColor = true;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlQuery.Controls.Add(this.rb加油记录);
            this.pnlQuery.Controls.Add(this.rb保养记录);
            this.pnlQuery.Controls.Add(this.rb维修记录);
            this.pnlQuery.Controls.Add(this.rb出车记录);
            this.pnlQuery.Controls.Add(this.dtp结束时间);
            this.pnlQuery.Controls.Add(this.dtp开始时间);
            this.pnlQuery.Controls.Add(this.label2);
            this.pnlQuery.Controls.Add(this.cbx车牌号);
            this.pnlQuery.Controls.Add(this.label4);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 72);
            this.pnlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(1131, 30);
            this.pnlQuery.TabIndex = 124;
            // 
            // rb加油记录
            // 
            this.rb加油记录.AutoSize = true;
            this.rb加油记录.Checked = true;
            this.rb加油记录.ForeColor = System.Drawing.Color.Fuchsia;
            this.rb加油记录.Location = new System.Drawing.Point(556, 7);
            this.rb加油记录.Name = "rb加油记录";
            this.rb加油记录.Size = new System.Drawing.Size(71, 16);
            this.rb加油记录.TabIndex = 154;
            this.rb加油记录.TabStop = true;
            this.rb加油记录.Text = "加油记录";
            this.rb加油记录.UseVisualStyleBackColor = true;
            // 
            // rb保养记录
            // 
            this.rb保养记录.AutoSize = true;
            this.rb保养记录.ForeColor = System.Drawing.Color.Fuchsia;
            this.rb保养记录.Location = new System.Drawing.Point(633, 7);
            this.rb保养记录.Name = "rb保养记录";
            this.rb保养记录.Size = new System.Drawing.Size(71, 16);
            this.rb保养记录.TabIndex = 153;
            this.rb保养记录.TabStop = true;
            this.rb保养记录.Text = "保养记录";
            this.rb保养记录.UseVisualStyleBackColor = true;
            this.rb保养记录.CheckedChanged += new System.EventHandler(this.rb保养记录_CheckedChanged);
            // 
            // rb维修记录
            // 
            this.rb维修记录.AutoSize = true;
            this.rb维修记录.ForeColor = System.Drawing.Color.Fuchsia;
            this.rb维修记录.Location = new System.Drawing.Point(711, 7);
            this.rb维修记录.Name = "rb维修记录";
            this.rb维修记录.Size = new System.Drawing.Size(71, 16);
            this.rb维修记录.TabIndex = 152;
            this.rb维修记录.TabStop = true;
            this.rb维修记录.Text = "维修记录";
            this.rb维修记录.UseVisualStyleBackColor = true;
            this.rb维修记录.CheckedChanged += new System.EventHandler(this.rb维修记录_CheckedChanged);
            // 
            // rb出车记录
            // 
            this.rb出车记录.AutoSize = true;
            this.rb出车记录.ForeColor = System.Drawing.Color.Fuchsia;
            this.rb出车记录.Location = new System.Drawing.Point(789, 7);
            this.rb出车记录.Name = "rb出车记录";
            this.rb出车记录.Size = new System.Drawing.Size(71, 16);
            this.rb出车记录.TabIndex = 151;
            this.rb出车记录.TabStop = true;
            this.rb出车记录.Text = "出车记录";
            this.rb出车记录.UseVisualStyleBackColor = true;
            this.rb出车记录.CheckedChanged += new System.EventHandler(this.rb出车记录_CheckedChanged);
            // 
            // dtp结束时间
            // 
            this.dtp结束时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp结束时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp结束时间.Location = new System.Drawing.Point(420, 5);
            this.dtp结束时间.Name = "dtp结束时间";
            this.dtp结束时间.Size = new System.Drawing.Size(121, 21);
            this.dtp结束时间.TabIndex = 146;
            // 
            // dtp开始时间
            // 
            this.dtp开始时间.CustomFormat = "yyyy年MM月dd日";
            this.dtp开始时间.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp开始时间.Location = new System.Drawing.Point(240, 5);
            this.dtp开始时间.Name = "dtp开始时间";
            this.dtp开始时间.Size = new System.Drawing.Size(122, 21);
            this.dtp开始时间.TabIndex = 145;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 12);
            this.label2.TabIndex = 144;
            this.label2.Text = "开始日期                      结束日期";
            // 
            // cbx车牌号
            // 
            this.cbx车牌号.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx车牌号.FormattingEnabled = true;
            this.cbx车牌号.Location = new System.Drawing.Point(68, 5);
            this.cbx车牌号.Name = "cbx车牌号";
            this.cbx车牌号.Size = new System.Drawing.Size(101, 20);
            this.cbx车牌号.TabIndex = 139;
            this.cbx车牌号.SelectedValueChanged += new System.EventHandler(this.cbx车牌号_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 138;
            this.label4.Text = "车牌号：";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuery.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnQuery.Location = new System.Drawing.Point(1056, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvList.ColumnHeadersHeight = 28;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 102);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1131, 446);
            this.dgvList.TabIndex = 125;
            // 
            // COS_使用情况
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 548);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pnlQuery);
            this.Controls.Add(this.lbl使用情况列表);
            this.Controls.Add(this.pnlTool);
            this.Name = "COS_使用情况";
            this.Text = "COS_使用情况";
            this.pnlTool.ResumeLayout(false);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl使用情况列表;
        private System.Windows.Forms.Panel pnlTool;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.Button btn导出;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Button btn关闭;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cbx车牌号;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DateTimePicker dtp结束时间;
        private System.Windows.Forms.DateTimePicker dtp开始时间;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb出车记录;
        private System.Windows.Forms.RadioButton rb加油记录;
        private System.Windows.Forms.RadioButton rb保养记录;
        private System.Windows.Forms.RadioButton rb维修记录;
    }
}