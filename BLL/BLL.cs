 
using IBLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
	
	public partial class AdminInfoService :BaseService<AdminInfo>,IAdminInfoService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.AdminInfoDal;
        }
    }   
	
	public partial class DepartmentService :BaseService<Department>,IDepartmentService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.DepartmentDal;
        }
    }   
	
	public partial class EmpInfoService :BaseService<EmpInfo>,IEmpInfoService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.EmpInfoDal;
        }
    }   
	
	public partial class FamilyInfoService :BaseService<FamilyInfo>,IFamilyInfoService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.FamilyInfoDal;
        }
    }   
	
	public partial class FormNoticeService :BaseService<FormNotice>,IFormNoticeService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.FormNoticeDal;
        }
    }   
	
	public partial class TravelCategoryService :BaseService<TravelCategory>,ITravelCategoryService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.TravelCategoryDal;
        }
    }   
	
	public partial class TravelChoiceService :BaseService<TravelChoice>,ITravelChoiceService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.TravelChoiceDal;
        }
    }   
	
	public partial class TravelStageService :BaseService<TravelStage>,ITravelStageService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.TravelStageDal;
        }
    }   
	
	public partial class ViewFinalStatisticService :BaseService<ViewFinalStatistic>,IViewFinalStatisticService
    {
    

		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.ViewFinalStatisticDal;
        }
    }   
	
}