using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab1_2;

namespace test1
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(1, 2, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(1, 4, 4)]
        public void TestMethod1(int a, int b, int c)
        {
            Rectangle rec = new Rectangle(a,b);
            double area1 = rec.CalculateArea();
            Assert.AreEqual(c, area1);
        }

        [DataTestMethod]
        [DataRow(3, 2, 10)]
        [DataRow(2, 5, 14)]
        [DataRow(5, 1, 12)]
        public void TestMethod2(int a, int b, int c)
        {
            Rectangle rec = new Rectangle(a, b);
            double area1 = rec.CalculatePerimeter();
            Assert.AreEqual(c, area1);
        }

    }
}
