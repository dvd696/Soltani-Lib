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
            btnShow.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Messagebox msg = new Messagebox("اخطار", "آیا از حذف اطمینان دارید؟", 1);
            var status = msg.ShowDialog();
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

                Messagebox resmsg;
                if (res)
                    resmsg = new Messagebox();
                else
                    resmsg = new Messagebox("شکست خورد", "عملیات شکست خورد دوباره تلاش کنید", 2);

                resmsg.ShowDialog();
                UpdateData();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (grd.SelectedCells != null)
            {
                Messagebox msg = new Messagebox("اخطار", "آیا از انجام عملیات اطمینان دارید؟", 1);
                var status = msg.ShowDialog();
                int loanId = Convert.ToInt32(grd.SelectedCells[0].Value);
                var loan = _uow.LoanService.GetLoanById(loanId);
                if (status == DialogResult.OK && loan.Finish)
                {
                    Messagebox alreadymsg = new Messagebox("انجام شد", "عملیات از قبل انجام شده است", 0);
                    alreadymsg.ShowDialog();
                    return;
                }
                else if (status == DialogResult.OK)
                {
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

                    Messagebox resmsg;
                    if (res)
                        resmsg = new Messagebox();
                    else
                        resmsg = new Messagebox("شکست خورد", "عملیات شکست خورد دوباره تلاش کنید", 2);

                    resmsg.ShowDialog();
                    UpdateData();
                }
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            UpdateData(txtquery.Text, cmd.SelectedItem?.ToString());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (grd.SelectedCells != null)
            {
                int id = Convert.ToInt32(grd.SelectedCells[0].Value);
                ShowReport frm = new ShowReport(id);
                frm.ShowDialog();
            }
        }
    }
}
