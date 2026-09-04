using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmCalculate : Form
    {
        private double number1, number2, result;

        public frmCalculate()
        {
            InitializeComponent();
            txtResult.ReadOnly = true;
            lblError.Text = "";
            timer1.Interval = 3000;
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                txtResult.Clear();

                if (string.IsNullOrEmpty(txtNumber1.Text))
                {
                    lblError.Text = "Please Enter Number1";
                    txtNumber1.Focus();
                    timer1.Start();
                    return;
                }

                if (string.IsNullOrEmpty(txtNumber2.Text))
                {
                    lblError.Text = "Please Enter Number2";
                    txtNumber2.Focus();
                    timer1.Start();
                    return;
                }

                if (!double.TryParse(txtNumber1.Text, out number1))
                {
                    lblError.Text = "Number1 must be a valid number.";
                    txtNumber1.Focus();
                    timer1.Start();
                    txtNumber1.SelectAll();
                    return;
                }

                if (!double.TryParse(txtNumber2.Text, out number2))
                {
                    lblError.Text = "Number2 must be a valid number.";
                    txtNumber2.Focus();
                    timer1.Start();
                    txtNumber2.SelectAll();
                    return;
                }

                result = number1 - number2;
                txtResult.Text = result.ToString();

            }
            catch (Exception ex)
            {
                lblError.Text = "An error occurred: " + ex.Message;
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                txtResult.Clear();

                if (string.IsNullOrEmpty(txtNumber1.Text))
                {
                    lblError.Text = "Please enter Number1";
                    txtNumber1.Focus();
                    timer1.Start();
                    return;
                }

                if (string.IsNullOrEmpty(txtNumber2.Text))
                {
                    lblError.Text = "Please enter Number2";
                    txtNumber2.Focus();
                    timer1.Start();
                    return;
                }

                number1 = Convert.ToDouble(txtNumber1.Text);
                number2 = Convert.ToDouble(txtNumber2.Text);

                result = number1 + number2;
                txtResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                lblError.Text = "Please enter valid numbers";
                timer1.Start();
            }
            catch (Exception ex)
            {
                lblError.Text = "An error occurred: " + ex.Message;
                timer1.Start();
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                txtResult.Clear();

                if (string.IsNullOrEmpty(txtNumber1.Text))
                {
                    lblError.Text = "Please enter Number1";
                    txtNumber1.Focus();
                    timer1.Start();
                    return;
                }

                if (string.IsNullOrEmpty(txtNumber2.Text))
                {
                    lblError.Text = "Please enter Number2";
                    txtNumber2.Focus();
                    timer1.Start();
                    return;
                }

                if (!double.TryParse(txtNumber1.Text, out number1))
                {
                    lblError.Text = "Number1 must be a valid number.";
                    txtNumber1.Focus();
                    timer1.Start();
                    txtNumber1.SelectAll();
                    return;
                }

                if (!double.TryParse(txtNumber2.Text, out number2))
                {
                    lblError.Text = "Number2 must be a valid number.";
                    txtNumber2.Focus();
                    timer1.Start();
                    txtNumber2.SelectAll();
                    return;
                }

                result = number1 * number2;
                txtResult.Text = result.ToString();

            }
            catch (Exception ex)
            {
                lblError.Text = "An error occurred: " + ex.Message;
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                txtResult.Clear();

                if (string.IsNullOrEmpty(txtNumber1.Text))
                {
                    lblError.Text = "Please enter Number1";
                    txtNumber1.Focus();
                    timer1.Start();
                    return;
                }

                if (string.IsNullOrEmpty(txtNumber2.Text))
                {
                    lblError.Text = "Please enter Number2";
                    txtNumber2.Focus();
                    timer1.Start();
                    return;
                }

                if (!double.TryParse(txtNumber1.Text, out number1))
                {
                    lblError.Text = "Number1 must be a valid number.";
                    txtNumber1.Focus();
                    timer1.Start();
                    txtNumber1.SelectAll();
                    return;
                }

                if (!double.TryParse(txtNumber2.Text, out number2))
                {
                    lblError.Text = "Number2 must be a valid number.";
                    txtNumber2.Focus();
                    timer1.Start();
                    txtNumber2.SelectAll();
                    return;
                }

                if (number2 == 0)
                {
                    lblError.Text = "zero is not allowed";
                    txtNumber2.Focus();
                    timer1.Start();
                    txtNumber2.SelectAll();
                    return;
                }

                result = number1 / number2;
                txtResult.Text = result.ToString();

            }
            catch (Exception ex)
            {
                lblError.Text = "An error occurred: " + ex.Message;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblError.Text = "";
            timer1.Stop();
        }
    }
}
