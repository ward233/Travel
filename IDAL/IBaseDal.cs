using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
  public  interface IBaseDal<T> where T:class ,new()
    {
        IQueryable<T> LoadEntities(
    Expression<Func<T, bool>> whereLambda
    );

        IQueryable<T> LoadPageEntities<s>(int pageIndex, int pageSize, 
            Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderByLambda, bool isAsc);

        void DeleteEntity(T entity);
        void EditEntity(T entity);
        T AddEntity(T entity);

        void AddEntities(List<T> entities);
        T FindEntity(int id);
        IQueryable<T> LoadAllEntities();

        int TotalCount();
    }
}
