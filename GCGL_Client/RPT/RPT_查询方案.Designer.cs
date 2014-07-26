namespace GCGL_Client.RPT
{
    partial class RPT_查询方案
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
            this.clb单位 = new System.Windows.Forms.CheckedListBox();
            this.btn确定 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn保存方案 = new System.Windows.Forms.Button();
            this.cb全选 = new System.Windows.Forms.CheckBox();
            this.lv方案 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn取消 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clb单位
            // 
            this.clb单位.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clb单位.CheckOnClick = true;
            this.clb单位.FormattingEnabled = true;
            this.clb单位.Location = new System.Drawing.Point(181, 33);
            this.clb单位.Name = "clb单位";
            this.clb单位.Size = new System.Drawing.Size(293, 420);
            this.clb单位.TabIndex = 1;
            // 
            // btn确定
            // 
            this.btn确定.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn确定.Location = new System.Drawing.Point(385, 482);
            this.btn确定.Name = "btn确定";
            this.btn确定.Size = new System.Drawing.Size(75, 28);
            this.btn确定.TabIndex = 6;
            this.btn确定.Text = "查询(&J)";
            this.btn确定.UseVisualStyleBackColor = true;
            this.btn确定.Click += new System.EventHandler(this.btn确定_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(151, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "<<";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn保存方案
            // 
            this.btn保存方案.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn保存方案.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn保存方案.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn保存方案.Location = new System.Drawing.Point(181, 482);
            this.btn保存方案.Name = "btn保存方案";
            this.btn保存方案.Size = new System.Drawing.Size(87, 28);
            this.btn保存方案.TabIndex = 9;
            this.btn保存方案.Text = "保存方案(&S)";
            this.btn保存方案.UseVisualStyleBackColor = true;
            this.btn保存方案.Click += new System.EventHandler(this.btn保存方案_Click);
            // 
            // cb全选
            // 
            this.cb全选.AutoSize = true;
            this.cb全选.Location = new System.Drawing.Point(181, 12);
            this.cb全选.Name = "cb全选";
            this.cb全选.Size = new System.Drawing.Size(48, 16);
            this.cb全选.TabIndex = 10;
            this.cb全选.Text = "全选";
            this.cb全选.UseVisualStyleBackColor = true;
            this.cb全选.CheckedChanged += new System.EventHandler(this.cb全选_CheckedChanged);
            // 
            // lv方案
            // 
            this.lv方案.ContextMenuStrip = this.contextMenuStrip1;
            this.lv方案.Dock = System.Windows.Forms.DockStyle.Left;
            this.lv方案.Location = new System.Drawing.Point(0, 0);
            this.lv方案.MultiSelect = false;
            this.lv方案.Name = "lv方案";
            this.lv方案.Size = new System.Drawing.Size(150, 535);
            this.lv方案.TabIndex = 1;
            this.lv方案.UseCompatibleStateImageBehavior = false;
            this.lv方案.View = System.Windows.Forms.View.Details;
            this.lv方案.SelectedIndexChanged += new System.EventHandler(this.lv方案_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重命名ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 48);
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.重命名ToolStripMenuItem.Text = "重命名";
            this.重命名ToolStripMenuItem.Click += new System.EventHandler(this.重命名ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // btn取消
            // 
            this.btn取消.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn取消.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn取消.Location = new System.Drawing.Point(289, 482);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(75, 28);
            this.btn取消.TabIndex = 27;
            this.btn取消.Text = "取消(Esc)";
            this.btn取消.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(152, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 147);
            this.label2.TabIndex = 28;
            this.label2.Text = "可右键单击进行修改方案";
            // 
            // RPT_查询方案
            // 
            this.AcceptButton = this.btn取消;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.lv方案);
            this.Controls.Add(this.cb全选);
            this.Controls.Add(this.btn保存方案);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn确定);
            this.Controls.Add(this.clb单位);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(497, 475);
            this.Name = "RPT_查询方案";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RPT_查询方案";
            this.Load += new System.EventHandler(this.RPT_查询方案_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb单位;
        private System.Windows.Forms.Button btn确定;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn保存方案;
        private System.Windows.Forms.CheckBox cb全选;
        private System.Windows.Forms.ListView lv方案;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Label label2;
    }
}