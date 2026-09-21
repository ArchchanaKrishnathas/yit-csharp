using MySqlConnector;
using System;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;


namespace WinFormsApp1.DAL
{
    public class SubjectDal
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public async Task<DataTable> GetAll()
        {
            DataTable dt = new DataTable();

            try
            {
                await using var conn = new MySqlConnection(connectionString);

                await conn.OpenAsync();

                string query = "SELECT * FROM subjects";

                await using var cmd = new MySqlCommand(query, conn);

                await using var reader = await cmd.ExecuteReaderAsync();

                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading subjects: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return dt;
            }
          
        }

    }
}
