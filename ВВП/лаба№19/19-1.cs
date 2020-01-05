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
            int m, n, i, j, min = 10000, max = 0, bi = 0, bj = 0, mi = 0, mj = 0, k;
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
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (a[i, j] < min) { min = a[i, j]; mi = i; mj = j; }
                    if (a[i, j] > max) { max = a[i, j]; bi = i; bj = j; }
                }
                for (j = 0; j < n; j++)
                {
                    k = a[mi, mj];
                    a[mi, mj] = a[bi, bj];
                    a[bi, bj] = k;
                    min = 10000; max = 0;
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
