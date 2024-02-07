using ShahidSoltaniLibrary.Core.Core;
using ShahidSoltaniLibrary.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShahidSoltaniLibrary.App
{
    public partial class ReportForm : Form
    {
        private UnitOfWork _uow;
        private string booksSelected = "";
        private int numberBook = 0;
        public ReportForm()
        {
            InitializeComponent();
            _uow = new UnitOfWork();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
                err.SetError(txtName, "یک شخص را انتخاب کنید");
            if (string.IsNullOrEmpty(txtBooks.Text))
                err.SetError(txtName, "حداقل یک کتاب را انتخاب کنید");
            else
            {
                err.Clear();
                //Check User Has No Open Any Loan Already
                var user = _uow.UserService.GetUserByUserName(txtName.Text);
                if (_uow.LoanService.CheckUserNoOpenLoan(user.UserId))
                    MessageBox.Show("کاربر از قبل امانت تمام نشده ای دارد کتاب ها را به آن اضافه کنید");
                else
                {
                    Loan loan = new Loan()
                    {
                        EndDate = null,
                        UserId = user.UserId,
                    };
                    _uow.LoanService.Add(loan);

                    foreach (var ubook in txtBooks.Text.Trim().Split(' '))
                    {
                        var book = _uow.BookService.GetBookByName(ubook);
                        book.RemainNumber--;
                        UserBook uB = new UserBook();
                        uB.LoanId = loan.LoanId;
                        uB.BookId = book.BookId;
                        _uow.LoanService.AddUserBooks(uB);
                        _uow.BookService.Update(book);
                    }
                    bool res = _uow.Save();
                    if (res)
                        MessageBox.Show("موفقیت");
                    else
                        MessageBox.Show("شکست");
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchUser.Text))
                grdUser.DataSource = _uow.UserService.GetAllActiveUser(txtSearchUser.Text);
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchBook.Text))
                grdBook.DataSource = _uow.BookService.GetBooksName(txtSearchBook.Text);
        }

        private void grdUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = grdUser.SelectedCells[0].Value.ToString();
        }

        private void grdBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            booksSelected += grdBook.SelectedCells[0].Value.ToString() + " ";
            txtBooks.Text = booksSelected;
            numberBook++;
            lblNumber.Text = numberBook.ToString();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
        }
    }
}
