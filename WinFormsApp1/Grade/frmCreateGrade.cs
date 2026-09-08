using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Grade
{
    public partial class frmCreateGrade : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public frmCreateGrade()
        {
            InitializeComponent();

        }

        private void frmCreateGrade_Load(object sender, EventArgs e)
        {
            // Set default color
            pnlColor.BackColor = Color.White;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                // Convert selected color to HEX
                string colour =
                    $"#{pnlColor.BackColor.R:X2}" +
                    $"{pnlColor.BackColor.G:X2}" +
                    $"{pnlColor.BackColor.B:X2}";

                MySqlCommand cmd = new MySqlCommand(
                    $"INSERT INTO grades " +
                    $"(grade_name, grade_group, grade_order, colour) " +
                    $"VALUES " +
                    $"('{txtGrName.Text}', '{txtGrGroup.Text}', '{txtGrOrder.Text}', '{colour}')", conn);


                string affectedRow = cmd.ExecuteNonQuery().ToString();

                MessageBox.Show(
                    "Inserted successfully. Rows Affected: " + affectedRow,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Clear fields
                txtGrName.Clear();
                txtGrGroup.Clear();
                txtGrOrder.Clear();

                // Reset color
                pnlColor.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while inserting the database: "
                    + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlColor.BackColor = colorDialog1.Color;
            }
        }
    }
}
