using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public interface Deposit
    {
        int GetDeposit();
    }
    public class NoAdditionalSum : Deposit
    {
        private int deposit;
        public NoAdditionalSum(int other)
        {
            deposit = other;
        }
        public int GetDeposit()
        {
            return deposit;
        }
    }
    public class WithAdditionalSum : Deposit
    {
        private int deposit;
        private int additional_sum;
        public WithAdditionalSum(int other1, int other2)
        {
            deposit = other1;
            additional_sum = other2;
        }
        public int GetDeposit()
        {
            return deposit + additional_sum;
        }
    }
    public class Investor
    {
        private Deposit investor_deposit;
        private string name;
        public Investor(string other1, Deposit other2)
        {
            name = other1;
            investor_deposit = other2;
        }
        public string Name { get; set; }
        public int GetInvestorDeposit()
        {
            return investor_deposit.GetDeposit();
        }
    }
    public class Bank
    {
        List<Investor> lstClients = new List<Investor>();
        public void AddNoAdditionalSumInvestor(string name, int deposit)
        {
            Investor client = new Investor(name, new NoAdditionalSum(deposit));
            lstClients.Add(client);
        }
        public void AddWithAdditionalSumInvestor(string name, int deposit, int additional_sum)
        {
            Investor client = new Investor(name, new WithAdditionalSum(deposit, additional_sum));
            lstClients.Add(client);
        }
        public int GetTotalSum()
        {
            int sum = 0;
            foreach (Investor client in lstClients)
            {
                sum += client.GetInvestorDeposit();
            }
            return sum;
        }
    }
}
