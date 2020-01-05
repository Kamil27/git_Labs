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
            int m, n, i, j, sum = 0;
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
            int k, v = 0;
            for (i = 0; i < n * 2 - 1; i++)
            {
                sum = 0;
                k = i;
                if (i >= n) { k = n - 1; ++v; };

                for (j = k; j > v - 1; --j)
                {
                    sum += a[k + v - j, j];
                }
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }
    }
}
