using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using BLL;
using IBLL;
using Model;
using Webdiyer.WebControls.Mvc;
using WebGrease.Css.Extensions;
using WebUIMVC.Areas.Admin.Filter;

namespace WebUIMVC.Areas.Admin.Controllers
{
    [CustomAuth]
    public class TravelStageController : Controller
    {
        private ITravelStageService travelStageService = new TravelStageService();
        private ITravelCategoryService travelCategoryService = new TravelCategoryService();

        // GET
        public ActionResult List(int pageIndex)
        {
            var travelStages = travelStageService.LoadAllEntities().OrderByDescending(m => m.Id)
                .ToPagedList(pageIndex, 10);
            
            return View(travelStages);
        }

        public ActionResult Add()
        {
            var travelCategories = travelCategoryService.LoadAllEntities();

            return View(travelCategories);
        }

        [HttpPost]
        public ActionResult Add(int[] id,TravelStage vm)
        {

            var travelCategories = travelCategoryService.LoadEntities(m => id.Contains(m.Id)).Include(m => m.TravelStage);
            travelCategories.ForEach(t=>
            {
                var item = new TravelStage
                {
                    Count = vm.Count,
                    Days = vm.Days,
                    Price = vm.Price,
                    StartDate = vm.StartDate
                };
                t.TravelStage.Add(item);
            });

            travelCategoryService.CurrentDBSession.SaveChanges();

            return RedirectToAction("Add");
        }

        public ActionResult Edit(int id = -1)
        {
            var vm = travelStageService.FindEntity(id);

            if (vm == null)
            {
                return RedirectToAction("List");
            }

            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(TravelStage travelStage)
        {

            TravelStage travelStage2 = travelStageService.FindEntity(travelStage.Id);

            travelStage2.Count = travelStage.Count;
            travelStage2.Days = travelStage.Days;
            travelStage2.Price = travelStage.Price;
            travelStage2.StartDate = travelStage.StartDate;
            travelStageService.EditEntity(travelStage2);

                return RedirectToAction("List");
            
        }

        public ActionResult Delete(int id)
        {
            var vm = travelStageService.FindEntity(id);

            travelStageService.DeleteEntity(vm);

            return RedirectToAction("List");
        }
    }
}