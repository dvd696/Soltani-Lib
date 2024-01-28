using ShahidSoltaniLibrary.Core.Interfaces;
using ShahidSoltaniLibrary.Core.ViewModels;
using ShahidSoltaniLibrary.DataLayer.Context;
using ShahidSoltaniLibrary.DataLayer.Entities;
using ShahidSoltaniLibrary.DataLayer.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.Services
{
    public class BookService : IBookInterface
    {
        private LibraryContext _context;

        public BookService(LibraryContext context)
        {
            _context = context;
        }

        public bool Add(Book book)
        {
            try
            {
                _context.Books.Add(book);
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }

        public bool Delete(int bookId)
        {
            Book book = GetBookById(bookId);
            return Delete(book);
        }

        public bool Delete(Book book)
        {
            try
            {
                _context.Books.Remove(book);
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }

        public List<ShowBooks> GetAllBooks(string title, int categoryId, string status)
        {
            IQueryable<Book> Books = _context.Books.Include("Category");
            if (!string.IsNullOrEmpty(title))
                Books = Books.Where(b => b.Title.Contains(title));
            if (categoryId > 0)
                Books = Books.Where(b => b.CategoryId == categoryId);

            switch (status)
            {
                case "فقط موجود ها":
                    {
                        Books = Books.Where(b => b.RemainNumber > 0);
                        break;
                    }
                case "فقط ناموجود ها":
                    {
                        Books = Books.Where(b => b.RemainNumber <= 0);
                        break;
                    }
            }

            List<ShowBooks> showBooks = Books
                .Select(b => new ShowBooks()
                {
                    BookId = b.BookId,
                    CanLoan = (b.CanLoan) ? "مجاز" : "غیرمجاز",
                    Category = b.Category.Title,
                    Title = b.Title,
                    NumberOfRemain = b.RemainNumber,
                    Number = b.Number
                }).ToList();

            return showBooks;
        }

        public Book GetBookById(int bookId) =>
            _context.Books.Find(bookId);

        public bool Update(Book book)
        {
            try
            {
                _context.Books.AddOrUpdate(book);
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }
    }
}
