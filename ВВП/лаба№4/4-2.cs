using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, pi = 3.14;
                Console.Write("введите угол: ");
            a = double.Parse(Console.ReadLine());
                if ((a > 0) && (a <  180 * 2))
            {
                a = a * pi / 180;
                Console.WriteLine("Угол в радианах: " + a);
            }
            else Console.WriteLine("Угол не подходит по условиям");
            Console.ReadKey();
        }
    }
}
