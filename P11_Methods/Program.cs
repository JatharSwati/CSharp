using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Methods");


            Console.WriteLine("\n\n1. Create a method and call a method - ");            

            Console.WriteLine("\nExample 1 : When it is called.");
            MyMethod1();

            Console.WriteLine("\nExample 2 : A method can be called multiple times.");
            MyMethod2();
            MyMethod2();
            MyMethod2();


            Console.WriteLine("\n\n2. Method Parameters - ");                 

            Console.WriteLine("\n(a) Parameters and Arguments : ");
            MyMethod3("Swati");
            MyMethod3("Pradip");

            Console.WriteLine("\n(b) Multiple Parameters : ");
            MyMethod4("Swati", 22);
            MyMethod4("Pradip", 24);


            Console.WriteLine("\n\n3. Default Parameter Value - ");
            MyMethod5("Sweden");
            MyMethod5("India");
            MyMethod5();
            MyMethod5("USA");


            Console.Write("\n\n4. Return Values - ");
            Console.WriteLine(MyMethod6(3));

            Console.Write("\n(a) This example returns the sum of a method's two parameters : ");
            Console.WriteLine(MyMethod7(5, 8));

            Console.Write("\n(b) You can also store the result in a variable : ");
            int z = MyMethod8(5, 6);
            Console.WriteLine(z);


            Console.WriteLine("\n\n5. Named Arguments - ");
            MyMethod9(child3: "John", child1: "Liam", child2: "jenny");

            Console.WriteLine();

        }


        // Methods
        // A method is a block of code which only runs when it is called
        // You can pass data, known as parameters, into a method.
        // Methods are used to perform certain actions, and they are also known as functions.
        // Why use methods? To reuse code: define the code once, and use it many times.


        // 1. Create a Method and Call a Method -
        // A method is defined with the name of the method, followed by parentheses ().
        // C# provides some pre-defined methods, which you already are familiar with, such as Main().
        // To call (execute) a method, write the method's name followed by two parentheses () and a semicolon;

        // Example 1 :  When it is called
        static void MyMethod1()
        {
            Console.WriteLine("I just got executed!");
        }

        // Example 2 : A method can be called multiple times
        static void MyMethod2()
        {
            Console.WriteLine("Welcome!");
        }


        // 2. Method Parameters -

        // (a) Parameters and Arguments :
        // Information can be passed to methods as parameter.
        // Parameters act as variables inside the method.
        // They are specified after the method name, inside the parentheses.
        static void MyMethod3(string firstName1)
        {
            Console.WriteLine(firstName1 + " Jathar");
        }

        // (b) Multiple Parameters :
        // You can have as many parameters as you like, just separate them with commas.

        static void MyMethod4(string firstName2, int age)
        {
            Console.WriteLine(firstName2 + " age is " + age);
        }


        // 3. Default Parameter Value -
        // You can also use a default parameter value, by using the equals sign (=).
        // If we call the method without an argument, it uses the default value.
        // A parameter with a default value, is often known as an "optional parameter".

        static void MyMethod5(string country = "Norway")
        {
            Console.WriteLine(country);
        }


        // 4. Return Values -
        // In the previous examples, we used the void keyword in all examples, which indicates that the method should not return a value.
        // If you want the method to return a value, you can use a primitive data type instead of void, and use the return keyword inside the method.
        static int MyMethod6(int x1)
        {
            return 5 + x1;
        }

        // (a) This example returns the sum of a method's two parameters :
        static int MyMethod7(int x2, int y2)
        {
            return x2 + y2;
        }

        // (b) You can also store the result in a variable :
        static int MyMethod8(int x3, int y3)
        {
            return x3 + y3;
        }


        // 5. Named Arguments -
        // It is also possible to send arguments with the key: value syntax.
        // That way, the order of the arguments does not matter.

        static void MyMethod9(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is : " + child3);
        }
    }
}
