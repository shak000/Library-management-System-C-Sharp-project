namespace Login
{
    partial class ManageBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBook));
            this.panelDetails = new System.Windows.Forms.Panel();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBrowse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.uploadBookPic = new System.Windows.Forms.PictureBox();
            this.image = new System.Windows.Forms.Label();
            this.quantityTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bookidTF2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.authornameTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.booknameTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bookidTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.quantity = new System.Windows.Forms.Label();
            this.publicationYear = new System.Windows.Forms.Label();
            this.authorName = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.Label();
            this.bookId = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.labelView = new System.Windows.Forms.Label();
            this.separatorAdd = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadBookPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDetails
            // 
            this.panelDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetails.Controls.Add(this.yearComboBox);
            this.panelDetails.Controls.Add(this.btnAdd);
            this.panelDetails.Controls.Add(this.btnBack);
            this.panelDetails.Controls.Add(this.btnBrowse);
            this.panelDetails.Controls.Add(this.uploadBookPic);
            this.panelDetails.Controls.Add(this.image);
            this.panelDetails.Controls.Add(this.quantityTF);
            this.panelDetails.Controls.Add(this.bookidTF2);
            this.panelDetails.Controls.Add(this.authornameTF);
            this.panelDetails.Controls.Add(this.booknameTF);
            this.panelDetails.Controls.Add(this.bookidTF);
            this.panelDetails.Controls.Add(this.quantity);
            this.panelDetails.Controls.Add(this.publicationYear);
            this.panelDetails.Controls.Add(this.authorName);
            this.panelDetails.Controls.Add(this.bookName);
            this.panelDetails.Controls.Add(this.bookId);
            this.panelDetails.Location = new System.Drawing.Point(28, 46);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(527, 403);
            this.panelDetails.TabIndex = 0;
            this.panelDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDetails_Paint);
            // 
            // yearComboBox
            // 
            this.yearComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018"});
            this.yearComboBox.Location = new System.Drawing.Point(205, 156);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(175, 25);
            this.yearComboBox.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.DarkSlateBlue;
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAdd.Iconimage")));
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(127, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(99, 29);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.DarkSlateBlue;
            this.btnBack.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = "Back";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBack.Iconimage")));
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconMarginLeft = 0;
            this.btnBack.IconMarginRight = 0;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 90D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(281, 344);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.MediumSlateBlue;
            this.btnBack.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btnBack.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(99, 29);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Textcolor = System.Drawing.Color.White;
            this.btnBack.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Activecolor = System.Drawing.Color.DarkSlateBlue;
            this.btnBrowse.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.BorderRadius = 0;
            this.btnBrowse.ButtonText = "Browse";
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowse.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowse.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Iconimage")));
            this.btnBrowse.Iconimage_right = null;
            this.btnBrowse.Iconimage_right_Selected = null;
            this.btnBrowse.Iconimage_Selected = null;
            this.btnBrowse.IconMarginLeft = 0;
            this.btnBrowse.IconMarginRight = 0;
            this.btnBrowse.IconRightVisible = true;
            this.btnBrowse.IconRightZoom = 0D;
            this.btnBrowse.IconVisible = false;
            this.btnBrowse.IconZoom = 90D;
            this.btnBrowse.IsTab = false;
            this.btnBrowse.Location = new System.Drawing.Point(285, 239);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Normalcolor = System.Drawing.Color.MediumSlateBlue;
            this.btnBrowse.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btnBrowse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowse.selected = false;
            this.btnBrowse.Size = new System.Drawing.Size(95, 23);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowse.Textcolor = System.Drawing.Color.White;
            this.btnBrowse.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // uploadBookPic
            // 
            this.uploadBookPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uploadBookPic.Location = new System.Drawing.Point(205, 239);
            this.uploadBookPic.Name = "uploadBookPic";
            this.uploadBookPic.Size = new System.Drawing.Size(74, 72);
            this.uploadBookPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uploadBookPic.TabIndex = 12;
            this.uploadBookPic.TabStop = false;
            // 
            // image
            // 
            this.image.AutoSize = true;
            this.image.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image.Location = new System.Drawing.Point(28, 247);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(129, 17);
            this.image.TabIndex = 11;
            this.image.Text = "Choose an image:";
            // 
            // quantityTF
            // 
            this.quantityTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.quantityTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTF.Location = new System.Drawing.Point(205, 198);
            this.quantityTF.Name = "quantityTF";
            this.quantityTF.Size = new System.Drawing.Size(175, 23);
            this.quantityTF.TabIndex = 10;
            // 
            // bookidTF2
            // 
            this.bookidTF2.BorderColor = System.Drawing.Color.SeaGreen;
            this.bookidTF2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookidTF2.Location = new System.Drawing.Point(238, 35);
            this.bookidTF2.Name = "bookidTF2";
            this.bookidTF2.Size = new System.Drawing.Size(142, 23);
            this.bookidTF2.TabIndex = 8;
            // 
            // authornameTF
            // 
            this.authornameTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.authornameTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authornameTF.Location = new System.Drawing.Point(205, 117);
            this.authornameTF.Name = "authornameTF";
            this.authornameTF.Size = new System.Drawing.Size(175, 23);
            this.authornameTF.TabIndex = 7;
            this.authornameTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.authornameTF_KeyPress);
            // 
            // booknameTF
            // 
            this.booknameTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.booknameTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booknameTF.Location = new System.Drawing.Point(205, 76);
            this.booknameTF.Name = "booknameTF";
            this.booknameTF.Size = new System.Drawing.Size(175, 23);
            this.booknameTF.TabIndex = 6;
            this.booknameTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.booknameTF_KeyPress);
            // 
            // bookidTF
            // 
            this.bookidTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.bookidTF.Enabled = false;
            this.bookidTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookidTF.Location = new System.Drawing.Point(205, 35);
            this.bookidTF.Name = "bookidTF";
            this.bookidTF.Size = new System.Drawing.Size(33, 23);
            this.bookidTF.TabIndex = 5;
            this.bookidTF.Text = "BO#";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(27, 202);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(123, 17);
            this.quantity.TabIndex = 4;
            this.quantity.Text = "Quantity              :";
            // 
            // publicationYear
            // 
            this.publicationYear.AutoSize = true;
            this.publicationYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicationYear.Location = new System.Drawing.Point(28, 160);
            this.publicationYear.Name = "publicationYear";
            this.publicationYear.Size = new System.Drawing.Size(121, 17);
            this.publicationYear.TabIndex = 3;
            this.publicationYear.Text = "Publication Year :";
            // 
            // authorName
            // 
            this.authorName.AutoSize = true;
            this.authorName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorName.Location = new System.Drawing.Point(27, 118);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(123, 17);
            this.authorName.TabIndex = 2;
            this.authorName.Text = "Author Name      :";
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.Location = new System.Drawing.Point(27, 79);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(124, 17);
            this.bookName.TabIndex = 1;
            this.bookName.Text = "Book Name         :";
            // 
            // bookId
            // 
            this.bookId.AutoSize = true;
            this.bookId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookId.Location = new System.Drawing.Point(27, 38);
            this.bookId.Name = "bookId";
            this.bookId.Size = new System.Drawing.Size(125, 17);
            this.bookId.TabIndex = 0;
            this.bookId.Text = "Book ID                :";
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(26, 19);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(87, 20);
            this.labelAdd.TabIndex = 1;
            this.labelAdd.Text = "Add Books";
            this.labelAdd.Click += new System.EventHandler(this.labelAdd_Click);
            // 
            // labelView
            // 
            this.labelView.AutoSize = true;
            this.labelView.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelView.Location = new System.Drawing.Point(122, 19);
            this.labelView.Name = "labelView";
            this.labelView.Size = new System.Drawing.Size(94, 20);
            this.labelView.TabIndex = 2;
            this.labelView.Text = "View Books";
            this.labelView.Click += new System.EventHandler(this.labelView_Click);
            // 
            // separatorAdd
            // 
            this.separatorAdd.BackColor = System.Drawing.Color.Transparent;
            this.separatorAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.separatorAdd.LineThickness = 5;
            this.separatorAdd.Location = new System.Drawing.Point(28, 37);
            this.separatorAdd.Name = "separatorAdd";
            this.separatorAdd.Size = new System.Drawing.Size(83, 10);
            this.separatorAdd.TabIndex = 3;
            this.separatorAdd.Transparency = 255;
            this.separatorAdd.Vertical = false;
            // 
            // ManageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.separatorAdd);
            this.Controls.Add(this.labelView);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.panelDetails);
            this.Name = "ManageBook";
            this.Size = new System.Drawing.Size(582, 470);
            this.Load += new System.EventHandler(this.ManageBook_Load);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadBookPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Label labelView;
        private Bunifu.Framework.UI.BunifuSeparator separatorAdd;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label publicationYear;
        private System.Windows.Forms.Label authorName;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.Label bookId;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bookidTF;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowse;
        private System.Windows.Forms.Label image;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox authornameTF;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox booknameTF;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox bookidTF2;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox quantityTF;
        public System.Windows.Forms.PictureBox uploadBookPic;
        public System.Windows.Forms.ComboBox yearComboBox;
    }
}
