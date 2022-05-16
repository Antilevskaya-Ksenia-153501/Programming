using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank Belinvestbank = new Bank();
            Belinvestbank.AddCustomer("Ivan", CustomerType.usual, 100, 5);
            Belinvestbank.AddCustomer("Anya", CustomerType.usual, 200, 7);
            Belinvestbank.AddCustomer("Sergey", CustomerType.VIP, 500, 6);

            Belinvestbank.LogIn("Ivan");
            Belinvestbank.ChangeCustomerDeposit(800);
            Belinvestbank.LogOut();

            Belinvestbank.LogIn("Anya");
            Belinvestbank.ChangeCustomerDeposit(400);
            Belinvestbank.LogOut();

            Console.WriteLine(Belinvestbank.GetTotalSum());
            Console.WriteLine(Belinvestbank.GetDepositByName("Ivan"));
            Console.WriteLine(Belinvestbank.GetDepositByName("Anya"));
        }
    }
}
