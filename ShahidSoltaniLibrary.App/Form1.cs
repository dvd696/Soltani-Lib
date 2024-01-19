using Bunifu.UI.WinForms.Extensions;
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
        public FormMain()
        {
            InitializeComponent();
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
    }
}
