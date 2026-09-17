using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WinFormsApp1.DAL
{
    public class StudentSubjectDal
    {
        string connString = "Server=localhost;Database=school;Uid=root;Pwd=;port=3307";

        public int Store(string studentId, string subjectId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO student_subjects
                        (student_id, subject_id, enrolled_on)
                        VALUES
                        (@studentId, @subjectId, @enrolledOn)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@subjectId", subjectId);
                        cmd.Parameters.AddWithValue("@enrolledOn", DateTime.Today);

                        return cmd.ExecuteNonQuery();
                    }
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
        }
    }
}