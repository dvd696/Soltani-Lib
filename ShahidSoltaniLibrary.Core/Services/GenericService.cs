using ShahidSoltaniLibrary.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.Services
{
    public class GenericService<T> where T : class
    {
        private LibraryContext _context;
        private DbSet<T> set;
        public GenericService(LibraryContext context)
        {
            _context = context;
            set = context.Set<T>();
        }

        public virtual IEnumerable<T> GetAll() => set;
        public virtual void Add(T entity) => set.Add(entity);
        public virtual void Edit(T entity) => set.Add(entity);
        public virtual T GetOneById(int id) => set.Find(id);
        public virtual bool IsExist(string title) =>
            _context.Categories.Any(t => t.Title == title);
        public virtual void Delete(T entity) => set.Remove(entity);
        public virtual void Delete(int id) => Delete(GetOneById(id));
    }
}
