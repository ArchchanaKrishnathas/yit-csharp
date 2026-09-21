using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp1.DAL;
namespace WinFormsApp1.Grade
{
    public partial class frmEditGrade : Form
    {
        private string gradeId;
        public frmEditGrade(string id)
        {
            InitializeComponent();
            this.gradeId = id;
        }

        private async void frmEditGrade_Load(object sender, EventArgs e)
        {
            
            GradeDal gradeDal = new GradeDal();
            DataTable dt = await gradeDal.GetByID(gradeId);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Grade not found.");
                return;
            }

            DataRow dr = dt.Rows[0];

            txtGrId.Text = dr["id"].ToString();
            txtGrName.Text = dr["grade_name"].ToString();
            txtGrGroup.Text = dr["grade_group"].ToString();
            txtGrOrder.Text = dr["grade_order"].ToString();

            string colour = dr["colour"].ToString();

            if (!string.IsNullOrEmpty(colour))
            {
                pnlColor.BackColor = ColorTranslator.FromHtml(colour);

            }
        }


        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string colour = ColorTranslator.ToHtml(pnlColor.BackColor);

            GradeDal gradeDal = new GradeDal();

            try
            {
                int affectedRows = await gradeDal.Update(gradeId, txtGrName.Text, txtGrGroup.Text, txtGrOrder.Text, colour);

                MessageBox.Show("Updated successfully. Rows Affected: " + affectedRows, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information

                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the grade: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pnlColor.BackColor = colorDialog1.Color;
            }
        }

        private void txtGrId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
