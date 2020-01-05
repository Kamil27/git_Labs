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
            String s = "C:\\Users\\Public\\Приложения\\KMSAuto Cleaner.exe";
            s = s.Substring(s.LastIndexOf("\\") + 1, s.LastIndexOf(".") - s.LastIndexOf("\\") - 1);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
