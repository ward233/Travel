 
using DAL;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALFactory
{
	public partial class DBSession : IDBSession
    {
	
		private IAdminInfoDal _AdminInfoDal;
        public IAdminInfoDal AdminInfoDal
        {
            get
            {
                if(_AdminInfoDal == null)
                {
                    _AdminInfoDal = new AdminInfoDal();
                }
                return _AdminInfoDal;
            }
            set { _AdminInfoDal = value; }
        }
	
		private IDepartmentDal _DepartmentDal;
        public IDepartmentDal DepartmentDal
        {
            get
            {
                if(_DepartmentDal == null)
                {
                    _DepartmentDal = new DepartmentDal();
                }
                return _DepartmentDal;
            }
            set { _DepartmentDal = value; }
        }
	
		private IEmpInfoDal _EmpInfoDal;
        public IEmpInfoDal EmpInfoDal
        {
            get
            {
                if(_EmpInfoDal == null)
                {
                    _EmpInfoDal = new EmpInfoDal();
                }
                return _EmpInfoDal;
            }
            set { _EmpInfoDal = value; }
        }
	
		private IFamilyInfoDal _FamilyInfoDal;
        public IFamilyInfoDal FamilyInfoDal
        {
            get
            {
                if(_FamilyInfoDal == null)
                {
                    _FamilyInfoDal = new FamilyInfoDal();
                }
                return _FamilyInfoDal;
            }
            set { _FamilyInfoDal = value; }
        }
	
		private IFormNoticeDal _FormNoticeDal;
        public IFormNoticeDal FormNoticeDal
        {
            get
            {
                if(_FormNoticeDal == null)
                {
                    _FormNoticeDal = new FormNoticeDal();
                }
                return _FormNoticeDal;
            }
            set { _FormNoticeDal = value; }
        }
	
		private ITravelCategoryDal _TravelCategoryDal;
        public ITravelCategoryDal TravelCategoryDal
        {
            get
            {
                if(_TravelCategoryDal == null)
                {
                    _TravelCategoryDal = new TravelCategoryDal();
                }
                return _TravelCategoryDal;
            }
            set { _TravelCategoryDal = value; }
        }
	
		private ITravelChoiceDal _TravelChoiceDal;
        public ITravelChoiceDal TravelChoiceDal
        {
            get
            {
                if(_TravelChoiceDal == null)
                {
                    _TravelChoiceDal = new TravelChoiceDal();
                }
                return _TravelChoiceDal;
            }
            set { _TravelChoiceDal = value; }
        }
	
		private ITravelStageDal _TravelStageDal;
        public ITravelStageDal TravelStageDal
        {
            get
            {
                if(_TravelStageDal == null)
                {
                    _TravelStageDal = new TravelStageDal();
                }
                return _TravelStageDal;
            }
            set { _TravelStageDal = value; }
        }
	
		private IViewFinalStatisticDal _ViewFinalStatisticDal;
        public IViewFinalStatisticDal ViewFinalStatisticDal
        {
            get
            {
                if(_ViewFinalStatisticDal == null)
                {
                    _ViewFinalStatisticDal = new ViewFinalStatisticDal();
                }
                return _ViewFinalStatisticDal;
            }
            set { _ViewFinalStatisticDal = value; }
        }
	}	
}