using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, a, b, S, P;
            Console.WriteLine("введите координаты x1 ");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите координаты x2 ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите координаты y1 ");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите координаты y2 ");
            y2 = double.Parse(Console.ReadLine());
            a = Math.Pow(x1 - x2, 2);
            b = Math.Pow(y1 - y2, 2);
            Console.WriteLine(Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))));
            P = 2 * (a + b);
            Console.WriteLine("P =  " + P);
            S = a * b;
            Console.WriteLine("S =  " + S);
            Console.ReadKey();
        }
    }
}
