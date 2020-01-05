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
            int K, N, V;
            Console.Write("Введите день: ");
            K = int.Parse(Console.ReadLine());
            Console.Write("Введите каким номером недели было 1 января: ");
            N = int.Parse(Console.ReadLine());
            if ((K >= 1 && K <= 365) && (N >= 1 && N <= 7))
            {
                V = (K + N - 1) % 7;
                switch (V)
            {
                case 1:
                    Console.WriteLine("Понедельник ");
                    break;
                case 2:
                    Console.WriteLine("Вторник ");
                    break;
                case 3:
                    Console.WriteLine("Среда ");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница ");
                    break;
                case 6:
                    Console.WriteLine("Суббота ");
                    break;
                case 7:
                    Console.WriteLine("Воскресение");
                    break;
            }
                Console.WriteLine("День недели " + V);
            }
            else Console.WriteLine("условие не правильно. ");
            Console.ReadKey();
        }
    }
}
