using System;
using System.Data;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Data.Common;
using System.Data.SqlTypes;
using System.IO;
using System.Drawing;
namespace GCGL_Service
{
    [ServiceContract]
    public interface IWS_GCGL
    {
        #region 通用模块

        [OperationContract]
        DataSet ExecuteDataSet(string sql);
        [OperationContract]
        int ExecuteNoQuery(string sql);

        #endregion

        #region 系统管理

        /// <summary>
        /// 系统登录
        /// </summary>
        [OperationContract]
        DataSet SYS_Login(ref DataType_User model);

        /// <summary>
        /// 系统登录用户的菜单
        /// </summary>
        [OperationContract]
        DataSet SYS_Login_Menu(ref DataType_User model);

        /// <summary>
        /// 用户列表
        /// </summary>
        [OperationContract]
        DataSet Sys_User_List(DataType_User model);

        /// <summary>
        ///  用户编辑
        /// </summary>
        [OperationContract]
        void Sys_User_Edit(ref DataType_User model);

        /// <summary>
        /// 角色列表
        /// </summary>
        [OperationContract]
        DataSet Sys_Role_List(DataType_Role model);

        /// <summary>
        ///  角色编辑
        /// </summary>
        [OperationContract]
        void Sys_Role_Edit(ref DataType_Role model);

        /// <summary>
        /// 菜单列表
        /// </summary>
        [OperationContract]
        DataSet Sys_Menu_List(int ARoleID);

        /// <summary>
        /// 参数读取
        /// </summary>
        [OperationContract]
        void SYS_Param_Get(ref DataType_Param model);

        /// <summary>
        /// 参数设置
        /// </summary>
        [OperationContract]
        void SYS_Param_Set(ref DataType_Param model);

        /// <summary>
        /// 表格读取
        /// </summary>
        [OperationContract]
        void SYS_Grid_Get (ref DataType_Grid model);

        /// <summary>
        /// 表格设置--保存用户对表格配置
        /// </summary>
        [OperationContract]
        void SYS_Grid_Set(ref DataType_Grid model);

        [OperationContract]
        string GetTableDef(string tableid);
        
        #endregion

        #region 标准管理

        [OperationContract]
        DataSet CMN_车辆更新标准_List(ref DataType_CMN_车辆更新标准 model);
        [OperationContract]
         void CMN_车辆更新标准_Edit(ref DataType_CMN_车辆更新标准 model);

        [OperationContract]
        DataSet CMN_车辆配置标准_List(ref DataType_CMN_车辆配置标准 model);
        [OperationContract]
        void CMN_车辆配置标准_Edit(ref DataType_CMN_车辆配置标准 model);

        #endregion       

        #region 基础设置
        /// <summary>
        /// 编码列表
        /// </summary>
        [OperationContract]
        DataSet FZB_编码_List(string AExAction);
        [OperationContract]
        void FZB_资产类别_Edit(ref DataType_FZB_编码 model);
        [OperationContract]
        void FZB_车辆类型_Edit(ref DataType_FZB_编码 model);
        [OperationContract]
        void FZB_采购形式_Edit(ref DataType_FZB_编码 model);
        [OperationContract]
        void FZB_处置形式_Edit(ref DataType_FZB_编码 model);
        [OperationContract]
        void FZB_经费来源_Edit(ref DataType_FZB_编码 model);
        
        #endregion

        #region 行政区划、单位、处室

        [OperationContract]
        DataSet CMN_行政区划_List(ref DataType_CMN_行政区划 model);
        [OperationContract]
        void CMN_行政区划_Edit(ref DataType_CMN_行政区划 model);

        [OperationContract]
        DataSet CMN_单位_List(ref DataType_CMN_单位 model);
        [OperationContract]
        void CMN_单位_Edit(ref DataType_CMN_单位 model);

        [OperationContract]
        DataSet CMN_单位_处室_List(ref DataType_CMN_单位_处室 model);
        [OperationContract]
        void CMN_单位_处室_Edit(ref DataType_CMN_单位_处室 model);

        [OperationContract]
        DataSet CMN_单位_编制_List(ref DataType_CMN_单位_编制 model);
        [OperationContract]
        void CMN_单位_编制_Edit(ref DataType_CMN_单位_编制 model);

        #endregion

        #region 预算管理

        [OperationContract]
        DataSet OCC_更新计划_List(ref DataType_OCC_更新计划 model);
        [OperationContract]
        void OCC_更新计划_Edit(ref DataType_OCC_更新计划 model);

        #endregion

        #region 配置管理（配置申请、公车入库）

        [OperationContract]
        void OCC_配置申请_Edit(ref DataType_OCC_配置申请 model);
        [OperationContract]
        DataSet OCC_配置申请_List(ref DataType_OCC_配置申请 model);

        [OperationContract]
        void OCC_公车入库_Edit(ref DataType_OCC_公车入库 model);
        [OperationContract]
        DataSet OCC_公车入库_List(ref DataType_OCC_公车入库 model);

        #endregion

        #region 使用情况
        [OperationContract]
        void COS_使用情况_Edit(ref DataType_COS_使用申请 model);
        [OperationContract]
        DataSet COS_使用情况_List(ref DataType_COS_使用申请 model);

        [OperationContract]
        void COS_计提折旧_Edit(ref DataType_COS_计提折旧 model);
        [OperationContract]
        DataSet COS_计提折旧_List(ref DataType_COS_计提折旧 model);
        #endregion

        #region 处置管理（处置申请、公车出库）

        [OperationContract]
        void OCC_处置申请_Edit(ref DataType_OCC_处置申请 model);
        [OperationContract]
        DataSet OCC_处置申请_List(ref DataType_OCC_处置申请 model);
       
        [OperationContract]
        DataSet OCC_公车出库_List(ref DataType_OCC_公车出库 model);
        [OperationContract]
        void OCC_公车出库_Edit(ref DataType_OCC_公车出库 model);
       
        #endregion

        #region 公车库存

        [OperationContract]
        DataSet OCC_公车库存_List(ref DataType_OCC_公车库存 model);
        
        #endregion

        #region 公文管理

        [OperationContract]
        DataSet NET_审批_List(ref DataType_NET_审批 model);
        [OperationContract]
        void NET_审批_Edit(ref DataType_NET_审批 model);

        [OperationContract]
        DataSet NET_附件管理_List(ref DataType_NET_附件管理 model);
        [OperationContract]
        void NET_附件管理_Edit(ref DataType_NET_附件管理 model);
        
        [OperationContract]
        DataSet NET_公文_List(ref DataType_NET_公文 model);
        [OperationContract]
        void NET_公文_Edit(ref DataType_NET_公文 model);

        [OperationContract]
        DataSet NET_论坛_List(ref DataType_NET_论坛 model);
        [OperationContract]
        void NET_论坛_Edit(ref DataType_NET_论坛 model);
        [OperationContract]
        DataSet NET_论坛_版块_List(ref DataType_NET_论坛 model);
        [OperationContract]
        void NET_论坛_版块_Edit(ref DataType_NET_论坛 model);

        [OperationContract]
        string NET_论坛_图片_Edit(MemoryStream ss, string Fileformat, string ip);
        #endregion

    }

    #region 模型/契约 定义

    #region 模型基类

    [DataContract]
    public class ModelBase
    {
        [DataMember]
        public string ExAction { get; set; }
        [DataMember]
        public int ExResult { get; set; }
        [DataMember]
        public string ErrorMsg { get; set; }

        [DataMember]
        public string LoginUserCode { get; set; }
        [DataMember]
        public string LoginUserPswd { get; set; }
        [DataMember]
        public int yRoleList { get; set; }     

        [DataMember]
        public int PageRows { get; set; }
        [DataMember]
        public int PageIndex { get; set; }
        [DataMember]
        public int PageCount { get; set; }
        [DataMember]
        public int RowsCount { get; set; }

        [DataMember]
        public string GridTitle { get; set; }
        [DataMember]
        public string GridDefine { get; set; }
    }

    #endregion

    #region 系统管理

    [DataContract]
    public class DataType_User : ModelBase
    {
        [DataMember]
        public string LoginName { get; set; }
        [DataMember]
        public string LoginPswd { get; set; }
        [DataMember]
        public string LoginAddr { get; set; }
        [DataMember]
        public DateTime LoginDate { get; set; }

        [DataMember]
        public string UserCode { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string UserPswd { get; set; }
        [DataMember]
        public string MobiPhone { get; set; }
        [DataMember]
        public string WorkPhone { get; set; }
        [DataMember]
        public string UserEmail { get; set; }
        [DataMember]
        public string RoleList { get; set; }
        [DataMember]
        public string UnitCode { get; set; }
        [DataMember]
        public string DeptCode { get; set; }
        [DataMember]
        public int GovCars { get; set; }
        [DataMember]
        public int LawCars { get; set; }

        [DataMember]
        public string OldUserPswd { get; set; }
        [DataMember]
        public string WorkName { get; set; }
    }

    [DataContract]
    public class DataType_Role : ModelBase
    {
        [DataMember]
        public int RoleID { get; set; }
        [DataMember]
        public string RoleName { get; set; }
        [DataMember]
        public string RoleMemo { get; set; }
        [DataMember]
        public string RoleMenu { get; set; }
    }
    
    [DataContract]
    public class DataType_Param : ModelBase
    {
        [DataMember]
        public string DBVersion { get; set; }
        [DataMember]
        public string WSVersion { get; set; }
        [DataMember]
        public string CSVersion { get; set; }
        
        [DataMember]
        public string AppName { get; set; }
        [DataMember]
        public int DP_Number { get; set; }
        [DataMember]
        public int DP_Money { get; set; }

        [DataMember]
        public string 公司名称 { get; set; }
        [DataMember]
        public string 公司地址 { get; set; }
        [DataMember]
        public string 公司电话 { get; set; }
        [DataMember]
        public string 公司传真 { get; set; }
        [DataMember]
        public string 公司负责人 { get; set; }
    }

    [DataContract]
    public class DataType_Grid : ModelBase
    {
        [DataMember]
        public string GridName { get; set; }
        //[DataMember]
        //public string GridDefine { get; set; }
        [DataMember]
        public string GridMemo { get; set; }

        [DataMember]
        public string GridUser { get; set; }
    }

    #endregion

    #region  基础设置

    [DataContract]
    public class DataType_FZB_编码 : ModelBase
    {
        [DataMember]
        public string 资产类别编码 { get; set; }
        [DataMember]
        public string 车辆类型编码 { get; set; }
        [DataMember]
        public string 采购形式编码 { get; set; }
        [DataMember]
        public string 处置形式编码 { get; set; }
        [DataMember]
        public string 车辆品牌 { get; set; }
        [DataMember]
        public string 车辆类型名称 { get; set; }
        [DataMember]
        public string 资产类别名称 { get; set; }
        [DataMember]
        public string 采购形式名称 { get; set; }
        [DataMember]
        public string 处置形式名称 { get; set; }       
        [DataMember]
        public string 上级编码 { get; set; }
        [DataMember]
        public Boolean 可选择项 { get; set; }
    }
   
    #endregion

    #region 行政区划、单位、处室

    [DataContract] 
    public class DataType_CMN_行政区划 : ModelBase
    {  
        [DataMember]
        public string 区划编码 { get; set; }
        [DataMember]
        public string 区划名称{ get; set; }
        [DataMember]
        public string 上级编码 { get; set; }
        [DataMember]
        public int 区划级次 { get; set; }
        [DataMember]
        public bool 是否本级{ get; set; }
        [DataMember]
        public bool 是否行政省管县{ get; set; }
        [DataMember]
        public bool 是否财政省管县 { get; set; }
        [DataMember]
        public bool 是否有效{ get; set; }
    }
    
    public class DataType_CMN_单位 : ModelBase
    {
        [DataMember]
        public string 区划编码 { get; set; }
        [DataMember]
        public string 单位编码 { get; set; }
        [DataMember]
        public string 上级编码 { get; set; }
        [DataMember]
        public string 预算编码 { get; set; }
        [DataMember]
        public int 单位类型编码 { get; set; }
        [DataMember]
        public string 单位性质编码 { get; set; }
        [DataMember]
        public string 单位名称 { get; set; }
        [DataMember]
        public string 组织代码证号 { get; set; }
        [DataMember]
        public string 级别 { get; set; }
        [DataMember]
        public string 部门预算处室编码 { get; set; }
        [DataMember]
        public string 单位地址 { get; set; }
        [DataMember]
        public string 联系人 { get; set; }
        [DataMember]
        public string 电话 { get; set; }
        [DataMember]
        public string 传真 { get; set; }
        [DataMember]
        public string 邮编 { get; set; }
        [DataMember]
        public string 备注 { get; set; }
        [DataMember]
        public Boolean 有效 { get; set; }

        //查询条件
        [DataMember]
        public Boolean 包含下级 { get; set; }

    }

    public class DataType_CMN_单位_处室 : ModelBase
    {
        [DataMember]
        public string 单位编码 { get; set; }
        [DataMember]
        public string 处室编码 { get; set; }
        [DataMember]
        public string 处室名称 { get; set; }
        [DataMember]
        public int 处室类型 { get; set; }
        [DataMember]
        public int 执法执勤类型 { get; set; }
        [DataMember]
        public Boolean 有效 { get; set; }
    }

    [DataContract]
    public class DataType_CMN_单位_编制 : ModelBase
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string 单位编码 { get; set; }
        [DataMember]
        public int 一般公务用车编制数 { get; set; }
        [DataMember]
        public int 一般执法执勤用车编制数 { get; set; }
        [DataMember]
        public int 特种专业技术用车编制数 { get; set; }
        [DataMember]
        public DateTime 开始日期 { get; set; }
        [DataMember]
        public string 创建人编码 { get; set; }
        [DataMember]
        public string 审核人编码 { get; set; }
        [DataMember]
        public Boolean 是否审核 { get; set; }
    }
  
    #endregion

    #region 车辆标准管理
    [DataContract]
    public class DataType_CMN_车辆更新标准 : ModelBase
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string 资产类别编码 { get; set; }
        [DataMember]
        public string 车辆类型编码 { get; set; }
        [DataMember]
        public string 依据文件编码 { get; set; }
        [DataMember]
        public bool 是否生效 { get; set; }
        [DataMember]
        public int 使用年限 { get; set; }
        [DataMember]
        public int 行驶里程 { get; set; }
        [DataMember]
        public string 创建人编码 { get; set; }       
    }

    [DataContract]
    public class DataType_CMN_车辆配置标准 : ModelBase
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string 区划编码 { get; set; }
        [DataMember]
        public string 资产类别编码 { get; set; }
        [DataMember]
        public string 车辆类型编码 { get; set; }
        [DataMember]
        public string 依据文件编码 { get; set; }
        [DataMember]
        public bool 是否生效 { get; set; }
        [DataMember]
        public bool 是否新能源汽车 { get; set; }
        [DataMember]
        public decimal 价格 { get; set; }
        [DataMember]
        public decimal 排量 { get; set; }
        [DataMember]
        public DateTime 创建时间 { get; set; }
        [DataMember]
        public string 创建人编码 { get; set; }
    }
    #endregion

    #region 预算管理

    public class DataType_OCC_更新计划 : ModelBase
    {
        [DataMember]
        public string 申请编号 { get; set; }
        [DataMember]
        public string 单位编码 { get; set; }
        [DataMember]
        public int 公务用车预配置数 { get; set; }
        [DataMember]
        public int 公务用车预报废数 { get; set; }
        [DataMember]
        public int 一般执法执勤用车预配置数 { get; set; }
        [DataMember]
        public int 一般执法执勤用车预报废数 { get; set; }
        [DataMember]
        public int 特种专业技术用车预配置数 { get; set; }
        [DataMember]
        public int 特种专业技术用车预报废数 { get; set; }
        [DataMember]
        public DateTime 创建时间 { get; set; }
        [DataMember]
        public string 创建人编码 { get; set; }
        [DataMember]
        public string 备注 { get; set; }
        [DataMember]
        public int 计划年度 { get; set; }
        [DataMember]
        public Boolean 包含下级 { get; set; }
    }

    #endregion

    #region 配置管理

    [DataContract]
    public class DataType_OCC_配置申请 : ModelBase
    {
        [DataMember]
        public string 申请编号 { get; set; }
        [DataMember]
        public string 单位编码 { get; set; }
        [DataMember]
        public string 申请原因 { get; set; }
        [DataMember]
        public string 申请备注 { get; set; }
        [DataMember]
        public int 公务用车编制数 { get; set; }
        [DataMember]
        public int 公务用车实有数 { get; set; }
        [DataMember]
        public int 其中执法执勤用车编制数 { get; set; }
        [DataMember]
        public int 其中执法执勤用车实有数 { get; set; }
        //[DataMember]
        //public string 审批状态编码 { get; set; }
        [DataMember]
        public string 附件编码 { get; set; }
        [DataMember]
        public string MxDataStr { get; set; }

        [DataMember]
        public DateTime 开始时间 { get; set; }
        [DataMember]
        public DateTime 结束时间 { get; set; }
        [DataMember]
        public Boolean 包含下级 { get; set; }
    }

    [DataContract]
    public class DataType_OCC_公车入库 : ModelBase
    {
        [DataMember]
        public string 资产编号 { get; set; }
        [DataMember]
        public int 申请序号 { get; set; }
        [DataMember]
        public string 财政资产编号 { get; set; }
        [DataMember]
        public string 资产名称 { get; set; }
        [DataMember]
        public string 车辆类型编码 { get; set; }
        [DataMember]
        public string 资产类别编码 { get; set; }
        [DataMember]
        public string 规格型号 { get; set; }
        [DataMember]
        public string 厂牌型号 { get; set; }
        [DataMember]
        public string 计量单位 { get; set; }
        [DataMember]
        public string 取得方式 { get; set; }
        [DataMember]
        public DateTime 取得日期 { get; set; }
        [DataMember]
        public string 采购形式编码 { get; set; }
        [DataMember]
        public int 使用年限 { get; set; }
        [DataMember]
        public DateTime 保修截止日期 { get; set; }
        [DataMember]
        public DateTime 使用日期 { get; set; }
        [DataMember]
        public string 车辆产地 { get; set; }
        [DataMember]
        public string 车牌号 { get; set; }
        [DataMember]
        public string 颜色 { get; set; }
        [DataMember]
        public string 发动机号 { get; set; }
        [DataMember]
        public string 车架号 { get; set; }
        [DataMember]
        public string 排气量 { get; set; }
        [DataMember]
        public string 价值类型 { get; set; }
        [DataMember]
        public string 折旧状态 { get; set; }
        [DataMember]
        public decimal 价值 { get; set; }
        [DataMember]
        public decimal 累计折旧 { get; set; }
        [DataMember]
        public decimal 账面净值 { get; set; }
        [DataMember]
        public string 会计凭证号 { get; set; }
        [DataMember]
        public int     座位数 { get; set; }
        [DataMember]
        public string  型号 { get; set; }
        [DataMember]
        public string 使用方向 { get; set; }
        [DataMember]
        public string 备注 { get; set; }
        [DataMember]
        public string 单位编码 { get; set; }
        [DataMember]
        public string 处室编码 { get; set; }
        [DataMember]
        public int 资产状态编码 { get; set; }

        [DataMember]
        public string 入库单编码 { get; set; }
        [DataMember]
        public string 配置申请编号 { get; set; }
        [DataMember]
        public string 入库类型 { get; set; }
        [DataMember]
        public string 出库单编码 { get; set; }
        [DataMember]
        public string 附件编码 { get; set; }
        [DataMember]
        public string 创建人编码 { get; set; }
        [DataMember]
        public DateTime 创建时间 { get; set; }

        //查询条件
        [DataMember]
        public DateTime 开始时间 { get; set; }
        [DataMember]
        public DateTime 结束时间 { get; set; }
        [DataMember]
        public Boolean 包含下级 { get; set; }
    }

    #endregion

    #region 使用情况
    [DataContract]
    public class DataType_COS_使用申请 : ModelBase
    {
        [DataMember]
        public string 单位编码 { get; set; }
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string 车牌号 { get; set; }
        [DataMember]
        public DateTime 加油日期 { get; set; }
        [DataMember]
        public int 加油行驶里程 { get; set; }
        [DataMember]
        public decimal 加油量 { get; set; }
        [DataMember]
        public decimal 油价 { get; set; }
        [DataMember]
        public int 保养行驶里程 { get; set; }
        [DataMember]
        public decimal 预约里程 { get; set; }
        [DataMember]
        public DateTime 保养日期 { get; set; }
        [DataMember]
        public DateTime 预约日期 { get; set; }
        [DataMember]
        public string 保养项目 { get; set; }
        [DataMember]
        public decimal 保养费用 { get; set; }
        [DataMember]
        public string 保养经办人 { get; set; }
        [DataMember]
        public DateTime 维修日期 { get; set; }
        [DataMember]
        public decimal 维修费用 { get; set; }
        [DataMember]
        public string 维修项目 { get; set; }
        [DataMember]
        public string 维修经办人 { get; set; }
        [DataMember]
        public DateTime 出车日期 { get; set; }
        [DataMember]
        public DateTime 还车日期 { get; set; }
        [DataMember]
        public int 出车行驶里程 { get; set; }
        [DataMember]
        public string 出车事由 { get; set; }
        [DataMember]
        public string 出车目的地 { get; set; }
        [DataMember]
        public string 出车人 { get; set; }
        [DataMember]
        public string 出车批示人 { get; set; }
        [DataMember]
        public string 创建人编码 { get; set; }
        [DataMember]
        public DateTime 创建日期 { get; set; }

        [DataMember]
        public Boolean 加油记录 { get; set; }
        [DataMember]
        public Boolean 保养记录 { get; set; }
        [DataMember]
        public Boolean 维修记录 { get; set; }
        [DataMember]
        public Boolean 出车记录 { get; set; }

        [DataMember]
        public DateTime 开始时间 { get; set; }
        [DataMember]
        public DateTime 结束时间 { get; set; }
        
    }
    [DataContract]
    public class DataType_COS_计提折旧 : ModelBase
    {
        [DataMember]
        public string 编号 { get; set; }
        [DataMember]
        public int 资产编号 { get; set; }
        [DataMember]
        public DateTime 折旧日期 { get; set; }
        [DataMember]
        public string 折旧方式 { get; set; }
        [DataMember]
        public string 单位编码 { get; set; }
        [DataMember]
        public decimal 折旧金额 { get; set; }
        [DataMember]
        public string 创建人编码 { get; set; }
        [DataMember]
        public string 备注 { get; set; }
        [DataMember]
        public DateTime 创建日期 { get; set; }
    }
    #endregion

    #region  处置管理

    [DataContract]
    public class DataType_OCC_处置申请 : ModelBase
    {
        [DataMember]
        public string 申请编号 { get; set; }
        [DataMember]
        public int 申请序号 { get; set; }
        [DataMember]
        public string 单位编码 { get; set; }
        [DataMember]
        public string 申请原因 { get; set; }
        [DataMember]
        public string 申请备注 { get; set; }
        [DataMember]
        public string 审批状态编码 { get; set; }
        [DataMember]
        public int 申请数量 { get; set; }
        [DataMember]
        public decimal 总评估价值 { get; set; }
        [DataMember]
        public string 附件编码 { get; set; }
        [DataMember]
        public string MxDataStr { get; set; }

        //查询条件
        [DataMember]
        public DateTime 开始时间 { get; set; }
        [DataMember]
        public DateTime 结束时间 { get; set; }
        [DataMember]
        public Boolean 包含下级 { get; set; }
    }

    [DataContract]
    public class DataType_OCC_公车出库 : ModelBase
    {
        [DataMember]
        public string 出库单编码 { get; set; }
        [DataMember]
        public string 单位编码 { get; set; }
        [DataMember]
        public string 资产编号 { get; set; }
        [DataMember]
        public string 处置申请编号 { get; set; }
        [DataMember]
        public int 处置申请序号 { get; set; }
        [DataMember]
        public string 处置形式编码 { get; set; }
        [DataMember]
        public string 接收单位编码 { get; set; }
        [DataMember]
        public string 接收人编码 { get; set; }
        [DataMember]
        public string 备注 { get; set; }
        [DataMember]
        public string 收购单位 { get; set; }
        [DataMember]
        public decimal 处置收入 { get; set; }
        [DataMember]
        public DateTime 调拨日期 { get; set; }
        [DataMember]
        public string 本单位批准人 { get; set; }
        [DataMember]
        public string 附件编码 { get; set; }

        //查询条件
        [DataMember]
        public DateTime 开始时间 { get; set; }
        [DataMember]
        public DateTime 结束时间 { get; set; }
        [DataMember]
        public Boolean 包含下级 { get; set; }
    }

    #endregion

    #region 公车库存

    [DataContract]
    public class DataType_OCC_公车库存 : ModelBase
    {
        [DataMember]
        public string 配置申请编号 { get; set; }
        [DataMember]
        public string 资产编号 { get; set; }
        [DataMember]
        public string 财政资产编号 { get; set; }
        [DataMember]
        public string 资产名称 { get; set; }
        [DataMember]
        public string 车辆类型编码 { get; set; }
        [DataMember]
        public string 资产类别编码 { get; set; }
        [DataMember]
        public string 规格型号 { get; set; }
        [DataMember]
        public string 厂牌型号 { get; set; }
        [DataMember]
        public string 计量单位 { get; set; }
        [DataMember]
        public string 取得方式 { get; set; }
        [DataMember]
        public DateTime 取得日期 { get; set; }
        [DataMember]
        public string 采购形式编码 { get; set; }
        [DataMember]
        public int 使用年限 { get; set; }
        [DataMember]
        public DateTime 保修截止日期 { get; set; }
        [DataMember]
        public DateTime 使用日期 { get; set; }
        [DataMember]
        public string 车辆产地 { get; set; }
        [DataMember]
        public string 车牌号 { get; set; }
        [DataMember]
        public string 发动机号 { get; set; }
        [DataMember]
        public string 车架号 { get; set; }
        [DataMember]
        public string 排气量 { get; set; }
        [DataMember]
        public string 价值类型 { get; set; }
        [DataMember]
        public string 折旧状态 { get; set; }
        [DataMember]
        public decimal 价值 { get; set; }
        [DataMember]
        public decimal 累计折旧 { get; set; }
        [DataMember]
        public decimal 账面净值 { get; set; }
        [DataMember]
        public string 会计凭证号 { get; set; }
        [DataMember]
        public string 使用状况 { get; set; }
        [DataMember]
        public string 使用方向 { get; set; }
        [DataMember]
        public string 备注 { get; set; }
        [DataMember]
        public string 单位编码 { get; set; }
        [DataMember]
        public string 处室编码 { get; set; }
        [DataMember]
        public int 资产状态编码 { get; set; }

        //查询条件
        [DataMember]
        public DateTime 开始时间 { get; set; }
        [DataMember]
        public DateTime 结束时间 { get; set; }
        [DataMember]
        public Boolean 包含下级 { get; set; }
        [DataMember]
        public string 查询年度 { get; set; }
        [DataMember]
        public DateTime 保修截止日期k { get; set; }
        [DataMember]
        public DateTime 保修截止日期j { get; set; }
        [DataMember]
        public decimal 价值1 { get; set; }
        [DataMember]
        public decimal 价值2 { get; set; }
        [DataMember]
        public decimal 账面净值1 { get; set; }
        [DataMember]
        public decimal 账面净值2 { get; set; }
        [DataMember]
        public string  搜索内容 { get; set; }
        [DataMember]
        public Boolean 在编制 { get; set; }
        [DataMember]
        public Boolean 已报废 { get; set; }
        [DataMember]
        public Boolean 已出售 { get; set; }
    }

    #endregion

    #region 公文管理

    [DataContract]
    public class DataType_NET_审批 : ModelBase
    {
        [DataMember]
        public string exCode { get; set; }
        [DataMember]
        public int exIndex { get; set; }
        [DataMember]
        public string flCode { get; set; }
        [DataMember]
        public string exOpinion { get; set; }
        [DataMember]
        public int exOpinionFlag { get; set; }
        [DataMember]
        public int exState { get; set; }
        [DataMember]
        public string exUnitCode { get; set; }
        [DataMember]
        public string exUserCode { get; set; }
        [DataMember]
        public int exUserType { get; set; }

        //查询条件
        [DataMember]
        public string 单位编码 { get; set; }
        [DataMember]
        public DateTime 开始时间 { get; set; }
        [DataMember]
        public DateTime 结束时间 { get; set; }
        [DataMember]
        public Boolean 仅未审批 { get; set; }
        [DataMember]
        public Boolean 包含下级 { get; set; }
    }

    [DataContract]
    public class DataType_NET_附件管理 : ModelBase
    {
        [DataMember]
        public string 附件编码 { get; set; }
        [DataMember]
        public string 附件摘要 { get; set; }
        [DataMember]
        public string 附件备注 { get; set; }
        [DataMember]
        public string 文件标识 { get; set; }
    }

    [DataContract]
    public class DataType_NET_公文 : ModelBase
    {
        [DataMember]
        public string 公文编码 { get; set; }
        [DataMember]
        public string 公文类型 { get; set; }
        [DataMember]
        public string 公文标题 { get; set; }
        [DataMember]
        public string 公文内容 { get; set; }
        [DataMember]
        public string 附件编码 { get; set; }
        [DataMember]
        public int 查看次数 { get; set; }
        [DataMember]
        public string 单位编码 { get; set; }
        [DataMember]
        public string 创建人编码 { get; set; }
        [DataMember]
        public string 创建时间 { get; set; }
        [DataMember]
        public string 接收单位编码 { get; set; }
        [DataMember]
        public string 接收意见 { get; set; }
        [DataMember]
        public string 接收人编码 { get; set; }
        [DataMember]
        public DateTime 接收时间 { get; set; }
        [DataMember]
        public DateTime 开始时间 { get; set; }
        [DataMember]
        public DateTime 结束时间 { get; set; }
        [DataMember]
        public Boolean 仅显示我未接收 { get; set; }
        [DataMember]
        public string 关键字 { get; set; }
    }

    [DataContract]
    public class DataType_NET_论坛 : ModelBase
    {
        [DataMember]
        public string 版块编码 { get; set; }
        [DataMember]
        public string 版块名称 { get; set; }
        [DataMember]
        public string 版主人编码 { get; set; }
        [DataMember]
        public string 版块简介 { get; set; }
        [DataMember]
        public DateTime 创建时间 { get; set; }

        [DataMember]
        public string 贴子编码 { get; set; }
        [DataMember]
        public string 贴子标题 { get; set; }
        [DataMember]
        public string 贴子内容 { get; set; }
        [DataMember]
        public int 附件内容 { get; set; }

        //查询条件
        [DataMember]
        public DateTime 开始时间 { get; set; }
        [DataMember]
        public DateTime 结束时间 { get; set; }
        [DataMember]
        public Boolean 包含下级 { get; set; }
    }

    #endregion

    #endregion

}
