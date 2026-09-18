using MySqlConnector;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using WinFormsApp1.DAL;

namespace WinFormsApp1
{
    public partial class frmEditStudent : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        private string studentId;
        private int? familyId;
        public frmEditStudent(string id)
        {
            InitializeComponent();
            this.studentId = id;
        }

        private async void frmEditStudent_Load(object sender, EventArgs e)
        {


            StudentDal studentDal = new StudentDal();

            DataTable dt = await studentDal.GetByID(studentId);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Student not found.");
                return;
            }

            DataRow dr = dt.Rows[0];

            txtFname.Text = dr["first_name"].ToString();
            txtLname.Text = dr["last_name"].ToString();
            txtAddress.Text = dr["per_address"].ToString();

            // GRADE
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

            // HOUSE

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


            // MEDIUM
            if (dr["medium"] != DBNull.Value &&
                !string.IsNullOrEmpty(dr["medium"].ToString()))
            {
                cmbMedium.Text = dr["medium"].ToString();
            }
            else
            {
                cmbMedium.Text = "N/A";
            }


            // DATE OF BIRTH
            if (dr["date_of_birth"] != DBNull.Value)
            {
                dtpDob.Value = Convert.ToDateTime(dr["date_of_birth"]);
            }

            // GENDER
            string gender = dr["gender"].ToString();

            if (gender == "M")
            {
                rdbMale.Checked = true;
            }
            else if (gender == "F")
            {
                rdbFemale.Checked = true;
            }

            // ADMISSION NUMBER
            txtAdmissionNumber.Text = dr["admission_number"].ToString();

            // NIC NUMBER
            txtNicNumber.Text = dr["nic_number"].ToString();

            // BIRTH CERTIFICATE NUMBER
             txtBirthCertificateNumber.Text =
                dr["birth_certificate_number"].ToString();

            // TELEPHONE NUMBER
                txtTeleNumber.Text = dr["tele_number"].ToString();

            // GUARDIAN MOBILE NUMBER       
            if (dr["family_id"] != DBNull.Value)
            {
                familyId = Convert.ToInt32(dr["family_id"]);
            }
            else
            {
                familyId = null;
            }


            if (familyId.HasValue)
            {
                FamilyDal familyDal = new FamilyDal();

                DataTable familyTable = familyDal.GetByID(familyId.Value.ToString());

                if (familyTable.Rows.Count > 0)
                {
                    DataRow familyRow = familyTable.Rows[0];

                    if (familyRow["mobile_number"] != DBNull.Value &&
                        !string.IsNullOrWhiteSpace(
                            familyRow["mobile_number"].ToString()))
                    {
                        txtFam.Text =
                            familyRow["mobile_number"].ToString();
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



        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // STUDENT UPDATE
                StudentDal studentDal = new StudentDal();

                int affectedRow = await studentDal.Update(
                    studentId,
                    txtFname.Text,
                    txtLname.Text,
                    txtAddress.Text,
                    cmbGradeName.SelectedValue,
                    cmbHouseName.SelectedValue,
                    cmbMedium.Text,
                    dtpDob.Value,
                    familyId.HasValue ? familyId.Value : DBNull.Value,
                    rdbMale.Checked ? "M" : "F",
                    txtAdmissionNumber.Text,
                    txtNicNumber.Text,
                    txtBirthCertificateNumber.Text,
                    txtTeleNumber.Text
                );

                // FAMILY UPDATE
                if (familyId.HasValue &&
                    !string.IsNullOrWhiteSpace(txtFam.Text) &&
                    txtFam.Text != "N/A")
                {
                    FamilyDal familyDal = new FamilyDal();

                    familyDal.Update(
                        familyId.Value.ToString(),
                        txtFam.Text
                    );
                }

                // SUCCESS MESSAGE

                MessageBox.Show(
                    "Updated successfully. Rows Affected: " + affectedRow,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while updating student: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtFam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
