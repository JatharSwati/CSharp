using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // Loops
            // Loops can execute a block of code as long as a specified condition is reached.
            // Loops are handy because they save time, reduce errors, and they make code more readable.

            Console.WriteLine("Loops");



            // 1. While Loop -
            // The while loop loops through a block of code as long as a specified condition is True.

            Console.WriteLine("\n1. While Loop - ");

            int i = 0;
            while (i < 4)
            {
                Console.WriteLine(i);
                i++;
            }



            // 2. The Do/While Loop -
            // The do/while loop is a variant of the while loop.
            // This loop will execute the code block once, before checking if the condition is true.
            // Then it will repeat the loop as long as the condition is true.

            Console.WriteLine("\n\n2. The Do/While Loop - ");

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 4);



            // 3. For Loop -
            // When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop.

            Console.WriteLine("\n\n3. For Loop - ");


            // Example 1 :

            Console.WriteLine("\nExample 1 : ");

            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine(k);
            }


            // Example 2 :

            Console.WriteLine("\nExample 2 : ");

            for (int l = 0; l <= 8; l = l + 2)
            {
                Console.WriteLine(l);
            }



            // 4. Nested Loops -
            // It is also possible to place a loop inside another loop. This is called a nested loop.
            // The "inner loop" will be executed one time for each iteration of the "outer loop".

            Console.WriteLine("\n\n4. Nested Loops - ");

            // Outer loop
            for (int m = 1; m <= 2; ++m)
            {
                Console.WriteLine("Outer: " + m);                 // Executes 2 times

                // Inner loop
                for (int n = 1; n <= 3; n++)
                {
                    Console.WriteLine(" Inner: " + n);            // Executes 6 times (2 * 3)
                }
            }



            // 5. Foreach Loop -
            // There is also a foreach loop, which is used exclusively to loop through elements in an array.

            Console.WriteLine("\n\n5. Foreach Loop - ");

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string p in cars)
            {
                Console.WriteLine(p);
            }



            // 6. Break and Continue -

            Console.WriteLine("\n\n6. Break and Continue - ");


            // (a) Break :
            // It was used to "jump out" of a switch statement.
            // The break statement can also be used to jump out of a loop.

            Console.WriteLine("\n(a) Break : ");

            for (int q = 0; q < 10; q++)
            {
                if (q == 4)
                {
                    break;
                }
                Console.WriteLine(q);
            }


            // (b) Continue :
            // The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.

            Console.WriteLine("\n(b) Continue : ");

            for (int r = 0; r < 10; r++)
            {
                if (r == 4)
                {
                    continue;
                }
                Console.WriteLine(r);
            }


            // (c) Break and Continue in While Loop :
            // You can also use break and continue in while loops.

            Console.WriteLine("\n(c) Break and Continue in While Loop : ");

            // Break Example

            Console.WriteLine("\nBreak Example");

            int s = 0;
            while (s < 10)
            {
                Console.WriteLine(s);
                s++;
                if (s == 4)
                {
                    break;
                }
            }

            // Continue Example

            Console.WriteLine("\nContinue Example");

            int t = 0;
            while (t < 10)
            {
                if (t == 4)
                {
                    t++;
                    continue;
                }
                Console.WriteLine(t);
                t++;
            }



        }
    }
}
