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
    public partial class Register : System.Web.UI.Page
    {
        IDepartmentService departmentService = new DepartmentService();
        IEmpInfoService empInfoService = new EmpInfoService();
        protected void Page_Load(object sender, EventArgs e)
        {

            

            if (!IsPostBack)
            {
                var departList = departmentService.LoadAllEntities().ToList();
                List<DDLType> ddlTypeList = new List<DDLType>();
                foreach (var department in departList)
                {
                    ddlTypeList.Add(new DDLType() { Id = department.Id, TypeName = department.DepName });
                }
                DDLTool.ItemsBind(ddl_Department, ddlTypeList, "请选择部门类型");
            }
        }

        protected void btn_Submit_OnClick(object sender, EventArgs e)
        {
            var empInfoValidate = empInfoService.LoadEntities(emp => emp.EmpCode == txt_EmpCode.Text).FirstOrDefault();
            if (empInfoValidate != null)
            {
                string message = Toast.GetToast("", "注册失败，工号已存在","error");
                ScriptManager.RegisterClientScriptBlock(this.UpdatePanel1, this.UpdatePanel1.GetType(), "alert", message, false);
                return;
            }

            var empInfo = new EmpInfo();
            empInfo.RealName = txt_RealName.Text;
            empInfo.EmpCode = txt_EmpCode.Text;
            string sex = Request.Form["sex"];
            empInfo.Sex = sex == "男" ? "男" : "女";
            empInfo.IdCard = txt_IdCard.Text;
            empInfo.Password = MD5Control.GetMd5Hash(txt_PassW.Text);
            empInfo.DepartmentId = Convert.ToInt32(ddl_Department.SelectedValue);
            empInfoService.AddEntity(empInfo);
            string jsText = Toast.GetToast("","注册成功");
            ScriptManager.RegisterClientScriptBlock(this.UpdatePanel1, this.UpdatePanel1.GetType(), "alert", jsText, false);
        }
    }
}