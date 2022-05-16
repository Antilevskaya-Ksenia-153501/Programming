using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Deposit
    {
        private double money;
        private double interestRate;
        public Deposit(double money, double interestRate)
        {
            this.money = money;
            this.interestRate = interestRate;
        }
        public Deposit()
        {
            money = 100;
            interestRate = 5;
        }
        public double Change_Deposit
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }
        public double Change_InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                interestRate = value;
            }
        }
    }
}
