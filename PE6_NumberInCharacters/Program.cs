using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_NumberInCharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input

            int number, reverseNumber = 0, reminder;
            string[] numberText = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Zero" };

            Console.Write("Enter your number : ");
            number = Convert.ToInt32(Console.ReadLine());


            // Output

            Console.WriteLine();

            while (number > 0)
            {
                reminder = number % 10;
                number = number / 10;
                reverseNumber = reverseNumber * 10 + reminder;
            }

            number = reverseNumber;

            while (number > 0)
            {

                reminder = number % 10;

                Console.Write($"{numberText[reminder - 1]} ");

                number = number / 10;

            }                                             

            Console.WriteLine("\n");

        }
    }
}
