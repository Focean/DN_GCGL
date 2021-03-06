﻿using System;
using System.ServiceModel;
using System.IO;
using System.Data;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Web.Security;
using System.Security.Principal;
using System.Runtime.InteropServices;
using WcfFileTransferInterface;
using log4net;

namespace WcfFileTransferService
{

    public static class ExtendMethods
    {
        public static void AddInOutParameter(this SqlDatabase db, DbCommand command, string name, SqlDbType dbType, int size, object value)
        {
            db.AddParameter(command, name, dbType, size, ParameterDirection.InputOutput, true, 0, 0, String.Empty, DataRowVersion.Default, value);
        }

        public static void AddInOutParameter(this SqlDatabase db, DbCommand command, string name, SqlDbType dbType, int size)
        {
            db.AddParameter(command, name, dbType, size, ParameterDirection.InputOutput, true, 0, 0, String.Empty, DataRowVersion.Default, DBNull.Value);
        }
    }

    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“FileTransfer”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 FileTransfer.svc 或 FileTransfer.svc.cs，然后开始调试。
    public class FileTransfer : IFileTransfer
    {
        private const int LOGON32_LOGON_INTERACTIVE = 2;
        private const int LOGON32_PROVIDER_DEFAULT = 0;

        private WindowsImpersonationContext impersonationContext;

        [DllImport("advapi32.dll")]
        private static extern int LogonUserA(String lpszUserName,
            String lpszDomain,
            String lpszPassword,
            int dwLogonType,
            int dwLogonProvider,
            ref IntPtr phToken);
        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int DuplicateToken(IntPtr hToken,
            int impersonationLevel,
            ref IntPtr hNewToken);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool RevertToSelf();

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern bool CloseHandle(IntPtr handle);

        private bool impersonateValidUser(String userName, String domain, String password)
        {
            WindowsIdentity tempWindowsIdentity;
            IntPtr token = IntPtr.Zero;
            IntPtr tokenDuplicate = IntPtr.Zero;

            if (RevertToSelf())
            {
                if (LogonUserA(userName, domain, password, LOGON32_LOGON_INTERACTIVE,
                    LOGON32_PROVIDER_DEFAULT, ref token) != 0)
                {
                    if (DuplicateToken(token, 2, ref tokenDuplicate) != 0)
                    {
                        tempWindowsIdentity = new WindowsIdentity(tokenDuplicate);
                        impersonationContext = tempWindowsIdentity.Impersonate();
                        if (impersonationContext != null)
                        {
                            CloseHandle(token);
                            CloseHandle(tokenDuplicate);
                            return true;
                        }
                    }
                }
            }
            if (token != IntPtr.Zero)
                CloseHandle(token);
            if (tokenDuplicate != IntPtr.Zero)
                CloseHandle(tokenDuplicate);
            return false;
        }

        private void undoImpersonation()
        {
            impersonationContext.Undo();
        }

        private static SqlDatabase AppDB = (SqlDatabase)DatabaseFactory.CreateDatabase("Connect_FileSvc");

        //private static string domain = ConfigurationManager.AppSettings["domain"].ToString();
        //private static string username = ConfigurationManager.AppSettings["username"].ToString();
        //private static string password = ConfigurationManager.AppSettings["password"].ToString();
        private static string RootPath = ConfigurationManager.AppSettings["UploadFilePath"].ToString();


        private log4net.ILog log = log4net.LogManager.GetLogger("LogFileAppender");

        public string Hello(string yourName)
        {
            return string.Format("{0}，你好！",yourName);
        }

        public UploadFileReturnMessage UploadFile(UploadFileMessage request)
        {           
            //log.Info("这是服务器端的日志信息！");
            log.Info("开始接收文件");

            Stream sourceStream = request.FileData;

            //  模拟用户
            //log.Info(string.Format("模拟用户：domain={0}， username={1}, password={2}",domain, username, password));
//            impersonateValidUser(username, domain, password);
            //impersonateValidUser("mengfanlai", "zzdnsoft", "mfl@5808359");

            //log.Info("get RootPath ... ");

            if (string.IsNullOrWhiteSpace(RootPath)) RootPath = @"D:\";

            log.Info("RootPath=" + RootPath);

            string fileName = RootPath;
            //if (fileName.Substring(fileName.Length, 1) != @"\") fileName = fileName + @"\";

            if (!string.IsNullOrEmpty(request.SavePath))
            {
                fileName = fileName + request.SavePath;
                if (!Directory.Exists(fileName)) Directory.CreateDirectory(fileName);
                fileName = fileName + @"\";
            }
            //log.Info("fileName = " + fileName);

            fileName = fileName + Path.GetFileName(request.FileName);
            if (File.Exists(fileName)) File.Delete(fileName);
            //log.Info("fileName = " + fileName);

            //log.Info("targetStream creating ..." + fileName);

            FileStream targetStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

            //log.Info("targetStream created !");

            sourceStream.CopyTo(targetStream);
            targetStream.Flush();

            //log.Info("targetStream copied !");

            targetStream.Close();
            sourceStream.Close();

            //log.Info("targetStream closed !");
            
            log.Info("接收文件完毕");

            Guid Stream_ID = new Guid();
            return new UploadFileReturnMessage() { Stream_ID = Stream_ID, FilePath = fileName, Path = "", Index = request.Index };
        }

        public IAsyncResult BeginUploadFile(UploadFileMessage request, AsyncCallback callback, object asyncState)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public UploadFileReturnMessage EndUploadFile(IAsyncResult asyncResult)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public DownloadFileReturnMessage DownloadFile(DownloadFileMessage request)
        {
            //log.Info("这是服务器端的日志信息！");
            log.Info("开始下载文件");

            long fileSize = 0;
            Stream targetStream = null;
            string tag = null;

            string fileName = RootPath + request.FilePath + @"\" + request.FileName;
            try
            {
                targetStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                fileSize = targetStream.Length;
            }
            catch (Exception e)
            {
                tag = e.Message;
                targetStream = new MemoryStream();
            }

            // ??? 这是异步调用,什么时候执行以下语句
            //transaction.Commit();
            //cnn.Close();
            log.Info("下载文件完毕");

            return new DownloadFileReturnMessage() { FileData = targetStream, FileSize = fileSize, Index = request.Index, Tag = tag };
        }

        public IAsyncResult BeginDownloadFile(DownloadFileMessage request, AsyncCallback callback, object asyncState)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public DownloadFileReturnMessage EndDownloadFile(IAsyncResult asyncResult)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public bool DeleteFile(string AFileName)
        {
            string fileName = RootPath + AFileName;

            File.Delete(fileName);

            return true;
        }

        public DataSet GetFileList()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);

            dt.Columns.Add(new DataColumn("序号", typeof(Int32)));
            dt.Columns.Add(new DataColumn("文件", typeof(string)));
            dt.Columns.Add(new DataColumn("大小", typeof(long)));

            string[] fs = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "文件传输");
            int index = 0;
            foreach (string f in fs)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(f);
                fi.OpenRead();
                dt.Rows.Add(new object[] { ++index, Path.GetFileName(f), fi.Length });
            }

            return ds;
        }
    }
}
