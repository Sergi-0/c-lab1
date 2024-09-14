using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3
{
    class Point
    {
        private int x;
        private int y;

        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }

    class Figure
    {
        public string name {  get; set; }
        private Point[] masspoint = new Point[5];
        public Figure(Point p1, Point p2, Point p3, string name)
        {
            masspoint[0] = p1;
            masspoint[1] = p2;
            masspoint[2] = p3;
            this.name = name;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, string name)
        {
            masspoint[0] = p1;
            masspoint[1] = p2;
            masspoint[2] = p3;
            masspoint[3] = p4;
            this.name = name;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5, string name)
        {
            masspoint[0] = p1;
            masspoint[1] = p2;
            masspoint[2] = p3;
            masspoint[3] = p4;
            masspoint[4] = p5;
            this.name = name;
        }

        
        public double LengthSide(Point A, Point B)
        {
            int dx = A.X - B.X;
            int dy = A.Y - B.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public double PerimeterCalculator()
        {
            double length = 0;
            int n = 0;

            if (name == "Треугольник ") n = 3;
            if (name == "Четырехугольник") n = 4;
            if (name == "Пятиугольник") n = 5;
            
            length = LengthSide(masspoint[0], masspoint[n - 1]);

            for (int i = 0; i <= n-2; i++) length = length + LengthSide(masspoint[i], masspoint[i+1]);

            return length;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(5, 0);
            Point p3 = new Point(5, 5);
            Point p4 = new Point(0, 5);
            Figure rect = new Figure(p1, p2, p3, p4, "Четырехугольник");
            Console.WriteLine($"{rect.name} периметра: {rect.PerimeterCalculator()}");
            Console.WriteLine();
        }
    }
}
