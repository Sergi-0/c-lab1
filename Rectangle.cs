using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2
{
    class Rectangle
    {
        private double sideA;
        double sideB;
        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        private double CalculateArea()
        {
            return sideA*sideB;
        }

        private double CalculatePerimeter()
        {
            return 2*sideA + 2*sideB;
        }

        public double Area
        {
            get { return CalculateArea(); }
        }
        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            Rectangle rec1 = new Rectangle(sideA, sideB);
            Console.WriteLine($"Площадь: {rec1.Area}");
            Console.WriteLine(($"Периметр: {rec1.Perimeter}"));
            Console.ReadLine();
        }

    }
}
