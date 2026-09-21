using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp1.DAL;

namespace WinFormsApp1.Grade
{
    public partial class frmShowGrade : Form
    {
        private string gradeId;
        public frmShowGrade(string id)
        {
            InitializeComponent();
            this.gradeId = id;
        }

        private async void frmShowGrade_Load(object sender, EventArgs e)
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

       

    }
}
