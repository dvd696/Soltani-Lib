using ShahidSoltaniLibrary.Core.Core;
using ShahidSoltaniLibrary.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShahidSoltaniLibrary.App
{
    public partial class UserForm : Form
    {
        private UnitOfWork _uow;
        public UserForm()
        {
            InitializeComponent();
            _uow = new UnitOfWork();
            UpdateData();
        }

        private void UpdateData(string userName = "")
        {
            grd.DataSource = _uow.UserService.GetAllUser(userName);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void swtStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (swtStatus.Checked)
            {
                lblStatus.Text = "فعال";
                lblStatus.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text = "غیرفعال";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text == null)
                err.SetError(txtName, "نام دانش آموزش ضروری است");
            else if (_uow.UserService.IsExistsUser(txtName.Text))
                err.SetError(txtName, "نام کاربری از قبل موجود است");
            else
            {
                User user = new User();
                user.UserName = txtName.Text;
                user.IsActive = swtStatus.Checked;
                bool res = _uow.UserService.AddUser(user);
                _uow.Save();
                if (res)
                {
                    txtName.Text = "";
                    swtStatus.Checked = false;
                    MessageBox.Show("عملیات موفقیت آمیز بود", "افزودن",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    UpdateData();
                }
                else
                {
                    MessageBox.Show("عملیات شکشت خورد دوباره تلاش کنید",
                        "افزودن",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtName_TextChange(object sender, EventArgs e)
        {
            err.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "" && txtSearch.Text != null)
            {
                UpdateData(txtSearch.Text);
            }
            txtSearch.Text = "";
        }

        private void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditUser.Enabled = true;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            var user = _uow.UserService.GetUserById(Convert.ToInt32(grd.SelectedCells[0].Value));
            EditUserForm frm = new EditUserForm(user);
            var res = frm.ShowDialog();
            if(res==DialogResult.OK)
                MessageBox.Show("عملیات موفقیت آمیز بود", "ویرایش",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else if(res==DialogResult.Abort)
                MessageBox.Show("عملیات شکشت خورد دوباره تلاش کنید","ویرایش",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            UpdateData();
        }
    }
}
