using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.DAL;

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

            try
            {
                // Convert selected color to HEX
                string colour =
                    $"#{pnlColor.BackColor.R:X2}" +
                    $"{pnlColor.BackColor.G:X2}" +
                    $"{pnlColor.BackColor.B:X2}";


                GradeDal gradeDAL = new GradeDal();

                int affectedRows = gradeDAL.Store(txtGrName.Text, txtGrGroup.Text, txtGrOrder.Text, colour);

                if (affectedRows > 0)
                {
                    MessageBox.Show(
                        "Inserted successfully. Rows Affected: " + affectedRows,
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
