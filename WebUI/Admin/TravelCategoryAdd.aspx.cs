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
    public partial class TravelCategoryAdd : System.Web.UI.Page
    {
        ITravelCategoryService travelCategoryService = new TravelCategoryService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            TravelCategory travelCategory = new TravelCategory();
            travelCategory.Title = txt_Title.Text;
            travelCategory.Content = txt_Editor.Text;
            travelCategory.CreateDate = DateTime.Now;
            travelCategory.IsShow = true;
            int id= travelCategoryService.AddEntity(travelCategory).Id;

            if (id > 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('文章添加成功');", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('文章添加失败');", true);
            }
        }
    }
}