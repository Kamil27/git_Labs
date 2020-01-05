using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
              static void Swap(ref int a, ref int b)
  {
                 int temp = a;
                a = b;
                b = temp;
                 }
             static void Main(string[] args)
 {
                Console.Write("N = ");
                 int n = Convert.ToInt32(Console.ReadLine());
                 int[] a = new int[n];
                 int[] b = new int[n];
                 for (int i = 0; i < n; i++)
                     {
                    Console.Write($"a[{i}] = ");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                     }
                 for (int i = 0; i < n; i++)
                     {
                    Console.Write($"b[{i}] = ");
                    b[i] = Convert.ToInt32(Console.ReadLine());
                     }
                 for (int i = 0; i < n; i++)
                     {
                    Swap(ref a[i], ref b[i]);
                     }
                Console.Write("A: ");
                 foreach (int i in a) Console.Write(i + " ");
                Console.WriteLine();
                Console.Write("B: ");
                foreach (int i in b) Console.Write(i + " ");
                Console.ReadKey();
            }

        }
    }

