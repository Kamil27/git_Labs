using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int ka = 0, kp;
            string path = "C:\\Users\\KAMA\\source\\repos\\22\\22-5\\TextFile5.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    kp = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ' ')
                        {
                            if (kp == 5) ka++;
                            break;
                        }
                        kp++;
                    }
                }
            }
            Console.WriteLine(ka);
            Console.ReadKey();
        }
    }
}
