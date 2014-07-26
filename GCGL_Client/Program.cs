using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GCGL_Client.Main;
using GCGL_Client.RPT;
using System.Deployment.Application;
using System.Collections.Specialized;
using System.Web;

namespace GCGL_Client
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //集成登录验证
            if (ApplicationDeployment.IsNetworkDeployed && ApplicationDeployment.CurrentDeployment.ActivationUri != null)
            {
                //检查URL参数
                NameValueCollection col = new NameValueCollection();
                string queryString = ApplicationDeployment.CurrentDeployment.ActivationUri.Query;
                col = HttpUtility.ParseQueryString(queryString);
                string username = col["UserName"];
                string password = col["PassWord"];
                //
                if (!string.IsNullOrWhiteSpace(username))
                {
                    using (var form = new Man_Login())
                    {
                        form.Login(username, password);
                    }
                }
            }
            //启动主窗体
            Application.Run(new Man_Main());  
          
        }
    }
}
