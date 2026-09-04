using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Grade
{
    public partial class frmGrade : Form
    {
        public frmGrade()
        {
            InitializeComponent();
        }

        private void btnAllGrades_Click(object sender, EventArgs e)
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
                dgvGrades.DataSource = dt;
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

        private void btnShow_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvGrades.CurrentRow == null)
                {
                    MessageBox.Show("No Data Found");
                    return;
                }

                string id = dgvGrades.CurrentRow.Cells["id"].Value?.ToString();
                frmShowGrade f = new frmShowGrade(id);
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
                if (dgvGrades.CurrentRow == null)
                {
                    MessageBox.Show("No Data Found");
                    return;
                }

                string id = dgvGrades.CurrentRow.Cells["id"].Value?.ToString();
                frmEditGrade f = new frmEditGrade(id);
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

                if (dgvGrades.CurrentRow == null)
                {
                    MessageBox.Show("no Data found");
                    return;
                }

                string id = dgvGrades.CurrentRow.Cells["id"].Value?.ToString();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this Grade?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MySqlCommand cmd = new MySqlCommand($"DELETE FROM grades WHERE id = {id}", conn);
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                frmCreateGrade f = new frmCreateGrade();
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
