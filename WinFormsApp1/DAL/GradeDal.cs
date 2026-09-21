using MySqlConnector;
using System;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;

namespace WinFormsApp1.DAL
{
    public class GradeDal
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;

        public async Task<DataTable> GetAll()
        {
            DataTable dt = new DataTable();

            try
            {
                await using var conn = new MySqlConnection(connectionString);
                await conn.OpenAsync();

                string query = "SELECT * FROM grades";

                await using var cmd = new MySqlCommand(query, conn);

                await using var reader = await cmd.ExecuteReaderAsync();

                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading grades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

                string query = "SELECT * FROM grades WHERE id = @id";

                await using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                await using var reader = await cmd.ExecuteReaderAsync();

                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dt;
            }


        }


        public async Task<int> Update(string gradeId, string gradeName, string gradeGroup, string gradeOrder, string colour)
        {
                await using var conn = new MySqlConnection(connectionString);
            
                try
                {
                    await conn.OpenAsync();

                    string query = @"UPDATE grades 
                                     SET grade_name = @grade_name,
                                         grade_group = @grade_group,
                                         grade_order = @grade_order,
                                         colour = @colour
                                     WHERE id = @id";

                    await using var cmd = new MySqlCommand(query, conn);
                
                    cmd.Parameters.AddWithValue("@grade_name", gradeName);
                    cmd.Parameters.AddWithValue("@grade_group", gradeGroup);
                    cmd.Parameters.AddWithValue("@grade_order", gradeOrder);
                    cmd.Parameters.AddWithValue("@colour", colour);
                    cmd.Parameters.AddWithValue("@id", gradeId);

                    return await cmd.ExecuteNonQueryAsync();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating grade: " + ex.Message);
                }
            

        }
        public async Task<int> Delete(string id)
        { 
            try
            {
                await using var conn = new MySqlConnection(connectionString);

                await conn.OpenAsync();

                string query = "DELETE FROM grades WHERE id = @id";

                await using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                return await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting the databse: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
                    
        }


        public async Task<int> Store(string gradeName, string gradeGroup, string gradeOrder, string colour)
        {
    
            try
            {
                await using var conn = new MySqlConnection(connectionString);
                await conn.OpenAsync();

                string query = @"INSERT INTO grades
                         (grade_name, grade_group, grade_order, colour)
                         VALUES
                         (@gradeName, @gradeGroup, @gradeOrder, @colour)";

                await using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@gradeName", gradeName);
                cmd.Parameters.AddWithValue("@gradeGroup", gradeGroup);
                cmd.Parameters.AddWithValue("@gradeOrder", gradeOrder);
                cmd.Parameters.AddWithValue("@colour", colour);

                return await cmd.ExecuteNonQueryAsync();

            }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while connecting the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0; 
                }
               

            }

                
        }

    }

