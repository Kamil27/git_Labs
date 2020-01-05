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
            Console.Write("N = ");
              int n = Convert.ToInt32(Console.ReadLine()), i, k = 1, x;
            Console.Write("L = ");
              int l = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
             int[] a;
             for (i = 0; i < n; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            i = 0;
             while (i < list.Count)
            {
                i++;
                k++;
                 if (i == list.Count || list[i - 1] != list[i])
                {
                     if (--k > l)
                    {
                        i -= k;
                        list.RemoveRange(i, k);
                        list.Insert(i, 0);
                    }
                    k = 1;
                }
            }
            a = list.ToArray();
            foreach (int j in a) Console.Write(j + " ");
            Console.ReadKey();
        }
    }
}
