using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (a[i, j] < min) { min = a[i, j]; km = j; }
                    if (a[i, j] > max) { max = a[i, j]; kb = j; }
                }
            }
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (j == km) Console.Write(a[i, kb]);
                    if (j == kb) Console.Write(a[i, km]);
                    if ((j != km) && (j != kb))
                        Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
