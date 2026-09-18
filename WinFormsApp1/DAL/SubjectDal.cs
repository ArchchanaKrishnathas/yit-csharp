using MySqlConnector;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace WinFormsApp1.DAL
{
    public class SubjectDal
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public DataTable GetAll()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM subjects", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading subjects: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
