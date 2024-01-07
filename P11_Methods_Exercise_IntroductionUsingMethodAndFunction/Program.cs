using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Methods_Exercise_IntroductionUsingMethodAndFunction
{
    class Program                 
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduction:");            

            string[] skills = { "HTML", "CSS", "JavaScript", "C#" };
            string[] languages = { "Marathi", "Hindi", "English" };
            string[] strength = { "self motivated", "punctual person" };
            string[] hobbies = { "spending time with friends", "watchnig reality shows", "cooking", "listining to music" };

            Introduction("Swati", "Jathar", 22, "Sangmner", "Kuran", "Computer Engineering", "Jaihind College of Engineering, Kuran", skills, languages, strength, hobbies);

            Console.WriteLine($"My aggregate CGPA is {TotalCGPA(9.45, 8.45, 7.45, 6.45)}");

            Console.WriteLine();

        }

        static void Introduction(string firstName, string lastName, int age, string nativePlace, string currentLocation, string degreeName, string collegeName,
            string[] skills, string[] languages, string[] strengths, string[] hobbies)
        {

            string fullName = firstName + " " + lastName;

            Console.Write("Hello everyone,");
            Console.Write($" My Name is {fullName}.");
            Console.Write($" I am {age} year's old.");
            Console.Write($" I am from {nativePlace} currently studing in {currentLocation}.");
            Console.Write($" I have completed my Bachelor's in {degreeName} technology from {collegeName}.");

            ArrayToText(skills, "skills");
            ArrayToText(languages, "languages");
            ArrayToText(strengths, "strengths");
            ArrayToText(hobbies, "hobbies");
        }


        static void ArrayToText(string[] input, string name)
        {
            Console.Write($"\nMy {name} are ");

            for (int i = 0; i < input.Length; i++)
            {
                string lastText = (i == input.Length - 1) ? "." : ", ";

                Console.Write($"{input[i]}{lastText}");
            }
        }


        static double TotalCGPA(double firstYearCGPA, double secondYearCGPA, double thirdYearCGPA, double fourthYearCGPA)
        {

            Console.WriteLine("\nI have CGPA in each year as Follws, ");
            Console.WriteLine($"- First year CGPA is {firstYearCGPA}");
            Console.WriteLine($"- Second year CGPA is {secondYearCGPA}");
            Console.WriteLine($"- Third year CGPA is {thirdYearCGPA}");
            Console.WriteLine($"- fourth year CGPA is {fourthYearCGPA}");

            double aggregateCGPA = (firstYearCGPA + secondYearCGPA + thirdYearCGPA + firstYearCGPA) / 4;

            return aggregateCGPA;

        }

    }
}
