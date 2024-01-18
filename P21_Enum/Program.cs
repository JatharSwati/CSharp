using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21_Enum
{
    class Program
    {
        // Enum
        // Enum is short for "enumerations", which means "specifically listed".
        // An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
        // To create an enum, use the enum keyword instead of class or interface.
        // Separate the enum items with a comma.

        // 1. Enum inside a Class:
        // You can access enum items with the dot syntax.

        // 2. Enum Values:
        // By default, the first item of an enum has the value 0.
        // The second has the value 1, and so on.
        // To get the integer value from an item, you must explicitly convert the item to an int.
        // You can also assign your own enum values, and the next items will update their numbers accordingly.

        // 3. Enum in a Switch Statement:
        // Enums are often used in switch statements to check for corresponding values

        static void Main(string[] args)
        {
            Console.WriteLine("Enum");

            Console.Write("1. Enum inside a Class: ");
            Level myVar = Level.Medium;                     // You can access enum items with the dot syntax.
            Console.WriteLine(myVar);

            Console.Write("2. Enum Values: ");
            int myNum = (int)Months.June;                   // To get the integer value from an item, you must explicitly convert the item to an int.
            Console.WriteLine(myNum);

            Console.Write("3. Enum in a Switch Statement: ");
            Color myColor = Color.White;
            switch(myColor)
            {
                case Color.Orange:
                    Console.Write("Orange color");
                    break;
                case Color.White:
                    Console.Write("White color");
                    break;
                case Color.Green:
                    Console.Write("Green color");
                    break;
                case Color.Blue:
                    Console.Write("Blue color");
                    break;
            }

            Console.WriteLine();

        }

        enum Level               // To create an enum, use the enum keyword instead of class or interface.
        {
            Low,                 // Separate the enum items with a comma.
            Medium,
            High
        }

    }

    enum Months
    {
        January,                 // 0 - By default, the first item of an enum has the value 0.
        February,                // 1
        March,                   // 2
        April=11,                // 11 - You can also assign your own enum values, and the next items will update their numbers accordingly.
        May,                     // 12
        June,                    // 13
        July                     // 14
    }

    enum Color
    {
        Orange,
        White,
        Green,
        Blue
    }

    // Why And When To Use Enums?
    // Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc.

}
