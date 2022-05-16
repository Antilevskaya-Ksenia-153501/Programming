using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public enum CustomerType {VIP, usual};
    public class Customer
    {
        private string customerName;
        private CustomerType status;
        private Deposit customerDeposit;
        public Customer(string name, CustomerType ct, double money, double interestRate)
        {
            customerName = name;
            status = ct;
            customerDeposit = new Deposit(money, interestRate);
        }
        public string Name
        {  
            get
            {
                if (customerName == null)
                {
                    Console.WriteLine("Error!!! Customer's name is null");
                    return "Null";
                }
                return customerName;
            }
            set
            {
                customerName = value;

            }
        }
        public void IncreaseDeposit(double temp_money)
        {
            customerDeposit.Change_Deposit = temp_money + customerDeposit.Change_Deposit;
        }
        public double ReturnDeposit()
        {
            return customerDeposit.Change_Deposit;
        }
        public double ReturnInterestRate()
        {
            return customerDeposit.Change_InterestRate;
            
        }

    }
}
