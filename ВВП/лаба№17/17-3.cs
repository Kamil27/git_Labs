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
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine()), i, x, i2 = 0, ik2;
            Console.Write("k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            List<int> temp = new List<int>();
            List<int> temp2 = new List<int>();
            for (i = 0; i < n; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            i = 0;
            int ik = 0;
            x = 0;
            for (int j = 1; j <= n; j++)
            {
                x++;
                i++;
                if (j == n || list[j] != list[j - 1])
                {
                    ik++;
                    if (ik == k) break;
                    x = 0;
                }
            }
            ik = x;
            i -= ik;
            x = 0;
            for (int j = n - 1; j > 0; j--)
            {
                x++;
                if (list[j] != list[j - 1])
                {
                    i2 = j;
                    break;
                }
            }
            ik2 = x;
            try
            {
                temp.AddRange(list.GetRange(i, ik));
                temp2.AddRange(list.GetRange(i2, ik2));
                list.RemoveRange(i, ik);
                list.InsertRange(i, temp2);
                list.RemoveRange(i2 - ik + ik2, ik2);
                list.InsertRange(i2 - ik + ik2, temp);
                foreach (int j in list) Console.Write(j + " ");
            }
            catch
            {
                Console.WriteLine("Изменений не требуется");
            }
            Console.ReadKey();
        }
    }
}

