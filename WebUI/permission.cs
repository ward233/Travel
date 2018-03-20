using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using BLL;
using IBLL;
using Model;

namespace WebUI
{
    public class permission : Page
    {
        IEmpInfoService empInfoService = new EmpInfoService();
        IFamilyInfoService familyInfoService = new FamilyInfoService();
        protected EmpInfo empInfo;
        protected override void OnInit(EventArgs e)
        {
            //todo hack 代码 
            Session["EmpInfo"] = empInfoService.FindEntity(10);

            empInfo = Session["EmpInfo"] as EmpInfo;

            if (empInfo == null)
            {
                Response.Redirect("Login.aspx");
            }

            FamilyInfo familyInfo = familyInfoService.LoadEntities(f => f.IsTeacher == true && f.EmpInfoId == empInfo.Id).FirstOrDefault();
            if (familyInfo == null)
            {
                if (Request.FilePath != "/CompleteInfo.aspx")
                {
                    Response.Redirect("CompleteInfo.aspx");
                }
                
            }

        }
    }
}