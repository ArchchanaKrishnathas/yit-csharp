using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.DAL;

namespace WinFormsApp1
{
    public partial class frmSubjects : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        private string studentId;
        public frmSubjects(string id)
        {
            InitializeComponent();
            this.studentId = id;
        }

        private async void frmSubjects_Load(object sender, EventArgs e)
        {
            StudentDal studentDal = new StudentDal();
            DataTable dt = await studentDal.GetByID(studentId);

            DataRow dr = dt.Rows[0];

            txtId.Text = dr["id"].ToString();
            txtFname.Text = dr["first_name"].ToString();
            txtAdmissionNumber.Text = dr["admission_number"].ToString();

            // Load subjects into the list box
            SubjectDal subjectDal = new SubjectDal();
            DataTable dtSubjects = subjectDal.GetAll();

            clbSubjects.DataSource = dtSubjects;
            clbSubjects.DisplayMember = "subject_name";
            clbSubjects.ValueMember = "id";


            // Load student's existing subjects
            StudentSubjectDal studentSubjectDal = new StudentSubjectDal();
            DataTable dtStudentSubjects = studentSubjectDal.GetByStudentId(studentId);

            // Check existing subjects
            foreach (DataRow row in dtStudentSubjects.Rows)
            {
                string subjectId = row["subject_id"].ToString();

                for (int i = 0; i < clbSubjects.Items.Count; i++)
                {
                    DataRowView item = (DataRowView)clbSubjects.Items[i];

                    if (item["id"].ToString() == subjectId)
                    {
                        clbSubjects.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        private void clbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clbSubjects.CheckedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select at least one subject.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            StudentSubjectDal studentSubjectDal = new StudentSubjectDal();

            // Remove existing subjects for this student
            studentSubjectDal.Delete(studentId);

            // Save currently checked subjects
            int savedCount = 0;

            foreach (DataRowView item in clbSubjects.CheckedItems)
            {
                string subjectId = item["id"].ToString();

                int result = studentSubjectDal.Store(studentId, subjectId);

                if (result > 0)
                {
                    savedCount++;
                }
            }

            MessageBox.Show(
                savedCount + " subject(s) saved successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
