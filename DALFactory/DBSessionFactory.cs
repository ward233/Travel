using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using IDAL;

namespace DALFactory
{
   public class DBSessionFactory
    {
        /// <summary>
        /// 返回一个线程内唯一的DbSession
        /// </summary>
        /// <returns></returns>
        public static IDBSession CreateDbSession()
        {
            IDBSession DbSession = (IDBSession) CallContext.GetData("dbSession");
            if (DbSession == null)
            {
                DbSession = new DALFactory.DBSession();
                CallContext.SetData("dbSession", DbSession);
            }

            return DbSession;
        }
    }
}
