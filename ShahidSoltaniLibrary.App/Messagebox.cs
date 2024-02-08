using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShahidSoltaniLibrary.App
{
    public partial class Messagebox : Form
    {
        private string Title;
        private string Caption;
        private int Status;
        public Messagebox(string title="انجام شد", string caption="عملیات با موفقیت انجام شد", int status=0)
        {
            InitializeComponent();
            Title = title;
            Caption = caption;
            Status = status;
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuIconButton3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void bunifuIconButton4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        // Status 0 : Success 
        // Status 1 : Question 
        // Status 2 : Failed 
        private void Messagebox_Load(object sender, EventArgs e)
        {
            lblTitle.Text = Title;
            lblCaption.Text = Caption;
            string path;
            string pictureName = "";
            switch (Status)
            {
                case 1:
                    {
                        pictureName = "Attention_perspective_matte-128x128.png";
                        path = Path.Combine(Application.StartupPath,"..","..","Resources",pictureName);
                        pt.Image = Image.FromFile(path);
                        break;
                    }
                case 2:
                    {
                        pictureName = "perspective_matte-15-128x128.png";
                        path = Path.Combine(Application.StartupPath, "..", "..", "Resources", pictureName);
                        pt.Image = Image.FromFile(path);
                        btnCancel.Visible = false;
                        btnCancel.Enabled = false;
                        break;
                    }
                default:
                    {
                        btnCancel.Visible = false;
                        btnCancel.Enabled = false;
                        break;
                    }
            }
        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
