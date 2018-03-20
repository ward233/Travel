using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using IDAL;
using Model;

namespace DALFactory
{
    /// <summary>
    /// 数据会话层:就是一个工厂类，负责完成所有数据操作类实例的创建，然后业务层通过数据会话层来获取要操作数据类的实例，所以数据会话层将业务层与数据层解耦。
    /// </summary>
    public partial class DBSession : IDBSession
    {
        //        DbContainer Db = new DbContainer();

        public DbContext Db => DBContextFactory.CreateDbContext();

        /// <summary>
        /// 因为DBSession有SaveChanges方法所以需要用到DbContext
        /// </summary>
        /// <returns></returns>
        public bool SaveChanges()
        {
            return Db.SaveChanges() > 0;
        }

        public int ExecuteSql(string sql, params SqlParameter[] pars)
        {
            return Db.Database.ExecuteSqlCommand(sql, pars);
        }
        public List<T> ExecuteQuery<T>(string sql, params SqlParameter[] pars)
        {
            return Db.Database.SqlQuery<T>(sql, pars).ToList();
        }
    }
}
