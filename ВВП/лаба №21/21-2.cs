using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, i;
            Console.Write("Введите строку: ");
            String s = Console.ReadLine();
            String[] ss = s.Split(' ');
            min = ss[0].Length;
            for (i = 0; i < ss.Length; i++)
            {
                if (ss[i].Length < min && ss[i].Length != 0)
                    min = ss[i].Length;
            }
            Console.WriteLine("Длина самого короткого слова = " + min);

            Console.ReadKey();
        }
    }
}
