using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. The if Statement -
            // Use the if statement to specify a block of C# code to be executed if a condition is True.

            Console.WriteLine("1. The if Statement - ");


            // Example 1 :

            Console.Write("\nExample 1 : ");
            if (40 > 30)
            {
                Console.WriteLine("40 is greater than 30.");
            }


            // Example 2 :

            Console.Write("\nExample 2 : ");
            int x = 35;
            int y = 10;
            if (x > y)
            {
                Console.WriteLine("x is greater than y.");
            }



            // 2. The else Statement -
            // Use the else statement to specify a block of code to be executed if the condition is False.

            Console.WriteLine("\n\n2. The else Statement - ");

            int num1 = 20;

            if (num1 < 45)
            {
                Console.WriteLine("Good day.");
            }

            else
            {
                Console.WriteLine("Good morning.");
            }
           


            // 3. The else if Statement -
            // Use the else if statement to specify a new condition if the first condition is False.

            Console.WriteLine("\n\n3. The else if Statement - ");

            int num2 = 45;

            if (num2 < 20)
            {
                Console.WriteLine("Good morning.");
            }

            else if (num2 < 30)
            {
                Console.WriteLine("Good evening.");
            }
            
            else
            {
                Console.WriteLine("Good day.");
            }



            // 4. Short Hand If...Else -
            // There is also a short-hand if else, which is known as the ternary operator because it consists of three operands.
            // It can be used to replace multiple lines of code with a single line.
            // It is often used to replace simple if else statements

            Console.WriteLine("\n\n4. Short Hand If...Else - ");

            int num3 = 57;
            string result = (num3 < 28) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            Console.WriteLine();

        }
    }
}
