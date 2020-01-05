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
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("M = ");
            int m = Int32.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            string[] s;
            bool k = true;
            int i, j;
            for (i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split();
                for (j = 0; j < n; j++)
                {
                    a[i, j] = Int32.Parse(s[j]);
                }
            }
            for (i = 0; i < m; i++)
            {
                k = true;
                for (j = 0; j < n; j++)
                {
                    if (a[j, i] % 2 == 0)
                    {
                        k = false;
                        continue;
                    }
                }
                if (k == true) break;
            }
            if (i == m && k == false) Console.WriteLine(0);
            else Console.WriteLine(i + 1);
            Console.ReadKey();
        }
    }
}
