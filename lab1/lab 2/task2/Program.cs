using System; // variant 5

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int solution = 0;
            do
            {
                Console.WriteLine("What do you want: 1) check the point; 2) exit;");
                while (!int.TryParse(Console.ReadLine(), out solution))
                {
                    Console.WriteLine("Error! Try again");
                }
                switch (solution)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Enter point coordinates (x,y)\n x : ");
                            while (!int.TryParse(Console.ReadLine(), out x))
                            {
                                Console.WriteLine("Error! Try again");
                            }

                            Console.Write("\n y : ");
                            while (!int.TryParse(Console.ReadLine(), out y))
                            {
                                Console.WriteLine("Error! Try again");
                            }

                            if ((x * x + y * y < 64) && (x * x + y * y > 9) && x <= 0)
                                Console.Write("The point lies inside the graph\n");
                            else if (((x * x + y * y == 64) || (x * x + y * y == 9)) && x <= 0)
                                Console.Write("The point lies on the border of the graph\n");
                            else Console.Write("The point lies outside the graph\n");
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
