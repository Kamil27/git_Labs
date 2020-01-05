using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("M = ");
            int m = Int32.Parse(Console.ReadLine());
            int prod, min = int.MaxValue, k = 0;
            int[,] a = new int[n, m];
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
                prod = 1;
                for (int j = 0; j < n; j++)
                {
                    prod *= a[j, i];
                }
                if (min > prod)
                {
                    min = prod;
                    k = i;
                }
            }
            Console.WriteLine($"Номер столбца - {k + 1}\nПроизведение - {min}");
            Console.ReadKey();
        }
    }
}

