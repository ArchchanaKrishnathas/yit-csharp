using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            //txtFname.Text = studentId;

            //string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();


                //Students
                //MySqlCommand cmd = new MySqlCommand($"SELECT * FROM students WHERE id = {this.studentId}", conn);

                MySqlCommand cmd = new MySqlCommand(
    "SELECT students.*, families.mobile_number AS guardian_number " +
    "FROM students " +
    "LEFT JOIN families ON students.family_id = families.id " +
    "WHERE students.id = @id", conn);

                cmd.Parameters.AddWithValue("@id", this.studentId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Student not found.");
                    return;
                }

                DataRow dr = dt.Rows[0];

                txtFname.Text = dr["first_name"].ToString();
                txtLname.Text = dr["last_name"].ToString();
                txtAddress.Text = dr["per_address"].ToString();

                // Load grades into ComboBox
                string gradeQuery = "SELECT id, grade_name FROM grades";

                MySqlDataAdapter gradeAdapter = new MySqlDataAdapter(gradeQuery, conn);
                DataTable gradeTable = new DataTable();
                gradeAdapter.Fill(gradeTable);

                cmbGradeName.DataSource = gradeTable;
                cmbGradeName.DisplayMember = "grade_name";
                cmbGradeName.ValueMember = "id";

                // Load Houses into ComboBox
                string houseQuery = "SELECT id, house_name FROM houses";

                MySqlDataAdapter houseAdapter = new MySqlDataAdapter(houseQuery, conn);
                DataTable houseTable = new DataTable();
                houseAdapter.Fill(houseTable);

                cmbHouseName.DataSource = houseTable;
                cmbHouseName.DisplayMember = "house_name";
                cmbHouseName.ValueMember = "id";

                



                // Grade
                if (dr["grade_id"] != DBNull.Value)
                {
                    cmbGradeName.SelectedValue = dr["grade_id"];
                }
                else
                {
                    cmbGradeName.SelectedIndex = -1;
                    cmbGradeName.Text = "N/A";
                }

                // House
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

                // Admission Number
                txtAdmissionNumber.Text = dr["admission_number"].ToString();

                // NIC Number
                txtNicNumber.Text = dr["nic_number"].ToString();

                // Birth Certificate Number
                txtBirthCertificateNumber.Text = dr["birth_certificate_number"].ToString();

                // Telephone Number
                txtTeleNumber.Text = dr["tele_number"].ToString();

                // Family ID
                //txtFam.Text = dr["family_id"].ToString();

                // Load families
                /*string familyQuery = "SELECT id, mobile_number FROM families";

                MySqlDataAdapter familyAdapter = new MySqlDataAdapter(familyQuery, conn);
                DataTable familyTable = new DataTable();
                familyAdapter.Fill(familyTable);

                // Guardian Mobile Number
                if (dr["family_id"] != DBNull.Value)
                {
                    string familyId = dr["family_id"].ToString();

                    foreach (DataRow familyRow in familyTable.Rows)
                    {
                        if (familyRow["id"].ToString() == familyId)
                        {
                            txtFam.Text = familyRow["mobile_number"].ToString();
                            break;
                        }
                    }
                }
                else
                {
                    txtFam.Text = "N/A";
                }
*/
                // Guardian Mobile Number
                if (dr["guardian_number"] != DBNull.Value &&
                    !string.IsNullOrWhiteSpace(dr["guardian_number"].ToString()))
                {
                    txtFam.Text = dr["guardian_number"].ToString();
                }
                else
                {
                    txtFam.Text = "N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting the databse: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
