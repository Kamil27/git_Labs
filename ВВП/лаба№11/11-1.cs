using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B, большее чем А: ");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A >= B)
            {
                Console.WriteLine("Error!");
                Environment.Exit(0);
            }
            int i, x;
            for (i = A; i <= B; i++)
            {
                for (x = i; x > 0; x--)
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                }
            }
        }
    }
}

