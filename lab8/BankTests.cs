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
    public class BankTests
    {
        [TestMethod()]
        public void GetTotalSumTest1()
        {
            Bank BelinvestBank = new Bank();
            BelinvestBank.AddNoAdditionalSumInvestor("Ivan", 3200);
            BelinvestBank.AddWithAdditionalSumInvestor("Vladislav", 1000, 100);
            Assert.AreEqual(BelinvestBank.GetTotalSum(), 4300);
        }

        [TestMethod()]
        public void GetTotalSumTest2()
        {
            Bank BelarusBank = new Bank();
            BelarusBank.AddNoAdditionalSumInvestor("Nastya", 5000);
            BelarusBank.AddWithAdditionalSumInvestor("Vladislav", 14000, 200);
            BelarusBank.AddNoAdditionalSumInvestor("Anya", 7000);
            Assert.AreEqual(BelarusBank.GetTotalSum(), 26200);
        }

        [TestMethod()]
        public void GetTotalSumTest3()
        {
            Bank VTB = new Bank();
            VTB.AddNoAdditionalSumInvestor("Georgi", 8000);
            VTB.AddWithAdditionalSumInvestor("Vladislav", 19000, 800);
            VTB.AddNoAdditionalSumInvestor("Marya", 4000);
            Assert.AreEqual(VTB.GetTotalSum(), 31800);
        }

        [TestMethod()]
        public void GetInvestorDeposit1()
        {
            Investor first = new Investor("Georgi", new NoAdditionalSum(8000));
            Assert.AreEqual(first.GetInvestorDeposit(), 8000);
        }

        [TestMethod()]
        public void GetInvestorDeposit2()
        {
            Investor first = new Investor("Andrey", new NoAdditionalSum(100));
            Assert.AreEqual(first.GetInvestorDeposit(), 100);
        }

        [TestMethod()]
        public void GetInvestorDeposit3()
        {
            Investor second = new Investor("Mari", new WithAdditionalSum(10000, 700));
            Assert.AreEqual(second.GetInvestorDeposit(), 10700);
        }

        [TestMethod()]
        public void GetInvestorDeposit4()
        {
            Investor second = new Investor("Nina", new WithAdditionalSum(20000, 1000));
            Assert.AreEqual(second.GetInvestorDeposit(), 21000);
        }
    }
}