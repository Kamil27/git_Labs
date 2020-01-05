using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int Sign(float x)
        {
            int num = 0;
            if (x < 0)
            {
                num = -1;
                return num;
            }
            else if (x == 0)
            {
                num = 0;
                return num;
            }
            else
            {
                num = 1;
                return num;
            }
        }
        static void Main(string[] args)
        {
            int A, B;
            Console.Write("A=");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B=");
            B = Convert.ToInt32(Console.ReadLine());
            Console.Write(Sign(A) + Sign(B));
            Console.ReadKey();
        }
    }
}
