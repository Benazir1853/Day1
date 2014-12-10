using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 1;
            for (i = 1; i <= 100; i++)
            {
                Console.WriteLine( +i );

            }
            Console.Read();
        }
    }
}
