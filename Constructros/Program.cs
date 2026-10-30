using System;

namespace Constructros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Point Data1 = new Point();

            Data1.showInfo();
            //Point Data2 = new Point(3, 2);
            //Data2.showInfo();

        }
        public class Point 
        {
            private double xCoord;
            private double yCoord;
            //simple parameterless constructor 
            public Point()
            {
                this.xCoord = 0;
                this.yCoord = 0;
            }
            //public Point(double x,double y) 
            //{
            //    this.xCoord=x;
            //    this.yCoord=y;
            //}
            //public double Xcoord
            //{
            //    get { return this.xCoord; }
            //    set { this.xCoord = value; }
            //}
            //public double Ycoord
            //{
            //    get { return this.yCoord; }
            //    set { this.yCoord = value; }
            //}


            public void showInfo()
            {
                Console.WriteLine($"Xcoord {xCoord}|Ycoord{yCoord}");
                Console.WriteLine(calculator.toStringASFIX(0.2));
            }
            public double calculator() 
            {
                return Math.Sqrt(Math.Pow(xCoord - xCoord,2) - Math.Pow(yCoord - yCoord,2));
            }

        } 
    }
}
