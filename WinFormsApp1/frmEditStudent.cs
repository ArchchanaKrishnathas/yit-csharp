using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

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

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            //txtFname.Text = studentId;

            //string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

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
                    familyId = Convert.ToInt32(dr["family_id"]);

                    foreach (DataRow familyRow in familyTable.Rows)
                    {
                        if (Convert.ToInt32(familyRow["id"]) == familyId)
                        {
                            txtFam.Text = familyRow["mobile_number"].ToString();
                            break;
                        }
                    }
                }
                else
                {
                    familyId = null;
                    txtFam.Text = "N/A";
                }
*/
                // Family ID
                if (dr["family_id"] != DBNull.Value)
                {
                    familyId = Convert.ToInt32(dr["family_id"]);
                }
                else
                {
                    familyId = null;
                }

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                //MySqlCommand cmd = new MySqlCommand($"UPDATE students SET first_name ='{txtFname.Text}', last_name ='{txtLname.Text}' , per_address ='{txtAddress.Text}'  WHERE id ={this.studentId}", conn);
                MySqlCommand cmd = new MySqlCommand(
                "UPDATE students SET " +
                "first_name=@first_name, " +
                "last_name=@last_name, " +
                "per_address=@per_address, " +
                "grade_id=@grade_id, " +
                "house_id=@house_id, " +
                "medium=@medium, " +
                "date_of_birth=@date_of_birth, " +
                "family_id=@family_id, " +
                "gender=@gender, " +
                "admission_number=@admission_number, " +
                "nic_number=@nic_number, " +
                "birth_certificate_number=@birth_certificate_number, " +
                "tele_number=@tele_number " +
                "WHERE id=@id", conn);

                cmd.Parameters.AddWithValue("@first_name", txtFname.Text);
                cmd.Parameters.AddWithValue("@last_name", txtLname.Text);
                cmd.Parameters.AddWithValue("@per_address", txtAddress.Text);

                // Grade ComboBox
                cmd.Parameters.AddWithValue("@grade_id", cmbGradeName.SelectedValue);

                // House ComboBox
                cmd.Parameters.AddWithValue("@house_id", cmbHouseName.SelectedValue);

                cmd.Parameters.AddWithValue("@medium", cmbMedium.Text);
                cmd.Parameters.AddWithValue("@date_of_birth", dtpDob.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gender", rdbMale.Checked ? "M" : "F");
                cmd.Parameters.AddWithValue("@admission_number", txtAdmissionNumber.Text);
                cmd.Parameters.AddWithValue("@nic_number", txtNicNumber.Text);
                cmd.Parameters.AddWithValue("@family_id", familyId.HasValue ? familyId.Value : DBNull.Value);

                cmd.Parameters.AddWithValue("@birth_certificate_number", txtBirthCertificateNumber.Text);
                cmd.Parameters.AddWithValue("@tele_number", txtTeleNumber.Text);
                cmd.Parameters.AddWithValue("@id", this.studentId);

                string affectedRow = cmd.ExecuteNonQuery().ToString();

                // Update Guardian Mobile Number
                if (familyId.HasValue && !string.IsNullOrWhiteSpace(txtFam.Text) && txtFam.Text != "N/A")
                {
                    MySqlCommand familyCmd = new MySqlCommand(
                        "UPDATE families SET mobile_number=@mobile_number WHERE id=@family_id", conn);

                    familyCmd.Parameters.AddWithValue("@mobile_number", txtFam.Text);
                    familyCmd.Parameters.AddWithValue("@family_id", familyId.Value);

                    familyCmd.ExecuteNonQuery();
                }


                MessageBox.Show("Updated successfully. Rows Affected: " + affectedRow, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void txtFam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
