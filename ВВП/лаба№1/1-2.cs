using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double d;
            Console.WriteLine("введите диаметр");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine("L = " + (3.14 * d));
            Console.ReadKey();
        }
    }
}
