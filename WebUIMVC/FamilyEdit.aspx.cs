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
    public partial class FamilyEdit : permission
    {
        IFamilyInfoService familyInfoService = new FamilyInfoService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id;
                bool isParser = int.TryParse(Request["id"], out id);
                FamilyInfo familyInfo = null;
                if (isParser)
                {
                    familyInfo = familyInfoService.FindEntity(id);
                }

                if (familyInfo == null)
                {
                    Response.Redirect("FamilyList.aspx");
                }

                txt_Height.Text = familyInfo.Height.ToString();
                txt_BirthDay.Text = familyInfo.BirthDay;
                txt_IdCard.Text = familyInfo.IdCard;
                txt_LongTellNum.Text = familyInfo.LongTellNum;
                txt_ShortTellNum.Text = familyInfo.ShortTellNum;
                txt_RealName.Text = familyInfo.RealName;

                if (familyInfo.Sex == "男")
                {
                    rad_Man.Checked = true;
                }
                else
                {
                    rad_Woman.Checked = true;
                }

                ckb_HasBed.Checked = familyInfo.HasBed;
                btnSubmit.ToolTip = familyInfo.Id.ToString();


            }
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {

            int id = int.Parse(btnSubmit.ToolTip);

            FamilyInfo familyInfo = familyInfoService.FindEntity(id);
            familyInfo.HasBed = ckb_HasBed.Checked;
            familyInfo.Height = Convert.ToDouble(txt_Height.Text);
            familyInfo.IdCard = txt_IdCard.Text;
            familyInfo.LongTellNum = txt_LongTellNum.Text;
            familyInfo.Sex = rad_Man.Checked ? "男" : "女";
            familyInfo.ShortTellNum = txt_ShortTellNum.Text;
            familyInfo.BirthDay = txt_BirthDay.Text;
            familyInfo.IsTeacher = false;
            familyInfo.RealName = txt_RealName.Text;
            familyInfoService.EditEntity(familyInfo);
            string jsText = Toast.GetToast(Request.Url.ToString(),"家属信息修改成功");
            ScriptManager.RegisterClientScriptBlock(this.UpdatePanel1, this.UpdatePanel1.GetType(), "alert", jsText, false);
        }
    }
}