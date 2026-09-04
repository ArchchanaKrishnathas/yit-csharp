namespace WinFormsApp1
{
    partial class frmLabelShow
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
            components = new System.ComponentModel.Container();
            lblShowFullName = new Label();
            lblLname = new Label();
            lblFname = new Label();
            txtFullName = new TextBox();
            lblFullNameHeading = new Label();
            txtlastName = new TextBox();
            txtFirstName = new TextBox();
            btnFullName = new Button();
            lblFullName = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblShowFullName
            // 
            lblShowFullName.AutoSize = true;
            lblShowFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblShowFullName.Location = new Point(12, 180);
            lblShowFullName.Name = "lblShowFullName";
            lblShowFullName.Size = new Size(100, 28);
            lblShowFullName.TabIndex = 7;
            lblShowFullName.Text = "Full Name";
            // 
            // lblLname
            // 
            lblLname.AutoSize = true;
            lblLname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLname.Location = new Point(12, 127);
            lblLname.Name = "lblLname";
            lblLname.Size = new Size(103, 28);
            lblLname.TabIndex = 8;
            lblLname.Text = "Last Name";
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFname.Location = new Point(12, 79);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(106, 28);
            lblFname.TabIndex = 9;
            lblFname.Text = "First Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(118, 184);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(231, 27);
            txtFullName.TabIndex = 10;
            // 
            // lblFullNameHeading
            // 
            lblFullNameHeading.BackColor = Color.Teal;
            lblFullNameHeading.Dock = DockStyle.Top;
            lblFullNameHeading.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullNameHeading.ForeColor = Color.White;
            lblFullNameHeading.Location = new Point(0, 0);
            lblFullNameHeading.Name = "lblFullNameHeading";
            lblFullNameHeading.Size = new Size(366, 50);
            lblFullNameHeading.TabIndex = 11;
            lblFullNameHeading.Text = "Full Name";
            lblFullNameHeading.TextAlign = ContentAlignment.MiddleCenter;
            lblFullNameHeading.Click += lblFullName_Click;
            // 
            // txtlastName
            // 
            txtlastName.Location = new Point(118, 131);
            txtlastName.Name = "txtlastName";
            txtlastName.Size = new Size(228, 27);
            txtlastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(118, 83);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(225, 27);
            txtFirstName.TabIndex = 5;
            // 
            // btnFullName
            // 
            btnFullName.BackColor = Color.DarkSeaGreen;
            btnFullName.Location = new Point(203, 281);
            btnFullName.Name = "btnFullName";
            btnFullName.Size = new Size(146, 29);
            btnFullName.TabIndex = 12;
            btnFullName.Text = "Show Full Name";
            btnFullName.UseVisualStyleBackColor = false;
            btnFullName.Click += btnFullName_Click;
            // 
            // lblFullName
            // 
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.DarkRed;
            lblFullName.Location = new Point(73, 235);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(256, 27);
            lblFullName.TabIndex = 13;
            lblFullName.Click += lblFullName_Click_1;
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // frmLabelShow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 335);
            Controls.Add(lblFullName);
            Controls.Add(lblShowFullName);
            Controls.Add(lblLname);
            Controls.Add(lblFname);
            Controls.Add(txtFullName);
            Controls.Add(lblFullNameHeading);
            Controls.Add(txtlastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnFullName);
            Name = "frmLabelShow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLabelShow";
            Load += frmLabelShow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShowFullName;
        private Label lblLname;
        private Label lblFname;
        private TextBox txtFullName;
        private Label lblFullNameHeading;
        private TextBox txtlastName;
        private TextBox txtFirstName;
        private Button btnFullName;
        private Label lblFullName;
        private System.Windows.Forms.Timer timer1;
    }
}