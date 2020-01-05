using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба
{
    class Program
    {
        static void Main(string[] args)
        {
        int x;
        Console.Write("Введите кол-во сек: ");
        x = int.Parse(Console.ReadLine());
            x = x % 60;
            Console.WriteLine("Кол-во полных сек: " + x);
            Console.ReadKey();
        }
    }
}
