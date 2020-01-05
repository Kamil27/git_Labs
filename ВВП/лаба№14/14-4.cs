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
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = -1;
            for (int i = n - 2; i > 0; i--)
            {
                if (a[i] > a[i + 1] && a[i] > a[i - 1])
                {
                    max = i;
                    break;
                }

            }
            if (max == -1) Console.WriteLine("Нет локального максимума");
            else Console.WriteLine($"Номер последнего локального максимума = {a[max]}");
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
