using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            // DataTypes:
            // A data type specifies the size and type of variable values.
            // A variable in C# must be a specified data type.

            // 1. int
            // Size -> 4 bytes
            // Stores whole numbers from -2,147,483,648 to 2,147,483,647.

            int num = 150000;



            // 2. long
            // Size -> 8 bytes
            // Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            // End the value with an "L".

            long num1 = 15000000000L;



            // 3. float 
            // Size -> 4 bytes
            // Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits.
            // End the value with an "F".

            float num2 = 6.45F;
            float f1 = 25e3F;               // A decimal point number can also be a scientific number with an "e" to indicate the power of 10.



            // 4. double 
            // Size -> 8 bytes
            // Stores fractional numbers. Sufficient for storing 15 decimal digits.
            // End the value with an "D".

            double num3 = 35.95D;
            double d1 = 15e4D;              // A decimal point number can also be a scientific number with an "e" to indicate the power of 10.



            // 5. bool 
            // Size -> 1 bit
            // Stores true or false values.

            bool isGoodMorning = true;
            bool isBadMorning = false;



            // 6. char 
            // Size -> 2 bytes
            // Stores a single character/letter, surrounded by single quotes.

            char myDiv = 'A';



            // 7. string 
            // Size -> 2 bytes per character.
            // Stores a sequence of characters, surrounded by double quotes.

            string myName = "Swati";




            // Type Casting:

            // Type casting is when you assign a value of one data type to another type.
            // In C#, there are two types of casting:


            // 1) Implicit Casting (automatically)
            //    Implicit casting is done automatically when passing a smaller size type to a larger size type.
            //    char -> int -> long -> float -> double

            Console.WriteLine("Implicit Casting:");

            int myRollNo1 = 26;
            double myRollNo2 = myRollNo1;               // Automatic casting: int to double

            Console.WriteLine(myRollNo1);
            Console.WriteLine(myRollNo2);


            // 2. Explicit Casting (manually):
            //    Explicit casting must be done manually by placing the type in parentheses in front of the value.
            //    double -> float -> long -> int -> char
            //    We can use type conversion methods for Explicit Casting.
            //    Type Conversion Methods - Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (for int) and Convert.ToInt64 (for long).

            Console.WriteLine("\nExplicit Casting:");

            double prise1 = 5.81;
            int prise2 = (int)prise1;
            int prise3 = Convert.ToInt32(prise1);        // Using Type Conversion Methods. (This round the number).

            Console.WriteLine(prise1);
            Console.WriteLine(prise2);
            Console.WriteLine(prise3);


            // More Examples for Explicit Casting:

            Console.WriteLine("\nMore Examples for Explicit Casting:");

            Console.WriteLine("\nConvert int to Boolean - ");
            int mynum1 = 25;
            bool mynum2 = Convert.ToBoolean(mynum1);            // convert int to Boolean
            Console.WriteLine(mynum2);


            Console.WriteLine("\nConvert double to string - ");
            double myDouble = 7.45;
            string s = Convert.ToString(myDouble);              // convert double to string
            Console.WriteLine(s);


            Console.WriteLine("\nConvert long to int - ");
            long myLong = 150;
            int i = Convert.ToInt32(myLong);                    // convert long to int
            Console.WriteLine(i);


            Console.WriteLine("\nConvert string to bool - ");
            string myStirng = "True";
            bool b = Convert.ToBoolean(myStirng);               // convert string to bool
            Console.WriteLine(b);


            Console.WriteLine("\nConvert long to string - ");
            long myNum2 = 75;
            string l = Convert.ToString(myNum2);                // convert long to string
            Console.WriteLine(l);

        }
    }
}
