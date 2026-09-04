using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmStudentValid : Form
    {
        public frmStudentValid()
        {
            InitializeComponent();
        }

        private void btmFillData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFname.Text))
            {
                MessageBox.Show("Please enter First Name.","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFname.Focus();
                return;
            }

            // Last Name validation
            if (string.IsNullOrEmpty(txtLname.Text))
            {
                MessageBox.Show("Please enter Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLname.Focus();
                return;
            }

            // Address validation
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please enter Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }

            // Telephone Number validation
            if (string.IsNullOrEmpty(txtTpNo.Text))
            {
                MessageBox.Show("Please enter Telephone Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTpNo.Focus();
                return;
            }

         
            // Gender validation
            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show("Please select Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbMale.Focus();
                return;
            }

            // NIC validation
            if (string.IsNullOrEmpty(txtNic.Text))
            {
                MessageBox.Show("Please enter NIC.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNic.Focus();
                return;
            }

            // Get data
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            DateTime dob = dtpDob.Value;
            string address = txtAddress.Text;
            string tpNo = txtTpNo.Text;
            string nic = txtNic.Text;

            string gender = rbMale.Checked ? "Male" : "Female";


            // Fill data into second section
            txtFname2.Text = fname;
            txtLname2.Text = lname;
            dtpDob2.Value = dob;
            txtAddress2.Text = address;
            txtTpNo2.Text = tpNo;

            rbMale2.Checked = gender == "Male";
            rbFemale2.Checked = gender == "Female";

            txtNic2.Text = nic;

            MessageBox.Show("Student data filled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
