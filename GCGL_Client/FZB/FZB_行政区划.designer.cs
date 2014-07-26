namespace GCGL_Client.FZB
{
    partial class FZB_行政区划
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FZB_行政区划));
            this.dtvTreeView = new DingnuoControlLibrary.DBTreeView();
            this.iglTree = new System.Windows.Forms.ImageList(this.components);
            this.panelMB = new System.Windows.Forms.Panel();
            this.panelMR = new System.Windows.Forms.Panel();
            this.panelT = new System.Windows.Forms.Panel();
            this.Btn刷新 = new System.Windows.Forms.Button();
            this.Btn修改 = new System.Windows.Forms.Button();
            this.Btn删除 = new System.Windows.Forms.Button();
            this.Btn增加 = new System.Windows.Forms.Button();
            this.Btn关闭 = new System.Windows.Forms.Button();
            this.panelMT = new System.Windows.Forms.Panel();
            this.Lbl标题 = new System.Windows.Forms.Label();
            this.panelMI = new System.Windows.Forms.Panel();
            this.panelT.SuspendLayout();
            this.panelMT.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtvTreeView
            // 
            this.dtvTreeView.CheckBoxs = false;
            this.dtvTreeView.CheckMode = DingnuoControlLibrary.CheckMode.None;
            this.dtvTreeView.DataSource = null;
            this.dtvTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtvTreeView.HideSelection = false;
            this.dtvTreeView.ImageIndex = 0;
            this.dtvTreeView.ImageList = this.iglTree;
            this.dtvTreeView.ItemHeight = 18;
            this.dtvTreeView.Location = new System.Drawing.Point(0, 59);
            this.dtvTreeView.MultiSelect = false;
            this.dtvTreeView.Name = "dtvTreeView";
            this.dtvTreeView.NodeID = "编码";
            this.dtvTreeView.NodePID = "上级编码";
            this.dtvTreeView.NodeTitle = "全名";
            this.dtvTreeView.SelectedImageIndex = 0;
            this.dtvTreeView.SelectedNode = null;
            this.dtvTreeView.Size = new System.Drawing.Size(689, 402);
            this.dtvTreeView.TabIndex = 75;
            this.dtvTreeView.TreeNodeCreated += new DingnuoControlLibrary.TreeNodeCreatedEventHandler(this.dtvTreeView_TreeNodeCreated);
            // 
            // iglTree
            // 
            this.iglTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iglTree.ImageStream")));
            this.iglTree.TransparentColor = System.Drawing.Color.Fuchsia;
            this.iglTree.Images.SetKeyName(0, "arrowright_green16.bmp");
            this.iglTree.Images.SetKeyName(1, "stop_blue16.bmp");
            this.iglTree.Images.SetKeyName(2, "AddToFavorites.bmp");
            // 
            // panelMB
            // 
            this.panelMB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMB.Location = new System.Drawing.Point(0, 461);
            this.panelMB.Name = "panelMB";
            this.panelMB.Size = new System.Drawing.Size(689, 8);
            this.panelMB.TabIndex = 72;
            // 
            // panelMR
            // 
            this.panelMR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMR.Location = new System.Drawing.Point(689, 59);
            this.panelMR.Name = "panelMR";
            this.panelMR.Size = new System.Drawing.Size(6, 410);
            this.panelMR.TabIndex = 70;
            // 
            // panelT
            // 
            this.panelT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelT.Controls.Add(this.Btn刷新);
            this.panelT.Controls.Add(this.Btn删除);
            this.panelT.Controls.Add(this.Btn修改);
            this.panelT.Controls.Add(this.Btn增加);
            this.panelT.Controls.Add(this.Btn关闭);
            this.panelT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelT.Location = new System.Drawing.Point(0, 0);
            this.panelT.Name = "panelT";
            this.panelT.Size = new System.Drawing.Size(695, 25);
            this.panelT.TabIndex = 69;
            // 
            // Btn刷新
            // 
            this.Btn刷新.BackColor = System.Drawing.SystemColors.Control;
            this.Btn刷新.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn刷新.Location = new System.Drawing.Point(195, 0);
            this.Btn刷新.Name = "Btn刷新";
            this.Btn刷新.Size = new System.Drawing.Size(65, 25);
            this.Btn刷新.TabIndex = 4;
            this.Btn刷新.Text = "刷新(&R)";
            this.Btn刷新.UseVisualStyleBackColor = false;
            this.Btn刷新.Click += new System.EventHandler(this.Btn刷新_Click);
            // 
            // Btn修改
            // 
            this.Btn修改.BackColor = System.Drawing.SystemColors.Control;
            this.Btn修改.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn修改.Location = new System.Drawing.Point(65, 0);
            this.Btn修改.Name = "Btn修改";
            this.Btn修改.Size = new System.Drawing.Size(65, 25);
            this.Btn修改.TabIndex = 3;
            this.Btn修改.Text = "修改(&M)";
            this.Btn修改.UseVisualStyleBackColor = false;
            this.Btn修改.Click += new System.EventHandler(this.Btn修改_Click);
            // 
            // Btn删除
            // 
            this.Btn删除.BackColor = System.Drawing.SystemColors.Control;
            this.Btn删除.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn删除.Location = new System.Drawing.Point(130, 0);
            this.Btn删除.Name = "Btn删除";
            this.Btn删除.Size = new System.Drawing.Size(65, 25);
            this.Btn删除.TabIndex = 2;
            this.Btn删除.Text = "删除(&D)";
            this.Btn删除.UseVisualStyleBackColor = false;
            this.Btn删除.Click += new System.EventHandler(this.Btn删除_Click);
            // 
            // Btn增加
            // 
            this.Btn增加.BackColor = System.Drawing.SystemColors.Control;
            this.Btn增加.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn增加.Location = new System.Drawing.Point(0, 0);
            this.Btn增加.Name = "Btn增加";
            this.Btn增加.Size = new System.Drawing.Size(65, 25);
            this.Btn增加.TabIndex = 1;
            this.Btn增加.Text = "增加(&A)";
            this.Btn增加.UseVisualStyleBackColor = false;
            this.Btn增加.Click += new System.EventHandler(this.Btn增加_Click);
            // 
            // Btn关闭
            // 
            this.Btn关闭.BackColor = System.Drawing.SystemColors.Control;
            this.Btn关闭.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn关闭.Location = new System.Drawing.Point(630, 0);
            this.Btn关闭.Name = "Btn关闭";
            this.Btn关闭.Size = new System.Drawing.Size(65, 25);
            this.Btn关闭.TabIndex = 5;
            this.Btn关闭.Text = "关闭(&X)";
            this.Btn关闭.UseVisualStyleBackColor = false;
            this.Btn关闭.Click += new System.EventHandler(this.Btn关闭_Click);
            // 
            // panelMT
            // 
            this.panelMT.Controls.Add(this.Lbl标题);
            this.panelMT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMT.Location = new System.Drawing.Point(0, 27);
            this.panelMT.Name = "panelMT";
            this.panelMT.Size = new System.Drawing.Size(695, 32);
            this.panelMT.TabIndex = 73;
            // 
            // Lbl标题
            // 
            this.Lbl标题.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl标题.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl标题.Location = new System.Drawing.Point(0, 0);
            this.Lbl标题.Name = "Lbl标题";
            this.Lbl标题.Size = new System.Drawing.Size(695, 32);
            this.Lbl标题.TabIndex = 3;
            this.Lbl标题.Text = "行政区划列表";
            this.Lbl标题.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMI
            // 
            this.panelMI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMI.Location = new System.Drawing.Point(0, 25);
            this.panelMI.Name = "panelMI";
            this.panelMI.Size = new System.Drawing.Size(695, 2);
            this.panelMI.TabIndex = 74;
            // 
            // FZB_行政区划
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 469);
            this.Controls.Add(this.dtvTreeView);
            this.Controls.Add(this.panelMB);
            this.Controls.Add(this.panelMR);
            this.Controls.Add(this.panelMT);
            this.Controls.Add(this.panelMI);
            this.Controls.Add(this.panelT);
            this.Name = "FZB_行政区划";
            this.Load += new System.EventHandler(this.BZ_行政区划_Load);
            this.panelT.ResumeLayout(false);
            this.panelMT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DingnuoControlLibrary.DBTreeView dtvTreeView;
        private System.Windows.Forms.Panel panelMB;
        private System.Windows.Forms.Panel panelMR;
        private System.Windows.Forms.Panel panelT;
        private System.Windows.Forms.Button Btn刷新;
        private System.Windows.Forms.Button Btn修改;
        private System.Windows.Forms.Button Btn删除;
        private System.Windows.Forms.Button Btn增加;
        private System.Windows.Forms.Button Btn关闭;
        private System.Windows.Forms.Panel panelMT;
        private System.Windows.Forms.Label Lbl标题;
        private System.Windows.Forms.Panel panelMI;
        private System.Windows.Forms.ImageList iglTree;
    }
}