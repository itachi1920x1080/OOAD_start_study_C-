using System;
namespace Right_Circular_Cylinde
{

    interface I3DShape
    {
        double  CalculateVolume();
        double CalculateSurfaceArea();
        string info();
    }
    public class Cylinder : I3DShape
    {
        public double Readius { get; set; }
        public double Height { get; set; }

        public Cylinder (double r , double h)
        {
            Readius = r;
            Height = h;
        }
        public double CalculateVolume()
        {
            return Math.PI * Readius * Height;
        }
        public double CalculateSurfaceArea()
        {
            return (2 * Math.PI *Readius*Height)+ (2*Math.PI * Readius * Readius * Height);
        }
        public string info()
        {
            return $"Readius : {Readius}  Heigth : {Height}  Volume : {CalculateVolume()} SurfaceArea : {CalculateSurfaceArea()}";
        }
        


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Cylinder CV1 = new Cylinder(12,66);
            CV1.CalculateVolume();
            CV1.CalculateSurfaceArea();
            Console.WriteLine(CV1.info());
        }
    }
}
