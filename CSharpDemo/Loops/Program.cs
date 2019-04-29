using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loops
            for (int i = 0; i < 10; i++)
            {
                int k = 1;
                Console.WriteLine($"Inside For Loop");
                if (k == 1)
                {
                    Console.WriteLine($"k = 1");
                }
                else
                {
                    Console.WriteLine($"k = 0");

                }
                k = (k + 1) % 2;
                var x = "edwin";
                var x1 = 10;
                while (x1 != 0)
                {
                    Console.WriteLine($"Edwin");
                    x1--;
                }
            }
        }
    }
}
