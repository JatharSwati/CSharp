using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE7_SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input

            int number, sum, reminder, numberForOutput;

            Console.Write("Enter your number : ");
            number = Convert.ToInt32(Console.ReadLine());

            sum = 0;

            numberForOutput = number;


            // Output

            while (number > 0)
            {
                reminder = number % 10;
                number = number / 10;
                sum = sum + reminder;
            }

            Console.WriteLine($"\nSum of the digits of {numberForOutput} is {sum}.");

            Console.WriteLine();

        }
    }
}
