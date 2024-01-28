using Bunifu.UI.WinForms;
using ShahidSoltaniLibrary.Core.Core;
using ShahidSoltaniLibrary.DataLayer.Entities;
using ShahidSoltaniLibrary.DataLayer.Migrations;
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
    public partial class BookForm : Form
    {
        private UnitOfWork _uow;
        private int _bookId;
        public BookForm(int bookId = -1)
        {
            _bookId = bookId;
            InitializeComponent();
            _uow = new UnitOfWork();
            cmCategory.Items.AddRange(_uow.CategoryService.GetAll()
                .Select(c => c.Title).ToArray());
        }


        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtShelf.Text != "" && txtnum.Value != 0 &&
                txtfloor.Text != "" && !string.IsNullOrEmpty(cmCategory.SelectedItem.ToString()))
            {
                bool res;
                Book book;
                if (_bookId != -1)
                {
                    book = _uow.BookService.GetBookById(_bookId);
                    book.CanLoan = (rdAccept.Checked) ? true : false;
                    book.Floor = txtfloor.Text;
                    book.Number = (int)txtnum.Value;
                    book.RemainNumber = (int)txtnum.Value;
                    book.Title = txtTitle.Text;
                    book.Shelf = txtShelf.Text;
                    book.CategoryId = _uow.CategoryService.GetIdByTitle(cmCategory.SelectedItem.ToString());
                    res = _uow.BookService.Update(book);
                }
                else
                {
                    book = new Book()
                    {
                        CanLoan = (rdAccept.Checked) ? true : false,
                        Floor = txtfloor.Text,
                        Number = (int)txtnum.Value,
                        RemainNumber = (int)txtnum.Value,
                        Title = txtTitle.Text,
                        Shelf = txtShelf.Text,
                        CategoryId = _uow.CategoryService.GetIdByTitle(cmCategory.SelectedItem.ToString())
                    };
                    res = _uow.BookService.Add(book);
                }
                _uow.Save();
                if (res)
                    MessageBox.Show("عملیات موفقیت آمیز بود", "موفقیت",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("عملیات شکشت خورد دوباره تلاش کنید", "شکست",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                DialogResult = DialogResult.OK;
            }
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            if (_bookId != -1)
            {
                bunifuButton22.Text = "ویرایش";
                Book book = _uow.BookService.GetBookById(_bookId);
                txtTitle.Text = book.Title;
                txtShelf.Text = book.Shelf;
                txtnum.Value = book.Number;
                txtfloor.Text = book.Floor;
                if (book.CanLoan)
                    rdAccept.Checked = true;
                else
                    rdforbidden.Checked = true;
                cmCategory.SelectedItem =
                    _uow.CategoryService.GetOneById(book.CategoryId).Title;
            }
        }
    }
}
