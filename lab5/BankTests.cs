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
            Bank Belinvestbank = new Bank();
            Belinvestbank.AddCustomer("Ivan", CustomerType.usual, 100, 5);
            Belinvestbank.AddCustomer("Anya", CustomerType.usual, 200, 7);
            Belinvestbank.AddCustomer("Sergey", CustomerType.VIP, 500, 6);
            Assert.AreEqual(Belinvestbank.GetTotalSum(), 849);
        }

        [TestMethod()]
        public void GetTotalSumTest2()
        {
            Bank Belinvestbank = new Bank();
            Belinvestbank.AddCustomer("Ivan", CustomerType.usual, 400, 6);
            Belinvestbank.AddCustomer("Anya", CustomerType.usual, 100, 7);
            Belinvestbank.AddCustomer("Sergey", CustomerType.VIP, 450, 6);
            Assert.AreEqual(Belinvestbank.GetTotalSum(), 1008);
        }

        [TestMethod()]
        public void GetTotalSumTest3()
        {
            Bank Belinvestbank = new Bank();
            Belinvestbank.AddCustomer("Ivan", CustomerType.usual, 300, 6);
            Belinvestbank.AddCustomer("Anya", CustomerType.usual, 100, 7);
            Belinvestbank.AddCustomer("Sergey", CustomerType.VIP, 450, 6);
            Assert.AreEqual(Belinvestbank.GetTotalSum(), 902);
        }

    }
}