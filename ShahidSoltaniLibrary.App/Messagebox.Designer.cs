namespace ShahidSoltaniLibrary.App
{
    partial class Messagebox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.xuiObjectEllipse2 = new XanderUI.XUIObjectEllipse();
            this.pt = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnOk = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pt)).BeginInit();
            this.bunifuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiObjectEllipse2
            // 
            this.xuiObjectEllipse2.CornerRadius = 10;
            this.xuiObjectEllipse2.EffectedControl = this;
            this.xuiObjectEllipse2.EffectedForm = this;
            // 
            // pt
            // 
            this.pt.AllowFocused = false;
            this.pt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pt.AutoSizeHeight = true;
            this.pt.BorderRadius = 0;
            this.pt.Image = global::ShahidSoltaniLibrary.App.Properties.Resources.perspective_matte_95_128x128;
            this.pt.IsCircle = false;
            this.pt.Location = new System.Drawing.Point(8, 7);
            this.pt.Name = "pt";
            this.pt.Size = new System.Drawing.Size(70, 70);
            this.pt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pt.TabIndex = 0;
            this.pt.TabStop = false;
            this.pt.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.pt.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTitle.Location = new System.Drawing.Point(105, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(81, 35);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "انجام شد";
            // 
            // lblCaption
            // 
            this.lblCaption.Location = new System.Drawing.Point(84, 39);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(103, 49);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "عملیات با موفقیت انجام شد";
            // 
            // btnOk
            // 
            this.btnOk.AllowAnimations = true;
            this.btnOk.AllowBorderColorChanges = true;
            this.btnOk.AllowMouseEffects = true;
            this.btnOk.AnimationSpeed = 200;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk.BorderRadius = 1;
            this.btnOk.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnOk.BorderThickness = 1;
            this.btnOk.ColorContrastOnClick = 30;
            this.btnOk.ColorContrastOnHover = 30;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnOk.CustomizableEdges = borderEdges2;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOk.Image = global::ShahidSoltaniLibrary.App.Properties.Resources.icons8_check_321;
            this.btnOk.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnOk.Location = new System.Drawing.Point(151, 91);
            this.btnOk.Name = "btnOk";
            this.btnOk.RoundBorders = true;
            this.btnOk.ShowBorders = true;
            this.btnOk.Size = new System.Drawing.Size(35, 35);
            this.btnOk.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnOk.TabIndex = 3;
            this.btnOk.Click += new System.EventHandler(this.bunifuIconButton3_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AllowAnimations = true;
            this.btnCancel.AllowBorderColorChanges = true;
            this.btnCancel.AllowMouseEffects = true;
            this.btnCancel.AnimationSpeed = 200;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Red;
            this.btnCancel.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.BorderRadius = 1;
            this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.ColorContrastOnClick = 30;
            this.btnCancel.ColorContrastOnHover = 30;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.Image = global::ShahidSoltaniLibrary.App.Properties.Resources.multi1;
            this.btnCancel.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Location = new System.Drawing.Point(6, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RoundBorders = true;
            this.btnCancel.ShowBorders = true;
            this.btnCancel.Size = new System.Drawing.Size(35, 35);
            this.btnCancel.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Click += new System.EventHandler(this.bunifuIconButton4_Click);
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.pt);
            this.bunifuGroupBox1.Controls.Add(this.btnCancel);
            this.bunifuGroupBox1.Controls.Add(this.lblTitle);
            this.bunifuGroupBox1.Controls.Add(this.btnOk);
            this.bunifuGroupBox1.Controls.Add(this.lblCaption);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(4, 5);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(192, 133);
            this.bunifuGroupBox1.TabIndex = 7;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // Messagebox
            // 
            this.ClientSize = new System.Drawing.Size(202, 141);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Messagebox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Messagebox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pt)).EndInit();
            this.bunifuGroupBox1.ResumeLayout(false);
            this.bunifuGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButton1;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse2;
        private Bunifu.UI.WinForms.BunifuPictureBox pt;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnOk;
        private System.Windows.Forms.Label lblCaption;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnCancel;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
    }
}