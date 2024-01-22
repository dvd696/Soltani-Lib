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


        private IUserInterface _userInterface;
        public IUserInterface UserService
        {
            get
            {
                if (_userInterface == null)
                {
                    _userInterface = new UserService(context);
                }
                return _userInterface;
            }
        }


        private ICategoryInterface _categoryService;
        public ICategoryInterface CategoryService
        {
            get
            {
                if(_categoryService == null)
                {
                    _categoryService = new CategoryService(context);
                }
                return _categoryService;
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
