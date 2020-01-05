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
            int N, a, b, c;
            Console.Write("Введите трёхзначное число: ");
            N = Convert.ToInt32(Console.ReadLine());
            N = Math.Abs(N);
            c = N % 10;
            b = N / 10 % 10;
            a = N / 100;
            Console.WriteLine((b - a) * (c - b) > 0);
            Console.ReadKey();
        }
    }
}
