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

            int number;

            Console.Write("Enter your number : ");
            number = Convert.ToInt32(Console.ReadLine());


            // Output

            if (number % 2 == 0)
            {
                Console.WriteLine($"\n{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"\n{number} is an odd number.");    
            }

            Console.WriteLine();

        }
    }
}
