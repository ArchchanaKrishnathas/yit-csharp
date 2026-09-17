namespace WinFormsApp1
{
    partial class frmConnect
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
            btnConnect = new Button();
            btnStudents = new Button();
            dgvStudents = new DataGridView();
            btnShow = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtAddress = new TextBox();
            label4 = new Label();
            cmbGradeName = new ComboBox();
            allGrades = new Button();
            button1 = new Button();
            button2 = new Button();
            gender = new Label();
            rdbMale = new RadioButton();
            rdbFemale = new RadioButton();
            label5 = new Label();
            cmbHouseName = new ComboBox();
            label6 = new Label();
            cmbMedium = new ComboBox();
            label7 = new Label();
            dtpDob = new DateTimePicker();
            label8 = new Label();
            txtFam = new TextBox();
            label9 = new Label();
            txtAdmissionNumber = new TextBox();
            label10 = new Label();
            txtNicNumber = new TextBox();
            label11 = new Label();
            txtBirthCertificateNumber = new TextBox();
            label12 = new Label();
            txtTeleNumber = new TextBox();
            btnDbShow = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnInsert = new Button();
            btnSubjects = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConnect.Location = new Point(12, 31);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(114, 41);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnStudents
            // 
            btnStudents.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudents.Location = new Point(651, 30);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(114, 41);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "All Students";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 95);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(753, 623);
            dgvStudents.TabIndex = 2;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(252, 31);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(114, 41);
            btnShow.TabIndex = 3;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(786, 95);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(788, 143);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 5;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(788, 191);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 6;
            label3.Text = "Address";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(946, 95);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(206, 27);
            txtFname.TabIndex = 7;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(946, 140);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(206, 27);
            txtLname.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(946, 185);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(206, 27);
            txtAddress.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(788, 239);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 10;
            label4.Text = "Grade";
            // 
            // cmbGradeName
            // 
            cmbGradeName.FormattingEnabled = true;
            cmbGradeName.Location = new Point(946, 230);
            cmbGradeName.Name = "cmbGradeName";
            cmbGradeName.Size = new Size(206, 28);
            cmbGradeName.TabIndex = 11;
            cmbGradeName.SelectedIndexChanged += cmbGradeName_SelectedIndexChanged;
            // 
            // allGrades
            // 
            allGrades.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allGrades.Location = new Point(132, 30);
            allGrades.Name = "allGrades";
            allGrades.Size = new Size(114, 41);
            allGrades.TabIndex = 3;
            allGrades.Text = "  All Grades";
            allGrades.UseVisualStyleBackColor = true;
            allGrades.Click += btnLoadGrade;
            // 
            // button1
            // 
            button1.Location = new Point(948, 275);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1077, 275);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 13;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI", 10.8F);
            gender.Location = new Point(788, 318);
            gender.Name = "gender";
            gender.Size = new Size(69, 25);
            gender.TabIndex = 14;
            gender.Text = "Gender";
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(948, 320);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(63, 24);
            rdbMale.TabIndex = 15;
            rdbMale.TabStop = true;
            rdbMale.Text = "Male";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(1074, 320);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(78, 24);
            rdbFemale.TabIndex = 16;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(788, 363);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 17;
            label5.Text = "House";
            // 
            // cmbHouseName
            // 
            cmbHouseName.FormattingEnabled = true;
            cmbHouseName.Location = new Point(946, 354);
            cmbHouseName.Name = "cmbHouseName";
            cmbHouseName.Size = new Size(206, 28);
            cmbHouseName.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(786, 408);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 19;
            label6.Text = "Medium";
            // 
            // cmbMedium
            // 
            cmbMedium.FormattingEnabled = true;
            cmbMedium.Items.AddRange(new object[] { "Tamil", "English" });
            cmbMedium.Location = new Point(946, 401);
            cmbMedium.Name = "cmbMedium";
            cmbMedium.Size = new Size(204, 28);
            cmbMedium.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(786, 453);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 21;
            label7.Text = "DOB";
            // 
            // dtpDob
            // 
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(948, 448);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(204, 27);
            dtpDob.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.Location = new Point(786, 498);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 23;
            label8.Text = "Family ID";
            // 
            // txtFam
            // 
            txtFam.Location = new Point(948, 494);
            txtFam.Name = "txtFam";
            txtFam.Size = new Size(206, 27);
            txtFam.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F);
            label9.Location = new Point(786, 540);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 25;
            label9.Text = "Admission No";
            // 
            // txtAdmissionNumber
            // 
            txtAdmissionNumber.Location = new Point(948, 540);
            txtAdmissionNumber.Name = "txtAdmissionNumber";
            txtAdmissionNumber.Size = new Size(206, 27);
            txtAdmissionNumber.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F);
            label10.Location = new Point(786, 588);
            label10.Name = "label10";
            label10.Size = new Size(70, 25);
            label10.TabIndex = 27;
            label10.Text = "NIC No";
            // 
            // txtNicNumber
            // 
            txtNicNumber.Location = new Point(948, 586);
            txtNicNumber.Name = "txtNicNumber";
            txtNicNumber.Size = new Size(206, 27);
            txtNicNumber.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F);
            label11.Location = new Point(786, 632);
            label11.Name = "label11";
            label11.Size = new Size(160, 25);
            label11.TabIndex = 29;
            label11.Text = "Birth Certificate No";
            // 
            // txtBirthCertificateNumber
            // 
            txtBirthCertificateNumber.Location = new Point(946, 632);
            txtBirthCertificateNumber.Name = "txtBirthCertificateNumber";
            txtBirthCertificateNumber.Size = new Size(206, 27);
            txtBirthCertificateNumber.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F);
            label12.Location = new Point(786, 678);
            label12.Name = "label12";
            label12.Size = new Size(70, 25);
            label12.TabIndex = 31;
            label12.Text = "Tele No";
            // 
            // txtTeleNumber
            // 
            txtTeleNumber.Location = new Point(946, 678);
            txtTeleNumber.Name = "txtTeleNumber";
            txtTeleNumber.Size = new Size(206, 27);
            txtTeleNumber.TabIndex = 32;
            // 
            // btnDbShow
            // 
            btnDbShow.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDbShow.Location = new Point(372, 31);
            btnDbShow.Name = "btnDbShow";
            btnDbShow.Size = new Size(109, 41);
            btnDbShow.TabIndex = 33;
            btnDbShow.Text = "DB Show";
            btnDbShow.UseVisualStyleBackColor = true;
            btnDbShow.Click += btnDbShow_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Teal;
            btnEdit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(1053, 30);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(101, 41);
            btnEdit.TabIndex = 34;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(946, 30);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 40);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.LightGreen;
            btnInsert.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(839, 29);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(101, 41);
            btnInsert.TabIndex = 36;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnSubjects
            // 
            btnSubjects.Font = new Font("Segoe UI", 10.8F);
            btnSubjects.Location = new Point(487, 31);
            btnSubjects.Name = "btnSubjects";
            btnSubjects.Size = new Size(126, 41);
            btnSubjects.TabIndex = 37;
            btnSubjects.Text = "Add Subjects";
            btnSubjects.UseVisualStyleBackColor = true;
            btnSubjects.Click += btnSubjects_Click;
            // 
            // frmConnect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 729);
            Controls.Add(btnSubjects);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnDbShow);
            Controls.Add(txtTeleNumber);
            Controls.Add(label12);
            Controls.Add(txtBirthCertificateNumber);
            Controls.Add(label11);
            Controls.Add(txtNicNumber);
            Controls.Add(label10);
            Controls.Add(txtAdmissionNumber);
            Controls.Add(label9);
            Controls.Add(txtFam);
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
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbGradeName);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(allGrades);
            Controls.Add(btnShow);
            Controls.Add(dgvStudents);
            Controls.Add(btnStudents);
            Controls.Add(btnConnect);
            Name = "frmConnect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConnect";
            Load += frmConnect_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private Button btnStudents;
        private DataGridView dgvStudents;
        private Button btnShow;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtAddress;
        private Label label4;
        private ComboBox cmbGradeName;
        private Button allGrades;
        private Button button1;
        private Button button2;
        private Label gender;
        private RadioButton rdbMale;
        private RadioButton rdbFemale;
        private Label label5;
        private ComboBox cmbHouseName;
        private Label label6;
        private ComboBox cmbMedium;
        private Label label7;
        private DateTimePicker dtpDob;
        private Label label8;
        private TextBox txtFam;
        private Label label9;
        private TextBox txtAdmissionNumber;
        private Label label10;
        private TextBox txtNicNumber;
        private Label label11;
        private TextBox txtBirthCertificateNumber;
        private Label label12;
        private TextBox txtTeleNumber;
        private Button btnDbShow;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnInsert;
        private Button btnSubjects;
    }
}