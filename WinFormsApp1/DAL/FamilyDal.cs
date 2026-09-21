using MySqlConnector;
using System;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;

namespace WinFormsApp1.DAL
{
    public class FamilyDal
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public async Task<DataTable> GetAll()
        {
            DataTable dt = new DataTable();

            try
            {
                await using var conn = new MySqlConnection(connectionString);

                await conn.OpenAsync();

                string query = "SELECT * FROM families";

                await using var cmd = new MySqlCommand(query, conn);

                await using var reader = await cmd.ExecuteReaderAsync();

                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading Families: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return dt;
            }
           
        }

        public async Task<DataTable> GetByID(string id)
        {
            DataTable dt = new DataTable();

            try
            {
                await using var conn = new MySqlConnection(connectionString);

                await conn.OpenAsync();

                string query = @"SELECT * FROM families WHERE id = @id";
                 
                await using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                await using var reader = await cmd.ExecuteReaderAsync();

                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading Family: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return dt;
            }
          
        }


        public async Task<int> Update(string id, string mobileNumber)
        {
            try
            {
                await using var conn = new MySqlConnection(connectionString);

                await conn.OpenAsync();

                string query = @"
                    UPDATE families
                    SET mobile_number = @mobile_number
                    WHERE id = @id";

                await using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@mobile_number", mobileNumber);
                cmd.Parameters.AddWithValue("@id", id);

                return await cmd.ExecuteNonQueryAsync();
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
        }



        public async Task<int> Store(string mobileNumber)
        {
            try
            {
                await using var conn = new MySqlConnection(connectionString);

                await conn.OpenAsync();

                // Check whether family already exists
                string checkQuery = @"
                    SELECT id
                    FROM families
                    WHERE mobile_number = @mobile_number";

                await using var checkCmd = new MySqlCommand(checkQuery, conn);

                checkCmd.Parameters.AddWithValue("@mobile_number", mobileNumber);

                object result = await checkCmd.ExecuteScalarAsync();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }

                // Insert new family
                string query = @"
                    INSERT INTO families (mobile_number)
                    VALUES (@mobile_number);

                    SELECT LAST_INSERT_ID();";

                await using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue(
                    "@mobile_number",
                    mobileNumber);

                object newId = await cmd.ExecuteScalarAsync();

                return Convert.ToInt32(newId);
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
           
        }
    }
}
