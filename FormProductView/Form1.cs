namespace FormProductView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += FormProductView_Load;
        }

        public static List<Product> lst = new List<Product>();
        public BindingSource bs = new BindingSource();
        private void FormProductView_Load(object sender, EventArgs e)
        {
            lst.AddRange(new[] {
         new Product("P1", "Tiger Beer Cans 330ml", 16.7),
         new Product("P2", "Honda Dream 125cc", 2750),
         new Product("P3", "Cowhead Pure milk 1L", 2.5)
        //  new Product("P4", " ",255)
         });
            bs = new BindingSource(lst, null);
            dgvProductView.DataSource = bs;
            dgvProductView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvProductView.AllowUserToAddRows = false;
            dgvProductView.ReadOnly = true;
            bs.ResetBindings(false);
            dgvProductView.Columns["Info"].Visible = false;
            var tempVar = dgvProductView.Columns["ValidData"];
            tempVar.DisplayIndex = 0;
            tempVar.HeaderText = "Valid?";
            dgvProductView.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProductView.Columns["Price"].DefaultCellStyle.Format = "#,0.00";
            lblInfo.DataBindings.Add("Text", bs, "Info");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
    {
        // Open FormAddEdit in "Add" mode by passing null
        FormAddEdit formAdd = new FormAddEdit(null);
        
        if (formAdd.ShowDialog() == DialogResult.OK)
        {
            // Add the new product to our static list
            lst.Add(formAdd.CurrentProduct);
            
            // Refresh the BindingSource to update the DataGridView
            bs.ResetBindings(false);
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        // Ensure a product is actually selected in the grid
        if (bs.Current == null)
        {
            MessageBox.Show("Please select a product to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        // Get the currently selected product from the BindingSource
        Product selectedProduct = (Product)bs.Current;

        // Open FormAddEdit in "Edit" mode by passing the selected product
        FormAddEdit formEdit = new FormAddEdit(selectedProduct);
        
        if (formEdit.ShowDialog() == DialogResult.OK)
        {
            // Copy the updated data back into the original product object
            selectedProduct.CopyFrom(formEdit.CurrentProduct);
            
            // Refresh the BindingSource to reflect changes in the DataGridView and Info textbox
            bs.ResetBindings(false);
        }
    }
    }
}
