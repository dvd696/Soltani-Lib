using ShahidSoltaniLibrary.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.Interfaces
{
    public interface ILoginInterface
    {
        Login GetLastestLogin();
        bool IsExistLogin(string username, string password);
        bool Change(Login login);
        bool Delete(Login login);
    }
}
