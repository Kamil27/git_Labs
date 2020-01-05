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
            int a, b, c;
            Console.Write("Введите трёх значное число: ");
            c = int.Parse(Console.ReadLine());
            a = c / 100;
            b = c % 100;
            a = c / 10;
            b = c % 10;
            Console.WriteLine(b * 100 +a );
            Console.ReadKey();
        }
    }
}
