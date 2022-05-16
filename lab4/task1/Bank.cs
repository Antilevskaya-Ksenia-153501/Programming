using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Bank
    {
        private static Bank bank;
        private string bankName = "BelinvestBank";
        private int number_of_deposits = 5;
        private double interestRate = 7;
        public Deposit deposit = new Deposit();

        public string BankName
        {
            get
            {
                if (bankName == null)
                {
                    Console.WriteLine("Error!!! Bank name is null");
                    return "Null";
                }
                return bankName;
            }
            set 
            {
                bankName = value;
            }
        }

        public int NumberOfDeposits
        {
            get
            {
                return number_of_deposits;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error!!! Number of deposits is negative");
                    number_of_deposits = 0;
                    return;
                }
                number_of_deposits = value;
            }
        }
        private Bank(string name)
        {
            this.bankName = name;
        }

        public static Bank getInstance(string name)
        {
            if (bank == null)
                bank = new Bank(name);
            return bank;
        }

        public double TotalSum()
        {
            return ((deposit.Change_Deposit + EditInterestRate * deposit.Change_Deposit / 100) * NumberOfDeposits);
        }

        public double EditDeposit
        {
            get 
            {
                return deposit.Change_Deposit; 
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error!!! You entered negative deposit");
                    deposit.Change_Deposit = 1000;
                    return;
                }
                deposit.Change_Deposit = value;
            }
        }
        public double EditInterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error!!! You entered negative interest rate");
                    interestRate = 10;
                    return;
                }
                interestRate = value;
            }
        }
    }
}
