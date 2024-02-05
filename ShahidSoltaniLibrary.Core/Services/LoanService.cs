using ShahidSoltaniLibrary.Core.Interfaces;
using ShahidSoltaniLibrary.DataLayer.Context;
using ShahidSoltaniLibrary.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.Services
{
    public class LoanService : ILoanInterface
    {

        private LibraryContext _context;

        public LoanService(LibraryContext context)
        {
            _context = context;
        }

        public bool Add(Loan loan)
        {
            try
            {
                _context.Loans.Add(loan);
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }

        public bool AddUserBooks(UserBook book)
        {
            try
            {
                _context.UserBooks.Add(book);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool CheckUserNoOpenLoan(int userId)
        {
            return _context.Loans.Any(l => l.UserId == userId && !l.Finish);
        }

        public bool Delete(Loan loan)
        {
            try
            {
                _context.Loans.Remove(loan);
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }

        public bool Delete(int loanId)
        {
            Loan loan = GetLoanById(loanId);
            return Delete(loan);
        }

        public List<Loan> GetAllLoan(string query, string status)
        {
            IQueryable<Loan> Loans = _context.Loans.Include("User")
                .Include("UserBooks");
            if (!string.IsNullOrEmpty(query))
                Loans = Loans.Where(b => b.User.UserName.Contains(query));

            switch (status)
            {
                case "به اتمام رسیده":
                    {
                        Loans = Loans.Where(l => l.Finish);
                        break;
                    }
                case "در حال اجرا":
                    {
                        Loans = Loans.Where(l => !l.Finish);
                        break;
                    }
            }

            return Loans.OrderByDescending(l=> l.StartDate).ToList();
        }

        public Loan GetLoanById(int loanId) =>
            _context.Loans.Find(loanId);

        public bool Update(Loan loan)
        {
            try
            {
                _context.Loans.AddOrUpdate(loan);
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
