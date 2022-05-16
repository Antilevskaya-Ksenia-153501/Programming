using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, z;
            Console.WriteLine("Enter z:");
            while (!double.TryParse(Console.ReadLine(), out  z))
            {
                Console.WriteLine("Error! Try again");
            }

            y = Calculations.FunctionCalculations(z);
            Console.WriteLine($"ln(x + 0,5) + (e^x - e^-x) = {y}");
        }
    }
}
