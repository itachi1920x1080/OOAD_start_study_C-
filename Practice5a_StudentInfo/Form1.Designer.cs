namespace Practice5a_StudentInfo
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
            labelTitle = new Label();
            labelID = new Label();
            labelName = new Label();
            labelAddress = new Label();
            labelPhone = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            btnAddNewRecord = new Button();
            btnShowRecord = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(285, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(196, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Student Information";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 10F);
            labelID.Location = new Point(55, 85);
            labelID.Name = "labelID";
            labelID.Size = new Size(23, 19);
            labelID.TabIndex = 1;
            labelID.Text = "ID";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 10F);
            labelName.Location = new Point(55, 140);
            labelName.Name = "labelName";
            labelName.Size = new Size(45, 19);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 10F);
            labelAddress.Location = new Point(55, 195);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(58, 19);
            labelAddress.TabIndex = 3;
            labelAddress.Text = "Address";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 10F);
            labelPhone.Location = new Point(55, 250);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(48, 19);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Phone";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 10F);
            txtID.Location = new Point(145, 82);
            txtID.Name = "txtID";
            txtID.Size = new Size(300, 25);
            txtID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(145, 137);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 25);
            txtName.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F);
            txtAddress.Location = new Point(145, 192);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(300, 25);
            txtAddress.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(145, 247);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 25);
            txtPhone.TabIndex = 8;
            // 
            // btnAddNewRecord
            // 
            btnAddNewRecord.Font = new Font("Segoe UI", 9.5F);
            btnAddNewRecord.Location = new Point(500, 82);
            btnAddNewRecord.Name = "btnAddNewRecord";
            btnAddNewRecord.Size = new Size(150, 40);
            btnAddNewRecord.TabIndex = 9;
            btnAddNewRecord.Text = "Add New Record";
            btnAddNewRecord.UseVisualStyleBackColor = true;
            btnAddNewRecord.Click += btnAddNewRecord_Click;
            // 
            // btnShowRecord
            // 
            btnShowRecord.Font = new Font("Segoe UI", 9.5F);
            btnShowRecord.Location = new Point(500, 137);
            btnShowRecord.Name = "btnShowRecord";
            btnShowRecord.Size = new Size(150, 40);
            btnShowRecord.TabIndex = 10;
            btnShowRecord.Text = "Show Record";
            btnShowRecord.UseVisualStyleBackColor = true;
            btnShowRecord.Click += btnShowRecord_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 350);
            Controls.Add(btnShowRecord);
            Controls.Add(btnAddNewRecord);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(labelPhone);
            Controls.Add(labelAddress);
            Controls.Add(labelName);
            Controls.Add(labelID);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelID;
        private Label labelName;
        private Label labelAddress;
        private Label labelPhone;

        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;

        private Button btnAddNewRecord;
        private Button btnShowRecord;
    }
}