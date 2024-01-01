using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Switch_Exercise_Marks
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input

            double marathiMarks = 96;
            double englishMarks = 85;
            double physicsMarks = 67;
            double chemistryMarks = 75;
            double mathematicsMarks = 55;
            double biologyMarks = 67;

            string mySubject;

            // Output

            Console.Write($"Enter your subject : ");
            mySubject = Console.ReadLine();

            switch (mySubject)
            {
                case "Marathi":
                    Console.WriteLine($"\nYour marathi marks is {marathiMarks}.");
                    break;
                case "English":
                    Console.WriteLine($"\nYour english marks is {englishMarks}.");
                    break;
                case "Physics":
                    Console.WriteLine($"\nyour physics marks is {physicsMarks}.");
                    break;
                case "Chemistry":
                    Console.WriteLine($"\nYour chemistry marks is {chemistryMarks}.");
                    break;
                case "Mathematics":
                    Console.WriteLine($"\nYour mathematics marks is {mathematicsMarks}.");
                    break;
                case "Biology":
                    Console.WriteLine($"\nYour biology marks is {biologyMarks}.");
                    break;
            }

            Console.WriteLine();

        }
    }
}
