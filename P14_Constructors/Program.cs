using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_Constructors
{
    // Create a Car class
    class Car
    {
        public string model;            // Create a field
        public string color;            // Create a field
        public int year;                // Create a field
        public int weight;

        // Create a class constructor with multiple parameters for the Car class.
        public Car(string modelName, string modelColor, int modelYear, int modelWeight)
        {
            Console.WriteLine("Constructors\n");

            model = modelName;           // Set the initial value for model
            color = modelColor;          // Set the initial value for model
            year = modelYear;            // Set the initial value for model
            weight = modelWeight;        // Set the initial value for model
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Figo", "Black", 2010, 1016);          // Create an object of the Car Class (this will call the constructor).
            Console.WriteLine(Ford.model + " " + Ford.color + " " + Ford.year + " " + Ford.weight+"kg.");           // Print the value of model.

            Console.WriteLine();
        }
    }
}
