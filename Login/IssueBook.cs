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
namespace Login
{
    public partial class IssueBook : Form
    {
        public Information info = new Information();
        public Operations opr = new Operations();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N1PTAGF;Initial Catalog=Library_management_System;Integrated Security=True;Pooling=False");
        public IssueBook()
        {
            InitializeComponent();
            feesTF.Text = "0.00";
        }

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void studentTxt_Enter(object sender, EventArgs e)
        {
            if (studentTxt.Text.Equals("Student Id"))
            {
                studentTxt.Text = "";

            }
        }

        private void studentTxt_Leave(object sender, EventArgs e)
        {
            if (studentTxt.Text.Equals(""))
            {
                studentTxt.Text = @"Student Id";

            }
        }

        private void bookTxt_Enter(object sender, EventArgs e)
        {
            if (bookTxt.Text.Equals("Book Id"))
            {
                bookTxt.Text = "";

            }
        }

        private void bookTxt_Leave(object sender, EventArgs e)
        {
            if (bookTxt.Text.Equals(""))
            {
                bookTxt.Text = @"Book Id";

            }
        }

        private void sbtnLoad_Click(object sender, EventArgs e)
        {
            string query = "select * from student where studentId = '" + studentTxt.Text + "'";
            string query1 = "select * from feesTable where studentId = '" + studentTxt.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmdd = new SqlCommand(query1, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlDataAdapter sdaa = new SqlDataAdapter(cmdd);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            sda.Fill(dt);
            sdaa.Fill(dt1);
            int i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("No Record Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    fullnameTF.Text = dr["studentName"].ToString();
                    genderTF.Text = dr["studentGender"].ToString();
                    dobTF.Text = dr["studentDOB"].ToString();
                    addressTF.Text = dr["studentAddress"].ToString();
                    emailTF.Text = dr["studentEmail"].ToString();
                    phoneTF2.Text = dr["studentPhone"].ToString();
                    

                    studentTxt.Enabled = false;
                }

            }
            int j = Convert.ToInt32(dt1.Rows.Count.ToString());
            if (j > 0)
            {
                foreach (DataRow dr1 in dt1.Rows)
                {
                    feesTF.Text = dr1["fees"].ToString();
                }
            }



        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void studentTxt_TextChanged(object sender, EventArgs e)
        {
            //clear();
        }

        public void clear()
        {
            fullnameTF.Text= "";
            genderTF.Text = "";
            dobTF.Text= "";
            addressTF.Text = "";
            emailTF.Text = "";
            phoneTF2.Text = "";
            bookTxt.Enabled = true;
            studentTxt.Enabled = true;
            bookTxt.Text = "";
            studentTxt.Text = "";
            booknameTF.Text = "";
            authornameTF.Text = "";
            publicationyearTF.Text = "";
            quantityTF.Text = "";
            brwTxt2.Text = "";
            feesTF.Text = "0.00";
 
        }

        private void bbtnLoad_Click(object sender, EventArgs e)
        {
            string query = "select * from books where bookId = '" + bookTxt.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("No Record Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    booknameTF.Text = dr["bookName"].ToString();
                    authornameTF.Text = dr["authorName"].ToString();
                    publicationyearTF.Text = dr["publicationYear"].ToString();
                    quantityTF.Text = dr["quantity"].ToString();

                    bookTxt.Enabled = false;
                }
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            
                info.borrowId = brwTxt1.Text + brwTxt2.Text;
                info.studentId = studentTxt.Text;
                info.bookId = bookTxt.Text;
                info.borrowDate = brwDate.Text;
                info.returnDate = rtnDate.Text;
                info.qty = 1;
                double x = Convert.ToDouble(feesTF.Text);
                

                try
                {
                    if (brwTxt2.Text.Length == 0 || bookTxt.Text.Length == 0 || studentTxt.Text.Length == 0)
                    {
                        MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (x > 0.00)
                    {
                        MessageBox.Show("Please pay the fees to Borrow book again", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
                    }

                    else
                    {
                        opr.insertIntoBorrowInfo(info);
                        opr.updateBookBorrow(info);
                        MessageBox.Show("Information Saved successfully.", "Success", MessageBoxButtons.OK);
                        clear();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
        }

    }
}
