using System;

public class Student
{
    // 1. សរសេរ Auto-Property សម្រាប់ Name (string) នៅទីនេះ

    public string Name { get; set; }
    private int _age;

    // 2. បំពេញ Full Property សម្រាប់ Age (int) ខាងក្រោមនេះ
    public int Age
    {
        get
        {
            // សរសេរកូដ return នៅទីនេះ
            return _age;
        }
        set
        {
            // សរសេរលក្ខខណ្ឌ if (value > 0) នៅទីនេះ
            if (value > 0)
            {
                _age = value;
            }
        }
    }
    public Student (string name ,int age)
    {
        Name = name;
        Age = age;
    }
}

//Student student1 = new Student("Alice",21);

public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("Visal", 23);
        Console.WriteLine($"Student: {student1.Name}, Age: {student1.Age}");
    }
    
}