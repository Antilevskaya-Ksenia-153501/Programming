using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Calculations
    {
        public static double FunctionCalculations(double z)
        {
            double temp_x = 0;
            double temp_y = 0;
            if (z < -1)
            {
                temp_x = -z / 3;
                Console.WriteLine("Branch 1 (x =  -z / 3)");
            }
            else if (z >= -1)
            {
                temp_x = Math.Abs(z);
                Console.WriteLine("Branch 2 (x = |z|)");
            }
            temp_y = Math.Log(temp_x + 0.5) + (Math.Pow(Math.E, temp_x) - Math.Pow(Math.E, -temp_x));
            return temp_y;
        }
    }
}
