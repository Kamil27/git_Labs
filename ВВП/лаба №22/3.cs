using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "C:\\Users\\KAMA\\source\\repos\\22\\22-3\\TextFile3-1.txt";
            string path2 = "C:\\Users\\KAMA\\source\\repos\\22\\22-3\\TextFile3-2.txt";
            int s1count = File.ReadAllLines(path1).Length;
            int s2count = File.ReadAllLines(path2).Length;
            List<string> lines1 = new List<string>();
            List<string> lines2 = new List<string>();
            using (StreamReader sr = new StreamReader(path1))
            {
                int i = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines1.Add(line);
                    i++;
                }
            }
            using (StreamReader sr = new StreamReader(path2))
            {
                int i = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines2.Add(line);
                    i++;
                }
            }
            for (int i = s2count-1; i >= 0; i--)
            {
                lines1.Insert(0, lines2[i]);
            }
            using (StreamWriter sw = new StreamWriter(path1, false, Encoding.Default))
            {
                sw.Write("");
            }
            using (StreamWriter sw = new StreamWriter(path1, true, Encoding.Default))
            {
                for (int i = 0; i < s2count+s1count; i++)
                {
                    sw.WriteLine(lines1[i]);
                }              
            }
            Console.ReadKey();
        }
    }
}
