using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task1
{
    public class Program
    {
        public static string discriminant(double a, double b, double c)
        {
            double result = b * b - 4 * a * c;

            if (result < 0)
                return "There is no solution for such equation ";
            else
                return "The equation has a solution ";
        }
        static void Main(string[] args)
        {
            double a, b, c;
            string result;
            int solution = 0;
            do
            {
                Console.WriteLine("What do you want: 1) check the equation; 2) exit;");
                while (!int.TryParse(Console.ReadLine(), out solution))
                {
                    Console.WriteLine("Error! Try again");
                }
                switch (solution)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("There is equation of the form ax^2 + bc + c = 0 ");

                            Console.WriteLine("Enter coefficient a: ");
                            while (!double.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Error! Try again");
                            }

                            Console.WriteLine("Enter coefficient b: ");
                            while (!double.TryParse(Console.ReadLine(), out b))
                            {
                                Console.WriteLine("Error! Try again");
                            }

                            Console.WriteLine("Enter coefficient c: ");
                            while (!double.TryParse(Console.ReadLine(), out c))
                            {
                                Console.WriteLine("Error! Try again");
                            }

                            result = discriminant(a, b, c);
                            Console.WriteLine(result);
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Exit");
                            System.Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Error! Try again");
                            break;
                        }
                }
            } while (solution != 2);
        }
    }
}
