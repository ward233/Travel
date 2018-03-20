  

using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
	
	public partial interface IAdminInfoService : IBaseService<AdminInfo>
    {
       
    }   
	
	public partial interface IDepartmentService : IBaseService<Department>
    {
       
    }   
	
	public partial interface IEmpInfoService : IBaseService<EmpInfo>
    {
       
    }   
	
	public partial interface IFamilyInfoService : IBaseService<FamilyInfo>
    {
       
    }   
	
	public partial interface IFormNoticeService : IBaseService<FormNotice>
    {
       
    }   
	
	public partial interface ITravelCategoryService : IBaseService<TravelCategory>
    {
       
    }   
	
	public partial interface ITravelChoiceService : IBaseService<TravelChoice>
    {
       
    }   
	
	public partial interface ITravelStageService : IBaseService<TravelStage>
    {
       
    }   
	
	public partial interface IViewFinalStatisticService : IBaseService<ViewFinalStatistic>
    {
       
    }   
	
}