using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Data.Oracle;
using System.Collections.Generic;
using System.ServiceModel;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.IO;
using System.Reflection;
using TY.Helper;
using System.Data.SqlClient;
using System.Drawing;
using System.Data.OracleClient;

namespace GCGL_Service
{

    public static class ExtendMethods2
    {
        public static void AddInParameter(this OracleDatabase db, OracleCommand command, string name, OracleType dbType, int size, object value)
        {
            db.AddParameter(command, name, dbType, size, ParameterDirection.Input, true, 0, 0, String.Empty, DataRowVersion.Default, value);
        }

        public static void AddOutParameter(this OracleDatabase db, OracleCommand command, string name, OracleType dbType, int size)
        {
            db.AddParameter(command, name, dbType, size, ParameterDirection.Output, true, 0, 0, String.Empty, DataRowVersion.Default, DBNull.Value);
        }

        public static void AddInOutParameter(this OracleDatabase db, OracleCommand command, string name, OracleType dbType, int size, object value)
        {
            db.AddParameter(command, name, dbType, size, ParameterDirection.InputOutput, true, 0, 0, String.Empty, DataRowVersion.Default, value);
        }

        public static void AddInOutParameter(this OracleDatabase db, OracleCommand command, string name, OracleType dbType, int size)
        {
            db.AddParameter(command, name, dbType, size, ParameterDirection.InputOutput, true, 0, 0, String.Empty, DataRowVersion.Default, DBNull.Value);
        }

    }

    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    public class WS_GCGL : IWS_GCGL
    {
        public WS_GCGL()
        {
            //初始化
            ProcProxy.db = AppDB;
        }

        //数据库连接
        private static SqlDatabase AppDB = (SqlDatabase)DatabaseFactory.CreateDatabase("Connect_GCGL");
        private static OracleDatabase AppDB2 = (OracleDatabase)DatabaseFactory.CreateDatabase("Connect_APP");


        #region 通用模块

        public DataSet ExecuteDataSet(string sql)
        {
            DbCommand dbcmd = AppDB.GetStoredProcCommand("p_sys_execsql");
            AppDB.AddInParameter(dbcmd, "@sql", SqlDbType.NVarChar, sql);
            return AppDB.ExecuteDataSet(dbcmd);
        }

        public int ExecuteNoQuery(string sql)
        {
            DbCommand dbcmd = AppDB.GetStoredProcCommand("p_sys_execsql");
            AppDB.AddInParameter(dbcmd, "@sql", SqlDbType.NVarChar, sql);
            return AppDB.ExecuteNonQuery(dbcmd);
        }

        #endregion

        #region 系统管理

        /// <summary>
        /// 系统登录
        /// </summary>
        public DataSet SYS_Login(ref DataType_User model)
        {
            object m = model;
            return ProcProxy.ExecuteDataSet("P_SYS_Login", ref m);
        }

        /// <summary>
        /// 系统登录用户的菜单
        /// </summary>
        public DataSet SYS_Login_Menu(ref DataType_User model)
        {
            object m = model;
            return ProcProxy.ExecuteDataSet("P_SYS_Login_Menu", ref m);
        }

        /// <summary>
        /// 用户列表
        /// </summary>
        public DataSet Sys_User_List(DataType_User model)
        {
            return ProcProxy.ExecuteDataSet("P_SYS_User_List", model);
        }

        /// <summary>
        ///  用户编辑
        /// </summary>
        public void Sys_User_Edit(ref DataType_User model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_SYS_User_Edit", ref m);
        }

        /// <summary>
        /// 角色列表
        /// </summary>
        public DataSet Sys_Role_List(DataType_Role model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_SYS_Role_List", model);
        }

        /// <summary>
        ///  角色编辑
        /// </summary>
        public void Sys_Role_Edit(ref DataType_Role model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_SYS_Role_Edit", ref m);
        }

        /// <summary>
        /// 菜单列表
        /// </summary>
        public DataSet Sys_Menu_List(DataType_Role model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_SYS_Menu_List", model);
        }

        /// <summary>
        /// 参数读取
        /// </summary>
        public void SYS_Param_Get(ref DataType_Param model)
        {
            DataTable table = ProcProxy.ExecuteDataSet("P_SYS_Param_Get", model).Tables[0];
            TY.Helper.FormHelper.DataBinding_DataSourceToModel(table, model);
            //读取应用程序的版本号
            model.WSVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        /// <summary>
        /// 参数设置
        /// </summary>
        public void SYS_Param_Set(ref DataType_Param model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_SYS_Param_Set", ref m);
        }

        /// <summary>
        /// 表格读取
        /// </summary>
        public void SYS_Grid_Get(ref DataType_Grid model)
        {
            DataTable table = ProcProxy.ExecuteDataSet("P_SYS_Grid_Get", model).Tables[0];
            //
            TY.Helper.FormHelper.DataBinding_DataSourceToModel(table, model);
        }

        /// <summary>
        /// 表格设置--保存用户对表格配置
        /// </summary>
        public void SYS_Grid_Set(ref DataType_Grid model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_SYS_Grid_Set", ref m);
        }

        public string GetTableDef(string tableid)
        {
            DbCommand dbcmd = AppDB.GetStoredProcCommand("P_SYS_Grid_Get");
            AppDB.AddInParameter(dbcmd, "@GridName", SqlDbType.NVarChar, tableid);
            DataTable table = AppDB.ExecuteDataSet(dbcmd).Tables[0];
            if (table.Rows.Count > 0)
            { return table.Rows[0]["GridDefine"].ToStringDef(); }
            else
            { return ""; }
        }

        #endregion        

        #region 用户日志
        public DataSet SYS_User_log_list(ref DataType_User_log model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_SYS_User_log_List", ref m);
        }
        #endregion
       
        #region 基础设置

        /// <summary>
        /// 编码表
        /// </summary>
        public DataSet FZB_编码_List(string AExAction,string 区划编码)
        {
            DbCommand dbcmd = AppDB.GetStoredProcCommand("P_FZB_辅助编码_List");
            AppDB.AddInParameter(dbcmd, "@ExAction", SqlDbType.VarChar, AExAction);
            AppDB.AddInParameter(dbcmd, "@区划编码", SqlDbType.VarChar, 区划编码);
            return AppDB.ExecuteDataSet(dbcmd);
        }
        public void FZB_资产类别_Edit(ref DataType_FZB_编码 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_FZB_资产类别_Edit", ref m);
        }
        public void FZB_车辆类型_Edit(ref DataType_FZB_编码 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_FZB_车辆类型_Edit", ref m);
        }
        public void FZB_采购形式_Edit(ref DataType_FZB_编码 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_FZB_采购形式_Edit", ref m);
        }
        public void FZB_处置形式_Edit(ref DataType_FZB_编码 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_FZB_处置形式_Edit", ref m);
        }
        public void FZB_经费来源_Edit(ref DataType_FZB_编码 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_FZB_经费来源_Edit", ref m);
        }
        public void FZB_品牌型号_Edit(ref DataType_FZB_编码 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_FZB_品牌型号_Edit", ref m);
        }
        public void FZB_固定资产_Edit(ref DataType_FZB_编码 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_FZB_资产分类_Edit", ref m);
        }
        public DataSet FZB_固定资产_List(string AExAction, string ZCBM)
        {
            DbCommand dbcmd = AppDB.GetStoredProcCommand("P_FZB_辅助编码_List");
            AppDB.AddInParameter(dbcmd, "@ExAction", SqlDbType.VarChar, AExAction);
            AppDB.AddInParameter(dbcmd, "@资产类别编码", SqlDbType.VarChar, ZCBM);
            return AppDB.ExecuteDataSet(dbcmd);
        }
        #endregion

        #region 委托
        public void SYS_委托_Edit(ref DataType_SYS_委托 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_SYS_Entrust_Edit", ref m);
        }
        public DataSet SYS_委托_list(ref DataType_SYS_委托 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_SYS_Entrust_List", ref m);
        }
        #endregion

        //#region 手机短信
        ///// <summary>
        ///// 发送手机短信
        ///// </summary>
        ///// 
        //public DataSet CMN_发送短信_List(ref DataType_发送短信 model)
        //{
        //    return ProcProxy.ExecuteDataSet("P_CMN_发送短信_List", model);
        //}

        //public void CMN_发送短信_Edit(ref DataType_发送短信 model)
        //{
        //    object m = model as object;
        //    ProcProxy.ExecuteNoQuery("P_CMN_发送短信_Edit", ref m);
        //}

        //public void CMN_GetSendMessage(string CheckType,string UserCode,out string ErrorStr,string ExCode=null)
        //{
        //    ErrorStr = null;
        //    int sum=0;
        //    var getmodel = new DataType_NET_审批();
        //    string exUnit=null;
        //   // int exUType=9999;
        //    string NUser = null;
        //    string MobiPhone=null;
        //    //确认单位的分管人
        //    getmodel.ExAction = "GetNUnit";
        //    getmodel.LoginUserCode = UserCode;
        //    getmodel.exCode = ExCode;
        //    DataSet ds = this.NET_审批_List(ref getmodel);
        //    DataTable DUT = ds.Tables[0];
        //   // DataTable dU = ds.Tables[1];
        //    //if (dU.Rows.Count > 0)
        //    //{
        //    //    exUnit = dU.Rows[0]["exUnitCode"].ToString();//要执行的单位
        //    //    exUType = dU.Rows[0]["exUserType"].ToIntegerDef();//用户类型，这两个字段确定是短信要发送给资产处经办人
                
        //    //}
        //    if (DUT.Rows.Count > 0)
        //    {
        //        NUser = DUT.Rows[0]["UserCode"].ToString();
        //        MobiPhone = DUT.Rows[0]["MobiPhone"].ToString();
        //    }
            
        //    //查询申报数量
        //    getmodel.ExAction = "NCount";
        //    getmodel.LoginUserCode = NUser;
        //    DataSet db = this.NET_审批_List(ref getmodel);
        //    DataTable DT = db.Tables[0];
        //    if (DT.Rows.Count > 0)
        //    {
        //        if (CheckType == "编制")
        //        {
        //            sum = DT.Rows[0]["编制审批数量"].ToIntegerDef();
        //        }
        //        else if (CheckType == "更新")
        //        {
        //            sum = DT.Rows[0]["更新审批数量"].ToIntegerDef();
        //        }
        //        else if (CheckType == "出库")
        //        {
        //            sum = DT.Rows[0]["出库审批数量"].ToIntegerDef();
        //        }
        //        else if (CheckType == "入库")
        //        {
        //            sum = DT.Rows[0]["入库审批数量"].ToIntegerDef();
        //        }
        //        else if (CheckType == "配置")
        //        {
        //            sum = DT.Rows[0]["配置审批数量"].ToIntegerDef();
        //        }
        //        else if (CheckType == "处置")
        //        {
        //          //  if (exUnit == "410001_CZT" && exUType == 3)
        //                sum = DT.Rows[0]["处置审批数量"].ToIntegerDef();
        //        }
        //    }
        //    if (sum > 0)
        //    {
        //        //进行短信发送
        //        var newmodel = new DataType_发送短信();
        //        newmodel.ExAction = "Add";
        //        newmodel.LoginUserCode = UserCode;
        //        newmodel.发送手机 = MobiPhone;
        //        newmodel.单位编码 = exUnit;
        //        newmodel.接收人编码 = NUser;
        //        newmodel.短信内容 = string.Format("公车管理：您有一个新的{0}申报需要审核，现共有{1}个{0}申报需要审核，请登录系统进行处理！", CheckType, sum);
        //        //
        //        this.CMN_发送短信_Edit(ref newmodel);
        //        //
        //        ErrorStr = this.CMN_SendSMS_DB(NUser);
        //    }          
        //}

        //private string CMN_SendSMS_DB(string Nuser)
        //{
        //    string err = null;

        //    try
        //    {
        //        string sqlstr = "Insert into BIC_STAYSMSDETAIL(strlevel,appSourceSubCode,mobile,content,smstype) values ('1','ZCC_GCGL',:MobiPhone,:SendSMS,'1')";
        //        OracleCommand oracmd = AppDB2.GetSqlStringCommand(sqlstr) as OracleCommand;

        //        oracmd.Connection = AppDB2.CreateConnection() as OracleConnection;
        //        oracmd.Connection.Open();

                
        //        var model = new DataType_发送短信();
        //        model.ExAction = "SendList";
        //        model.LoginUserCode = Nuser;
        //        DataTable table = ProcProxy.ExecuteDataSet("P_CMN_发送短信_List", model).Tables[0];
        //        foreach (DataRow row in table.Rows)
        //        {
        //            AppDB2.AddInParameter(oracmd, "MobiPhone", OracleType.VarChar, 20, row["发送手机"].ToString());
        //            AppDB2.AddInParameter(oracmd, "SendSMS", OracleType.VarChar, 500, row["短信内容"].ToString());

        //            oracmd.ExecuteNonQuery();

        //            model.ExAction = "Mod";
        //            model.ID = row["ID"].ToIntegerDef(0);
        //            model.发送状态 = 1;
        //            object m = model as object;
        //            ProcProxy.ExecuteNoQuery("P_CMN_发送短信_Edit", ref m);
        //        }

        //        oracmd.Connection.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        err = "异常错误:" + ex.Message + "," + err; ;
        //    }

        //    return err;
        //}


        ////private string CMN_SendSMS_DB(string Nuser)
        ////{
        ////    string err = null;

        ////    string CONN_STR="DATA SOURCE=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 10.8.4.70)(PORT = 1521)))(CONNECT_DATA = (SID = app)));PERSIST SECURITY INFO=True;USER ID=ZZCZT;PASSWORD=123";
        ////    //string CONN_STR = "Data Source=(DESCRIPTION="
        ////    //                + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.8.4.70)(PORT=1521)))"
        ////    //                + "(CONNECT_DATA=(SID=APP)));"
        ////    //                + "User Id=zzczt;Password=123;";
        ////    if (string.IsNullOrEmpty(CONN_STR))
        ////    {
        ////        return "数据库访问服务出现故障！";
        ////    }
        ////    else
        ////    {
        ////        OracleConnection conn = null;
        ////        try
        ////        {
        ////            conn = new OracleConnection(CONN_STR);
        ////            conn.Open();
        ////            //
        ////            var model = new DataType_发送短信();
        ////            model.ExAction = "SendList";
        ////            model.LoginUserCode = Nuser;
        ////            DataTable table = ProcProxy.ExecuteDataSet("P_CMN_发送短信_List", model).Tables[0];
        ////            foreach (DataRow row in table.Rows)
        ////            {
        ////                string sqlstr = "Insert into BIC_STAYSMSDETAIL(strlevel,appSourceSubCode,mobile,content,smstype) values ('1','ZHC_ZFZJGL',:MobiPhone,:SendSMS,'1')";
        ////                OracleCommand oracmd = conn.CreateCommand();
        ////                oracmd.CommandText = sqlstr;

        ////                OracleParameter oraPara1 = new OracleParameter("MobiPhone", OracleType.VarChar);
        ////                oraPara1.Direction = ParameterDirection.Input;
        ////                oraPara1.Value = row["发送手机"].ToString();
        ////                oracmd.Parameters.Add(oraPara1);

        ////                OracleParameter oraPara2 = new OracleParameter("SendSMS", OracleType.VarChar);
        ////                oraPara2.Direction = ParameterDirection.Input;
        ////                oraPara2.Value = row["短信内容"].ToString();
        ////                oracmd.Parameters.Add(oraPara2);

        ////                oracmd.ExecuteNonQuery();

        ////                model.ExAction = "Mod";
        ////                model.ID = row["ID"].ToIntegerDef(0);
        ////                model.发送状态 = 1;
        ////                object m = model as object;
        ////                ProcProxy.ExecuteNoQuery("P_CMN_发送短信_Edit", ref m);
        ////                //err = "短信发送成功！";
        ////                err = null;
        ////            }
        ////        }
        ////        catch (Exception ex)
        ////        {
        ////            err = "异常错误:" + ex.Message;

        ////        }
        ////        if (null != conn)
        ////        {
        ////            conn.Close();
        ////            conn.Dispose();
        ////        }
        ////        return err;
        ////    }
            
        ////}

        //#endregion

        #region 行政区划、单位、处室

        public DataSet CMN_行政区划_List(ref DataType_CMN_行政区划 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_CMN_行政区划_List", ref m);
        }

        public void CMN_行政区划_Edit(ref DataType_CMN_行政区划 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_CMN_行政区划_Edit", ref m);
        }

        public DataSet CMN_单位_List(ref DataType_CMN_单位 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_CMN_单位_List", m);
        }
        public void CMN_单位_Edit(ref DataType_CMN_单位 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_CMN_单位_Edit", ref m);
        }

        public DateTime CMN_单位_更新_List()
        {
            DbCommand dbcmd = AppDB.GetStoredProcCommand("P_CMN_单位_更新_List");
            
            return AppDB.ExecuteDataSet(dbcmd).ToDateTimeDef();
        }
        public DataSet CMN_单位_处室_List(ref DataType_CMN_单位_处室 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_CMN_单位_处室_List", ref m);
        }
        public void CMN_单位_处室_Edit(ref DataType_CMN_单位_处室 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_CMN_单位_处室_Edit", ref m);
        }

        public DataSet CMN_单位_编制_List(ref DataType_CMN_单位_编制 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_CMN_单位_编制_List", ref m);
        }
        public void CMN_单位_编制_Edit(ref DataType_CMN_单位_编制 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_CMN_单位_编制_Edit", ref m);
        }

        #endregion

        #region 标准管理

        public DataSet CMN_车辆更新标准_List(ref DataType_CMN_车辆更新标准 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_CMN_更新标准_List", ref m);
        }

        public void CMN_车辆更新标准_Edit(ref DataType_CMN_车辆更新标准 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_CMN_更新标准_Edit", ref m);
        }

        public DataSet CMN_车辆配置标准_List(ref DataType_CMN_车辆配置标准 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_CMN_配置标准_List", ref m);
        }

        public void CMN_车辆配置标准_Edit(ref DataType_CMN_车辆配置标准 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_CMN_配置标准_Edit", ref m);
        }

        #endregion

        #region 预算管理

        public DataSet OCC_更新计划_List(ref DataType_OCC_更新计划 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_OCC_更新计划_List", ref m);
        }
        public void OCC_更新计划_Edit(ref DataType_OCC_更新计划 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_OCC_更新计划_Edit", ref m);
        }

        #endregion

        #region 配置管理(配置申请、公车入库)

        public void OCC_配置申请_Edit(ref DataType_OCC_配置申请 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_OCC_配置申请_Edit", ref m);
        }
        public DataSet OCC_配置申请_List(ref DataType_OCC_配置申请 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_OCC_配置申请_List", ref m);   
        }

        public void OCC_公车入库_Edit(ref DataType_OCC_公车入库 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_OCC_公车库存_入库_Edit", ref m);
        }

        public DataSet OCC_公车入库_List(ref DataType_OCC_公车入库 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_OCC_公车库存_入库_List", ref m);
        }
        public void OCC_批量申请_Edit(ref DataType_OCC_批量申请 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_OCC_批量申请_Edit", ref m);
        }
        public DataSet OCC_批量申请_List(ref DataType_OCC_批量申请 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_OCC_批量申请_List", ref m);
        }
        #endregion

        #region 使用情况
        public void COS_使用情况_Edit(ref DataType_COS_使用申请 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_COS_使用情况_Edit", ref m);
        }
        public DataSet COS_使用情况_List(ref DataType_COS_使用申请 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_COS_使用情况_List", ref m);
        }

        public void COS_计提折旧_Edit(ref DataType_COS_计提折旧 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_COS_计提折旧_Edit", ref m);
        }
        public DataSet COS_计提折旧_List(ref DataType_COS_计提折旧 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_COS_计提折旧_List", ref m);
        }

        public DataSet COS_车辆超编_List(ref DataType_OCC_公车入库 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_OCC_公车库存_超编_List", ref m);
        }
        public void COS_车辆超编_Edit(ref  DataType_OCC_公车入库 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_OCC_公车库存_超编_Edit", ref m);
        }
        #endregion

        #region 处置管理(处置申请、公车出库)

        public void OCC_处置申请_Edit(ref DataType_OCC_处置申请 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_OCC_处置申请_Edit", ref m);
        }
        public DataSet OCC_处置申请_List(ref DataType_OCC_处置申请 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_OCC_处置申请_List", ref m);
        }

        public void OCC_公车出库_Edit(ref DataType_OCC_公车出库 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_OCC_公车库存_出库_Edit", ref m);
        }

        public DataSet OCC_公车出库_List(ref DataType_OCC_公车出库 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_OCC_公车库存_出库_List", ref m);
        }

        #endregion

        #region 公车库存
        public DataSet OCC_公车库存_List(ref DataType_OCC_公车库存 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_OCC_公车库存_List", ref m);
        }
        #endregion

        #region 信息管理

        public DataSet NET_审批_List(ref DataType_NET_审批 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_NET_审批_List", ref m);
        }

        public void NET_审批_Edit(ref DataType_NET_审批 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_NET_审批_Edit", ref m);
        }

        public DataSet NET_附件管理_List(ref DataType_NET_附件管理 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_NET_附件管理_List", ref m);
        }

        public void NET_附件管理_Edit(ref DataType_NET_附件管理 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_NET_附件管理_Edit", ref m);
        }

        public DataSet NET_公文_List(ref DataType_NET_公文 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_NET_公文_List", ref m);
        }

        public void NET_公文_Edit(ref DataType_NET_公文 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_NET_公文_Edit", ref m);
        }

        public DataSet NET_论坛_List(ref DataType_NET_论坛 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_NET_论坛_List", ref m);
        }

        public void NET_论坛_Edit(ref DataType_NET_论坛 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_NET_论坛_Edit", ref m);
        }

        public DataSet NET_论坛_版块_List(ref DataType_NET_论坛 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_NET_论坛_版块_List", ref m);
        }

        public void NET_论坛_版块_Edit(ref DataType_NET_论坛 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_NET_论坛_版块_Edit", ref m);
        }

        public string NET_论坛_图片_Edit(MemoryStream ss, string Fileformat, string ip)
        {
            string SavePath = System.AppDomain.CurrentDomain.BaseDirectory;
            if (!Directory.Exists(SavePath + "\\images"))
                Directory.CreateDirectory(SavePath + "\\images");
            Image img = Image.FromStream(ss);
            string dbName = DateTime.Now.ToString("yyyyMMddhhmmss") + Fileformat;
            img.Save(SavePath + "images" + "\\" + dbName);

            return "http://" + ip + "/dnsoft/gcgl/Service/images/" + dbName;
        }
        #endregion

        #region 查询方案

        public DataSet FZB_查询方案_List(ref DataType_FZB_查询方案 model)
        {
            object m = model as object;
            return ProcProxy.ExecuteDataSet("P_FZB_查询方案_List", ref m);
        }
        public void FZB_查询方案_Edit(ref DataType_FZB_查询方案 model)
        {
            object m = model as object;
            ProcProxy.ExecuteNoQuery("P_FZB_查询方案_Edit", ref m);
        }
        #endregion

    }

}
