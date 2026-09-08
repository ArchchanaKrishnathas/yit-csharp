namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            btnFullName = new Button();
            txtFirstName = new TextBox();
            lblFullName = new Label();
            lblFname = new Label();
            lblLname = new Label();
            txtlastName = new TextBox();
            txtFullName = new TextBox();
            lblShowFullName = new Label();
            SuspendLayout();
            // 
            // btnFullName
            // 
            btnFullName.BackColor = Color.Gray;
            btnFullName.Location = new Point(203, 223);
            btnFullName.Name = "btnFullName";
            btnFullName.Size = new Size(146, 29);
            btnFullName.TabIndex = 4;
            btnFullName.Text = "Show Full Name";
            btnFullName.UseVisualStyleBackColor = false;
            btnFullName.Click += btnSave_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(118, 70);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(225, 27);
            txtFirstName.TabIndex = 0;
            // 
            // lblFullName
            // 
            lblFullName.BackColor = Color.Teal;
            lblFullName.Dock = DockStyle.Top;
            lblFullName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.White;
            lblFullName.Location = new Point(0, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(366, 50);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            lblFullName.TextAlign = ContentAlignment.MiddleCenter;
            lblFullName.Click += lblFullName_Click;
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFname.Location = new Point(12, 66);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(106, 28);
            lblFname.TabIndex = 2;
            lblFname.Text = "First Name";
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLname.Location = new Point(12, 114);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(103, 28);
            lblLname.TabIndex = 2;
            lblLname.Text = "Last Name";
            // 
            // txtlastName
            // 
            txtlastName.Location = new Point(118, 118);
            txtlastName.Name = "txtlastName";
            txtlastName.Size = new Size(228, 27);
            txtlastName.TabIndex = 1;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(118, 171);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(231, 27);
            txtFullName.TabIndex = 2;
            // 
            // lblShowFullName
            // 
            lblShowFullName.AutoSize = true;
            lblShowFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShowFullName.Location = new Point(12, 167);
            lblShowFullName.Name = "lblShowFullName";
            lblShowFullName.Size = new Size(100, 28);
            lblShowFullName.TabIndex = 2;
            lblShowFullName.Text = "Full Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 279);
            Controls.Add(lblShowFullName);
            Controls.Add(lblLname);
            Controls.Add(lblFname);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(txtlastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnFullName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FullNameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFullName;
        private TextBox txtFirstName;
        private Label lblFullName;
        private Label lblFname;
        private Label lblLname;
        private TextBox txtlastName;
        private TextBox txtFullName;
        private Label lblShowFullName;
    }
}