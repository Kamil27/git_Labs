using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            Console.WriteLine("введите a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("введите b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("введите c: ");
            c = double.Parse(Console.ReadLine());
            d = a;
            a = b;
            b = c;
            c = d;
            Console.WriteLine(("A стало " + a + "\nB стало " + b + "\nC стало " + c));
            Console.ReadKey();
        }
    }
}
