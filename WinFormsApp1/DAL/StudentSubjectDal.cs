using MySqlConnector;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WinFormsApp1.DAL
{
    public class StudentSubjectDal
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;

        public async Task<DataTable> GetByStudentId(string studentId)
        {
            DataTable dt = new DataTable();
            
            try
            {
                await using var conn = new MySqlConnection(connectionString);

                await conn.OpenAsync();

                string query = @"
                    SELECT subject_id
                    FROM student_subjects
                    WHERE student_id = @studentId";

                await using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@studentId", studentId);

                await using var reader = await cmd.ExecuteReaderAsync();

                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading student subjects:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
            return dt;
        }

        public async Task<int> Store(string studentId, string subjectId)
        {

            try
            {
                await using var conn = new MySqlConnection(connectionString);

                await conn.OpenAsync();

                string query = @"
                    INSERT INTO student_subjects
                    (student_id, subject_id, enrolled_on)
                    VALUES
                    (@studentId, @subjectId, @enrolledOn)";

                await using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@subjectId", subjectId);
                cmd.Parameters.AddWithValue("@enrolledOn", DateTime.Today);

                return await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
                {
                    MessageBox.Show(
                        "Database Error:\n\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return 0;
                }
            
        }

        public async Task<int> Delete(string studentId)
        {
            try
            {
                await using var conn = new MySqlConnection(connectionString);

                await conn.OpenAsync();

                string query = @"
                    DELETE FROM student_subjects
                    WHERE student_id = @studentId";

                await using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@studentId", studentId);

                return await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error deleting subjects:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return 0;
            }
            
        }
    }
}