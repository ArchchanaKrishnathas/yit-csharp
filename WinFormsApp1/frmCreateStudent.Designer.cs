namespace WinFormsApp1
{
    partial class frmCreateStudent
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
            txtTeleNumber = new TextBox();
            label12 = new Label();
            txtBirthCertificateNumber = new TextBox();
            label11 = new Label();
            txtNicNumber = new TextBox();
            label10 = new Label();
            txtAdmissionNumber = new TextBox();
            label9 = new Label();
            txtGuardianNumber = new TextBox();
            label8 = new Label();
            dtpDob = new DateTimePicker();
            label7 = new Label();
            cmbMedium = new ComboBox();
            label6 = new Label();
            cmbHouseName = new ComboBox();
            label5 = new Label();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            gender = new Label();
            cmbGradeName = new ComboBox();
            label4 = new Label();
            txtAddress = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // txtTeleNumber
            // 
            txtTeleNumber.Location = new Point(195, 574);
            txtTeleNumber.Name = "txtTeleNumber";
            txtTeleNumber.Size = new Size(206, 27);
            txtTeleNumber.TabIndex = 88;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F);
            label12.Location = new Point(41, 574);
            label12.Name = "label12";
            label12.Size = new Size(70, 25);
            label12.TabIndex = 87;
            label12.Text = "Tele No";
            // 
            // txtBirthCertificateNumber
            // 
            txtBirthCertificateNumber.Location = new Point(195, 529);
            txtBirthCertificateNumber.Name = "txtBirthCertificateNumber";
            txtBirthCertificateNumber.Size = new Size(206, 27);
            txtBirthCertificateNumber.TabIndex = 86;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F);
            label11.Location = new Point(41, 528);
            label11.Name = "label11";
            label11.Size = new Size(155, 25);
            label11.TabIndex = 85;
            label11.Text = "Birth CertificateNo";
            // 
            // txtNicNumber
            // 
            txtNicNumber.Location = new Point(197, 487);
            txtNicNumber.Name = "txtNicNumber";
            txtNicNumber.Size = new Size(206, 27);
            txtNicNumber.TabIndex = 84;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F);
            label10.Location = new Point(41, 486);
            label10.Name = "label10";
            label10.Size = new Size(70, 25);
            label10.TabIndex = 83;
            label10.Text = "NIC No";
            // 
            // txtAdmissionNumber
            // 
            txtAdmissionNumber.Location = new Point(197, 443);
            txtAdmissionNumber.Name = "txtAdmissionNumber";
            txtAdmissionNumber.Size = new Size(206, 27);
            txtAdmissionNumber.TabIndex = 82;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F);
            label9.Location = new Point(41, 442);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 81;
            label9.Text = "Admission No";
            // 
            // txtGuardianNumber
            // 
            txtGuardianNumber.Location = new Point(197, 401);
            txtGuardianNumber.Name = "txtGuardianNumber";
            txtGuardianNumber.Size = new Size(206, 27);
            txtGuardianNumber.TabIndex = 80;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.Location = new Point(41, 400);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 79;
            label8.Text = "Guardian No";
            // 
            // dtpDob
            // 
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(197, 349);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(204, 27);
            dtpDob.TabIndex = 78;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(41, 350);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 77;
            label7.Text = "DOB";
            // 
            // cmbMedium
            // 
            cmbMedium.FormattingEnabled = true;
            cmbMedium.Items.AddRange(new object[] { "Tamil", "English" });
            cmbMedium.Location = new Point(197, 304);
            cmbMedium.Name = "cmbMedium";
            cmbMedium.Size = new Size(204, 28);
            cmbMedium.TabIndex = 76;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(41, 303);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 75;
            label6.Text = "Medium";
            // 
            // cmbHouseName
            // 
            cmbHouseName.FormattingEnabled = true;
            cmbHouseName.Location = new Point(195, 255);
            cmbHouseName.Name = "cmbHouseName";
            cmbHouseName.Size = new Size(206, 28);
            cmbHouseName.TabIndex = 74;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(41, 253);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 73;
            label5.Text = "House";
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(306, 219);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(78, 24);
            rdbFemale.TabIndex = 72;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(195, 219);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(63, 24);
            rdbMale.TabIndex = 71;
            rdbMale.TabStop = true;
            rdbMale.Text = "Male";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI", 10.8F);
            gender.Location = new Point(41, 216);
            gender.Name = "gender";
            gender.Size = new Size(69, 25);
            gender.TabIndex = 70;
            gender.Text = "Gender";
            // 
            // cmbGradeName
            // 
            cmbGradeName.FormattingEnabled = true;
            cmbGradeName.Location = new Point(195, 178);
            cmbGradeName.Name = "cmbGradeName";
            cmbGradeName.Size = new Size(206, 28);
            cmbGradeName.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(41, 180);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 68;
            label4.Text = "Grade";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(195, 128);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(206, 27);
            txtAddress.TabIndex = 67;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(195, 80);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(206, 27);
            txtLname.TabIndex = 66;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(195, 31);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(206, 27);
            txtFname.TabIndex = 65;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 127);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 64;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 78);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 63;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 30);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 62;
            label1.Text = "First Name";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Green;
            btnCreate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(306, 632);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 39);
            btnCreate.TabIndex = 89;
            btnCreate.Text = "Insert";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // frmCreateStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 681);
            Controls.Add(btnCreate);
            Controls.Add(txtTeleNumber);
            Controls.Add(label12);
            Controls.Add(txtBirthCertificateNumber);
            Controls.Add(label11);
            Controls.Add(txtNicNumber);
            Controls.Add(label10);
            Controls.Add(txtAdmissionNumber);
            Controls.Add(label9);
            Controls.Add(txtGuardianNumber);
            Controls.Add(label8);
            Controls.Add(dtpDob);
            Controls.Add(label7);
            Controls.Add(cmbMedium);
            Controls.Add(label6);
            Controls.Add(cmbHouseName);
            Controls.Add(label5);
            Controls.Add(rdbFemale);
            Controls.Add(rdbMale);
            Controls.Add(gender);
            Controls.Add(cmbGradeName);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCreateStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCreateStudent";
            Load += frmCreateStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTeleNumber;
        private Label label12;
        private TextBox txtBirthCertificateNumber;
        private Label label11;
        private TextBox txtNicNumber;
        private Label label10;
        private TextBox txtAdmissionNumber;
        private Label label9;
        private TextBox txtGuardianNumber;
        private Label label8;
        private DateTimePicker dtpDob;
        private Label label7;
        private ComboBox cmbMedium;
        private Label label6;
        private ComboBox cmbHouseName;
        private Label label5;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private Label gender;
        private ComboBox cmbGradeName;
        private Label label4;
        private TextBox txtAddress;
        private TextBox txtLname;
        private TextBox txtFname;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCreate;
    }
}