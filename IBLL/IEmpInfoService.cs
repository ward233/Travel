using System.Collections.Generic;
using Model;
namespace IBLL
{
    public partial interface IEmpInfoService : IBaseService<EmpInfo>
    {
        EmpInfo Login(string empCode, string userPwd);
    }
}