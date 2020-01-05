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
            int A, B, C;
            Console.Write("A=");
            A = int.Parse(Console.ReadLine());
            Console.Write("B=");
            B = int.Parse(Console.ReadLine());
            Console.Write("C=");
            C = int.Parse(Console.ReadLine());
            int occpiedpart = (A / C) * (B / C);
            int freepart = (A * B) - (occpiedpart * (C * C));
            Console.WriteLine("количество квадратов, размещенных на прямоугольнике: " + occpiedpart);
            Console.WriteLine("также площадь незанятой части прямоугольника: "+ freepart);
            Console.ReadKey();
        }
    }
}
