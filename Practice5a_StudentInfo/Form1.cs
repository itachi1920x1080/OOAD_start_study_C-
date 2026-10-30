using System.Text;

namespace Practice5a_StudentInfo
{
    struct Student
    {
        public string ID;
        public string Name;
        public string Address;
        public string Phone;


    }
    public partial class Form1 : Form
    {
        Student[] students = new Student[100];
        int Studentcount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //private void btnAddNewRecord_Click(object sender, EventArgs e)
        //{
        //    Student newstudent = new Student();
        //    newstudent.ID = txtID.Text;
        //    newstudent.Name = txtName.Text;
        //    newstudent.Address = txtAddress.Text;
        //    newstudent.Phone = txtPhone.Text;

        //    students[Studentcount] = newstudent;
        //    Studentcount++;

        //    MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    txtID.Clear();
        //    txtName.Clear();
        //    txtAddress.Clear();
        //    txtPhone.Clear();
        //    txtID.Focus();
        //}
        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            // --- ផ្នែក Validation (Step 6) ---
            if (Studentcount >= 100)
            {
                MessageBox.Show("Memory is full. Cannot add more records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter Phone.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            // --- ផ្នែក Add Record (Step 5) ---
            Student newstudent = new Student();
            newstudent.ID = txtID.Text;
            newstudent.Name = txtName.Text;
            newstudent.Address = txtAddress.Text;
            newstudent.Phone = txtPhone.Text;

            students[Studentcount] = newstudent;
            Studentcount++;

            MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtID.Focus();
        }

        private void btnShowRecord_Click(object sender, EventArgs e)
        {
            if (Studentcount == 0)
            {
                MessageBox.Show("No records found. Please add a record first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ប្រើ StringBuilder ជំនួសឱ្យ string ធម្មតា
            StringBuilder sb = new StringBuilder();

            // (ជម្រើស) បន្ថែមចំណងជើង (Header) ពីលើ ដើម្បីឱ្យមើលទៅស្អាត
            sb.AppendLine("ID\tName\tAddress\tPhone");
            sb.AppendLine("---------------------------------------------------------");


            for (int i = 0; i < Studentcount; i++)
            {
                // ប្រើ \t (Tab) ដើម្បីរុញអក្សរឱ្យចូលជួរគ្នា
                // AppendLine គឺមានន័យថា វាបូកបញ្ចូលហើយ ចុះបន្ទាត់ថ្មី (\n) ឱ្យស្រាប់តែម្តង
                sb.AppendLine(students[i].ID + "\t" +
                              students[i].Name + "\t" +
                              students[i].Address + "\t" +
                              students[i].Phone);
            }

            // បង្ហាញលទ្ធផលចេញមក
            // យើងត្រូវប្តូរពី sb ទៅជា string វិញទើប MessageBox ស្គាល់ ដោយប្រើ .ToString()
            MessageBox.Show(sb.ToString(), "Student Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}