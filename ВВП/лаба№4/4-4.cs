using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double V1, V2, S, T, S1;
            Console.Write("Введите скорость первой машины: ");
            V1 = double.Parse(Console.ReadLine());
            Console.Write("Введите скорость второй машины: ");
            V2 = double.Parse(Console.ReadLine());
            Console.Write("Ведите расстояние между ними: ");
            S = double.Parse(Console.ReadLine());
            Console.Write("Введите время: ");
            T = double.Parse(Console.ReadLine());
            S1 = T * (V1 + V2) + S;
            Console.WriteLine("Растояние через Т времени будет: " + S1);
            Console.ReadKey();
        }
    }
}
