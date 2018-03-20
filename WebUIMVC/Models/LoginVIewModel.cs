using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Model;

namespace WebUIMVC.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "工号不能为空")]
        public string Empcode { get; set; }
        [Required(ErrorMessage = "密码不能为空")]
        public string Password { get; set; }
        [Required(ErrorMessage = "验证码不能为空")]
        public string Checkcode { get; set; }

        public FormNotice FormNotice { get; set; }
    }
}