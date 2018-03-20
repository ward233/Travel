using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using IBLL;
using Model;
using WebUIMVC.Areas.Admin.Filter;

namespace WebUIMVC.Areas.Admin.Controllers
{
    [CustomAuth]
    public class FillNoticeController : Controller
    {
        IFormNoticeService formNoticeService = new FormNoticeService();

        // GET: Admin/FillNotice
        public ActionResult Index()
        {
            var formNotice = formNoticeService.LoadAllEntities().FirstOrDefault();

            if (formNotice == null)
            {
                return View(new FormNotice());
            }
            return View(formNotice);
        }
    }
}