namespace GCGL_Client.FZB
{
    partial class FZB_公车编制数_导入
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FZB_公车编制数_导入));
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
            // chk栏目标题
            // 
            this.chk栏目标题.AutoSize = true;
            this.chk栏目标题.Checked = true;
            this.chk栏目标题.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk栏目标题.Location = new System.Drawing.Point(674, 331);
            this.chk栏目标题.Name = "chk栏目标题";
            this.chk栏目标题.Size = new System.Drawing.Size(126, 16);
            this.chk栏目标题.TabIndex = 1;
            this.chk栏目标题.Text = "第 1 行为栏目标题";
            this.chk栏目标题.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(11, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(659, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "注意：导入EXCEL表的栏目顺序为：单位名称，一般公务用车编制数，一般执法执勤用车编制数，特种专业技术用车编制数。";
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
            this.workbookView.Location = new System.Drawing.Point(13, 62);
            this.workbookView.Name = "workbookView";
            this.workbookView.Size = new System.Drawing.Size(789, 241);
            this.workbookView.TabIndex = 21;
            this.workbookView.WorkbookSetState = resources.GetString("workbookView.WorkbookSetState");
            // 
            // txtLog
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.ForeColor = System.Drawing.Color.Blue;
            this.txtLog.Location = new System.Drawing.Point(13, 358);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(789, 65);
            this.txtLog.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "导入日志：";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(691, 433);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "返回(&R)";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btn开始导入
            // 
            this.btn开始导入.Location = new System.Drawing.Point(564, 433);
            this.btn开始导入.Name = "btn开始导入";
            this.btn开始导入.Size = new System.Drawing.Size(108, 33);
            this.btn开始导入.TabIndex = 2;
            this.btn开始导入.Text = "开始导入(&I)";
            this.btn开始导入.UseVisualStyleBackColor = true;
            this.btn开始导入.Click += new System.EventHandler(this.btn开始导入_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "请选择一个要导入的EXCEL文件：";
            // 
            // txtEXCELFile
            // 
            this.txtEXCELFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEXCELFile.Location = new System.Drawing.Point(13, 33);
            this.txtEXCELFile.Name = "txtEXCELFile";
            this.txtEXCELFile.ReadOnly = true;
            this.txtEXCELFile.Size = new System.Drawing.Size(753, 21);
            this.txtEXCELFile.TabIndex = 15;
            // 
            // btn选择文件
            // 
            this.btn选择文件.Location = new System.Drawing.Point(772, 31);
            this.btn选择文件.Name = "btn选择文件";
            this.btn选择文件.Size = new System.Drawing.Size(30, 23);
            this.btn选择文件.TabIndex = 0;
            this.btn选择文件.Text = "…";
            this.btn选择文件.UseVisualStyleBackColor = true;
            this.btn选择文件.Click += new System.EventHandler(this.btn选择文件_Click);
            // 
            // FZB_公车编制数_导入
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 484);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FZB_公车编制数_导入";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FZB_公车编制_导入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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