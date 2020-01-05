using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Треугольник со сторонами a, b, c является прямоугольным");
            Console.WriteLine("Введите первый катет треугольника а ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второй катет треугольника b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите гипотенузу треугольника c ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (c * c == a * a + b * b)
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
