using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, x;
            Console.Write("Введите А: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            B = double.Parse(Console.ReadLine());
            if (A != 0) {
                Console.WriteLine("x = " +  -(B / A));
            }
            else Console.WriteLine("А != 0");
            Console.ReadKey();
        }
    }
}
