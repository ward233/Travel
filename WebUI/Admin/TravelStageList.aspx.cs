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
    public partial class TravelStageList : System.Web.UI.Page
    {
        ITravelStageService travelStageService = new TravelStageService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //assuming the total record number you want to page through is 288
                AspNetPager.RecordCount = travelStageService.TotalCount();

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
                travelStageService.LoadPageEntities(CurrentPageIndex, 10, c => true, c => c.TravelCategory.Title, true).ToList();
            DataBind();
        }

        protected void btn_Update_OnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string id = button.ToolTip;
            Response.Redirect("TravelStageEdit.aspx?id=" + id);
        }


        protected void btn_Delete_OnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int id = int.Parse(button.ToolTip);

            var stage = travelStageService.FindEntity(id);
            bool isDelete = travelStageService.DeleteEntity(stage);

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