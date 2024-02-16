using ShahidSoltaniLibrary.Core.Core;
using ShahidSoltaniLibrary.Core.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShahidSoltaniLibrary.App
{
    public partial class ShowReport : Form
    {
        private int _loanId;
        private UnitOfWork _uow;
        public ShowReport(int loanId)
        {
            InitializeComponent();
            _loanId = loanId;
            _uow = new UnitOfWork();
        }

        private void ShowReport_Load(object sender, EventArgs e)
        {
            var loan = _uow.LoanService.GetLoanById(_loanId);
            lblName.Text = loan.User.UserName;
            lblStartDate.Text = loan.StartDate.ToShamsi();
            lblEndDate.Text = (loan.EndDate!=null)?loan.EndDate.Value.ToShamsi():"هنوز بازگردانده نشده";
            string books = ""; 
            foreach (var book in _uow.LoanService.GetBooksLoan(_loanId))
            {
                books += book+" ";
            }
            lblBooks.Text = books;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
