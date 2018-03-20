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
    public partial class TravelCategoryList : System.Web.UI.Page
    {
        ITravelCategoryService travelCategoryService = new TravelCategoryService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //assuming the total record number you want to page through is 288
                AspNetPager.RecordCount = travelCategoryService.TotalCount();

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
                travelCategoryService.LoadPageEntities(CurrentPageIndex, 10, c => true, c => c.Id, true).ToList();
            DataBind();
        }


        protected void Btn_Show_OnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string id = button.ToolTip;
            Response.Redirect("TravelCategoryDetail.aspx?id=" + id);

        }

        protected void Btn_Update_OnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string id = button.ToolTip;
            Response.Redirect("TravelCategoryEdit.aspx?id=" + id);

        }

        protected void Btn_Delete_OnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int id = int.Parse(button.ToolTip);

            var category = travelCategoryService.FindEntity(id);
            bool isDelete = travelCategoryService.DeleteEntity(category);

            if (isDelete)
            {
                BodyDataBind();

                Page.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('删除成功');", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('删除失败');", true);
            }

        }
    }
}