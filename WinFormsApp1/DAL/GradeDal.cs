using MySqlConnector;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp1.DAL
{
    public class GradeDal
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;

        public DataTable GetAll()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
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
            MySqlConnection conn = new MySqlConnection(connectionString);
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
            using (MySqlConnection conn = new MySqlConnection(connectionString))
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
        public int Delete(string id)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand($"DELETE FROM grades WHERE id = {id}", conn);
                return cmd.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting the databse: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                conn.Close();
            }

           
        }


        public int Store(string gradeName, string gradeGroup, string gradeOrder, string colour)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(
                            "INSERT INTO grades " +
                            "(grade_name, grade_group, grade_order, colour) " +
                            "VALUES " +
                            "(@gradeName, @gradeGroup, @gradeOrder, @colour)",
                            conn);

                    cmd.Parameters.AddWithValue("@gradeName", gradeName);
                    cmd.Parameters.AddWithValue("@gradeGroup", gradeGroup);
                    cmd.Parameters.AddWithValue("@gradeOrder", gradeOrder);
                    cmd.Parameters.AddWithValue("@colour", colour);

                    return cmd.ExecuteNonQuery();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while connecting the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0; 
                }
                finally
                {
                    conn.Close();
                }

            }

                
        }

    }
}
