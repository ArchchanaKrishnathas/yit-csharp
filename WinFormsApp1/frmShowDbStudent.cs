using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.DAL;

namespace WinFormsApp1
{
    public partial class frmShowDbStudent : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        private string studentId;
        public frmShowDbStudent(string id)
        {
            InitializeComponent();
            this.studentId = id;
        }

        private void frmShowDbStudent_Load(object sender, EventArgs e)
        {
            StudentDal studentDal = new StudentDal();
            DataTable dt = studentDal.GetByID(studentId);

            DataRow dr = dt.Rows[0];

            txtFname.Text = dr["first_name"].ToString();
            txtLname.Text = dr["last_name"].ToString();
            txtAddress.Text = dr["per_address"].ToString();

            //Grade
            GradeDal gradeDal = new GradeDal();

            DataTable gradeTable = gradeDal.GetAll();

            cmbGradeName.DataSource = gradeTable;
            cmbGradeName.DisplayMember = "grade_name";
            cmbGradeName.ValueMember = "id";

            if (dr["grade_id"] != DBNull.Value)
            {
                cmbGradeName.SelectedValue = dr["grade_id"];
            }
            else
            {
                cmbGradeName.SelectedIndex = -1;
                cmbGradeName.Text = "N/A";
            }

            // Gender
            string gender = dr["gender"].ToString();

            if (gender == "M")
            {
                rdbMale.Checked = true;
            }
            else if (gender == "F")
            {
                rdbFemale.Checked = true;
            }

            // House
            HouseDal houseDal = new HouseDal();

            DataTable houseTable = houseDal.GetAll();

            cmbHouseName.DataSource = houseTable;
            cmbHouseName.DisplayMember = "house_name";
            cmbHouseName.ValueMember = "id";

            if (dr["house_id"] != DBNull.Value)
            {
                int houseId = Convert.ToInt32(dr["house_id"]);

                cmbHouseName.SelectedValue = houseId;
            }
            else
            {
                cmbHouseName.SelectedIndex = -1;
                cmbHouseName.Text = "N/A";
            }

            // Medium
            if (dr["medium"] != DBNull.Value && !string.IsNullOrEmpty(dr["medium"].ToString()))
            {
                cmbMedium.Text = dr["medium"].ToString();
            }
            else
            {
                cmbMedium.Text = "N/A";
            }

            // Date of Birth
            if (dr["date_of_birth"] != DBNull.Value)
            {
                dtpDob.Value = Convert.ToDateTime(dr["date_of_birth"]);
            }

            // Guardian Mobile Number

            if (dr["family_id"] != DBNull.Value)
            {
                string familyId = dr["family_id"].ToString();

                FamilyDal familyDal = new FamilyDal();

                DataTable familyTable = familyDal.GetByID(familyId);

                if (familyTable.Rows.Count > 0)
                {
                    DataRow familyRow = familyTable.Rows[0];

                    if (familyRow["mobile_number"] != DBNull.Value &&
                        !string.IsNullOrWhiteSpace(familyRow["mobile_number"].ToString()))
                    {
                        txtFam.Text = familyRow["mobile_number"].ToString();
                    }
                    else
                    {
                        txtFam.Text = "N/A";
                    }
                }
                else
                {
                    txtFam.Text = "N/A";
                }
            }
            else
            {
                txtFam.Text = "N/A";
            }
            // Admission Number
            txtAdmissionNumber.Text = dr["admission_number"].ToString();

            // NIC Number
            txtNicNumber.Text = dr["nic_number"].ToString();

            // Birth Certificate Number
            txtBirthCertificateNumber.Text = dr["birth_certificate_number"].ToString();

            // Telephone Number
            txtTeleNumber.Text = dr["tele_number"].ToString();


        }


      
    }
}
