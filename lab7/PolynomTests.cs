using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Tests
{
    [TestClass()]
    public class PolynomTests
    {
        [TestMethod()]
        public void ToStringTest1()
        {
            Polynom temp = new Polynom(2, 2, 2);
            Assert.AreEqual(temp.ToString(), "2x + 2y + 2z");
        }

        [TestMethod()]
        public void ToStringTest2()
        {
            Polynom temp = new Polynom(2, 4, 6);
            Assert.AreEqual(temp.ToString(), "2x + 4y + 6z");
        }

        [TestMethod()]
        public void ToStringTest3()
        {
            Polynom temp = new Polynom(3, 3, 3);
            Assert.AreEqual(temp.ToString(), "3x + 3y + 3z");
        }

        [TestMethod()]
        public void PolynomTest1()
        {
            Polynom temp = new Polynom();
            temp.Set_Koef_a = 2;
            Assert.AreEqual(2, temp.Set_Koef_a);
        }

        [TestMethod()]
        public void PolynomTest2()
        {
            Polynom temp = new Polynom();
            temp.Set_Koef_b = 10;
            Assert.AreEqual(10, temp.Set_Koef_b);
        }

        [TestMethod()]
        public void PolynomTest3()
        {
            Polynom temp = new Polynom();
            temp.Set_Koef_c = 14;
            Assert.AreEqual(14, temp.Set_Koef_c);
        }
    }
}