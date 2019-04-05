﻿using System;
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
    public partial class ActiveInactive : UserControl
    {
        Information info = new Information();
        Operations opr = new Operations();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-N1PTAGF;Initial Catalog=Library_management_System;Integrated Security=True;Pooling=False");
        DataTable dt = new DataTable();
        int status;
        public ActiveInactive()
        {
            InitializeComponent();
        }
        //load Student
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            fullnameTF.Text = "";
            genderTF.Text = "";
            dobTF.Text = "";
            addressTF.Text = "";
            emailTF.Text = "";
            phoneTF2.Text = "";
            studentTxt.Text = "";
            feesTF.Text = "";
            studentTxt.Enabled = true;
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

        private void btnActive_Click(object sender, EventArgs e)
        {

            info.userId = studentTxt.Text;

            dt = opr.updateActive(info);
            if (dt.Rows.Count > 0)
            {
                status = Convert.ToInt32(dt.Rows[0][2].ToString());
                if (status == 2)
                {
                    MessageBox.Show("This user already Active", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (status == 3)
                {
                    opr.activeStudent(info);
                    opr.deleteFromFees(info);
                    MessageBox.Show("Activate user successfully", "Success", MessageBoxButtons.OK);
                }
            }

        }

        private void btnInactive_Click(object sender, EventArgs e)
        {

            info.userId = studentTxt.Text;

            dt = opr.updateActive(info);
            if (dt.Rows.Count > 0)
            {
                status = Convert.ToInt32(dt.Rows[0][2].ToString());
                if (status == 3)
                {
                    MessageBox.Show("This user already Inactive", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (status == 2)
                {
                    opr.deactivateUser(info);
                    MessageBox.Show("Deactivate user successfully", "Success", MessageBoxButtons.OK);
                }
            }

        }
    }
}
