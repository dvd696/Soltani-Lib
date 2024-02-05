using ShahidSoltaniLibrary.Core.ViewModels;
using ShahidSoltaniLibrary.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.Interfaces
{
    public interface ILoanInterface
    {
        List<Loan> GetAllLoan(string query, string status);
        bool CheckUserNoOpenLoan(int userId);
        Loan GetLoanById(int loanId);
        bool Add(Loan loan);
        bool AddUserBooks(UserBook book);
        bool Update(Loan loan);
        bool Delete(Loan loan);
        bool Delete(int loanId);
    }
}
