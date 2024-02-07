namespace ShahidSoltaniLibrary.App
{
    partial class ReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grd = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtquery = new System.Windows.Forms.TextBox();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.cmd = new System.Windows.Forms.ComboBox();
            this.bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.xuiCustomToolstrip1 = new XanderUI.XUICustomToolstrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEnd = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.xuiCustomToolstrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 10;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grd);
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(735, 408);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش امانات";
            // 
            // grd
            // 
            this.grd.AllowCustomTheming = false;
            this.grd.AllowUserToAddRows = false;
            this.grd.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.grd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grd.ColumnHeadersHeight = 40;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column5,
            this.Column4});
            this.grd.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.grd.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grd.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grd.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.grd.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grd.CurrentTheme.BackColor = System.Drawing.Color.DodgerBlue;
            this.grd.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.grd.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.grd.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.grd.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grd.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.grd.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grd.CurrentTheme.Name = null;
            this.grd.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grd.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grd.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grd.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.grd.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd.DefaultCellStyle = dataGridViewCellStyle3;
            this.grd.EnableHeadersVisualStyles = false;
            this.grd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.grd.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.grd.HeaderBgColor = System.Drawing.Color.Empty;
            this.grd.HeaderForeColor = System.Drawing.Color.White;
            this.grd.Location = new System.Drawing.Point(6, 30);
            this.grd.Name = "grd";
            this.grd.ReadOnly = true;
            this.grd.RowHeadersVisible = false;
            this.grd.RowTemplate.Height = 40;
            this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd.Size = new System.Drawing.Size(723, 412);
            this.grd.TabIndex = 0;
            this.grd.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DodgerBlue;
            this.grd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LoanId";
            this.Column2.HeaderText = "آیدی";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UserName";
            this.Column1.HeaderText = "نام دانش آموز";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "StartDate";
            this.Column3.HeaderText = "تاریخ شروع";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "EndDate";
            this.Column5.HeaderText = "تاریخ اتمام";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "IsFinish";
            this.Column4.HeaderText = "وضعیت";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtquery);
            this.groupBox2.Controls.Add(this.bunifuImageButton1);
            this.groupBox2.Controls.Add(this.cmd);
            this.groupBox2.Controls.Add(this.bunifuButton21);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.xuiCustomToolstrip1);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(735, 142);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "دسترسی ها";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "نام شخص:";
            // 
            // txtquery
            // 
            this.txtquery.Location = new System.Drawing.Point(406, 100);
            this.txtquery.Name = "txtquery";
            this.txtquery.Size = new System.Drawing.Size(255, 31);
            this.txtquery.TabIndex = 11;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::ShahidSoltaniLibrary.App.Properties.Resources.perspective_matte_15_128x128;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 10;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // cmd
            // 
            this.cmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd.FormattingEnabled = true;
            this.cmd.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmd.Items.AddRange(new object[] {
            "همه",
            "به اتمام رسیده",
            "در حال اجرا"});
            this.cmd.Location = new System.Drawing.Point(127, 99);
            this.cmd.Name = "cmd";
            this.cmd.Size = new System.Drawing.Size(213, 32);
            this.cmd.TabIndex = 7;
            // 
            // bunifuButton21
            // 
            this.bunifuButton21.AllowAnimations = true;
            this.bunifuButton21.AllowMouseEffects = true;
            this.bunifuButton21.AllowToggling = false;
            this.bunifuButton21.AnimationSpeed = 200;
            this.bunifuButton21.AutoGenerateColors = false;
            this.bunifuButton21.AutoRoundBorders = true;
            this.bunifuButton21.AutoSizeLeftIcon = true;
            this.bunifuButton21.AutoSizeRightIcon = true;
            this.bunifuButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton21.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.BackgroundImage")));
            this.bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.ButtonText = "جستجو";
            this.bunifuButton21.ButtonTextMarginLeft = 0;
            this.bunifuButton21.ColorContrastOnClick = 45;
            this.bunifuButton21.ColorContrastOnHover = 45;
            this.bunifuButton21.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton21.CustomizableEdges = borderEdges1;
            this.bunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton21.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton21.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton21.IconMarginLeft = 11;
            this.bunifuButton21.IconPadding = 10;
            this.bunifuButton21.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton21.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton21.IconSize = 25;
            this.bunifuButton21.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuButton21.IdleBorderRadius = 30;
            this.bunifuButton21.IdleBorderThickness = 1;
            this.bunifuButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuButton21.IdleIconLeftImage = null;
            this.bunifuButton21.IdleIconRightImage = null;
            this.bunifuButton21.IndicateFocus = false;
            this.bunifuButton21.Location = new System.Drawing.Point(6, 100);
            this.bunifuButton21.Name = "bunifuButton21";
            this.bunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.OnDisabledState.BorderRadius = 1;
            this.bunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnDisabledState.BorderThickness = 1;
            this.bunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.OnDisabledState.IconLeftImage = null;
            this.bunifuButton21.OnDisabledState.IconRightImage = null;
            this.bunifuButton21.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.BorderRadius = 1;
            this.bunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.onHoverState.BorderThickness = 1;
            this.bunifuButton21.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton21.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.onHoverState.IconLeftImage = null;
            this.bunifuButton21.onHoverState.IconRightImage = null;
            this.bunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuButton21.OnIdleState.BorderRadius = 1;
            this.bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnIdleState.BorderThickness = 1;
            this.bunifuButton21.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnIdleState.IconLeftImage = null;
            this.bunifuButton21.OnIdleState.IconRightImage = null;
            this.bunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.BorderRadius = 1;
            this.bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnPressedState.BorderThickness = 1;
            this.bunifuButton21.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnPressedState.IconLeftImage = null;
            this.bunifuButton21.OnPressedState.IconRightImage = null;
            this.bunifuButton21.Size = new System.Drawing.Size(113, 32);
            this.bunifuButton21.TabIndex = 6;
            this.bunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton21.TextMarginLeft = 0;
            this.bunifuButton21.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton21.UseDefaultRadiusAndThickness = true;
            this.bunifuButton21.Click += new System.EventHandler(this.bunifuButton21_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "وضعیت :";
            // 
            // xuiCustomToolstrip1
            // 
            this.xuiCustomToolstrip1.BackColor = System.Drawing.Color.Transparent;
            this.xuiCustomToolstrip1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomToolstrip1.ForeColor = System.Drawing.Color.Black;
            this.xuiCustomToolstrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.xuiCustomToolstrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.xuiCustomToolstrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.btnDelete,
            this.toolStripSeparator2,
            this.btnEnd});
            this.xuiCustomToolstrip1.Location = new System.Drawing.Point(3, 27);
            this.xuiCustomToolstrip1.Name = "xuiCustomToolstrip1";
            this.xuiCustomToolstrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.xuiCustomToolstrip1.Size = new System.Drawing.Size(729, 54);
            this.xuiCustomToolstrip1.TabIndex = 0;
            this.xuiCustomToolstrip1.Text = "xuiCustomToolstrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::ShahidSoltaniLibrary.App.Properties.Resources.perspective_matte_128x128;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 51);
            this.toolStripButton1.Text = "امانت جدید";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::ShahidSoltaniLibrary.App.Properties.Resources.Dust_128x128;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 51);
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // btnEnd
            // 
            this.btnEnd.Enabled = false;
            this.btnEnd.Image = global::ShahidSoltaniLibrary.App.Properties.Resources.perspective_matte_95_128x128;
            this.btnEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(101, 51);
            this.btnEnd.Text = "ثبت به عنوان اتمام";
            this.btnEnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReportsForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.xuiCustomToolstrip1.ResumeLayout(false);
            this.xuiCustomToolstrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private XanderUI.XUICustomToolstrip xuiCustomToolstrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Bunifu.UI.WinForms.BunifuDataGridView grd;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        private System.Windows.Forms.ComboBox cmd;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEnd;
        private System.Windows.Forms.TextBox txtquery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}