using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintRangesOfIntegerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (i = a; i <= b; i++)
            {
                Console.WriteLine(+i);
            }
            Console.Read();
        }
    }
}
