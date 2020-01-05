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
            int[] array = { 1, 2, 2, 3, 4, 4, 5, 6, 6, 6 };
            int count = 1;
            int number = array[0];
            Console.WriteLine("Длина всех серий массива равна: ");
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == number)
                    count++;
                else
                {
                    Console.Write(count + " ");
                    count = 1;
                    number = array[i];
                }
            }
            Console.Write(count + " ");
            Console.ReadKey();
        }
    }
}
