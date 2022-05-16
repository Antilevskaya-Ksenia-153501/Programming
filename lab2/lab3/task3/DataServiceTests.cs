using Microsoft.VisualStudio.TestTools.UnitTesting;
using task3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Tests
{
    [TestClass()]
    public class DataServiceTests
    {
        [TestMethod()]
        public void GetDayTest1()
        {
            Assert.AreEqual("День недели: понедельник", DataService.GetDay("04.04.2022"));
            Assert.AreEqual(1, DataService.GetDaysSpan(3, 4, 2022));
        }

        [TestMethod()]
        public void GetDayTest2()
        {
            Assert.AreEqual("День недели: понедельник", DataService.GetDay("18.04.2022"));
            Assert.AreEqual(15, DataService.GetDaysSpan(3, 4, 2022));
        }

        [TestMethod()]
        public void GetDayTest3()
        {
            Assert.AreEqual("День недели: вторник", DataService.GetDay("05.04.2022"));
            Assert.AreEqual(2, DataService.GetDaysSpan(3, 4, 2022));
        }

        [TestMethod()]
        public void GetDayTest4()
        {
            Assert.AreEqual("День недели: среда", DataService.GetDay("25.05.2022"));
            Assert.AreEqual(52, DataService.GetDaysSpan(3, 4, 2022));
        }
    }
}