using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, r, p =3.14;
            Console.Write("введите угол a: ");
            a = double.Parse(Console.ReadLine());
            if ((a > 0) && (a < 360)) 
            {
                r = p * a / 180;
                Console.WriteLine("угол в Радианах: " + r);
            }
            else Console.WriteLine("угол не подходит по условиию");
            Console.ReadKey();
        }
    }
}
