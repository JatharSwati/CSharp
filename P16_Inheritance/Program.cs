using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_Inheritance
{
    // Inheritance - 
    // It is possible to inherit fields and methods from one class to another.
    // Derived Class (child) - the class that inherits from another class
    // Base Class (parent) - the class being inherited from
    // To inherit from a class, use the : symbol.
    // sealed - If you don't want other classes to inherit from a class, use the sealed keyword:

    class Program
    {
        static void Main(string[] args)
        {
            Flowers mogra = new Flowers();
            mogra.name = "Rose";
            mogra.color = "Pink";
            mogra.shape = "open-cupped";
            mogra.GetFlowerInfo();

            FragranceFlowers rose = new FragranceFlowers();
            rose.name = "Mogra";
            rose.color = "White";
            rose.shape = "star-shaped";
            rose.fragrance = "Calm";
            rose.GetFragrance();
            mogra.GetFlowerInfo();                             // We can access the members of parent class in child class.
        }
    }

    // Flowers - Base Class (parent) - the class being inherited from
    class Flowers
    {
        public string name;
        public string color;
        public string shape;

        public void GetFlowerInfo()
        {
            Console.WriteLine($"{name} - {color} - {shape}");
        }
    }


    // FragranceFlowers - Derived Class (child) - the class that inherits from another class
    class FragranceFlowers : Flowers         // To inherit from a class, use the : symbol.
    {
        public string fragrance;

        public void GetFragrance()
        {
            Console.WriteLine($"{name} - {color} - {shape} - {fragrance}");
        }
    }


    // Types of Inheritance - 


    // 1. Single Inheritance 
    //   C# supports single inheritance, meaning a class can inherit from only one base class.     
    //   Example :

    class BaseClass
    {
        // Base class members
    }

    class DerivedClass : BaseClass      // Single Inheritance 
    {
        // Derived class members
    }


    // 2. Multiple Interface Inheritance
    //   While C# supports only single class inheritance, it allows a class to implement multiple interfaces.
    //   This is a form of multiple inheritance through interfaces.
    //   Providing a way to share method signatures between classes without the complexities associated with multiple class inheritance.
    //   Example :

    interface IFirstInterface
    {
        // Interface members
    }

    interface ISecondInterface
    {
        // Interface members
    }

    class MyClass : IFirstInterface, ISecondInterface       //  Multiple Interface Inheritance
    {
        // Class members implementing both interfaces
    }


    // 3. Multilevel Inheritance
    //   In multilevel inheritance, a class can inherit from another class, and then another class can inherit from the second class.
    //   This forms a chain of inheritance.
    //   Example :

    class Grandparent
    {
        // Grandparent class members
    }

    class Parent : Grandparent          // Multilevel Inheritance - Level 1
    {
        // Parent class members
    }

    class Child : Parent                // Multilevel Inheritance - Level 2
    {
        // Child class members
    }


    // 4. Hierarchical Inheritance
    //   In hierarchical inheritance, multiple classes derive from a single base class. 
    //   Each derived class is a specialization of the common base class.
    //   Example :

    class BaseClass1
    {
        // Base class members
    }

    class DerivedClass1 : BaseClass1
    {
        // Derived class 1 members
    }

    class DerivedClass2 : BaseClass1        // Hierarchical Inheritance - 1 Base (parent) class and 2 or more Derived (chlid)
    {
        // Derived class 2 members
    }


    // 5. Hybrid Inheritance
    //   Hybrid inheritance is a combination of any two or more types of inheritance.
    //   It is not directly supported in C#, but you can achieve it by combining single inheritance, multiple interface inheritance, multilevel inheritance, or hierarchical inheritance as needed.


    // Note: C# does not support multiple class inheritance, known as "multiple inheritance". 
    //      To avoid the diamond problem and maintain a simpler and more predictable language design.



}
