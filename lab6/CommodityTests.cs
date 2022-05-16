using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1.Tests
{
    [TestClass()]
    public class CommodityTests
    {
        [TestMethod()]
        public void IsCorrespondsToWorkingLifeTest1()
        {
            DateTime now = DateTime.Now;
            Product milk = new Product("молоко", 20, Convert.ToDateTime("01.05.2022"), 14);
            Assert.AreEqual("Годен", milk.IsCorrespondsToWorkingLife(now) ? "Годен" : "Не годен");
        }

        [TestMethod()]
        public void IsCorrespondsToWorkingLifeTest2()
        {
            DateTime now = DateTime.Now;
            Product kefir = new Product("кефир", 15, Convert.ToDateTime("30.04.2022"), 5);
            Assert.AreEqual("Не годен", kefir.IsCorrespondsToWorkingLife(now) ? "Годен" : "Не годен");
        }

        [TestMethod()]
        public void IsCorrespondsToWorkingLifeTest3()
        {
            DateTime now = DateTime.Now;
            Batch youghurt = new Batch("актимель", 25, Convert.ToDateTime("05.05.2022"), 10, 10);
            Assert.AreEqual("Годен", youghurt.IsCorrespondsToWorkingLife(now) ? "Годен" : "Не годен");
        }
    }
}