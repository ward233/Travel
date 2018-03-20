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
    public partial class TravelStageEdit : System.Web.UI.Page
    {
        ITravelStageService travelStageService = new TravelStageService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id;
                bool isParser = int.TryParse(Request["id"], out id);
                if (!isParser)
                {
                    Response.Redirect("TravelStageList.aspx");
                }

                TravelStage travelStage = travelStageService.FindEntity(id);
                if (travelStage == null)
                {
                    Response.Redirect("TravelStageList.aspx");
                }

                txt_Title.Text = travelStage.TravelCategory.Title;
                txt_Title.ToolTip = travelStage.Id.ToString();
                txt_StartDate.Text = travelStage.StartDate;
                txt_Count.Text = travelStage.Count.ToString();
                txt_Days.Text = travelStage.Days.ToString();
                txt_Price.Text = travelStage.Price.ToString();
            }
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            int id = int.Parse(txt_Title.ToolTip);
            TravelStage travelStage = travelStageService.FindEntity(id);
            travelStage.Count = Convert.ToInt32(txt_Count.Text);
            travelStage.Days = Convert.ToInt32(txt_Days.Text);
            travelStage.StartDate = txt_StartDate.Text;
            travelStage.Price = Convert.ToDouble(txt_Price.Text);

        }
    }
}