using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grade {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Student pupil; //pupil is an object of class Student

        private void btnEnter_Click(object sender, EventArgs e) {
            pupil = new Student(); //Create an instances of Student
            pupil.Name = txtName.Text;
            pupil.SSN = txtSSN.Text;
            pupil.Midterm = double.Parse(txtMidterm.Text);
            pupil.Final = double.Parse(txtFinal.Text);
            txtName.Clear();
            txtSSN.Clear();
            txtMidterm.Clear();
            txtFinal.Clear();
            lstGrades.Items.Clear();    
        }

        private void btnDisplay_Click(object sender, EventArgs e) {
            string str = "{0, -20} {1,-15} {2, -15}";
            lstGrades.Items.Clear();
            lstGrades.Items.Add(
                string.Format(str, "Student Name", "SSNumber", "Grade")
            );
            lstGrades.Items.Add(
                string.Format(str, pupil.Name, pupil.SSN, 
                pupil.CalculateSemesterGrade())
            );
        }

        private void btnQuit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}