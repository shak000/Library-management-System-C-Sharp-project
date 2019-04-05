using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using BAL;
using BEL;

namespace Login
{
    
    public partial class ViewStudent : UserControl
    {
        public Information info = new Information();
        public Operations opr = new Operations();

        string imgLocation = "";

        public ViewStudent()
        {
            InitializeComponent();
            studentIdTF2.Enabled = false;
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            dgvUpdate();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search by Student Name or Student Id"))
            {
                txtSearch.Text = "";

            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                txtSearch.Text = @"Search by Student Name or Student Id";

            }
        }

        // update the shown dataTable always.
        public void dgvUpdate()
        {
            DataTable dt = new DataTable();
            dt = opr.ViewStudent(info); //need to change.
            dgbStudent.DataSource = dt;
        }

        private void panelDgb_Paint(object sender, PaintEventArgs e)
        {
            dgvUpdate();

            // Edit the column name.
            dgbStudent.Columns[0].HeaderCell.Value = "Student Id";
            dgbStudent.Columns[1].HeaderCell.Value = "Student Name";
            dgbStudent.Columns[2].HeaderCell.Value = "Gender";
            dgbStudent.Columns[3].HeaderCell.Value = "Date of Birth";
            dgbStudent.Columns[4].HeaderCell.Value = "Address";
            dgbStudent.Columns[5].HeaderCell.Value = "Email";
            dgbStudent.Columns[6].HeaderCell.Value = "Phone";
            dgbStudent.Columns[7].HeaderCell.Value = "Image";
            clean();
        }
        //clear field 
        public void clean()
        {
            studentIdTF2.Text = "";
            fullnameTF.Text = "";
            genderTF.Text = "";
            dobTF.Text = "";
            addressTF.Text = "";
            emailTF.Text = "";
            phoneTF.Text = "";
            this.uploadStudentPic.Image = null;
        }

        //search by name or id
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-N1PTAGF;Initial Catalog=Library_management_System;Integrated Security=True;Pooling=False");
            con.Open();
            string query = "select * from student where studentName like '%" + txtSearch.Text + "%' or studentId like '%" + txtSearch.Text + "%'";
            
            SqlCommand cmd = new SqlCommand(query, con);
            
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            dgbStudent.DataSource = dt;


            con.Close();
           // search();
        }
        // again search id
       /* public void search()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-N1PTAGF;Initial Catalog=Library_management_System;Integrated Security=True;Pooling=False");
            con.Open();
            string query1 = "select * from student where studentId like '%" + txtSearch.Text + "%'";
            SqlCommand cmdd = new SqlCommand(query1, con);
            SqlDataAdapter sdaa = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            sdaa.Fill(dt);
            dgbStudent.DataSource = dt;
            con.Close();
 
        }*/

        private void dgbStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgbStudent.Rows[e.RowIndex];
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)dgbStudent.Columns[7];

                studentIdTF2.Text = row.Cells["studentId"].Value.ToString();
                fullnameTF.Text = row.Cells["studentName"].Value.ToString();
                genderTF.Text = row.Cells["studentGender"].Value.ToString();
                dobTF.Text = row.Cells["studentDOB"].Value.ToString();
                addressTF.Text = row.Cells["studentAddress"].Value.ToString();
                emailTF.Text = row.Cells["studentEmail"].Value.ToString();
                phoneTF.Text = row.Cells["studentPhone"].Value.ToString();
                

                //Retriving the images from data Grid View.
                var data = (Byte[])(row.Cells["studentImage"].Value);
                var stream = new MemoryStream(data);
                uploadStudentPic.Image = Image.FromStream(stream);
            }
            else { }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                uploadStudentPic.ImageLocation = imgLocation;
            }
            updateImage();
        }

        //image update 
        public void updateImage()
        {
            try
            {
                byte[] uploadStudentPic = null;
                FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                uploadStudentPic = br.ReadBytes((int)fs.Length);
                info.studentImage = uploadStudentPic;
                info.studentId = studentIdTF2.Text;

                opr.updateStudentPictures(info);
            }
            catch (Exception ex)
            {}
            // update grid view
            dgvUpdate();

        }
        // update info
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
                if (fullnameTF.Text.Length == 0 || genderTF.Text.Length == 0 || dobTF.Text.Length == 0 || addressTF.Text.Length == 0 || emailTF.Text.Length == 0 || phoneTF.Text.Length == 0)
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
                            info.studentId = studentIdTF2.Text;

                            info.studentName = fullnameTF.Text;
                            info.studentGender = genderTF.Text;
                            info.studentDOB = dobTF.Text;
                            info.studentAddress = addressTF.Text;
                            info.studentEmail = emailTF.Text;
                            info.studentPhone = Convert.ToInt64(phoneTF.Text);


                            opr.updateStudent(info);
                            

                            MessageBox.Show("Information Updated successfully.", "Success", MessageBoxButtons.OK);
                            // update grid view
                            dgvUpdate();

                            clean();
                        }
                        catch (Exception ex)
                        {
                            
                            MessageBox.Show("opps!","Error",MessageBoxButtons.OK);
                        }
                        
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentIdTF2.Text.Length != 0)
            {
                info.studentId = studentIdTF2.Text;
                DialogResult dr = MessageBox.Show("Are you sure? This might Delete the all information about the selected Librarian", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        opr.deleteStudent(info);
                        opr.deleteStudentLogin(info);
                        MessageBox.Show("Information Deleted successfully.", "Success", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("You Can not do this right now because this Student is currently borrowed book", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    
                    clean();
                    dgvUpdate();

                }
                else { }
            }
            else
            {
                MessageBox.Show("opps! Nothing is selected", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clean();
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
