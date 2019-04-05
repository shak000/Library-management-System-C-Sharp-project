namespace Login
{
    partial class StudentPanel
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuBar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBoxCross = new System.Windows.Forms.PictureBox();
            this.labelLibrarianPanel = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.brwInfo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cngPassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.myInformation = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelUsername = new System.Windows.Forms.Label();
            this.logOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.viewBook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.panelTotalBook = new System.Windows.Forms.Panel();
            this.labelBooksCount = new System.Windows.Forms.Label();
            this.labelTotalBook = new System.Windows.Forms.Label();
            this.panelBlack1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fetchLabel = new System.Windows.Forms.Label();
            this.fetchPassword = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.panelControl.SuspendLayout();
            this.panelTotalBook.SuspendLayout();
            this.panelBlack1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.menuBar);
            this.panel1.Controls.Add(this.pictureBoxCross);
            this.panel1.Controls.Add(this.labelLibrarianPanel);
            this.panelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 42);
            this.panel1.TabIndex = 0;
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.SlateBlue;
            this.panelAnimator.SetDecoration(this.menuBar, BunifuAnimatorNS.DecorationType.None);
            this.menuBar.Image = ((System.Drawing.Image)(resources.GetObject("menuBar.Image")));
            this.menuBar.ImageActive = null;
            this.menuBar.Location = new System.Drawing.Point(6, 4);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(48, 34);
            this.menuBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBar.TabIndex = 10;
            this.menuBar.TabStop = false;
            this.menuBar.Zoom = 10;
            this.menuBar.Click += new System.EventHandler(this.menuBar_Click);
            // 
            // pictureBoxCross
            // 
            this.pictureBoxCross.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.pictureBoxCross, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCross.Image")));
            this.pictureBoxCross.Location = new System.Drawing.Point(712, 4);
            this.pictureBoxCross.Name = "pictureBoxCross";
            this.pictureBoxCross.Size = new System.Drawing.Size(32, 31);
            this.pictureBoxCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCross.TabIndex = 4;
            this.pictureBoxCross.TabStop = false;
            this.pictureBoxCross.Click += new System.EventHandler(this.pictureBoxCross_Click);
            // 
            // labelLibrarianPanel
            // 
            this.labelLibrarianPanel.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelLibrarianPanel, BunifuAnimatorNS.DecorationType.None);
            this.labelLibrarianPanel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibrarianPanel.ForeColor = System.Drawing.Color.White;
            this.labelLibrarianPanel.Location = new System.Drawing.Point(59, 8);
            this.labelLibrarianPanel.Name = "labelLibrarianPanel";
            this.labelLibrarianPanel.Size = new System.Drawing.Size(152, 24);
            this.labelLibrarianPanel.TabIndex = 3;
            this.labelLibrarianPanel.Text = "Student Panel";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.BlueViolet;
            this.panelMenu.Controls.Add(this.brwInfo);
            this.panelMenu.Controls.Add(this.cngPassword);
            this.panelMenu.Controls.Add(this.myInformation);
            this.panelMenu.Controls.Add(this.labelUsername);
            this.panelMenu.Controls.Add(this.logOut);
            this.panelMenu.Controls.Add(this.viewBook);
            this.panelMenu.Controls.Add(this.labelWelcome);
            this.panelMenu.Controls.Add(this.pictureBoxAdmin);
            this.panelAnimator.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Location = new System.Drawing.Point(0, 41);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(57, 483);
            this.panelMenu.TabIndex = 9;
            // 
            // brwInfo
            // 
            this.brwInfo.Activecolor = System.Drawing.Color.Indigo;
            this.brwInfo.BackColor = System.Drawing.Color.MediumPurple;
            this.brwInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brwInfo.BorderRadius = 0;
            this.brwInfo.ButtonText = "Current Borrow";
            this.brwInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.brwInfo, BunifuAnimatorNS.DecorationType.None);
            this.brwInfo.DisabledColor = System.Drawing.Color.Gray;
            this.brwInfo.Enabled = false;
            this.brwInfo.Iconcolor = System.Drawing.Color.Transparent;
            this.brwInfo.Iconimage = ((System.Drawing.Image)(resources.GetObject("brwInfo.Iconimage")));
            this.brwInfo.Iconimage_right = null;
            this.brwInfo.Iconimage_right_Selected = null;
            this.brwInfo.Iconimage_Selected = null;
            this.brwInfo.IconMarginLeft = 0;
            this.brwInfo.IconMarginRight = 0;
            this.brwInfo.IconRightVisible = true;
            this.brwInfo.IconRightZoom = 0D;
            this.brwInfo.IconVisible = true;
            this.brwInfo.IconZoom = 90D;
            this.brwInfo.IsTab = false;
            this.brwInfo.Location = new System.Drawing.Point(-1, 156);
            this.brwInfo.Name = "brwInfo";
            this.brwInfo.Normalcolor = System.Drawing.Color.MediumPurple;
            this.brwInfo.OnHovercolor = System.Drawing.Color.SlateBlue;
            this.brwInfo.OnHoverTextColor = System.Drawing.Color.White;
            this.brwInfo.selected = false;
            this.brwInfo.Size = new System.Drawing.Size(222, 48);
            this.brwInfo.TabIndex = 11;
            this.brwInfo.Text = "Current Borrow";
            this.brwInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.brwInfo.Textcolor = System.Drawing.Color.White;
            this.brwInfo.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwInfo.Click += new System.EventHandler(this.brwInfo_Click);
            this.brwInfo.DoubleClick += new System.EventHandler(this.brwInfo_DoubleClick);
            // 
            // cngPassword
            // 
            this.cngPassword.Activecolor = System.Drawing.Color.Indigo;
            this.cngPassword.BackColor = System.Drawing.Color.MediumPurple;
            this.cngPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cngPassword.BorderRadius = 0;
            this.cngPassword.ButtonText = "Change Password";
            this.cngPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.cngPassword, BunifuAnimatorNS.DecorationType.None);
            this.cngPassword.DisabledColor = System.Drawing.Color.Gray;
            this.cngPassword.Enabled = false;
            this.cngPassword.Iconcolor = System.Drawing.Color.Transparent;
            this.cngPassword.Iconimage = ((System.Drawing.Image)(resources.GetObject("cngPassword.Iconimage")));
            this.cngPassword.Iconimage_right = null;
            this.cngPassword.Iconimage_right_Selected = null;
            this.cngPassword.Iconimage_Selected = null;
            this.cngPassword.IconMarginLeft = 0;
            this.cngPassword.IconMarginRight = 0;
            this.cngPassword.IconRightVisible = true;
            this.cngPassword.IconRightZoom = 0D;
            this.cngPassword.IconVisible = true;
            this.cngPassword.IconZoom = 90D;
            this.cngPassword.IsTab = false;
            this.cngPassword.Location = new System.Drawing.Point(0, 256);
            this.cngPassword.Name = "cngPassword";
            this.cngPassword.Normalcolor = System.Drawing.Color.MediumPurple;
            this.cngPassword.OnHovercolor = System.Drawing.Color.SlateBlue;
            this.cngPassword.OnHoverTextColor = System.Drawing.Color.White;
            this.cngPassword.selected = false;
            this.cngPassword.Size = new System.Drawing.Size(222, 48);
            this.cngPassword.TabIndex = 10;
            this.cngPassword.Text = "Change Password";
            this.cngPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cngPassword.Textcolor = System.Drawing.Color.White;
            this.cngPassword.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cngPassword.Click += new System.EventHandler(this.cngPassword_Click);
            this.cngPassword.DoubleClick += new System.EventHandler(this.cngPassword_DoubleClick);
            // 
            // myInformation
            // 
            this.myInformation.Activecolor = System.Drawing.Color.Indigo;
            this.myInformation.BackColor = System.Drawing.Color.MediumPurple;
            this.myInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myInformation.BorderRadius = 0;
            this.myInformation.ButtonText = "My Information";
            this.myInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.myInformation, BunifuAnimatorNS.DecorationType.None);
            this.myInformation.DisabledColor = System.Drawing.Color.Gray;
            this.myInformation.Enabled = false;
            this.myInformation.Iconcolor = System.Drawing.Color.Transparent;
            this.myInformation.Iconimage = ((System.Drawing.Image)(resources.GetObject("myInformation.Iconimage")));
            this.myInformation.Iconimage_right = null;
            this.myInformation.Iconimage_right_Selected = null;
            this.myInformation.Iconimage_Selected = null;
            this.myInformation.IconMarginLeft = 0;
            this.myInformation.IconMarginRight = 0;
            this.myInformation.IconRightVisible = true;
            this.myInformation.IconRightZoom = 0D;
            this.myInformation.IconVisible = true;
            this.myInformation.IconZoom = 90D;
            this.myInformation.IsTab = false;
            this.myInformation.Location = new System.Drawing.Point(-1, 206);
            this.myInformation.Name = "myInformation";
            this.myInformation.Normalcolor = System.Drawing.Color.MediumPurple;
            this.myInformation.OnHovercolor = System.Drawing.Color.SlateBlue;
            this.myInformation.OnHoverTextColor = System.Drawing.Color.White;
            this.myInformation.selected = false;
            this.myInformation.Size = new System.Drawing.Size(222, 48);
            this.myInformation.TabIndex = 9;
            this.myInformation.Text = "My Information";
            this.myInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myInformation.Textcolor = System.Drawing.Color.White;
            this.myInformation.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myInformation.Click += new System.EventHandler(this.myInformation_Click);
            this.myInformation.DoubleClick += new System.EventHandler(this.myInformation_DoubleClick);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelUsername, BunifuAnimatorNS.DecorationType.None);
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(92, 42);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 17);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logOut
            // 
            this.logOut.Activecolor = System.Drawing.Color.Indigo;
            this.logOut.BackColor = System.Drawing.Color.MediumPurple;
            this.logOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOut.BorderRadius = 0;
            this.logOut.ButtonText = "Log Out";
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.logOut, BunifuAnimatorNS.DecorationType.None);
            this.logOut.DisabledColor = System.Drawing.Color.Gray;
            this.logOut.Enabled = false;
            this.logOut.Iconcolor = System.Drawing.Color.Transparent;
            this.logOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("logOut.Iconimage")));
            this.logOut.Iconimage_right = null;
            this.logOut.Iconimage_right_Selected = null;
            this.logOut.Iconimage_Selected = null;
            this.logOut.IconMarginLeft = 0;
            this.logOut.IconMarginRight = 0;
            this.logOut.IconRightVisible = true;
            this.logOut.IconRightZoom = 0D;
            this.logOut.IconVisible = true;
            this.logOut.IconZoom = 90D;
            this.logOut.IsTab = false;
            this.logOut.Location = new System.Drawing.Point(0, 306);
            this.logOut.Name = "logOut";
            this.logOut.Normalcolor = System.Drawing.Color.MediumPurple;
            this.logOut.OnHovercolor = System.Drawing.Color.SlateBlue;
            this.logOut.OnHoverTextColor = System.Drawing.Color.White;
            this.logOut.selected = false;
            this.logOut.Size = new System.Drawing.Size(222, 48);
            this.logOut.TabIndex = 6;
            this.logOut.Text = "Log Out";
            this.logOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logOut.Textcolor = System.Drawing.Color.White;
            this.logOut.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // viewBook
            // 
            this.viewBook.Activecolor = System.Drawing.Color.Indigo;
            this.viewBook.BackColor = System.Drawing.Color.MediumPurple;
            this.viewBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewBook.BorderRadius = 0;
            this.viewBook.ButtonText = "View Book";
            this.viewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.viewBook, BunifuAnimatorNS.DecorationType.None);
            this.viewBook.DisabledColor = System.Drawing.Color.Gray;
            this.viewBook.Enabled = false;
            this.viewBook.Iconcolor = System.Drawing.Color.Transparent;
            this.viewBook.Iconimage = ((System.Drawing.Image)(resources.GetObject("viewBook.Iconimage")));
            this.viewBook.Iconimage_right = null;
            this.viewBook.Iconimage_right_Selected = null;
            this.viewBook.Iconimage_Selected = null;
            this.viewBook.IconMarginLeft = 0;
            this.viewBook.IconMarginRight = 0;
            this.viewBook.IconRightVisible = true;
            this.viewBook.IconRightZoom = 0D;
            this.viewBook.IconVisible = true;
            this.viewBook.IconZoom = 90D;
            this.viewBook.IsTab = false;
            this.viewBook.Location = new System.Drawing.Point(0, 105);
            this.viewBook.Name = "viewBook";
            this.viewBook.Normalcolor = System.Drawing.Color.MediumPurple;
            this.viewBook.OnHovercolor = System.Drawing.Color.SlateBlue;
            this.viewBook.OnHoverTextColor = System.Drawing.Color.White;
            this.viewBook.selected = false;
            this.viewBook.Size = new System.Drawing.Size(222, 48);
            this.viewBook.TabIndex = 2;
            this.viewBook.Text = "View Book";
            this.viewBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewBook.Textcolor = System.Drawing.Color.White;
            this.viewBook.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBook.Click += new System.EventHandler(this.viewBook_Click);
            this.viewBook.DoubleClick += new System.EventHandler(this.viewBook_DoubleClick);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelWelcome, BunifuAnimatorNS.DecorationType.None);
            this.labelWelcome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Black;
            this.labelWelcome.Location = new System.Drawing.Point(75, 16);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(111, 24);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome";
            // 
            // pictureBoxAdmin
            // 
            this.panelAnimator.SetDecoration(this.pictureBoxAdmin, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdmin.Image")));
            this.pictureBoxAdmin.Location = new System.Drawing.Point(-3, 0);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(64, 73);
            this.pictureBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdmin.TabIndex = 0;
            this.pictureBoxAdmin.TabStop = false;
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.panelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation2;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Gainsboro;
            this.panelControl.Controls.Add(this.labelDashboard);
            this.panelControl.Controls.Add(this.panelTotalBook);
            this.panelAnimator.SetDecoration(this.panelControl, BunifuAnimatorNS.DecorationType.None);
            this.panelControl.Location = new System.Drawing.Point(209, 42);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(535, 476);
            this.panelControl.TabIndex = 10;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelDashboard, BunifuAnimatorNS.DecorationType.None);
            this.labelDashboard.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelDashboard.Location = new System.Drawing.Point(150, 88);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(192, 39);
            this.labelDashboard.TabIndex = 5;
            this.labelDashboard.Text = "Dashboard";
            // 
            // panelTotalBook
            // 
            this.panelTotalBook.BackColor = System.Drawing.SystemColors.Control;
            this.panelTotalBook.Controls.Add(this.labelBooksCount);
            this.panelTotalBook.Controls.Add(this.labelTotalBook);
            this.panelTotalBook.Controls.Add(this.panelBlack1);
            this.panelAnimator.SetDecoration(this.panelTotalBook, BunifuAnimatorNS.DecorationType.None);
            this.panelTotalBook.Location = new System.Drawing.Point(121, 167);
            this.panelTotalBook.Name = "panelTotalBook";
            this.panelTotalBook.Size = new System.Drawing.Size(254, 111);
            this.panelTotalBook.TabIndex = 2;
            // 
            // labelBooksCount
            // 
            this.labelBooksCount.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelBooksCount, BunifuAnimatorNS.DecorationType.None);
            this.labelBooksCount.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooksCount.Location = new System.Drawing.Point(72, 27);
            this.labelBooksCount.Name = "labelBooksCount";
            this.labelBooksCount.Size = new System.Drawing.Size(34, 39);
            this.labelBooksCount.TabIndex = 5;
            this.labelBooksCount.Text = "0";
            // 
            // labelTotalBook
            // 
            this.labelTotalBook.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelTotalBook, BunifuAnimatorNS.DecorationType.None);
            this.labelTotalBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBook.Location = new System.Drawing.Point(41, 66);
            this.labelTotalBook.Name = "labelTotalBook";
            this.labelTotalBook.Size = new System.Drawing.Size(96, 21);
            this.labelTotalBook.TabIndex = 4;
            this.labelTotalBook.Text = "Total Books";
            // 
            // panelBlack1
            // 
            this.panelBlack1.BackColor = System.Drawing.Color.MediumPurple;
            this.panelBlack1.Controls.Add(this.pictureBox2);
            this.panelAnimator.SetDecoration(this.panelBlack1, BunifuAnimatorNS.DecorationType.None);
            this.panelBlack1.Location = new System.Drawing.Point(162, 1);
            this.panelBlack1.Name = "panelBlack1";
            this.panelBlack1.Size = new System.Drawing.Size(90, 110);
            this.panelBlack1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.panelAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // fetchLabel
            // 
            this.fetchLabel.AutoSize = true;
            this.panelAnimator.SetDecoration(this.fetchLabel, BunifuAnimatorNS.DecorationType.None);
            this.fetchLabel.Location = new System.Drawing.Point(140, 87);
            this.fetchLabel.Name = "fetchLabel";
            this.fetchLabel.Size = new System.Drawing.Size(0, 13);
            this.fetchLabel.TabIndex = 11;
            this.fetchLabel.Visible = false;
            // 
            // fetchPassword
            // 
            this.fetchPassword.AutoSize = true;
            this.panelAnimator.SetDecoration(this.fetchPassword, BunifuAnimatorNS.DecorationType.None);
            this.fetchPassword.Location = new System.Drawing.Point(153, 231);
            this.fetchPassword.Name = "fetchPassword";
            this.fetchPassword.Size = new System.Drawing.Size(0, 13);
            this.fetchPassword.TabIndex = 12;
            this.fetchPassword.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // StudentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(747, 517);
            this.Controls.Add(this.fetchPassword);
            this.Controls.Add(this.fetchLabel);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelTotalBook.ResumeLayout(false);
            this.panelTotalBook.PerformLayout();
            this.panelBlack1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLibrarianPanel;
        private System.Windows.Forms.PictureBox pictureBoxCross;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton cngPassword;
        private Bunifu.Framework.UI.BunifuFlatButton myInformation;
        public System.Windows.Forms.Label labelUsername;
        private Bunifu.Framework.UI.BunifuFlatButton logOut;
        private Bunifu.Framework.UI.BunifuFlatButton viewBook;
        private System.Windows.Forms.Label labelWelcome;
        public System.Windows.Forms.PictureBox pictureBoxAdmin;
        private Bunifu.Framework.UI.BunifuImageButton menuBar;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton brwInfo;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Panel panelTotalBook;
        public System.Windows.Forms.Label labelBooksCount;
        private System.Windows.Forms.Label labelTotalBook;
        private System.Windows.Forms.Panel panelBlack1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label fetchLabel;
        private System.Windows.Forms.Label fetchPassword;

    }
}