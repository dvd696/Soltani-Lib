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
    public partial class Login : Form
    {
        UnitOfWork _uow;
        public Login()
        {
            InitializeComponent();
            _uow = new UnitOfWork();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //{UserName : Savior , Password : 777}
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                if (_uow.LoginService.IsExistLogin(txtUserName.Text, txtPassword.Text))
                {
                    Messagebox messagebox = new Messagebox();
                    messagebox.ShowDialog();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    errorlbl.Visible = true;
            }
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
