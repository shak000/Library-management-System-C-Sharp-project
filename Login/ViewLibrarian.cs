using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;
using System.Data.SqlClient;
using System.IO;

namespace Login
{
    public partial class ViewLibrarian : UserControl
    {
        public Information info = new Information ();
        public Operations opr = new Operations ();

        

        string imgLocation = "";

        public ViewLibrarian()
        {
            InitializeComponent();
            librarianidTF2.Enabled = false;

        }

        private void ViewLibrarian_Load(object sender, EventArgs e)
        {
            dgvUpdate();
            
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search by Librarian Name or Librarian Id"))
            {
                txtSearch.Text = "";

            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                txtSearch.Text = @"Search by Librarian Name or Librarian Id";

            }
        }

        // update the shown dataTable always.
        public void dgvUpdate()
        {
            DataTable dt = new DataTable();
            dt = opr.ViewLibrarian(info);
            dgbLibrarian.DataSource = dt;
        }

        private void panelDgb_Paint(object sender, PaintEventArgs e)
        {
            dgvUpdate();

            // Edit the column name.
            dgbLibrarian.Columns[0].HeaderCell.Value = "Librarian Id";
            dgbLibrarian.Columns[1].HeaderCell.Value = "Librarian Name";
            dgbLibrarian.Columns[2].HeaderCell.Value = "Gender";
            dgbLibrarian.Columns[3].HeaderCell.Value = "Date of Birth";
            dgbLibrarian.Columns[4].HeaderCell.Value = "Address";
            dgbLibrarian.Columns[5].HeaderCell.Value = "Email";
            dgbLibrarian.Columns[6].HeaderCell.Value = "Phone";
            dgbLibrarian.Columns[7].HeaderCell.Value = "Salary";
            dgbLibrarian.Columns[8].HeaderCell.Value = "Image";

            cleanField();

        }

        //clear field 
        public void cleanField()
        {
            librarianidTF2.Text = "";
            fullnameTF.Text = "";
            genderTF.Text = "";
            dobTF.Text = "";
            addressTF.Text = "";
            emailTF.Text = "";
            phoneTF.Text = "";
            salaryTF.Text = "";
            this.uploadLibrarianPic.Image = null;
        }

        //search by name or id
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-N1PTAGF;Initial Catalog=Library_management_System;Integrated Security=True;Pooling=False");
            con.Open();
            string query = "select * from librarian where librarianName like '%" + txtSearch.Text + "%'or librarianId like '%" + txtSearch.Text + "%'" ;
            
            SqlCommand cmd = new SqlCommand(query, con);
            
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            dgbLibrarian.DataSource = dt;
           // SqlConnection con = new SqlConnection("Data Source=DESKTOP-N1PTAGF;Initial Catalog=Library_management_System;Integrated Security=True;Pooling=False");
            //con.Open();
           /* string query1 = "select * from librarian where librarianId like '%" + txtSearch.Text + "%'";
            SqlCommand cmdd = new SqlCommand(query1, con);
            SqlDataAdapter sdaa = new SqlDataAdapter(cmdd);
            //DataTable dt = new DataTable();
            //sdaa.Fill(dt);
            dgbLibrarian.DataSource = dt;*/
           // con.Close();

            //search();
            con.Close();

           
        }

        //again search
       /* public void search()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-N1PTAGF;Initial Catalog=Library_management_System;Integrated Security=True;Pooling=False");
            con.Open();
            string query1 = "select * from librarian where librarianId like '%" + txtSearch.Text + "%'";
            SqlCommand cmdd = new SqlCommand(query1, con);
            SqlDataAdapter sdaa = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            sdaa.Fill(dt);
            dgbLibrarian.DataSource = dt;
            con.Close();

        }*/

        private void dgbLibrarian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgbLibrarian.Rows[e.RowIndex];
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)dgbLibrarian.Columns[8];

                librarianidTF2.Text = row.Cells["librarianId"].Value.ToString();
                fullnameTF.Text = row.Cells["librarianName"].Value.ToString();
                genderTF.Text = row.Cells["librarianGender"].Value.ToString();
                dobTF.Text = row.Cells["librarianDOB"].Value.ToString();
                addressTF.Text = row.Cells["librarianAddress"].Value.ToString();
                emailTF.Text = row.Cells["librarianEmail"].Value.ToString();
                phoneTF.Text = row.Cells["librarianPhone"].Value.ToString();
                salaryTF.Text = row.Cells["librarianSalary"].Value.ToString();

                //Retriving the images from data Grid View.
                var data = (Byte[])(row.Cells["librarianImage"].Value);
                var stream = new MemoryStream(data);
                uploadLibrarianPic.Image = Image.FromStream(stream);
            }
            else { }
        }

        //image processing
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                uploadLibrarianPic.ImageLocation = imgLocation;
            }

            updateImage();
        }

        //image update 
        public void updateImage()
        {
            try
            {
                byte[] uploadLibrarianPic = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                uploadLibrarianPic = br.ReadBytes((int)fs.Length);
                info.librarianImage = uploadLibrarianPic;
                info.librarianId = librarianidTF2.Text;

                opr.updateLibrarianPictures(info);
            }
            catch (Exception ex)
            {}
            // update grid view
            dgvUpdate();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(fullnameTF.Text, out result) || int.TryParse(addressTF.Text, out result) || int.TryParse(emailTF.Text, out result))
            {
                MessageBox.Show("Enter Valid Name or Address.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else 
            {
                // field empty check
                if (fullnameTF.Text.Length == 0 || genderTF.Text.Length == 0 || dobTF.Text.Length == 0 || addressTF.Text.Length == 0 || emailTF.Text.Length == 0 || phoneTF.Text.Length == 0 || salaryTF.Text.Length == 0)
                {
                    MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (phoneTF.Text.Length > 13 || phoneTF.Text.Length < 13)
                    {
                        MessageBox.Show("Enter Valid Mobile number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    else
                    {
                        try
                        {
                            info.librarianId = librarianidTF2.Text;

                            info.librarianName = fullnameTF.Text;
                            info.librarianGender = genderTF.Text;
                            info.librarianDOB = dobTF.Text;
                            info.librarianAddress = addressTF.Text;
                            info.librarianEmail = emailTF.Text;
                            info.librarianPhone = Convert.ToInt64(phoneTF.Text);
                            info.librarianSalary = Convert.ToDouble(salaryTF.Text);

                            opr.updateLibrarian(info);
                            

                            MessageBox.Show("Information Updated successfully.", "Success", MessageBoxButtons.OK);
                            // update grid view
                            dgvUpdate();

                            cleanField();
                        }
                        catch ( Exception ex)
                        {
                            
                            MessageBox.Show("opps!","Error",MessageBoxButtons.OK);
                        }
                    }
                }
            }
            dgvUpdate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (librarianidTF2.Text.Length != 0)
            {
                info.librarianId = librarianidTF2.Text;
                DialogResult dr = MessageBox.Show("Are you sure? This might Delete the all information about the selected Librarian", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    opr.deleteLibrarian(info);
                    opr.deleteFromLogin(info);
                    MessageBox.Show("Information Deleted successfully.", "Success", MessageBoxButtons.OK);
                    cleanField();
                    dgvUpdate();
                }
                else { }
            }
            else 
            {
                MessageBox.Show("opps! Nothing is selected", "Error", MessageBoxButtons.OK);
            }
            dgvUpdate();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanField();
        }

        private void ViewLibrarian_Paint(object sender, PaintEventArgs e)
        {
            //txtSearch.Text = "";
        }

        private void fullnameTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void genderTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void dobTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }
    }
}
