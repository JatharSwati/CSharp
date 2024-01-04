using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_CheckDivisibility
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input

            int number1, number2;

            Console.Write("Enter your number : ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nCheck if it is divisible by : ");
            number2 = Convert.ToInt32(Console.ReadLine());


            // Output

            if (number1 % number2 == 0)
            {
                Console.WriteLine($"\nYes, {number1} is divisible by {number2}.");
            }
            else
            {
                Console.WriteLine($"\nNo, {number1} is not divisible by {number2}.");
            }

            Console.WriteLine();

        }
    }
}
