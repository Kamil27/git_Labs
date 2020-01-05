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
               double s = 0;
            Console.Write("N = ");
             int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("K = ");
             int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("L = ");
              int l = Convert.ToInt32(Console.ReadLine());
              double[] a = new double[n];
            Console.WriteLine("Введите массив:");
             for (int i = 0; i < n; i++)
                 {
                a[i] = Convert.ToInt32(Console.ReadLine());
                 }
             for (int i = k - 1; i < l; i++)
                 {
                s += a[i];
                 }
            Console.WriteLine("Результат: "+s / (l - k + 1));
            Console.ReadKey();



        }
    }
}
