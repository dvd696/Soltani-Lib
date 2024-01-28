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

namespace ShahidSoltaniLibrary.App
{
    public partial class BooksForm : Form
    {
        private UnitOfWork _uow;
        public BooksForm()
        {
            InitializeComponent();
            _uow = new UnitOfWork();
            cmCategory.Items.AddRange(_uow.CategoryService.GetAll()
                .Select(c => c.Title).ToArray());
            UpdateData();
        }

        private void UpdateData(string title = "", string category = "", string status = "")
        {
            int categoryId = 0;
            if (!string.IsNullOrEmpty(category))
                categoryId = _uow.CategoryService.GetIdByTitle(category);

            grd.DataSource = _uow.BookService.GetAllBooks(title, categoryId, status);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            BookForm frm = new BookForm();
            var res = frm.ShowDialog();
            if (res == DialogResult.OK)
                UpdateData();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            UpdateData(txtTitle.Text, cmCategory.SelectedItem?.ToString(),
                cmStatus.SelectedItem?.ToString());
            txtTitle.Text = "";
            cmCategory.SelectedItem = null;
            cmStatus.SelectedItem = null;
        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grd.SelectedCells.Count > 0)
            {
                int bookId = int.Parse(grd.SelectedCells[0].Value.ToString());
                BookForm frm = new BookForm(bookId);
                var res = frm.ShowDialog();
                if (res == DialogResult.OK)
                    UpdateData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grd.SelectedCells.Count > 0)
            {
                var res = MessageBox.Show("از حذف اطمینان دارید", "حذف", buttons: MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    int bookId = int.Parse(grd.SelectedCells[0].Value.ToString());
                    bool result = _uow.BookService.Delete(bookId);
                    _uow.Save();
                    if (result)
                        MessageBox.Show("عملیات موفقیت آمیز بود", "حذف",
                                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("عملیات شکشت خورد دوباره تلاش کنید", "حذف",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UpdateData();
                }
            }
        }
    }
}
