using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter First Number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Large Number:" +a);
                Console.WriteLine("Small Number:" +b);

            }
            else if (a < b)
            {
                Console.WriteLine("Large Number:" + b);
                Console.WriteLine("Small Number:" + a);
            }
            else
            {
                Console.WriteLine("They are equal");
            }
            Console.Read();
            
        }
    }
}
