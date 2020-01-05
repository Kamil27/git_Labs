using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "C:\\Users\\Public\\Приложения\\KMSAuto Cleaner.exe";
            String[] ss = s.Split('\\');
            if (ss.Length - 2 == 0)
                Console.WriteLine(ss[ss.Length - 2] + "\\");
            else
                Console.WriteLine(ss[ss.Length - 2]);
            Console.ReadKey();
        }
    }
}
