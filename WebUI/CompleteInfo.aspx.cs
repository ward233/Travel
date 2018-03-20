using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using IBLL;
using Model;

namespace WebUI
{
    public partial class CompleteInfo : permission
    {
        IEmpInfoService empInfoService = new EmpInfoService();
        IFamilyInfoService familyInfoService = new FamilyInfoService();
        protected FamilyInfo familyInfo;
        protected void Page_Load(object sender, EventArgs e)
        {
                EmpInfo empInfo = Session["EmpInfo"] as EmpInfo;

                 familyInfo = familyInfoService
                    .LoadEntities(f => f.EmpInfoId == empInfo.Id && f.IsTeacher == true).FirstOrDefault();
            if (!IsPostBack)
            {
                if (familyInfo == null)
                {
                    txt_RealName.Text = empInfo.RealName;
                    txt_IdCard.Text = empInfo.IdCard;
                    txt_BirthDay.Text = empInfo.BirthDay;
                }
                else
                {
                    txt_RealName.Text = familyInfo.RealName;
                    txt_BirthDay.Text = familyInfo.BirthDay;
                    txt_Height.Text = familyInfo.Height.ToString();
                    txt_IdCard.Text = familyInfo.IdCard;
                    txt_LongTellNum.Text = familyInfo.LongTellNum;
                    txt_ShortTellNum.Text = familyInfo.ShortTellNum;
                }

            }


        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            string realName = txt_RealName.Text;
            string sex = Request.Form["Sex"];
            string idCard = txt_IdCard.Text;
            string birthDay = txt_BirthDay.Text;
            bool hasBed = Request.Form["HasBed"] != null;
            string height = txt_Height.Text;
            string longTellNum = txt_LongTellNum.Text;
            string shortTellNum = txt_ShortTellNum.Text;

            EmpInfo empInfo = Session["EmpInfo"] as EmpInfo;
            FamilyInfo familyInfo = familyInfoService
                .LoadEntities(f => f.IsTeacher == true && f.EmpInfoId == empInfo.Id).FirstOrDefault();
            if (familyInfo == null)
            {
                familyInfo = new FamilyInfo();
                familyInfo.EmpInfoId = empInfo.Id;
                familyInfo.RealName = realName;
                familyInfo.Sex = sex;
                familyInfo.IsTeacher = true;
                familyInfo.IdCard = idCard;
                familyInfo.BirthDay = birthDay;
                familyInfo.HasBed = hasBed;
                familyInfo.Height = Convert.ToDouble(height);
                familyInfo.LongTellNum = longTellNum;
                familyInfo.ShortTellNum = shortTellNum;
                familyInfoService.AddEntity(familyInfo);
                Page.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('个人信息添加成功');", true);

            }
            else
            {
                familyInfo.RealName = realName;
                familyInfo.Sex = sex;
                familyInfo.IsTeacher = true;
                familyInfo.IdCard = idCard;
                familyInfo.BirthDay = birthDay;
                familyInfo.HasBed = hasBed;
                familyInfo.Height = Convert.ToDouble(height);
                familyInfo.LongTellNum = longTellNum;
                familyInfo.ShortTellNum = shortTellNum;
                familyInfoService.EditEntity(familyInfo);
                Page.ClientScript.RegisterStartupScript(this.GetType(), null, "alert('个人信息修改成功');", true);
            }

        }
    }
}