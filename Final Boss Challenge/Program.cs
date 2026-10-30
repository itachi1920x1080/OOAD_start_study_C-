using System;
namespace Final_Boss_Challenge
{

    interface IShape 
    {
        double CalculateArea();
        string info();
    }
    public class Circle : IShape
    {
        public double Radius { get; set;  }
        public Circle(double Redius) 
        {
            this.Radius = Redius;
        }
        public double  CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public string info()
        {
            return $"Readiu :{Radius}, Area : {CalculateArea()}";
        }
    } 
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle (double Length ,double Width )
        {
            this.Length = Length;
            this.Width = Width;
        }
        public double CalculateArea()
        {
            return Length * Width;
        }
        public string info()
        {
            return $"Length :{Length}, Width : {Width}, Area : {CalculateArea()}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(12);
            Console.WriteLine(c1.info());
            Rectangle r1 = new Rectangle(12, 5);
            Console.WriteLine(r1.info());


        }
    }
}
