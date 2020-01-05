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
            int N;
            Console.Write("Введите номера учебных заданий с 10го по 40е: ");
            N = Convert.ToInt32(Console.ReadLine());
            int NN = N / 10;
            if (NN == 1)
            {
                switch (N)
                {
                    case 10:
                        Console.WriteLine("Десять учебных заданий");
                        break;
                    case 11:
                        Console.WriteLine("Одиннадцать учебных заданий");
                        break;
                    case 12:
                        Console.WriteLine("Двенадцать учебных заданий");
                        break;
                    case 13:
                        Console.WriteLine("Тринадцать учебных заданий");
                        break;
                    case 14:
                        Console.WriteLine("Четырнадцать учебных заданий");
                        break;
                    case 15:
                        Console.WriteLine("Пятнадцать учебных заданий");
                        break;
                    case 16:
                        Console.WriteLine("Шестнадцать учебных заданий");
                        break;
                    case 17:
                        Console.WriteLine("Семнадцать учебных заданий");
                        break;
                    case 18:
                        Console.WriteLine("Восемнадцать учебных заданий");
                        break;
                    case 19:
                        Console.WriteLine("Девятнадцать учебных заданий");
                        break;
                }
            }
            else
            {
                switch (NN)
                {
                    case 2:
                        Console.Write("Двадцать ");
                        break;
                    case 3:
                        Console.Write("Трицать ");
                        break;
                }
                switch (N % 10)
                {
                    case 0:
                        Console.Write("учебных заданий");
                        break;
                    case 1:
                        Console.Write("одно учебное задание ");
                        break;
                    case 2:
                        Console.Write("два учебных задания ");
                        break;
                    case 3:
                        Console.Write("триучебных задания ");
                        break;
                    case 4:
                        Console.Write("четыре учебных задания ");
                        break;
                    case 5:
                        Console.Write("пять учебных заданий ");
                        break;
                    case 6:
                        Console.Write("шесть учебных заданий ");
                        break;
                    case 7:
                        Console.Write("семь учебных заданий ");
                        break;
                    case 8:
                        Console.Write("восемь учебных заданий ");
                        break;
                    case 9:
                        Console.Write("девять учебных заданий ");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
