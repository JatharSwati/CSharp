using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE1_IsNumberEvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input

            int number1, number2;

            Console.Write("Enter your number : ");
            number1 = Convert.ToInt32(Console.ReadLine());

            number2 = number1 % 2;


            // Output

            if (number2 % 2 == 0)
            {
                Console.WriteLine($"\n{number1} is an even number.");
            }
            else
            {
                Console.WriteLine($"\n{number1} is an odd number.");    
            }

            Console.WriteLine();

        }
    }
}
