namespace WinFormsApp1
{
    partial class frmCalculate
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
            lblError = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            txtResult = new TextBox();
            btnSubstraction = new Button();
            btnAddition = new Button();
            btnMultiplication = new Button();
            btnDivision = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(90, 302);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 76);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 0;
            label2.Text = "Number 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 260);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 0;
            label3.Text = "Results";
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(134, 69);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(183, 27);
            txtNumber1.TabIndex = 1;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(134, 127);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(183, 27);
            txtNumber2.TabIndex = 1;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(134, 257);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(183, 27);
            txtResult.TabIndex = 1;
            // 
            // btnSubstraction
            // 
            btnSubstraction.Location = new Point(39, 187);
            btnSubstraction.Name = "btnSubstraction";
            btnSubstraction.Size = new Size(46, 42);
            btnSubstraction.TabIndex = 2;
            btnSubstraction.Text = "-";
            btnSubstraction.UseVisualStyleBackColor = true;
            btnSubstraction.Click += btnSubstraction_Click;
            // 
            // btnAddition
            // 
            btnAddition.Location = new Point(119, 187);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(46, 42);
            btnAddition.TabIndex = 2;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += btnAddition_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Location = new Point(187, 187);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(46, 42);
            btnMultiplication.TabIndex = 2;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += btnMultiplication_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(271, 187);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(46, 42);
            btnDivision.TabIndex = 2;
            btnDivision.Text = "-";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 134);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Number 2";
            // 
            // frmCalculate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 341);
            Controls.Add(label1);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplication);
            Controls.Add(btnAddition);
            Controls.Add(btnSubstraction);
            Controls.Add(txtResult);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblError);
            Name = "frmCalculate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCalculate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblError;
        private Label label2;
        private Label label3;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private TextBox txtResult;
        private Button btnSubstraction;
        private Button btnAddition;
        private Button btnMultiplication;
        private Button btnDivision;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}