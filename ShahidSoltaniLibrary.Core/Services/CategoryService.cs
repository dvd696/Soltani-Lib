using ShahidSoltaniLibrary.Core.Interfaces;
using ShahidSoltaniLibrary.DataLayer.Context;
using ShahidSoltaniLibrary.DataLayer.Entities;
using ShahidSoltaniLibrary.DataLayer.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.Services
{
    public class CategoryService : ICategoryInterface
    {
        private LibraryContext _context;

        public CategoryService(LibraryContext context)
        {
            _context = context;
        }

        public bool Add(Category category)
        {
            try
            {
                _context.Categories.Add(category);
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }

        public bool Delete(Category category)
        {
            try
            {
                _context.Categories.Remove(category);
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }

        public bool Delete(int categoryId)
        {
            var category = GetOneById(categoryId);
            return Delete(category);
        }

        public bool Edit(Category category)
        {
            try
            {
                _context.Categories.AddOrUpdate(category);
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }

        public List<Category> GetAll(string name = "")
        {
            List<Category> Category;
            if (name != "" && name != null)
                Category = _context.Categories.Where(c => c.Title.Contains(name)).ToList();
            else
                Category = _context.Categories.ToList();
            return Category;
        }

        public Category GetOneById(int categoryId)
        {
            return _context.Categories.Find(categoryId);
        }

        public bool IsExist(string title)
        {
            return _context.Categories.Any(c => c.Title == title);
        }
    }
}
