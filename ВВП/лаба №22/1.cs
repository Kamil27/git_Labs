using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _22_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            string path = "C:\\Users\\KAMA\\source\\repos\\22\\22-1\\TextFile1.txt";
            int scount = File.ReadAllLines(path).Length;
            string[] lines = new string[scount];
            using (StreamReader sr = new StreamReader(path))
            {
                int x = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines[x] = line;
                    x++;
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                bool flag = false;
                while((line = sr.ReadLine()) != null)
                {
                    for (j = 0; j < line.Length; j++)
                    {
                        if (line[j] == ' ')
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == true) break;
                    i++;
                }
            }
            lines[i] = lines[i].Remove(0, j+1);
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
            {
                sw.Write("");
            }
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
            {
                for (int x = i; x < scount; x++)
                {
                    sw.WriteLine(lines[x]);
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
