using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUIMVC.Areas.Admin.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "用户名不能为空")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "密码不能为空")]
        public string UserPwd { get; set; }

        [Required(ErrorMessage = "验证码不能为空")]
        public string CheckCode { get; set; }
    }
}