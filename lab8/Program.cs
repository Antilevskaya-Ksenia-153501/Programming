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
            Bank BelinvestBank = new Bank();
            BelinvestBank.AddNoAdditionalSumInvestor("Ivan", 3200);
            BelinvestBank.AddWithAdditionalSumInvestor("Vladislav", 1000, 100);
            Console.WriteLine("The total sum of deposits - {0}", BelinvestBank.GetTotalSum());
            Console.ReadLine();
        }
    }
}
