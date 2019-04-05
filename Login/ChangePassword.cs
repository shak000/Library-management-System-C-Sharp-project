using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;

namespace Login
{
    public partial class ChangePassword : Form
    {
        public Information info = new Information();
        public Operations opr = new Operations();
        public ChangePassword(string fetchUserId,string fetchPassword)
        {
            InitializeComponent();
            passwordFetch.Text = fetchPassword;
            userFetch.Text = fetchUserId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void pictureBoxCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            info.userId = userFetch.Text;
            info.password = newTF.Text;

            try
            {

                if (passwordFetch.Text == oldTF.Text && newTF.Text == conTF.Text)
                {
                    if (newTF.Text.Length < 4)
                    {
                        MessageBox.Show("Choose atleast 4 Length password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        opr.updateInLogin(info);

                        MessageBox.Show("Successfully Changed", "Success", MessageBoxButtons.OK);
                        oldTF.Text = "";
                        newTF.Text = "";
                        conTF.Text = "";
                        MessageBox.Show("Session Expired! Login Again.", "Success", MessageBoxButtons.OK);
                        // Application.Exit();
                        FormLogin fl = new FormLogin();
                        fl.Show();
                        this.Close();
                    }
                    

                }
                else
                {
                    MessageBox.Show("Password didn't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    oldTF.Text = "";
                    newTF.Text = "";
                    conTF.Text = "";
                }
            }
            catch (Exception ex)
            {
                
                
            }
        }
    }
}
