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
    public partial class FamilyList : permission
    {
        IFamilyInfoService familyInfoService = new FamilyInfoService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //assuming the total record number you want to page through is 288
                AspNetPager.RecordCount = familyInfoService
                    .LoadEntities(c => c.IsTeacher == false && c.EmpInfoId == empInfo.Id).Count();

                BodyDataBind();
            }
        }



        protected void AspNetPager_OnPageChanged(object sender, EventArgs e)
        {
            BodyDataBind();
        }

        protected int CurrentPageIndex => AspNetPager.CurrentPageIndex;

        private void BodyDataBind()
        {
            repTableBody.DataSource =
                familyInfoService.LoadPageEntities(CurrentPageIndex, 10, c => c.IsTeacher == false && c.EmpInfoId == empInfo.Id, c => c.Id, true).ToList();
            DataBind();
        }

        protected void btn_Update_OnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string id = button.ToolTip;
            Response.Redirect("FamilyEdit.aspx?id=" + id);
        }

        protected void btn_Delete_OnClick(object sender, EventArgs e)
        {
            
            Button button = (Button) sender;
            int id = Convert.ToInt32(button.ToolTip);

            FamilyInfo familyInfo = familyInfoService.FindEntity(id);
            if (familyInfo == null)
            {
                return;
            }
            string jsText;
            if (familyInfoService.DeleteEntity(familyInfo))
            {
                 jsText =  Toast.GetToast(Request.Url.ToString(), "删除成功");
              
            }
            else
            {
                jsText = Toast.GetToast(Request.Url.ToString(), "删除失败");
            }

            ScriptManager.RegisterClientScriptBlock(this.UpdatePanel1, this.UpdatePanel1.GetType(), "alert", jsText, false);

        }
    }
}