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
            Console.WriteLine("The first polynom is given by system");
            Polynom first = new Polynom(2, 4, 6);
            Polynom second = new Polynom();
            int a, b, c;
            Console.WriteLine("Enter coefficients for second polynom");
            Console.WriteLine("Enter сoefficient a:");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Error!Enter int a");
            }
            second.Set_Koef_a = a;

            Console.WriteLine("Enter сoefficient b:");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Error!Enter int b");
            }
            second.Set_Koef_b = b;

            Console.WriteLine("Enter сoefficient c:");
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Error!Enter int b");
            }
            second.Set_Koef_c = c;
            Console.Clear();
            Console.WriteLine("The first polynom: ");
            Console.WriteLine(first.ToString());
            Console.WriteLine("The second polynom: ");
            Console.WriteLine(second.ToString());

            Console.WriteLine("The sum of the first and second polymons: ");
            Polynom sum = first + second;
            Console.WriteLine(sum.ToString());

            Console.WriteLine("The difference of the first and second polymons: ");
            Polynom diff = first - second;
            Console.WriteLine(diff.ToString());

            Console.WriteLine("The dividing of the first polynom by 2: ");
            Polynom div = first / 2;
            Console.WriteLine(div.ToString());

            Console.WriteLine("The multiplying of the second polynom by 2: ");
            Polynom mult = second * 2;
            Console.WriteLine(mult.ToString());

            Console.WriteLine("The -- of the first polynom: ");
            first--;
            Console.WriteLine(first.ToString());
            
            Console.WriteLine("The ++ of the second polynom: ");
            second++;
            Console.WriteLine(second.ToString());

            if (first != second)
                Console.WriteLine("The polynoms are not equal");

            int koef_a = (int)first;
            Console.WriteLine("The reduction to int - {0}", koef_a);

            Polynom temp = (Polynom)koef_a;
            Console.WriteLine("The reduction to polynom - {0}", temp);
            Console.ReadLine();
        }
    }
}
