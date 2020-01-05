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
            HashSet<int> hs = new HashSet<int>();
            Console.Write("Введите размер массива: ");
              int n = Convert.ToInt32(Console.ReadLine()), j = 0, i = 0;
              int[] a = new int[n];
             for (i = 0; i < n; i++)
                 {
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                 if (hs.Contains(a[i]))
                     {
                    j = i;
                     }
                 else hs.Add(a[i]);
                }
            i = 1;
            while (a[i] != a[j]) i++;
            Console.WriteLine($"{i}, {j}");
            Console.ReadKey();


        }
    }
}
