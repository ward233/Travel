using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Toast
    {
        public static string GetToast(string refushUrl, string message = "添加成功", string type = "success", string position = "toast-left-top")
        {
            string result;
            if (string.IsNullOrEmpty(refushUrl))
            {
                result = @"<script>
			toastr.options = {
				'timeOut': '800'
            }
            toastr['" + type + @"']('" + message + @"');
          </script>";

            }
            else
            {
                result = @"<script>
			toastr.options = {
				'timeOut': '800',
            'onHidden': function() { window.location.href='" + refushUrl + @"' }
            }
            toastr['" + type + @"']('" + message + @"');
          </script>";
            }


            return result;
        }
    }
}
