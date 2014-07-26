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

namespace GCGL_Client.COS
{
    public partial class COS_超编车辆_导入 : Form
    {
        public COS_超编车辆_导入()
        {
            InitializeComponent();
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
                //this.GetSheetList();
                this.OpenFile(this.txtEXCELFile.Text, this.workbookView);
            }
        }
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
                var model = new Ref_WS_GCGL.DataType_OCC_公车入库();
                model.ExAction = "Add_DR";
                model.LoginUserCode = AppServer.LoginUserCode;
                model.忽略重复 = this.chk忽略重复.Checked;

                for (int iR = iBeginRow; iR < iRowCount; iR++)
                {
                    for (int iC = 0; iC < iColCount; iC++)
                    {
                        string sText = this.GetText(iR, iC);
                        switch (iC)
                        {
                            case 1: model.单位名称 = sText;break;
                            case 3: model.财政资产编号 = sText; break;
                            case 4: model.车辆类型编码 = sText; break;
                            case 6: model.资产名称 = sText; break;
                            case 7: model.规格型号 = sText; break;
                            case 8: model.厂牌型号 = sText; break;
                            case 9: model.计量单位 = sText; break;
                            case 10: model.取得方式 = sText; break;
                            case 11: model.取得日期 = sText.ToDateTimeDef(); break;
                            case 12: model.采购形式名称 = sText; break;
                            case 13: model.使用年限 = sText.ToIntegerDef(); break;
                            case 14: model.保修截止日期 = sText.ToDateTimeDef(); break;
                            case 15: model.使用日期 = sText.ToDateTimeDef(); break;
                            case 16: model.车辆产地 = sText; break;
                            case 17: model.车牌号 = sText; break;
                            case 18: model.发动机号 = sText; break;
                            case 19: model.车架号 = sText; break;
                            case 20: model.排气量 = sText; break;
                            case 21: model.资产类别名称 = sText; break;
                            case 22: model.价值类型 = sText; break;
                            case 23: model.价值 = sText.ToDecimalDef(); break;
                            case 29: model.会计凭证号 = sText; break;
                            case 30: model.折旧状态 = sText; break;
                            case 32: model.处室名称 = sText; break;
                            case 33: model.超编状态 = sText; break;
                        }
                    }
                    //
                    if (model.财政资产编号.Length > 0)
                    {
                        AppServer.wcfClient.COS_车辆超编_Edit(ref model);
                        if (model.ExResult == 0)
                        {
                            this.txtLog.AppendText(string.Format("--导入{0}.{1}  ", iR + 1, model.财政资产编号));
                            iCount_CG++;
                        }
                        else if (model.ExResult == 92)
                        {
                            this.txtLog.AppendText(string.Format("--忽略{0}.{1}  ", iR + 1, model.财政资产编号));
                            iCount_HL++;
                        }
                        else if (model.ExResult != 0)
                        {
                            AppServer.ShowMsg_SubmitError(model.ErrorMsg);
                            return;
                        }
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
                this.DialogResult = DialogResult.OK;
        }
    }
}
