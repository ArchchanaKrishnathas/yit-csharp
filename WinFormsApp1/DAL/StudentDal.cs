using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WinFormsApp1.DAL
{
    public class StudentDal
    {
        string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";
        public DataTable GetAll()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            DataTable dt = new DataTable(); 

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM students", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting the databse: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM students WHERE id={id}", conn);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting the databse: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }
            finally
            {
                conn.Close();
            }

        }

        // Update
        public int Update(
        string id,
        string firstName,
        string lastName,
        string address,
        object gradeId,
        object houseId,
        string medium,
        DateTime dateOfBirth,
        object familyId,
        string gender,
        string admissionNumber,
        string nicNumber,
        string birthCertificateNumber,
        string telephoneNumber)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE students SET " +
                    "first_name=@first_name, " +
                    "last_name=@last_name, " +
                    "per_address=@per_address, " +
                    "grade_id=@grade_id, " +
                    "house_id=@house_id, " +
                    "medium=@medium, " +
                    "date_of_birth=@date_of_birth, " +
                    "family_id=@family_id, " +
                    "gender=@gender, " +
                    "admission_number=@admission_number, " +
                    "nic_number=@nic_number, " +
                    "birth_certificate_number=@birth_certificate_number, " +
                    "tele_number=@tele_number " +
                    "WHERE id=@id",
                    conn);

                cmd.Parameters.AddWithValue("@first_name", firstName);
                cmd.Parameters.AddWithValue("@last_name", lastName);
                cmd.Parameters.AddWithValue("@per_address", address);
                cmd.Parameters.AddWithValue("@grade_id", gradeId);
                cmd.Parameters.AddWithValue("@house_id", houseId);
                cmd.Parameters.AddWithValue("@medium", medium);
                cmd.Parameters.AddWithValue("@date_of_birth", dateOfBirth);
                cmd.Parameters.AddWithValue("@family_id", familyId);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@admission_number", admissionNumber);
                cmd.Parameters.AddWithValue("@nic_number", nicNumber);
                cmd.Parameters.AddWithValue("@birth_certificate_number", birthCertificateNumber);
                cmd.Parameters.AddWithValue("@tele_number", telephoneNumber);
                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while updating student: " + ex.Message,
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


        public int Delete(string id)
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("DELETE FROM students WHERE id = @id", conn);

                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 0;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
