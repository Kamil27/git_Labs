using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static float RingS(float R1, float R2)
        {
            const float pi = 3.14f;
                float s1 = pi * (R1 * R1);
                float s2 = pi * (R2 * R2);
                float innerringS = s1 - s2;
                return innerringS;
           
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("R1=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("R2=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RingS(a, b));
            Console.ReadKey();
        }
    }
}
