using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSubDivMultApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, Sum, Sub, Div, Multi;
            Console.WriteLine("Enter First Number:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            B = int.Parse(Console.ReadLine());
            Sum = A + B;
            Console.WriteLine("Additon result: {2}", Sum);
            Console.Read();
        }
    }
}
