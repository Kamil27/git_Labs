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
            Console.Write("Введите первое число А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int a = A, b = B;
            while (a > 1 && b > 1)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            if (a > b)
            {
                Console.WriteLine("НОД чисел {0} и {1} равен {2}", A, B, a);
            }
            else
            {
                Console.WriteLine("НОД чисел {0} и {1} равен {2}", A, B, b);
                Console.ReadKey();
            }
        }
    }
}

