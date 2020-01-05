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
            int i;
            string s1, s = "";
            Console.Write("S = ");
            s1 = Console.ReadLine();
            for (i = 0; i < s1.Length; i++)
            {
                Console.Write(s1[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
