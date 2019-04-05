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
using System.IO;

namespace Login
{
    public partial class StudentPanel : Form
    {
        ViewBook vb = new ViewBook();
        Details d = new Details();
        BorrowInfo bi = new BorrowInfo();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N1PTAGF;Initial Catalog=Library_management_System;Integrated Security=True;Pooling=False");
        public StudentPanel(string txtUsername, string txtPassword)
        {
            InitializeComponent();
            fetchLabel.Text = txtUsername;
            fetchPassword.Text = txtPassword;
        }

        private void menuBar_Click(object sender, EventArgs e)
        {
             if (panelMenu.Width == 57)
            {
                //Expand the panel;
                panelMenu.Visible = false;
                panelMenu.Width = 221;
                panelAnimator.ShowSync(panelMenu);

                // expand and enable button

                viewBook.Enabled = true;
               
                logOut.Enabled = true;
                brwInfo.Enabled = true;
                myInformation.Enabled = true;
                cngPassword.Enabled = true;



            }
            else
            {
                //Minimize;
                viewBook.Enabled = false;
                brwInfo.Enabled = false;
                logOut.Enabled = false;
                
                myInformation.Enabled = false;
                cngPassword.Enabled = false;

                panelMenu.Visible = false;
                panelMenu.Width = 57;
                panelAnimator.ShowSync(panelMenu);
            }
        
        }

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewBook_Click(object sender, EventArgs e)
        {
            vb.Hide();
            bi.Hide();
        }

        private void viewBook_DoubleClick(object sender, EventArgs e)
        {
            panelControl.Controls.Add(vb);
            vb.BringToFront();
            //panelControl.Controls.Remove(vb);
            vb.btnBrowse.Visible = false;
            vb.btnDelete.Visible = false;
            vb.btnUpdate.Visible = false;
            vb.booknameTF.ReadOnly = true;
            vb.authornameTF.ReadOnly = true;
            vb.publicationyearTF.ReadOnly = true;
            vb.quantityTF.ReadOnly = true;
            vb.Show();
        }

        private void myInformation_Click(object sender, EventArgs e)
        {
            vb.Hide();
            bi.Hide();
        }

        private void myInformation_DoubleClick(object sender, EventArgs e)
        {
            panelControl.Controls.Add(d);
            d.BringToFront();
            d.Show();
            bi.Hide();
            d.salaryTF.Visible = false;
            d.salaryLabel.Visible = false;

            
            con.Open();
            string query = "select * from student where studentId = '" + fetchLabel.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                d.fullnameTF.Text = (sdr["studentName"].ToString());
                d.genderTF.Text = (sdr["studentGender"].ToString());
                d.dobTF.Text = (sdr["studentDOB"].ToString());
                d.addressTF.Text = (sdr["studentAddress"].ToString());
                d.emailTF.Text = (sdr["studentEmail"].ToString());
                d.phoneTF2.Text = (sdr["studentPhone"].ToString());
               // d.salaryTF.Text = (sdr["librarianSalary"].ToString());


                byte[] pic = (byte[])sdr["studentImage"];
                MemoryStream ms = new MemoryStream(pic);
                ms.Seek(0, SeekOrigin.Begin);
                d.uploadLibrarianPic.Image = Image.FromStream(ms);


            }
            con.Close();
        }

        private void cngPassword_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(fetchLabel.Text, fetchPassword.Text);
            cp.Hide();
            
            vb.Hide();
            bi.Hide();
        }

        private void cngPassword_DoubleClick(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword(fetchLabel.Text, fetchPassword.Text);
            cp.Show();

            bi.Hide();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Hide();
        }

        private void brwInfo_Click(object sender, EventArgs e)
        {
            vb.Hide();
            d.Hide();
            bi.Hide();
        }

        private void brwInfo_DoubleClick(object sender, EventArgs e)
        {
            panelControl.Controls.Add(bi);
            bi.BringToFront();
            bi.Show();

             con.Open();
            string query = "select * from borrowInfo where studentId = '" + fetchLabel.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                bi.brwTF.Text = (sdr["borrowId"].ToString());
                bi.bookidTF.Text = (sdr["bookId"].ToString());
                bi.brwDateTF.Text = (sdr["borrowDate"].ToString());
                bi.rtnDateTF.Text = (sdr["returnDate"].ToString());
                /*d.addressTF.Text = (sdr["studentAddress"].ToString());
                d.emailTF.Text = (sdr["studentEmail"].ToString());
                d.phoneTF2.Text = (sdr["studentPhone"].ToString());*/
                // d.salaryTF.Text = (sdr["librarianSalary"].ToString());
                
            }
            con.Close();
            con.Open();
            string query1 = "select * from books where bookId = '" + bi.bookidTF.Text + "'";
            SqlCommand cmdd = new SqlCommand(query1, con);
            SqlDataReader sd = cmdd.ExecuteReader();
            if (sd.Read())
            {
                bi.bookTF.Text = (sd["bookName"].ToString());
                bi.authorTF.Text = (sd["authorName"].ToString());

            }
            con.Close();

        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {
            showCount_Books();
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
    }
}
