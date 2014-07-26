using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace GCGL_Client.OCC
{
    public partial class OCC_处置申请_Print : Form
    {
        public OCC_处置申请_Print()
        {
            InitializeComponent();
            //
            this.RowCount = 0;
        }

        public void Print(string APrinterName = "")
        {
            var prt = new Prt_Printer_CZ();
            prt.SetPrintParam(APrinterName);
            //
            while (this.RowCount < 5)
            {
                this.AddRow(null);
            }

            prt.Print(this);
        }

        public int RowCount { get; set; }

        private int iRowH = 37;

        private int iTop = 0;

        private int SL = 0;//数量合计参数
        private decimal YZ = 0;//账面原值参数
        //private decimal JZ = 0;//账面净值参数
        private decimal PG = 0;//评估价值参数

        public bool AddRow(DataRow row)
        {
            this.RowCount++;
            //AppServer.ShowMsg("rowcount=" + this.RowCount.ToString());
            //
            if (this.RowCount == 1)
            {
                this.lbl序号_R1.Text = this.RowCount.ToString();
                if (row != null)
                {
                    this.lbl资产名称_R1.Text = row["资产名称"].ToString();
                    this.lbl规格型号_R1.Text = row["规格型号"].ToString();
                    this.lbl计量单位_R1.Text = row["计量单位"].ToString();
                    this.lbl数量_R1.Text = "1";
                    this.lbl建造日期_R1.Text = string.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(row["取得日期"].ToString()));
                    this.lbl账面原值_R1.Text = string.Format("{0:0.00}", Convert.ToDecimal(row["价值"].ToString()));
                    this.lbl账面净值_R1.Text = "";//单位手填
                    this.lbl评估价值_R1.Text = string.Format("{0:0.00}", Convert.ToDecimal(row["评估价值"].ToString()));
                    this.lbl处置形式_R1.Text = row["处置形式名称"].ToString();
                    this.lbl所附依据_R1.Text = "";
                    if(this.lbl数量_R1.Text!="")SL += Convert.ToInt32(this.lbl数量_R1.Text);
                    if (this.lbl账面原值_R1.Text!="") YZ += Convert.ToDecimal(this.lbl账面原值_R1.Text);
                    if (this.lbl评估价值_R1.Text!="") PG += Convert.ToDecimal(this.lbl评估价值_R1.Text);
                }
            }
            else
            {
                this.Height = this.Height + iRowH;
                iTop = iTop + iRowH;
                //序号
                Label lblXH = new Label();
                lblXH.Name = string.Format("lbl序号_R{0}", this.RowCount);
                this.CloneLabel(lblXH, this.lbl序号_R1);
                lblXH.Top = lblXH.Top + iTop;
                //资产名称
                Label lblZCMC = new Label();
                lblZCMC.Name = string.Format("lbl资产名称_R{0}", this.RowCount);
                this.CloneLabel(lblZCMC, this.lbl资产名称_R1);
                lblZCMC.Top = lblZCMC.Top + iTop;
                //规格型号
                Label lblGGXH = new Label();
                lblGGXH.Name = string.Format("lbl规格型号_R{0}", this.RowCount);
                this.CloneLabel(lblGGXH, this.lbl规格型号_R1);
                lblGGXH.Top = lblGGXH.Top + iTop;
                //计量单位
                Label lblJLDW = new Label();
                lblJLDW.Name = string.Format("lbl计量单位_R{0}", this.RowCount);
                this.CloneLabel(lblJLDW, this.lbl计量单位_R1);
                lblJLDW.Top = lblJLDW.Top + iTop;
                //数量
                Label lblSL = new Label();
                lblSL.Name = string.Format("lbl数量_R{0}", this.RowCount);
                this.CloneLabel(lblSL, this.lbl数量_R1);
                lblSL.Top = lblSL.Top + iTop;
                //建造日期
                Label lblJZRQ = new Label();
                lblJZRQ.Name = string.Format("lbl建造日期_R{0}", this.RowCount);
                this.CloneLabel(lblJZRQ, this.lbl建造日期_R1);
                lblJZRQ.Top = lblJZRQ.Top + iTop;
                //账面原值
                Label lblZMYZ = new Label();
                lblZMYZ.Name = string.Format("lbl账面原值_R{0}", this.RowCount);
                this.CloneLabel(lblZMYZ, this.lbl账面原值_R1);
                lblZMYZ.Top = lblZMYZ.Top + iTop;
                //账面净值
                Label lblZMJZ = new Label();
                lblZMJZ.Name = string.Format("lbl账面净值_R{0}", this.RowCount);
                this.CloneLabel(lblZMJZ, this.lbl账面净值_R1);
                lblZMJZ.Top = lblZMJZ.Top + iTop;
                //评估价值
                Label lblPGJZ = new Label();
                lblPGJZ.Name = string.Format("lbl评估价值_R{0}", this.RowCount);
                this.CloneLabel(lblPGJZ, this.lbl评估价值_R1);
                lblPGJZ.Top = lblPGJZ.Top + iTop;
                //处置形式
                Label lblCZXS = new Label();
                lblCZXS.Name = string.Format("lbl处置形式_R{0}", this.RowCount);
                this.CloneLabel(lblCZXS, this.lbl处置形式_R1);
                lblCZXS.Top = lblCZXS.Top + iTop;
                //所附依据
                Label lblSFYJ = new Label();
                lblSFYJ.Name = string.Format("lbl所附依据_R{0}", this.RowCount);
                this.CloneLabel(lblSFYJ, this.lbl所附依据_R1);
                lblSFYJ.Top = lblSFYJ.Top + iTop;

                lblXH.Text = this.RowCount.ToString();
                if (row != null)
                {
                    lblZCMC.Text = row["资产名称"].ToString();
                    lblGGXH.Text = row["规格型号"].ToString();
                    lblJLDW.Text = row["计量单位"].ToString();
                    lblSL.Text = "1";
                    lblJZRQ.Text = string.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(row["取得日期"].ToString()));
                    lblZMYZ.Text = string.Format("{0:0.00}", Convert.ToDecimal(row["价值"].ToString()));
                    lblZMJZ.Text = "";//单位手填
                    lblPGJZ.Text = string.Format("{0:0.00}", Convert.ToDecimal(row["评估价值"].ToString()));
                    lblCZXS.Text = row["处置形式名称"].ToString();
                    lblSFYJ.Text = "";
                }
                else
                {
                    lblZCMC.Text = "";
                    lblGGXH.Text = "";
                    lblJLDW.Text = "";
                    lblSL.Text = "";
                    lblJZRQ.Text = "";
                    lblZMYZ.Text = "";
                    lblZMJZ.Text = "";//单位手填
                    lblPGJZ.Text = "";
                    lblCZXS.Text = "";
                    lblSFYJ.Text = "";
                }

                if (lblSL.Text!="") SL += Convert.ToInt32(lblSL.Text);
                if (lblZMYZ.Text!="") YZ += Convert.ToDecimal(lblZMYZ.Text);
                // JZ += Convert.ToDecimal(lblZMJZ.Text);
                if(lblPGJZ.Text!="")PG += Convert.ToDecimal(lblPGJZ.Text);

                this.lbl数量_HJ.Text = Convert.ToString(SL);
                this.lbl账面原值_HJ.Text = Convert.ToString(YZ);
                this.lbl账面净值_HJ.Text = "";
                this.lbl评估价值_HJ.Text = Convert.ToString(PG);

                //行线
                Label lblLine = new Label();
                lblLine.Name = string.Format("lblLine_R{0}", this.RowCount);
                lblLine.Parent = this;
                lblLine.Visible = true;
                lblLine.Text = "";
                lblLine.BorderStyle = BorderStyle.FixedSingle;
                lblLine.Width = this.lblLine_R1.Width;
                lblLine.Height = this.lblLine_R1.Height;
                lblLine.Top = this.lblLine_R1.Top + iTop;
                lblLine.Left = this.lblLine_R1.Left;
            }   
            //
            return true;
        }

        private void CloneLabel(Label labOld, Label lblNew)
        {
            labOld.Parent = this;
            labOld.Visible = true;
            labOld.Font = lblNew.Font;
            labOld.ForeColor = lblNew.ForeColor;
            labOld.TextAlign = lblNew.TextAlign;
            labOld.AutoSize = lblNew.AutoSize;
            labOld.Width = lblNew.Width;
            labOld.Height = lblNew.Height;
            labOld.Top = lblNew.Top;
            labOld.Left = lblNew.Left;
        }
    }


    class Prt_Printer_CZ
    {
        //
        OCC_处置申请_Print _PrintForm = null;
        //
        PrintDocument _printDoc = null;
        //
        int pageHeight = 0;
        int pageWidth = 0;
        int printWidth = 0;
        int printHeight = 0;

        /// <summary>
        /// Page margins
        /// </summary>
        public Margins PrintMargins
        {
            get { return PageSettings.Margins; }
            set { PageSettings.Margins = value; }
        }

        /// <summary>
        /// Expose the printdocument default page settings to the caller
        /// </summary>
        public PageSettings PageSettings
        {
            get { return _printDoc.DefaultPageSettings; }
        }

        public Prt_Printer_CZ()
        {
            _printDoc = new PrintDocument();
            _printDoc.OriginAtMargins = false;
            _printDoc.PrintPage += new PrintPageEventHandler(OnPrinting);
        }

        public void Print(OCC_处置申请_Print APrintForm)
        {
            _PrintForm = APrintForm;
            //
            _printDoc.Print();
        }

        /// <summary>
        /// 设置打印参数
        /// </summary>
        public void SetPrintParam(string APrinterName = "")
        {
            if (!string.IsNullOrWhiteSpace(APrinterName)) _printDoc.DefaultPageSettings.PrinterSettings.PrinterName = APrinterName;
            //
            _printDoc.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.A4;

            _printDoc.DefaultPageSettings.Landscape = true;

            _printDoc.DefaultPageSettings.Margins.Left = Convert.ToInt32(150 / 2.54);
            _printDoc.DefaultPageSettings.Margins.Right = Convert.ToInt32(100 / 2.54);
            _printDoc.DefaultPageSettings.Margins.Top = Convert.ToInt32(200 / 2.54);
            _printDoc.DefaultPageSettings.Margins.Bottom = Convert.ToInt32(100 / 2.54);

            int hardx = (int)Math.Round(_printDoc.DefaultPageSettings.HardMarginX);
            int hardy = (int)Math.Round(_printDoc.DefaultPageSettings.HardMarginY);
            int printareawidth;
            if (_printDoc.DefaultPageSettings.Landscape)
                printareawidth = (int)Math.Round(_printDoc.DefaultPageSettings.PrintableArea.Height);
            else
                printareawidth = (int)Math.Round(_printDoc.DefaultPageSettings.PrintableArea.Width);

            // set the print area we're working within
            pageHeight = _printDoc.DefaultPageSettings.Bounds.Height;
            pageWidth = _printDoc.DefaultPageSettings.Bounds.Width;

            // Set the printable area: margins and pagewidth
            PrintMargins = _printDoc.DefaultPageSettings.Margins;
            // adjust for when the margins are less than the printer's hard x/y limits
            PrintMargins.Right = (hardx > PrintMargins.Right) ? hardx : PrintMargins.Right;
            PrintMargins.Left = (hardx > PrintMargins.Left) ? hardx : PrintMargins.Left;
            PrintMargins.Top = (hardy > PrintMargins.Top) ? hardy : PrintMargins.Top;
            PrintMargins.Bottom = (hardy > PrintMargins.Bottom) ? hardy : PrintMargins.Bottom;

            // Now, we can calc default print width, again, respecting the printer's limitations
            printWidth = pageWidth - PrintMargins.Left - PrintMargins.Right;
            printWidth = (printWidth > printareawidth) ? printareawidth : printWidth;
            printHeight = pageHeight - PrintMargins.Top - PrintMargins.Bottom;
        }

        /// <summary>
        /// 绘制主调用函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPrinting(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (_PrintForm == null)
            {
                e.Graphics.DrawString("报告主人,没有发现要打印的Form啊!", new Font("宋体", 11), new SolidBrush(Color.Black), printWidth / 2, printHeight / 2);
                return;
            }
            //
            float x = 0;
            float y = 0;
            foreach (Control ctrl in _PrintForm.Controls)
            {
                //if (!ctrl.Visible) continue;
                if (ctrl is Label)
                {
                    Label label = ctrl as Label;
                    //if (!(ctrl as Label).Visible) continue;
                    x = PrintMargins.Left + ctrl.Left / _PrintForm.CreateGraphics().DpiX * 100;
                    y = PrintMargins.Top + ctrl.Top / _PrintForm.CreateGraphics().DpiY * 100;
                    //
                    if (!label.AutoSize)
                    {
                        if (label.BorderStyle == BorderStyle.FixedSingle)
                        {
                            int x1 = Convert.ToInt32(x);
                            int y1 = Convert.ToInt32(y);
                            int x2; int y2;
                            if (label.Height == 1 && label.Width > 1)
                            {

                                x2 = x1 + (int)(label.Width / _PrintForm.CreateGraphics().DpiX * 100); ;
                                // Draw line to screen.
                                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), x1, y1, x2, y1);
                            }
                            else if (label.Width == 1 && label.Height > 1)
                            {
                                y2 = y1 + (int)(label.Height / _PrintForm.CreateGraphics().DpiX * 100); ;
                                e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), x1, y1, x1, y2);
                            }
                            else
                            {
                                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), x, y, label.Width, label.Height);
                            }
                        }

                        if (!string.IsNullOrWhiteSpace(label.Text))
                        {
                            RectangleF printrect = new RectangleF(x, y, ctrl.Width / _PrintForm.CreateGraphics().DpiX * 100, ctrl.Height / _PrintForm.CreateGraphics().DpiY * 100);

                            StringFormat printformat = new StringFormat();
                            if ((ctrl as Label).TextAlign == ContentAlignment.TopRight || (ctrl as Label).TextAlign == ContentAlignment.MiddleRight || (ctrl as Label).TextAlign == ContentAlignment.BottomRight)
                            {
                                printformat.Alignment = StringAlignment.Far;
                            }
                            else if ((ctrl as Label).TextAlign == ContentAlignment.TopCenter || (ctrl as Label).TextAlign == ContentAlignment.MiddleCenter || (ctrl as Label).TextAlign == ContentAlignment.BottomCenter)
                            {
                                printformat.Alignment = StringAlignment.Center;
                            }
                            else
                            {
                                printformat.Alignment = StringAlignment.Near;
                            }
                            //
                            e.Graphics.DrawString(ctrl.Text, ctrl.Font, new SolidBrush(ctrl.ForeColor), printrect, printformat);
                        }
                    }
                    else
                    {
                        e.Graphics.DrawString(ctrl.Text, ctrl.Font, new SolidBrush(ctrl.ForeColor), x, y);
                    }
                }
            }
        }

    }

}
