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
    public partial class frmConnect : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public frmConnect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MessageBox.Show("Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnStudents_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM students", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStudents.DataSource = dt;

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

        private void LoadGrades()
        {
            string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";

            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT id, grade_name FROM grades", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbGradeName.DataSource = dt;
                cmbGradeName.DisplayMember = "grade_name";
                cmbGradeName.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while loading grades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadHouses()
        {
            string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT id, house_name FROM houses";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbHouseName.DataSource = dt;
                    cmbHouseName.DisplayMember = "house_name";
                    cmbHouseName.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while loading houses: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            LoadGrades();
            LoadHouses();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvStudents.CurrentRow == null)
                {
                    MessageBox.Show("no Data found");
                    return;
                }

                string fna = dgvStudents.CurrentRow.Cells["first_name"].Value.ToString();
                string lna = dgvStudents.CurrentRow.Cells["last_name"].Value.ToString();
                string add = dgvStudents.CurrentRow.Cells["per_address"].Value.ToString();

                string gen = dgvStudents.CurrentRow.Cells["gender"].Value.ToString();

                // Get Grade
                string grade = "N/A";
                string gradeId = dgvStudents.CurrentRow.Cells["grade_id"].Value?.ToString();

                if (!string.IsNullOrEmpty(gradeId))
                {
                    grade = cmbGradeName.Text;
                }

                // House
                string house = "N/A";

                string houseId = dgvStudents.CurrentRow.Cells["house_id"].Value?.ToString();

                if (string.IsNullOrEmpty(houseId))
                {
                    cmbHouseName.SelectedIndex = -1;
                    cmbHouseName.Text = "N/A";
                }
                else
                {
                    cmbHouseName.SelectedValue = houseId;
                    house = cmbHouseName.Text;
                }

                // Medium
                string medium = dgvStudents.CurrentRow.Cells["medium"].Value?.ToString();

                if (string.IsNullOrEmpty(medium))
                {
                    medium = "N/A";
                }

                // Date of Birth
                string dob = "N/A";
                string dobValue = dgvStudents.CurrentRow.Cells["date_of_birth"].Value?.ToString();

                if (!string.IsNullOrEmpty(dobValue))
                {
                    dob = Convert.ToDateTime(dobValue).ToString("yyyy-MM-dd");
                }

                frmShowStudent f = new frmShowStudent(fna, lna, add, gen, grade, house, medium, dob);
                f.ShowDialog();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //MessageBox.Show(ex.Message.ToString());
            //throw;
        }
        /*
                   try
                    {
                        if (dgvStudents.CurrentRow == null)
                        {
                            MessageBox.Show("no Data found");
                            return;
                        }
                        string fname = dgvStudents.CurrentRow.Cells["first_name"].Value?.ToString();
                        txtFname.Text = fname;

                        string lname = dgvStudents.CurrentRow.Cells["last_name"].Value?.ToString();
                        txtLname.Text = lname;

                        string address = dgvStudents.CurrentRow.Cells["per_address"].Value?.ToString();
                        if (string.IsNullOrEmpty(address))
                        {
                            txtAddress.Text = "N/A";
                        }
                        else
                        {
                            txtAddress.Text = address;
                        }

                        // Set the gender radio button 
                        string gender = dgvStudents.CurrentRow.Cells["gender"].Value?.ToString();
                        if (gender == "M")
                        {
                            rdbMale.Checked = true;
                        }
                        else if (gender == "F")
                        {
                            rdbFemale.Checked = true;
                        }

                        // Load the grades into the combo box
                        string gradeValue = dgvStudents.CurrentRow.Cells["grade_id"].Value?.ToString();

                        if (string.IsNullOrEmpty(gradeValue))
                        {
                            cmbGradeName.SelectedIndex = -1;
                            cmbGradeName.Text = "N/A";
                        }
                        else
                        {
                            cmbGradeName.SelectedValue = gradeValue;
                        }

                        // Load the houses into the combo box
                        string house = "N/A";

                        string houseId = dgvStudents.CurrentRow.Cells["house_id"].Value?.ToString();

                        if (string.IsNullOrEmpty(houseId))
                        {
                            cmbHouseName.SelectedIndex = -1;
                            cmbHouseName.Text = "N/A";
                        }
                        else
                        {
                            cmbHouseName.SelectedValue = houseId;
                            house = cmbHouseName.Text;
                        }

                        // Load the medium into the combo box
                        string medium = dgvStudents.CurrentRow.Cells["medium"].Value?.ToString();

                        if (string.IsNullOrEmpty(medium))
                        {
                            cmbMedium.Text = "N/A";
                        }
                        else
                        {
                            cmbMedium.Text = medium;
                        }


                        // Load the date of birth
                        string dob = dgvStudents.CurrentRow.Cells["date_of_birth"].Value?.ToString();

                        if (string.IsNullOrEmpty(dob))
                        {
                            dtpDob.Value = DateTime.Today;
                        }
                        else
                        {
                            dtpDob.Value = Convert.ToDateTime(dob);
                        }

                        // Load the family ID
                        string familyId = dgvStudents.CurrentRow.Cells["family_id"].Value?.ToString();

                        if (string.IsNullOrEmpty(familyId))
                        {
                            txtFam.Text = "N/A";
                        }
                        else
                        {
                            txtFam.Text = familyId;
                        }

                        // Load the admission number
                        string admissionNumber = dgvStudents.CurrentRow.Cells["admission_number"].Value?.ToString();

                        if (string.IsNullOrEmpty(admissionNumber))
                        {
                            txtAdmissionNumber.Text = "N/A";
                        }
                        else
                        {
                            txtAdmissionNumber.Text = admissionNumber;
                        }

                        // Load the NIC number
                        string nicNumber = dgvStudents.CurrentRow.Cells["nic_number"].Value?.ToString();

                        if (string.IsNullOrEmpty(nicNumber))
                        {
                            txtNicNumber.Text = "N/A";
                        }
                        else
                        {
                            txtNicNumber.Text = nicNumber;
                        }

                        // Load the birth certificate number
                        string birthCertificateNumber = dgvStudents.CurrentRow.Cells["birth_certificate_number"].Value?.ToString();

                        if (string.IsNullOrEmpty(birthCertificateNumber))
                        {
                            txtBirthCertificateNumber.Text = "N/A";
                        }
                        else
                        {
                            txtBirthCertificateNumber.Text = birthCertificateNumber;
                        }

                        // Load the telephone number
                        string teleNumber = dgvStudents.CurrentRow.Cells["tele_number"].Value?.ToString();

                        if (string.IsNullOrEmpty(teleNumber))
                        {
                            txtTeleNumber.Text = "N/A";
                        }
                        else
                        {
                            txtTeleNumber.Text = teleNumber;
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }*/
        /*  catch (Exception ex)
            {
                MessageBox.Show("Please Select a row from the table: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } */




        private void btnLoadGrade(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM grades", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbGradeName.DataSource = dt;
                cmbGradeName.DisplayMember = "grade_name";
                cmbGradeName.ValueMember = "id";

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbGradeName.SelectedValue?.ToString());
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            cmbGradeName.SelectedValue = "10";

        }

        private void cmbGradeName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDbShow_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvStudents.CurrentRow == null)
                {
                    MessageBox.Show("no Data found");
                    return;
                }

                string id = dgvStudents.CurrentRow.Cells["id"].Value?.ToString();
                frmShowDbStudent f = new frmShowDbStudent(id);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvStudents.CurrentRow == null)
                {
                    MessageBox.Show("no Data found");
                    return;
                }

                string id = dgvStudents.CurrentRow.Cells["id"].Value?.ToString();
                frmEditStudent f = new frmEditStudent(id);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                if (dgvStudents.CurrentRow == null)
                {
                    MessageBox.Show("no Data found");
                    return;
                }

                string id = dgvStudents.CurrentRow.Cells["id"].Value?.ToString();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this student?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand($"DELETE FROM students WHERE id = {id}", conn);
                    int affected = cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted successfully. Rows Affected: " + affected.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                frmCreateStudent f = new frmCreateStudent();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }

            
        }
    }
}
