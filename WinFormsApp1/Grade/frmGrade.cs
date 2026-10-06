using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.BLL;

namespace WinFormsApp1.Grade
{
    public partial class frmGrade : Form
    {

        private readonly GradeBll gradeBll = new GradeBll();
        public frmGrade()
        {
            InitializeComponent();
        }
        private async void btnAllGrades_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable gradesTable = await gradeBll.GetAllAsync();
                dgvGrades.DataSource = gradesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load grades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
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

                    int affected = await gradeBll.DeleteAsync(id);

                    MessageBox.Show("Deleted successfully. Rows Affected: " + affected.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the table after deleting.
                    dgvGrades.DataSource = await gradeBll.GetAllAsync();
                }
                else
                {
                    MessageBox.Show("Grade not found. No rows were deleted.");
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGrade_Load(object sender, EventArgs e)
        {


        }
    }
} 