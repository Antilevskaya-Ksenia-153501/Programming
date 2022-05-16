using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Squaring
    {
        public static uint FunctinSquaring(uint x)
        {
            if (x <= 0)
            {
                Console.WriteLine("Error. The number must be > 0");
                return 0;
            }
            else
            { 
                return (uint)(x * x);
            }
        }
    }
}
