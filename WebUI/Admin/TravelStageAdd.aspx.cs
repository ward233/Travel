using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using BLL;
using IBLL;
using Model;

namespace WebUI.Admin
{



    public partial class TravelStageAdd : System.Web.UI.Page
    {
        ITravelCategoryService travelCategoryService = new TravelCategoryService();
        ITravelStageService travelStageService = new TravelStageService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var categoryList = travelCategoryService.LoadAllEntities().Select(t => new { t.Id, t.Title });
                List<TravelCategory> travelCategories = new List<TravelCategory>();
                foreach (var cate in categoryList)
                {
                    travelCategories.Add(new TravelCategory() { Id = cate.Id, Title = cate.Title });
                }

                RepCategory.DataSource = travelCategories;
                RepCategory.DataBind();
            }


        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            RepeaterItemCollection ReItems = RepCategory.Items;
            List<TravelCategory> travelCategoryList = new List<TravelCategory>();
            foreach (RepeaterItem item in ReItems)
            {
                HtmlInputCheckBox cbx = (HtmlInputCheckBox)item.FindControl("CbxCategory");
                if (cbx.Checked)
                {
                    int id = int.Parse(cbx.Value);
                    TravelCategory travelCategory = travelCategoryService.FindEntity(id);
                    if (travelCategory != null)
                    {
                        travelCategoryList.Add(travelCategory);
                    }
                }
            }

            if (travelCategoryList.Count == 0)
            {
                  Page.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('未选择任何项目。请先选择项目');", true);
            }

            List<TravelStage> travelStages = new List<TravelStage>();

            foreach (var travelCategory in travelCategoryList)
            {
                TravelStage travelStage = new TravelStage();
                travelStage.StartDate = txt_StartDate.Text;
                travelStage.Count = int.Parse(txt_Count.Text);
                travelStage.Days = int.Parse(txt_Days.Text);
                travelStage.Price = double.Parse(txt_Price.Text);
                travelStage.TravelCategory = travelCategory;
               travelStages.Add(travelStage);
            }

           int count =  travelStageService.AddEntities(travelStages);

            Page.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('添加成功');", true);

        }
    }
}