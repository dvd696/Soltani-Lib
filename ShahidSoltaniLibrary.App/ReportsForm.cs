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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void UpdateData(string query = "", string status = "")
        {
            grd.DataSource = _uow.LoanService.GetAllLoan(query, status);
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
            btnEnd.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var status = MessageBox.Show("آیا مطمئنی؟", "d", MessageBoxButtons.OKCancel);
            if (grd.SelectedCells != null && status == DialogResult.OK)
            {
                int loanId = Convert.ToInt32(grd.SelectedCells[0].Value);
                var loan = _uow.LoanService.GetLoanById(loanId);

                if (!loan.Finish)
                {
                    foreach (var ubook in loan.UserBooks)
                    {
                        var book = _uow.BookService.GetBookById(ubook.BookId);
                        book.RemainNumber++;
                        _uow.BookService.Update(book);
                    }
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

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (grd.SelectedCells != null)
            {
                var status = MessageBox.Show("آیا مطمئنی؟", "d", MessageBoxButtons.OKCancel);
                int loanId = Convert.ToInt32(grd.SelectedCells[0].Value);
                var loan = _uow.LoanService.GetLoanById(loanId);
                if (status == DialogResult.OK && loan.Finish)
                {
                    MessageBox.Show("عملیات از قبل انجام شده");
                    return;
                }
                loan.Finish = true;
                loan.EndDate = DateTime.Now;
                _uow.LoanService.Update(loan);
                foreach (var ubook in loan.UserBooks)
                {
                    var book = _uow.BookService.GetBookById(ubook.BookId);
                    book.RemainNumber++;
                    _uow.BookService.Update(book);
                }
                bool res = _uow.Save();

                if (res)
                    MessageBox.Show("موفقیت");
                else
                    MessageBox.Show("شکست");

                UpdateData();
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            UpdateData(txtquery.Text, cmd.SelectedItem?.ToString());
        }
    }
}
