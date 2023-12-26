using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1) Area of Square

            int a = 4;
            Console.WriteLine("1) Area of Square = " + a * a);


            // 2) Area of Rectangle

            int l = 4;
            int w = 6;
            Console.WriteLine("2) Area of Rectangle = " + l * w);


            // 3) Area of circle

            const double PI = 3.14;
            int r = 2;
            Console.WriteLine("3) Area of Circle = " + PI * r * r);


            // 4) Area of Sphere

            int radius = 4;
            Console.WriteLine("4) Area of Sphere = " + 4 * PI * radius * radius);


            // 5) Area of Triangle

            int b = 8;
            int h = 4;
            Console.WriteLine("5) Area of Triangle = " + 0.5 * b * h);

        }
    }
}
