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
using BAL;
using BEL;

namespace Login
{
    public partial class ManageLibrarian : UserControl
    {
        //create object 
        
        public Information info = new Information();
        public Operations opr = new Operations();
        ViewLibrarian vl = new ViewLibrarian();

        //for locating image
        string imgLocation = "";

        public ManageLibrarian()
        {
            InitializeComponent();
        }

        private void addLabel_Click(object sender, EventArgs e)
        {
            separatorAdd.Width = addLabel.Width;
            separatorAdd.Left = addLabel.Left;
            vl.Hide();
        }

        private void viewLabel_Click(object sender, EventArgs e)
        {
            separatorAdd.Width = viewLabel.Width;
            separatorAdd.Left = viewLabel.Left;

            panelDetails.Controls.Add(vl);
            vl.Show();
            vl.BringToFront();
            //back to empty.
            librarianidTF2.Text = "";
            passwordTF.Text = "";
            fullnameTF.Text = "";
            genderBox.Text = "";
            datepickTF.Text = "";
            addressTF.Text = "";
            emailTF.Text = "";
            phoneTF2.Text = "";
            salaryTF.Text = "";
            this.uploadLibrarianPic.Image = null;
            btnGenerate.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            vl.Hide();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgLocation = ofd.FileName.ToString();
                uploadLibrarianPic.ImageLocation = imgLocation;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            passwordTF.Text = (rnd.Next(89999999) + 10000000 + "");
            btnGenerate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Declaring the picture box in byte type.
            byte[] uploadLibrarianpic = null;

            // check for input integer value.
            int result = 0;
            if (int.TryParse(fullnameTF.Text, out result) || int.TryParse(addressTF.Text, out result) || int.TryParse(emailTF.Text, out result))
            {
                MessageBox.Show("Enter Valid Name.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else 
            {
                
                    int rlt = 0;

                    // field empty check
                    if (librarianidTF2.Text.Length == 0 || passwordTF.Text.Length == 0 || fullnameTF.Text.Length == 0 || genderBox.Text.Length == 0 || datepickTF.Text.Length == 0 || addressTF.Text.Length == 0 || emailTF.Text.Length == 0 || phoneTF2.Text.Length == 0 || salaryTF.Text.Length == 0 || uploadLibrarianPic.Image == null)
                    {
                        MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Insert into librarian.
                    else
                    {
                        // converting img in binary value.
                        FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        uploadLibrarianpic = br.ReadBytes((int)fs.Length);

                        //BAL and BEL Layer execution.

                        if (phoneTF2.Text.Length > 10 || phoneTF2.Text.Length < 10)
                        {
                            MessageBox.Show("Enter Valid Mobile number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else if (int.TryParse(phoneTF2.Text, out rlt))
                        {
                            info.librarianId = librarianidTF.Text + librarianidTF2.Text;
                            info.password = passwordTF.Text;
                            info.librarianName = fullnameTF.Text;
                            info.librarianGender = genderBox.Text;
                            info.librarianDOB = datepickTF.Text;
                            info.librarianAddress = addressTF.Text;
                            info.librarianEmail = emailTF.Text;
                            info.librarianPhone = Convert.ToInt64(phoneTF.Text + phoneTF2.Text);
                            info.librarianSalary = Convert.ToDouble(salaryTF.Text);
                            info.librarianImage = uploadLibrarianpic;
                            info.stat = 1;

                            try
                            {
                                opr.inserLibrarian(info);
                                opr.insertIntoLogin(info);

                                MessageBox.Show("Information Saved successfully.", "Success", MessageBoxButtons.OK);
                            }
                            catch (Exception ex)
                            {
                                
                                MessageBox.Show("Already exist user.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            // clear field
                            clearField();
                        }
                        else
                        {
                            MessageBox.Show("Enter Valid Mobile number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
            }
        }

        //clear field
        public void clearField()
        {
            librarianidTF2.Text = "";
            passwordTF.Text = "";
            fullnameTF.Text = "";
            genderBox.Text = "";
            datepickTF.Text = "";
            addressTF.Text = "";
            emailTF.Text = "";
            phoneTF2.Text = "";
            salaryTF.Text = "";
            btnGenerate.Enabled = true;
            uploadLibrarianPic.Image = null;
 
        }

        private void ManageLibrarian_Load(object sender, EventArgs e)
        {
            clearField();
        }

        private void fullnameTF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 8) || (e.KeyChar == 32))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        
    }
}
