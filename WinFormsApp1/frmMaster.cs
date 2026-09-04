using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Grade;

namespace WinFormsApp1
{
    public partial class frmMaster : Form
    {
        public frmMaster()
        {
            InitializeComponent();
        }

        private void btnFrmLabelShow_Click(object sender, EventArgs e)
        {
            frmLabelShow fs = new frmLabelShow();
            fs.ShowDialog();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnFrmStudent_Click(object sender, EventArgs e)
        {
            frmStudent vs = new frmStudent();
            vs.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidation_Click(object sender, EventArgs e)
        {
            frmStudentValid vs = new frmStudentValid();
            vs.ShowDialog();
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            frmComboBox cb = new frmComboBox();
            cb.ShowDialog();
        }

        private void btnTryCatch_Click(object sender, EventArgs e)
        {
            frmCalculate cal = new frmCalculate();
            cal.ShowDialog();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            frmConnect fc = new frmConnect();
            fc.ShowDialog();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            frmGrade fg = new frmGrade();
            fg.ShowDialog();
        }
    }
}
