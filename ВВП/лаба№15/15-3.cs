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
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int last = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = n - 1; i >= 0; i--)
            {
                if (a[i] % 2 != 0)
                {
                    last = a[i];
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0) a[i] += last;

                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
