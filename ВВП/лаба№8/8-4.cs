using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату Х, не лежащую на оси ОХ: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату Y, не лежащую на оси ОY: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка лежит в I-й четверти");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка лежит в IV-й четверти");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка лежит в II-й четверти");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка лежит в III-й четверти");
            }
            if (x == 0 || y == 0)
            {
                Console.WriteLine("Ошибка!");
            }
            Console.ReadKey();
        }
    }
}
