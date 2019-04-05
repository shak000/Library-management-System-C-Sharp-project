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
    public partial class ManageStudent : UserControl
    {
        public Information info = new Information();
        public Operations opr = new Operations();
        ViewStudent vs = new ViewStudent();

        string imgLocation = "";
        

        public ManageStudent()
        {
            InitializeComponent();
        }

        private void addLabel_Click(object sender, EventArgs e)
        {
            separatorAdd.Width = addLabel.Width;
            separatorAdd.Left = addLabel.Left;
            vs.Hide();
            clearStudentField();
            btnGenerate.Enabled = true;

        }

        private void viewLabel_Click(object sender, EventArgs e)
        {
            separatorAdd.Width = viewLabel.Width;
            separatorAdd.Left = viewLabel.Left;

            panelDetails.Controls.Add(vs);
            vs.Show();
            vs.BringToFront();
            clearStudentField();
        }
        // clear Field
        public void clearStudentField()
        {
            studentidTF2.Text = "";
            passwordTF.Text = "";
            fullnameTF.Text = "";
            genderBox.Text = "";
            datepickTF.Text = "";
            addressTF.Text = "";
            emailTF.Text = "";
            phoneTF2.Text = "";
            uploadStudentPic.Image = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            vs.Hide();
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
            byte[] uploadStudentpic = null;

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
                    if (studentidTF2.Text.Length == 0 || passwordTF.Text.Length == 0 || fullnameTF.Text.Length == 0 || genderBox.Text.Length == 0 || datepickTF.Text.Length == 0 || addressTF.Text.Length == 0 || emailTF.Text.Length == 0 || phoneTF2.Text.Length == 0 || uploadStudentPic.Image == null)
                    {
                        MessageBox.Show("opps! Something Went Wrong.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // insert into Student
                    else
                    {
                        // converting img in binary value.
                        FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        uploadStudentpic = br.ReadBytes((int)fs.Length);

                        //Check mobile number

                        if (phoneTF2.Text.Length > 10 || phoneTF2.Text.Length < 10)
                        {
                            MessageBox.Show("Enter Valid Mobile number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // BAL & BEL Operation
                        else if (int.TryParse(phoneTF2.Text, out rlt))
                        {
                            info.studentId = studentidTF.Text + studentidTF2.Text;
                            info.password = passwordTF.Text;
                            info.studentName = fullnameTF.Text;
                            info.studentGender = genderBox.Text;
                            info.studentDOB = datepickTF.Text;
                            info.studentAddress = addressTF.Text;
                            info.studentEmail = emailTF.Text;
                            info.studentPhone = Convert.ToInt64(phoneTF.Text + phoneTF2.Text);
                            info.studentImage = uploadStudentpic;
                            info.stat = 2;

                            try
                            {
                                opr.insertStudent(info);
                                opr.insertIntoStudentLogin(info);

                                MessageBox.Show("Information Saved successfully.", "Success", MessageBoxButtons.OK);
                                // clear field
                                clearStudentField();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Already exist User.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                               
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Valid Mobile number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                
            }
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            clearStudentField();
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
