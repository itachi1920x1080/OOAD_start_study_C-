using System;
using System.Windows.Forms;

namespace FormProductView
{
    public partial class FormAddEdit : Form
    {
        public Product CurrentProduct { get; private set; }

        public FormAddEdit(Product product = null)
        {
            InitializeComponent();
            if (product != null)
            {
                CurrentProduct = product.Clone();
                txtId.Text = CurrentProduct.Id;
                txtName.Text = CurrentProduct.Name;
                txtPrice.Text = CurrentProduct.Price.ToString();
            }
            else
            {
                CurrentProduct = new Product();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentProduct.Id = txtId.Text;
            CurrentProduct.Name = txtName.Text;
            if (double.TryParse(txtPrice.Text, out double price))
            {
                CurrentProduct.Price = price;
            }
            else
            {
                MessageBox.Show("Invalid price.");
                return;
            }

            if (!CurrentProduct.ValidData)
            {
                MessageBox.Show("Invalid product data.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
