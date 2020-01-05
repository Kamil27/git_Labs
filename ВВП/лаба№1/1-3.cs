using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("введите числа");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("среднее арифметичское" + ((a + b) / 2));
            Console.ReadKey();
         }
    }
}
