using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = Bank.getInstance("BelarusBank");
            Console.WriteLine(bank.BankName);
            bank.BankName = "VTB";
            Console.WriteLine(bank.BankName);
            
            bank.NumberOfDeposits = 20;

            bank.EditDeposit = 1000; 
            Console.WriteLine(bank.EditDeposit);

            double resultSum = bank.TotalSum();
            Console.WriteLine(resultSum);

            bank.BankName = "VTB new generation";
            Console.WriteLine(bank.BankName);
        }
    }
}
