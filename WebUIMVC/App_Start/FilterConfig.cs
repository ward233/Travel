using System.Web;
using System.Web.Mvc;
using WebUIMVC.infrastructure;

namespace WebUIMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
//            filters.Add(new HandleErrorAttribute());
            filters.Add(new MyExceptionAttribute());
        }
    }
}
