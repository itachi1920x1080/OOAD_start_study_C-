
namespace FormProductView
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
            dgvProductView = new DataGridView();
            lblCurrentProduct = new Label();
            lblInfo = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductView).BeginInit();
            SuspendLayout();
            // 
            // dgvProductView
            // 
            dgvProductView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductView.Location = new Point(12, 12);
            dgvProductView.Name = "dgvProductView";
            dgvProductView.Size = new Size(572, 315);
            dgvProductView.TabIndex = 0;
            // 
            // lblCurrentProduct
            // 
            lblCurrentProduct.AutoSize = true;
            lblCurrentProduct.Location = new Point(40, 389);
            lblCurrentProduct.Name = "lblCurrentProduct";
            lblCurrentProduct.Size = new Size(92, 15);
            lblCurrentProduct.TabIndex = 1;
            lblCurrentProduct.Text = "Current product";
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(153, 376);
            lblInfo.Name = "lblInfo";
            lblInfo.ReadOnly = true;
            lblInfo.Size = new Size(431, 23);
            lblInfo.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(629, 21);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(629, 76);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lblInfo);
            Controls.Add(lblCurrentProduct);
            Controls.Add(dgvProductView);
            Location = new Point(10, 0);
            Name = "Form1";
            Padding = new Padding(0, 10, 200, 0);
            Text = "Product";
            //Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductView;
        private Label lblCurrentProduct;
        private TextBox lblInfo;
        private Button btnAdd;
        private Button btnEdit;
    }
}
