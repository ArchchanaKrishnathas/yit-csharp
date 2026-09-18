using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;

namespace WinFormsApp1
{
    public partial class frmShowStudent : Form
    {
        string fname;
        string lname;
        string address;
        string gender;
        string grade;
        string house;
        string medium;
        string dob;
        public frmShowStudent(string fname, string lname, string address, string gender, string grade, string house, string medium, string dob)
        {
            InitializeComponent();
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.gender = gender;
            this.grade = grade;
            this.house = house;
            this.medium = medium;
            this.dob = dob;
        }

      
        private void frmShowStudent_Load(object sender, EventArgs e)
        {
            txtFname.Text = this.fname;
            txtLname.Text = this.lname;
            txtAddress.Text = this.address;
            

            if(this.gender == "M")
            {
                rdbMale.Checked = true;
            }
            else if(this.gender == "F") 
            {
                rdbFemale.Checked = true;
            }

            cmbGradeName.Text = this.grade;
            cmbHouseName.Text = this.house;
            cmbMedium.Text = this.medium;

            // Date of Birth
            if (dob != "N/A")
            {
                dtpDob.Value = Convert.ToDateTime(dob);
            }
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
