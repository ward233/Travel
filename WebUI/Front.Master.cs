using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Common;
using IBLL;
using Model;

namespace WebUI
{
    public partial class Front : System.Web.UI.MasterPage
    {
        ITravelCategoryService travelCategoryService = new TravelCategoryService();
        IEmpInfoService empInfoService = new EmpInfoService();
        ITravelChoiceService travelChoiceService = new TravelChoiceService();
        IFamilyInfoService familyInfoService = new FamilyInfoService();
        protected EmpInfo empInfo;
        protected void Page_Load(object sender, EventArgs e)
        {

            empInfo = Session["EmpInfo"] as EmpInfo;
    

            LblRealName.Text = empInfo.RealName;

            if (!IsPostBack)
            {
                RepCategory.DataSource = travelCategoryService.LoadAllEntities().ToList();
                RepCategory.DataBind();
                   
            }

            ShowCurrentChoose();
            ShowFamilyInfo();

        }

        private void ShowFamilyInfo()
        {
            var familyInfos = familyInfoService.LoadEntities(f => f.IsTeacher == false && f.EmpInfoId == empInfo.Id).ToList();
            if (familyInfos.Count == 0)
            {
                sp_NoFamily.Visible = true;
            }
            RepFamilyInfo.DataSource = familyInfos;
            RepFamilyInfo.DataBind();
        }

        private void ShowCurrentChoose()
        {
            int empId = (Session["EmpInfo"] as EmpInfo).Id;
            TravelChoice travelChoice = travelChoiceService.LoadEntities(c => c.EmpInfo.Id == empId).FirstOrDefault();
            if (travelChoice == null)
            {
                sp_CurrentChoose.InnerText = "当前没有选择线路。";
                return;
            }

            btn_CancleChoose.Visible = true;
            btn_CancleChoose.ToolTip = travelChoice.Id.ToString();
            sp_CurrentChoose.InnerText = travelChoice.TravelCategory.Title + travelChoice.TravelStage.StartDate;
        }

        protected void btn_CancleChoose_OnClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(btn_CancleChoose.ToolTip);
            var choice = travelChoiceService.FindEntity(id);
            travelChoiceService.DeleteEntity(choice);
string jsText = Toast.GetToast(Request.Url.ToString(),"取消选择线路成功");ScriptManager.RegisterClientScriptBlock(this.UpdatePanel1, this.UpdatePanel1.GetType(), "alert", jsText, false);
        }
    }
}