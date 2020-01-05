using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1кг - ");
            double x = Convert.ToDouble(Console.ReadLine());
            for (double i = 0.1; i <= 1; i += 0.1)
            {
                Console.WriteLine("{0}кг - {1}", i, x * i);
            }
            Console.ReadKey();
        }
    }
}
