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
             int i = 0;
             while (i < n)
                 {
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                  if (a[i] < 0)
                    {
                    Array.Resize<int>(ref a, ++n);
                    a[++i] = 0;
                    }
                i++;
                 }
            foreach (int j in a) Console.Write(j + " ");
            Console.ReadKey();
        }
    }
}
