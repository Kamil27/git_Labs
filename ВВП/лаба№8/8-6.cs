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
            Console.Write("Введите положительное число: ");
            int A = Convert.ToInt32(Console.ReadLine());
            if (1000 > A && A > 99 && A % 2 == 0)
            {
                Console.Write("Число " + A + " является трёхзначным чётным");
            }
            if (100 > A && A > 9 && A % 2 == 0)
            {
                Console.Write("Число " + A + " является двухзначным чётным");
            }
            if (10 > A && A > 0 && A % 2 == 0)
            {
                Console.Write("Число " + A + " является однозачным чётным");
            }
            if (1000 > A && A > 99 && A % 2 != 0)
            {
                Console.Write("Число " + A + " является трёхзначным нечётным");
            }
            if (100 > A && A > 9 && A % 2 != 0)
            {
                Console.Write("Число " + A + " является двухзначным нечётным");
            }
            if (10 > A && A > 0 && A % 2 != 0)
            {
                Console.Write("Число " + A + " является однозначным нечётным");
            }
            if (A == 0 || A < 0 || A > 999)
            {
                Console.Write("Ошибка!");
            }
            Console.ReadKey();
        }
    }
}
