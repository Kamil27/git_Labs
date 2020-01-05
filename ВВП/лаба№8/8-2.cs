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
            Console.Write("Введите значение А: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение C: ");
            int C = Convert.ToInt32(Console.ReadLine());
            int sum;
            if (A > C && B > C)
            {
                sum = A + B;
                Console.WriteLine("Сумма двух наибольших чисел равна = {0}", sum);
            }
            else if (A > B && C > B)
            {
                sum = A + C;
                Console.WriteLine("Сумма двух наибольших чисел равна = {0}", sum);
            }
            else if (B > A && C > A)
            {
                sum = B + C;
                Console.WriteLine("Сумма двух наибольших чисел равна = {0}", sum);
            }
            else
            {
                Console.WriteLine("Ошибка! Введеные числа не имеют двух наибольших значений");
            }
            Console.ReadKey();
        }
    }
}
