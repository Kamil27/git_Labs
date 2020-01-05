using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, i, j, kb = 0, km = 0, min = 10000, max = 0;
            Console.WriteLine("Введите m: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите n: ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("a[" + i + ", " + j + "] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < m / 2; i++)
            {
                for (j = 0; j < n / 2; j++)
                {
                    int tmp = a[i, j];
                    a[i, j] = a[m / 2 + i, n / 2 + j];
                    a[m / 2 + i, n / 2 + j] = tmp;
                }
                Console.WriteLine();
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {

                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
