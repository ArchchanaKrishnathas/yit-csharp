using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void frmComboBox_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    MessageBox.Show(cmbSubject.SelectedItem.ToString());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Please select a subject from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            //---------Use SelectedItem to combo box and assign to another combo box-----------------
            //string selectSubject = cmbSubject.SelectedItem?.ToString();

            //cmbSelectedSubject.SelectedItem = selectSubject;

            //MessageBox.Show(cmbSubject.SelectedItem.ToString());


            //----------------Use SelectedIndex to combo box and assign to another combo box-----------------
            string selectSubject = cmbSubject.SelectedIndex.ToString();

            if (cmbSubject.SelectedIndex != -1)
            {
                cmbSelectedSubject.SelectedIndex = int.Parse(selectSubject);
                MessageBox.Show(cmbSubject.SelectedIndex.ToString());
            }
            else
            {
                MessageBox.Show("Please select a subject from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
