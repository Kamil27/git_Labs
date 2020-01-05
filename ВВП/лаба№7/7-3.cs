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
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());

            if ((a % 2) == 0)
            {
                if ((a / 100) == 0)
                {
                    Console.WriteLine("Число целое и двузначное.");
                }
                else
                {
                    Console.WriteLine("Не является двузначным.");
                }
            }
            else
            {
                Console.WriteLine("Не является четным.");
            }
            Console.ReadKey();
        }
    }
}
