using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["userName"] = "admin";
            if (Session["userName"] == null || Session["userName"].ToString() == "")
            {
                Response.Redirect("Login.aspx");
            }
        }

    }
}