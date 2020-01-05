using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace laba2._5
{
    class Program
    {
        static void Main(string[] args)

        {
            double x1, x2, y1, y2, x3, y3, a, b, c,  S, P;
            Console.WriteLine("введите координаты x1 ");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите координаты x2 ");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите координаты y1 ");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите координаты y2 ");
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите координаты x3 ");
            x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите координаты y3 ");
            y3 = double.Parse(Console.ReadLine());
            a = Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            b = Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            c = Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            P = a + b + c;
            Console.WriteLine(" P = " + P);
            S = Sqrt(P / 2 * (P / 2 - a) * (P / 2 - b) * (P / 2 - c));
            Console.WriteLine(" S = {0}", S);
            Console.ReadKey();
        }
    }
}
