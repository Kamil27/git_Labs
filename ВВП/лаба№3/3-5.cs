using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("x=");
            x = double.Parse(Console.ReadLine());
            y = 4 * Math.Pow((x - 3), 6) - 7 * Math.Pow((x - 3), 3 );
            Console.WriteLine("y=" + y);
            Console.ReadKey();
        }
    }
}
