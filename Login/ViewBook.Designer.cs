namespace Login
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            this.dgbBook = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.Label();
            this.publicationYear = new System.Windows.Forms.Label();
            this.authorName = new System.Windows.Forms.Label();
            this.bookName = new System.Windows.Forms.Label();
            this.bookId = new System.Windows.Forms.Label();
            this.quantityTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bookidTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.authornameTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.booknameTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.publicationyearTF = new System.Windows.Forms.TextBox();
            this.viewBookPic = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelDgb = new System.Windows.Forms.Panel();
            this.btnBrowse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClean = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgbBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBookPic)).BeginInit();
            this.panelDgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbBook
            // 
            this.dgbBook.AllowUserToAddRows = false;
            this.dgbBook.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgbBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbBook.GridColor = System.Drawing.SystemColors.Control;
            this.dgbBook.Location = new System.Drawing.Point(9, 3);
            this.dgbBook.Name = "dgbBook";
            this.dgbBook.ReadOnly = true;
            this.dgbBook.ShowRowErrors = false;
            this.dgbBook.Size = new System.Drawing.Size(490, 150);
            this.dgbBook.TabIndex = 0;
            this.dgbBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbBook_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(19, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(459, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search by Book Name or Book Id";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(17, 163);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(123, 17);
            this.quantity.TabIndex = 9;
            this.quantity.Text = "Quantity              :";
            // 
            // publicationYear
            // 
            this.publicationYear.AutoSize = true;
            this.publicationYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicationYear.Location = new System.Drawing.Point(17, 135);
            this.publicationYear.Name = "publicationYear";
            this.publicationYear.Size = new System.Drawing.Size(121, 17);
            this.publicationYear.TabIndex = 8;
            this.publicationYear.Text = "Publication Year :";
            // 
            // authorName
            // 
            this.authorName.AutoSize = true;
            this.authorName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorName.Location = new System.Drawing.Point(16, 108);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(123, 17);
            this.authorName.TabIndex = 7;
            this.authorName.Text = "Author Name      :";
            // 
            // bookName
            // 
            this.bookName.AutoSize = true;
            this.bookName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.Location = new System.Drawing.Point(16, 78);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(124, 17);
            this.bookName.TabIndex = 6;
            this.bookName.Text = "Book Name         :";
            // 
            // bookId
            // 
            this.bookId.AutoSize = true;
            this.bookId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookId.Location = new System.Drawing.Point(17, 50);
            this.bookId.Name = "bookId";
            this.bookId.Size = new System.Drawing.Size(125, 17);
            this.bookId.TabIndex = 5;
            this.bookId.Text = "Book ID                :";
            // 
            // quantityTF
            // 
            this.quantityTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.quantityTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTF.Location = new System.Drawing.Point(158, 162);
            this.quantityTF.Name = "quantityTF";
            this.quantityTF.Size = new System.Drawing.Size(151, 23);
            this.quantityTF.TabIndex = 21;
            // 
            // bookidTF
            // 
            this.bookidTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.bookidTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookidTF.Location = new System.Drawing.Point(158, 50);
            this.bookidTF.Name = "bookidTF";
            this.bookidTF.Size = new System.Drawing.Size(151, 23);
            this.bookidTF.TabIndex = 20;
            // 
            // authornameTF
            // 
            this.authornameTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.authornameTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authornameTF.Location = new System.Drawing.Point(158, 107);
            this.authornameTF.Name = "authornameTF";
            this.authornameTF.Size = new System.Drawing.Size(151, 23);
            this.authornameTF.TabIndex = 19;
            this.authornameTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.authornameTF_KeyPress);
            // 
            // booknameTF
            // 
            this.booknameTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.booknameTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booknameTF.Location = new System.Drawing.Point(158, 78);
            this.booknameTF.Name = "booknameTF";
            this.booknameTF.Size = new System.Drawing.Size(151, 23);
            this.booknameTF.TabIndex = 18;
            this.booknameTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.booknameTF_KeyPress);
            // 
            // publicationyearTF
            // 
            this.publicationyearTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicationyearTF.Location = new System.Drawing.Point(158, 135);
            this.publicationyearTF.Name = "publicationyearTF";
            this.publicationyearTF.Size = new System.Drawing.Size(151, 23);
            this.publicationyearTF.TabIndex = 22;
            // 
            // viewBookPic
            // 
            this.viewBookPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewBookPic.Location = new System.Drawing.Point(371, 48);
            this.viewBookPic.Name = "viewBookPic";
            this.viewBookPic.Size = new System.Drawing.Size(107, 107);
            this.viewBookPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.viewBookPic.TabIndex = 23;
            this.viewBookPic.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.MediumPurple;
            this.btnUpdate.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = null;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(80, 201);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnUpdate.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(93, 29);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.MediumPurple;
            this.btnDelete.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(224, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnDelete.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(93, 29);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelDgb
            // 
            this.panelDgb.Controls.Add(this.dgbBook);
            this.panelDgb.Location = new System.Drawing.Point(10, 238);
            this.panelDgb.Name = "panelDgb";
            this.panelDgb.Size = new System.Drawing.Size(506, 165);
            this.panelDgb.TabIndex = 26;
            this.panelDgb.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDgb_Paint);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Activecolor = System.Drawing.Color.MediumPurple;
            this.btnBrowse.BackColor = System.Drawing.Color.MediumPurple;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.BorderRadius = 0;
            this.btnBrowse.ButtonText = "Browse";
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowse.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowse.Iconimage = null;
            this.btnBrowse.Iconimage_right = null;
            this.btnBrowse.Iconimage_right_Selected = null;
            this.btnBrowse.Iconimage_Selected = null;
            this.btnBrowse.IconMarginLeft = 0;
            this.btnBrowse.IconMarginRight = 0;
            this.btnBrowse.IconRightVisible = true;
            this.btnBrowse.IconRightZoom = 0D;
            this.btnBrowse.IconVisible = true;
            this.btnBrowse.IconZoom = 90D;
            this.btnBrowse.IsTab = false;
            this.btnBrowse.Location = new System.Drawing.Point(378, 164);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnBrowse.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btnBrowse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowse.selected = false;
            this.btnBrowse.Size = new System.Drawing.Size(93, 16);
            this.btnBrowse.TabIndex = 27;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowse.Textcolor = System.Drawing.Color.White;
            this.btnBrowse.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnClean
            // 
            this.btnClean.Activecolor = System.Drawing.Color.MediumPurple;
            this.btnClean.BackColor = System.Drawing.Color.MediumPurple;
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClean.BorderRadius = 0;
            this.btnClean.ButtonText = "Clear";
            this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClean.DisabledColor = System.Drawing.Color.Gray;
            this.btnClean.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClean.Iconimage = null;
            this.btnClean.Iconimage_right = null;
            this.btnClean.Iconimage_right_Selected = null;
            this.btnClean.Iconimage_Selected = null;
            this.btnClean.IconMarginLeft = 0;
            this.btnClean.IconMarginRight = 0;
            this.btnClean.IconRightVisible = true;
            this.btnClean.IconRightZoom = 0D;
            this.btnClean.IconVisible = true;
            this.btnClean.IconZoom = 90D;
            this.btnClean.IsTab = false;
            this.btnClean.Location = new System.Drawing.Point(371, 201);
            this.btnClean.Name = "btnClean";
            this.btnClean.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnClean.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btnClean.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClean.selected = false;
            this.btnClean.Size = new System.Drawing.Size(93, 29);
            this.btnClean.TabIndex = 29;
            this.btnClean.Text = "Clear";
            this.btnClean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClean.Textcolor = System.Drawing.Color.White;
            this.btnClean.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.panelDgb);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.viewBookPic);
            this.Controls.Add(this.publicationyearTF);
            this.Controls.Add(this.quantityTF);
            this.Controls.Add(this.bookidTF);
            this.Controls.Add(this.authornameTF);
            this.Controls.Add(this.booknameTF);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.publicationYear);
            this.Controls.Add(this.authorName);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.bookId);
            this.Controls.Add(this.txtSearch);
            this.Name = "ViewBook";
            this.Size = new System.Drawing.Size(529, 427);
            this.Load += new System.EventHandler(this.ViewBook_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewBook_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgbBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBookPic)).EndInit();
            this.panelDgb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbBook;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label publicationYear;
        private System.Windows.Forms.Label authorName;
        private System.Windows.Forms.Label bookName;
        private System.Windows.Forms.Label bookId;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bookidTF;
        private System.Windows.Forms.PictureBox viewBookPic;
        private System.Windows.Forms.Panel panelDgb;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        public Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        public Bunifu.Framework.UI.BunifuFlatButton btnBrowse;
        public Bunifu.Framework.UI.BunifuFlatButton btnClean;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox quantityTF;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox authornameTF;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox booknameTF;
        public System.Windows.Forms.TextBox publicationyearTF;
    }
}
