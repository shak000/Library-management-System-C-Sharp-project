namespace Login
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelUp = new System.Windows.Forms.Panel();
            this.issue_book = new System.Windows.Forms.Label();
            this.pictureBoxCross = new System.Windows.Forms.PictureBox();
            this.dobTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.genderTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.phoneTF2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.emailTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.fullnameTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dateofbirthLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.publicationyearTF = new System.Windows.Forms.TextBox();
            this.quantityTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.authornameTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.booknameTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.quantity = new System.Windows.Forms.Label();
            this.publicationYear = new System.Windows.Forms.Label();
            this.authorName = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.Label();
            this.studentTxt = new System.Windows.Forms.TextBox();
            this.bookTxt = new System.Windows.Forms.TextBox();
            this.sbtnLoad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bbtnLoad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIssue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.brwDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.brwLabel = new System.Windows.Forms.Label();
            this.brwTxt2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rtnDate = new System.Windows.Forms.DateTimePicker();
            this.brwTxt1 = new System.Windows.Forms.TextBox();
            this.separatorAdd = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.feesTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.feesLabel = new System.Windows.Forms.Label();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.MediumPurple;
            this.panelUp.Controls.Add(this.issue_book);
            this.panelUp.Controls.Add(this.pictureBoxCross);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(802, 44);
            this.panelUp.TabIndex = 2;
            // 
            // issue_book
            // 
            this.issue_book.AutoSize = true;
            this.issue_book.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_book.ForeColor = System.Drawing.Color.White;
            this.issue_book.Location = new System.Drawing.Point(12, 10);
            this.issue_book.Name = "issue_book";
            this.issue_book.Size = new System.Drawing.Size(115, 24);
            this.issue_book.TabIndex = 3;
            this.issue_book.Text = "Issue Book";
            // 
            // pictureBoxCross
            // 
            this.pictureBoxCross.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCross.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCross.Image")));
            this.pictureBoxCross.Location = new System.Drawing.Point(764, 3);
            this.pictureBoxCross.Name = "pictureBoxCross";
            this.pictureBoxCross.Size = new System.Drawing.Size(32, 31);
            this.pictureBoxCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCross.TabIndex = 0;
            this.pictureBoxCross.TabStop = false;
            this.pictureBoxCross.Click += new System.EventHandler(this.pictureBoxCross_Click);
            // 
            // dobTF
            // 
            this.dobTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobTF.Location = new System.Drawing.Point(176, 184);
            this.dobTF.Name = "dobTF";
            this.dobTF.ReadOnly = true;
            this.dobTF.Size = new System.Drawing.Size(151, 23);
            this.dobTF.TabIndex = 36;
            // 
            // genderTF
            // 
            this.genderTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.genderTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTF.Location = new System.Drawing.Point(176, 148);
            this.genderTF.Name = "genderTF";
            this.genderTF.ReadOnly = true;
            this.genderTF.Size = new System.Drawing.Size(151, 23);
            this.genderTF.TabIndex = 35;
            // 
            // phoneTF2
            // 
            this.phoneTF2.BorderColor = System.Drawing.Color.SeaGreen;
            this.phoneTF2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTF2.Location = new System.Drawing.Point(176, 294);
            this.phoneTF2.Name = "phoneTF2";
            this.phoneTF2.ReadOnly = true;
            this.phoneTF2.Size = new System.Drawing.Size(151, 23);
            this.phoneTF2.TabIndex = 34;
            // 
            // emailTF
            // 
            this.emailTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.emailTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTF.Location = new System.Drawing.Point(176, 256);
            this.emailTF.Name = "emailTF";
            this.emailTF.ReadOnly = true;
            this.emailTF.Size = new System.Drawing.Size(151, 23);
            this.emailTF.TabIndex = 33;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(42, 297);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(124, 17);
            this.phoneLabel.TabIndex = 32;
            this.phoneLabel.Text = "Phone No            :";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(42, 259);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(123, 17);
            this.emailLabel.TabIndex = 31;
            this.emailLabel.Text = "Email                   :";
            // 
            // addressTF
            // 
            this.addressTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.addressTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTF.Location = new System.Drawing.Point(176, 222);
            this.addressTF.Name = "addressTF";
            this.addressTF.ReadOnly = true;
            this.addressTF.Size = new System.Drawing.Size(151, 23);
            this.addressTF.TabIndex = 30;
            // 
            // fullnameTF
            // 
            this.fullnameTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.fullnameTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameTF.Location = new System.Drawing.Point(176, 111);
            this.fullnameTF.Name = "fullnameTF";
            this.fullnameTF.ReadOnly = true;
            this.fullnameTF.Size = new System.Drawing.Size(151, 23);
            this.fullnameTF.TabIndex = 29;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(41, 223);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(125, 17);
            this.addressLabel.TabIndex = 28;
            this.addressLabel.Text = "Address                :";
            // 
            // dateofbirthLabel
            // 
            this.dateofbirthLabel.AutoSize = true;
            this.dateofbirthLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirthLabel.Location = new System.Drawing.Point(42, 187);
            this.dateofbirthLabel.Name = "dateofbirthLabel";
            this.dateofbirthLabel.Size = new System.Drawing.Size(124, 17);
            this.dateofbirthLabel.TabIndex = 27;
            this.dateofbirthLabel.Text = "Date of Birth        :";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(41, 151);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(124, 17);
            this.genderLabel.TabIndex = 26;
            this.genderLabel.Text = "Gender                :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(41, 114);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(124, 17);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Full Name            :";
            // 
            // publicationyearTF
            // 
            this.publicationyearTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicationyearTF.Location = new System.Drawing.Point(602, 186);
            this.publicationyearTF.Name = "publicationyearTF";
            this.publicationyearTF.ReadOnly = true;
            this.publicationyearTF.Size = new System.Drawing.Size(151, 23);
            this.publicationyearTF.TabIndex = 44;
            // 
            // quantityTF
            // 
            this.quantityTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.quantityTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTF.Location = new System.Drawing.Point(602, 222);
            this.quantityTF.Name = "quantityTF";
            this.quantityTF.ReadOnly = true;
            this.quantityTF.Size = new System.Drawing.Size(151, 23);
            this.quantityTF.TabIndex = 43;
            // 
            // authornameTF
            // 
            this.authornameTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.authornameTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authornameTF.Location = new System.Drawing.Point(602, 146);
            this.authornameTF.Name = "authornameTF";
            this.authornameTF.ReadOnly = true;
            this.authornameTF.Size = new System.Drawing.Size(151, 23);
            this.authornameTF.TabIndex = 42;
            // 
            // booknameTF
            // 
            this.booknameTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.booknameTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booknameTF.Location = new System.Drawing.Point(602, 114);
            this.booknameTF.Name = "booknameTF";
            this.booknameTF.ReadOnly = true;
            this.booknameTF.Size = new System.Drawing.Size(151, 23);
            this.booknameTF.TabIndex = 41;
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(461, 223);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(123, 17);
            this.quantity.TabIndex = 40;
            this.quantity.Text = "Quantity              :";
            // 
            // publicationYear
            // 
            this.publicationYear.AutoSize = true;
            this.publicationYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicationYear.Location = new System.Drawing.Point(461, 186);
            this.publicationYear.Name = "publicationYear";
            this.publicationYear.Size = new System.Drawing.Size(121, 17);
            this.publicationYear.TabIndex = 39;
            this.publicationYear.Text = "Publication Year :";
            // 
            // authorName
            // 
            this.authorName.AutoSize = true;
            this.authorName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorName.Location = new System.Drawing.Point(460, 147);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(123, 17);
            this.authorName.TabIndex = 38;
            this.authorName.Text = "Author Name      :";
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.Location = new System.Drawing.Point(460, 114);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(124, 17);
            this.bookName.TabIndex = 37;
            this.bookName.Text = "Book Name         :";
            // 
            // studentTxt
            // 
            this.studentTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentTxt.Location = new System.Drawing.Point(44, 71);
            this.studentTxt.Name = "studentTxt";
            this.studentTxt.Size = new System.Drawing.Size(141, 27);
            this.studentTxt.TabIndex = 45;
            this.studentTxt.Text = "Student Id";
            this.studentTxt.TextChanged += new System.EventHandler(this.studentTxt_TextChanged);
            this.studentTxt.Enter += new System.EventHandler(this.studentTxt_Enter);
            this.studentTxt.Leave += new System.EventHandler(this.studentTxt_Leave);
            // 
            // bookTxt
            // 
            this.bookTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTxt.Location = new System.Drawing.Point(464, 71);
            this.bookTxt.Name = "bookTxt";
            this.bookTxt.Size = new System.Drawing.Size(142, 27);
            this.bookTxt.TabIndex = 46;
            this.bookTxt.Text = "Book Id";
            this.bookTxt.Enter += new System.EventHandler(this.bookTxt_Enter);
            this.bookTxt.Leave += new System.EventHandler(this.bookTxt_Leave);
            // 
            // sbtnLoad
            // 
            this.sbtnLoad.Activecolor = System.Drawing.Color.MediumPurple;
            this.sbtnLoad.BackColor = System.Drawing.Color.MediumPurple;
            this.sbtnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sbtnLoad.BorderRadius = 0;
            this.sbtnLoad.ButtonText = "Load Student";
            this.sbtnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbtnLoad.DisabledColor = System.Drawing.Color.Gray;
            this.sbtnLoad.Iconcolor = System.Drawing.Color.Transparent;
            this.sbtnLoad.Iconimage = null;
            this.sbtnLoad.Iconimage_right = null;
            this.sbtnLoad.Iconimage_right_Selected = null;
            this.sbtnLoad.Iconimage_Selected = null;
            this.sbtnLoad.IconMarginLeft = 0;
            this.sbtnLoad.IconMarginRight = 0;
            this.sbtnLoad.IconRightVisible = true;
            this.sbtnLoad.IconRightZoom = 0D;
            this.sbtnLoad.IconVisible = true;
            this.sbtnLoad.IconZoom = 90D;
            this.sbtnLoad.IsTab = false;
            this.sbtnLoad.Location = new System.Drawing.Point(206, 71);
            this.sbtnLoad.Name = "sbtnLoad";
            this.sbtnLoad.Normalcolor = System.Drawing.Color.MediumPurple;
            this.sbtnLoad.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.sbtnLoad.OnHoverTextColor = System.Drawing.Color.White;
            this.sbtnLoad.selected = false;
            this.sbtnLoad.Size = new System.Drawing.Size(121, 29);
            this.sbtnLoad.TabIndex = 47;
            this.sbtnLoad.Text = "Load Student";
            this.sbtnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sbtnLoad.Textcolor = System.Drawing.Color.White;
            this.sbtnLoad.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtnLoad.Click += new System.EventHandler(this.sbtnLoad_Click);
            // 
            // bbtnLoad
            // 
            this.bbtnLoad.Activecolor = System.Drawing.Color.MediumPurple;
            this.bbtnLoad.BackColor = System.Drawing.Color.MediumPurple;
            this.bbtnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bbtnLoad.BorderRadius = 0;
            this.bbtnLoad.ButtonText = "Load Book";
            this.bbtnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bbtnLoad.DisabledColor = System.Drawing.Color.Gray;
            this.bbtnLoad.Iconcolor = System.Drawing.Color.Transparent;
            this.bbtnLoad.Iconimage = null;
            this.bbtnLoad.Iconimage_right = null;
            this.bbtnLoad.Iconimage_right_Selected = null;
            this.bbtnLoad.Iconimage_Selected = null;
            this.bbtnLoad.IconMarginLeft = 0;
            this.bbtnLoad.IconMarginRight = 0;
            this.bbtnLoad.IconRightVisible = true;
            this.bbtnLoad.IconRightZoom = 0D;
            this.bbtnLoad.IconVisible = true;
            this.bbtnLoad.IconZoom = 90D;
            this.bbtnLoad.IsTab = false;
            this.bbtnLoad.Location = new System.Drawing.Point(635, 71);
            this.bbtnLoad.Name = "bbtnLoad";
            this.bbtnLoad.Normalcolor = System.Drawing.Color.MediumPurple;
            this.bbtnLoad.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.bbtnLoad.OnHoverTextColor = System.Drawing.Color.White;
            this.bbtnLoad.selected = false;
            this.bbtnLoad.Size = new System.Drawing.Size(118, 29);
            this.bbtnLoad.TabIndex = 48;
            this.bbtnLoad.Text = "Load Book";
            this.bbtnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bbtnLoad.Textcolor = System.Drawing.Color.White;
            this.bbtnLoad.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtnLoad.Click += new System.EventHandler(this.bbtnLoad_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Activecolor = System.Drawing.Color.MediumPurple;
            this.btnIssue.BackColor = System.Drawing.Color.MediumPurple;
            this.btnIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIssue.BorderRadius = 0;
            this.btnIssue.ButtonText = "Issue Book";
            this.btnIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssue.DisabledColor = System.Drawing.Color.Gray;
            this.btnIssue.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIssue.Iconimage = null;
            this.btnIssue.Iconimage_right = null;
            this.btnIssue.Iconimage_right_Selected = null;
            this.btnIssue.Iconimage_Selected = null;
            this.btnIssue.IconMarginLeft = 0;
            this.btnIssue.IconMarginRight = 0;
            this.btnIssue.IconRightVisible = true;
            this.btnIssue.IconRightZoom = 0D;
            this.btnIssue.IconVisible = true;
            this.btnIssue.IconZoom = 90D;
            this.btnIssue.IsTab = false;
            this.btnIssue.Location = new System.Drawing.Point(234, 368);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnIssue.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btnIssue.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIssue.selected = false;
            this.btnIssue.Size = new System.Drawing.Size(121, 29);
            this.btnIssue.TabIndex = 49;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIssue.Textcolor = System.Drawing.Color.White;
            this.btnIssue.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // brwDate
            // 
            this.brwDate.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwDate.Location = new System.Drawing.Point(152, 47);
            this.brwDate.Name = "brwDate";
            this.brwDate.Size = new System.Drawing.Size(155, 20);
            this.brwDate.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Borrow Date        :";
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.MediumPurple;
            this.btnClear.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderRadius = 0;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.Gray;
            this.btnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClear.Iconimage = null;
            this.btnClear.Iconimage_right = null;
            this.btnClear.Iconimage_right_Selected = null;
            this.btnClear.Iconimage_Selected = null;
            this.btnClear.IconMarginLeft = 0;
            this.btnClear.IconMarginRight = 0;
            this.btnClear.IconRightVisible = true;
            this.btnClear.IconRightZoom = 0D;
            this.btnClear.IconVisible = true;
            this.btnClear.IconZoom = 90D;
            this.btnClear.IsTab = false;
            this.btnClear.Location = new System.Drawing.Point(417, 368);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnClear.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(121, 29);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Textcolor = System.Drawing.Color.White;
            this.btnClear.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // brwLabel
            // 
            this.brwLabel.AutoSize = true;
            this.brwLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwLabel.Location = new System.Drawing.Point(15, 25);
            this.brwLabel.Name = "brwLabel";
            this.brwLabel.Size = new System.Drawing.Size(125, 17);
            this.brwLabel.TabIndex = 54;
            this.brwLabel.Text = "Borrow Id             :";
            // 
            // brwTxt2
            // 
            this.brwTxt2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwTxt2.Location = new System.Drawing.Point(188, 20);
            this.brwTxt2.Name = "brwTxt2";
            this.brwTxt2.Size = new System.Drawing.Size(119, 23);
            this.brwTxt2.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rtnDate);
            this.panel1.Controls.Add(this.brwTxt1);
            this.panel1.Controls.Add(this.separatorAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.brwTxt2);
            this.panel1.Controls.Add(this.brwDate);
            this.panel1.Controls.Add(this.brwLabel);
            this.panel1.Location = new System.Drawing.Point(449, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 100);
            this.panel1.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Return Date         :";
            // 
            // rtnDate
            // 
            this.rtnDate.Location = new System.Drawing.Point(152, 73);
            this.rtnDate.Name = "rtnDate";
            this.rtnDate.Size = new System.Drawing.Size(155, 20);
            this.rtnDate.TabIndex = 59;
            // 
            // brwTxt1
            // 
            this.brwTxt1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brwTxt1.Location = new System.Drawing.Point(152, 20);
            this.brwTxt1.Name = "brwTxt1";
            this.brwTxt1.ReadOnly = true;
            this.brwTxt1.Size = new System.Drawing.Size(36, 23);
            this.brwTxt1.TabIndex = 58;
            this.brwTxt1.Text = "BR#";
            // 
            // separatorAdd
            // 
            this.separatorAdd.BackColor = System.Drawing.Color.Transparent;
            this.separatorAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.separatorAdd.LineThickness = 5;
            this.separatorAdd.Location = new System.Drawing.Point(5, 15);
            this.separatorAdd.Name = "separatorAdd";
            this.separatorAdd.Size = new System.Drawing.Size(97, 10);
            this.separatorAdd.TabIndex = 57;
            this.separatorAdd.Transparency = 255;
            this.separatorAdd.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Fill This For Issue";
            // 
            // feesTF
            // 
            this.feesTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.feesTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesTF.Location = new System.Drawing.Point(176, 329);
            this.feesTF.Name = "feesTF";
            this.feesTF.ReadOnly = true;
            this.feesTF.Size = new System.Drawing.Size(151, 23);
            this.feesTF.TabIndex = 58;
            // 
            // feesLabel
            // 
            this.feesLabel.AutoSize = true;
            this.feesLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesLabel.Location = new System.Drawing.Point(42, 332);
            this.feesLabel.Name = "feesLabel";
            this.feesLabel.Size = new System.Drawing.Size(123, 17);
            this.feesLabel.TabIndex = 57;
            this.feesLabel.Text = "Fees                     :";
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(802, 435);
            this.Controls.Add(this.feesTF);
            this.Controls.Add(this.feesLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.bbtnLoad);
            this.Controls.Add(this.sbtnLoad);
            this.Controls.Add(this.bookTxt);
            this.Controls.Add(this.studentTxt);
            this.Controls.Add(this.publicationyearTF);
            this.Controls.Add(this.quantityTF);
            this.Controls.Add(this.authornameTF);
            this.Controls.Add(this.booknameTF);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.publicationYear);
            this.Controls.Add(this.authorName);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.dobTF);
            this.Controls.Add(this.genderTF);
            this.Controls.Add(this.phoneTF2);
            this.Controls.Add(this.emailTF);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.addressTF);
            this.Controls.Add(this.fullnameTF);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.dateofbirthLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.panelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBook";
            this.Load += new System.EventHandler(this.IssueBook_Load);
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCross)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Label issue_book;
        private System.Windows.Forms.PictureBox pictureBoxCross;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobTF;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox genderTF;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox phoneTF2;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox emailTF;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox addressTF;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox fullnameTF;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dateofbirthLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox bookTxt;
        private System.Windows.Forms.TextBox studentTxt;
        private System.Windows.Forms.TextBox publicationyearTF;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox quantityTF;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox authornameTF;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox booknameTF;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label publicationYear;
        private System.Windows.Forms.Label authorName;
        private System.Windows.Forms.Label bookName;
        private Bunifu.Framework.UI.BunifuFlatButton bbtnLoad;
        private Bunifu.Framework.UI.BunifuFlatButton sbtnLoad;
        private Bunifu.Framework.UI.BunifuFlatButton btnIssue;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker brwDate;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox brwTxt2;
        private System.Windows.Forms.Label brwLabel;
        private System.Windows.Forms.TextBox brwTxt1;
        private Bunifu.Framework.UI.BunifuSeparator separatorAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker rtnDate;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox feesTF;
        private System.Windows.Forms.Label feesLabel;
    }
}