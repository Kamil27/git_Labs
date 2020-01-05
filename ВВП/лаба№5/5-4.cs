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
            int a, b, c;
            Console.Write("Введите двух значное число: ");
            c = int.Parse(Console.ReadLine());
            a = c / 10;
            b = c % 10;
            Console.WriteLine(b * 10 + a);
            Console.ReadKey();
        }
    }
}
