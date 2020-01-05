using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, m = 0;
            string s, s0;
            byte k, k0;
            Console.Write("S = ");
            s = Console.ReadLine();
            Console.Write("S0 = ");
            s0 = Console.ReadLine();
            for (i = 0; i < s.Length; i++)
            {
                k = Convert.ToByte(s[i]);
                k0 = Convert.ToByte(s0[i]);
                if (k == k0) m = m + 1;
            }
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
