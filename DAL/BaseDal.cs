using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DAL
{
    public class BaseDal<T> where T : class, new()
    {
        //        DbContainer Db = new DbContainer();
        public DbContext Db => DBContextFactory.CreateDbContext();
        public T AddEntity(T entity)

        {
            Db.Set<T>().Add(entity);
            return entity;
        }

        public void AddEntities(List<T> entities)
        {
            Db.Set<T>().AddRange(entities);
        }


        public void DeleteEntity(T entity)
        {
            Db.Entry(entity).State = EntityState.Deleted;
        }

        public void EditEntity(T entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// 查询过滤
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
        {
            return Db.Set<T>().Where(whereLambda);
        }

        public IQueryable<T> LoadAllEntities()
        {
            return Db.Set<T>();
        }


        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="s"></typeparam>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>

        /// <param name="whereLambda"></param>
        /// <param name="orderByLambda"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        public IQueryable<T> LoadPageEntities<s>(int pageIndex, int pageSize,  Expression<Func<T, bool>> whereLambda, Expression<Func<T, s>> orderByLambda, bool isAsc)
        {
            var temp = Db.Set<T>().Where(whereLambda);
            int totalCout = temp.Count();
            if (isAsc) // 升序
            {
                temp = temp.OrderBy(orderByLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            else
            {
                temp = temp.OrderByDescending(orderByLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }

            return temp;
        }

        public T FindEntity(int id)
        {
            return Db.Set<T>().Find(id);
        }

        public int TotalCount()
        {
            return Db.Set<T>().Count();
        }
    }
}
