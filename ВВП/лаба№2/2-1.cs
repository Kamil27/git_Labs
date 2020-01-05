using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            Console.WriteLine("введите координаты ");
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("L: " + Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2))));
            Console.ReadKey();
        }
    }
}
