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
            int n, k;
            Console.Write("Введите колличество элементов в массиве: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int[] A = new int[n];
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(k = (2 * i) - 1);
                }
            }
            else Console.WriteLine("Условие не правильно: ");
            Console.ReadKey();
        }
    }
}
