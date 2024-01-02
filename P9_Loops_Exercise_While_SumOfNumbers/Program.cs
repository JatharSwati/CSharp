using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_Loops_Exercise_While_SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input

            int i = 1, n, sum = 0;

            Console.Write("Enter your number : ");
            n = Convert.ToInt32(Console.ReadLine());

            while (i<=n)
            {
                sum += i;       // sum = sum + i
                i++;
            }

            // Output

            Console.Write($"\nSum of 1 to {n} is {sum}");

            Console.WriteLine("\n");

        }
    }
}
