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
            int i;
            string s;
            char c1;
            byte k, c;
            Console.Write("S = ");
            s = Console.ReadLine();
            Console.Write("C = ");
            c1 = char.Parse(Console.ReadLine());
            c = Convert.ToByte(c1);
            for (i = 0; i < s.Length; i++)
            {
                k = Convert.ToByte(s[i]);
                if (k == c)
                    Console.Write(s[i] + "" + s[i]);
                else
                    Console.Write(s[i]);
            }
            Console.ReadKey();
        }
    }
}
