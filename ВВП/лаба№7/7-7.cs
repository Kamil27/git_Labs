using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Существует треугольник со сторонами a, b, c");
            Console.WriteLine("Введите cторону треугольника а ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону треугольника b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону треугольника c ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a + b > c)
            {
                Console.WriteLine("Высказывание истинно");
            }
            else if (b + c > a)
            {
                Console.WriteLine("Высказывание истинно");
            }
            else if (a + c > b)
            {
                Console.WriteLine("Высказывание истинно");
            }
            else
            {
                Console.WriteLine("Высказывание не истинно");
            }
            Console.ReadKey();
        }
    }
}
