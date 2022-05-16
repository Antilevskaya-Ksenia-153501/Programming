using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"2^2 + 3^2 + 4^2 = {Squaring.FunctinSquaring(2) + Squaring.FunctinSquaring(3) + Squaring.FunctinSquaring(4)}");
        }
    }
}
