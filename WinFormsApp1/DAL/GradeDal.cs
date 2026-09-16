using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp1.DAL
{
    public class GradeDal
    {
        string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";

        public DataTable GetAll()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM grades", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading grades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return dt;
            }
            finally
            {
                conn.Close();
            }
        }


        public DataTable GetByID(string id)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM grades WHERE id = {id}", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }


        }


        public int Update(string gradeId, string gradeName, string gradeGroup, string gradeOrder, string colour)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"UPDATE grades 
                                     SET grade_name = @grade_name,
                                         grade_group = @grade_group,
                                         grade_order = @grade_order,
                                         colour = @colour
                                     WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@grade_name", gradeName);
                        cmd.Parameters.AddWithValue("@grade_group", gradeGroup);
                        cmd.Parameters.AddWithValue("@grade_order", gradeOrder);
                        cmd.Parameters.AddWithValue("@colour", colour);
                        cmd.Parameters.AddWithValue("@id", gradeId);

                        return cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating grade: " + ex.Message);
                }
            }

        }
    }
}
