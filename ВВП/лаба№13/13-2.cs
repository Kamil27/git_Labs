using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.Write(" Введите целое число N: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                double[] array = new double[n];
                double N;
                Console.Write(" Введите первый член: ");
                N = Convert.ToDouble(Console.ReadLine());
                array[0] = N;
                double D;
                Console.Write(" Введите знаменатель D геометрической прогрессии: ");
                D = Convert.ToDouble(Console.ReadLine());
                double z = 1;   
                for (int i = 0; i < N; ++i)
                {
                    array[i] = N * z;
                    z *= D;
                }
                for (int i = 0; i < N; ++i)
                    Console.WriteLine(array[i]);
            } else Console.WriteLine("Условие не правильно: ");
            Console.ReadKey();
        }
    }
}

