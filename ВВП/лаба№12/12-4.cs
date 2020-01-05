using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static int Quarter(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int o = 0; o < 3; o++)
            {
                int randX = rand.Next(-100, 100), randY = rand.Next(-100, 100);
                Console.WriteLine("Координаты: " + randX + ", " + randY);
                Console.WriteLine("Точка с этими координатами находится в " + Quarter(randX, randY) + " четверти");
            }
            Console.ReadKey();
        }
    }
}
