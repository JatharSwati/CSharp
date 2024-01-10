using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_Constructors
{
    // Constructor
    // 1. Constructor is a special method that is used to initialize (create) objects.
    // 2. Constructor always called when the object is created.
    // 3. Constructor can be used to set initial values for fields.
    // 4. Constructor name must match the class name.
    // 5. Constructor cannot have a return type (like void or int).
    // 6. Constructors can also take parameters, which is used to initialize fields.
    // 7. Just like other methods, constructors can be overloaded by using different numbers of parameters.
    // 8. All classes have constructors by default: if you do not create a class constructor yourself, C# creates one for you.



    class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car("Figo", "Black", 2010, 1016);                // 1. Constructor is a special method that is used to initialize (create) objects.
                                                                            // 2. Constructor always called when the object is created.

            Console.WriteLine($"{ford.model} - {ford.color} - {ford.year} - {ford.weight} kg");


            Car tata = new Car("Safari", 2017);                             // Car constructor 2nd overload.

            Console.WriteLine($"{tata.model} - {tata.year}");

            Console.WriteLine();
        }
    }

  

    class Car
    {
        public string model;            // Fields

        public string color;            

        public int year;                

        public int weight;


        public Car(string modelName, string modelColor, int modelYear, int modelWeight)     // 4. Constructor name must match the class name.
        {                                                                                   // 5. Constructor cannot have a return type (like void or int).
            model = modelName;                                                              
            color = modelColor;         
            year = modelYear;           
            weight = modelWeight;                                                           // 3. Constructor can be used to set initial values for fields.
        }   
        
        public Car(string modelName, int modelYear)                                         // 7. Just like other methods, constructors can be overloaded by using different numbers of parameters.
        {
            model = modelName;
            year = modelYear;
        }

    }
}
