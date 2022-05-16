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
    public class BankTests
    {
        [TestMethod()]
        public void getInstanceTest()
        {
            Bank bank1 = Bank.getInstance("BelarusBank");
            Bank bank2 = Bank.getInstance("VTB");
            Assert.AreEqual(bank1, bank2);
        }

        [TestMethod()]
        public void EditDepositTest()
        {
            Bank bank = Bank.getInstance("BelarusBank");
            int[] deposit = { 500, 1000, 1500 };
            int[] result = { 500, 1000, 1500 };
            for (int i = 0; i < 3; i++)
            {
                bank.EditDeposit = deposit[i];
                Assert.AreEqual(bank.EditDeposit, result[i]);
            }
        }

        [TestMethod()]
        public void TotalSumTest()
        {
            Bank bank = Bank.getInstance("BelarusBank");
            int[] deposit = { 500, 1000, 1500 };
            int[] procent = { 10, 20, 5 };
            int[] number_of_deposit = { 2, 3, 4 };
            int[] result = { 1100, 3600, 6300 };
            for (int i = 0; i < 3; i++)
            {
                bank.EditDeposit = deposit[i];
                bank.NumberOfDeposits = number_of_deposit[i];
                bank.EditInterestRate = procent[i];
                Assert.AreEqual(bank.TotalSum(), result[i]);
            }
        }
    }
}