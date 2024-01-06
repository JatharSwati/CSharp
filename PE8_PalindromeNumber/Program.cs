using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input

            int number, reminder, reverseNumber, initialNumber;

            Console.Write("Enter your number : ");
            number = Convert.ToInt32(Console.ReadLine());

            reverseNumber = 0;
            initialNumber = number;


            // Output

            while (number > 0)
            {
                reminder = number % 10;
                number = number / 10;
                reverseNumber = (reverseNumber * 10) + reminder;
            }

            if (initialNumber == reverseNumber)
            {
                Console.WriteLine($"\n{initialNumber} is Palindrome Number.\n");
            }
            else
            {
                Console.WriteLine($"\n{initialNumber} is not Palindrome Number.\n");
            }

        }
    }
}
