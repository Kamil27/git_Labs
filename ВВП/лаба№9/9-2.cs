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
            char C;
            int N;
            Console.Write("Введите направление: С - сервер, З - запад, Ю - юг, В - восток —");
            C = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите команду: 1 - поворот налево, 0 - продолжить направление, -1 - поворот направо —");
            N = Convert.ToInt32(Console.ReadLine());
            switch (C)
            {
                case 'С':
                    switch (N)
                    {
                        case 0:
                            Console.WriteLine("Робот направлен на север");
                            break;
                        case 1:
                            Console.WriteLine("Робот направлен на запад");
                            break;
                        case -1:
                            Console.WriteLine("Робот направлен на восток");
                            break;
                    }
                    break;
                case 'Ю':
                    switch (N)
                    {
                        case 0:
                            Console.WriteLine("Робот направлен на юг");
                            break;
                        case 1:
                            Console.WriteLine("Робот направлен восток");
                            break;
                        case -1:
                            Console.WriteLine("Робот направлен на запад");
                            break;
                    }
                    break;
                case 'З':
                    switch (N)
                    {
                        case 0:
                            Console.WriteLine("Робот направен на запад");
                            break;
                        case 1:
                            Console.WriteLine("Робот направлен на юг");
                            break;
                        case -1:
                            Console.WriteLine("Робот направлен на север");
                            break;
                    }
                    break;
                case 'В':
                    switch (N)
                    {
                        case 0:
                            Console.WriteLine("Робот направлен на восток");
                            break;
                        case 1:
                            Console.WriteLine("Робот направлен на север");
                            break;
                        case -1:
                            Console.WriteLine("Робот направлен на юг");
                            break;
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
