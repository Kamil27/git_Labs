using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
             int n = Convert.ToInt32(Console.ReadLine());
             int?[] a = new int?[n];
             int?[] b;
              int i;
              int? deleted;
              for (i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            i = 0;
             while (i < a.Length)
            {
                b = Array.FindAll<int?>(a, x => x == a[i]);
                 if (b.Length == 2)
                {
                    deleted = a[i];
                     for (int j = i; j < a.Length; j++)
                        {
                         if (a[j] == deleted)
                        {
                            a[j] = null;
                        }
                    }
                    a = a.Where(x => x != null).ToArray();
                     }
                 else i++;
                 }
             foreach (int j in a) Console.Write(j + " ");
            Console.ReadKey();
        }
    }
}
