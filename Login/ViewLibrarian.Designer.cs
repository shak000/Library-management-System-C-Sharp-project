namespace Login
{
    partial class ViewLibrarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLibrarian));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDgb = new System.Windows.Forms.Panel();
            this.dgbLibrarian = new System.Windows.Forms.DataGridView();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dateofbirthLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.librarianIdLabel = new System.Windows.Forms.Label();
            this.chooseimgLabel = new System.Windows.Forms.Label();
            this.uploadLibrarianPic = new System.Windows.Forms.PictureBox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBrowse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.phoneTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.emailTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.addressTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.genderTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.librarianidTF2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.fullnameTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.dobTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.salaryTF = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnClean = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbLibrarian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uploadLibrarianPic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(23, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(479, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search by Librarian Name or Librarian Id";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(478, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // panelDgb
            // 
            this.panelDgb.Controls.Add(this.dgbLibrarian);
            this.panelDgb.Location = new System.Drawing.Point(4, 251);
            this.panelDgb.Name = "panelDgb";
            this.panelDgb.Size = new System.Drawing.Size(506, 151);
            this.panelDgb.TabIndex = 30;
            this.panelDgb.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDgb_Paint);
            // 
            // dgbLibrarian
            // 
            this.dgbLibrarian.AllowUserToAddRows = false;
            this.dgbLibrarian.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgbLibrarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbLibrarian.GridColor = System.Drawing.SystemColors.Control;
            this.dgbLibrarian.Location = new System.Drawing.Point(9, 6);
            this.dgbLibrarian.Name = "dgbLibrarian";
            this.dgbLibrarian.ReadOnly = true;
            this.dgbLibrarian.ShowRowErrors = false;
            this.dgbLibrarian.Size = new System.Drawing.Size(490, 140);
            this.dgbLibrarian.TabIndex = 0;
            this.dgbLibrarian.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbLibrarian_CellContentClick);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(20, 207);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(124, 17);
            this.phoneLabel.TabIndex = 37;
            this.phoneLabel.Text = "Phone No            :";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(22, 181);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(123, 17);
            this.emailLabel.TabIndex = 36;
            this.emailLabel.Text = "Email                   :";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(20, 151);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(125, 17);
            this.addressLabel.TabIndex = 35;
            this.addressLabel.Text = "Address                :";
            // 
            // dateofbirthLabel
            // 
            this.dateofbirthLabel.AutoSize = true;
            this.dateofbirthLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirthLabel.Location = new System.Drawing.Point(20, 122);
            this.dateofbirthLabel.Name = "dateofbirthLabel";
            this.dateofbirthLabel.Size = new System.Drawing.Size(124, 17);
            this.dateofbirthLabel.TabIndex = 34;
            this.dateofbirthLabel.Text = "Date of Birth        :";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(20, 93);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(124, 17);
            this.genderLabel.TabIndex = 33;
            this.genderLabel.Text = "Gender                :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(20, 65);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(124, 17);
            this.nameLabel.TabIndex = 32;
            this.nameLabel.Text = "Full Name            :";
            // 
            // librarianIdLabel
            // 
            this.librarianIdLabel.AutoSize = true;
            this.librarianIdLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librarianIdLabel.Location = new System.Drawing.Point(20, 34);
            this.librarianIdLabel.Name = "librarianIdLabel";
            this.librarianIdLabel.Size = new System.Drawing.Size(124, 17);
            this.librarianIdLabel.TabIndex = 31;
            this.librarianIdLabel.Text = "Librarian ID          :";
            // 
            // chooseimgLabel
            // 
            this.chooseimgLabel.AutoSize = true;
            this.chooseimgLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseimgLabel.Location = new System.Drawing.Point(273, 82);
            this.chooseimgLabel.Name = "chooseimgLabel";
            this.chooseimgLabel.Size = new System.Drawing.Size(122, 17);
            this.chooseimgLabel.TabIndex = 42;
            this.chooseimgLabel.Text = "Update  image? :";
            // 
            // uploadLibrarianPic
            // 
            this.uploadLibrarianPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uploadLibrarianPic.Location = new System.Drawing.Point(401, 82);
            this.uploadLibrarianPic.Name = "uploadLibrarianPic";
            this.uploadLibrarianPic.Size = new System.Drawing.Size(103, 93);
            this.uploadLibrarianPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uploadLibrarianPic.TabIndex = 40;
            this.uploadLibrarianPic.TabStop = false;
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
            this.btnDelete.Location = new System.Drawing.Point(353, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnDelete.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(68, 29);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(269, 209);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnUpdate.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(68, 29);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnBrowse.Location = new System.Drawing.Point(401, 181);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnBrowse.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btnBrowse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowse.selected = false;
            this.btnBrowse.Size = new System.Drawing.Size(103, 15);
            this.btnBrowse.TabIndex = 45;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowse.Textcolor = System.Drawing.Color.White;
            this.btnBrowse.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // phoneTF
            // 
            this.phoneTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.phoneTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTF.Location = new System.Drawing.Point(151, 204);
            this.phoneTF.Name = "phoneTF";
            this.phoneTF.Size = new System.Drawing.Size(92, 23);
            this.phoneTF.TabIndex = 51;
            // 
            // emailTF
            // 
            this.emailTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.emailTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTF.Location = new System.Drawing.Point(151, 177);
            this.emailTF.Name = "emailTF";
            this.emailTF.Size = new System.Drawing.Size(92, 23);
            this.emailTF.TabIndex = 50;
            // 
            // addressTF
            // 
            this.addressTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.addressTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTF.Location = new System.Drawing.Point(151, 150);
            this.addressTF.Name = "addressTF";
            this.addressTF.Size = new System.Drawing.Size(92, 23);
            this.addressTF.TabIndex = 49;
            // 
            // genderTF
            // 
            this.genderTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.genderTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTF.Location = new System.Drawing.Point(151, 91);
            this.genderTF.Name = "genderTF";
            this.genderTF.Size = new System.Drawing.Size(92, 23);
            this.genderTF.TabIndex = 48;
            this.genderTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.genderTF_KeyPress);
            // 
            // librarianidTF2
            // 
            this.librarianidTF2.BorderColor = System.Drawing.Color.SeaGreen;
            this.librarianidTF2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librarianidTF2.Location = new System.Drawing.Point(151, 35);
            this.librarianidTF2.Name = "librarianidTF2";
            this.librarianidTF2.Size = new System.Drawing.Size(92, 23);
            this.librarianidTF2.TabIndex = 47;
            // 
            // fullnameTF
            // 
            this.fullnameTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.fullnameTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameTF.Location = new System.Drawing.Point(151, 63);
            this.fullnameTF.Name = "fullnameTF";
            this.fullnameTF.Size = new System.Drawing.Size(92, 23);
            this.fullnameTF.TabIndex = 46;
            this.fullnameTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fullnameTF_KeyPress);
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLabel.Location = new System.Drawing.Point(273, 38);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(121, 17);
            this.salaryLabel.TabIndex = 55;
            this.salaryLabel.Text = "Salary                  :";
            // 
            // dobTF
            // 
            this.dobTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobTF.Location = new System.Drawing.Point(151, 120);
            this.dobTF.Name = "dobTF";
            this.dobTF.Size = new System.Drawing.Size(92, 23);
            this.dobTF.TabIndex = 56;
            this.dobTF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dobTF_KeyPress);
            // 
            // salaryTF
            // 
            this.salaryTF.BorderColor = System.Drawing.Color.SeaGreen;
            this.salaryTF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryTF.Location = new System.Drawing.Point(410, 38);
            this.salaryTF.Name = "salaryTF";
            this.salaryTF.Size = new System.Drawing.Size(92, 23);
            this.salaryTF.TabIndex = 57;
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
            this.btnClean.Location = new System.Drawing.Point(436, 207);
            this.btnClean.Name = "btnClean";
            this.btnClean.Normalcolor = System.Drawing.Color.MediumPurple;
            this.btnClean.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btnClean.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClean.selected = false;
            this.btnClean.Size = new System.Drawing.Size(68, 29);
            this.btnClean.TabIndex = 72;
            this.btnClean.Text = "Clear";
            this.btnClean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClean.Textcolor = System.Drawing.Color.White;
            this.btnClean.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // ViewLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.salaryTF);
            this.Controls.Add(this.dobTF);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.phoneTF);
            this.Controls.Add(this.emailTF);
            this.Controls.Add(this.addressTF);
            this.Controls.Add(this.genderTF);
            this.Controls.Add(this.librarianidTF2);
            this.Controls.Add(this.fullnameTF);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.chooseimgLabel);
            this.Controls.Add(this.uploadLibrarianPic);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.dateofbirthLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.librarianIdLabel);
            this.Controls.Add(this.panelDgb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Name = "ViewLibrarian";
            this.Size = new System.Drawing.Size(529, 427);
            this.Load += new System.EventHandler(this.ViewLibrarian_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewLibrarian_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDgb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgbLibrarian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uploadLibrarianPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDgb;
        private System.Windows.Forms.DataGridView dgbLibrarian;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dateofbirthLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label librarianIdLabel;
        private System.Windows.Forms.Label chooseimgLabel;
        public System.Windows.Forms.PictureBox uploadLibrarianPic;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowse;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox phoneTF;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox emailTF;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox addressTF;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox genderTF;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox librarianidTF2;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox fullnameTF;
        public System.Windows.Forms.Label salaryLabel;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobTF;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox salaryTF;
        private Bunifu.Framework.UI.BunifuFlatButton btnClean;
    }
}
