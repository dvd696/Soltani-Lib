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
    public partial class SettingForm : Form
    {
        private UnitOfWork _uow;
        public SettingForm()
        {
            InitializeComponent();
            _uow = new UnitOfWork();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void bunifuButton21_Click_1(object sender, EventArgs e)
        {
            if (txtOldPassword.Text != "" || txtPassword.Text != "" || txtRePassword.Text != "")
            {
                if (txtPassword.Text != txtRePassword.Text)
                {
                    err.Clear();
                    err.SetError(txtRePassword, "کلمه عبور با تکرار آن همخوانی ندارد");
                }
                else if (!_uow.LoginService.IsExistLogin("Soltani5", txtOldPassword.Text))
                {
                    err.Clear();
                    err.SetError(txtOldPassword, "کلمه عبور فعلی نادرست است");
                }
                else
                {
                    err.Clear();
                    //Delete Last Login
                    var oldLogin = _uow.LoginService.GetLastestLogin();
                    _uow.LoginService.Delete(oldLogin);

                    //new Login
                    var newlogin = new DataLayer.Entities.Login();
                    newlogin.UserName = "Soltani5";
                    newlogin.Password = txtPassword.Text;
                    var res = _uow.LoginService.Change(newlogin);

                    _uow.Save();

                    if (res)
                    {
                        MessageBox.Show("عملیات موفقیت آمیز بود", "تغییر",
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtOldPassword.Text = "";
                        txtPassword.Text = "";
                        txtRePassword.Text = "";
                    }
                    else
                        MessageBox.Show("عملیات شکشت خورد دوباره تلاش کنید", "حذف",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
