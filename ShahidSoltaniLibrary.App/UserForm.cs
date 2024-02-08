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
                Messagebox msg;
                if (res)
                {
                    msg = new Messagebox();
                    txtName.Text = "";
                    swtStatus.Checked = false;
                    UpdateData();
                }
                else
                    msg = new Messagebox("شکست خورد", "عملیات شکست خورد دوباره تلاش کنید", 2);
                msg.ShowDialog();
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
            Messagebox msg;
            if (res == DialogResult.OK)
            {
                msg = new Messagebox();
                msg.ShowDialog();
            }
            else if (res == DialogResult.Abort)
            {
                msg = new Messagebox("شکست خورد", "عملیات شکست خورد دوباره تلاش کنید", 2);
                msg.ShowDialog();
            }
            UpdateData();
        }
    }
}
