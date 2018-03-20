using Common;
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

    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      
        }


        protected void btn_Login_Click(object sender, EventArgs e)
        {
            //用户名admin 密码1234@abcd
            if (HttpContext.Current.Session["valicode"] != null)
            {

                if (HttpContext.Current.Session["valicode"].ToString().ToLower() == txt_CheckCode.Text.ToLower())
                {
                    string userName = txt_UserName.Text;
                    string userPwd = txt_UserPwd.Text;

                    string md5Pwd = MD5Control.GetMd5Hash(txt_UserPwd.Text.Trim()).ToLower();


                    bool isLogin = true;

                    if (isLogin) // 测试代码 正式请替换成isLogin
                    {
                        Session["userName"] = userName;
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