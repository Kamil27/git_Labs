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
            int m, i, j;
            Console.WriteLine("Введите m: ");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[m, m];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write("a[" + i + ", " + j + "] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            if (m == 3)
            {
                Console.WriteLine(a[0, 0] + " " + a[1, 0] + " " + a[2, 0] + " " + a[2, 1] + " " + a[2, 2] + " " + a[1, 2] + " " + a[0, 2] + " " + a[0, 2] + " " + a[1, 1]);
            }
            if (m == 5)
                Console.WriteLine(a[0, 0] + " " + a[1, 0] + " " + a[2, 0] + " " + a[3, 0] + " " + a[4, 0] + " " + a[4, 1] + " " + a[4, 2] + " " + a[4, 3] + " " + a[4, 4] + " " + a[3, 4] + " " + a[2, 4] + " " + a[1, 4] + " " + a[0, 4] + " " + a[0, 3] + " " + a[0, 2] + " " + a[0, 1] + " " + a[1, 1] + " " + a[2, 1] + " " + a[3, 1] + " " + a[3, 2] + " " + a[3, 3] + " " + a[2, 3] + " " + a[1, 3] + " " + a[1, 2] + " " + a[2, 2]);
            Console.ReadKey();
        }


        }
    }


