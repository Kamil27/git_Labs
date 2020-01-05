using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B;
            Console.Write("A= ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write("B= ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((A > 2) && (B <= 3));
            Console.ReadKey();
        }
    }
}
