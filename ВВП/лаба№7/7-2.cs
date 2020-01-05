using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            Console.Write("A= ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write("B= ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.Write("C= ");
            C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((A < B) && (B < C));
            Console.ReadKey();
        }
    }
}
