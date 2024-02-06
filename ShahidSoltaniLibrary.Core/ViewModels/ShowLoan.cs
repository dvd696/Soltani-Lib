using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahidSoltaniLibrary.Core.ViewModels
{
    public class ShowLoan
    {
        public ShowLoan()
        {

        }

        public int LoanId { get; set; }
        public string UserName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string IsFinish { get; set; }
    }
}
