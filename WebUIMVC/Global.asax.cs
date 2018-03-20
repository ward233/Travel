using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.UI;
using log4net;
using WebUIMVC.infrastructure;

namespace WebUIMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            string filePath = Server.MapPath("/Log/");
            //开启一个线程，执行扫描队列的方法
            ThreadPool.QueueUserWorkItem((a) =>
            {
                //死循环导致函数永远不会退出，也就是线程永远不销毁
                while (true)
                {
                    if (MyExceptionAttribute.ExceptionQueue.Any())
                    {
                        Exception ex = MyExceptionAttribute.ExceptionQueue.Dequeue();
                        if (ex != null)
                        {
                            ILog logger = LogManager.GetLogger("errorMsg");
                            logger.Error(ex.ToString());
                        }
                        else
                        {
                            Thread.Sleep(3000);
                        }
                    }
                    else
                    {
                        Thread.Sleep(3000);
                        //如果没有数据，让线程休眠3秒钟，这样可以让这个死循环不是无限制的跑。
                    }
                }
            },filePath);


            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/scripts/jquery-3.3.1.min.js",
                DebugPath = "~/scripts/jquery-3.3.1.js"
            });

        }
    }
}
