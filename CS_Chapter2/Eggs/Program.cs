using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            double C1 = 19;
            double C2 = 16;
            double C3 = 11;
            double C4 = 14;
            double sum = C1 + C2 + C3 + C4;
            double dozen = sum / 12;
            double remainder = sum % 12;
            // find the number of eggs produced in a month by each of the chickens
            Console.WriteLine("The sum of eggs layed by all the chickens is {0} eggs.", sum);
            Console.WriteLine("There are {0} dozen eggs with {1} eggs remaining", dozen, remainder);
        }
    }
}
