using System.Web.Mvc;

namespace WebUIMVC.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{pageIndex}",
                new { action = "List", pageIndex = 1 },
                namespaces: new [] { "WebUIMVC.Areas.Admin.Controllers" }
            );
        }
    }
}