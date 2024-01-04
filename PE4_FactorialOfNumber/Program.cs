using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_FactorialOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input

            int number, factorial;

            Console.Write("Enter your number : ");
            number = Convert.ToInt32(Console.ReadLine());

            factorial = 1;


            // Output

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i; 
            }

            Console.WriteLine($"\n{number}! = { factorial}");

            Console.WriteLine();

        }
    }
}
