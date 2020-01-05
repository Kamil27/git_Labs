using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B;
            Console.Write("A= ");
            A = double.Parse(Console.ReadLine());
            Console.Write("B= ");
            B = double.Parse(Console.ReadLine());
            if (A > B)
            {
                Console.WriteLine("Отрезков В размещенны на отрезке А:" + A / B);
            }
            else Console.WriteLine("А не больше B ");
            Console.ReadKey();        
        }
    }
}
