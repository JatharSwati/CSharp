using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {

            // User Input - Console.ReadLine()

            // Example 1:

            Console.WriteLine("Example 1 - Full Name");

            string firstName, middleName, lastName, fullName;

            Console.WriteLine("\nEnter your first name: ");
            firstName = Console.ReadLine();                         // Get user input from the keyboard and store it in the variable.

            Console.WriteLine("\nEnter your middle name: ");
            middleName = Console.ReadLine();

            Console.WriteLine("\nEnter your last name: ");
            lastName = Console.ReadLine();

            fullName = firstName + " " + middleName + " " + lastName;

            Console.WriteLine("\nFull name is " + fullName);



            // User Input and Numbers
            // The Console.ReadLine() method returns a string.
            // Therefore, you cannot get information from another data type, such as int. 

            // Example 2:

            Console.WriteLine("\n\nExample 2 - Roll No. ");

            int rollNo;

            Console.WriteLine("\nEnter your roll number: ");
            rollNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYour roll number is " + rollNo);

        }
    }
}
