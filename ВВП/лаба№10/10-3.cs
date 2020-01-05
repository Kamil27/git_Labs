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
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine()), x = 0;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    x += 2 * i - 1;
                    Console.WriteLine(x);
                }
            }
            Console.ReadKey();
        }
    }
}
