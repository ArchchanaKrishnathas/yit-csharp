using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace WinFormsApp1.DAL
{
    public class SubjectDal
    {
        string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
        public DataTable GetAll()
        {
            MySqlConnection conn = new MySqlConnection(connString);
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
