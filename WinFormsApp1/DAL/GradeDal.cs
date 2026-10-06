using MySqlConnector;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;

namespace WinFormsApp1.DAL
{
    public class GradeDal
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;

        // READ: all grades
        public async Task<DataTable> GetAll()
        {
            DataTable dt = new DataTable();

            await using var conn = new MySqlConnection(connectionString);
            await conn.OpenAsync();

            string query = "SELECT * FROM grades";

            await using var cmd = new MySqlCommand(query, conn);
            await using var reader = await cmd.ExecuteReaderAsync();

            dt.Load(reader);

            return dt;
        }

        // READ: one grade
        public async Task<DataTable> GetByID(string id)
        {
            DataTable dt = new DataTable();

            await using var conn = new MySqlConnection(connectionString);
            await conn.OpenAsync();

            string query = "SELECT * FROM grades WHERE id = @id";

            await using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            await using var reader = await cmd.ExecuteReaderAsync();

            dt.Load(reader);

            return dt;
        }

        // CREATE
        public async Task<int> Store(
            string gradeName,
            string gradeGroup,
            string gradeOrder,
            string colour)
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

        // UPDATE
        public async Task<int> Update(
            string gradeId,
            string gradeName,
            string gradeGroup,
            string gradeOrder,
            string colour)
        {
            await using var conn = new MySqlConnection(connectionString);
            await conn.OpenAsync();

            string query = @"UPDATE grades
                             SET grade_name = @gradeName,
                                 grade_group = @gradeGroup,
                                 grade_order = @gradeOrder,
                                 colour = @colour
                             WHERE id = @id";

            await using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@gradeName", gradeName);
            cmd.Parameters.AddWithValue("@gradeGroup", gradeGroup);
            cmd.Parameters.AddWithValue("@gradeOrder", gradeOrder);
            cmd.Parameters.AddWithValue("@colour", colour);
            cmd.Parameters.AddWithValue("@id", gradeId);

            return await cmd.ExecuteNonQueryAsync();
        }

        // DELETE
        public async Task<int> Delete(string id)
        {
            await using var conn = new MySqlConnection(connectionString);
            await conn.OpenAsync();

            string query = "DELETE FROM grades WHERE id = @id";

            await using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            return await cmd.ExecuteNonQueryAsync();
        }
    }
}