using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program2
    {
        static float PowerA3(float x)
        {
            float y = x * x * x;
            return y;
        }
        static void Main(string[] args)
        {
            int i;
            Console.Write("Введите число: ");
            i = Convert.ToInt32(Console.ReadLine());
            while (i < 8)
            {
                Console.WriteLine(PowerA3(i));
                i++;
            }
            Console.ReadKey();
        }
    }
}

