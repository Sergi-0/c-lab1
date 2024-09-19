using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1_3;
using System.Runtime.CompilerServices;

namespace test1
{
    [TestClass]
    public class UnitTest1 // perimetr
    {
        [DataTestMethod]
        [DataRow(0,4,0,0,4,0,4,4,16)]
        public void TestMethod1(int a, int b, int c, int d, int z, int p, int k, int t, int exp)
        {
            Point p1 = new Point(a, b);
            Point p2 = new Point(c, d);
            Point p3 = new Point(z, p);
            Point p4 = new Point(k, t);
            Figure rect = new Figure(p1, p2, p3, p4, "Четырехугольник");
            double znach = rect.PerimeterCalculator();
            Assert.AreEqual(exp, znach);
        }

        [DataTestMethod]
        [DataRow(0, 4, 0, 0, 16)]
        [DataRow(2, 1, 3, 5, 17)]
        [DataRow(3, 4, 2, 1, 10)]
        [DataRow(7, 1, 8, 3, 5)]
        public void TestMethod2(int a, int b, int c, int d, int exp)
        {
            Point p1 = new Point(a, b);
            Point p2 = new Point(c, d);
            double znach = Figure.LengthSide(p1,p2);
            double expected = Math.Sqrt(exp);
            Assert.AreEqual(expected, znach);
        }
    }
}
