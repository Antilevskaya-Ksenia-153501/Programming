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
    public class SquaringTests
    {
        [TestMethod()]
        public void FunctinSquaringTest1()
        {
            uint x = 3;
            uint x_result = 9;
            Assert.AreEqual(x_result, Squaring.FunctinSquaring(x));
        }

        [TestMethod()]
        public void FunctinSquaringTest2()
        {
            uint x = 0;
            Assert.AreEqual(x, Squaring.FunctinSquaring(x));
        }

        [TestMethod()]
        public void FunctinSquaringTest3()
        {
            uint x = 5;
            uint x_result = 25;
            Assert.AreEqual(x_result, Squaring.FunctinSquaring(x));
        }

        [TestMethod()]
        public void FunctinSquaringTest4()
        {
            uint x = 8;
            uint x_result = 64;
            Assert.AreEqual(x_result, Squaring.FunctinSquaring(x));
        }

        [TestMethod()]
        public void FunctinSquaringTest5()
        {
            uint x = 6;
            uint x_result = 36;
            Assert.AreEqual(x_result, Squaring.FunctinSquaring(x));
        }


    }
}