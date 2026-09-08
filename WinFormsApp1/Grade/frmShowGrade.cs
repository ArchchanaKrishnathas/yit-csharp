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
    public partial class frmShowGrade : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        private string gradeId;
        public frmShowGrade(string id)
        {
            InitializeComponent();
            this.gradeId = id;
        }

        private void frmShowGrade_Load(object sender, EventArgs e)
        {
            //string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
            MySqlConnection conn = new MySqlConnection(connectionString);

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
                    pnlColor.BackColor = ColorTranslator.FromHtml(colour);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
