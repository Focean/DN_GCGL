namespace GCGL_Client.OCC
{
    partial class OCC_配置申请_Select
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iglTree = new System.Windows.Forms.ImageList(this.components);
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btn取消 = new System.Windows.Forms.Button();
            this.btn下一步 = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.申请编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车辆品牌 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.排气量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.价格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.待入库数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车辆类型名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.车辆类型编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产类别名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.资产类别编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // iglTree
            // 
            this.iglTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iglTree.ImageSize = new System.Drawing.Size(16, 16);
            this.iglTree.TransparentColor = System.Drawing.Color.Fuchsia;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.申请编号,
            this.申请,
            this.申请序号,
            this.车辆品牌,
            this.型号,
            this.排气量,
            this.价格,
            this.待入库数量,
            this.创建时间,
            this.车辆类型名称,
            this.车辆类型编码,
            this.资产类别名称,
            this.资产类别编码});
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(12, 38);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(755, 341);
            this.dgvList.TabIndex = 269;
            // 
            // btn取消
            // 
            this.btn取消.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn取消.Location = new System.Drawing.Point(253, 390);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(110, 28);
            this.btn取消.TabIndex = 270;
            this.btn取消.Text = "取消(&ESC)";
            this.btn取消.UseVisualStyleBackColor = true;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // btn下一步
            // 
            this.btn下一步.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn下一步.Location = new System.Drawing.Point(415, 390);
            this.btn下一步.Name = "btn下一步";
            this.btn下一步.Size = new System.Drawing.Size(110, 28);
            this.btn下一步.TabIndex = 271;
            this.btn下一步.Text = "下一步(Ctrl+N)";
            this.btn下一步.UseVisualStyleBackColor = true;
            this.btn下一步.Click += new System.EventHandler(this.btn下一步_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.LblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblTitle.Location = new System.Drawing.Point(8, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(252, 21);
            this.LblTitle.TabIndex = 272;
            this.LblTitle.Text = "配置申请详细信息列表：";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(255, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 12);
            this.label1.TabIndex = 273;
            this.label1.Text = "请选择一个申请的资产后单击“下一步”进行入库信息登记";
            // 
            // 申请编号
            // 
            this.申请编号.DataPropertyName = "申请编号";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.申请编号.DefaultCellStyle = dataGridViewCellStyle2;
            this.申请编号.HeaderText = "申请编号";
            this.申请编号.Name = "申请编号";
            this.申请编号.ReadOnly = true;
            this.申请编号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.申请编号.Visible = false;
            // 
            // 申请
            // 
            this.申请.DataPropertyName = "申请编号1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.申请.DefaultCellStyle = dataGridViewCellStyle3;
            this.申请.HeaderText = "申请编号";
            this.申请.Name = "申请";
            this.申请.ReadOnly = true;
            this.申请.Width = 115;
            // 
            // 申请序号
            // 
            this.申请序号.DataPropertyName = "申请序号";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.申请序号.DefaultCellStyle = dataGridViewCellStyle4;
            this.申请序号.HeaderText = "序号";
            this.申请序号.Name = "申请序号";
            this.申请序号.ReadOnly = true;
            this.申请序号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.申请序号.Width = 40;
            // 
            // 车辆品牌
            // 
            this.车辆品牌.DataPropertyName = "车辆品牌";
            this.车辆品牌.HeaderText = "品牌";
            this.车辆品牌.Name = "车辆品牌";
            this.车辆品牌.ReadOnly = true;
            this.车辆品牌.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.车辆品牌.Width = 80;
            // 
            // 型号
            // 
            this.型号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.型号.DataPropertyName = "型号";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.型号.DefaultCellStyle = dataGridViewCellStyle5;
            this.型号.HeaderText = "型号";
            this.型号.MinimumWidth = 80;
            this.型号.Name = "型号";
            this.型号.ReadOnly = true;
            this.型号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 排气量
            // 
            this.排气量.DataPropertyName = "排气量";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N1";
            dataGridViewCellStyle6.NullValue = "0";
            this.排气量.DefaultCellStyle = dataGridViewCellStyle6;
            this.排气量.HeaderText = "排气量(L)";
            this.排气量.Name = "排气量";
            this.排气量.ReadOnly = true;
            this.排气量.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.排气量.Width = 80;
            // 
            // 价格
            // 
            this.价格.DataPropertyName = "价格";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0";
            this.价格.DefaultCellStyle = dataGridViewCellStyle7;
            this.价格.HeaderText = "价格(万元)";
            this.价格.Name = "价格";
            this.价格.ReadOnly = true;
            this.价格.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.价格.Width = 80;
            // 
            // 待入库数量
            // 
            this.待入库数量.DataPropertyName = "待入库数量";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.待入库数量.DefaultCellStyle = dataGridViewCellStyle8;
            this.待入库数量.HeaderText = "待入库数(台)";
            this.待入库数量.Name = "待入库数量";
            this.待入库数量.ReadOnly = true;
            this.待入库数量.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.待入库数量.Width = 90;
            // 
            // 创建时间
            // 
            this.创建时间.DataPropertyName = "创建时间";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.创建时间.DefaultCellStyle = dataGridViewCellStyle9;
            this.创建时间.HeaderText = "申请时间";
            this.创建时间.Name = "创建时间";
            this.创建时间.ReadOnly = true;
            this.创建时间.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.创建时间.Width = 90;
            // 
            // 车辆类型名称
            // 
            this.车辆类型名称.DataPropertyName = "车辆类型名称";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.车辆类型名称.DefaultCellStyle = dataGridViewCellStyle10;
            this.车辆类型名称.HeaderText = "车辆类型";
            this.车辆类型名称.Name = "车辆类型名称";
            this.车辆类型名称.ReadOnly = true;
            this.车辆类型名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.车辆类型名称.Width = 130;
            // 
            // 车辆类型编码
            // 
            this.车辆类型编码.DataPropertyName = "车辆类型编码";
            this.车辆类型编码.HeaderText = "车辆类型编码";
            this.车辆类型编码.Name = "车辆类型编码";
            this.车辆类型编码.ReadOnly = true;
            this.车辆类型编码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.车辆类型编码.Visible = false;
            // 
            // 资产类别名称
            // 
            this.资产类别名称.DataPropertyName = "资产类别名称";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.资产类别名称.DefaultCellStyle = dataGridViewCellStyle11;
            this.资产类别名称.HeaderText = "资产类别";
            this.资产类别名称.Name = "资产类别名称";
            this.资产类别名称.ReadOnly = true;
            this.资产类别名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 资产类别编码
            // 
            this.资产类别编码.DataPropertyName = "资产类别编码";
            this.资产类别编码.HeaderText = "资产类别编码";
            this.资产类别编码.Name = "资产类别编码";
            this.资产类别编码.ReadOnly = true;
            this.资产类别编码.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.资产类别编码.Visible = false;
            // 
            // OCC_配置申请_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.btn下一步);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.dgvList);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(558, 356);
            this.Name = "OCC_配置申请_Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.OCC_配置申请_Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList iglTree;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.Button btn下一步;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车辆品牌;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 排气量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 价格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 待入库数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车辆类型名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 车辆类型编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产类别名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 资产类别编码;
    }
}