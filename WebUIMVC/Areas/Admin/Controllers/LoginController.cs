using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Common;
using IBLL;
using Model;
using WebUIMVC.Areas.Admin.Models.ViewModels;
using WebUIMVC.Utils;

namespace WebUIMVC.Areas.Admin.Controllers
{
    
    public class LoginController : Controller
    {
        IAdminInfoService adminInfoService = new AdminInfoService();
        // GET: Admin/Login
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            return null;
        }

        public FileResult VaildImg()
        {

            ImageDValidate idv = new ImageDValidate(4);
            string valicode = idv.GetCode();
            //用于验证时比对
            Session["AdminValidCode"] = valicode;
            MemoryStream ms = idv.GetImageCode(valicode);

            return File(ms.ToArray(), "image/jpeg");
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (vm.CheckCode.ToLower() != (Session["AdminValidCode"] as string)?.ToLower())
            {
                 ViewBag.ErrorMsg = "验证码错误";
                return View();
            }

            var adminInfo = adminInfoService
                .LoadEntities(m => m.LoginName == vm.UserName && m.Password == vm.UserPwd).FirstOrDefault();
            if (adminInfo == null)
            {
                ViewBag.ErrorMsg = "用户名或密码错误";
                return View();
            }

            SessionManager.AdminInfo = adminInfo;

            return RedirectToAction("List");
            
        }

        public ActionResult List()
        {
            AdminInfo adminInfo = SessionManager.AdminInfo;

            return View(SessionManager.AdminInfo);
        }
    }
}