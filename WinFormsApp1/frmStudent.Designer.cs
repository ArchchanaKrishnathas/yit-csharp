namespace WinFormsApp1
{
    partial class frmStudent
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtAddress = new TextBox();
            txtTpNo = new TextBox();
            txtNic = new TextBox();
            dtpDob = new DateTimePicker();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            txtFname2 = new TextBox();
            txtLname2 = new TextBox();
            txtAddress2 = new TextBox();
            txtTpNo2 = new TextBox();
            txtNic2 = new TextBox();
            dtpDob2 = new DateTimePicker();
            rbMale2 = new RadioButton();
            rbFemale2 = new RadioButton();
            btmFillData = new Button();
            lblHeading = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(9, 74);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(9, 118);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(52, 28);
            label3.TabIndex = 0;
            label3.Text = "DOB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(9, 208);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 0;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(9, 291);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 0;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 331);
            label6.Name = "label6";
            label6.Size = new Size(44, 28);
            label6.TabIndex = 0;
            label6.Text = "NIC";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(9, 252);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 0;
            label7.Text = "Telephone No";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(150, 74);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(231, 27);
            txtFname.TabIndex = 1;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(150, 118);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(231, 27);
            txtLname.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 212);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(231, 27);
            txtAddress.TabIndex = 1;
            // 
            // txtTpNo
            // 
            txtTpNo.Location = new Point(150, 252);
            txtTpNo.Name = "txtTpNo";
            txtTpNo.Size = new Size(231, 27);
            txtTpNo.TabIndex = 1;
            // 
            // txtNic
            // 
            txtNic.Location = new Point(150, 332);
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(231, 27);
            txtNic.TabIndex = 1;
            // 
            // dtpDob
            // 
            dtpDob.Format = DateTimePickerFormat.Short;
            dtpDob.Location = new Point(150, 174);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(231, 27);
            dtpDob.TabIndex = 2;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(150, 291);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 3;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(273, 291);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 4;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // txtFname2
            // 
            txtFname2.Location = new Point(437, 74);
            txtFname2.Name = "txtFname2";
            txtFname2.Size = new Size(231, 27);
            txtFname2.TabIndex = 1;
            // 
            // txtLname2
            // 
            txtLname2.Location = new Point(437, 118);
            txtLname2.Name = "txtLname2";
            txtLname2.Size = new Size(231, 27);
            txtLname2.TabIndex = 1;
            // 
            // txtAddress2
            // 
            txtAddress2.Location = new Point(437, 212);
            txtAddress2.Name = "txtAddress2";
            txtAddress2.Size = new Size(231, 27);
            txtAddress2.TabIndex = 1;
            // 
            // txtTpNo2
            // 
            txtTpNo2.Location = new Point(437, 252);
            txtTpNo2.Name = "txtTpNo2";
            txtTpNo2.Size = new Size(231, 27);
            txtTpNo2.TabIndex = 1;
            // 
            // txtNic2
            // 
            txtNic2.Location = new Point(437, 332);
            txtNic2.Name = "txtNic2";
            txtNic2.Size = new Size(231, 27);
            txtNic2.TabIndex = 1;
            // 
            // dtpDob2
            // 
            dtpDob2.Format = DateTimePickerFormat.Short;
            dtpDob2.Location = new Point(432, 174);
            dtpDob2.Name = "dtpDob2";
            dtpDob2.Size = new Size(236, 27);
            dtpDob2.TabIndex = 2;
            // 
            // rbMale2
            // 
            rbMale2.AutoSize = true;
            rbMale2.Location = new Point(437, 291);
            rbMale2.Name = "rbMale2";
            rbMale2.Size = new Size(63, 24);
            rbMale2.TabIndex = 3;
            rbMale2.TabStop = true;
            rbMale2.Text = "Male";
            rbMale2.UseVisualStyleBackColor = true;
            // 
            // rbFemale2
            // 
            rbFemale2.AutoSize = true;
            rbFemale2.Location = new Point(560, 291);
            rbFemale2.Name = "rbFemale2";
            rbFemale2.Size = new Size(78, 24);
            rbFemale2.TabIndex = 4;
            rbFemale2.TabStop = true;
            rbFemale2.Text = "Female";
            rbFemale2.UseVisualStyleBackColor = true;
            // 
            // btmFillData
            // 
            btmFillData.BackColor = Color.FromArgb(0, 64, 64);
            btmFillData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmFillData.ForeColor = Color.White;
            btmFillData.Location = new Point(253, 387);
            btmFillData.Name = "btmFillData";
            btmFillData.Size = new Size(128, 39);
            btmFillData.TabIndex = 5;
            btmFillData.Text = "Fill Data";
            btmFillData.UseVisualStyleBackColor = false;
            btmFillData.Click += btmFillData_Click;
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
            lblHeading.TabIndex = 6;
            lblHeading.Text = "Student Registration";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
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
            Name = "frmStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStudent";
            Load += frmStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtAddress;
        private TextBox txtTpNo;
        private TextBox txtNic;
        private DateTimePicker dtpDob;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private TextBox txtFname2;
        private TextBox txtLname2;
        private TextBox txtAddress2;
        private TextBox txtTpNo2;
        private TextBox txtNic2;
        private DateTimePicker dtpDob2;
        private RadioButton rbMale2;
        private RadioButton rbFemale2;
        private Button btmFillData;
        private Label lblHeading;
    }
}