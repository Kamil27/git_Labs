using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, AC, BC;
            Console.WriteLine("введите координату А");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("введите координату B");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("введите координату С");
            C = double.Parse(Console.ReadLine());
            AC = Math.Abs(A - C);
            BC = Math.Abs(C - B);
            Console.WriteLine("АС = " + AC);
            Console.WriteLine("BC = " + BC);
            Console.WriteLine("произведение длин отрезков: " + (AC * BC));
            Console.ReadKey();
        }
    }
}
