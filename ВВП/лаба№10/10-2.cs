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
            Console.Write("N = ");
            double N = Convert.ToDouble(Console.ReadLine());
            double x = 1, k = 1.1;
            if (N > 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    x *= k;
                    k += 0.1;
                }
                Console.WriteLine(x);
            }
            else Console.WriteLine("Условие не правильно:");
            Console.ReadKey();
        }
    }
}
