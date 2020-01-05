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
            Console.Write("Введите точку А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите точку B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите точку C: ");
            int C = Convert.ToInt32(Console.ReadLine());
            int ba = B - A;
            if (ba < 0)
                ba *= -1;
            int ca = C - A;
            if (ca < 0)
                ca *= -1;
            if (ba < ca)
            {
                Console.Write("Точка В, равная " + B + ", ближе к А и расстояние равно = {0}", ba);
            }
            else if (ca < ba)
            {
                Console.Write("Точка C, равная " + C + ", ближе к А и расстояние равно = {0}", ca);
            }
            else if (ca == ba)
            {
                Console.Write("Точка C, равная " + C + " и точка В, равная " + B + ", равноудалены и расстояние равно = {0}", ca);
            }
            else
            {
                Console.WriteLine("Error!");
            }
            Console.ReadKey();
        }
    }
}
