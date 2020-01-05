using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            Console.Write("A=");
            A = double.Parse(Console.ReadLine());
            A = A * A;
            A = A * A;
            A = A * A;
            Console.WriteLine(("A^8=") + A );
            Console.ReadKey();
        }
    }
}
