namespace WinFormsApp1
{
    partial class frmMaster
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
            btnForm1 = new Button();
            btnFrmLabelShow = new Button();
            btnFrmStudent = new Button();
            lblMaster = new Label();
            btnValidation = new Button();
            btnCombo = new Button();
            btnTryCatch = new Button();
            btnConnect = new Button();
            SuspendLayout();
            // 
            // btnForm1
            // 
            btnForm1.BackColor = Color.DarkSeaGreen;
            btnForm1.Font = new Font("Segoe UI", 10.8F);
            btnForm1.ImageAlign = ContentAlignment.BottomLeft;
            btnForm1.Location = new Point(21, 86);
            btnForm1.Name = "btnForm1";
            btnForm1.Size = new Size(146, 38);
            btnForm1.TabIndex = 0;
            btnForm1.Text = "Show Form1";
            btnForm1.UseVisualStyleBackColor = false;
            btnForm1.Click += btnForm1_Click;
            // 
            // btnFrmLabelShow
            // 
            btnFrmLabelShow.BackColor = Color.DarkSeaGreen;
            btnFrmLabelShow.Font = new Font("Segoe UI", 10.8F);
            btnFrmLabelShow.Location = new Point(21, 139);
            btnFrmLabelShow.Name = "btnFrmLabelShow";
            btnFrmLabelShow.Size = new Size(146, 38);
            btnFrmLabelShow.TabIndex = 0;
            btnFrmLabelShow.Text = "Show Label ";
            btnFrmLabelShow.UseVisualStyleBackColor = false;
            btnFrmLabelShow.Click += btnFrmLabelShow_Click;
            // 
            // btnFrmStudent
            // 
            btnFrmStudent.BackColor = Color.DarkSeaGreen;
            btnFrmStudent.Font = new Font("Segoe UI", 10.8F);
            btnFrmStudent.Location = new Point(21, 195);
            btnFrmStudent.Name = "btnFrmStudent";
            btnFrmStudent.Size = new Size(146, 38);
            btnFrmStudent.TabIndex = 0;
            btnFrmStudent.Text = "Student Form";
            btnFrmStudent.UseVisualStyleBackColor = false;
            btnFrmStudent.Click += btnFrmStudent_Click;
            // 
            // lblMaster
            // 
            lblMaster.BackColor = Color.Teal;
            lblMaster.Dock = DockStyle.Top;
            lblMaster.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaster.ForeColor = Color.White;
            lblMaster.Location = new Point(0, 0);
            lblMaster.Name = "lblMaster";
            lblMaster.Size = new Size(452, 50);
            lblMaster.TabIndex = 3;
            lblMaster.Text = "Master Page";
            lblMaster.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnValidation
            // 
            btnValidation.BackColor = Color.DarkSeaGreen;
            btnValidation.Font = new Font("Segoe UI", 10.8F);
            btnValidation.Location = new Point(21, 252);
            btnValidation.Name = "btnValidation";
            btnValidation.Size = new Size(146, 38);
            btnValidation.TabIndex = 4;
            btnValidation.Text = "Student FormV";
            btnValidation.UseVisualStyleBackColor = false;
            btnValidation.Click += btnValidation_Click;
            // 
            // btnCombo
            // 
            btnCombo.BackColor = Color.DarkSeaGreen;
            btnCombo.Font = new Font("Segoe UI", 10.8F);
            btnCombo.Location = new Point(208, 86);
            btnCombo.Name = "btnCombo";
            btnCombo.Size = new Size(188, 38);
            btnCombo.TabIndex = 5;
            btnCombo.Text = "Combo";
            btnCombo.UseVisualStyleBackColor = false;
            btnCombo.Click += btnCombo_Click;
            // 
            // btnTryCatch
            // 
            btnTryCatch.BackColor = Color.DarkSeaGreen;
            btnTryCatch.Font = new Font("Segoe UI", 10.8F);
            btnTryCatch.Location = new Point(208, 139);
            btnTryCatch.Name = "btnTryCatch";
            btnTryCatch.Size = new Size(188, 38);
            btnTryCatch.TabIndex = 6;
            btnTryCatch.Text = "Calculator (try-catch)";
            btnTryCatch.UseVisualStyleBackColor = false;
            btnTryCatch.Click += btnTryCatch_Click;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.DarkSeaGreen;
            btnConnect.Font = new Font("Segoe UI", 10.8F);
            btnConnect.Location = new Point(208, 195);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(188, 38);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "CRUD";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // frmMaster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(452, 351);
            Controls.Add(btnConnect);
            Controls.Add(btnTryCatch);
            Controls.Add(btnCombo);
            Controls.Add(btnValidation);
            Controls.Add(lblMaster);
            Controls.Add(btnFrmStudent);
            Controls.Add(btnFrmLabelShow);
            Controls.Add(btnForm1);
            Name = "frmMaster";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMaster";
            ResumeLayout(false);
        }

        #endregion

        private Button btnForm1;
        private Button btnFrmLabelShow;
        private Button btnFrmStudent;
        private Label lblMaster;
        private Button btnValidation;
        private Button btnCombo;
        private Button btnTryCatch;
        private Button btnConnect;
    }
}