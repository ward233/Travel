 
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
   
	
	public partial interface IAdminInfoDal :IBaseDal<AdminInfo>
    {
      
    }
	
	public partial interface IDepartmentDal :IBaseDal<Department>
    {
      
    }
	
	public partial interface IEmpInfoDal :IBaseDal<EmpInfo>
    {
      
    }
	
	public partial interface IFamilyInfoDal :IBaseDal<FamilyInfo>
    {
      
    }
	
	public partial interface IFormNoticeDal :IBaseDal<FormNotice>
    {
      
    }
	
	public partial interface ITravelCategoryDal :IBaseDal<TravelCategory>
    {
      
    }
	
	public partial interface ITravelChoiceDal :IBaseDal<TravelChoice>
    {
      
    }
	
	public partial interface ITravelStageDal :IBaseDal<TravelStage>
    {
      
    }
	
	public partial interface IViewFinalStatisticDal :IBaseDal<ViewFinalStatistic>
    {
      
    }
	
}