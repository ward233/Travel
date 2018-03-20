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
    public partial class FinalStatistic : System.Web.UI.Page
    {
        IViewFinalStatisticService finalStatisticService = new ViewFinalStatisticService();
        protected void Page_Load(object sender, EventArgs e)
        {
            AspNetPager.RecordCount = finalStatisticService.TotalCount();
            BodyDataBind();

        }
        protected void AspNetPager_OnPageChanged(object sender, EventArgs e)
        {
            BodyDataBind();
        }
        private void BodyDataBind()
        {
            repTableBody.DataSource =
                finalStatisticService.LoadPageEntities(CurrentPageIndex, 10, c => true, c => c.EmpCode, true).ToList();
            DataBind();
        }
        protected int CurrentPageIndex => AspNetPager.CurrentPageIndex;
    }
}