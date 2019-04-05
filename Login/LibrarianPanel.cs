using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class LibrarianPanel : Form
    {
        public Information info = new Information();
        public Operations opr = new Operations();
        ManageBook mb = new ManageBook();
        ViewBook vb = new ViewBook();
        ManageStudent ms = new ManageStudent();
        ViewStudent vs = new ViewStudent();
        Details d = new Details();
        ReturnBook rb = new ReturnBook();
        ActiveInactive ai = new ActiveInactive();
        
      
        //FormLogin fl = new FormLogin();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N1PTAGF;Initial Catalog=Library_management_System;Integrated Security=True;Pooling=False");

        public LibrarianPanel(string txtUsername, string txtPassword)
        {
            InitializeComponent();
            //labelUsername.Text = txtUsername;
            fetchLabel.Text = txtUsername;
            fetchPassword.Text = txtPassword;
        }

        private void menuBar_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 60)
            {
                //Expand the panel;
                panelMenu.Visible = false;
                panelMenu.Width = 222;
                panelAnimator.ShowSync(panelMenu);

                // expand and enable button

                manageBook.Enabled = true;
                manageStudent.Enabled = true;
                issuedBook.Enabled = true;
                logOut.Enabled = true;
                returnBook.Enabled = true;
                myInformation.Enabled = true;
                btnActive.Enabled = true;
                cngPassword.Enabled = true;



            }
            else
            {
                //Minimize;
                manageBook.Enabled = false;
                manageStudent.Enabled = false;
                issuedBook.Enabled = false;
                logOut.Enabled = false;
                returnBook.Enabled = false;
                myInformation.Enabled = false;
                cngPassword.Enabled = false;
                btnActive.Enabled = false;
                panelMenu.Visible = false;
                panelMenu.Width = 60;
                panelAnimator.ShowSync(panelMenu);
            }
        }

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }

        private void manageBook_Click(object sender, EventArgs e)
        {
            //this.Parent.Controls.Remove(this);
            mb.Hide();
            vb.Hide();
           // ml.Hide();
            panelControl.Show();
            // this.mb.Visible = false;
            mb.SendToBack();
            //ms.Hide();
            
            d.Hide();
            rb.Hide();
            ai.Hide();
            rb.clean();
            
        }

        private void manageBook_DoubleClick(object sender, EventArgs e)
        {
            panelControl.Controls.Add(mb);
            mb.BringToFront();
            panelControl.Controls.Remove(vb);
            mb.Show();
            clearField();
        }
        public void clearField()
        {
           

            //clear Field book
            mb.bookidTF2.Text = "";
            mb.booknameTF.Text = "";
            mb.authornameTF.Text = "";
            mb.yearComboBox.Text = "";
            mb.quantityTF.Text = "";
            mb.uploadBookPic.Image = null;

            //clear field Student
           /* ms.studentidTF2.Text = "";
            ms.passwordTF.Text = "";
            ms.fullnameTF.Text = "";
            ms.genderBox.Text = "";
            ms.datepickTF.Text = "";
            ms.addressTF.Text = "";
            ms.emailTF.Text = "";
            ms.phoneTF2.Text = "";
            ms.uploadStudentPic.Image = null;*/

        }

        private void manageStudent_Click(object sender, EventArgs e)
        {
            panelControl.Show();
            mb.SendToBack();
            mb.Hide();
            vb.Hide();
            //ml.Hide();
            ms.Hide();
            
            d.Hide();
            rb.Hide();
            ai.Hide();
            rb.clean();
           
        }

        private void manageStudent_DoubleClick(object sender, EventArgs e)
        {
            panelControl.Controls.Add(ms);
            ms.BringToFront();
            ms.Show();
            ms.btnGenerate.Enabled = true;
            clearField();
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {
            showCount_Books();
            //showCount_Librarian();
            showCount_Student();
            showCount_Issue();
        }
        public void showCount_Books()
        {


            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT sum (quantity) FROM books", con);

            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                labelBooksCount.Text = Convert.ToString(count.ToString());
            }
            else
            {
                labelBooksCount.Text = "0";
            }
            con.Close();
        }
        public void showCount_Student()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM Student", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                labelStudentCount.Text = Convert.ToString(count.ToString());
            }
            else
            {
                labelStudentCount.Text = "0";

            }
            con.Close();

        }

        public void showCount_Issue()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM borrowInfo", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                label3.Text = Convert.ToString(count.ToString());
            }
            else
            {
                label3.Text = "0";

            }
            con.Close();

 
        }

        private void myInformation_Click(object sender, EventArgs e)
        {
            panelControl.Show();
            d.SendToBack();
            d.Hide();
            rb.Hide();
            ai.Hide();
            rb.clean();
        }

        private void myInformation_DoubleClick(object sender, EventArgs e)
        {
            panelControl.Controls.Add(d);
            d.BringToFront();
            d.Show();

            con.Open();
            string query = "select * from librarian where librarianId = '"+fetchLabel.Text+"'";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader sdr = cmd.ExecuteReader();
             
            if (sdr.Read())
            {
                d.fullnameTF.Text = (sdr["librarianName"].ToString());
                d.genderTF.Text = (sdr["librarianGender"].ToString());
                d.dobTF.Text = (sdr["librarianDOB"].ToString());
                d.addressTF.Text = (sdr["librarianAddress"].ToString());
                d.emailTF.Text = (sdr["librarianEmail"].ToString());
                d.phoneTF2.Text = (sdr["librarianPhone"].ToString());
                d.salaryTF.Text = (sdr["librarianSalary"].ToString());


                byte[] pic = (byte[])sdr["librarianImage"];
                MemoryStream ms = new MemoryStream(pic);
                ms.Seek(0,SeekOrigin.Begin);
                d.uploadLibrarianPic.Image = Image.FromStream(ms);
                

            }
            con.Close();
        }

        private void cngPassword_Click(object sender, EventArgs e)
        {
            panelControl.Show();
            d.SendToBack();
            d.Hide();
            mb.SendToBack();
            mb.Hide();
            vb.Hide();
            //ml.Hide();
            ms.Hide();
            ChangePassword cp = new ChangePassword(fetchLabel.Text, fetchPassword.Text);
            cp.Close();
            rb.Hide();
            ai.Hide();
            rb.clean();
            
        }

        private void cngPassword_DoubleClick(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(fetchLabel.Text,fetchPassword.Text);
            cp.Show();
           
        }

        private void issuedBook_Click(object sender, EventArgs e)
        {
            panelControl.Show();
            mb.SendToBack();
            mb.Hide();
            vb.Hide();
            //ml.Hide();
            ms.Hide();

            d.Hide();
            rb.Hide();
            ai.Hide();
            rb.clean();
        }

        private void issuedBook_DoubleClick(object sender, EventArgs e)
        {
            IssueBook ib = new IssueBook();
            ib.Show();
            
        }

        private void returnBook_Click(object sender, EventArgs e)
        {
            panelControl.Show();
            mb.SendToBack();
            mb.Hide();
            vb.Hide();
            //ml.Hide();
            ms.Hide();

            d.Hide();
            rb.Hide();
            ai.Hide();
            rb.clean();
        }

        private void returnBook_DoubleClick(object sender, EventArgs e)
        {
            panelControl.Controls.Add(rb);
            rb.BringToFront();
            rb.Show();
           // rb.brwDate.Visible = true;
           // rb.exrtnDate.Visible = true;
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            panelControl.Show();
            mb.SendToBack();
            mb.Hide();
            vb.Hide();
            //ml.Hide();
            ms.Hide();
            ai.Hide();
            d.Hide();
            rb.Hide();
            rb.clean();
            
        }

        private void btnActive_DoubleClick(object sender, EventArgs e)
        {
            panelControl.Controls.Add(ai);
            ai.BringToFront();
            ai.Show();
        }
    }
}
