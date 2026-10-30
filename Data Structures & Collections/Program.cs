using System;
using System.Collections.Generic;
namespace Data_Structures___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            List<String> studentName = new List<string> ();
            studentName.Add("Dara");
            studentName.Add("Sok");
            studentName.Remove("Sok");
            //Console.WriteLine(studentName);
            foreach(var name in studentName)
            {
                Console.WriteLine(name);
            }
        }
    }
}
