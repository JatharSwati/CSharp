using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input

            int firstNumber, secondNumber;

            Console.Write("Enter your first number : ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter your second number : ");
            secondNumber = Convert.ToInt32(Console.ReadLine());


            // Output
            
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"\n{firstNumber} is largest number.");
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine($"\n{secondNumber} is largest number.");
            }
            else
            {
                Console.WriteLine("\nBoth numbers are equal.");
            }

            Console.WriteLine();
        }
    }
}
