using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            Console.WriteLine("введите A ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("введите B ");
            B = double.Parse(Console.ReadLine());
            C = A;
            A = B;
            B = C;
            Console.WriteLine(("A стало "  + A  +  "\nB стало " + B ));
            Console.ReadKey();
        }
    }
}
