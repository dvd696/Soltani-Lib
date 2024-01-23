using ShahidSoltaniLibrary.Core.Interfaces;
using ShahidSoltaniLibrary.DataLayer.Context;
using ShahidSoltaniLibrary.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.Services
{
    public class LoginService : ILoginInterface
    {
        private LibraryContext _context;

        public LoginService(LibraryContext context)
        {
            _context = context;
        }

        public bool Change(Login login)
        {
            try
            {
                _context.Login.Add(login);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(Login login)
        {
            try
            {
                _context.Login.Remove(login);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Login GetLastestLogin() =>
            _context.Login.SingleOrDefault(c => c.UserName == "Soltani5");


        public bool IsExistLogin(string username, string password) =>
            _context.Login.Any(l => l.UserName == username && l.Password == password);
    }
}
