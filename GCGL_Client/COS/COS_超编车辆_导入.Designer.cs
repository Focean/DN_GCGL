namespace GCGL_Client.COS
{
    partial class COS_超编车辆_导入
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COS_超编车辆_导入));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chk忽略重复 = new System.Windows.Forms.CheckBox();
            this.cbx单位编码 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk栏目标题 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.workbookView = new SpreadsheetGear.Windows.Forms.WorkbookView();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn开始导入 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEXCELFile = new System.Windows.Forms.TextBox();
            this.btn选择文件 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(92, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(647, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "、经费来源1、经费来源2、经费来源3、经费来源4、经费来源5、会计凭证号、折旧状态、使用状况、使用部门、处置情况";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(91, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(713, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "、采购组织形式、使用年限、保修截止日期、使用日期、车辆产地、车牌号、发动机号、车架号、排气量、用途分类、价值类型、价值";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(32, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(797, 12);
            this.label5.TabIndex = 31;
            this.label5.Text = "字段顺序：序号、所属单位、单据日期、资产编号、资产分类代码、资产分类名称、资产名称、规格型号、厂牌型号、计量单位、取得方式、取得日期";
            // 
            // chk忽略重复
            // 
            this.chk忽略重复.AutoSize = true;
            this.chk忽略重复.Checked = true;
            this.chk忽略重复.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk忽略重复.ForeColor = System.Drawing.Color.Fuchsia;
            this.chk忽略重复.Location = new System.Drawing.Point(289, 520);
            this.chk忽略重复.Name = "chk忽略重复";
            this.chk忽略重复.Size = new System.Drawing.Size(168, 16);
            this.chk忽略重复.TabIndex = 30;
            this.chk忽略重复.Text = "财政资产编号重复不再导入";
            this.chk忽略重复.UseVisualStyleBackColor = true;
            // 
            // cbx单位编码
            // 
            this.cbx单位编码.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx单位编码.Enabled = false;
            this.cbx单位编码.FormattingEnabled = true;
            this.cbx单位编码.Location = new System.Drawing.Point(107, 518);
            this.cbx单位编码.Name = "cbx单位编码";
            this.cbx单位编码.Size = new System.Drawing.Size(164, 20);
            this.cbx单位编码.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(32, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "导入数据到：";
            // 
            // chk栏目标题
            // 
            this.chk栏目标题.AutoSize = true;
            this.chk栏目标题.Checked = true;
            this.chk栏目标题.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk栏目标题.Location = new System.Drawing.Point(691, 304);
            this.chk栏目标题.Name = "chk栏目标题";
            this.chk栏目标题.Size = new System.Drawing.Size(126, 16);
            this.chk栏目标题.TabIndex = 27;
            this.chk栏目标题.Text = "第 1 行为栏目标题";
            this.chk栏目标题.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(30, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "注意：导入EXCEL表的栏目顺序与资产系统相一致。";
            // 
            // workbookView
            // 
            this.workbookView.AllowChartExplorer = false;
            this.workbookView.AllowEditCommands = false;
            this.workbookView.AllowRangeExplorer = false;
            this.workbookView.AllowShapeExplorer = false;
            this.workbookView.AllowWorkbookDesigner = false;
            this.workbookView.AllowWorkbookExplorer = false;
            this.workbookView.HollowSelection = true;
            this.workbookView.Location = new System.Drawing.Point(32, 57);
            this.workbookView.Name = "workbookView";
            this.workbookView.Size = new System.Drawing.Size(789, 241);
            this.workbookView.TabIndex = 25;
            this.workbookView.WorkbookSetState = resources.GetString("workbookView.WorkbookSetState");
            // 
            // txtLog
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.ForeColor = System.Drawing.Color.Blue;
            this.txtLog.Location = new System.Drawing.Point(32, 426);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(789, 86);
            this.txtLog.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "导入日志：";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(710, 522);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 33);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "返回(&R)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btn开始导入
            // 
            this.btn开始导入.Location = new System.Drawing.Point(583, 522);
            this.btn开始导入.Name = "btn开始导入";
            this.btn开始导入.Size = new System.Drawing.Size(108, 33);
            this.btn开始导入.TabIndex = 21;
            this.btn开始导入.Text = "开始导入(&I)";
            this.btn开始导入.UseVisualStyleBackColor = true;
            this.btn开始导入.Click += new System.EventHandler(this.btn开始导入_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "请选择一个要导入的EXCEL文件：";
            // 
            // txtEXCELFile
            // 
            this.txtEXCELFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEXCELFile.Location = new System.Drawing.Point(32, 28);
            this.txtEXCELFile.Name = "txtEXCELFile";
            this.txtEXCELFile.ReadOnly = true;
            this.txtEXCELFile.Size = new System.Drawing.Size(753, 21);
            this.txtEXCELFile.TabIndex = 19;
            // 
            // btn选择文件
            // 
            this.btn选择文件.Location = new System.Drawing.Point(791, 26);
            this.btn选择文件.Name = "btn选择文件";
            this.btn选择文件.Size = new System.Drawing.Size(30, 23);
            this.btn选择文件.TabIndex = 18;
            this.btn选择文件.Text = "…";
            this.btn选择文件.UseVisualStyleBackColor = true;
            this.btn选择文件.Click += new System.EventHandler(this.btn选择文件_Click);
            // 
            // COS_超编车辆_导入
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 568);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chk忽略重复);
            this.Controls.Add(this.cbx单位编码);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk栏目标题);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.workbookView);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn开始导入);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEXCELFile);
            this.Controls.Add(this.btn选择文件);
            this.Name = "COS_超编车辆_导入";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "COS_超编车辆_导入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk忽略重复;
        private System.Windows.Forms.ComboBox cbx单位编码;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk栏目标题;
        private System.Windows.Forms.Label label3;
        private SpreadsheetGear.Windows.Forms.WorkbookView workbookView;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btn开始导入;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEXCELFile;
        private System.Windows.Forms.Button btn选择文件;
    }
}