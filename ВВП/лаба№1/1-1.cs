using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Введите стороны прямоугольника: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь = " + (a * b));
            Console.WriteLine("Периметр = " + (2 * (a + b)));
            Console.ReadKey();
        }
    }
}

