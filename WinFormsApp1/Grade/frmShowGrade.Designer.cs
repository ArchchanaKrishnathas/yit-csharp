namespace WinFormsApp1.Grade
{
    partial class frmShowGrade
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
            lblGradeHeading = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtGrId = new TextBox();
            txtGrName = new TextBox();
            txtGrGroup = new TextBox();
            txtGrOrder = new TextBox();
            btnChooseColor = new Button();
            pnlColor = new Panel();
            SuspendLayout();
            // 
            // lblGradeHeading
            // 
            lblGradeHeading.BackColor = Color.Teal;
            lblGradeHeading.Dock = DockStyle.Top;
            lblGradeHeading.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGradeHeading.ForeColor = Color.White;
            lblGradeHeading.Location = new Point(0, 0);
            lblGradeHeading.Name = "lblGradeHeading";
            lblGradeHeading.Size = new Size(360, 44);
            lblGradeHeading.TabIndex = 8;
            lblGradeHeading.Text = "Show Grade";
            lblGradeHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 9;
            label1.Text = "Grade Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 10;
            label2.Text = "Grade Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 234);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 11;
            label3.Text = "Grade Colour";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 192);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 12;
            label4.Text = "Grade Order";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 150);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 13;
            label5.Text = "Grade Group";
            // 
            // txtGrId
            // 
            txtGrId.Location = new Point(136, 66);
            txtGrId.Name = "txtGrId";
            txtGrId.ReadOnly = true;
            txtGrId.Size = new Size(203, 27);
            txtGrId.TabIndex = 14;
            // 
            // txtGrName
            // 
            txtGrName.Location = new Point(136, 107);
            txtGrName.Name = "txtGrName";
            txtGrName.Size = new Size(203, 27);
            txtGrName.TabIndex = 15;
            // 
            // txtGrGroup
            // 
            txtGrGroup.Location = new Point(136, 148);
            txtGrGroup.Name = "txtGrGroup";
            txtGrGroup.Size = new Size(203, 27);
            txtGrGroup.TabIndex = 16;
            // 
            // txtGrOrder
            // 
            txtGrOrder.Location = new Point(136, 189);
            txtGrOrder.Name = "txtGrOrder";
            txtGrOrder.Size = new Size(203, 27);
            txtGrOrder.TabIndex = 17;
            // 
            // btnChooseColor
            // 
            btnChooseColor.Location = new Point(181, 232);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(157, 27);
            btnChooseColor.TabIndex = 23;
            btnChooseColor.Text = "Choose Color";
            btnChooseColor.UseVisualStyleBackColor = true;
            // 
            // pnlColor
            // 
            pnlColor.BackColor = Color.White;
            pnlColor.BorderStyle = BorderStyle.FixedSingle;
            pnlColor.Location = new Point(135, 232);
            pnlColor.Name = "pnlColor";
            pnlColor.Size = new Size(40, 27);
            pnlColor.TabIndex = 22;
            // 
            // frmShowGrade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 293);
            Controls.Add(btnChooseColor);
            Controls.Add(pnlColor);
            Controls.Add(txtGrOrder);
            Controls.Add(txtGrGroup);
            Controls.Add(txtGrName);
            Controls.Add(txtGrId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblGradeHeading);
            Name = "frmShowGrade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmShowGrade";
            Load += frmShowGrade_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGradeHeading;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtGrId;
        private TextBox txtGrName;
        private TextBox txtGrGroup;
        private TextBox txtGrOrder;
        private Button btnChooseColor;
        private Panel pnlColor;
    }
}