using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Common
{
    public class DDLTool
    {
        public static void ItemsBind(DropDownList DDl_Control, List<DDLType> TypeList, string info = "请选择类型")
        {
            DDl_Control.Items.Clear();
            ListItem ls = new ListItem();
            ls.Value = "-1";
            ls.Text = info;
            DDl_Control.Items.Add(ls);
            foreach (var imgType in TypeList)
            {
                ls = new ListItem();
                ls.Value = imgType.Id.ToString();
                ls.Text = imgType.TypeName;
                DDl_Control.Items.Add(ls);
            }

        }
    }

    public class DDLType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

    }
}
