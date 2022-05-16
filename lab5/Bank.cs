using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Bank
    {
        List<Customer> lstCustomers = new List<Customer>();
        Customer currentCustomer;
        public void AddCustomer(string name, CustomerType status, double money, double interestRate)
        {
            lstCustomers.Add(new Customer(name, status, money, interestRate));
        }
        Customer GetCustomerByName(string name)
        {
            foreach (Customer item in lstCustomers)
            {
                if (item.Name == name)
                    return item;
            }
            return null;
        }
        public void ChangeCustomerDeposit(double temp_money)
        {
            currentCustomer.IncreaseDeposit(temp_money);
        }
        public void LogIn(string name)
        {
            if (currentCustomer == null)
                currentCustomer = GetCustomerByName(name);
        }
        public void LogOut()
        {
            currentCustomer = null;
        }
        public double GetTotalSum()
        {
            double sum = 0;
            foreach (Customer item in lstCustomers)
            {
                sum += item.ReturnDeposit() + item.ReturnInterestRate() * item.ReturnDeposit() / 100;
            }
            return sum;
        }
        public string GetDepositByName(string name)
        {
            Customer temp_customer = GetCustomerByName(name);
            string s = "Customer:" + temp_customer.Name + "\n" + "Deposit:" + temp_customer.ReturnDeposit() + "\n" + "Procents:" + temp_customer.ReturnInterestRate();
            return s;
        }
    }
}
