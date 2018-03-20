using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DALFactory;
using IDAL;

namespace BLL
{
    public abstract class BaseService<T> where T : class, new()
    {
        public IDBSession CurrentDBSession
        {
            get { return DBSessionFactory.CreateDbSession(); }
        }

        public IBaseDal<T> CurrentDal { get; set; }

        public abstract void SetCurrentDal();

        public BaseService()
        {
            SetCurrentDal();
        }


        public T FindEntity(int id)
        {
            return CurrentDal.FindEntity(id);
        }

        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
        {
            return CurrentDal.LoadEntities(whereLambda);
        }

        public IQueryable<T> LoadPageEntities<s>(int pageIndex, int pageSize, 
            Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderByLambda, bool isAsc)
        {
            return CurrentDal.LoadPageEntities<s>(pageIndex, pageSize,  whereLambda, orderByLambda,
                isAsc);
        }

        public bool DeleteEntity(T entity)
        {
            CurrentDal.DeleteEntity(entity);
            return CurrentDBSession.SaveChanges();
        }

        public bool EditEntity(T entity)
        {
            CurrentDal.EditEntity(entity);
            return CurrentDBSession.SaveChanges();
        }
        public T AddEntity(T entity)

        {
             CurrentDal.AddEntity(entity);
            CurrentDBSession.SaveChanges();
            return entity;
        }

        public int AddEntities(List<T> entities)
        {
            CurrentDal.AddEntities(entities);
            return CurrentDBSession.Db.SaveChanges();
        }

        public IQueryable<T> LoadAllEntities()
        {
            return CurrentDal.LoadAllEntities();
        }

        public int TotalCount()
        {
            return CurrentDal.TotalCount();
        }
    }

}
