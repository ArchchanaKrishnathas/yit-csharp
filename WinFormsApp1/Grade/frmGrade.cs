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

namespace WinFormsApp1.Grade
{
    public partial class frmGrade : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"]?.ConnectionString ?? string.Empty;
        public frmGrade()
        {
            InitializeComponent();
        }

        private void btnAllGrades_Click(object sender, EventArgs e)
        {
            GradeDal gradeDal = new GradeDal();
            DataTable gradesTable = gradeDal. GetAll();
            dgvGrades.DataSource = gradesTable;
        }

        
        private void btnShow_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvGrades.CurrentRow == null)
                {
                    MessageBox.Show("No Data Found");
                    return;
                }

                string id = dgvGrades.CurrentRow.Cells["id"].Value?.ToString();
                frmShowGrade f = new frmShowGrade(id);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvGrades.CurrentRow == null)
                {
                    MessageBox.Show("No Data Found");
                    return;
                }

                string id = dgvGrades.CurrentRow.Cells["id"].Value?.ToString();
                frmEditGrade f = new frmEditGrade(id);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 

            try
            {
                if (dgvGrades.CurrentRow == null)
                {
                    MessageBox.Show("no Data found");
                    return;
                }

                string id = dgvGrades.CurrentRow.Cells["id"].Value?.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this Grade?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    GradeDal gradeDal = new GradeDal();

                    int affected = gradeDal.Delete(id);

                    MessageBox.Show("Deleted successfully. Rows Affected: " + affected.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting grade: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
                      
            
        }

        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                frmCreateGrade f = new frmCreateGrade();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void frmGrade_Load(object sender, EventArgs e)
        {

        }
    }
}
