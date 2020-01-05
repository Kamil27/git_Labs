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
            Console.Write("Введите число N > 1 : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 1, K = 1;
            if (N <= 1)
            {
                Console.WriteLine("Error!");
                Environment.Exit(0);
            }
            while (sum < N)
            {
                K++;
                sum += K;
            }

            Console.WriteLine("Наименьшее из целых чисел является число {0}, а сумма равна {1}", K, sum);
            Console.ReadKey();
        }
    }

}
    
