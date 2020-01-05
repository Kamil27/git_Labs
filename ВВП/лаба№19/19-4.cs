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
            int m, n, i, j, k;
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
            for (i = 0; i < n - 1; i++)
            {
                for (int l = i + 1; l < n; l++)
                {
                    if (a[i, 1] > a[l, 1])
                    {
                        for (j = 0; j < m; j++)
                        {
                            int b = a[i, j];
                            a[i, j] = a[l, j];
                            a[l, j] = b;
                        }
                    }
                }
            }
            Console.WriteLine();
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
