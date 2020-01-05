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
            int K;
            Console.Write("Введите день: ");
            K = int.Parse(Console.ReadLine());
            if (K>=1 && K <=365)
            {
                K = K % 7;
            }
            else Console.WriteLine("условие не правильно: ");


            switch (K)
                {
                    case 0:
                        Console.WriteLine("Воскресение ");
                        break;
                    case 1:
                        Console.WriteLine("Понидельник ");
                        break;
                    case 2:
                        Console.WriteLine("Вторник ");
                        break;
                    case 3:
                        Console.WriteLine("Среда ");
                        break;
                    case 4:
                        Console.WriteLine("Четверг ");
                        break;
                    case 5:
                        Console.WriteLine("Пятница ");
                        break;
                    case 6:
                        Console.WriteLine("Суббота ");
                        break;
                }
            Console.ReadKey();
         }
    }
}
