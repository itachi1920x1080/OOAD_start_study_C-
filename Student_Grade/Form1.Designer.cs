namespace Student_Grade
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtSSN = new TextBox();
            label3 = new Label();
            txtMidterm = new TextBox();
            label4 = new Label();
            txtFinal = new TextBox();
            btnEnter = new Button();
            btnDisplay = new Button();
            btnQuit = new Button();
            lstGrades = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 46);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 94);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 10;
            label2.Text = "SSN";
            // 
            // txtName
            // 
            txtName.Location = new Point(95, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(649, 23);
            txtName.TabIndex = 9;
            // 
            // txtSSN
            // 
            txtSSN.Location = new Point(100, 93);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(150, 23);
            txtSSN.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 96);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 7;
            label3.Text = "Midterm";
            // 
            // txtMidterm
            // 
            txtMidterm.Location = new Point(335, 93);
            txtMidterm.Name = "txtMidterm";
            txtMidterm.Size = new Size(150, 23);
            txtMidterm.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(524, 96);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 5;
            label4.Text = "Final";
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(568, 93);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(190, 23);
            txtFinal.TabIndex = 4;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(43, 187);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(207, 30);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "Enter Information";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(296, 187);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(207, 30);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "Display Grade";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(553, 187);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(205, 30);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lstGrades
            // 
            lstGrades.Font = new Font("Consolas", 10F);
            lstGrades.FormattingEnabled = true;
            lstGrades.ItemHeight = 15;
            lstGrades.Location = new Point(43, 252);
            lstGrades.Name = "lstGrades";
            lstGrades.Size = new Size(715, 184);
            lstGrades.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstGrades);
            Controls.Add(btnQuit);
            Controls.Add(btnDisplay);
            Controls.Add(btnEnter);
            Controls.Add(txtFinal);
            Controls.Add(label4);
            Controls.Add(txtMidterm);
            Controls.Add(label3);
            Controls.Add(txtSSN);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Semester Grade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtSSN;
        private Label label3;
        private TextBox txtMidterm;
        private Label label4;
        private TextBox txtFinal;
        private Button btnEnter;
        private Button btnDisplay;
        private Button btnQuit;
        private ListBox lstGrades;
    }
}