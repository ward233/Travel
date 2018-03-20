using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    /// <summary>
    /// 负责创建EF数据操作上下文实例，必须保证线程内唯一
    /// </summary>
    public class DBContextFactory
    {
        /// <summary>
        /// 返回一个线程内唯一的DbContext
        /// </summary>
        /// <returns></returns>
        public static DbContext CreateDbContext()
        {
            DbContext dbContext = (DbContext) CallContext.GetData("dbContext");
            if (dbContext == null)
            {
                dbContext = new DbContainer();
                CallContext.SetData("dbContext",dbContext);
            }

            return dbContext;
        }
    }
}
