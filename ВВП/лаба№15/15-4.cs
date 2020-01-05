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
              int n = Convert.ToInt32(Console.ReadLine());
             int[] a = new int[n];
              int min = 0, max = 0;
              for (int i = 0; i < n; i++)
                  {
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                  if (a[min] > a[i]) min = i;
                 if (a[max] < a[i]) max = i;
                 }
             if (min > max) for (int i = max + 1; i < min; i++) a[i] = 0;
            if (max > min) for (int i = min + 1; i < max; i++) a[i] = 0;
             foreach (int i in a) Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
