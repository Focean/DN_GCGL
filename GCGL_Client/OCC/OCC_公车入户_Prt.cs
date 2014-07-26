using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace GCGL_Client.OCC
{
    public partial class OCC_公车入户_Prt : Form
    {
        public OCC_公车入户_Prt()
        {
            InitializeComponent();
        }
        public void Print(string APrinterName = "")
        {
            var prt = new Prt_Printer();
            prt.SetPrintParam(APrinterName);
            //第1页
            this.lbl联字显示.Text = "\n\n\n第\n一\n联\n \n省\n财\n政\n厅\n存\n查";
            prt.Print(this);
            //第2页
            this.lbl联字显示.Text = "\n\n第\n二\n联\n \n公\n安\n车\n管\n部\n门\n存\n查";
            prt.Print(this);
            //第3页
            this.lbl联字显示.Text = "\n\n\n第\n三\n联\n \n购\n车\n单\n位\n存\n查";
            prt.Print(this);
        }
        class Prt_Printer
        {
            //
            OCC_公车入户_Prt _PrintForm = null;
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

            public Prt_Printer()
            {
                _printDoc = new PrintDocument();
                _printDoc.OriginAtMargins = false;
                _printDoc.PrintPage += new PrintPageEventHandler(OnPrinting);
            }

            public void Print(OCC_公车入户_Prt APrintForm)
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
                _printDoc.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.A4;//设置纸张大小

                _printDoc.DefaultPageSettings.Landscape = true;//获取或设置一个值，该值指示是横向还是纵向打印该页。如果页面应横向打印，则为 true；反之，则为 false。默认值由打印机决定。

                _printDoc.DefaultPageSettings.Margins.Left = Convert.ToInt32(150 / 2.54);//获取或设置页设置
                _printDoc.DefaultPageSettings.Margins.Right = Convert.ToInt32(100 / 2.54);
                _printDoc.DefaultPageSettings.Margins.Top = Convert.ToInt32(300 / 2.54);
                _printDoc.DefaultPageSettings.Margins.Bottom = Convert.ToInt32(100 / 2.54);

                int hardx = (int)Math.Round(_printDoc.DefaultPageSettings.HardMarginX);//获取页面左侧硬边距的X坐标
                int hardy = (int)Math.Round(_printDoc.DefaultPageSettings.HardMarginY);//获取页面左侧硬边距的Y坐标
                int printareawidth;
                if (_printDoc.DefaultPageSettings.Landscape)
                    printareawidth = (int)Math.Round(_printDoc.DefaultPageSettings.PrintableArea.Height);//获取打印机的可打印页面区域的界限
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
}
    
