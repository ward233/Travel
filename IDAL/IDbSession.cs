 

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
	public partial interface IDBSession
    {

	
		IAdminInfoDal AdminInfoDal{get;set;}
	
		IDepartmentDal DepartmentDal{get;set;}
	
		IEmpInfoDal EmpInfoDal{get;set;}
	
		IFamilyInfoDal FamilyInfoDal{get;set;}
	
		IFormNoticeDal FormNoticeDal{get;set;}
	
		ITravelCategoryDal TravelCategoryDal{get;set;}
	
		ITravelChoiceDal TravelChoiceDal{get;set;}
	
		ITravelStageDal TravelStageDal{get;set;}
	
		IViewFinalStatisticDal ViewFinalStatisticDal{get;set;}
	}	
}