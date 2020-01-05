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
              int[] a = new int[n];
             double[] b = new double[n];
             double sum = 0;
              for (int i = 0; i < n; i++)
                 {
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                 }
             for (int i = 0; i < n; i++)
                 {
                sum += a[i];
                b[i] = sum / (i + 1);
                 }
             foreach (double i in b) Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
