namespace GCGL_Client.Main
{
    partial class Man_UserMngr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Man_UserMngr));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn分管 = new System.Windows.Forms.Button();
            this.btnUser_Del = new System.Windows.Forms.Button();
            this.btnUser_Rgt = new System.Windows.Forms.Button();
            this.btnUser_Mod = new System.Windows.Forms.Button();
            this.btnUser_Add = new System.Windows.Forms.Button();
            this.btn打印 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dbTreeView = new DingnuoControlLibrary.DBTreeView();
            this.iglTree = new System.Windows.Forms.ImageList(this.components);
            this.splitter = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dbGridView = new System.Windows.Forms.DataGridView();
            this.UserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobiPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.权限角色 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPswd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.处室名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn重置密码 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn重置密码);
            this.panel1.Controls.Add(this.btn分管);
            this.panel1.Controls.Add(this.btnUser_Del);
            this.panel1.Controls.Add(this.btnUser_Rgt);
            this.panel1.Controls.Add(this.btnUser_Mod);
            this.panel1.Controls.Add(this.btnUser_Add);
            this.panel1.Controls.Add(this.btn打印);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 30);
            this.panel1.TabIndex = 50;
            // 
            // btn分管
            // 
            this.btn分管.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn分管.Location = new System.Drawing.Point(399, 0);
            this.btn分管.Name = "btn分管";
            this.btn分管.Size = new System.Drawing.Size(84, 28);
            this.btn分管.TabIndex = 6;
            this.btn分管.Text = "部门分管(&K)";
            this.btn分管.UseVisualStyleBackColor = true;
            this.btn分管.Visible = false;
            this.btn分管.Click += new System.EventHandler(this.btn分管_Click);
            // 
            // btnUser_Del
            // 
            this.btnUser_Del.BackColor = System.Drawing.SystemColors.Control;
            this.btnUser_Del.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUser_Del.Location = new System.Drawing.Point(307, 0);
            this.btnUser_Del.Name = "btnUser_Del";
            this.btnUser_Del.Size = new System.Drawing.Size(92, 28);
            this.btnUser_Del.TabIndex = 2;
            this.btnUser_Del.Text = "删除用户(&D)";
            this.btnUser_Del.UseVisualStyleBackColor = false;
            this.btnUser_Del.Click += new System.EventHandler(this.btnUser_Del_Click);
            // 
            // btnUser_Rgt
            // 
            this.btnUser_Rgt.BackColor = System.Drawing.SystemColors.Control;
            this.btnUser_Rgt.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUser_Rgt.Location = new System.Drawing.Point(184, 0);
            this.btnUser_Rgt.Name = "btnUser_Rgt";
            this.btnUser_Rgt.Size = new System.Drawing.Size(123, 28);
            this.btnUser_Rgt.TabIndex = 3;
            this.btnUser_Rgt.Text = "用户权限设置(&R)";
            this.btnUser_Rgt.UseVisualStyleBackColor = false;
            this.btnUser_Rgt.Click += new System.EventHandler(this.btnUser_Rgt_Click);
            // 
            // btnUser_Mod
            // 
            this.btnUser_Mod.BackColor = System.Drawing.SystemColors.Control;
            this.btnUser_Mod.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUser_Mod.Location = new System.Drawing.Point(92, 0);
            this.btnUser_Mod.Name = "btnUser_Mod";
            this.btnUser_Mod.Size = new System.Drawing.Size(92, 28);
            this.btnUser_Mod.TabIndex = 1;
            this.btnUser_Mod.Text = "修改用户(&M)";
            this.btnUser_Mod.UseVisualStyleBackColor = false;
            this.btnUser_Mod.Click += new System.EventHandler(this.btnUser_Mod_Click);
            // 
            // btnUser_Add
            // 
            this.btnUser_Add.BackColor = System.Drawing.SystemColors.Control;
            this.btnUser_Add.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUser_Add.Location = new System.Drawing.Point(0, 0);
            this.btnUser_Add.Name = "btnUser_Add";
            this.btnUser_Add.Size = new System.Drawing.Size(92, 28);
            this.btnUser_Add.TabIndex = 0;
            this.btnUser_Add.Text = "新建用户(&A)";
            this.btnUser_Add.UseVisualStyleBackColor = false;
            this.btnUser_Add.Click += new System.EventHandler(this.btnUser_Add_Click);
            // 
            // btn打印
            // 
            this.btn打印.BackColor = System.Drawing.SystemColors.Control;
            this.btn打印.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn打印.Location = new System.Drawing.Point(770, 0);
            this.btn打印.Name = "btn打印";
            this.btn打印.Size = new System.Drawing.Size(75, 28);
            this.btn打印.TabIndex = 4;
            this.btn打印.Text = "打印(&P)";
            this.btn打印.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(845, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭(&X)";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(922, 41);
            this.lblTitle.TabIndex = 246;
            this.lblTitle.Text = "用户管理";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dbTreeView
            // 
            this.dbTreeView.CheckBoxs = false;
            this.dbTreeView.CheckMode = DingnuoControlLibrary.CheckMode.None;
            this.dbTreeView.DataSource = null;
            this.dbTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.dbTreeView.HideSelection = false;
            this.dbTreeView.ImageIndex = 0;
            this.dbTreeView.ImageList = this.iglTree;
            this.dbTreeView.ItemHeight = 20;
            this.dbTreeView.Location = new System.Drawing.Point(0, 71);
            this.dbTreeView.MultiSelect = false;
            this.dbTreeView.Name = "dbTreeView";
            this.dbTreeView.NodeID = "机构编码";
            this.dbTreeView.NodePID = "上级编码";
            this.dbTreeView.NodeTitle = "机构名称";
            this.dbTreeView.SelectedImageIndex = 0;
            this.dbTreeView.SelectedNode = null;
            this.dbTreeView.Size = new System.Drawing.Size(211, 478);
            this.dbTreeView.TabIndex = 247;
            this.dbTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dbTreeView_NodeMouseClick);
            this.dbTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dbTreeView_NodeMouseDoubleClick);
            this.dbTreeView.TreeNodeCreated += new DingnuoControlLibrary.TreeNodeCreatedEventHandler(this.dbTreeView_TreeNodeCreated);
            // 
            // iglTree
            // 
            this.iglTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iglTree.ImageStream")));
            this.iglTree.TransparentColor = System.Drawing.Color.Fuchsia;
            this.iglTree.Images.SetKeyName(0, "arrowright_green16.bmp");
            this.iglTree.Images.SetKeyName(1, "stop_blue16.bmp");
            this.iglTree.Images.SetKeyName(2, "AddToFavorites.bmp");
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitter.Location = new System.Drawing.Point(211, 71);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(3, 478);
            this.splitter.TabIndex = 248;
            this.splitter.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dbGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(214, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 478);
            this.panel2.TabIndex = 249;
            // 
            // dbGridView
            // 
            this.dbGridView.AllowUserToAddRows = false;
            this.dbGridView.AllowUserToDeleteRows = false;
            this.dbGridView.AllowUserToResizeRows = false;
            this.dbGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dbGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dbGridView.ColumnHeadersHeight = 28;
            this.dbGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dbGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserCode,
            this.UserName,
            this.MobiPhone,
            this.WorkPhone,
            this.UserEmail,
            this.权限角色,
            this.UserPswd,
            this.RoleList,
            this.处室名称,
            this.UserType});
            this.dbGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbGridView.EnableHeadersVisualStyles = false;
            this.dbGridView.Location = new System.Drawing.Point(0, 0);
            this.dbGridView.MultiSelect = false;
            this.dbGridView.Name = "dbGridView";
            this.dbGridView.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dbGridView.RowHeadersWidth = 20;
            this.dbGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dbGridView.RowTemplate.Height = 20;
            this.dbGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbGridView.Size = new System.Drawing.Size(708, 478);
            this.dbGridView.TabIndex = 48;
            // 
            // UserCode
            // 
            this.UserCode.DataPropertyName = "UserCode";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.UserCode.DefaultCellStyle = dataGridViewCellStyle11;
            this.UserCode.HeaderText = "用户账号";
            this.UserCode.Name = "UserCode";
            this.UserCode.ReadOnly = true;
            this.UserCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserCode.Width = 120;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.UserName.DefaultCellStyle = dataGridViewCellStyle12;
            this.UserName.HeaderText = "姓名";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserName.Width = 120;
            // 
            // MobiPhone
            // 
            this.MobiPhone.DataPropertyName = "MobiPhone";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.MobiPhone.DefaultCellStyle = dataGridViewCellStyle13;
            this.MobiPhone.HeaderText = "手机";
            this.MobiPhone.Name = "MobiPhone";
            this.MobiPhone.ReadOnly = true;
            this.MobiPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WorkPhone
            // 
            this.WorkPhone.DataPropertyName = "WorkPhone";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.WorkPhone.DefaultCellStyle = dataGridViewCellStyle14;
            this.WorkPhone.HeaderText = "电话";
            this.WorkPhone.Name = "WorkPhone";
            this.WorkPhone.ReadOnly = true;
            this.WorkPhone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserEmail
            // 
            this.UserEmail.DataPropertyName = "UserEmail";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.UserEmail.DefaultCellStyle = dataGridViewCellStyle15;
            this.UserEmail.HeaderText = "邮箱";
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.ReadOnly = true;
            this.UserEmail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserEmail.Width = 150;
            // 
            // 权限角色
            // 
            this.权限角色.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.权限角色.DataPropertyName = "权限角色";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.权限角色.DefaultCellStyle = dataGridViewCellStyle16;
            this.权限角色.HeaderText = "权限角色";
            this.权限角色.Name = "权限角色";
            this.权限角色.ReadOnly = true;
            this.权限角色.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserPswd
            // 
            this.UserPswd.DataPropertyName = "UserPswd";
            this.UserPswd.HeaderText = "UserPswd";
            this.UserPswd.Name = "UserPswd";
            this.UserPswd.ReadOnly = true;
            this.UserPswd.Visible = false;
            // 
            // RoleList
            // 
            this.RoleList.DataPropertyName = "RoleList";
            this.RoleList.HeaderText = "RoleList";
            this.RoleList.Name = "RoleList";
            this.RoleList.ReadOnly = true;
            this.RoleList.Visible = false;
            // 
            // 处室名称
            // 
            this.处室名称.DataPropertyName = "处室名称";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.处室名称.DefaultCellStyle = dataGridViewCellStyle17;
            this.处室名称.HeaderText = "所在处室";
            this.处室名称.Name = "处室名称";
            this.处室名称.ReadOnly = true;
            this.处室名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.处室名称.Width = 80;
            // 
            // UserType
            // 
            this.UserType.DataPropertyName = "UserType";
            this.UserType.HeaderText = "UserType";
            this.UserType.Name = "UserType";
            this.UserType.ReadOnly = true;
            this.UserType.Visible = false;
            // 
            // btn重置密码
            // 
            this.btn重置密码.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn重置密码.Location = new System.Drawing.Point(483, 0);
            this.btn重置密码.Name = "btn重置密码";
            this.btn重置密码.Size = new System.Drawing.Size(96, 28);
            this.btn重置密码.TabIndex = 7;
            this.btn重置密码.Text = "重置密码(&R)";
            this.btn重置密码.UseVisualStyleBackColor = true;
            this.btn重置密码.Visible = false;
            this.btn重置密码.Click += new System.EventHandler(this.btn重置密码_Click);
            // 
            // Man_UserMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.dbTreeView);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "Man_UserMngr";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.Man_UserMngr_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn打印;
        private DingnuoControlLibrary.DBTreeView dbTreeView;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.DataGridView dbGridView;
        private System.Windows.Forms.ImageList iglTree;
        private System.Windows.Forms.Button btnUser_Rgt;
        private System.Windows.Forms.Button btnUser_Mod;
        private System.Windows.Forms.Button btnUser_Del;
        private System.Windows.Forms.Button btnUser_Add;
        private System.Windows.Forms.Button btn分管;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobiPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn 权限角色;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPswd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleList;
        private System.Windows.Forms.DataGridViewTextBoxColumn 处室名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserType;
        private System.Windows.Forms.Button btn重置密码;
    }
}