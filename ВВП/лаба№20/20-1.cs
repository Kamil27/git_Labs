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
            char c1;
            byte c;
            Console.WriteLine("Введите с: ");
            c1 = char.Parse(Console.ReadLine());
            c = Convert.ToByte(c1);
            Console.WriteLine(c - 1);
            Console.WriteLine(c + 1);
            Console.ReadKey();
        }
    }
}
