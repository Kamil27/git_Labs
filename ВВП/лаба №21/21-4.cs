using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, count = 0;
            Console.Write("Введите строку: ");
            String s = Console.ReadLine().ToLower();
            char[] gl = { 'а', 'у', 'о', 'ы', 'и', 'э', 'я', 'ю', 'ё', 'е' };
            char[] ss = s.ToCharArray();

            for (i = 0; i < ss.Length; i++)
            {
                for (j = 0; j < gl.Length; j++)
                {
                    if (ss[i].Equals(gl[j]))
                        count++;
                }
            }
            Console.WriteLine("Количество гласных: " + count);
            Console.ReadKey();
        }
    }
}
