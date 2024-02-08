using ShahidSoltaniLibrary.Core.Core;
using ShahidSoltaniLibrary.Core.Tools;
using ShahidSoltaniLibrary.DataLayer.Entities;
using System;
using System.Windows.Forms;

namespace ShahidSoltaniLibrary.App
{
    public partial class EditUserForm : Form
    {
        private User user;
        private UnitOfWork _uow;
        public EditUserForm(User user)
        {
            InitializeComponent();
            this.user = user;
            _uow = new UnitOfWork();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            txtName.Text = user.UserName;
            txtDate.Text = user.RegisterDate.ToShamsi();
            if (user.IsActive)
                rdActive.Checked = true;
            else
                rdDeActive.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text == null)
                err.SetError(txtName, "نام دانش آموزش ضروری است");
            else if (_uow.UserService.IsExistsUser(txtName.Text) && txtName.Text != user.UserName)
                err.SetError(txtName, "نام کاربری از قبل موجود است");
            else
            {
                err.Clear();
                user.UserName = txtName.Text;
                user.IsActive = (rdActive.Checked) ? true : false;
                bool res = _uow.UserService.UpdateUser(user);
                _uow.Save();
                if (res)
                    DialogResult = DialogResult.OK;
                else
                    DialogResult = DialogResult.Abort;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            Messagebox msg = new Messagebox("اخطار", "آیا از حذف کاربر اطمینان دارید؟", 1);
            dynamic res = msg.ShowDialog();
            if (res == DialogResult.OK)
            {
                res = _uow.UserService.DeleteUser(user.UserId);
                _uow.Save();
                if (res)
                    DialogResult = DialogResult.OK;
                else
                    DialogResult = DialogResult.Abort;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
