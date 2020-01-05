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
            int i, m = 0;
            string s;
            byte k;
            Console.Write("S = ");
            s = Console.
            ReadLine();
            for (i = 0; i < s.Length; i++)
            {
                k = Convert.ToByte(s[i]);
                if ((k > 96) && (k < 123)) m = m + 1;
            }
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
