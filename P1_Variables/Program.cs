using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Variables:
            // Variables are containers for storing data values.

            int num = 20;                       // Creating Variables and assign value at same time.
            Console.WriteLine(num);

            int num1;                           // Creating Variables.
            num1 = 40;                          // Assign value to it.
            Console.WriteLine(num1);

            int num2 = 80;                      // Creating Variables.
            num2 = 60;                          // Assign a new value to an existing variable, it will overwrite the previous value
            Console.WriteLine(num2);


            // Variables with some other DataTypes:

            int rollNumber = 21;
            double price = 199.99;
            char myLetter = 'S';
            string myName = "Swati";
            bool myBool = true;



            // 2) Constants:
            // If you don't want others (or yourself) to overwrite existing values, you can add the const keyword in front of the variable type.
            // This will declare the variable as "constant", which means unchangeable and read-only.

            const double PI = 3.14159;          // You cannot declare a constant variable without assigning the value.
            // pi = 5.8;                        // You cannot change a value of constant.

            Console.WriteLine("Area of Sphere with 3 m Radius is " + 4 * PI * 3 * 3 + " meter square.");



            // 3) Display Variables:

            string name = "Swati";
            Console.WriteLine("Hello " + name);           // To combine both text and a variable, use the + character

            string firstName = "Swati ";
            string lastName = "Jathar";
            Console.WriteLine(firstName + lastName);      // Use the + character to join a variable to another variable if they are string.



            // 4) Multiple Variables:

            int x = 4, y = 6, z = 10;                  // To declare more than one variable of the same type, use a comma-separated list.
            Console.WriteLine( x + y + z);

            int p, q, r;
            p = q = r = 30;                            // You can also assign the same value to multiple variables in one line.
            Console.WriteLine(p + q + r);

            int a = 5;
            int b = 10;
            Console.WriteLine(a + b);                  // The + character works as a mathematical operator.



            // 5) Identifiers:
            // The general rules for naming variables are -
            // 1. Names can contain letters, digits and the underscore character (_). eg --> a-z, A-Z, 0-9, and _
            // 2. Names must begin with a letter or underscore. eg --> int num1 or string _name
            // 3. Names should start with a lowercase letter and it cannot contain whitespace. eg --> firstName, lastName
            // 4. Names are case sensitive ("myVar" and "myvar" are different variables)
            // 5. Reserved words (like C# keywords, such as int double, class, static, void) cannot be used as names.


        }
    }
}
