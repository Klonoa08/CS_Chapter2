using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 197;
            double h = m / 60;
            Console.WriteLine("{0} minutes is equal to {0} hours and {1} minutes.", m / 60, m % 60);
        }
    }
}