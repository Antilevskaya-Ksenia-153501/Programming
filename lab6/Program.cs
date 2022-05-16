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
            DateTime now = DateTime.Now;
            Product milk = new Product("молоко", 20, Convert.ToDateTime("01.05.2022"), 14);
            Console.WriteLine(milk.Info());
            Console.WriteLine(milk.IsCorrespondsToWorkingLife(now) ? "Годен" : "Не годен");
            Console.WriteLine();

            Product kefir = new Product("кефир ", 30, Convert.ToDateTime("02.05.2022"), 6);
            Console.WriteLine(kefir.Info());
            Console.WriteLine(kefir.IsCorrespondsToWorkingLife(now) ? "Годен" : "Не годен");
            Console.WriteLine();

            Batch youghurt = new Batch("актимель", 15, Convert.ToDateTime("04.04.2022"), 4, 21);
            Console.WriteLine(youghurt.Info());
            Console.WriteLine(youghurt.IsCorrespondsToWorkingLife(now) ? "Годен" : "Не годен");
            Console.WriteLine();
            
            Console.WriteLine(youghurt.Sold(22));
            Console.WriteLine(milk.Sold());
            milk.Buy();
            youghurt.Buy();
            Console.ReadLine();
        }
    }
    
}
