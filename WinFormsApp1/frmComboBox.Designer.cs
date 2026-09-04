namespace WinFormsApp1
{
    partial class frmComboBox
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
            lstSubject = new ListBox();
            btnSubmit = new Button();
            cmbSelectedSubject = new ComboBox();
            cmbSubject = new ComboBox();
            SuspendLayout();
            // 
            // lstSubject
            // 
            lstSubject.FormattingEnabled = true;
            lstSubject.Items.AddRange(new object[] { "Science", "English", "Maths", "ICT", "History" });
            lstSubject.Location = new Point(46, 146);
            lstSubject.Margin = new Padding(2);
            lstSubject.Name = "lstSubject";
            lstSubject.Size = new Size(145, 124);
            lstSubject.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(45, 94);
            btnSubmit.Margin = new Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(90, 27);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cmbSelectedSubject
            // 
            cmbSelectedSubject.FormattingEnabled = true;
            cmbSelectedSubject.Items.AddRange(new object[] { "Science", "Maths", "English", "History", "Tamil" });
            cmbSelectedSubject.Location = new Point(237, 41);
            cmbSelectedSubject.Margin = new Padding(2);
            cmbSelectedSubject.Name = "cmbSelectedSubject";
            cmbSelectedSubject.Size = new Size(146, 28);
            cmbSelectedSubject.TabIndex = 3;
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] { "Science", "Maths", "English", "History", "Tamil" });
            cmbSubject.Location = new Point(45, 41);
            cmbSubject.Margin = new Padding(2);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(146, 28);
            cmbSubject.TabIndex = 4;
            // 
            // frmComboBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 296);
            Controls.Add(lstSubject);
            Controls.Add(btnSubmit);
            Controls.Add(cmbSelectedSubject);
            Controls.Add(cmbSubject);
            Name = "frmComboBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmComboBox";
            Load += frmComboBox_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstSubject;
        private Button btnSubmit;
        private ComboBox cmbSelectedSubject;
        private ComboBox cmbSubject;
    }
}