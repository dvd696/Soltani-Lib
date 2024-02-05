using ShahidSoltaniLibrary.Core.ViewModels;
using ShahidSoltaniLibrary.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.Interfaces
{
    public interface IUserInterface
    {
        IEnumerable<User> GetAllUser();
        List<NameUser> GetAllActiveUser(string userName);
        List<ShowUser> GetAllUser(string userName);
        User GetUserById(int userId);
        User GetUserByUserName(string userName);
        bool IsExistsUser(string userName);
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(User user);
        bool DeleteUser(int id);
        bool ChangeStatus(int userId);
    }
}
