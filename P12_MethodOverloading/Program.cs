using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {            
            Intro("Swati", "Jathar", 22);          // Method
            Console.WriteLine($"My percentage are {CalculatePercentage(80, 70, 90, 60)}.");    // Function

            Console.WriteLine();


            // Method overloading - Intro

            Intro("Swati", "Jathar", 22); 

            Intro("Swati J", 22);               // Method overload - Rule 1 - Change the number of parameter.

            Intro(22, "Swati J");               // Method overload - Rule 2 - Change the position of parameter.

            Intro(22.5, "Swati J");             // Method overload - Rule 3 - Change the datatype of parameter. --> (if you required same position).
        }


        // Method (void Method - Method with no return value)

        // Method overload
        static void Intro(string firstName, string lastName, int age)
        {
            string fullName = firstName + " " + lastName;

            Console.WriteLine("Hii,");
            Console.WriteLine($"My name is {fullName}.");
            Console.WriteLine($"My age is {age}.\n");
        }

        // Method overload - Rule 1 - Change the number of parameter.
        static void Intro(string fullName, int age)
        {
            Console.WriteLine("Rule 1 - Change the number of parameter.");
            Console.WriteLine("Hii,");
            Console.WriteLine($"My name is {fullName}.");
            Console.WriteLine($"My age is {age}.\n");
        }

        // Method overload - Rule 2 - Change the position of parameter.
        static void Intro(int age, string fullName)
        {
            Console.WriteLine("Rule 2 - Change the position of parameter.");
            Console.WriteLine("Hii,");
            Console.WriteLine($"My name is {fullName}.");
            Console.WriteLine($"My age is {age}.\n");
        }

        // Method overload - Rule 3 - Change the datatype of parameter if you required same position.
        static void Intro(double age, string fullName)
        {
            Console.WriteLine("Rule 3 - Change the datatype of parameter if you required same position.");
            Console.WriteLine("Hii,");
            Console.WriteLine($"My name is {fullName}.");
            Console.WriteLine($"My age is {age}.\n");
        }


        // Function (Method with return value)

        static double CalculatePercentage(int phyMarks, int chemMarks, int mathMarks, int bioMarks)
        {
            int totalMarks = phyMarks + chemMarks + mathMarks + bioMarks;

            double percentage = totalMarks / 4;

            return percentage;
        }
    }
}
