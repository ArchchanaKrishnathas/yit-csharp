namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Save button clicked!");

            //string name = txtName.Text;
            //MessageBox.Show("Hi " + name);

            /*
            string fname = txtFistName.Text;
            string lname = txtlastName.Text;
            string fullName = $"{fname} {lname}";
            txtFullName.Text = fullName;
            MessageBox.Show($"Full Name: {fullName}","Full Name",MessageBoxButtons.OK,MessageBoxIcon.Information);  
            */

            //Validation

            /*
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtlastName.Text))
            {
                MessageBox.Show("Please enter both First and Last name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            */

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please Enter First name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtlastName.Text))
            {
                MessageBox.Show("Please Enter Last name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlastName.Focus();
                return;
            }

            string fname = txtFirstName.Text;
            string lname = txtlastName.Text;

            string fullName = $"{fname} {lname}";
            txtFullName.Text = fullName;
            MessageBox.Show($"Full Name: {fullName}", "Full Name", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtFistName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }
    }
}
