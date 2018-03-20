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
    public partial class FillFormNotice : System.Web.UI.Page
    {
        IFormNoticeService formNoticeService = new FormNoticeService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FormNotice formNotice = formNoticeService.LoadAllEntities().FirstOrDefault();
                if (formNotice != null)
                {
                    txt_Editor.Text = formNotice.Content;
                }
            }
      
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            FormNotice formNotice = null;

            bool hasFormNotice = formNoticeService.TotalCount() > 0;
            if (hasFormNotice)
            {
                formNotice = formNoticeService.LoadAllEntities().FirstOrDefault();
                formNotice.Content = txt_Editor.Text;
                formNoticeService.EditEntity(formNotice);
                Page.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('填表须知修改成功');", true);
            }
            else
            {
                formNotice = new FormNotice();
                formNotice.Content = txt_Editor.Text;
                formNoticeService.AddEntity(formNotice);
                Page.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('填表须知添加成功');", true);
            }
        }
    }
}