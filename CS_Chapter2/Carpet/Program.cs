using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = 9.4;
            double w = 3.7;
            double area = l * w;
            double cost = 2 * area;
            Console.WriteLine("Cost of carpeting per sqaure foot is {0}", cost.ToString("C"));
        }
    }
}
