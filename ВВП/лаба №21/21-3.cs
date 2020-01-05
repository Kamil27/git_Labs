using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.Write("Введите строку: ");
            String s = Console.ReadLine();
            String[] ss = s.Split(' ');
            for (i = 0; i < ss.Length; i++)
            {
                char[] a = ss[i].ToCharArray();
                ss[i] = a[0] + "";
                for (j = 1; j < a.Length; j++)
                {
                    if (a[j] == a[0])
                        a[j] = '.';
                    ss[i] += a[j];
                }
                Console.Write(ss[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
