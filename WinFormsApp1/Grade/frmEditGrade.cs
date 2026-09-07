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
    public partial class frmEditGrade : Form
    {
        private string gradeId;
        public frmEditGrade(string id)
        {
            InitializeComponent();
            this.gradeId = id;
        }

        private void frmEditGrade_Load(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM grades WHERE id = {this.gradeId}", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Grade not found.");
                    return;
                }

                DataRow dr = dt.Rows[0];

                txtGrId.Text = dr["id"].ToString();
                txtGrName.Text = dr["grade_name"].ToString();
                txtGrGroup.Text = dr["grade_group"].ToString();
                txtGrOrder.Text = dr["grade_order"].ToString();

                string colour = dr["colour"].ToString();

                if (!string.IsNullOrEmpty(colour))
                {
                    pnlColor.BackColor =
                        ColorTranslator.FromHtml(colour);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                string colour = ColorTranslator.ToHtml(pnlColor.BackColor);

                MySqlCommand cmd = new MySqlCommand($"UPDATE grades SET grade_name ='{txtGrName.Text}', grade_group ='{txtGrGroup.Text}' , grade_order ='{txtGrOrder.Text}' , colour ='{colour}' WHERE id ={this.gradeId}", conn);

                string affectedRow = cmd.ExecuteNonQuery().ToString();

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

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlColor.BackColor = colorDialog1.Color;
            }
        }
    }
}
