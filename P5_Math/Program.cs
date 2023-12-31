using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math -
            // The C# Math class has many methods that allows you to perform mathematical tasks on numbers.
            Console.WriteLine("Math - ");

            // 1. Math.Max(x,y) : 
            // The Math.Max(x,y) method can be used to find the highest value of x and y.
            Console.WriteLine("\n1. Math.Max(5,8) : " + (Math.Max(5, 8)));

            // 2. Math.Min(x,y) :
            // The Math.Min(x,y) method can be used to find the lowest value of of x and y.
            Console.WriteLine("\n2. Math.Min(4,3) : " + (Math.Min(4, 3)));

            // 3. Math.Sqrt(x) :
            // The Math.Sqrt(x) method returns the square root of x.
            Console.WriteLine("\n3. Math.Sqrt(25) : " + (Math.Sqrt(25)));

            // 4. Math.Abs(x) :
            // The Math.Abs(x) method returns the absolute (positive) value of x.
            Console.WriteLine("\n4. Math.Abs(-8) : " + (Math.Abs(-8)));

            // 5. Math.Round() :
            // Math.Round() rounds a number to the nearest whole number.
            Console.WriteLine("\n5. Math.Round(6.78) : " + (Math.Round(6.78)));

            Console.WriteLine();
        }
    }
}
