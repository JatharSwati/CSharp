using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_Polymorphism
{
    // Polymorphism:
    // Polymorphism means "many forms".
    // It occurs when we have many classes that are related to each other by inheritance.
    // There are two main types of polymorphism in C#:
    // 1. Compile-Time Polymorphism - Method Overloading
    // 2. Runtime Polymorphism - Overriding Methods

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Compile - Time Polymorphism - Method Overloading

            Console.WriteLine("1.Compile - Time Polymorphism - Method Overloading");

            Calculator calculator = new Calculator();

            int sum1 = calculator.Add(3, 5, 10);
            Console.WriteLine(sum1);

            double sum2 = calculator.Add(7, 15.35);         // Method overload - Rule 1 - Change the number of parameter.
            Console.WriteLine(sum2);

            double sum3 = calculator.Add(16.8, 6);          // Method overload - Rule 2 - Change the position of parameter.
            Console.WriteLine(sum3);

            double sum4 = calculator.Add(3.14, 9.81);       // Method overload - Rule 3 - Change the datatype of parameter.
            Console.WriteLine(sum4);

            Console.WriteLine("\n");



            // 2. Runtime Polymorphism - Overriding Methods

            Console.WriteLine("2. Runtime Polymorphism - Overriding Methods");

            Shape shape1 = new Shape();
            shape1.Draw();

            Shape shape2 = new Circle();        // We can use child class constructor to create object of base class. but we can not use base class constructor to create object of child class.
            shape2.Draw();

            Shape shape3 = new Triangle();
            shape3.Draw();

        }
    }


    // 1. Compile-Time Polymorphism - Method Overloading
    // Compile-time polymorphism is achieved through method overloading.
    // Method overloading allows you to define multiple methods with the same name but with different parameter lists.
    // The compiler determines the appropriate method to call based on the number and types of arguments provided during the method call.

    class Calculator
    {
        public int Add(int a, int b, int c)
        {
            return a + b;
        }

        public double Add(int a, double b)              // Method overload - Rule 1 - Change the number of parameter.
        {
            return a + b;
        }

        public double Add(double b, int a)              // Method overload - Rule 2 - Change the position of parameter.
        {
            return a + b;
        }

        public double Add(double a, double b)           // Method overload - Rule 3 - Change the datatype of parameter.
        {
            return a + b;
        }
    }


    // 2. Runtime Polymorphism - Overriding Methods
    // Runtime polymorphism is achieved through method overriding.
    // Inheritance allows a derived (child) class to provide a specific implementation of a method that is already defined in its base (parent) class.
    // To perform method overriding in C#, you need to use virtual keyword with base class method and override keyword with derived class method.

    class Shape
    {
        public virtual void Draw()                      // To perform method overriding in C#, use virtual keyword with base class method.
        {
            Console.WriteLine("Draw a shape.");
        }
    }


    class Circle : Shape
    {
        public override void Draw()                     // To perform method overriding in C#, use override keyword with derived class method.
        {
            Console.WriteLine("Draw a circle.");
        }
    }


    class Triangle : Shape
    {
        public override void Draw()                     // To perform method overriding in C#, use override keyword with derived class method.
        {
            Console.WriteLine("Draw a triangle.");
        }
    }
}
