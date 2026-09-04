using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmLabelShow : Form
    {
        public frmLabelShow()
        {
            InitializeComponent();
           
        }

        private void btnFullName_Click(object sender, EventArgs e)
        {
            string message = "";
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                message = "Please enter First name.";
                lblFullName.Text = message;
                txtFirstName.Focus();
                timer1.Start();
                return;
            }

            if (string.IsNullOrEmpty(txtlastName.Text))
            {
                message = "Please enter Last name.";
                lblFullName.Text = message;
                txtlastName.Focus();
                timer1.Start();
                return;
            }

            string fname = txtFirstName.Text;
            string lname = txtlastName.Text;

            string fullName = $"{fname} {lname}";
            txtFullName.Text = fullName;
            message = "Full Name is " + fullName;
            lblFullName.Text = message;
            timer1.Start();
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void lblFullName_Click_1(object sender, EventArgs e)
        {

        }

        private void frmLabelShow_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFullName.Text = "";
            timer1.Stop();
        }
    }
}
