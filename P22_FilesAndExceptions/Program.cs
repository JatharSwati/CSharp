using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22_FilesAndExceptions
{
    // File:
    // Working With Files - The File class from the System.IO namespace, allows us to work with files.
    // The File class has many useful methods for creating and getting information about files.

    // Exceptions:
    // When executing C# code, different errors can occur.
    // Coding errors made by the programmer, errors due to wrong input, or other unforeseeable things.
    // When an error occurs, C# will normally stop and generate an error message.
    // The technical term for this is: C# will throw an exception (throw an error).

    // There are 3 statement in Exceptions:

    // 1) try statement - The try statement allows you to define a block of code to be tested for errors while it is being executed.
    // 2) catch statement - The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
    // 3) finally statement - The finally statement lets you execute code, after try...catch, regardless of the result.

    class Program
    {
        static void Main(string[] args)
        {
            try                             // 1) try statement - The try statement allows you to define a block of code to be tested for errors while it is being executed.
            {

                string path1 = "D:/MyFile.txt";
                string path2 = "D:/MyFile New.txt";

                if (File.Exists(path1))                                                      // File.Exists() - Tests whether the file exists.
                {
                    File.WriteAllText(path1, "Hi, I am Swati. This is my file project.");    // File.WriteAllText() - Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.

                    File.AppendAllText(path1, "\n\nThis text is appended to file.");         // File.AppendAllText() - Appends text at the end of an existing file.

                    string textAfterRead = File.ReadAllText(path1);                          // File.ReadAllText() - Reads the contents of a file.

                    Console.WriteLine(textAfterRead);

                    File.Copy(path1, path2);                                                 // File.Copy() - Copies a file.

                    File.Delete(path1);                                                      // File.Delete() - Deletes a file.
                    Console.WriteLine("Deleted old file.");
                }

                File.Create(path1);                                                          // File.Create() - Creates or overwrites a file.
                Console.WriteLine("Created new file.");
            }
            catch (Exception e)             // 2) catch statement - The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
            {
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Stack Trace: {e.StackTrace}");
            }
            finally                         // 3) finally statement - The finally statement lets you execute code, after try...catch, regardless of the result
            {
                Console.WriteLine("Finally block always executes.");
            }
        }
    }
}
