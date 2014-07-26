namespace GCGL_Client.Main
{
    partial class Man_单位_Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Man_单位_Select));
            this.btn选择 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.iglTree = new System.Windows.Forms.ImageList(this.components);
            this.dbTreeView = new DingnuoControlLibrary.DBTreeView();
            this.SuspendLayout();
            // 
            // btn选择
            // 
            this.btn选择.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn选择.Location = new System.Drawing.Point(366, 423);
            this.btn选择.Margin = new System.Windows.Forms.Padding(2);
            this.btn选择.Name = "btn选择";
            this.btn选择.Size = new System.Drawing.Size(90, 28);
            this.btn选择.TabIndex = 128;
            this.btn选择.Text = "选择(&S)";
            this.btn选择.UseVisualStyleBackColor = false;
            this.btn选择.Click += new System.EventHandler(this.btn选择_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(246, 423);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 28);
            this.btnCancel.TabIndex = 129;
            this.btnCancel.Text = "返回(&R)";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // iglTree
            // 
            this.iglTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iglTree.ImageStream")));
            this.iglTree.TransparentColor = System.Drawing.Color.Fuchsia;
            this.iglTree.Images.SetKeyName(0, "arrowright_green16.bmp");
            this.iglTree.Images.SetKeyName(1, "stop_blue16.bmp");
            this.iglTree.Images.SetKeyName(2, "AddToFavorites.bmp");
            // 
            // dbTreeView
            // 
            this.dbTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbTreeView.CheckBoxs = false;
            this.dbTreeView.CheckMode = DingnuoControlLibrary.CheckMode.None;
            this.dbTreeView.DataSource = null;
            this.dbTreeView.HideSelection = false;
            this.dbTreeView.ImageIndex = 0;
            this.dbTreeView.ImageList = this.iglTree;
            this.dbTreeView.ItemHeight = 20;
            this.dbTreeView.Location = new System.Drawing.Point(8, 9);
            this.dbTreeView.MultiSelect = true;
            this.dbTreeView.Name = "dbTreeView";
            this.dbTreeView.NodeID = "机构编码";
            this.dbTreeView.NodePID = "上级编码";
            this.dbTreeView.NodeTitle = "机构名称";
            this.dbTreeView.SelectedImageIndex = 0;
            this.dbTreeView.SelectedNode = null;
            this.dbTreeView.Size = new System.Drawing.Size(496, 405);
            this.dbTreeView.TabIndex = 248;
            this.dbTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dbTreeView_NodeMouseDoubleClick);
            this.dbTreeView.TreeNodeCreated += new DingnuoControlLibrary.TreeNodeCreatedEventHandler(this.dbTreeView_TreeNodeCreated);
            this.dbTreeView.DoubleClick += new System.EventHandler(this.dbTreeView_DoubleClick);
            this.dbTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dbTreeView_MouseDoubleClick);
            // 
            // Man_单位_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 458);
            this.Controls.Add(this.dbTreeView);
            this.Controls.Add(this.btn选择);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Man_单位_Select";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择单位";
            this.Load += new System.EventHandler(this.Man_单位_Select_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn选择;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ImageList iglTree;
        private DingnuoControlLibrary.DBTreeView dbTreeView;
    }
}