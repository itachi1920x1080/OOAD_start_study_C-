using System;
public class Student
{
    private string m_name;
    private string m_ssn; // Social Security Number
    private double m_midterm;
    private double m_final;
    public string Name
    {
        get { return m_name; }
        set { m_name = value; }
    }
    public string SSN
    {
        get { return m_ssn; }
        set { m_ssn = value; }
    }
    public double Midterm
    {
        set { m_midterm = value; }
    }
    public double Final
    {
        set { m_final = value; }
    }
    public string CalculateSemesterGrade()
    {
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