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
            int N;
            Console.Write("Введите размер массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            int[] M = new int[N];
            Console.WriteLine("Массив А: ");
            for(int i=0; i<N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= N / 2; i++)
            {
                if (i == N / 2 && N % 2 == 0) break;
                Console.Write(A [i] + " ");
                if (i == N / 2 && N % 2 == 1) break;
                Console.Write(A [N - i - 1] + " ");
            }
            Console.ReadKey();
        }
        
    }
}
