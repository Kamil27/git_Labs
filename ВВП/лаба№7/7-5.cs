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
            int a;
            Console.WriteLine("Введите 4-х значное число: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 10 == a / 1000 && (a / 10) % 10 == (a / 100) % 10)
                Console.WriteLine("TRUE");
            else
                Console.WriteLine("FALSE");
            Console.ReadKey();
        }
    }
}
