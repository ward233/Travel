using System.Linq;
using Model;

namespace BLL
{
    public partial class EmpInfoService
    {
        public EmpInfo Login(string empCode, string userPwd)
        {
            EmpInfo empInfo = LoadEntities(e => e.EmpCode == empCode && e.Password == userPwd).FirstOrDefault();

            return empInfo;
        }
    }
}