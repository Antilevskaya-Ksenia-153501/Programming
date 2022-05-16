using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Deposit
    {
        private double money;
        public Deposit(double money)
        {
            this.money = money;
        }

        public Deposit()
        {
            money = 1000;
        }

        public double Change_Deposit
        {
            get
            {
                return money;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error!!! You entered negative deposit");
                    money = 1000;
                    return;
                }
                money = value;
            }
        }
    }
}
