using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Strings -
            // Strings are used for storing text.
            // A string variable contains a collection of characters surrounded by double quotes.
            // A string in C# is actually an object.
            // Which contain properties and methods that can perform certain operations on strings.

            Console.WriteLine("1. Strings - ");

            string name = "Swati";
            string greeting = "Nice to meet you!";
            Console.WriteLine(name);                            // Output "Swati"
            Console.WriteLine(greeting);                        // Output "Nice to meet you!"


            // (a)  Strings properties :
            // The length of a string can be found with the Length property.

            Console.WriteLine("\n(a)  Strings properties : ");
            string text1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is " + text1.Length);      //Output "The length of the txt string is 26"


            // (b) Strings Methods :
            // There are many string methods available.
            // ToUpper() and ToLower(), which returns a copy of the string converted to uppercase or lowercase

            Console.WriteLine("\n(b) Strings Methods :");
            string text2 = "Welcome Swati";
            Console.WriteLine(text2.ToUpper());         // Output "WELCOME SWATI"
            Console.WriteLine(text2.ToLower());         // Output "welcome swati"



            // 2. String Concatenation -

            Console.WriteLine("\n\n\n2. String Concatenation - ");


            // (a) + operator :
            // The + operator can be used between strings to combine them. This is called concatenation.
            // C# uses the + operator for both addition and concatenation.

            Console.Write("\n(a) + operator : ");
            string firstName = "Swati ";
            string lastName = "Jathar";
            string fullName= firstName + lastName; 
            Console.WriteLine(fullName);                        // Output "Swati Jathar"


            // (b) string.Concat() method :
            // Use the string.Concat() method to concatenate two strings.
            Console.Write("\n(b) string.Concat() method : ");

            string var1 = "Hey ";
            string var2 = "Good Morning.";
            string var = string.Concat(var1, var2);
            Console.WriteLine(var);                             // Output "Hey Good Morning."


            // (c) Example Adding Numbers and Strings :

            Console.WriteLine("\n(c) Example Adding Numbers and Strings : ");

            // Numbers are added :

            Console.Write("\nNumbers are added : ");

            int x1 = 10;
            int y1 = 20;
            int z1 = x1 + y1;
            Console.WriteLine(z1);                         // Output "30"


            // Strings are concatenated :

            Console.Write("\nStrings are concatenated : ");

            string x2 = "10";
            string y2 = "20";
            string z2 = x2 + y2;
            Console.WriteLine(z2);                         // Output "1020"



            // 3. String Interpolation -
            // Another option of string concatenation, is string interpolation.
            // Which substitutes values of variables into placeholders in a string.

            Console.WriteLine("\n\n\n3. String Interpolation - ");

            string firstName1 = "Pradip";
            string lastName1 = "Jathar";
            string name1 = $"My full name is {firstName1} {lastName1}.";        // Output "My full name is Pradip Jathar"
            Console.WriteLine(name1);



            // 4. Access Strings - 
            // You can access the characters in a string by referring to its index number inside square brackets [].

            Console.WriteLine("\n\n\n4. Access Strings - ");


            // (a) Character position :
            // Access the characters in a string by referring to its index number inside square brackets [].

            Console.Write("\n(a) Character position : ");
            string myString1 = "Hello";
            Console.WriteLine(myString1[1]);                     // Output "e"


            // (b) Index position :

            Console.Write("\n(b) Index position : ");
            string myString2 = "Hello";
            Console.WriteLine(myString2.IndexOf("o"));            // Output "4"


            // (c) Substring() method :
            // Which extracts the characters from a string, starting from the specified character position/index, and returns a new string.
            // This method is often used together with IndexOf() to get the specific character position.

            Console.Write("\n(c) Substring() method : ");

            // Full name
            string name3 = "Shubhangi Gunjal";

            // Location of the letter G
            int charPos = name3.IndexOf("G");

            // Get last name
            string lastName3 = name3.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName3);                       // Output "Gunjal"



            // 5. Special Characters - 
            // Because strings must be written within quotes, C# will misunderstand this string, and generate an error.
            // string txt = "We are the so-called "Vikings" from the north.";
            // The solution to avoid this problem, is to use the backslash escape character.

            Console.WriteLine("\n\n\n5. Special Characters - ");

            // Backslash escape character
            // The backslash (\) escape character turns special characters into string characters.

            Console.WriteLine("\nBackslash escape character");


            // (a) Single quote :
            // \'       '       Single quote

            Console.Write("\n(a) Single quote : ");
            string text3 = "It\'s alright.";
            Console.WriteLine(text3);                   // Output "It's alright."


            // (b) Double quote :
            // \"       "       Double quote

            Console.Write("\n(b) Double quote : ");
            string text4 = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(text4);                    // Output " We are the so-called "Vikings" from the north."


            // (c) Backslash :
            // \\       \       Backslash

            Console.Write("\n(c) Backslash : ");
            string text5 = "The character \\ is called backslash.";          
            Console.WriteLine(text5);                    // Output "The character \ is called backslash."


            // (d) New Line :
            //  \n       New Line

            Console.WriteLine("\n(d) New Line : ");
            string text6 = "Hello\nWorld!";
            Console.WriteLine(text6);                    // Output "Hello"
                                                         //        "World"

            // (e) Tab :
            // \t       Tab

            Console.WriteLine("\n(e) Tab : ");
            string text7 = "Hello\tWorld!";
            Console.WriteLine(text7);                    // Output "Hello   World!"


            // (f) Backspace :
            // \b       Backspace

            Console.Write("\n(f) Backspace : ");
            string text8 = "He\bllo World!";
            Console.WriteLine(text8);                    // Output "Hllo World!"

            Console.WriteLine();
        }
    }
}
