using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double A1, B1, C1, A2, B2, C2, x,y;
            Console.Write("A1= ");
            A1 = double.Parse(Console.ReadLine());
            Console.Write("B1= ");
            B1 = double.Parse(Console.ReadLine());
            Console.Write("C1= ");
            C1 = double.Parse(Console.ReadLine());
            Console.Write("A2= ");
            A2 = double.Parse(Console.ReadLine());
            Console.Write("B2= ");
            B2 = double.Parse(Console.ReadLine());
            Console.Write("C2= ");
            C2 = double.Parse(Console.ReadLine());
            x= (C2 - (B2 * C1)) / ((B1 * A2) - A1);
            y= (C1 - (A1 * x)) / B1;
            Console.WriteLine("x= " + x);
            Console.WriteLine("y= " + y);
            Console.ReadKey();
        }
    }
}
