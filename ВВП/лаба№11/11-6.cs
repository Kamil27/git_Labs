using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N > 1 : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int f1 = 1, f2 = 1, f = 0, k = 3;
            while (f < n)
            {
                ++k;
                f = f2 + f1;
                f2 = f1;
                f1 = f;
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
