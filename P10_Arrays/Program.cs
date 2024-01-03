using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arrays 
            // // Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.

            Console.WriteLine("Arrays");


            // 1. Create an Array and Access the Elements of an Array -
            // To declare an array, define the variable type with square brackets.
            // We have now declared a variable that holds an array of strings.
            // To insert values to it, we can use an array literal - place the values in a comma-separated list, inside curly braces.
            // You access an array element by referring to the index number.
            // This statement accesses the value of the first element in cars:

            Console.Write("\n\n1. Create an Array and Access the Elements of an Array - ");
            string[] cars1 = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars1[0]);


            // 2. Change an Array Element -
            // To change the value of a specific element, refer to the index number.

            Console.Write("\n\n2. Change an Array Element - ");
            string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
            cars2[3] = "Opel";
            Console.WriteLine(cars2[3]);


            // 3. Array Length -
            // To find out how many elements an array has, use the Length property.

            Console.Write("\n\n3. Array Length - ");
            string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars4.Length);


            // 4. Loop Through an Array -
            // You can loop through the array elements with the for loop, and use the Length property to specify how many times the loop should run.

            Console.WriteLine("\n\n4. Loop Through an Array - ");
            string[] cars5 = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars5.Length; i++)
            {
                Console.WriteLine(cars5[i]);
            }


            // 5. The foreach Loop -
            // There is also a foreach loop, which is used exclusively to loop through elements in an array.
            // The following example outputs all elements in the cars array, using a foreach loop:

            Console.WriteLine("\n\n5. The foreach Loop - ");
            string[] cars6 = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars6)
            {
                Console.WriteLine(i);
            }


            // 6. Sort an Array -
            // Sort(), which sorts an array alphabetically or in an ascending order.

            Console.WriteLine("\n\n6. Sort an Array - ");

            // Example 1 - Sort a string

            Console.WriteLine("\nExample 1 - Sort a string");
            string[] cars7 = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars7);
            foreach (string i in cars7)
            {
                Console.WriteLine(i);
            }

            // Example 2 - Sort an int

            Console.WriteLine("\nExample 2 - Sort an int");
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }


            // 7. Multidimensional Arrays -
            // A multidimensional array is basically an array of arrays.
            // Arrays can have any number of dimensions. The most common are two-dimensional arrays (2D).

            Console.WriteLine("\n\n7. Multidimensional Arrays - ");

            // (a) Access Elements of a 2D Array :
            // To create a 2D array, add each array within its own set of curly braces, and insert a comma (,) inside the square brackets.
            // To access an element of a two-dimensional array, you must specify two indexes: one for the array, and one for the element inside that array.
            // This statement accesses the value of the element in the first row (0) and third column (1) of the numbers array:

            Console.Write("\n(a) Access Elements of a 2D Array : ");
            int[,] numbers1 = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers1[0, 1]);

            // (b) Change Elements of a 2D Array :
            // You can also change the value of an element.
            // The following example will change the value of the element in the first row (0) and first column (0):

            Console.Write("\n(b) Change Elements of a 2D Array : ");
            int[,] numbers2 = { { 1, 4, 2 }, { 3, 6, 8 } };
            numbers2[0, 0] = 5;                      // Change value to 5
            Console.WriteLine(numbers2[0, 0]);

            // (c) Loop Through a 2D Array :

            Console.WriteLine("\n(c) Loop Through a 2D Array : ");

            // Example 1 - foreach loop
            // You can easily loop through the elements of a two-dimensional array with a foreach loop:

            Console.WriteLine("\nExample 1 - foreach loop");        
            int[,] numbers3 = { { 1, 4, 2 }, { 3, 6, 8 } };
            foreach (int i in numbers3)
            {
                Console.WriteLine(i);
            }

            // Example 2 - for loop  
            // You can also use a for loop. For multidimensional arrays, you need one loop for each of the array's dimensions.
            // Also note that we have to use GetLength() instead of Length to specify how many times the loop should run.

            Console.WriteLine("\nExample 2 - for loop");
            int[,] numbers4 = { { 1, 4, 2 }, { 3, 6, 8 } };

            for (int i = 0; i < numbers4.GetLength(0); i++)
            {
                for (int j = 0; j < numbers4.GetLength(1); j++)
                {
                    Console.WriteLine(numbers4[i, j]);
                }
            }

            Console.WriteLine();
        }
    }
}
