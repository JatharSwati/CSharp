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
            // Method overloading - Intro

            Intro("Swati", "Jathar", 22); 

            Intro("Pradip Jathar", 24);               // Method overload - Rule 1 - Change the number of parameter.

            Intro(27, "Pravin Gunjal");               // Method overload - Rule 2 - Change the position of parameter.

            Intro(23.5, "Shubhangi Gunjal");          // Method overload - Rule 3 - Change the datatype of parameter. --> (if you required same position).
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

    }
}
