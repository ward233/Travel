﻿using System;
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
    public partial class TravelCategoryShow : permission
    {
        ITravelCategoryService travelCategoryService = new TravelCategoryService();
        IEmpInfoService empInfoService = new EmpInfoService();
        ITravelChoiceService travelChoiceService = new TravelChoiceService();
        ITravelStageService travelStageService = new TravelStageService();
        IFamilyInfoService familyInfoService = new FamilyInfoService();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                int id;
                bool isParser = int.TryParse(Request["id"], out id);

                if (!isParser)
                {
                    Response.Redirect("Index.aspx");
                }

                var category = travelCategoryService.FindEntity(id);

                if (category == null)
                {
                    Response.Redirect("Index.aspx");
                }


                TravelChoice travelChoice =
                    travelChoiceService.LoadEntities(t => t.EmpInfo.Id == empInfo.Id).FirstOrDefault();

                if (travelChoice != null)
                {
                    btnSubmit.Text = "修改路线";
                }

                txt_Title.InnerText = category.Title;
                txt_Content.InnerHtml = category.Content;
                btnSubmit.ToolTip = id.ToString();
                RepStageChoice.DataSource = category.TravelStage.Where(t => t.Count > 0).ToList();

                RepStageChoice.DataBind();
            }


        }


        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.Form["stage"]))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('请选择后再提交');", true);
                return;
            }

            int stageId = Convert.ToInt32(Request.Form["stage"]);
            int cateId = Convert.ToInt32(btnSubmit.ToolTip);
            int count = familyInfoService.LoadEntities(f => f.EmpInfoId == empInfo.Id).Count();

            TravelStage travelStage = travelStageService.FindEntity(stageId);

            travelStage.Count -= count;
            travelStageService.EditEntity(travelStage);


            TravelChoice travelChoice =
                travelChoiceService.LoadEntities(t => t.EmpInfo.Id == empInfo.Id).FirstOrDefault();
            if (travelChoice == null)
            {
                var emp = empInfoService.FindEntity(base.empInfo.Id); // 这是一个坑，在添加的时候，外键对象必须来自dbcontext 而不是session
                travelChoice = new TravelChoice
                {
                    TravelStageId = stageId,
                    TravelCategoryId = cateId,
                    EmpInfo = emp,
                    CreateTime = DateTime.Now
                };
                travelChoiceService.AddEntity(travelChoice);
                string jsText = Toast.GetToast(Request.Url.ToString(), "行程添加成功");
                ScriptManager.RegisterClientScriptBlock(this.UpdatePanel1, this.UpdatePanel1.GetType(), "alert", jsText, false);
            }
            else
            {
                travelChoice.TravelStage.Count+= count;
                travelStageService.EditEntity(travelChoice.TravelStage);
                travelChoice.TravelStageId = stageId;
                travelChoice.TravelCategoryId = cateId;
                travelChoice.CreateTime = DateTime.Now;
                travelChoiceService.EditEntity(travelChoice);
                string jsText = Toast.GetToast(Request.Url.ToString(), "行程修改成功");
                ScriptManager.RegisterClientScriptBlock(this.UpdatePanel1, this.UpdatePanel1.GetType(), "alert", jsText, false);
            }






        }
    }
}