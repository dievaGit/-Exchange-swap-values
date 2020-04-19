using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializing variables
            int value1 = 5, value2 = 10, interchance = 0;

            //showing the value of the variables
            Console.WriteLine(" The following variables value1 = 5 and value2 = 10");

            //exchanging values
            interchance = value1;
            value1 = value2;
            value2 = interchance;

            //showing exchanged values
            Console.WriteLine(" Now value1 = {0} and value2 = {1}", value1, value2);

            Console.ReadKey();
        }
    }
}
