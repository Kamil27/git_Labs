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
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("M = ");
            int m = Int32.Parse(Console.ReadLine());
            int k;
            int[,] a = new int[n, m];
            int[] aV = new int[m];
            string[] s;
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Int32.Parse(s[j]);
                }
            }
            for (int i = 0; i < m; i++)
            {
                k = 0;
                for (int j = 0; j < n; j++)
                {
                    aV[j] = a[j, i];
                }
                for (int j = 0; j < n; j++)
                    if (a[j, i] > aV.Average())
                    {
                        k++;
                    }
                Console.WriteLine($"Столбец №{i + 1}: k = {k}");
            }
            Console.ReadKey();
        }
    }
}
