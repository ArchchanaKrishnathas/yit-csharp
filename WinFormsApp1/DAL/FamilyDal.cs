using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp1.DAL
{
    public class FamilyDal
    {
        string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
        public DataTable GetAll()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM families", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading Families: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM families WHERE id = @id", conn);

                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading Family: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return dt;
            }
            finally
            {
                conn.Close();
            }
        }


        public int Update(string id, string mobileNumber)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE families SET mobile_number=@mobile_number " +
                    "WHERE id=@id",
                    conn);

                cmd.Parameters.AddWithValue("@mobile_number", mobileNumber);
                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while updating family: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return 0;
            }
            finally
            {
                conn.Close();
            }
        }



        public int Store(string mobileNumber)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                // Check whether family already exists
                MySqlCommand checkCmd = new MySqlCommand(
                    "SELECT id FROM families WHERE mobile_number = @mobile_number",
                    conn);

                checkCmd.Parameters.AddWithValue("@mobile_number", mobileNumber);

                object result = checkCmd.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }

                // Insert new family
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO families (mobile_number) " +
                    "VALUES (@mobile_number); " +
                    "SELECT LAST_INSERT_ID();",
                    conn);

                cmd.Parameters.AddWithValue("@mobile_number", mobileNumber);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while storing family: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
