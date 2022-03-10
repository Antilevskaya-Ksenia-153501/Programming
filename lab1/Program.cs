using System;

namespace _153501_Antilevskaya
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, result;

            Console.WriteLine("Enter dividend: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter divider: ");
            b = Convert.ToInt32(Console.ReadLine());

            result = a / b;
            Console.WriteLine("The result: " + result);
        }
    }
}
