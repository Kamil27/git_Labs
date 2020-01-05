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
              int[] a = new int[n + 2];
              int i, min = 0, max = 0;
             for (i = 0; i < n; i++)
                  {
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                  if (a[min] > a[i]) min = i;
                 if (a[max] < a[i]) max = i;
                }
             if (max > min)
                 {
                for (i = n; i > min; i--)
                     {
                    a[i] = a[i - 1];
                     }
                a[min] = 0;
                max++;
                 for (i = n + 1; i > max; i--)
                     {
                    a[i] = a[i - 1];
                     }
                a[max + 1] = 0;
                 }
             else
                 {
                 for (i = n; i > max; i--)
                     {
                    a[i] = a[i - 1];
                     }
                a[max + 1] = 0;
                min++;
                 for (i = n + 1; i > min; i--)
                     {
                    a[i] = a[i - 1];
                     }
               a[min] = 0;
                 }
             foreach (int j in a) Console.Write(j + " ");
            Console.ReadKey();
        }
    }
}
