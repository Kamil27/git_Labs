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
             int n = Convert.ToInt32(Console.ReadLine());
              int[] a = new int[n];
              int i, temp, k;
             for (i = 0; i < n; i++)
                 {
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                  }
             do
                 {
                k = 0;
                 for (i = 1; i < n; i++)
                     {
                     if (a[i - 1] > a[i])
                         {
                        temp = a[i - 1];
                        a[i - 1] = a[i];
                        a[i] = temp;
                        k = i;
                        }
                     }
                 }
             while (k > 0) ;
             foreach (int j in a) Console.Write(j + " ");
            Console.ReadKey();
        }
    }
}
