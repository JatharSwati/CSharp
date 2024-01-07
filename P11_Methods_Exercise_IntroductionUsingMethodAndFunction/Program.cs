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
            double[] allCGPA = { 9.45, 8.45, 7.45, 6.45 };

            Introduction("Swati", "Jathar", 22, "Sangmner", "Kuran", "Computer Engineering", "Jaihind College of Engineering, Kuran", skills, languages, strength, hobbies, allCGPA);
           

            Console.WriteLine();

        }

        static void Introduction(string firstName, string lastName, int age, string nativePlace, string currentLocation, string degreeName, string collegeName,
            string[] skills, string[] languages, string[] strengths, string[] hobbies, double[] allCGPA)
        {

            string fullName = firstName + " " + lastName;

            Console.Write("Hello everyone,");
            Console.Write($" My Name is {fullName}.");
            Console.Write($" I am {age} year's old.");
            Console.Write($" I am from {nativePlace} currently studing in {currentLocation}.");
            Console.Write($" I have completed my Bachelor's in {degreeName} technology from {collegeName}.");

            StringArrayToText(skills, "skills");
            StringArrayToText(languages, "languages");
            StringArrayToText(strengths, "strengths");
            StringArrayToText(hobbies, "hobbies");

            Console.WriteLine($"My aggregate CGPA is {TotalCGPA(allCGPA)}");
        }


        static void StringArrayToText(string[] input, string name)
        {
            Console.Write($"\nMy {name} are ");

            for (int i = 0; i < input.Length; i++)
            {
                string lastText = (i == input.Length - 1) ? "." : ", ";

                Console.Write($"{input[i]}{lastText}");
            }
        }


        static double TotalCGPA(double[] allCGPA)
        {

            Console.WriteLine("\nI have CGPA in each year as Follws, ");
            Console.WriteLine($"- First year CGPA is {allCGPA[0]}");
            Console.WriteLine($"- Second year CGPA is {allCGPA[1]}");
            Console.WriteLine($"- Third year CGPA is {allCGPA[2]}");
            Console.WriteLine($"- fourth year CGPA is {allCGPA[3]}");

            double aggregateCGPA = (allCGPA[0] + allCGPA[1] + allCGPA[2] + allCGPA[3]) / 4;

            return aggregateCGPA;

        }

    }
}
