using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            j = 1;
            for (i = 0; i <= 100;)
            {
                Console.WriteLine(+i);
                int temp = i;
                i = j;
                j = temp + i;
            }
            Console.Read();
        }
    }
}
