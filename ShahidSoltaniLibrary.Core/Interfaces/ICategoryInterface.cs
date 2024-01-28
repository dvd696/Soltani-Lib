using ShahidSoltaniLibrary.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.Interfaces
{
    public interface ICategoryInterface
    {
        List<Category> GetAll(string name="");
        bool Add(Category category);
        bool Edit(Category category);
        Category GetOneById(int categoryId);
        int GetIdByTitle(string title);
        bool IsExist(string title);
        bool Delete(Category category);
        bool Delete(int categoryId);
    }
}
