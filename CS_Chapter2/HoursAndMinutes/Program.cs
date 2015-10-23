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
            double m = 140;
            double h = m / 60;
            Console.WriteLine("{0} minutes is equal to {1} hours and {2} minutes.", m, m / 60, m % 60);
        }
    }
}