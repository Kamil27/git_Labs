using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = 0;
            for (int i = 2; i < n; i += 2)
            {
                if (a[min] > a[i]) min = i;
            }
            Console.WriteLine($"min = {a[min]}");
            Console.ReadKey();
        }
    }
}
