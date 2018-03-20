using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using IBLL;
using Webdiyer.WebControls.Mvc;
using WebUIMVC.Areas.Admin.Filter;

namespace WebUIMVC.Areas.Admin.Controllers
{
    [CustomAuth]
    public class FinalResultController : Controller
    {

        IViewFinalStatisticService finalStatisticService = new ViewFinalStatisticService();
        // GET: Admin/FinalResult
        public ActionResult Index(int pageIndex)
        {
            var finalResult = finalStatisticService.LoadAllEntities().OrderByDescending(m => m.EmpCode)
                .ToPagedList(pageIndex, 10);

            return View(finalResult);
        }
    }
}