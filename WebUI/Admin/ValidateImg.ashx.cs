using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;
using System.IO;
using System.Web.SessionState;

namespace WebUI.Admin
{
    /// <summary>
    /// ValidateImg 的摘要说明
    /// </summary>
    public class ValidateImg : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {


            ImageDValidate idv = new ImageDValidate(4);
            string valicode = idv.GetCode();
            //用于验证时比对

            context.Session["valicode"] = valicode;
            MemoryStream ms = idv.GetImageCode(valicode);

            context.Response.ClearContent();
            //向页面输出图片的字节流，生成图片
            context.Response.ContentType = "image/Jpeg";
            context.Response.BinaryWrite(ms.ToArray());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}