using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, A, Y, R, P;
            Console.Write("сколько килограм: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("введите цену: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("введите килограммы: ");
            Y = int.Parse(Console.ReadLine());
            R = A / X;
            P = R * Y;
            Console.WriteLine("равно: " + P);
            Console.ReadKey();
        }
    }
}
