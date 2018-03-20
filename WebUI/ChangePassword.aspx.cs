using System;
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
    public partial class ChangePassword : permission
    {
        IEmpInfoService empInfoService = new EmpInfoService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            EmpInfo empInfo = empInfoService.FindEntity(base.empInfo.Id);
            empInfo.Password = MD5Control.GetMd5Hash(txt_NewPassword.Text);
            empInfoService.EditEntity(empInfo);
  Page.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('密码修改成功');", true);


        }
    }
}