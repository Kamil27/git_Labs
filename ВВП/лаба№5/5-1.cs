using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("введите размер файла в байтах: ");
            a = double.Parse(Console.ReadLine());
            b = a / 1024;
            Console.WriteLine("Размер файла в килобайтах: " + b);
            Console.ReadKey();
        }
    }
}
