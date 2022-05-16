using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Tests
{
    [TestClass()]
    public class CalculationsTests
    {
        [TestMethod()]
        public void FunctionCalculationsTest1()
        {
            double z = 2;
            double result = 8;
            Assert.AreEqual(result, (int)Calculations.FunctionCalculations(z));
        }

        [TestMethod()]
        public void FunctionCalculationsTest2()
        {
            double z = -2;
            double result = 1;
            Assert.AreEqual(result, (int)Calculations.FunctionCalculations(z));
        }

        [TestMethod()]
        public void FunctionCalculationsTest3()
        {
            double z = 4;
            double result = 56;
            Assert.AreEqual(result, (int)Calculations.FunctionCalculations(z));
        }

        [TestMethod()]
        public void FunctionCalculationsTest4()
        {
            double z = 0;
            double result = 0;
            Assert.AreEqual(result, (int)Calculations.FunctionCalculations(z));
        }

        [TestMethod()]
        public void FunctionCalculationsTest5()
        {
            double z = -3;
            double result = 2;
            Assert.AreEqual(result, (int)Calculations.FunctionCalculations(z));
        }
    }
}