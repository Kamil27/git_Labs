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
              int[,] a = new int[2, n];
             double maxL = 0, L;
              int max = 0;
              for (int i = 0; i < n; i++)
                 {
                Console.Write($"X{i + 1} = ");
               a[0, i] = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Y{i + 1} = ");
                a[1, i] = Convert.ToInt32(Console.ReadLine());
                 if (a[0, i] < 0 && a[1, i] > 0)
                    {
                    L = Math.Sqrt(a[0, i] * a[0, i] + a[1, i] * a[1, i]);
                     if (maxL < L)
                        {
                        maxL = L;
                        max = i;
                         }
                     }
                 }
             if (maxL != 0)
                 {
                Console.WriteLine("Max({0},{1})", a[0, max], a[1, max]);
                 }
             else Console.WriteLine("(0,0)");
            Console.ReadKey();
        }
    }
}
