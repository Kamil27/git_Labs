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
            int N, B, A, S = 0;
            Console.Write("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());
            if (N > 2)
            {
                Console.Write("Введите А: ");
                A = int.Parse(Console.ReadLine());
                Console.Write("Введите В: ");
                B = int.Parse(Console.ReadLine());
                int[] M = new int[N];
                Console.WriteLine("Новый массив: ");
                M[0] = A;
                M[1] = B;
                Console.Write("{0} {1} ", M[0], M[1]);
                for (int i = 2; i < N; i++)
                {
                    S = M[i - 2] + M[i - 1];
                    M[i] = S;
                    Console.Write("{0} ", M[i]);
                }
            }
            else Console.WriteLine("Error!");
                Console.ReadKey();
            }


        }
    }

