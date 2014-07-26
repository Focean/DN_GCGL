using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml;
using System.Data;
using System.Drawing;
using Microsoft.Win32;
using DingnuoControlLibrary;
using System.ServiceModel;
using GCGL_Client.Ref_WS_GCGL;
using GCGL_Client.Main;
using GCGL_Client.Common;
using GCGL_Client.OCC;
using GCGL_Client.NET;
using GCGL_Client.FZB;
using GCGL_Client.RPT;
using GCGL_Client.COS;

namespace GCGL_Client
{
    class Win32
    {
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

        [DllImport("kernel32.dll")]
        public static extern void Sleep(int dwMilliseconds);

        [DllImport("user32.dll ")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
    }

    public class AppServer
    {
        #region 全局变量

        //当前用户编码
        public static string LoginUserCode;
        //当前用户名称
        public static string LoginUserName;
        //登录业务日期
        public static DateTime LoginWorkDate;
        //是否登录成功了
        public static bool LoginSuccess = false;

        public static string LoginUnitCode;
        public static string LoginUnitName;
        public static int    LoginUnitJC;
        public static string LoginDeptCode;
        public static string LoginDeptName;
        public static string LoginAreaCode;
        public static string LoginAreaName;

        public static string LoginUnitWH;
        public static int    LoginGovCars;//一般公务用车编制数
        public static int    LoginLawCars;//一般执法执勤用车编制数
        public static int    LoginSkillCars; //特种专业技术用车编制数
        public static int    LoginUnitType;
        public static int    LoginUserType;
        public static string LoginDataType;//数据权限

        //当前单位是不是公物仓
        public static bool LoginUnitIsGWC()
        {
            return AppServer.LoginUnitType == 8;
        }

        //当前单位是不是预算单位
        public static bool LoginUnitIsYSDW()
        {
            return AppServer.LoginUnitType == 1;
        }

        //当前单位是不是主管单位
        public static bool LoginUnitIsZGDW()
        {
            return AppServer.LoginUnitType == 2;
        }

        //当前单位是不是财政厅
        public static bool LoginUnitIsCZT()
        {
            return AppServer.LoginUnitType == 3;
        }

        //当前单位是不是区划
        public static bool LoginUnitIsQH()
        {
            return AppServer.LoginUnitType == 0;
        }
        //当前用户是区划管理员
        public static bool LoginUserIsQH()
        {
            return AppServer.LoginUserType == 99;
        }
        //当前用户是系统管理员
        public static bool LoginUserIsXT()
        {
            return AppServer.LoginUserType == 88;
        }
        //用户权限表
        public static DataTable UserQxMenuList = null;

        //单位表
        public static DataTable  UdataTable = null;
        public static DBTreeView dbTreeView = null;
        public static DateTime EndChange;
        public static DateTime ChangeTime;
        
        //系统参数
        public static DataType_Param Sys_Param = new DataType_Param();

        public static string SelectTaskCode;
        public static string SelectUnitCode;
        public static int    SelectUnitJC;
        

        #endregion

        #region 编码选择窗体显示
        public static Cmn_TreeBox Frm行政区划 = null;//1
        public static Cmn_TreeBox Frm单位信息 = null;//2
        public static Cmn_TreeBox Frm上级编码 = null;//3
        public static Cmn_TreeBox Frm资产类别 = null;//5

        public static void ReadAppCommon(int AReadType)
        {
            try
            {
                if (!AppServer.WcfService_Open()) return;

                if (AppServer.Frm行政区划 == null) AppServer.Frm行政区划 = new Cmn_TreeBox();
                if (AReadType == 0 || AReadType == 1)
                {
                    AppServer.Frm行政区划.BuildTree("行政区划", AppServer.wcfClient.FZB_编码_List("行政区划1", AppServer.LoginAreaCode).Tables[0].Copy(), "编码", "上级编码", "名称");
                    AppServer.Frm行政区划.ExpandAll();
                }

                if (AppServer.Frm单位信息 == null)
                {
                    AppServer.Frm单位信息 = new Cmn_TreeBox();
                    AppServer.Frm单位信息.BuildTree("单位信息", AppServer.UdataTable, "单位编码", "上级编码", "单位名称");
                }
                else
                {
                    if(AppServer.EndChange != AppServer.ChangeTime)
                    AppServer.Frm单位信息.BuildTree("单位信息", AppServer.UdataTable, "单位编码", "上级编码", "单位名称");
                    AppServer.EndChange = AppServer.ChangeTime;
                }
               
                if (AppServer.Frm上级编码 == null) AppServer.Frm上级编码 = new Cmn_TreeBox();
                if (AReadType == 0 || AReadType == 3)
                {
                    AppServer.Frm上级编码.BuildTree("所属上级主管部门", AppServer.wcfClient.FZB_编码_List("上级编码", AppServer.LoginAreaCode).Tables[0].Copy(), "编码", "上级编码", "名称");
                    AppServer.Frm上级编码.ExpandAll();
                }

                if (AppServer.Frm资产类别 == null) AppServer.Frm资产类别 = new Cmn_TreeBox();
                if (AReadType == 5)
                {
                    AppServer.Frm资产类别.BuildTree("资产类别", AppServer.wcfClient.FZB_编码_List("资产类别1", AppServer.LoginAreaCode).Tables[0].Copy(), "编码", "上级编码", "名称");
                    AppServer.Frm资产类别.ExpandAll();
                }
            }
            catch (Exception ex)
            {
                AppServer.ShowMsg(ex.Message);
                return;
            }
            finally
            {
                AppServer.WcfService_Close();
            }
        }
        #endregion

        #region 公用函数  几个不同的提示消息方法
        public static void ShowMsg(string AMsgText, string AMsgCapt = "提示")
        {
            MessageBox.Show(AMsgText, AMsgCapt, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowMsg_Warn(string AMsgText, string AMsgCapt = "警告")
        {
            MessageBox.Show(AMsgText, AMsgCapt, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void ShowMsg_Error(string AMsgText, string AMsgCapt = "错误")
        {
            MessageBox.Show(AMsgText, AMsgCapt, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool DialogMsg(string AMsgText, string AMsgCapt = "询问")
        {
            return (MessageBox.Show(AMsgText, AMsgCapt, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK);
        }
        public static void ShowMsg_InputWarn(string AHintInfo)
        {
            MessageBox.Show(AHintInfo, "数据验证", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void ShowMsg_SubmitError(string AErrorMessage)
        {
            MessageBox.Show("提交数据时出现数据错误！\n错误信息：" + AErrorMessage, "提交错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowMsg_ExceptError(string AErrorMessage)
        {
            MessageBox.Show("执行过程中出现异常错误了！\n错误信息：" + AErrorMessage, "异常错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region ToolTipBox   //在控件的上方出现“云朵”式的提示
        public static ToolTip ToolTip;
        public static void ShowMsg_ToolTip(string Text, IWin32Window Window)
        {
            AppServer.ToolTip.Show(Text, Window, 0, -40);
        }
        public static void ShowMsg_ToolTip(string Text, IWin32Window Window, int X, int Y)
        {
            AppServer.ToolTip.Show(Text, Window, X, Y);
        }
        #endregion

        #region WCF服务连接

        public static Ref_WS_GCGL.WS_GCGLClient wcfClient = null;
        public static System.ServiceModel.Channels.Binding wcfBinding = null;
        public static System.ServiceModel.EndpointAddress wcfEndPointAddress = null;

        public static System.ServiceModel.Channels.Binding wcfBinding_File = null;
        public static System.ServiceModel.EndpointAddress wcfEndPointAddress_File = null;

        public static string ReportURL;
        public static string ReportPath;
        public static string ReportUsername;
        public static string ReportPassword;

        public static void InitAppServer()
        {
            //BindingHelper.Init();
            //读取Http通道的配置
            //BindingHelper.InitBindingInfo("BasicHttpBinding_IWS_GBJY", out wcfBinding, out wcfEndPointAddress);
            //读取Net.Tcp通道的配置
            //BindingHelper.InitBindingInfo("NetTcpBinding_IWS_FileTrans", out wcfBinding_File, out wcfEndPointAddress_File);
            //读取报表服务器的配置
            //BindingHelper.ReadReportMachineInfo(out ReportURL, out ReportPath, out ReportUsername, out ReportPassword);
        }

        public static Boolean WcfService_Open()
        {
            try
            {
                if ((wcfClient == null)
                    || (wcfClient.State != System.ServiceModel.CommunicationState.Created)
                    || (wcfClient.State != System.ServiceModel.CommunicationState.Opened))
                {
                    wcfClient = new WS_GCGLClient("BasicHttpBinding_IWS_GCGL");
                    //wcfClient = new WS_JXCClient(wcfBinding, wcfEndPointAddress);
                }
                return true;
            }
            catch (Exception ex)
            {
                //经验证此时URL不对也能正常创建啊，没异常错误，调用具体方法时才出错的
                AppServer.ShowMsg_SubmitError("打开Wcf出现异常！ 错误信息：" + (char)13 + ex.Message);
                return false;
            }
        }
        public static void WcfService_Close()
        {
            try
            {
                if (wcfClient.State != System.ServiceModel.CommunicationState.Faulted)
                    wcfClient.Close();
            }
            catch
            {
                wcfClient.Abort();
            }
        }

        public static decimal ReadDecimal(DataGridViewCell cell)
        {
            return decimal.Parse(cell.Value.ToString() == "" ? "-1" : cell.Value.ToString());
        }

        public static decimal ReadDecimal(object cell)
        {
            return decimal.Parse(cell.ToString() == "" ? "-1" : cell.ToString());
        }

        // 读取表格定义
        public static string GetTableDef(string tableid)
        {
            bool Opened = AppServer.wcfClient.State == System.ServiceModel.CommunicationState.Opened;
            if (Opened) // 已经打开则不再关闭
            {
                return AppServer.wcfClient.GetTableDef(tableid);
            }
            else // 否则先打开后关闭
            {
                try
                {
                    if (!AppServer.WcfService_Open()) return "";
                    return AppServer.wcfClient.GetTableDef(tableid);   
                }
                catch (Exception ex)
                {
                    AppServer.ShowMsg_ExceptError(ex.Message);
                    return "";
                }
                finally
                {
                    AppServer.WcfService_Close();
                }
            }
        }

        #endregion

        #region 单元格显示格式
        public static void SetGridViewStyle(DataGridView grid)
        {
            //设置表格显示颜色配置
            grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(AppServer.GridView_CellFormatting);
            //不允许自动增加列
            grid.AutoGenerateColumns = false;
        }


        public static void GridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.SelectionBackColor = Color.Orange;
            e.CellStyle.SelectionForeColor = Color.Black;
            if (e.RowIndex % 2 == 1)
            {
                e.CellStyle.BackColor = Color.AliceBlue;
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
            }
        }
        #endregion

        #region Cmn_WaitingBox
        public static Cmn_WaitingBox formWaitingBox = null;
        public static void Sleep(int dwMilliseconds)
        {
            Win32.Sleep(dwMilliseconds);
        }

        public static void SetWindowTop(int hwnd, bool top)
        {
            int hWndInsertAfter = 0;

            if (top)
                hWndInsertAfter = -1;   // 置顶
            else
                hWndInsertAfter = -2;   // 解除置顶

            Win32.SetWindowPos(hwnd, hWndInsertAfter, 0, 0, 0, 0, 0x001 | 0x002 | 0x040);
        }

        public static void SetWindowTop(Form form, bool top)
        {
            SetWindowTop(form.Handle.ToInt32(), top);
        }

        public delegate void OnFormShow();
        public static OnFormShow ShowWaitForm = delegate()
        {
            if (formWaitingBox == null) formWaitingBox = new Cmn_WaitingBox();
            formWaitingBox.ShowMsg();
        };

        public delegate void OnFormClose();
        public static OnFormClose HideWaitForm = delegate()
        {
            if (formWaitingBox != null)
            {
                formWaitingBox.Close();
                formWaitingBox = null;
            }
        };

        public delegate void OnDataImport(string msg, int progress, int max, bool waiting);
        public static OnDataImport DataImport = delegate(string msg, int progress, int max, bool waiting)
        {
            formWaitingBox.MsgText = msg;
            formWaitingBox.ProgressMax = max;
            formWaitingBox.Progress = progress;
            if (waiting) { AppServer.Sleep(100); }
        };
        #endregion

        #region 公用业务处理窗体


        #endregion

        #region Wcf服务的简洁调用
        public static TReturn WcfService<TChannel, TReturn>(Func<TChannel, TReturn> func)
        {
            var chanFactory = new ChannelFactory<TChannel>("*");
            TChannel channel = chanFactory.CreateChannel();
            ((IClientChannel)channel).Open();
            TReturn result = func(channel);
            try
            {
                ((IClientChannel)channel).Close();
            }
            catch (Exception ex)
            {
                ((IClientChannel)channel).Abort();
                ShowMsg_ExceptError(ex.Message);
            }
            return result;
        }
        #endregion

        #region 菜单调用处理方法

        public static bool OpenUserMenu(string AMenuCode, string AMenuName, Form AMainForm)
        {
            if (!AppServer.UserQxMenuList.Rows.Contains(AMenuCode))
            {
                AppServer.ShowMsg_Warn(string.Format("对不起，您没有“{0}”模块的操作权限，请与系统管理员联系解决！", AMenuName), "权限验证");
                return false;
            }
            //已打开的就不再重复创建了
            foreach (Form fForm in Application.OpenForms)
            {
                if (fForm.Name == AMenuName)
                {
                    fForm.BringToFront();
                    return true;
                }
            }
            //开始创建表单
            Form fMdiForm = null;
            switch (AMenuCode)
            {
                #region 基础设置-01
                //case "0100": { (new Man_Param()).ShowDialog(); break; }
                case "0101": { fMdiForm = new FZB_行政区划(); break; }
                case "0102": { fMdiForm = new FZB_机构信息(); break; }
                case "0103": { fMdiForm = new FZB_单位设置(); break; }
                case "0104": { fMdiForm = new FZB_配置标准(); break; }
                case "0105": { fMdiForm = new FZB_更新标准(); break; }

                case "0111": { fMdiForm = new FZB_车辆类型(); break; }
                case "0112": { fMdiForm = new FZB_资产类别(); break; }
                case "0113": { fMdiForm = new FZB_采购形式(); break; }
                case "0114": { fMdiForm = new FZB_处置形式(); break; }
                case "0115": { fMdiForm = new FZB_基础数据();break; }
                case "0120": { fMdiForm = new Man_UserLog(); break; }
                #endregion

                #region 预算管理-02
                case "0201":
                    {
                        if (AppServer.LoginUnitIsYSDW())
                        {
                            using (var form = new OCC_更新计划_Editor())
                            {
                                form.Editor_Add();
                                form.ShowDialog();
                            }
                            break;
                        }
                        else
                        {
                            AppServer.ShowMsg("您没有该项的权限，请与管理员联系！");
                            break;
                        }
                    }
                case "0211":
                    {
                        fMdiForm = new OCC_更新计划();
                        break;
                    }

                #endregion

                #region 配置管理-03

                case "0301":
                    {
                        using (var form = new OCC_配置申请_Editor())
                        {
                            form.Editor_Add();
                            form.ShowDialog();
                        }
                        break;
                    }
                case "0302":
                    {
                        if (AppServer.LoginUnitIsGWC())
                        {
                            using (var form = new OCC_公车入库_Editor())
                            {
                                form.Editor_Add(null);
                                form.ShowDialog();
                            }
                              
                        }
                        else
                        {
                            using (var form = new OCC_配置申请_Select())
                            {
                                form.Select_DB();
                                form.ShowDialog();
                            }
                        }
                        break;
                    }
                case "0303":
                    {
                        using (var form = new OCC_公车入库_调拨())
                        {                         
                            form.ShowDialog();
                        }
                        break;
                    }
                case "0304": { fMdiForm = new OCC_批量申请(); break; }
                case "0310": { fMdiForm = new FZB_公车编制数(); break; }
                case "0311": { fMdiForm = new OCC_配置申请(); break; }
                case "0312": { fMdiForm = new OCC_公车入库(); break; }

                #endregion

                #region 使用情况-04
               
                case "0403": { fMdiForm = new COS_超编车辆(); break; }
                case "0411": { fMdiForm = new COS_使用情况(); break; }
                case "0412": { fMdiForm = new COS_计提折旧(); break; }
                #endregion

                #region 处置管理-05

                case "0501":
                    {
                        using (var form = new OCC_处置申请_Editor())
                        {
                            form.Editor_Add();
                            form.ShowDialog();
                        }
                        break;
                    }
                case "0502":
                    {
                        using (var form = new OCC_公车出库_报废())
                        {
                            form.Editor_Add();
                            form.ShowDialog();
                        }
                        break;
                    }
                case "0503":
                    {
                        using (var form = new OCC_公车出库_调拨())
                        {
                            form.Editor_Add();
                            form.ShowDialog();
                        }
                        break;
                    }
                 case "0504":
                    {
                        using (var form = new OCC_公车出库_出售())
                        {
                            form.Editor_Add();
                            form.ShowDialog();
                        }
                        break;
                    }

                case "0511": { fMdiForm = new OCC_处置申请(); break; }
                case "0512": { fMdiForm = new OCC_公车出库(); break; }

                #endregion

                #region 信息管理-06
                case "0600": { fMdiForm = new NET_代办事项(); break; }
                case "0601": { fMdiForm = new NET_审批中心(); break; }
                case "0602": { fMdiForm = new NET_公告通知(); break; }
                case "0603": { fMdiForm = new NET_公文法规(); break; }
                case "0604": { fMdiForm = new NET_业务论坛(); break; }
                #endregion

                #region 统计报表-08

                case "0801": { fMdiForm = new RPT_公车库存_存量(); break; }
                case "0802": { fMdiForm = new RPT_公车库存_状况(); break; }
                case "0803": { fMdiForm = new RPT_公车库存_变化(); break; }
                case "0804": { fMdiForm = new RPT_单位编制_统计(); break; }
                case "0805": { fMdiForm = new RPT_超编车辆_统计(); break; }
                case "0811": { fMdiForm = new RPT_公车库存_台账(); break; }
                case "0812": { fMdiForm = new RPT_公车库存_总账(); break; }
                #endregion

                #region 系统管理-09
                case "0900": { fMdiForm = new Man_Entrust(); break; }
                case "0901": { fMdiForm = new Man_UserMngr(); break; }
                case "0902": { (new Man_UserPswd()).ShowDialog(); break; }
                case "0903": { (new Man_Login()).ShowDialog(); break; }
                //case "0904": { this.miExit.PerformClick(); break; }
                #endregion
            }
            //
            if (fMdiForm != null)
            {
                fMdiForm.Name = AMenuName;
                fMdiForm.Text = AMenuName;
                fMdiForm.MdiParent = AMainForm;
                fMdiForm.WindowState = FormWindowState.Maximized;
                fMdiForm.Show();
                fMdiForm.BringToFront();
            }
            //调用成功了
            return true;
        }
        #endregion
    }

}
