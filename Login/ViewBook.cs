using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;
using System.IO;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace Login
{
    public partial class ViewBook : UserControl
    {
        public Information info = new Information ();
        public Operations opr = new Operations ();

        string imgLocation = "";

        public ViewBook()
        {
            InitializeComponent();
            bookidTF.Enabled = false;
        }

        //fetching data from the database
        private void ViewBook_Load(object sender, EventArgs e)
        {
            dgvUpdate();
            
            
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search by Book Name or Book Id"))
            {
                txtSearch.Text = "";

            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                txtSearch.Text = @"Search by Book Name or Book Id";

            }
        }

        // update the shown dataTable always.
        public void dgvUpdate()
        {
            DataTable dt = new DataTable();
            dt = opr.ViewBooks(info);
            dgbBook.DataSource = dt;
        }

        //fetching update data from the database
        public void panelDgb_Paint(object sender, PaintEventArgs e)
        {
            dgvUpdate();

            // Edit the column name.
            dgbBook.Columns[0].HeaderCell.Value = "Book Id";
            dgbBook.Columns[1].HeaderCell.Value = "Book Name";
            dgbBook.Columns[2].HeaderCell.Value = "Author Name";
            dgbBook.Columns[3].HeaderCell.Value = "Publication Year";
            dgbBook.Columns[4].HeaderCell.Value = "Quantity";
            dgbBook.Columns[5].HeaderCell.Value = "Image";

            bookidTF.Text = "";
            booknameTF.Text = "";
            authornameTF.Text = "";
            publicationyearTF.Text = "";
            quantityTF.Text = "";
            this.viewBookPic.Image = null;

           
        }

        // Search by Name or id
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-N1PTAGF;Initial Catalog=Library_management_System;Integrated Security=True;Pooling=False");
            con.Open();
            string query = "select * from books where bookName like '%" + txtSearch.Text + "%' or bookId like '%" + txtSearch.Text + "%'";
            //string query1 = "select * from books where bookId like '%" + txtSearch.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, con);
            //SqlCommand cmdd = new SqlCommand(query1,con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //SqlDataAdapter sdaa = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            //sdaa.Fill(dt);
            sda.Fill(dt);
            dgbBook.DataSource = dt;
            con.Close();
        }  
       

        private void dgbBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgbBook.Rows[e.RowIndex];
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)dgbBook.Columns[5];

                bookidTF.Text = row.Cells["bookId"].Value.ToString();
                booknameTF.Text = row.Cells["bookName"].Value.ToString();
                authornameTF.Text = row.Cells["authorName"].Value.ToString();
                publicationyearTF.Text = row.Cells["publicationYear"].Value.ToString();
                quantityTF.Text = row.Cells["quantity"].Value.ToString();

                //Retriving the images from data Grid View.
                var data = (Byte[])(row.Cells["bookImage"].Value);
                var stream = new MemoryStream(data);
                viewBookPic.Image = Image.FromStream(stream);
            }
            else { }
        }

        // image processing
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                viewBookPic.ImageLocation = imgLocation;
            }

            updateImage();
        }

        //image update 
        public void updateImage()
        {
            try
            {
                byte[] viewBookPic = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                viewBookPic = br.ReadBytes((int)fs.Length);
                info.images = viewBookPic;
                info.bookId = bookidTF.Text;

                opr.updatePictures(info);
            }
            catch(Exception ex)
            {}
            // update grid view
            dgvUpdate();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Declaring the picture box in byte type.

            

           /* */
            // check for input integer value.
            int result = 0;
            if (int.TryParse(booknameTF.Text, out result) || int.TryParse(authornameTF.Text, out result))
            {
                MessageBox.Show("Enter Valid Name.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {            
                    // field empty check
                    if (booknameTF.Text.Length == 0 || authornameTF.Text.Length == 0 || publicationyearTF.Text.Length == 0 || quantityTF.Text.Length == 0)
                    {
                        MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {

                            info.bookId = bookidTF.Text;
                            info.bookName = booknameTF.Text;
                            info.authorName = authornameTF.Text;
                            info.publicationYear = Convert.ToInt32(publicationyearTF.Text);
                            info.quantity = Convert.ToInt32(quantityTF.Text);


                            opr.updateBook(info);
                            

                            MessageBox.Show("Information Updated successfully.", "Success", MessageBoxButtons.OK);
                            // update grid view
                            dgvUpdate();

                            bookidTF.Text = "";
                            booknameTF.Text = "";
                            authornameTF.Text = "";
                            publicationyearTF.Text = "";
                            quantityTF.Text = "";
                            this.viewBookPic.Image = null;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("opps!","Error",MessageBoxButtons.OK);
                        }
                    }                               
            }            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           

                if (bookidTF.Text.Length != 0)
                {
                    info.bookId = bookidTF.Text;
                    DialogResult dr = MessageBox.Show("Are you sure? This might Delete the all information about the selected item", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            opr.deleteBook(info);
                            MessageBox.Show("Information Deleted successfully.", "Success", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("You Can not do this right now because this book is currently issued", "Alert", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }

                        bookidTF.Text = "";
                        booknameTF.Text = "";
                        authornameTF.Text = "";
                        publicationyearTF.Text = "";
                        quantityTF.Text = "";
                        this.viewBookPic.Image = null;

                        dgvUpdate();
                    }
                    else { }
                }
                else 
                {
                    MessageBox.Show("opps! Nothing is selected","Error",MessageBoxButtons.OK);
                }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            bookidTF.Text = "";
            booknameTF.Text = "";
            authornameTF.Text = "";
            publicationyearTF.Text = "";
            quantityTF.Text = "";
            this.viewBookPic.Image = null;
        }

        private void ViewBook_Paint(object sender, PaintEventArgs e)
        {
            //txtSearch.Text = "";
        }

        private void authornameTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void booknameTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
    }       
}

