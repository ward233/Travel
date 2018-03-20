using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http.Controllers;
using WebUIMVC.Utils;

namespace WebUIMVC.Areas.Admin.Filter
{
    public class CustomAuthAttribute :AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (SessionManager.AdminInfo == null)
            {
                filterContext.Result = new RedirectResult("/Admin/Login/Login");
            }
        }
    }
}