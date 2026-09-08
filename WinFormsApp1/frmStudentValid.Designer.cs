namespace WinFormsApp1
{
    partial class frmStudentValid
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
            lblHeading = new Label();
            btmFillData = new Button();
            rbFemale2 = new RadioButton();
            rbFemale = new RadioButton();
            rbMale2 = new RadioButton();
            rbMale = new RadioButton();
            dtpDob2 = new DateTimePicker();
            dtpDob = new DateTimePicker();
            txtNic2 = new TextBox();
            txtNic = new TextBox();
            txtTpNo2 = new TextBox();
            txtTpNo = new TextBox();
            txtAddress2 = new TextBox();
            txtLname2 = new TextBox();
            txtAddress = new TextBox();
            txtFname2 = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.BackColor = Color.Teal;
            lblHeading.Dock = DockStyle.Top;
            lblHeading.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.White;
            lblHeading.Location = new Point(0, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(696, 50);
            lblHeading.TabIndex = 31;
            lblHeading.Text = "Student Registration";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btmFillData
            // 
            btmFillData.BackColor = Color.FromArgb(0, 64, 64);
            btmFillData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmFillData.ForeColor = Color.White;
            btmFillData.Location = new Point(253, 393);
            btmFillData.Name = "btmFillData";
            btmFillData.Size = new Size(128, 39);
            btmFillData.TabIndex = 30;
            btmFillData.Text = "Fill Data";
            btmFillData.UseVisualStyleBackColor = false;
            btmFillData.Click += btmFillData_Click;
            // 
            // rbFemale2
            // 
            rbFemale2.AutoSize = true;
            rbFemale2.Location = new Point(560, 297);
            rbFemale2.Name = "rbFemale2";
            rbFemale2.Size = new Size(78, 24);
            rbFemale2.TabIndex = 29;
            rbFemale2.TabStop = true;
            rbFemale2.Text = "Female";
            rbFemale2.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(273, 297);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 28;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale2
            // 
            rbMale2.AutoSize = true;
            rbMale2.Location = new Point(437, 297);
            rbMale2.Name = "rbMale2";
            rbMale2.Size = new Size(63, 24);
            rbMale2.TabIndex = 27;
            rbMale2.TabStop = true;
            rbMale2.Text = "Male";
            rbMale2.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(150, 297);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 26;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDob2
            // 
            dtpDob2.Format = DateTimePickerFormat.Short;
            dtpDob2.Location = new Point(432, 180);
            dtpDob2.Name = "dtpDob2";
            dtpDob2.Size = new Size(236, 27);
            dtpDob2.TabIndex = 25;
            // 
            // dtpDob
            // 
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(150, 180);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(231, 27);
            dtpDob.TabIndex = 24;
            // 
            // txtNic2
            // 
            txtNic2.Location = new Point(437, 338);
            txtNic2.Name = "txtNic2";
            txtNic2.Size = new Size(231, 27);
            txtNic2.TabIndex = 22;
            // 
            // txtNic
            // 
            txtNic.Location = new Point(150, 338);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(231, 27);
            txtNic.TabIndex = 21;
            // 
            // txtTpNo2
            // 
            txtTpNo2.Location = new Point(437, 258);
            txtTpNo2.Name = "txtTpNo2";
            txtTpNo2.Size = new Size(231, 27);
            txtTpNo2.TabIndex = 20;
            // 
            // txtTpNo
            // 
            txtTpNo.Location = new Point(150, 258);
            txtTpNo.Name = "txtTpNo";
            txtTpNo.Size = new Size(231, 27);
            txtTpNo.TabIndex = 23;
            // 
            // txtAddress2
            // 
            txtAddress2.Location = new Point(437, 218);
            txtAddress2.Name = "txtAddress2";
            txtAddress2.Size = new Size(231, 27);
            txtAddress2.TabIndex = 19;
            // 
            // txtLname2
            // 
            txtLname2.Location = new Point(437, 124);
            txtLname2.Name = "txtLname2";
            txtLname2.Size = new Size(231, 27);
            txtLname2.TabIndex = 18;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 218);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(231, 27);
            txtAddress.TabIndex = 17;
            // 
            // txtFname2
            // 
            txtFname2.Location = new Point(437, 80);
            txtFname2.Name = "txtFname2";
            txtFname2.Size = new Size(231, 27);
            txtFname2.TabIndex = 16;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(150, 124);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(231, 27);
            txtLname.TabIndex = 15;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(150, 80);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(231, 27);
            txtFname.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(9, 258);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 12;
            label7.Text = "Telephone No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 337);
            label6.Name = "label6";
            label6.Size = new Size(44, 28);
            label6.TabIndex = 11;
            label6.Text = "NIC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(9, 297);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 10;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(9, 214);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 9;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(52, 28);
            label3.TabIndex = 8;
            label3.Text = "DOB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(9, 124);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 13;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(9, 80);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 7;
            label1.Text = "First Name";
            // 
            // frmStudentValid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 439);
            Controls.Add(lblHeading);
            Controls.Add(btmFillData);
            Controls.Add(rbFemale2);
            Controls.Add(rbFemale);
            Controls.Add(rbMale2);
            Controls.Add(rbMale);
            Controls.Add(dtpDob2);
            Controls.Add(dtpDob);
            Controls.Add(txtNic2);
            Controls.Add(txtNic);
            Controls.Add(txtTpNo2);
            Controls.Add(txtTpNo);
            Controls.Add(txtAddress2);
            Controls.Add(txtLname2);
            Controls.Add(txtAddress);
            Controls.Add(txtFname2);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStudentValid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStudentValid";
            Load += frmStudentValid_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Button btmFillData;
        private RadioButton rbFemale2;
        private RadioButton rbFemale;
        private RadioButton rbMale2;
        private RadioButton rbMale;
        private DateTimePicker dtpDob2;
        private DateTimePicker dtpDob;
        private TextBox txtNic2;
        private TextBox txtNic;
        private TextBox txtTpNo2;
        private TextBox txtTpNo;
        private TextBox txtAddress2;
        private TextBox txtLname2;
        private TextBox txtAddress;
        private TextBox txtFname2;
        private TextBox txtLname;
        private TextBox txtFname;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}