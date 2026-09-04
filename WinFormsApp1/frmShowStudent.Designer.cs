namespace WinFormsApp1
{
    partial class frmShowStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLname = new TextBox();
            txtFname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            cmbGradeName = new ComboBox();
            label5 = new Label();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            cmbHouseName = new ComboBox();
            label6 = new Label();
            cmbMedium = new ComboBox();
            label7 = new Label();
            dtpDob = new DateTimePicker();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtLname
            // 
            txtLname.Location = new Point(152, 91);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(202, 27);
            txtLname.TabIndex = 14;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(152, 47);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(202, 27);
            txtFname.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 93);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 11;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 46);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 10;
            label1.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 143);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 11;
            label3.Text = "Address";
            label3.Click += label3_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 144);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(202, 27);
            txtAddress.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(35, 242);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 16;
            label4.Text = "Grade";
            // 
            // cmbGradeName
            // 
            cmbGradeName.FormattingEnabled = true;
            cmbGradeName.Location = new Point(152, 243);
            cmbGradeName.Name = "cmbGradeName";
            cmbGradeName.Size = new Size(202, 28);
            cmbGradeName.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(33, 197);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 16;
            label5.Text = "Gender";
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(241, 199);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(78, 24);
            rdbFemale.TabIndex = 19;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(152, 199);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(63, 24);
            rdbMale.TabIndex = 18;
            rdbMale.TabStop = true;
            rdbMale.Text = "Male";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // cmbHouseName
            // 
            cmbHouseName.FormattingEnabled = true;
            cmbHouseName.Location = new Point(152, 291);
            cmbHouseName.Name = "cmbHouseName";
            cmbHouseName.Size = new Size(202, 28);
            cmbHouseName.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(35, 290);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 20;
            label6.Text = "House";
            // 
            // cmbMedium
            // 
            cmbMedium.FormattingEnabled = true;
            cmbMedium.Items.AddRange(new object[] { "Tamil", "English" });
            cmbMedium.Location = new Point(152, 335);
            cmbMedium.Name = "cmbMedium";
            cmbMedium.Size = new Size(204, 28);
            cmbMedium.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(35, 334);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 22;
            label7.Text = "Medium";
            // 
            // dtpDob
            // 
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(152, 376);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(204, 27);
            dtpDob.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.Location = new Point(35, 378);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 24;
            label8.Text = "DOB";
            // 
            // frmShowStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 430);
            Controls.Add(dtpDob);
            Controls.Add(label8);
            Controls.Add(cmbMedium);
            Controls.Add(label7);
            Controls.Add(cmbHouseName);
            Controls.Add(label6);
            Controls.Add(rdbFemale);
            Controls.Add(rdbMale);
            Controls.Add(cmbGradeName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmShowStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmShowStudent";
            Load += frmShowStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtLname;
        private TextBox txtFname;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private ComboBox cmbGradeName;
        private Label label5;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private ComboBox cmbHouseName;
        private Label label6;
        private ComboBox cmbMedium;
        private Label label7;
        private DateTimePicker dtpDob;
        private Label label8;
    }
}