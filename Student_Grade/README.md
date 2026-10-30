# Practice - Student Grade

## Step 1 
Create a class named Student following:

```csharp
public class Student {
    private string m_name;
    private string m_ssn; // Social Security Number
    private double m_midterm;
    private double m_final;

    public string Name {
        get { return m_name; }
        set { m_name = value; }
    }

    public string SSN {
        get { return m_ssn; }
        set { m_ssn = value; }
    }

    public double Midterm {
        set { m_midterm = value; }
    }

    public double Final {
        set { m_final = value; }
    }

    public string CalculateSemesterGrade() {
        double grade;
        grade = (m_midterm + m_final) / 2;
        grade = Math.Round(grade);
        
        if (grade >= 90) { return "A"; }
        else if (grade >= 80) { return "B"; }
        else if (grade >= 70) { return "C"; } 
        else if (grade >= 60) { return "D"; } 
        else { return "F"; }
    }
}
```

## Step 2 
Create and design a form named `StudentGrade` to view students. 

### Design

![Semester Grade Form](screenshot.png)

### Code

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGrade {
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
```
