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
    public partial class FormLogin : Form
    {
        public Information info = new Information();
        public Operations opr = new Operations();
        int status;

        DataTable dt = new DataTable();
        
       // int count = 0;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N1PTAGF;Initial Catalog=Library_management_System;Integrated Security=True;Pooling=False");
        public FormLogin()
        {
            InitializeComponent();

        }

      

        private Point PointToClient()
        {
            throw new NotImplementedException();
        }


        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Username"))
            {
                txtUsername.Text = "";

            }
        }

        private void txtUesrLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"Username";

            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(@"Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = @"Password";
            }

        }

       

        private void FormLogin_Load(object sender, EventArgs e)
        {
           /* if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();*/
        }

        public void checkLogin()
        {

               /* string query = "select * from login where userId = '" + txtUsername.Text + "'and password = '" + txtPassword.Text + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.Fill(dt);
           

                count = Convert.ToInt32(dt.Rows.Count.ToString());
               

                    if (count == 0)
                    {
                        MessageBox.Show("username and password does not match.");
                        txtUsername.Text = @"Username";
                        txtPassword.Text = @"Password";
                       
                    }
                    else
                    {
                        //MessageBox.Show("Successfully logged in.");
                        AdminPanel ap = new AdminPanel(txtUsername.Text);
                        this.Hide();
                        ap.Show();

                    }   */                 
        }

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            info.userId = txtUsername.Text;
            info.password = txtPassword.Text;

            dt = opr.FormLogin(info);

            if (dt.Rows.Count > 0)
            {
                status = Convert.ToInt32(dt.Rows[0][2].ToString());
                if (status == 0)
                {
                AdminPanel ap = new AdminPanel(txtUsername.Text);
                this.Hide();
                ap.Show();
                }
                else if (status == 1)
                {
                    LibrarianPanel lp = new LibrarianPanel(txtUsername.Text,txtPassword.Text);
                    this.Hide();
                    lp.Show();

                    con.Open();
                    string query = "select * from librarian where librarianId = '" + txtUsername.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        lp.labelUsername.Text = (sdr["librarianName"].ToString());
                        byte[] pic = (byte[])sdr["librarianImage"];
                        MemoryStream ms = new MemoryStream(pic);
                        ms.Seek(0, SeekOrigin.Begin);
                        
                        lp.pictureBoxAdmin.Image = Image.FromStream(ms);
                        
                    }
                    con.Close();
                }
                else if (status == 2)
                {
                    StudentPanel sp = new StudentPanel(txtUsername.Text, txtPassword.Text);
                    sp.Show();
                    this.Hide();

                    con.Open();
                    string query1 = "select * from student where studentId = '" + txtUsername.Text + "'";
                    SqlCommand cmdd = new SqlCommand(query1, con);
                    SqlDataReader sd = cmdd.ExecuteReader();
                    if (sd.Read())
                    {
                        sp.labelUsername.Text = (sd["studentName"].ToString());
                        byte[] pic = (byte[])sd["studentImage"];
                        MemoryStream ms = new MemoryStream(pic);
                        ms.Seek(0, SeekOrigin.Begin);

                        sp.pictureBoxAdmin.Image = Image.FromStream(ms);

                    }
                    con.Close();
                }
                else if (status == 3)
                {
                    MessageBox.Show("oops! You are Currently Inactive For Access Please Contact Librarian", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     txtUsername.Text = @"Username";
                    txtPassword.Text = @"Password";

                }
            }
           
            else
            {
                MessageBox.Show("username and password does not match.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = @"Username";
                txtPassword.Text = @"Password";
            }
        }

        
    }
}
