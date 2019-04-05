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

namespace Login
{
    public partial class ReturnBook : UserControl
    {
        Information info = new Information();
        Operations opr = new Operations();
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void brwidTF2_Enter(object sender, EventArgs e)
        {
            if (brwidTF2.Text.Equals("Enter Borrow Id"))
            {
                brwidTF2.Text = "";

            }
        }

        private void brwidTF2_Leave(object sender, EventArgs e)
        {
            if (brwidTF2.Text.Equals(""))
            {
                brwidTF2.Text = @"Enter Borrow Id";

            }

        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            dgvUpdate();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-N1PTAGF;Initial Catalog=Library_management_System;Integrated Security=True;Pooling=False");
            string query = "select * from borrowInfo where borrowId = '" + brwidTF1.Text + brwidTF2.Text + "'";
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
                    stdTF.Text = dr["studentId"].ToString();
                    bookidTF.Text = dr["bookId"].ToString();

                    brwTF.Text = dr["borrowDate"].ToString();
                    rtnTF.Text = dr["returnDate"].ToString();
                   /* emailTF.Text = dr["studentEmail"].ToString();
                    phoneTF2.Text = dr["studentPhone"].ToString();*/

                    brwidTF2.Enabled = false;
                    bookidTF.Enabled = false;
                    brwTF.Enabled = false;
                    rtnTF.Enabled = false;
                }
            }
        }

        private void panelDgb_Paint(object sender, PaintEventArgs e)
        {
            dgvUpdate();

            // Edit the column name.
            dgbBorrow.Columns[0].HeaderCell.Value = "Borrow Id";
            dgbBorrow.Columns[1].HeaderCell.Value = "Student Id";
            dgbBorrow.Columns[2].HeaderCell.Value = "Book Id";
            dgbBorrow.Columns[3].HeaderCell.Value = "Borrow Date";
            dgbBorrow.Columns[4].HeaderCell.Value = "Return Date";
            

           /* bookidTF.Text = "";
            booknameTF.Text = "";
            authornameTF.Text = "";
            publicationyearTF.Text = "";
            quantityTF.Text = "";
            this.viewBookPic.Image = null;*/
        }
        public void dgvUpdate()
        {
            DataTable dt = new DataTable();
            dt = opr.ViewBorrow(info);
            dgbBorrow.DataSource = dt;
        }

        private void dgbBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgbBorrow.Rows[e.RowIndex];
               

                brwidTF2.Text = row.Cells["borrowId"].Value.ToString().Substring(3);
                stdTF.Text = row.Cells["studentId"].Value.ToString();
                bookidTF.Text = row.Cells["bookId"].Value.ToString();
                brwTF.Text = row.Cells["borrowDate"].Value.ToString();
                rtnTF.Text = row.Cells["returnDate"].Value.ToString();

                
            }
            else { }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            info.borrowId = brwidTF1.Text + brwidTF2.Text;
            info.studentId = stdTF.Text;
            info.bookId = bookidTF.Text;
            info.borrowDate = brwTF.Text;
            info.returnDate = rtnTF.Text;
            info.qty = 1;

            info.orginalReturnDate = oDateTF.Text;
            if (brwidTF2.Text.Length == 0)
            {
                MessageBox.Show("Enter Borrow Id ", "Alert", MessageBoxButtons.OK);

            }
            else
            {
                try
                {
                    opr.deleteFromBorrowInfo(info);
                    opr.updateBookReturn(info);
                    DateTime sdt = brwTF.Value.Date;
                    DateTime edt = oDateTF.Value.Date;

                    TimeSpan ts = edt - sdt;
                    int days = ts.Days;
                    //label1.Text = days.ToString() + "days";
                    double fine = 0;

                    if (days <= 7)
                    {
                        fine = 0;
                        MessageBox.Show("Timely Returned Fees = '" + fine + "'", "Success", MessageBoxButtons.OK);
                    }
                    else if (days > 7 && days <= 10)
                    {
                        fine = (days - 7) * 10;
                        MessageBox.Show("Returned After '" + days + "' days. Fees = '" + fine + "' Tk", "Success", MessageBoxButtons.OK);
                        info.fees = fine;
                        opr.InsertintoFees(info);

                    }
                    else if (days > 10 && days <= 30)
                    {
                        fine = 3 * 10 + (days - 10) * 15;
                        MessageBox.Show("Returned After '" + days + "' days. Fees = '" + fine + "' Tk", "Success", MessageBoxButtons.OK);
                        info.fees = fine;
                        opr.InsertintoFees(info);
                    }
                    else
                    {
                        fine = 3 * 10 + 20 * 15 + 20;
                        MessageBox.Show("Returned After '" + days + "' days. Fees = '" + fine + "' Tk, Your MemberShip Cancel Please Contact Librarian ", "Success", MessageBoxButtons.OK);
                        info.fees = fine;
                        opr.InsertintoFees(info);
                        opr.updateLogin(info);
                    }

                   // MessageBox.Show("Book Return Successfully !", "Success", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong ", "Alert", MessageBoxButtons.OK);
                }
            }

           
            clean();
            dgvUpdate();
        }

        public void clean()
        {
            brwidTF2.Text = "";
            stdTF.Text = "";
            bookidTF.Text = "";
            brwTF.Text = "";
            rtnTF.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

    }
}
