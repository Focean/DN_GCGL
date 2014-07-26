using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;
using TY.Helper;

namespace GCGL_Client.FZB
{
    public partial class FZB_公车编制数_导入 : Form
    {
        public FZB_公车编制数_导入()
        {
            InitializeComponent();
        }

        public delegate void UpdateGridView(int AIndex);
        public UpdateGridView OnUpdateGrid { get; set; }
        private SpreadsheetGear.Windows.Forms.WorkbookView FWorkBook;
        public bool OpenFile(string AFileName, Control AContainer)
        {
            //if (AContainer != null) { "目标容器对象不能为空!"}          
            // 耗时统计：计时开始
            //FTakeTime= GetTickCount;
            if (FWorkBook == null)
            {
                FWorkBook = (SpreadsheetGear.Windows.Forms.WorkbookView)AContainer;
            }
            this.FWorkBook.GetLock();
            try
            {
                SpreadsheetGear.IWorkbook workbook =
                    SpreadsheetGear.Factory.GetWorkbook(AFileName, System.Globalization.CultureInfo.CurrentCulture);

                this.FWorkBook.ActiveWorkbook = workbook;
            }
            finally
            {
                this.FWorkBook.ReleaseLock();
            }
            return true;
        }

        private SpreadsheetGear.IRange GetCell(int ARow, int ACol)
        {
            this.FWorkBook.GetLock();
            try
            {
                return FWorkBook.ActiveWorkbook.Worksheets[this.workbookView.ActiveTabIndex].Cells[ARow, ACol];
            }
            finally
            {
                this.FWorkBook.ReleaseLock();
            }
        }

        protected int GetRowCount()
        {
            this.FWorkBook.GetLock();
            try
            {
                return FWorkBook.ActiveWorkbook.Worksheets[this.workbookView.ActiveTabIndex].UsedRange.RowCount;
            }
            finally
            {
                this.FWorkBook.ReleaseLock();
            }
        }
        protected int GetColCount()
        {
            this.FWorkBook.GetLock();
            try
            {
                return FWorkBook.ActiveWorkbook.Worksheets[this.workbookView.ActiveTabIndex].UsedRange.ColumnCount;
            }
            finally
            {
                this.FWorkBook.ReleaseLock();
            }
        }

        protected string GetValue(int ARow, int ACol)
        {
            this.FWorkBook.GetLock();
            try
            {
                string sValue = "";

                if ((ARow > -1) && (ACol > -1))
                {
                    var cell = GetCell(ARow, ACol);
                    if (cell.Value != null) sValue = cell.Value.ToString();
                }
                return sValue;
            }
            finally
            {
                this.FWorkBook.ReleaseLock();
            }
        }

        protected string GetText(int ARow, int ACol)
        {
            FWorkBook.GetLock();
            try
            {
                string sValue = "";
                if ((ARow > -1) && (ACol > -1))
                {
                    var cell = GetCell(ARow, ACol);
                    if (cell != null) sValue = cell.Text.Trim();
                }
                return sValue;
            }
            finally
            {
                FWorkBook.ReleaseLock();
            }

        }
        private void btn选择文件_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "EXCEL文件|*.xlsx;*.xls";

            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtEXCELFile.Text = openFileDialog.FileName;
                this.OpenFile(this.txtEXCELFile.Text, this.workbookView);
            }
        }

        private void btn开始导入_Click(object sender, EventArgs e)
        {
            if (this.txtEXCELFile.Text == "")
            {
                AppServer.ShowMsg_Warn("请先选择要导入的EXCEL文件", "警告");
                this.txtEXCELFile.Focus();
                return;
            }
            int iCount_CG = 0;
            int iCount_HL = 0;

            // UI验证
            int iRowCount = 0;
            int iColCount = 0;
            int iBeginRow = 0;
            string SheetName = "";
            try
            {
                this.workbookView.GetLock();
                iRowCount = this.GetRowCount();
                iColCount = this.GetColCount();
                SheetName = this.workbookView.ActiveSheet.Name;
            }
            finally
            {
                this.workbookView.ReleaseLock();
            }
            if (iRowCount <= 1)
            {
                AppServer.ShowMsg_Warn("此工作表没有数据或数据只能一行的情况下不允许导入!");
                return;
            }
            //验证标题
            if (this.chk栏目标题.Checked)
            {
                for (int i = 0; i < iColCount; i++)
                {
                    string sCapt = this.GetText(0, i);
                }
                iBeginRow = 1;
            }
            else
            {
                if (!AppServer.DialogMsg("您已选择当前EXCEL表无首行栏目标题\n请注意栏目顺序是否正确！\n\n栏目顺序是否正确，开始导入？"))
                    return;
            }
            //开始导入
            try
            {
                if (!AppServer.WcfService_Open()) return;
                //
                var model = new Ref_WS_GCGL.DataType_CMN_单位_编制();
                model.ExAction = "Add_D";
                model.LoginUserCode = AppServer.LoginUserCode;

                for (int iR = iBeginRow; iR < iRowCount; iR++)
                {
                    for (int iC = 0; iC < iColCount; iC++)
                    {
                        string sText = this.GetText(iR, iC);
                        switch (iC)
                        {
                            case 0: model.单位名称= sText; break;
                            case 1: model.一般公务用车编制数 = Convert.ToInt32(sText); break;
                            case 2: model.一般执法执勤用车编制数 = Convert.ToInt32(sText); break;
                            case 3: model.特种专业技术用车编制数 = Convert.ToInt32(sText); break;
                            case 4: model.开始日期 = Convert.ToDateTime(sText); break;
                        }
                    }
                    //
                    AppServer.wcfClient.CMN_单位_编制_Edit(ref model);
                    if (model.ExResult == 0)
                    {
                        this.txtLog.AppendText(string.Format("--导入{0}.{1}  ", iR + 1, model.单位名称));
                        iCount_CG++;
                    }
                    else if (model.ExResult == 92)
                    {
                        this.txtLog.AppendText(string.Format("--忽略{0}.{1}  ", iR + 1, model.单位名称));
                        iCount_HL++;
                    }
                    else if (model.ExResult != 0)
                    {
                        AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg_ExceptError(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
            }

            if (AppServer.DialogMsg(string.Format("数据导入已完成，成功导入{0}条记录，重复忽略{1}条记录！\n是否立即返回到主界面？", iCount_CG, iCount_HL)))
            if (this.OnUpdateGrid != null) this.OnUpdateGrid(0);
            this.DialogResult = DialogResult.OK;
        }
    }
}
