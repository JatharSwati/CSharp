using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE5_ReverseTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input 

            int number, numberForOutput, reminder;

            Console.Write("Enter your number : ");
            number = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;
            numberForOutput = number;

            // Output

            while (number > 0)
            {
                reminder = number % 10;
                number = number / 10;
                reverse = (reverse * 10) + reminder;                
            }

            Console.WriteLine($"\nThe reverse number of {numberForOutput} is {reverse}");

            Console.WriteLine();

        }
    }
}
