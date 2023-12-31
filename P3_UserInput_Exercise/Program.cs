using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_UserInput_Exercise
{
    class Program
    {
        static void Main(string[] args)

            //Input
        {
            string firstName, lastName, fullName, cityName, degreeName, collegeName;
            double firstYearCGPA, secondYearCGPA, thirdYearCGPA, fourthYearCGPA, aggregateCGPA;

            Console.Write("Enter your first name : ");
            firstName = Console.ReadLine();

            Console.Write("\nEnter your last name : ");
            lastName = Console.ReadLine();

            fullName = $"{firstName} {lastName}";

            Console.Write("\nEnter your city name : ");
            cityName = Console.ReadLine();

            Console.Write("\nEnter your degree name : ");
            degreeName = Console.ReadLine();

            Console.Write("\nEnter your college name : ");
            collegeName = Console.ReadLine();

            Console.Write("\nEnter your first year CGPA : ");
            firstYearCGPA = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEnter your second year CGPA : ");
            secondYearCGPA = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEnter your third year CGPA : ");
            thirdYearCGPA = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nEnter your fourth year CGPA : ");
            fourthYearCGPA = Convert.ToDouble(Console.ReadLine());

            aggregateCGPA = (firstYearCGPA + secondYearCGPA + thirdYearCGPA + fourthYearCGPA) / 4;


            // Output

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n\nMy Introduction ");
            Console.Write("\nHello everyone,");
            Console.Write($" I am {fullName}.");
            Console.Write($" I am from {cityName}.");
            Console.Write($" I have completed {degreeName} from {collegeName}.");
            Console.WriteLine("\nI have CGPA in each year as follows,");
            Console.WriteLine($"- First year CGPA is {firstYearCGPA}");
            Console.WriteLine($"- Second year CGPA is {secondYearCGPA}");
            Console.WriteLine($"- Third Year CGPA is {thirdYearCGPA}");
            Console.WriteLine($"- Fourth year CGPA is {fourthYearCGPA}");
            Console.WriteLine($"- My aggregate CGPA is {aggregateCGPA}");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
