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
    public partial class Login : System.Web.UI.Page
    {
        IFormNoticeService formNoticeService = new FormNoticeService();
        IEmpInfoService empInfoService = new EmpInfoService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FormNotice formNotice = formNoticeService.LoadAllEntities().FirstOrDefault();

                if (formNotice != null)
                {
                    div_FillForm.InnerHtml = formNotice.Content;
                }
            }
        }


        protected void btn_Login_Click(object sender, EventArgs e)
        {
            //用户名admin 密码1234@abcd
            if (HttpContext.Current.Session["fontvalicode"] != null)
            {

                if (HttpContext.Current.Session["fontvalicode"].ToString().ToLower() == txt_CheckCode.Text.ToLower())
                {
                    string empCode = txt_EmpCode.Text;
                    string userPwd = txt_UserPwd.Text;

                    string md5Pwd = MD5Control.GetMd5Hash(txt_UserPwd.Text.Trim()).ToLower();

                    EmpInfo empInfo = empInfoService.Login(empCode, md5Pwd);


                    bool isLogin = empInfo != null;

                    if (isLogin) // 测试代码 正式请替换成isLogin
                    {
                        Session["EmpInfo"] = empInfo;
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        MsgTxt.Text = "登陆失败，请检查。";
                    }




                }

                else
                {
                    MsgTxt.Text = "验证码错误！";

                }
            }
            else
                MsgTxt.Text = "验证码已过期，请刷新验证码重新获取！";
        }
    }
}