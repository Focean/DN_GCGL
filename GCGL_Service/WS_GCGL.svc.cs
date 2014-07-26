using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Collections.Generic;
using System.ServiceModel;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.IO;
using System.Reflection;
using TY.Helper;
using System.Data.SqlClient;
using System.Drawing;
namespace GCGL_Service
{
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
        public DataSet Sys_Menu_List(int ARoleID)
        {
            DbCommand dbcmd = AppDB.GetStoredProcCommand("P_SYS_Menu_List");
            AppDB.AddInParameter(dbcmd, "@RoleID", SqlDbType.Int, ARoleID);
            return AppDB.ExecuteDataSet(dbcmd);
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

        #region 基础设置

        /// <summary>
        /// 编码表
        /// </summary>
        public DataSet FZB_编码_List(string AExAction)
        {
            DbCommand dbcmd = AppDB.GetStoredProcCommand("P_FZB_辅助编码_List");
            AppDB.AddInParameter(dbcmd, "@ExAction", SqlDbType.VarChar, AExAction);
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
       
        #endregion

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

        #region 公文管理

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

    }

}
