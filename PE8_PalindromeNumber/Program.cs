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

            int number, reminder, sum, palindromeNumber;

            Console.Write("Enter your number : ");
            number = Convert.ToInt32(Console.ReadLine());

            sum = 0;
            palindromeNumber = number;


            // Output

            while (number > 0)
            {
                reminder = number % 10;
                number = number / 10;
                sum = (sum * 10) + reminder;
            }

            if (palindromeNumber == sum)
            {
                Console.Write($"\n{sum} is Palindrome Number.");
            }
            else
            {
                Console.WriteLine($"\n{sum} is not Palindrome Number.");
            }

            Console.WriteLine();

        }
    }
}
