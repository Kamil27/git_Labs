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
            Console.Write("N = ");
             int n = Convert.ToInt32(Console.ReadLine());
             int[] a = new int[n];
              int i;
              for (i = 0; i < n; i++)
                  {
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                  }
            i = 1;
             while (i < n)
                 {
                 if (a[i] == a[i - 1])
                     {
                     for (int j = i; j < n - 1; j++)
                         {
                        a[j] = a[j + 1];
                        }
                    n--;
                     }
                else i++;
                }
             for (i = 0; i < n; i++) Console.Write(a[i] + " ");
            Console.ReadKey();
        }
    }
}
