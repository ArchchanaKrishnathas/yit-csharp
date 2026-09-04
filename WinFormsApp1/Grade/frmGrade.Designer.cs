namespace WinFormsApp1.Grade
{
    partial class frmGrade
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
            dgvGrades = new DataGridView();
            btnCreate = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAllGrades = new Button();
            btnShow = new Button();
            lblGradeHeading = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
            SuspendLayout();
            // 
            // dgvGrades
            // 
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrades.Location = new Point(10, 141);
            dgvGrades.Name = "dgvGrades";
            dgvGrades.RowHeadersWidth = 51;
            dgvGrades.Size = new Size(692, 397);
            dgvGrades.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 10.8F);
            btnCreate.Location = new Point(10, 69);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 44);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 10.8F);
            btnEdit.Location = new Point(116, 69);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 44);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.8F);
            btnDelete.Location = new Point(328, 69);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 44);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAllGrades
            // 
            btnAllGrades.Font = new Font("Segoe UI", 10.8F);
            btnAllGrades.Location = new Point(571, 69);
            btnAllGrades.Name = "btnAllGrades";
            btnAllGrades.Size = new Size(133, 44);
            btnAllGrades.TabIndex = 4;
            btnAllGrades.Text = "All Grades";
            btnAllGrades.UseVisualStyleBackColor = true;
            btnAllGrades.Click += btnAllGrades_Click;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI", 10.8F);
            btnShow.Location = new Point(222, 69);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(100, 44);
            btnShow.TabIndex = 5;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // lblGradeHeading
            // 
            lblGradeHeading.BackColor = Color.Teal;
            lblGradeHeading.Dock = DockStyle.Top;
            lblGradeHeading.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGradeHeading.ForeColor = Color.White;
            lblGradeHeading.Location = new Point(0, 0);
            lblGradeHeading.Name = "lblGradeHeading";
            lblGradeHeading.Size = new Size(714, 50);
            lblGradeHeading.TabIndex = 7;
            lblGradeHeading.Text = "Grades";
            lblGradeHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmGrade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 550);
            Controls.Add(lblGradeHeading);
            Controls.Add(btnShow);
            Controls.Add(btnAllGrades);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnCreate);
            Controls.Add(dgvGrades);
            Name = "frmGrade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGrade";
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGrades;
        private Button btnCreate;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAllGrades;
        private Button btnShow;
        private Label lblGradeHeading;
    }
}