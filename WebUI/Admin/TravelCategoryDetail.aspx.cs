using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using IBLL;

namespace WebUI.Admin
{
    public partial class TravelCategoryDetail : System.Web.UI.Page
    {
        ITravelCategoryService travelCategoryService = new TravelCategoryService();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            bool isParser = int.TryParse(Request["id"], out id);

            if (!isParser)
            {
                Response.Redirect("TravelCategoryList.aspx");
            }

            var category = travelCategoryService.FindEntity(id);

            if (category == null)
            {
                Response.Redirect("TravelCategoryList.aspx");
            }

            txt_Title.InnerText = category.Title;
            txt_Content.InnerHtml = category.Content;

            GoBack.HRef = Request.UrlReferrer.ToString();
        }

    }
}