using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            String s = Console.ReadLine();
            String[] ss = s.Split(' ');
            Console.WriteLine("Количество слов в строке = " + ss.Length);
            Console.ReadKey();
        }
    }
}
