using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\KAMA\\source\\repos\\22\\22-2\\TextFile2.txt";
            Console.Write("N = ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = Int32.Parse(Console.ReadLine());
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                sw.Write("");
            }
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
            {
                string line = "";
                for (int i = 0; i < k; i++)
                    line += '*';
                for (int i = 0; i < n; i++) sw.WriteLine(line);
            }
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
