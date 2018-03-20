using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using IBLL;
using Model;
using Webdiyer.WebControls.Mvc;
using WebUIMVC.Areas.Admin.Filter;

namespace WebUIMVC.Areas.Admin.Controllers
{

    [CustomAuth]
    public class TravelCategoryController : Controller
    {
        private readonly ITravelCategoryService travelCategoryService = new TravelCategoryService();
        // GET: Admin/TravelCategory
        public ActionResult Index(int pageIndex = 1)
        {
            PagedList<TravelCategory> travelCategories = travelCategoryService.LoadAllEntities().OrderByDescending(m => m.Id).ToPagedList(pageIndex, 1);
            return View(travelCategories);

        }

        public ActionResult Add()
        {

            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Add(TravelCategory travelCategory)
        {
            travelCategory.CreateDate = DateTime.Now;
            travelCategory.IsShow = true;
            travelCategoryService.AddEntity(travelCategory);
            ViewBag.Result = travelCategory.Id + "添加成功";
            return View();
        }

        public ActionResult List(int pageIndex)
        {
            PagedList<TravelCategory> travelCategories = travelCategoryService.LoadAllEntities().OrderByDescending(m => m.Id).ToPagedList(pageIndex, 10);
            return View(travelCategories);
        }

        public ActionResult Detail(int id = -1)
        {
            var vm = travelCategoryService.FindEntity(id);
            if (vm != null)
            {
                ViewBag.UrlRefer = Request.UrlReferrer;
                return View(vm);
            }

            return RedirectToAction("List");
        }

        public ActionResult Edit(int id = -1)
        {
            var vm = travelCategoryService.FindEntity(id);

            if (vm != null)
            {
                return View(vm);
            }

            return RedirectToAction("List");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(TravelCategory category)
        {
            var vm = travelCategoryService.FindEntity(category.Id);
            vm.Title = category.Title;
            vm.Content = category.Content;

            bool isEdited = travelCategoryService.EditEntity(vm);

            if (isEdited)
            {
                ViewBag.Result = category.Id + "修改成功";
                return View(category);
            }
            else
            {
                ViewBag.Result = category.Id + "修改不成功";
                return View(category);
            }

        }

        public ActionResult Delete(int id)
        {
            var vm = travelCategoryService.FindEntity(id);

            travelCategoryService.DeleteEntity(vm);

            return RedirectToAction("List");

        }
    }
}