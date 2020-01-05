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
            double[,] a = new double[2, n];
            double maxL1 = 0, maxL2 = 0, L, cx, cy, P;
            int max1 = 0, max2 = 0, max3 = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"X{i + 1} = ");
                a[0, i] = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Y{i + 1} = ");
                a[1, i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    L = Math.Sqrt(Math.Pow(a[0, j] - a[0, i], 2) + Math.Pow(a[1, j] - a[1, i], 2));
                    if (maxL1 < L)
                    {
                        maxL1 = L;
                        max1 = i;
                        Console.ReadKey();
                    }
                }
            }
        }
    }

