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
    public partial class FamilyAdd : permission
    {
        IFamilyInfoService familyInfoService = new FamilyInfoService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            

            FamilyInfo familyInfo = new FamilyInfo();
            familyInfo.EmpInfoId = empInfo.Id;
            familyInfo.HasBed = ckb_HasBed.Checked;
            familyInfo.Height = Convert.ToDouble(txt_Height.Text);
            familyInfo.IdCard = txt_IdCard.Text;
            familyInfo.LongTellNum = txt_LongTellNum.Text;
            familyInfo.Sex = rad_Man.Checked ? "男" : "女";
            familyInfo.ShortTellNum = txt_ShortTellNum.Text;
            familyInfo.BirthDay = txt_BirthDay.Text;
            familyInfo.IsTeacher = false;
            familyInfo.RealName = txt_RealName.Text;
            familyInfoService.AddEntity(familyInfo);

            string jsText = Toast.GetToast(Request.Url.ToString());
            ScriptManager.RegisterClientScriptBlock(this.UpdatePanel1, this.UpdatePanel1.GetType(), "alert", jsText, false);

        }
    }
}