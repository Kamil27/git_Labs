using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j = 0; ;
            char swap;
            Console.Write("Введите строку: ");
            String s = Console.ReadLine();
            char[] a = s.ToCharArray();
            char[] b = s.ToCharArray();
            s = "";
            for (i = 0; i < a.Length; i++)
            {
                if (i % 2 != 0)
                {
                    swap = a[j];
                    a[j] = a[i];
                    a[i] = swap;
                    s += a[j];
                    j++;
                }
            }
            for (i = b.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                    s += b[i];
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
