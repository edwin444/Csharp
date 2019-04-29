using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //specifying the variable type
            int temp = 10;
            Console.WriteLine($"First C# pgm id: {temp}");

            //not specifying the variable type
            var temp1 = "Edwin";
            Console.WriteLine($"My name is : {temp1}");
        }
    }
}
