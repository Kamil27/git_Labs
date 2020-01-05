using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("введите числа");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            if (a!= 0 && b!= 0) 
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
                Console.WriteLine("сумма" + (a + b));
                Console.WriteLine("разность" + (a - b));
                Console.WriteLine("произведение" + (a * b));
                Console.WriteLine("частное" + (a / b));
                Console.ReadKey();
            }
        }
    }
}
