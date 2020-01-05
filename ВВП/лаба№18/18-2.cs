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
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("M = ");
            int m = Int32.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = Int32.Parse(Console.ReadLine()) - 1;
            int sum = 0, prod = 1;
            int[,] a = new int[n, m];
            string[] s;
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Int32.Parse(s[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                sum += a[k, i];
                prod *= a[k, i];
            }
            Console.WriteLine($"sum = {sum}\nprod = {prod}");
            Console.ReadKey();
        }
    }
}
