using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BAL;
using BEL;
using System.IO;


namespace Login
{
    public partial class ManageBook : UserControl
    {
        string imgLocation = "";
        public Information info = new Information();
        public Operations opr = new Operations();

        ViewBook vb = new ViewBook();
        
        

        public ManageBook()
        {
            InitializeComponent();
        }

        private void labelAdd_Click(object sender, EventArgs e)
        {
            separatorAdd.Width = labelAdd.Width;
            separatorAdd.Left = labelAdd.Left;
            // hide the user control view book.
            vb.Hide();

            // clear field
            bookidTF2.Text = "";
            booknameTF.Text = "";
            authornameTF.Text = "";
            yearComboBox.Text = "";
            quantityTF.Text = "";
            this.uploadBookPic.Image = null;
        }

        private void labelView_Click(object sender, EventArgs e)
        {
            separatorAdd.Width = labelView.Width;
            separatorAdd.Left = labelView.Left;

            // add user control in view book
            panelDetails.Controls.Add(vb);
            vb.Show();
            vb.BringToFront();
        }

        private void panelDetails_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            vb.Hide();
            //vb.BringToFront();
            //FormLogin fl = new FormLogin();
            //AdminPanel ap = new AdminPanel(fl.txtUsername.Text);
            //ap.Show();
        }

        //open computer resource to choose image.
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                uploadBookPic.ImageLocation = imgLocation;
            }
        }



        //insert the value in db
        private void btnAdd_Click(object sender, EventArgs e)
        {
           // Declaring the picture box in byte type.
            byte[] uploadBookpic = null;

            // check for input integer value.
            int result = 0;
            if (int.TryParse(booknameTF.Text, out result) || int.TryParse(authornameTF.Text, out result))
            {
                MessageBox.Show("Enter Valid Name.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                try
                {
                    // field empty check
                    if (bookidTF2.Text.Length == 0 || booknameTF.Text.Length == 0 || authornameTF.Text.Length == 0 || yearComboBox.Text.Length == 0 || quantityTF.Text.Length == 0 || uploadBookPic.Image == null)
                    {
                        MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   

                    else
                    {
                        // converting img in binary value.
                        FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        uploadBookpic = br.ReadBytes((int)fs.Length);

                        //BAL and BEL Layer execution.
                        info.bookId = bookidTF.Text + bookidTF2.Text;
                        info.bookName = booknameTF.Text;
                        info.authorName = authornameTF.Text;
                        info.publicationYear = Convert.ToInt32(yearComboBox.Text);
                        info.quantity = Convert.ToInt32(quantityTF.Text);
                        info.images = uploadBookpic;

                        opr.insertBook(info);

                        MessageBox.Show("Information Saved successfully.", "Success", MessageBoxButtons.OK);
                        bookidTF2.Text = "";
                        booknameTF.Text = "";
                        authornameTF.Text = "";
                        yearComboBox.Text="";
                        quantityTF.Text = "";
                        this.uploadBookPic.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Already exist!");
                    bookidTF2.Text = "";
                    booknameTF.Text = "";
                    authornameTF.Text = "";
                    yearComboBox.Text = "";
                    quantityTF.Text = "";
                    this.uploadBookPic.Image = null;
                }
            }
        }

        private void ManageBook_Load(object sender, EventArgs e)
        {
            bookidTF2.Text = "";
            booknameTF.Text = "";
            authornameTF.Text = "";
            yearComboBox.Text = "";
            quantityTF.Text = "";
            this.uploadBookPic.Image = null;
        }

        private void booknameTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void authornameTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
    }
}
