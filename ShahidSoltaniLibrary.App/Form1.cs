using Bunifu.UI.WinForms.Extensions;
using ShahidSoltaniLibrary.Core.Core;
using ShahidSoltaniLibrary.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShahidSoltaniLibrary.App
{
    public partial class FormMain : Form
    {
        private UnitOfWork _uow;
        public FormMain()
        {
            InitializeComponent();
            _uow = new UnitOfWork();
            UpdateData();
        }

        private void UpdateData(string title = "")
        {
            grd.DataSource = _uow.CategoryService.GetAll(title);
        }

        private void xuiFormDesign1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            Login lgn = new Login();
            if (lgn.ShowDialog() == DialogResult.OK)
                this.Show();
            else
                Application.Exit();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuPictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (!panelCategory.Visible)
                trnPanel.Show(panelCategory);
            else
                trnPanel.Hide(panelCategory);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingfrm = new SettingForm();
            settingfrm.ShowDialog();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUsForm frm = new AboutUsForm();
            frm.ShowDialog();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            UserForm frm = new UserForm();
            frm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportsForm frm = new ReportsForm();
            frm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            BooksForm frm = new BooksForm();
            frm.ShowDialog();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != "" && txtCategory.Text != null)
            {
                if (_uow.CategoryService.IsExist(txtCategory.Text))
                    MessageBox.Show("عملیات موفقیت آمیز بود", "افزودن",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                {
                    Category category = new Category();
                    category.Title = txtCategory.Text;
                    _uow.CategoryService.Add(category);
                    _uow.Save();
                    MessageBox.Show("عملیات موفقیت آمیز بود", "افزودن",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    UpdateData();
                }
            }

            txtCategory.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateData(txtSearch.Text);
        }

        private void grd_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("آیا از حذف اطمینان دارید؟", "حذف",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    == DialogResult.OK)
                {
                    int categoryId = Convert.ToInt32(grd.SelectedCells[0].Value);
                    bool res = _uow.CategoryService.Delete(categoryId);
                    _uow.Save();
                    if (res)
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
