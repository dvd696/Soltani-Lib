using ShahidSoltaniLibrary.Core.Interfaces;
using ShahidSoltaniLibrary.Core.Services;
using ShahidSoltaniLibrary.DataLayer.Context;
using ShahidSoltaniLibrary.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.Core
{
    public class UnitOfWork : IDisposable
    {
        private LibraryContext context;
        public UnitOfWork()
        {
            context = new LibraryContext();
        }


        private IUserInterface _userService;
        public IUserInterface UserService
        {
            get
            {
                if (_userService == null)
                {
                    _userService = new UserService(context);
                }
                return _userService;
            }
        }


        private ICategoryInterface _categoryService;
        public ICategoryInterface CategoryService
        {
            get
            {
                if (_categoryService == null)
                {
                    _categoryService = new CategoryService(context);
                }
                return _categoryService;
            }
        }


        private ILoginInterface _loginService;
        public ILoginInterface LoginService
        {
            get
            {
                if (_loginService == null)
                {
                    _loginService = new LoginService(context);
                }
                return _loginService;
            }
        }


        private IBookInterface _bookService;
        public IBookInterface BookService 
        {
            get
            {
                if (_bookService == null)
                {
                    _bookService = new BookService(context);
                }
                return _bookService;
            }
        }


        private ILoanInterface _loanService;
        public ILoanInterface LoanService
        {
            get
            {
                if (_loanService == null)
                {
                    _loanService = new LoanService(context);
                }
                return _loanService;
            }
        }


        public bool Save()
        {
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
