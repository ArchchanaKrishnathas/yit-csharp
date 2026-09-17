namespace WinFormsApp1
{
    partial class frmSubjects
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
            txtId = new TextBox();
            label10 = new Label();
            txtAdmissionNumber = new TextBox();
            label9 = new Label();
            txtFname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            lblHeading = new Label();
            clbSubjects = new CheckedListBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(164, 64);
            txtId.Name = "txtId";
            txtId.Size = new Size(217, 27);
            txtId.TabIndex = 84;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F);
            label10.Location = new Point(22, 63);
            label10.Name = "label10";
            label10.Size = new Size(96, 25);
            label10.TabIndex = 83;
            label10.Text = "Student ID";
            // 
            // txtAdmissionNumber
            // 
            txtAdmissionNumber.Location = new Point(164, 160);
            txtAdmissionNumber.Name = "txtAdmissionNumber";
            txtAdmissionNumber.Size = new Size(217, 27);
            txtAdmissionNumber.TabIndex = 82;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F);
            label9.Location = new Point(22, 160);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 81;
            label9.Text = "Admission No";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(164, 112);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(217, 27);
            txtFname.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 160);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 113);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 62;
            label1.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(22, 212);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 86;
            label3.Text = "Subjects";
            // 
            // lblHeading
            // 
            lblHeading.BackColor = Color.Teal;
            lblHeading.Dock = DockStyle.Top;
            lblHeading.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            lblHeading.ForeColor = Color.White;
            lblHeading.Location = new Point(0, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(416, 50);
            lblHeading.TabIndex = 87;
            lblHeading.Text = "Add Subjects";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clbSubjects
            // 
            clbSubjects.CheckOnClick = true;
            clbSubjects.FormattingEnabled = true;
            clbSubjects.Location = new Point(164, 212);
            clbSubjects.Name = "clbSubjects";
            clbSubjects.Size = new Size(217, 136);
            clbSubjects.TabIndex = 88;
            clbSubjects.SelectedIndexChanged += clbSubjects_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(268, 375);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 35);
            btnSave.TabIndex = 89;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmSubjects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 425);
            Controls.Add(btnSave);
            Controls.Add(clbSubjects);
            Controls.Add(lblHeading);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label10);
            Controls.Add(txtAdmissionNumber);
            Controls.Add(label9);
            Controls.Add(txtFname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSubjects";
            Text = "frmSubjects";
            Load += frmSubjects_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtId;
        private Label label10;
        private TextBox txtAdmissionNumber;
        private Label label9;
        private TextBox txtFname;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label lblHeading;
        private CheckedListBox clbSubjects;
        private Button btnSave;
    }
}