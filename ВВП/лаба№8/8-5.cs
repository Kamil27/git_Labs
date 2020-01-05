using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int A = Convert.ToInt32(Console.ReadLine());
            if (A > 0 && A % 2 == 0)
            {
                Console.Write("Число " + A + " является положительным чётным");
            }
            if (A < 0 && A % 2 == 0)
            {
                Console.Write("Число " + A + " является отрицательным чётным");
            }
            if (A > 0 && A % 2 != 0)
            {
                Console.Write("Число " + A + " является положительным нечётным");
            }
            if (A < 0 && A % 2 != 0)
            {
                Console.Write("Число " + A + " является отрицательным нечётным");
            }
            if (A == 0)
            {
                Console.Write("Число " + A + " является нулевым");
            }
            Console.ReadKey();
        }
    }
}
