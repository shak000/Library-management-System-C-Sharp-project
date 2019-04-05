namespace Login
{
    partial class AdminPanel
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.panelUp = new System.Windows.Forms.Panel();
            this.menuBar = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelAdminPanel = new System.Windows.Forms.Label();
            this.pictureBoxCross = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.logOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.issuedBook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.manageStudent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.manageLibrarian = new Bunifu.Framework.UI.BunifuFlatButton();
            this.manageBook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelTotalBook = new System.Windows.Forms.Panel();
            this.labelBooksCount = new System.Windows.Forms.Label();
            this.labelTotalBook = new System.Windows.Forms.Label();
            this.panelBlack1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTotalStudent = new System.Windows.Forms.Panel();
            this.labelStudentCount = new System.Windows.Forms.Label();
            this.labelTotalStudent = new System.Windows.Forms.Label();
            this.panelBlack3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelTotalIssued = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelIssuedBooks = new System.Windows.Forms.Label();
            this.panelTotalLibrarian = new System.Windows.Forms.Panel();
            this.labelLibrarianCount = new System.Windows.Forms.Label();
            this.labelTotalLibrarian = new System.Windows.Forms.Label();
            this.panelBlack2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelBlack4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.panelTotalBook.SuspendLayout();
            this.panelBlack1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTotalStudent.SuspendLayout();
            this.panelBlack3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelTotalIssued.SuspendLayout();
            this.panelTotalLibrarian.SuspendLayout();
            this.panelBlack2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelBlack4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.Navy;
            this.panelUp.Controls.Add(this.menuBar);
            this.panelUp.Controls.Add(this.labelAdminPanel);
            this.panelUp.Controls.Add(this.pictureBoxCross);
            this.panelAnimator.SetDecoration(this.panelUp, BunifuAnimatorNS.DecorationType.None);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(799, 44);
            this.panelUp.TabIndex = 0;
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.SlateBlue;
            this.panelAnimator.SetDecoration(this.menuBar, BunifuAnimatorNS.DecorationType.None);
            this.menuBar.Image = ((System.Drawing.Image)(resources.GetObject("menuBar.Image")));
            this.menuBar.ImageActive = null;
            this.menuBar.Location = new System.Drawing.Point(8, 4);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(48, 34);
            this.menuBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBar.TabIndex = 2;
            this.menuBar.TabStop = false;
            this.menuBar.Zoom = 10;
            this.menuBar.Click += new System.EventHandler(this.menuBar_Click);
            // 
            // labelAdminPanel
            // 
            this.labelAdminPanel.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelAdminPanel, BunifuAnimatorNS.DecorationType.None);
            this.labelAdminPanel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminPanel.ForeColor = System.Drawing.Color.White;
            this.labelAdminPanel.Location = new System.Drawing.Point(75, 10);
            this.labelAdminPanel.Name = "labelAdminPanel";
            this.labelAdminPanel.Size = new System.Drawing.Size(140, 24);
            this.labelAdminPanel.TabIndex = 2;
            this.labelAdminPanel.Text = "Admin Panel";
            // 
            // pictureBoxCross
            // 
            this.pictureBoxCross.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.pictureBoxCross, BunifuAnimatorNS.DecorationType.None);
            this.pictureBoxCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCross.Image")));
            this.pictureBoxCross.Location = new System.Drawing.Point(765, 4);
            this.pictureBoxCross.Name = "pictureBoxCross";
            this.pictureBoxCross.Size = new System.Drawing.Size(32, 31);
            this.pictureBoxCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCross.TabIndex = 0;
            this.pictureBoxCross.TabStop = false;
            this.pictureBoxCross.Click += new System.EventHandler(this.pictureBoxCross_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.BlueViolet;
            this.panelMenu.Controls.Add(this.labelUsername);
            this.panelMenu.Controls.Add(this.logOut);
            this.panelMenu.Controls.Add(this.issuedBook);
            this.panelMenu.Controls.Add(this.manageStudent);
            this.panelMenu.Controls.Add(this.manageLibrarian);
            this.panelMenu.Controls.Add(this.manageBook);
            this.panelMenu.Controls.Add(this.labelWelcome);
            this.panelMenu.Controls.Add(this.pictureBoxAdmin);
            this.panelAnimator.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Location = new System.Drawing.Point(0, 44);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(60, 473);
            this.panelMenu.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelUsername, BunifuAnimatorNS.DecorationType.None);
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(98, 44);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 21);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.logOut.Location = new System.Drawing.Point(0, 318);
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
            // issuedBook
            // 
            this.issuedBook.Activecolor = System.Drawing.Color.Indigo;
            this.issuedBook.BackColor = System.Drawing.Color.MediumPurple;
            this.issuedBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.issuedBook.BorderRadius = 0;
            this.issuedBook.ButtonText = "Issued Book";
            this.issuedBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.issuedBook, BunifuAnimatorNS.DecorationType.None);
            this.issuedBook.DisabledColor = System.Drawing.Color.Gray;
            this.issuedBook.Enabled = false;
            this.issuedBook.Iconcolor = System.Drawing.Color.Transparent;
            this.issuedBook.Iconimage = ((System.Drawing.Image)(resources.GetObject("issuedBook.Iconimage")));
            this.issuedBook.Iconimage_right = null;
            this.issuedBook.Iconimage_right_Selected = null;
            this.issuedBook.Iconimage_Selected = null;
            this.issuedBook.IconMarginLeft = 0;
            this.issuedBook.IconMarginRight = 0;
            this.issuedBook.IconRightVisible = true;
            this.issuedBook.IconRightZoom = 0D;
            this.issuedBook.IconVisible = true;
            this.issuedBook.IconZoom = 90D;
            this.issuedBook.IsTab = false;
            this.issuedBook.Location = new System.Drawing.Point(0, 268);
            this.issuedBook.Name = "issuedBook";
            this.issuedBook.Normalcolor = System.Drawing.Color.MediumPurple;
            this.issuedBook.OnHovercolor = System.Drawing.Color.SlateBlue;
            this.issuedBook.OnHoverTextColor = System.Drawing.Color.White;
            this.issuedBook.selected = false;
            this.issuedBook.Size = new System.Drawing.Size(222, 48);
            this.issuedBook.TabIndex = 5;
            this.issuedBook.Text = "Issued Book";
            this.issuedBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.issuedBook.Textcolor = System.Drawing.Color.White;
            this.issuedBook.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedBook.Click += new System.EventHandler(this.issuedBook_Click);
            this.issuedBook.DoubleClick += new System.EventHandler(this.issuedBook_DoubleClick);
            // 
            // manageStudent
            // 
            this.manageStudent.Activecolor = System.Drawing.Color.Indigo;
            this.manageStudent.BackColor = System.Drawing.Color.MediumPurple;
            this.manageStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manageStudent.BorderRadius = 0;
            this.manageStudent.ButtonText = "Manage Student";
            this.manageStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.manageStudent, BunifuAnimatorNS.DecorationType.None);
            this.manageStudent.DisabledColor = System.Drawing.Color.Gray;
            this.manageStudent.Enabled = false;
            this.manageStudent.Iconcolor = System.Drawing.Color.Transparent;
            this.manageStudent.Iconimage = ((System.Drawing.Image)(resources.GetObject("manageStudent.Iconimage")));
            this.manageStudent.Iconimage_right = null;
            this.manageStudent.Iconimage_right_Selected = null;
            this.manageStudent.Iconimage_Selected = null;
            this.manageStudent.IconMarginLeft = 0;
            this.manageStudent.IconMarginRight = 0;
            this.manageStudent.IconRightVisible = true;
            this.manageStudent.IconRightZoom = 0D;
            this.manageStudent.IconVisible = true;
            this.manageStudent.IconZoom = 90D;
            this.manageStudent.IsTab = false;
            this.manageStudent.Location = new System.Drawing.Point(0, 218);
            this.manageStudent.Name = "manageStudent";
            this.manageStudent.Normalcolor = System.Drawing.Color.MediumPurple;
            this.manageStudent.OnHovercolor = System.Drawing.Color.SlateBlue;
            this.manageStudent.OnHoverTextColor = System.Drawing.Color.White;
            this.manageStudent.selected = false;
            this.manageStudent.Size = new System.Drawing.Size(222, 48);
            this.manageStudent.TabIndex = 4;
            this.manageStudent.Text = "Manage Student";
            this.manageStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manageStudent.Textcolor = System.Drawing.Color.White;
            this.manageStudent.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStudent.Click += new System.EventHandler(this.manageStudent_Click);
            this.manageStudent.DoubleClick += new System.EventHandler(this.manageStudent_DoubleClick);
            // 
            // manageLibrarian
            // 
            this.manageLibrarian.Activecolor = System.Drawing.Color.Indigo;
            this.manageLibrarian.BackColor = System.Drawing.Color.MediumPurple;
            this.manageLibrarian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manageLibrarian.BorderRadius = 0;
            this.manageLibrarian.ButtonText = "Manage Librarian";
            this.manageLibrarian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.manageLibrarian, BunifuAnimatorNS.DecorationType.None);
            this.manageLibrarian.DisabledColor = System.Drawing.Color.Gray;
            this.manageLibrarian.Enabled = false;
            this.manageLibrarian.Iconcolor = System.Drawing.Color.Transparent;
            this.manageLibrarian.Iconimage = ((System.Drawing.Image)(resources.GetObject("manageLibrarian.Iconimage")));
            this.manageLibrarian.Iconimage_right = null;
            this.manageLibrarian.Iconimage_right_Selected = null;
            this.manageLibrarian.Iconimage_Selected = null;
            this.manageLibrarian.IconMarginLeft = 0;
            this.manageLibrarian.IconMarginRight = 0;
            this.manageLibrarian.IconRightVisible = true;
            this.manageLibrarian.IconRightZoom = 0D;
            this.manageLibrarian.IconVisible = true;
            this.manageLibrarian.IconZoom = 90D;
            this.manageLibrarian.IsTab = false;
            this.manageLibrarian.Location = new System.Drawing.Point(0, 168);
            this.manageLibrarian.Name = "manageLibrarian";
            this.manageLibrarian.Normalcolor = System.Drawing.Color.MediumPurple;
            this.manageLibrarian.OnHovercolor = System.Drawing.Color.SlateBlue;
            this.manageLibrarian.OnHoverTextColor = System.Drawing.Color.White;
            this.manageLibrarian.selected = false;
            this.manageLibrarian.Size = new System.Drawing.Size(222, 48);
            this.manageLibrarian.TabIndex = 3;
            this.manageLibrarian.Text = "Manage Librarian";
            this.manageLibrarian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manageLibrarian.Textcolor = System.Drawing.Color.White;
            this.manageLibrarian.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageLibrarian.Click += new System.EventHandler(this.manageLibrarian_Click);
            this.manageLibrarian.DoubleClick += new System.EventHandler(this.manageLibrarian_DoubleClick);
            // 
            // manageBook
            // 
            this.manageBook.Activecolor = System.Drawing.Color.Indigo;
            this.manageBook.BackColor = System.Drawing.Color.MediumPurple;
            this.manageBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manageBook.BorderRadius = 0;
            this.manageBook.ButtonText = "Manage Book";
            this.manageBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.manageBook, BunifuAnimatorNS.DecorationType.None);
            this.manageBook.DisabledColor = System.Drawing.Color.Gray;
            this.manageBook.Enabled = false;
            this.manageBook.Iconcolor = System.Drawing.Color.Transparent;
            this.manageBook.Iconimage = ((System.Drawing.Image)(resources.GetObject("manageBook.Iconimage")));
            this.manageBook.Iconimage_right = null;
            this.manageBook.Iconimage_right_Selected = null;
            this.manageBook.Iconimage_Selected = null;
            this.manageBook.IconMarginLeft = 0;
            this.manageBook.IconMarginRight = 0;
            this.manageBook.IconRightVisible = true;
            this.manageBook.IconRightZoom = 0D;
            this.manageBook.IconVisible = true;
            this.manageBook.IconZoom = 90D;
            this.manageBook.IsTab = false;
            this.manageBook.Location = new System.Drawing.Point(0, 118);
            this.manageBook.Name = "manageBook";
            this.manageBook.Normalcolor = System.Drawing.Color.MediumPurple;
            this.manageBook.OnHovercolor = System.Drawing.Color.SlateBlue;
            this.manageBook.OnHoverTextColor = System.Drawing.Color.White;
            this.manageBook.selected = false;
            this.manageBook.Size = new System.Drawing.Size(222, 48);
            this.manageBook.TabIndex = 2;
            this.manageBook.Text = "Manage Book";
            this.manageBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manageBook.Textcolor = System.Drawing.Color.White;
            this.manageBook.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBook.Click += new System.EventHandler(this.manageBook_Click);
            this.manageBook.DoubleClick += new System.EventHandler(this.manageBook_DoubleClick);
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
            this.pictureBoxAdmin.Location = new System.Drawing.Point(-2, 0);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(64, 73);
            this.pictureBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdmin.TabIndex = 0;
            this.pictureBoxAdmin.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelUp;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.menuBar;
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.panelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation1;
            this.panelAnimator.TimeStep = 0.01F;
            // 
            // panelTotalBook
            // 
            this.panelTotalBook.BackColor = System.Drawing.SystemColors.Control;
            this.panelTotalBook.Controls.Add(this.labelBooksCount);
            this.panelTotalBook.Controls.Add(this.labelTotalBook);
            this.panelTotalBook.Controls.Add(this.panelBlack1);
            this.panelAnimator.SetDecoration(this.panelTotalBook, BunifuAnimatorNS.DecorationType.None);
            this.panelTotalBook.Location = new System.Drawing.Point(12, 88);
            this.panelTotalBook.Name = "panelTotalBook";
            this.panelTotalBook.Size = new System.Drawing.Size(200, 100);
            this.panelTotalBook.TabIndex = 2;
            // 
            // labelBooksCount
            // 
            this.labelBooksCount.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelBooksCount, BunifuAnimatorNS.DecorationType.None);
            this.labelBooksCount.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooksCount.Location = new System.Drawing.Point(51, 16);
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
            this.labelTotalBook.Location = new System.Drawing.Point(20, 55);
            this.labelTotalBook.Name = "labelTotalBook";
            this.labelTotalBook.Size = new System.Drawing.Size(96, 21);
            this.labelTotalBook.TabIndex = 4;
            this.labelTotalBook.Text = "Total Books";
            // 
            // panelBlack1
            // 
            this.panelBlack1.BackColor = System.Drawing.Color.MediumPurple;
            this.panelBlack1.Controls.Add(this.pictureBox2);
            this.panelBlack1.Controls.Add(this.pictureBox1);
            this.panelAnimator.SetDecoration(this.panelBlack1, BunifuAnimatorNS.DecorationType.None);
            this.panelBlack1.Location = new System.Drawing.Point(133, 1);
            this.panelBlack1.Name = "panelBlack1";
            this.panelBlack1.Size = new System.Drawing.Size(67, 99);
            this.panelBlack1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.panelAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.panelAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panelTotalStudent
            // 
            this.panelTotalStudent.BackColor = System.Drawing.SystemColors.Control;
            this.panelTotalStudent.Controls.Add(this.labelStudentCount);
            this.panelTotalStudent.Controls.Add(this.labelTotalStudent);
            this.panelTotalStudent.Controls.Add(this.panelBlack3);
            this.panelAnimator.SetDecoration(this.panelTotalStudent, BunifuAnimatorNS.DecorationType.None);
            this.panelTotalStudent.Location = new System.Drawing.Point(12, 265);
            this.panelTotalStudent.Name = "panelTotalStudent";
            this.panelTotalStudent.Size = new System.Drawing.Size(200, 100);
            this.panelTotalStudent.TabIndex = 3;
            // 
            // labelStudentCount
            // 
            this.labelStudentCount.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelStudentCount, BunifuAnimatorNS.DecorationType.None);
            this.labelStudentCount.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentCount.Location = new System.Drawing.Point(51, 18);
            this.labelStudentCount.Name = "labelStudentCount";
            this.labelStudentCount.Size = new System.Drawing.Size(34, 39);
            this.labelStudentCount.TabIndex = 7;
            this.labelStudentCount.Text = "0";
            // 
            // labelTotalStudent
            // 
            this.labelTotalStudent.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelTotalStudent, BunifuAnimatorNS.DecorationType.None);
            this.labelTotalStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalStudent.Location = new System.Drawing.Point(29, 57);
            this.labelTotalStudent.Name = "labelTotalStudent";
            this.labelTotalStudent.Size = new System.Drawing.Size(79, 21);
            this.labelTotalStudent.TabIndex = 6;
            this.labelTotalStudent.Text = "Students";
            // 
            // panelBlack3
            // 
            this.panelBlack3.BackColor = System.Drawing.Color.MediumPurple;
            this.panelBlack3.Controls.Add(this.pictureBox4);
            this.panelAnimator.SetDecoration(this.panelBlack3, BunifuAnimatorNS.DecorationType.None);
            this.panelBlack3.Location = new System.Drawing.Point(133, 1);
            this.panelBlack3.Name = "panelBlack3";
            this.panelBlack3.Size = new System.Drawing.Size(67, 99);
            this.panelBlack3.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.panelAnimator.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(11, 28);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // panelTotalIssued
            // 
            this.panelTotalIssued.BackColor = System.Drawing.SystemColors.Control;
            this.panelTotalIssued.Controls.Add(this.label3);
            this.panelTotalIssued.Controls.Add(this.labelIssuedBooks);
            this.panelAnimator.SetDecoration(this.panelTotalIssued, BunifuAnimatorNS.DecorationType.None);
            this.panelTotalIssued.Location = new System.Drawing.Point(304, 265);
            this.panelTotalIssued.Name = "panelTotalIssued";
            this.panelTotalIssued.Size = new System.Drawing.Size(200, 100);
            this.panelTotalIssued.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.panelAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // labelIssuedBooks
            // 
            this.labelIssuedBooks.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelIssuedBooks, BunifuAnimatorNS.DecorationType.None);
            this.labelIssuedBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssuedBooks.Location = new System.Drawing.Point(20, 57);
            this.labelIssuedBooks.Name = "labelIssuedBooks";
            this.labelIssuedBooks.Size = new System.Drawing.Size(101, 21);
            this.labelIssuedBooks.TabIndex = 6;
            this.labelIssuedBooks.Text = "Total Issued";
            // 
            // panelTotalLibrarian
            // 
            this.panelTotalLibrarian.BackColor = System.Drawing.SystemColors.Control;
            this.panelTotalLibrarian.Controls.Add(this.labelLibrarianCount);
            this.panelTotalLibrarian.Controls.Add(this.labelTotalLibrarian);
            this.panelTotalLibrarian.Controls.Add(this.panelBlack2);
            this.panelAnimator.SetDecoration(this.panelTotalLibrarian, BunifuAnimatorNS.DecorationType.None);
            this.panelTotalLibrarian.Location = new System.Drawing.Point(304, 88);
            this.panelTotalLibrarian.Name = "panelTotalLibrarian";
            this.panelTotalLibrarian.Size = new System.Drawing.Size(200, 100);
            this.panelTotalLibrarian.TabIndex = 3;
            // 
            // labelLibrarianCount
            // 
            this.labelLibrarianCount.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelLibrarianCount, BunifuAnimatorNS.DecorationType.None);
            this.labelLibrarianCount.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibrarianCount.Location = new System.Drawing.Point(58, 16);
            this.labelLibrarianCount.Name = "labelLibrarianCount";
            this.labelLibrarianCount.Size = new System.Drawing.Size(34, 39);
            this.labelLibrarianCount.TabIndex = 6;
            this.labelLibrarianCount.Text = "0";
            // 
            // labelTotalLibrarian
            // 
            this.labelTotalLibrarian.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelTotalLibrarian, BunifuAnimatorNS.DecorationType.None);
            this.labelTotalLibrarian.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLibrarian.Location = new System.Drawing.Point(31, 55);
            this.labelTotalLibrarian.Name = "labelTotalLibrarian";
            this.labelTotalLibrarian.Size = new System.Drawing.Size(82, 21);
            this.labelTotalLibrarian.TabIndex = 5;
            this.labelTotalLibrarian.Text = "Librarians";
            // 
            // panelBlack2
            // 
            this.panelBlack2.BackColor = System.Drawing.Color.MediumPurple;
            this.panelBlack2.Controls.Add(this.pictureBox3);
            this.panelAnimator.SetDecoration(this.panelBlack2, BunifuAnimatorNS.DecorationType.None);
            this.panelBlack2.Location = new System.Drawing.Point(133, 1);
            this.panelBlack2.Name = "panelBlack2";
            this.panelBlack2.Size = new System.Drawing.Size(67, 99);
            this.panelBlack2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.panelAnimator.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // panelBlack4
            // 
            this.panelBlack4.BackColor = System.Drawing.Color.MediumPurple;
            this.panelBlack4.Controls.Add(this.pictureBox5);
            this.panelAnimator.SetDecoration(this.panelBlack4, BunifuAnimatorNS.DecorationType.None);
            this.panelBlack4.Location = new System.Drawing.Point(437, 264);
            this.panelBlack4.Name = "panelBlack4";
            this.panelBlack4.Size = new System.Drawing.Size(67, 99);
            this.panelBlack4.TabIndex = 4;
            // 
            // pictureBox5
            // 
            this.panelAnimator.SetDecoration(this.pictureBox5, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(11, 30);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 49);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.panelAnimator.SetDecoration(this.labelDashboard, BunifuAnimatorNS.DecorationType.None);
            this.labelDashboard.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelDashboard.Location = new System.Drawing.Point(163, 29);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(192, 39);
            this.labelDashboard.TabIndex = 5;
            this.labelDashboard.Text = "Dashboard";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.labelDashboard);
            this.panelControl.Controls.Add(this.panelBlack4);
            this.panelControl.Controls.Add(this.panelTotalStudent);
            this.panelControl.Controls.Add(this.panelTotalIssued);
            this.panelControl.Controls.Add(this.panelTotalLibrarian);
            this.panelControl.Controls.Add(this.panelTotalBook);
            this.panelAnimator.SetDecoration(this.panelControl, BunifuAnimatorNS.DecorationType.None);
            this.panelControl.Location = new System.Drawing.Point(215, 44);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(583, 476);
            this.panelControl.TabIndex = 6;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(799, 517);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelUp);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.panelTotalBook.ResumeLayout(false);
            this.panelTotalBook.PerformLayout();
            this.panelBlack1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTotalStudent.ResumeLayout(false);
            this.panelTotalStudent.PerformLayout();
            this.panelBlack3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelTotalIssued.ResumeLayout(false);
            this.panelTotalIssued.PerformLayout();
            this.panelTotalLibrarian.ResumeLayout(false);
            this.panelTotalLibrarian.PerformLayout();
            this.panelBlack2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelBlack4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBoxCross;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton manageBook;
        private Bunifu.Framework.UI.BunifuFlatButton logOut;
        private Bunifu.Framework.UI.BunifuFlatButton issuedBook;
        private Bunifu.Framework.UI.BunifuFlatButton manageStudent;
        private Bunifu.Framework.UI.BunifuFlatButton manageLibrarian;
        private System.Windows.Forms.Label labelAdminPanel;
        private System.Windows.Forms.Label labelUsername;
        private Bunifu.Framework.UI.BunifuImageButton menuBar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private System.Windows.Forms.Panel panelTotalBook;
        private System.Windows.Forms.Panel panelTotalStudent;
        private System.Windows.Forms.Panel panelTotalIssued;
        private System.Windows.Forms.Panel panelTotalLibrarian;
        private System.Windows.Forms.Panel panelBlack1;
        private System.Windows.Forms.Panel panelBlack3;
        private System.Windows.Forms.Panel panelBlack2;
        private System.Windows.Forms.Panel panelBlack4;
        private System.Windows.Forms.Label labelTotalBook;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStudentCount;
        private System.Windows.Forms.Label labelTotalStudent;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelIssuedBooks;
        private System.Windows.Forms.Label labelLibrarianCount;
        private System.Windows.Forms.Label labelTotalLibrarian;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Panel panelControl;
        public System.Windows.Forms.Label labelBooksCount;

    }
}