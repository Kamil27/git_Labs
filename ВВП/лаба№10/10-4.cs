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
            Console.Write("A = ");
            double a = Convert.ToDouble(Console.ReadLine()), x = 1;
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    x += Math.Pow(a, i);
                }
                Console.WriteLine(x);
            }
            else Console.WriteLine("Условие не правильно:");
            Console.ReadKey();
        }
    }
}
