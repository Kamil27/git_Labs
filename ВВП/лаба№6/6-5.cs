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
            int x, y, a;
            Console.WriteLine("Введите год: ");
            x = int.Parse(Console.ReadLine());
            y = x / 100;
            a = x % 100;
            if (a == 0)
            {
                Console.WriteLine(x+"-ый год явл "+y+"-м веком");
            }
            if (x != 0)
            {
                Console.WriteLine(x + "-ый год явл " + (y+1) + "-м веком");
            }
            Console.ReadKey();
        }
    }
}
