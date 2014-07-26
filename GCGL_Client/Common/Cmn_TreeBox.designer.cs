namespace GCGL_Client.Common
{
    partial class Cmn_TreeBox
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
            this.dbTreeView = new DingnuoControlLibrary.DBTreeView();
            this.SuspendLayout();
            // 
            // dbTreeView
            // 
            this.dbTreeView.AutoScroll = true;
            this.dbTreeView.CheckBoxs = false;
            this.dbTreeView.CheckMode = DingnuoControlLibrary.CheckMode.None;
            this.dbTreeView.DataSource = null;
            this.dbTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbTreeView.HideSelection = false;
            this.dbTreeView.ImageIndex = -1;
            this.dbTreeView.ImageList = null;
            this.dbTreeView.ItemHeight = 22;
            this.dbTreeView.Location = new System.Drawing.Point(0, 0);
            this.dbTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.dbTreeView.MultiSelect = true;
            this.dbTreeView.Name = "dbTreeView";
            this.dbTreeView.NodeID = "";
            this.dbTreeView.NodePID = "";
            this.dbTreeView.NodeTitle = "";
            this.dbTreeView.SelectedImageIndex = -1;
            this.dbTreeView.SelectedNode = null;
            this.dbTreeView.Size = new System.Drawing.Size(306, 290);
            this.dbTreeView.TabIndex = 7;
            this.dbTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dbTreeView_NodeMouseDoubleClick);
            // 
            // Cmn_TreeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 290);
            this.Controls.Add(this.dbTreeView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cmn_TreeBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cmn_TreeBox";
            this.ResumeLayout(false);

        }

        #endregion

        private DingnuoControlLibrary.DBTreeView dbTreeView;
    }
}