using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSubMultDivApp
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
            Console.WriteLine("Additon Result:" + (a + b));
            Console.WriteLine("Subtraction Result:" + (a - b));
            Console.WriteLine("Multiplication Result:" + (a*b));
            Console.WriteLine("Division Result:" + (a/b));
            Console.Read();

        }
    }
}
