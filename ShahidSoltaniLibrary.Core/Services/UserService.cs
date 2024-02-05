using ShahidSoltaniLibrary.Core.Interfaces;
using ShahidSoltaniLibrary.Core.Tools;
using ShahidSoltaniLibrary.Core.ViewModels;
using ShahidSoltaniLibrary.DataLayer.Context;
using ShahidSoltaniLibrary.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.Services
{
    public class UserService : IUserInterface
    {
        private LibraryContext _context;

        public UserService(LibraryContext context)
        {
            _context = context;
        }

        public bool AddUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ChangeStatus(int userId)
        {
            var user = GetUserById(userId);
            user.IsActive = (!user.IsActive);
            return UpdateUser(user);
        }

        public bool DeleteUser(User user)
        {
            try
            {
                _context.Users.Remove(user);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            var user = GetUserById(id);
            return DeleteUser(user);
        }

        public List<NameUser> GetAllActiveUser(string userName)
        {
            return _context.Users
                .Where(u => u.IsActive && u.UserName.Contains(userName))
                .Select(u => new NameUser() { Name = u.UserName })
                .ToList();
        }

        public IEnumerable<User> GetAllUser()
        {
            var Users = _context.Users;
            return Users;
        }

        public List<ShowUser> GetAllUser(string userName)
        {
            return _context.Users.Where(u => u.UserName.Contains(userName))
                .OrderByDescending(u => u.RegisterDate)
                .ToList()
                .Select(u => new ShowUser()
                {
                    UserName = u.UserName,
                    IsActive = (u.IsActive) ? "فعال" : "غیرفعال",
                    UserId = u.UserId,
                    RegisterDate = u.RegisterDate.ToShamsi()
                }).ToList();
        }

        public User GetUserById(int userId)
        {
            return _context.Users
                .SingleOrDefault(u => u.UserId == userId);
        }

        public User GetUserByUserName(string userName)
        {
            return _context.Users
                .SingleOrDefault(u => u.UserName == userName);
        }

        public bool IsExistsUser(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public bool UpdateUser(User user)
        {
            try
            {
                _context.Users.AddOrUpdate(user);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
