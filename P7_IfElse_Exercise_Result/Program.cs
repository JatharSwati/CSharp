using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_IfElse_Exercise_Result
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input 

            float marathi, english, physics, chemistry, mathematics, biology, totalMarks, percentage, message;

            Console.WriteLine("Enter your subjects marks - ");

            Console.Write("\nMarathi : ");
            marathi = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnglish : ");
            english = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("\nPhysics : ");
            physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nChemistry : ");
            chemistry = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nMathematics : ");
            mathematics = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nBiology : ");
            biology = Convert.ToInt32(Console.ReadLine());

            totalMarks = marathi + english + physics + chemistry + mathematics + biology;            

            Console.Write("\nTotal marks of subjet : ");
            Console.WriteLine(totalMarks);

            percentage = totalMarks / 6;
            Console.Write("\nPercentage : ");
            Console.WriteLine(percentage);

            message = percentage;

            if (message >= 35)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\nCongratulations! You are pass. Your percentage are {percentage} and ");                
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"\nSorry, you are fail. Your percentage are {percentage} and ");                
            }


            if (percentage > 90)
            {
                Console.Write("Your grade is O.");
            }

            else if (percentage > 80)
            {
                Console.Write("Your grade is A+.");
            }

            else if (percentage > 70)
            {
                Console.Write("Your grade is A.");
            }

            else if (percentage > 60)
            {
                Console.WriteLine("Your grade is B+.");
            }

            else if (percentage > 50)
            {
                Console.Write("Your grade is B.");
            }

            else if (percentage >= 35)
            {
                Console.Write("Your grade is c.");
            }

            else if (percentage <= 35)
            {
                Console.Write("Your grade is F.");
            }

            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
