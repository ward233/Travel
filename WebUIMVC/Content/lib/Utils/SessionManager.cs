using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using Model;

namespace WebUIMVC.Utils
{
    public  class SessionManager
    {
        public static AdminInfo AdminInfo
        {
            get
            {
                var admin = HttpContext.Current.Session["admin"] as AdminInfo;
                return admin;
            }
            set { HttpContext.Current.Session["admin"] = value; }
        }

        public static EmpInfo EmpInfo
        {
            get
            {
                var emp = HttpContext.Current.Session["emp"] as EmpInfo;
                return emp;
            }

            set { HttpContext.Current.Session["emp"] = value; }
        }

        public static string VaildCode
        {
            get
            {
                var code = HttpContext.Current.Session["code"] as string;
                return code;
            }

            set { HttpContext.Current.Session["code"] = value; }
        }
    }
}