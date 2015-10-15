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
            string chicken, chicken2, chicken3, chicken4;
            int egg, egg2, egg3, egg4;

            Console.WriteLine("Enter the first integer");
            chicken= Console.ReadLine();
            egg= Convert.ToInt32(chicken);

            Console.WriteLine("Enter the second integer");
            chicken2= Console.ReadLine();
            egg2 = Convert.ToInt32(chicken2);

            Console.WriteLine("Enter the third integer");
            chicken3= Console.ReadLine();
            egg3 = Convert.ToInt32(chicken3);

            Console.WriteLine("Enter the forth integer");
            chicken4= Console.ReadLine();
            egg4 = Convert.ToInt32(chicken4);
            int sum = egg + egg2 + egg3 + egg4;
            Console.WriteLine("the sum of {0} and {1} and {2} and {3} is {4}", chicken, chicken2, chicken3, chicken4, sum);

        }
    }
}
