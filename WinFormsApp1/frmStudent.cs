using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void btmFillData_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            DateTime dob = dtpDob.Value;
            string address = txtAddress.Text;
            string tpNo = txtTpNo.Text;
            string nic = txtNic.Text;

            string gender = rbMale.Checked ? "Male" : "Female";
            /*
            string gender = "";
            
            if (rbMale.Checked)
            {
                gender = "Male";
            } 
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }
            */


            // Fill data into second section
            txtFname2.Text = fname;
            txtLname2.Text = lname;
            dtpDob2.Value = dob;
            txtAddress2.Text = address;
            txtTpNo2.Text = tpNo;
            txtNic2.Text = nic;

            rbMale2.Checked = gender == "Male";
            rbFemale2.Checked = gender == "Female";
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
