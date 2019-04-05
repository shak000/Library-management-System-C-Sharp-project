using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using BAL;
using BEL;

namespace Login
{
    public partial class AdminPanel : Form
    {
        public Information info = new Information();
        public Operations opr = new Operations();

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N1PTAGF;Initial Catalog=Library_management_System;Integrated Security=True;Pooling=False");

        // create all object.
        ManageBook mb = new ManageBook();
        ViewBook vb = new ViewBook();
        ManageLibrarian ml = new ManageLibrarian();
        ManageStudent ms = new ManageStudent();
        ReturnBook rb = new ReturnBook();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
         private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect, // x-coordinate of upper-left corner
             int nTopRect, // y-coordinate of upper-left corner
             int nRightRect, // x-coordinate of lower-right corner
             int nBottomRect, // y-coordinate of lower-right corner
             int nWidthEllipse, // height of ellipse
             int nHeightEllipse // width of ellipse
          );
        public AdminPanel(string txtUsername)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; 
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            labelUsername.Text = txtUsername;
            showCount_Books();
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
                manageLibrarian.Enabled = true;
                manageStudent.Enabled = true;
                issuedBook.Enabled = true;
                logOut.Enabled = true;
                
               
            }
            else
            {
                //Minimize;
                manageBook.Enabled = false;
                manageLibrarian.Enabled = false;
                manageStudent.Enabled = false;
                issuedBook.Enabled = false;
                logOut.Enabled = false;

                panelMenu.Visible = false;
                panelMenu.Width = 60;
                panelAnimator.ShowSync(panelMenu);
            }
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {
            showCount_Books();
            showCount_Librarian();
            showCount_Student();
            showCount_Issue();
        }


        //counting books and showing in dashboard
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

        public void showCount_Librarian()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM librarian", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                labelLibrarianCount.Text = Convert.ToString(count.ToString());
            }
            else
            {
                labelLibrarianCount.Text = "0";
 
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


        // Show Control manage book.
        private void manageBook_Click(object sender, EventArgs e)
        {
            //this.Parent.Controls.Remove(this);
            mb.Hide();
            vb.Hide();
            ml.Hide();
            panelControl.Show();
           // this.mb.Visible = false;
            mb.SendToBack();
            ms.Hide();
            
        }

       

        private void manageBook_DoubleClick(object sender, EventArgs e)
        {
            
            panelControl.Controls.Add(mb);
            mb.BringToFront();
            panelControl.Controls.Remove(vb);
            mb.Show();
            clearField();
        }

        private void manageLibrarian_DoubleClick(object sender, EventArgs e)
        {
            panelControl.Controls.Add(ml);
            ml.BringToFront();
            ml.Show();
            ml.btnGenerate.Enabled = true;
            ms.btnGenerate.Enabled = true;
            clearField();
        }

        private void manageLibrarian_Click(object sender, EventArgs e)
        {
            panelControl.Show();
            mb.SendToBack();
            mb.Hide();
            vb.Hide();
            ml.Hide();
            ms.Hide();
        }
        public void clearField()
        {
            //clear field Librarian
            ml.librarianidTF2.Text = "";
            ml.passwordTF.Text = "";
            ml.fullnameTF.Text = "";
            ml.genderBox.Text = "";
            ml.datepickTF.Text = "";
            ml.addressTF.Text = "";
            ml.emailTF.Text = "";
            ml.phoneTF2.Text = "";
            ml.salaryTF.Text = "";
            ml.uploadLibrarianPic.Image = null;

            //clear Field book
            mb.bookidTF2.Text = "";
            mb.booknameTF.Text = "";
            mb.authornameTF.Text = "";
            mb.yearComboBox.Text = "";
            mb.quantityTF.Text = "";
            mb.uploadBookPic.Image = null;

            //clear field Student
            ms.studentidTF2.Text = "";
            ms.passwordTF.Text = "";
            ms.fullnameTF.Text = "";
            ms.genderBox.Text = "";
            ms.datepickTF.Text = "";
            ms.addressTF.Text = "";
            ms.emailTF.Text = "";
            ms.phoneTF2.Text = "";
            ms.uploadStudentPic.Image = null;
 
        }

        private void manageStudent_Click(object sender, EventArgs e)
        {
            panelControl.Show();
            mb.SendToBack();
            mb.Hide();
            vb.Hide();
            ml.Hide();
            ms.Hide();
        }

        private void manageStudent_DoubleClick(object sender, EventArgs e)
        {
            panelControl.Controls.Add(ms);
            ms.BringToFront();
            ms.Show();
            ms.btnGenerate.Enabled = true;
            clearField();
        }

        private void issuedBook_Click(object sender, EventArgs e)
        {
            panelControl.Show();
            mb.SendToBack();
            mb.Hide();
            vb.Hide();
            ml.Hide();
            ms.Hide();
            rb.Hide();
        }

        private void issuedBook_DoubleClick(object sender, EventArgs e)
        {
            panelControl.Controls.Add(rb);
            rb.BringToFront();
            rb.Show();
            //rb.btnLoad.Visible = false;
            rb.btnReturn.Visible = false;
            rb.btnCancel.Visible = false;
            rb.returnLabel.Text = "Issued Book";
            rb.oDateTF.Visible = false;
            rb.rtnDate.Visible = false;
           // rb.brwidTF2.ReadOnly = true;
            ms.btnGenerate.Enabled = true;
            
            clearField();
        }
    }
}
