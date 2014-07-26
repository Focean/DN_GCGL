namespace GCGL_Client.OCC
{
    partial class OCC_批量申请_Editor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn取消 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb预算单位 = new System.Windows.Forms.Label();
            this.btn添加 = new System.Windows.Forms.Button();
            this.btn确定 = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.cbx车辆类型名称 = new System.Windows.Forms.ComboBox();
            this.btn资产类别 = new System.Windows.Forms.Button();
            this.txt资产类别名称 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbx座位数 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx排气量 = new System.Windows.Forms.ComboBox();
            this.txt型号 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx车辆品牌 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.nud价格 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn附件查看 = new System.Windows.Forms.Button();
            this.btn附件管理 = new System.Windows.Forms.Button();
            this.txt附件信息 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx经费来源性质 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt配置原因 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt备注 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt经费来源 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn删除 = new System.Windows.Forms.Button();
            this.配置编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分配数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.接收数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.接收状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud价格)).BeginInit();
            this.SuspendLayout();
            // 
            // btn取消
            // 
            this.btn取消.Location = new System.Drawing.Point(133, 591);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(120, 28);
            this.btn取消.TabIndex = 17;
            this.btn取消.Text = "取消（&ESC）";
            this.btn取消.UseVisualStyleBackColor = true;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "分发列表：";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(-2, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "车辆分发";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(5, 583);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(540, 1);
            this.label15.TabIndex = 19;
            this.label15.Text = "label15";
            // 
            // lb预算单位
            // 
            this.lb预算单位.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb预算单位.Location = new System.Drawing.Point(0, -2);
            this.lb预算单位.Name = "lb预算单位";
            this.lb预算单位.Size = new System.Drawing.Size(552, 35);
            this.lb预算单位.TabIndex = 563;
            this.lb预算单位.Text = "车辆配置信息";
            this.lb预算单位.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn添加
            // 
            this.btn添加.Location = new System.Drawing.Point(450, 411);
            this.btn添加.Name = "btn添加";
            this.btn添加.Size = new System.Drawing.Size(79, 25);
            this.btn添加.TabIndex = 15;
            this.btn添加.Text = "添加(&A)";
            this.btn添加.UseVisualStyleBackColor = true;
            this.btn添加.Click += new System.EventHandler(this.btn添加_Click);
            // 
            // btn确定
            // 
            this.btn确定.Location = new System.Drawing.Point(300, 591);
            this.btn确定.Name = "btn确定";
            this.btn确定.Size = new System.Drawing.Size(120, 28);
            this.btn确定.TabIndex = 18;
            this.btn确定.Text = "确定（&Ctrl+S）";
            this.btn确定.UseVisualStyleBackColor = true;
            this.btn确定.Click += new System.EventHandler(this.btn确定_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeight = 28;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.配置编号,
            this.序号,
            this.单位编码,
            this.单位名称,
            this.分配数量,
            this.接收数量,
            this.接收状态});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(10, 436);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowHeadersWidth = 28;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(518, 139);
            this.dgvList.TabIndex = 16;
            // 
            // cbx车辆类型名称
            // 
            this.cbx车辆类型名称.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx车辆类型名称.FormattingEnabled = true;
            this.cbx车辆类型名称.Location = new System.Drawing.Point(362, 38);
            this.cbx车辆类型名称.Name = "cbx车辆类型名称";
            this.cbx车辆类型名称.Size = new System.Drawing.Size(166, 20);
            this.cbx车辆类型名称.TabIndex = 2;
            // 
            // btn资产类别
            // 
            this.btn资产类别.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn资产类别.Location = new System.Drawing.Point(227, 38);
            this.btn资产类别.Name = "btn资产类别";
            this.btn资产类别.Size = new System.Drawing.Size(21, 19);
            this.btn资产类别.TabIndex = 566;
            this.btn资产类别.Text = "…";
            this.btn资产类别.UseVisualStyleBackColor = true;
            this.btn资产类别.Click += new System.EventHandler(this.btn资产类别_Click);
            // 
            // txt资产类别名称
            // 
            this.txt资产类别名称.BackColor = System.Drawing.SystemColors.Control;
            this.txt资产类别名称.Location = new System.Drawing.Point(88, 37);
            this.txt资产类别名称.Name = "txt资产类别名称";
            this.txt资产类别名称.ReadOnly = true;
            this.txt资产类别名称.Size = new System.Drawing.Size(161, 21);
            this.txt资产类别名称.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 568;
            this.label10.Text = "资产类别：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(299, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 567;
            this.label17.Text = "车辆类型：";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx座位数
            // 
            this.cbx座位数.FormattingEnabled = true;
            this.cbx座位数.Location = new System.Drawing.Point(88, 104);
            this.cbx座位数.Name = "cbx座位数";
            this.cbx座位数.Size = new System.Drawing.Size(161, 20);
            this.cbx座位数.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 579;
            this.label3.Text = "座位数：";
            // 
            // cbx排气量
            // 
            this.cbx排气量.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx排气量.FormattingEnabled = true;
            this.cbx排气量.Location = new System.Drawing.Point(362, 105);
            this.cbx排气量.Name = "cbx排气量";
            this.cbx排气量.Size = new System.Drawing.Size(166, 20);
            this.cbx排气量.TabIndex = 6;
            // 
            // txt型号
            // 
            this.txt型号.Location = new System.Drawing.Point(362, 71);
            this.txt型号.Name = "txt型号";
            this.txt型号.Size = new System.Drawing.Size(166, 21);
            this.txt型号.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 578;
            this.label1.Text = "型  号：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx车辆品牌
            // 
            this.cbx车辆品牌.FormattingEnabled = true;
            this.cbx车辆品牌.Location = new System.Drawing.Point(88, 71);
            this.cbx车辆品牌.Name = "cbx车辆品牌";
            this.cbx车辆品牌.Size = new System.Drawing.Size(161, 20);
            this.cbx车辆品牌.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(219, 141);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 12);
            this.label18.TabIndex = 577;
            this.label18.Text = "万元";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud价格
            // 
            this.nud价格.DecimalPlaces = 2;
            this.nud价格.ForeColor = System.Drawing.Color.Blue;
            this.nud价格.Location = new System.Drawing.Point(88, 137);
            this.nud价格.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nud价格.Name = "nud价格";
            this.nud价格.Size = new System.Drawing.Size(123, 21);
            this.nud价格.TabIndex = 7;
            this.nud价格.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 576;
            this.label11.Text = "单    价：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 575;
            this.label9.Text = "排气量：\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 574;
            this.label8.Text = "车辆品牌：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn附件查看
            // 
            this.btn附件查看.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn附件查看.Location = new System.Drawing.Point(449, 232);
            this.btn附件查看.Name = "btn附件查看";
            this.btn附件查看.Size = new System.Drawing.Size(80, 23);
            this.btn附件查看.TabIndex = 12;
            this.btn附件查看.Text = "附件查看(&W)";
            this.btn附件查看.UseVisualStyleBackColor = true;
            this.btn附件查看.Click += new System.EventHandler(this.btn附件查看_Click);
            // 
            // btn附件管理
            // 
            this.btn附件管理.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn附件管理.Location = new System.Drawing.Point(370, 232);
            this.btn附件管理.Name = "btn附件管理";
            this.btn附件管理.Size = new System.Drawing.Size(80, 23);
            this.btn附件管理.TabIndex = 11;
            this.btn附件管理.Text = "附件管理(&F)";
            this.btn附件管理.UseVisualStyleBackColor = true;
            this.btn附件管理.Click += new System.EventHandler(this.btn附件管理_Click);
            // 
            // txt附件信息
            // 
            this.txt附件信息.BackColor = System.Drawing.SystemColors.Control;
            this.txt附件信息.Enabled = false;
            this.txt附件信息.ForeColor = System.Drawing.Color.Blue;
            this.txt附件信息.Location = new System.Drawing.Point(88, 233);
            this.txt附件信息.Name = "txt附件信息";
            this.txt附件信息.ReadOnly = true;
            this.txt附件信息.Size = new System.Drawing.Size(276, 21);
            this.txt附件信息.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(47, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 12);
            this.label12.TabIndex = 582;
            this.label12.Text = "附件：";
            // 
            // cbx经费来源性质
            // 
            this.cbx经费来源性质.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx经费来源性质.FormattingEnabled = true;
            this.cbx经费来源性质.Items.AddRange(new object[] {
            "自筹资金",
            "年初预算",
            "年度追加",
            "年度结余"});
            this.cbx经费来源性质.Location = new System.Drawing.Point(362, 138);
            this.cbx经费来源性质.Name = "cbx经费来源性质";
            this.cbx经费来源性质.Size = new System.Drawing.Size(166, 20);
            this.cbx经费来源性质.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 585;
            this.label6.Text = "资金来源：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt配置原因
            // 
            this.txt配置原因.Location = new System.Drawing.Point(88, 267);
            this.txt配置原因.Multiline = true;
            this.txt配置原因.Name = "txt配置原因";
            this.txt配置原因.Size = new System.Drawing.Size(440, 52);
            this.txt配置原因.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 588;
            this.label16.Text = "配置原因：";
            // 
            // txt备注
            // 
            this.txt备注.Location = new System.Drawing.Point(88, 332);
            this.txt备注.Multiline = true;
            this.txt备注.Name = "txt备注";
            this.txt备注.Size = new System.Drawing.Size(440, 52);
            this.txt备注.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 587;
            this.label5.Text = "备 注：";
            // 
            // txt经费来源
            // 
            this.txt经费来源.BackColor = System.Drawing.Color.White;
            this.txt经费来源.Location = new System.Drawing.Point(88, 171);
            this.txt经费来源.Multiline = true;
            this.txt经费来源.Name = "txt经费来源";
            this.txt经费来源.Size = new System.Drawing.Size(440, 49);
            this.txt经费来源.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(25, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 30);
            this.label14.TabIndex = 591;
            this.label14.Text = "资金来源      项目：";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(2, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(545, 1);
            this.label7.TabIndex = 592;
            this.label7.Text = "label7";
            // 
            // btn删除
            // 
            this.btn删除.Location = new System.Drawing.Point(372, 411);
            this.btn删除.Name = "btn删除";
            this.btn删除.Size = new System.Drawing.Size(79, 25);
            this.btn删除.TabIndex = 593;
            this.btn删除.Text = "删除(&D)";
            this.btn删除.UseVisualStyleBackColor = true;
            this.btn删除.Click += new System.EventHandler(this.btn删除_Click);
            // 
            // 配置编号
            // 
            this.配置编号.DataPropertyName = "配置编号";
            this.配置编号.HeaderText = "配置编号";
            this.配置编号.Name = "配置编号";
            this.配置编号.ReadOnly = true;
            this.配置编号.Visible = false;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "序号";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.序号.Width = 50;
            // 
            // 单位编码
            // 
            this.单位编码.DataPropertyName = "单位编码";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.单位编码.DefaultCellStyle = dataGridViewCellStyle2;
            this.单位编码.HeaderText = "单位编码";
            this.单位编码.Name = "单位编码";
            this.单位编码.ReadOnly = true;
            this.单位编码.Visible = false;
            // 
            // 单位名称
            // 
            this.单位名称.DataPropertyName = "单位名称";
            this.单位名称.HeaderText = "单位名称";
            this.单位名称.Name = "单位名称";
            this.单位名称.ReadOnly = true;
            this.单位名称.Width = 180;
            // 
            // 分配数量
            // 
            this.分配数量.DataPropertyName = "分配数量";
            this.分配数量.HeaderText = "分配数量(台)";
            this.分配数量.Name = "分配数量";
            this.分配数量.ReadOnly = true;
            this.分配数量.Width = 110;
            // 
            // 接收数量
            // 
            this.接收数量.DataPropertyName = "接收数量";
            this.接收数量.HeaderText = "接收数量(台)";
            this.接收数量.Name = "接收数量";
            this.接收数量.ReadOnly = true;
            // 
            // 接收状态
            // 
            this.接收状态.DataPropertyName = "接收状态";
            this.接收状态.HeaderText = "接收状态";
            this.接收状态.Name = "接收状态";
            this.接收状态.ReadOnly = true;
            // 
            // OCC_批量申请_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(548, 623);
            this.Controls.Add(this.btn删除);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn添加);
            this.Controls.Add(this.txt经费来源);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt配置原因);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt备注);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx经费来源性质);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn附件查看);
            this.Controls.Add(this.btn附件管理);
            this.Controls.Add(this.txt附件信息);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbx座位数);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx排气量);
            this.Controls.Add(this.txt型号);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx车辆品牌);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.nud价格);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbx车辆类型名称);
            this.Controls.Add(this.btn资产类别);
            this.Controls.Add(this.txt资产类别名称);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn确定);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.lb预算单位);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OCC_批量申请_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud价格)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb预算单位;
        private System.Windows.Forms.Button btn添加;
        private System.Windows.Forms.Button btn确定;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ComboBox cbx车辆类型名称;
        private System.Windows.Forms.Button btn资产类别;
        private System.Windows.Forms.TextBox txt资产类别名称;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbx座位数;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx排气量;
        private System.Windows.Forms.TextBox txt型号;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx车辆品牌;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nud价格;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn附件查看;
        private System.Windows.Forms.Button btn附件管理;
        private System.Windows.Forms.TextBox txt附件信息;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbx经费来源性质;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt配置原因;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt备注;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt经费来源;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn删除;
        private System.Windows.Forms.DataGridViewTextBoxColumn 配置编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分配数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 接收数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 接收状态;
    }
}