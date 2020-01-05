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
            double start = 1000, X = 0;
            int K = 0;
            Console.Write("Введите процентную ставку P(0 < P < 25): ");
            double P = Convert.ToDouble(Console.ReadLine());
            if (0 > P || P > 25)
            {
                Console.WriteLine("Error!");
                Environment.Exit(0);
            }
            while (start <= 1100)
            {
                X = start * (P / 100);
                K++;
                start += X;
            }
            Console.WriteLine("Итоговый размер вклада равен {0}, а количество месяцев, через которое размер вклада превысит 1100 руб., равен {1}", start, K);
            Console.ReadKey();
        }

    }
}

