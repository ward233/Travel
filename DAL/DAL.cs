 

using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
		
	public partial class AdminInfoDal :BaseDal<AdminInfo>,IAdminInfoDal
    {

    }
		
	public partial class DepartmentDal :BaseDal<Department>,IDepartmentDal
    {

    }
		
	public partial class EmpInfoDal :BaseDal<EmpInfo>,IEmpInfoDal
    {

    }
		
	public partial class FamilyInfoDal :BaseDal<FamilyInfo>,IFamilyInfoDal
    {

    }
		
	public partial class FormNoticeDal :BaseDal<FormNotice>,IFormNoticeDal
    {

    }
		
	public partial class TravelCategoryDal :BaseDal<TravelCategory>,ITravelCategoryDal
    {

    }
		
	public partial class TravelChoiceDal :BaseDal<TravelChoice>,ITravelChoiceDal
    {

    }
		
	public partial class TravelStageDal :BaseDal<TravelStage>,ITravelStageDal
    {

    }
		
	public partial class ViewFinalStatisticDal :BaseDal<ViewFinalStatistic>,IViewFinalStatisticDal
    {

    }
	
}