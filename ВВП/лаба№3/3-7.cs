using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double  a, b;
            Console.Write("A= ");
            a = double.Parse(Console.ReadLine());
            b = a * a;
            a = b * a;
            a = b * a;
            b = a * a;
            a = a * b;
            Console.WriteLine("A^15= " + a);
            Console.ReadKey();
        }
    }
}
