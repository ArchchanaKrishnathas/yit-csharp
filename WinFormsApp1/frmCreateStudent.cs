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
    public partial class frmCreateStudent : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;

        //string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
        public frmCreateStudent()
        {
            InitializeComponent();
        }

        private void frmCreateStudent_Load(object sender, EventArgs e)
        {
            LoadGrades();
            LoadHouses();
        }

        // Load Grades into ComboBox
        private void LoadGrades()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string gradeQuery = "SELECT id, grade_name FROM grades";

                    using (MySqlDataAdapter gradeAdapter =
                           new MySqlDataAdapter(gradeQuery, conn))
                    {
                        DataTable gradeTable = new DataTable();
                        gradeAdapter.Fill(gradeTable);

                        cmbGradeName.DataSource = gradeTable;
                        cmbGradeName.DisplayMember = "grade_name";
                        cmbGradeName.ValueMember = "id";
                        cmbGradeName.SelectedIndex = -1;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(
                        "Error loading grades: " + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // Load Houses into ComboBox
        private void LoadHouses()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string houseQuery = "SELECT id, house_name FROM houses";

                    using (MySqlDataAdapter houseAdapter =
                           new MySqlDataAdapter(houseQuery, conn))
                    {
                        DataTable houseTable = new DataTable();
                        houseAdapter.Fill(houseTable);

                        cmbHouseName.DataSource = houseTable;
                        cmbHouseName.DisplayMember = "house_name";
                        cmbHouseName.ValueMember = "id";
                        cmbHouseName.SelectedIndex = -1;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(
                        "Error loading houses: " + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Validate required fields
                    if (string.IsNullOrWhiteSpace(txtFname.Text))
                    {
                        MessageBox.Show("Please enter first name.");
                        txtFname.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtLname.Text))
                    {
                        MessageBox.Show("Please enter last name.");
                        txtLname.Focus();
                        return;
                    }

                    if (cmbGradeName.SelectedValue == null)
                    {
                        MessageBox.Show("Please select a grade.");
                        cmbGradeName.Focus();
                        return;
                    }

                    if (cmbHouseName.SelectedValue == null)
                    {
                        MessageBox.Show("Please select a house.");
                        cmbHouseName.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(cmbMedium.Text))
                    {
                        MessageBox.Show("Please select medium.");
                        cmbMedium.Focus();
                        return;
                    }

                    if (!rdbMale.Checked && !rdbFemale.Checked)
                    {
                        MessageBox.Show("Please select gender.");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtAdmissionNumber.Text))
                    {
                        MessageBox.Show("Please enter admission number.");
                        txtAdmissionNumber.Focus();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtGuardianNumber.Text))
                    {
                        MessageBox.Show("Please enter guardian number.");
                        txtGuardianNumber.Focus();
                        return;
                    }

                    // Convert foreign keys to integers
                    int gradeId = Convert.ToInt32(cmbGradeName.SelectedValue);
                    int houseId = Convert.ToInt32(cmbHouseName.SelectedValue);
                    //int familyId = Convert.ToInt32(txtGuardianNumber.Text);
                    string guardianNumber = txtGuardianNumber.Text.Trim();

                    conn.Open();

                    // Get family ID
                    int familyId;

                    string familyQuery = "SELECT id FROM families WHERE mobile_number = @guardian_number";

                    using (MySqlCommand familyCmd = new MySqlCommand(familyQuery, conn))
                    {
                        familyCmd.Parameters.AddWithValue("@guardian_number", guardianNumber);

                        object result = familyCmd.ExecuteScalar();

                        if (result != null)
                        {
                            familyId = Convert.ToInt32(result);
                        }
                        else
                        {
                            string insertFamilyQuery =
                                "INSERT INTO families (mobile_number) VALUES (@guardian_number); " +
                                "SELECT LAST_INSERT_ID();";

                            using (MySqlCommand insertFamilyCmd =
                                   new MySqlCommand(insertFamilyQuery, conn))
                            {
                                insertFamilyCmd.Parameters.AddWithValue(
                                    "@guardian_number", guardianNumber);

                                familyId = Convert.ToInt32(
                                    insertFamilyCmd.ExecuteScalar());
                            }
                        }
                    }

                    string query =
                        "INSERT INTO students " +
                        "(first_name, last_name, per_address, grade_id, house_id, medium, " +
                        "date_of_birth, family_id, gender, admission_number, nic_number, " +
                        "birth_certificate_number, tele_number) " +
                        "VALUES " +
                        "(@first_name, @last_name, @per_address, @grade_id, @house_id, @medium, " +
                        "@date_of_birth, @family_id, @gender, @admission_number, @nic_number, " +
                        "@birth_certificate_number, @tele_number)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first_name", txtFname.Text.Trim());
                        cmd.Parameters.AddWithValue("@last_name", txtLname.Text.Trim());
                        cmd.Parameters.AddWithValue("@per_address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@grade_id", gradeId);
                        cmd.Parameters.AddWithValue("@house_id", houseId);
                        cmd.Parameters.AddWithValue("@medium", cmbMedium.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_of_birth", dtpDob.Value.Date);
                        cmd.Parameters.AddWithValue("@family_id", familyId);
                        cmd.Parameters.AddWithValue("@gender", rdbMale.Checked ? "M" : "F");
                        cmd.Parameters.AddWithValue("@admission_number", txtAdmissionNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@nic_number", txtNicNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@birth_certificate_number", txtBirthCertificateNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@tele_number", txtTeleNumber.Text.Trim());

                        int affected = cmd.ExecuteNonQuery();

                        if (affected > 0)
                        {
                            MessageBox.Show(
                                "Student inserted successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            // Clear form
                            txtFname.Clear();
                            txtLname.Clear();
                            txtAddress.Clear();
                            txtGuardianNumber.Clear();
                            txtAdmissionNumber.Clear();
                            txtNicNumber.Clear();
                            txtBirthCertificateNumber.Clear();
                            txtTeleNumber.Clear();

                            cmbGradeName.SelectedIndex = -1;
                            cmbHouseName.SelectedIndex = -1;
                            cmbMedium.SelectedIndex = -1;

                            rdbMale.Checked = false;
                            rdbFemale.Checked = false;

                            dtpDob.Value = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show(
                                "Student was not inserted.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show(
                        "Invalid data format.",
                        "Invalid Data",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(
                        "Database error: " + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "An error occurred: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}