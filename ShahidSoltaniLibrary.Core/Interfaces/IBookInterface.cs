using ShahidSoltaniLibrary.Core.ViewModels;
using ShahidSoltaniLibrary.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.Interfaces
{
    public interface IBookInterface
    {
        List<ShowBooks> GetAllBooks(string title,int categoryId,string status);
        List<NameBook> GetBooksName(string bookName);
        Book GetBookById(int bookId);
        Book GetBookByName(string bookName);
        bool Add(Book book);
        bool Update(Book book);
        bool Delete(Book book);
        bool Delete(int bookId);
    }
}
