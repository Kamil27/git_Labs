using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static float Fact2(int N)
        {
                int mult = 1;
                while (N > 1)
                {
                    mult *= N;
                    N -= 2;
                }
                return mult;
            }
            static void Main(string[] args)
            {
                Random randd = new Random();
                int value = randd.Next(10);
                Console.WriteLine("Факториал " + value + " равен " + Fact2(value));
            Console.ReadKey();
            }
        }
    }



