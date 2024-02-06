using ShahidSoltaniLibrary.Core.Core;
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
    public partial class ReportsForm : Form
    {
        private UnitOfWork _uow;
        public ReportsForm()
        {
            InitializeComponent();
            _uow = new UnitOfWork();
            UpdateData();
        }

        private void UpdateData()
        {
            grd.DataSource = _uow.LoanService.GetAllLoan(txtquery.Text, cmd.SelectedItem?.ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            var res = frm.ShowDialog();
            if (res == DialogResult.OK)
                UpdateData();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnEnd.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grd.SelectedCells != null)
            {
                int loanId = Convert.ToInt32(grd.SelectedCells[0].Value);
                var loan = _uow.LoanService.GetLoanById(loanId);

                foreach (var ubook in loan.UserBooks)
                {
                    var book = _uow.BookService.GetBookById(ubook.BookId);
                    book.RemainNumber++;
                    _uow.BookService.Update(book);
                }
                _uow.LoanService.Delete(loan);
                bool res = _uow.Save();

                if (res)
                    MessageBox.Show("موفقیت");
                else
                    MessageBox.Show("شکست");

                UpdateData();
            }
        }
    }
}
