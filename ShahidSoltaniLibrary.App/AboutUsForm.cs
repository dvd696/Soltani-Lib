using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShahidSoltaniLibrary.App
{
    public partial class AboutUsForm : Form
    {
        public AboutUsForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnInsta_Click(object sender, EventArgs e)
        {
            Process.Start("https://instagram.com/dvd.696");
        }

        private void btnTel_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/dvd696");
        }

        private void btnLinked_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/davoud-nazari-41813923b");
        }

        private void btnFace_Click(object sender, EventArgs e)
        {
            Process.Start("https://facebook.com/dvd.696");
        }

        private void btnQuera_Click(object sender, EventArgs e)
        {
            Process.Start("https://quera.org/profile/hftvqg");
        }
    }
}
