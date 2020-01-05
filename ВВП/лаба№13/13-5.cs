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
            int N;
            Console.WriteLine("Введите размер массива");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Массив А");
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Новый массив");
            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0) Console.Write(A[i] + " ");
                else continue;
            }
            for (int i = N; i >= 0; i--)
            {
                if (i % 2 == 1 && i != 0) Console.Write(A[i] + " ");
                else continue;
            }
            Console.ReadLine();
        }
    }
}
