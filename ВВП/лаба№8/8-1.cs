using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            if (A > B)
            {
                B = A;
            }
            else if (B > A)
            {
                A = B;
            }
            else
            {
                A = 0;
                B = 0;
            }
            Console.WriteLine("Новое значение А = {0}", A);
            Console.WriteLine("Новое значение B = {0}", B);
            Console.ReadKey();
        }
    }
}
