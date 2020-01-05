using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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
                Console.WriteLine("Незанятая часть отрезка А: " + A % B);
            }
           else Console.WriteLine("А не больше B ");
            Console.ReadKey();
        }
    }
}
