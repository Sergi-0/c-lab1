using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3
{
    public class Point
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
    public class Figure
    {
        public string name { get; set; }
        private Point p1;
        private Point p2;
        private Point p3;
        private Point p4;
        private Point p5;
        public Figure(Point p1, Point p2, Point p3, string name)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.name = name;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, string name) : this(p1, p2, p3, name)
        {
            this.p4 = p4;
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5, string name) : this(p1, p2, p3, p4, name)
        {
            this.p5 = p5;
        }


        public static double LengthSide(Point A, Point B)
        {
            int dx = A.X - B.X;
            int dy = A.Y - B.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public double PerimeterCalculator()
        {
            double length = 0;

            if (name == "Треугольник ") { length = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p1, p3); };
            if (name == "Четырехугольник") { length = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p1); };
            if (name == "Пятиугольник") { length = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p5) + LengthSide(p5, p1); };

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
