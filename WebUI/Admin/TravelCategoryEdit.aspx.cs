using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using IBLL;
using Model;

namespace WebUI.Admin
{
    public partial class TravelCategoryEdit : System.Web.UI.Page
    {
        ITravelCategoryService travelCategoryService = new TravelCategoryService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id;
                bool isParser = int.TryParse(Request["id"], out id);
                if (!isParser)
                {
                    Response.Redirect("TravelCategoryList.aspx");
                }

                TravelCategory travelCategory = travelCategoryService.FindEntity(id);
                if (travelCategory == null)
                {
                    Response.Redirect("TravelCategoryList.aspx");
                }

                txt_Title.Text = travelCategory.Title;
                txt_Editor.Text = travelCategory.Content;
                txt_Title.ToolTip = travelCategory.Id.ToString();
            }
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            int id = int.Parse(txt_Title.ToolTip);
            TravelCategory travelCategory = travelCategoryService.FindEntity(id);
            travelCategory.Title = txt_Title.Text;
            travelCategory.Content = txt_Editor.Text;
            bool isUpdate = travelCategoryService.EditEntity(travelCategory);

            if (isUpdate)
            {
                  Page.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('文章更新成功');", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('文章更新失败');", true);
            }


        }
    }
}